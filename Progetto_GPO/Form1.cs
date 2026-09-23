using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Progetto_GPO
{
    public partial class Form1 : Form
    {
        private Griglia griglia;

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

            for (int j = 0; j < griglia.Columns+1; j++)
            {
                DataGridViewTextBoxColumn colonna =
                    new DataGridViewTextBoxColumn();

                if(j < griglia.Columns) 
                { 
                    colonna.Name = "Consumatore" + (j + 1);

                    colonna.HeaderText =
                        "Consumatore " + (j + 1);

                   
                }
                else 
                {
                    colonna.Name = "Produzione";

                    colonna.HeaderText =
                        "Produzione";
                }

                colonna.SortMode =
                       DataGridViewColumnSortMode.NotSortable;

                colonna.MinimumWidth = 125;

                dataGridViewMatrice.Columns.Add(colonna);
            }

            for (int i = 0; i < griglia.Rows+1; i++)
            {
                int indiceRiga =
                    dataGridViewMatrice.Rows.Add();

                if (indiceRiga < griglia.Rows)
                {
                    dataGridViewMatrice
                        .Rows[indiceRiga]
                        .HeaderCell
                        .Value = "Produttore " + (i + 1);
                }else
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
                            griglia.ImpostaValore(
                                i,
                                j,
                                numero
                            );
                        }
                        else
                        {
                            griglia.ImpostaValore(
                                i,
                                j,
                                0
                            );
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

            Random random = new Random();

            for (int i = 0; i < griglia.Rows; i++)
            {
                for (int j = 0; j < griglia.Columns; j++)
                {
                    int valore =
                        random.Next(
                            costoMin,
                            costoMax + 1
                        );

                    griglia.ImpostaValore(
                        i,
                        j,
                        valore
                    );

                    dataGridViewMatrice
                        .Rows[i]
                        .Cells[j]
                        .Value = valore;
                }
            }
        }

        private void btnRisolviQuattroMetodi_Click(
            object sender,
            EventArgs e)
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

            SalvaDatiMatrice();

            MessageBox.Show(
                "Matrice acquisita correttamente.\n\n"
                + "Pronta per l'applicazione dei quattro metodi.",
                "Risoluzione",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
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
                        griglia.ImpostaValore(
                            i,
                            j,
                            numero
                        );
                    }
                    else
                    {
                        griglia.ImpostaValore(
                            i,
                            j,
                            0
                        );
                    }
                }
            }
        }
    }
}