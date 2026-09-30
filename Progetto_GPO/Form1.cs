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
            groupBoxProduttoriConsumatori.Location = new Point(0, 12);
            groupBoxDatiExcel.Location = new Point(0, groupBoxProduttoriConsumatori.Bottom + 10);
            groupBoxValoriCasuali.Location = new Point(0, groupBoxDatiExcel.Bottom + 10);
            btnRisolvi.Location = new Point(0, groupBoxValoriCasuali.Bottom + 10);
            AbilitaAutoSelezioneNumericUpDown(this);

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
            dataGridViewMatrice.RowHeadersWidth = 145;
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
                    colonna.Name = "CONSUMATORE" + (j + 1);
                    colonna.HeaderText = "CONSUMATORE " + (j + 1);
                }
                else
                {
                    colonna.Name = "PRODUZIONE";
                    colonna.HeaderText = "PRODUZIONE";
                }

                colonna.SortMode =
                    DataGridViewColumnSortMode.NotSortable;

                colonna.MinimumWidth = 135;

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
                        .Value = "PRODUTTORE " + (i + 1);
                }
                else
                {
                    dataGridViewMatrice
                        .Rows[indiceRiga]
                        .HeaderCell
                        .Value = "FABBIOSOGNO";
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

        // INCOLLA EXCELL
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

            if (!Clipboard.ContainsText())
            {
                MessageBox.Show(
                    "Negli appunti non c'è nessun testo. Copia prima un intervallo da Excel.",
                    "Attenzione",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            int n = griglia.Rows;
            int m = griglia.Columns;

            int rigaInizio = 0;
            int colonnaInizio = 0;

            if (dataGridViewMatrice.CurrentCell != null)
            {
                rigaInizio = dataGridViewMatrice.CurrentCell.RowIndex;
                colonnaInizio = dataGridViewMatrice.CurrentCell.ColumnIndex;
            }

            string testo = Clipboard.GetText().Replace("\r\n", "\n").Replace("\r", "\n");
            string[] righe = testo.Split('\n');

            int numeroRighe = righe.Length;

            while (numeroRighe > 0 && string.IsNullOrWhiteSpace(righe[numeroRighe - 1]))
            {
                numeroRighe--;
            }

            if (numeroRighe == 0)
            {
                MessageBox.Show(
                    "Gli appunti sono vuoti.",
                    "Attenzione",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            List<int[]> valori = new List<int[]>();
            int larghezzaMax = 0;

            for (int r = 0; r < numeroRighe; r++)
            {
                string[] celle = righe[r].Split('\t');
                int[] riga = new int[celle.Length];

                for (int c = 0; c < celle.Length; c++)
                {
                    string cella = celle[c].Trim();

                    if (cella == "")
                    {
                        riga[c] = 0;
                    }
                    else if (!int.TryParse(cella, out riga[c]) || riga[c] < 0)
                    {
                        MessageBox.Show(
                            "Valore non valido \"" + cella + "\" alla riga " + (r + 1) +
                            ", colonna " + (c + 1) + " dei dati copiati.\n\n" +
                            "Sono ammessi solo numeri interi maggiori o uguali a zero.",
                            "Errore",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );

                        return;
                    }
                }

                valori.Add(riga);
                larghezzaMax = Math.Max(larghezzaMax, celle.Length);
            }

            if (rigaInizio + numeroRighe > n + 1 || colonnaInizio + larghezzaMax > m + 1)
            {
                MessageBox.Show(
                    "I dati copiati (" + numeroRighe + " righe x " + larghezzaMax + " colonne) " +
                    "non entrano nella tabella a partire dalla cella selezionata.\n\n" +
                    "La tabella ha " + n + " produttori e " + m + " consumatori: " +
                    "seleziona la cella in alto a sinistra e ricontrolla le dimensioni.",
                    "Errore",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            for (int r = 0; r < valori.Count; r++)
            {
                for (int c = 0; c < valori[r].Length; c++)
                {
                    int riga = rigaInizio + r;
                    int colonna = colonnaInizio + c;

                    if (riga == n && colonna == m)
                    {
                        continue;
                    }

                    dataGridViewMatrice.Rows[riga].Cells[colonna].Value = valori[r][c];
                }
            }

            SalvaDatiMatrice();

            int sommaProduzioni = LeggiProduzioni().Sum();
            int sommaFabbisogni = LeggiFabbisogni().Sum();

            dataGridViewMatrice.Rows[n].Cells[m].Value = sommaProduzioni;

            string avviso = "";

            if (sommaProduzioni != sommaFabbisogni)
            {
                avviso = "\n\nAttenzione: la produzione totale (" + sommaProduzioni +
                         ") è diversa dal fabbisogno totale (" + sommaFabbisogni +
                         "). Il problema non è bilanciato.";
            }

            MessageBox.Show(
                "Dati incollati correttamente." + avviso,
                "Operazione completata",
                MessageBoxButtons.OK,
                avviso == "" ? MessageBoxIcon.Information : MessageBoxIcon.Warning
            );
        }

        // GENERAZIONE CASUALE
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

        // DATA GRID
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

        // RISOLUTORE
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

        private void AbilitaAutoSelezioneNumericUpDown(Control contenitore)
        {
            foreach (Control c in contenitore.Controls)
            {
                // Se il controllo è un NumericUpDown, gli assegna il comportamento
                if (c is NumericUpDown nud)
                {
                    nud.Enter += (sender, e) => nud.Select(0, nud.Text.Length);
                    nud.Click += (sender, e) => nud.Select(0, nud.Text.Length);
                }
                // Se contiene altri controlli (es. è dentro un GroupBox), cerca anche lì dentro
                else if (c.HasChildren)
                {
                    AbilitaAutoSelezioneNumericUpDown(c);
                }
            }
        }
    }
}