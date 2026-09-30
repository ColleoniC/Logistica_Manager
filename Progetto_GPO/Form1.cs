using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Progetto_GPO
{
    public partial class Form1 : Form
    {
        private Griglia griglia;
        private readonly Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            groupBoxProduttoriConsumatori.Location = new Point(12, 12);
            groupBoxDatiExcel.Location = new Point(12, groupBoxProduttoriConsumatori.Bottom + 10);
            groupBoxValoriCasuali.Location = new Point(12, groupBoxDatiExcel.Bottom + 10);
            btnRisolviQuattroMetodi.Location = new Point(12, groupBoxValoriCasuali.Bottom + 10);

            ConfiguraDataGridView();
        }

        private void ConfiguraDataGridView()
        {
            dataGridViewMatrice.AllowUserToAddRows = false;
            dataGridViewMatrice.AllowUserToDeleteRows = false;
            dataGridViewMatrice.AllowUserToResizeRows = false;

            dataGridViewMatrice.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewMatrice.RowHeadersVisible = true;

            dataGridViewMatrice.SelectionMode =
                DataGridViewSelectionMode.CellSelect;

            dataGridViewMatrice.MultiSelect = false;
            dataGridViewMatrice.RowHeadersWidth = 125;
        }

        private void btnCreaMatrice_Click(object sender, EventArgs e)
        {
            int numeroProduttori =
                (int)numericNumeroProduttori.Value;

            int numeroConsumatori =
                (int)numericNumeroConsumatori.Value;

            griglia = new Griglia(
                numeroConsumatori,
                numeroProduttori
            );

            MostraGriglia();
        }

        private void MostraGriglia()
        {
            if (griglia == null)
            {
                return;
            }

            dataGridViewMatrice.Columns.Clear();
            dataGridViewMatrice.Rows.Clear();

            for (int j = 0; j < griglia.Columns + 1; j++)
            {
                DataGridViewTextBoxColumn colonna =
                    new DataGridViewTextBoxColumn();

                if (j < griglia.Columns)
                {
                    colonna.Name = "Consumatore" + (j + 1);
                    colonna.HeaderText = "Consumatore " + (j + 1);
                }
                else
                {
                    colonna.Name = "Produzione";
                    colonna.HeaderText = "Produzione";
                }

                colonna.SortMode =
                    DataGridViewColumnSortMode.NotSortable;

                colonna.MinimumWidth = 125;

                dataGridViewMatrice.Columns.Add(colonna);
            }

            for (int i = 0; i < griglia.Rows + 1; i++)
            {
                int indiceRiga =
                    dataGridViewMatrice.Rows.Add();

                if (indiceRiga < griglia.Rows)
                {
                    dataGridViewMatrice
                        .Rows[indiceRiga]
                        .HeaderCell
                        .Value = "Produttore " + (i + 1);
                }
                else
                {
                    dataGridViewMatrice
                        .Rows[indiceRiga]
                        .HeaderCell
                        .Value = "Fabbisogno";
                }
            }

            dataGridViewMatrice.Rows[griglia.Rows].Cells[griglia.Columns].Style.BackColor = Color.LightBlue;

            for (int i = 0; i < griglia.Rows; i++)
            {
                for (int j = 0; j < griglia.Columns; j++)
                {
                    dataGridViewMatrice
                        .Rows[i]
                        .Cells[j]
                        .Value = griglia.Grid[i][j];
                }
            }
        }

        private void btnIncolla_Click(object sender, EventArgs e)
        {
            if (griglia == null)
            {
                MessageBox.Show(
                    "Prima devi creare la matrice.",
                    "Attenzione",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                for (int i = 0; i < griglia.Rows; i++)
                {
                    for (int j = 0; j < griglia.Columns; j++)
                    {
                        object valore =
                            dataGridViewMatrice
                                .Rows[i]
                                .Cells[j]
                                .Value;

                        if (valore != null &&
                            int.TryParse(
                                valore.ToString(),
                                out int numero))
                        {
                            griglia.ImpostaValore(i, j, numero);
                        }
                        else
                        {
                            griglia.ImpostaValore(i, j, 0);
                        }
                    }
                }

                MessageBox.Show(
                    "Dati inseriti correttamente.",
                    "Operazione completata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Errore durante l'inserimento dei dati:\n\n"
                    + ex.Message,
                    "Errore",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        public static bool RangeFattibile(int n, int m, int min, int max)
        {
            return Math.Max(n, m) * min <= Math.Min(n, m) * max;
        }

        private static int MaxMinimoNecessario(int n, int m, int min)
        {
            int a = Math.Max(n, m);
            int b = Math.Min(n, m);
            return (int)Math.Ceiling((double)a * min / b);
        }

        private int[] Distribuisci(int count, int totale, int min, int max)
        {
            int[] valori = Enumerable.Repeat(min, count).ToArray();
            int resto = totale - count * min;
            List<int> liberi = Enumerable.Range(0, count).ToList();

            while (resto > 0)
            {
                int k = liberi[random.Next(liberi.Count)];
                int capacita = max - valori[k];
                int aggiunta = random.Next(1, Math.Min(capacita, resto) + 1);
                valori[k] += aggiunta;
                resto -= aggiunta;

                if (valori[k] == max)
                {
                    liberi.Remove(k);
                }
            }

            return valori;
        }

        private void btnGenera_Click(object sender, EventArgs e)
        {
            if (griglia == null)
            {
                MessageBox.Show(
                    "Prima devi creare la matrice.",
                    "Attenzione",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            int costoMin =
                (int)numericRangeCostiMin.Value;

            int costoMax =
                (int)numericRangeCostiMax.Value;

            if (costoMin > costoMax)
            {
                MessageBox.Show(
                    "Il costo minimo non può essere maggiore del costo massimo.",
                    "Errore",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            int unitaMin =
                (int)numericRangeProdMin.Value;

            int unitaMax =
                (int)numericRangeProdMax.Value;

            if (unitaMin > unitaMax)
            {
                MessageBox.Show(
                    "Il numero di unità minimo non può essere maggiore del numero di unità massimo.",
                    "Errore",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            if (unitaMin <= 0)
            {
                MessageBox.Show(
                    "Il numero di unità minimo deve essere maggiore di zero.",
                    "Errore",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            int n = griglia.Rows;
            int m = griglia.Columns;

            if (!RangeFattibile(n, m, unitaMin, unitaMax))
            {
                int maxNecessario = MaxMinimoNecessario(n, m, unitaMin);

                MessageBox.Show(
                    "Il range " + unitaMin + "-" + unitaMax +
                    " non è compatibile con " + n + " produttori e " + m + " consumatori: " +
                    "le somme di produzione e fabbisogno non possono coincidere.\n\n" +
                    "Con minimo " + unitaMin + " il massimo deve essere almeno " +
                    maxNecessario + ".",
                    "Range non valido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int valore =
                        random.Next(
                            costoMin,
                            costoMax + 1
                        );

                    griglia.ImpostaValore(i, j, valore);

                    dataGridViewMatrice
                        .Rows[i]
                        .Cells[j]
                        .Value = valore;
                }
            }

            int totMin = Math.Max(n, m) * unitaMin;
            int totMax = Math.Min(n, m) * unitaMax;
            int totale = random.Next(totMin, totMax + 1);

            int[] produzioni = Distribuisci(n, totale, unitaMin, unitaMax);
            int[] fabbisogni = Distribuisci(m, totale, unitaMin, unitaMax);

            for (int i = 0; i < n; i++)
            {
                dataGridViewMatrice.Rows[i].Cells[m].Value = produzioni[i];
            }

            for (int j = 0; j < m; j++)
            {
                dataGridViewMatrice.Rows[n].Cells[j].Value = fabbisogni[j];
            }

            dataGridViewMatrice.Rows[n].Cells[m].Value = totale;
        }

        private int[] LeggiProduzioni()
        {
            int[] produzioni = new int[griglia.Rows];

            for (int i = 0; i < griglia.Rows; i++)
            {
                object valore = dataGridViewMatrice.Rows[i].Cells[griglia.Columns].Value;

                produzioni[i] =
                    valore != null && int.TryParse(valore.ToString(), out int numero)
                        ? numero
                        : 0;
            }

            return produzioni;
        }

        private int[] LeggiFabbisogni()
        {
            int[] fabbisogni = new int[griglia.Columns];

            for (int j = 0; j < griglia.Columns; j++)
            {
                object valore = dataGridViewMatrice.Rows[griglia.Rows].Cells[j].Value;

                fabbisogni[j] =
                    valore != null && int.TryParse(valore.ToString(), out int numero)
                        ? numero
                        : 0;
            }

            return fabbisogni;
        }

        private void btnRisolviQuattroMetodi_Click(
            object sender,
            EventArgs e)
        {
            if (griglia == null)
            {
                MessageBox.Show(
                    "E' necessario creare la matrice.",
                    "Attenzione",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            SalvaDatiMatrice();

            // IMPLEMENTA METODO N-O
            // int[] produzioni = LeggiProduzioni();
            // int[] fabbisogni = LeggiFabbisogni();
        }

        private void SalvaDatiMatrice()
        {
            if (griglia == null)
            {
                return;
            }

            for (int i = 0; i < griglia.Rows; i++)
            {
                for (int j = 0; j < griglia.Columns; j++)
                {
                    object valore =
                        dataGridViewMatrice
                            .Rows[i]
                            .Cells[j]
                            .Value;

                    if (valore != null &&
                        int.TryParse(
                            valore.ToString(),
                            out int numero))
                    {
                        griglia.ImpostaValore(i, j, numero);
                    }
                    else
                    {
                        griglia.ImpostaValore(i, j, 0);
                    }
                }
            }
        }
    }
}