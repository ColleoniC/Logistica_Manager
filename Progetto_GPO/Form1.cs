using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progetto_GPO
{
    public partial class Form1 : Form
    {
        private const int RitardoSalto = 500;
        private const int RitardoEvidenziazione = 700;
        private const int RitardoTrasferimento = 1000;

        private static readonly CultureInfo CulturaItaliana = CultureInfo.GetCultureInfo("it-IT");

        private static readonly Regex RegexMigliaia =
            new Regex(@"^[0-9]{1,3}([.,'’])[0-9]{3}(\1[0-9]{3})*$");

        private Griglia griglia;
        private readonly Random random = new Random();

        private bool risoluzioneInCorso;
        private StringBuilder procedimento;
        private string ultimoProcedimento;
        private long costoParziale;
        private int passaggiEseguiti;
        private CancellationTokenSource annullamento;

        private object valorePrecedenteCella;

        public Form1()
        {
            InitializeComponent();

            try
            {
                this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            }
            catch (ArgumentException)
            {
            }

            AbilitaAutoSelezioneNumericUpDown(this);
            ConfiguraDataGridView();

            AggiornaEtichettaCosto(null);
            AggiornaStato("Imposta produttori e consumatori, poi premi CREA MATRICE.", "");
        }

        private void ConfiguraDataGridView()
        {
            dataGridViewMatrice.AllowUserToAddRows = false;
            dataGridViewMatrice.AllowUserToDeleteRows = false;
            dataGridViewMatrice.AllowUserToResizeRows = false;
            dataGridViewMatrice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMatrice.RowHeadersVisible = true;
            dataGridViewMatrice.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewMatrice.MultiSelect = false;
            dataGridViewMatrice.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
        }

        private void btnCreaMatrice_Click(object sender, EventArgs e)
        {
            if (risoluzioneInCorso)
            {
                return;
            }

            int numeroProduttori = (int)numericNumeroProduttori.Value;
            int numeroConsumatori = (int)numericNumeroConsumatori.Value;

            griglia = new Griglia(numeroConsumatori, numeroProduttori);

            MostraGriglia();
            InvalidaSoluzione();

            AggiornaStato(
                "Matrice " + numeroProduttori + " × " + numeroConsumatori +
                " creata. Inserisci costi, produzioni e fabbisogni.",
                "");
        }

        private void MostraGriglia()
        {
            if (griglia == null)
            {
                return;
            }

            int n = griglia.Rows;
            int m = griglia.Columns;

            dataGridViewMatrice.Columns.Clear();
            dataGridViewMatrice.Rows.Clear();

            for (int j = 0; j <= m; j++)
            {
                DataGridViewTextBoxColumn colonna = new DataGridViewTextBoxColumn();

                if (j < m)
                {
                    colonna.Name = "CONSUMATORE" + (j + 1);
                    colonna.HeaderText = "CONSUMATORE " + (j + 1);
                }
                else
                {
                    colonna.Name = "PRODUZIONE";
                    colonna.HeaderText = "PRODUZIONE";
                }

                colonna.SortMode = DataGridViewColumnSortMode.NotSortable;
                colonna.MinimumWidth = 150;

                dataGridViewMatrice.Columns.Add(colonna);
            }

            for (int i = 0; i <= n; i++)
            {
                int indiceRiga = dataGridViewMatrice.Rows.Add();

                dataGridViewMatrice.Rows[indiceRiga].HeaderCell.Value =
                    indiceRiga < n ? "PRODUTTORE " + (i + 1) : "FABBISOGNO";
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dataGridViewMatrice.Rows[i].Cells[j].Value = griglia.Grid[i][j];
                }
            }

            dataGridViewMatrice.Rows[n].Cells[m].ReadOnly = true;

            ApplicaStiliGriglia();
            AggiornaCellaTotale();
        }

        private void ApplicaStiliGriglia()
        {
            if (griglia == null)
            {
                return;
            }

            int n = griglia.Rows;
            int m = griglia.Columns;

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= m; j++)
                {
                    ApplicaStileBase(i, j);
                    dataGridViewMatrice.Rows[i].Cells[j].ToolTipText = "";
                }
            }

            for (int i = 0; i <= n; i++)
            {
                DataGridViewCellStyle stile = dataGridViewMatrice.Rows[i].HeaderCell.Style;
                stile.BackColor = i == n ? Tema.IntestazioneSpeciale : Tema.Intestazione;
                stile.SelectionBackColor = stile.BackColor;
                stile.ForeColor = Tema.TestoChiaro;
                stile.SelectionForeColor = Tema.TestoChiaro;
            }

            for (int j = 0; j <= m; j++)
            {
                DataGridViewCellStyle stile = dataGridViewMatrice.Columns[j].HeaderCell.Style;
                stile.BackColor = j == m ? Tema.IntestazioneSpeciale : Tema.Intestazione;
                stile.SelectionBackColor = stile.BackColor;
                stile.ForeColor = Tema.TestoChiaro;
                stile.SelectionForeColor = Tema.TestoChiaro;
            }

            dataGridViewMatrice.Refresh();
        }

        private void ApplicaStileBase(int riga, int colonna)
        {
            DataGridViewCell cella = dataGridViewMatrice.Rows[riga].Cells[colonna];

            bool rigaFabbisogno = riga == griglia.Rows;
            bool colonnaProduzione = colonna == griglia.Columns;

            Color sfondo;
            Color testo = Tema.TestoCella;
            Font font = Tema.FontCella;

            if (rigaFabbisogno && colonnaProduzione)
            {
                sfondo = Tema.CellaTotale;
                testo = Tema.TestoChiaro;
                font = Tema.FontCellaGrassetto;
            }
            else if (colonnaProduzione)
            {
                sfondo = Tema.CellaProduzione;
                font = Tema.FontCellaGrassetto;
            }
            else if (rigaFabbisogno)
            {
                sfondo = Tema.CellaFabbisogno;
                font = Tema.FontCellaGrassetto;
            }
            else
            {
                sfondo = Tema.CellaCosto;
            }

            cella.Style.BackColor = sfondo;
            cella.Style.ForeColor = testo;
            cella.Style.Font = font;
            cella.Style.SelectionBackColor = rigaFabbisogno && colonnaProduzione ? sfondo : Tema.Selezione;
            cella.Style.SelectionForeColor = rigaFabbisogno && colonnaProduzione ? testo : Tema.Intestazione;
        }

        private void EvidenziaRigaColonna(int riga, int colonna)
        {
            for (int j = 0; j < dataGridViewMatrice.Columns.Count; j++)
            {
                DataGridViewCell cella = dataGridViewMatrice.Rows[riga].Cells[j];
                cella.Style.BackColor = Tema.Evidenziazione;
                cella.Style.ForeColor = Tema.TestoCella;
            }

            for (int i = 0; i < dataGridViewMatrice.Rows.Count; i++)
            {
                DataGridViewCell cella = dataGridViewMatrice.Rows[i].Cells[colonna];
                cella.Style.BackColor = Tema.Evidenziazione;
                cella.Style.ForeColor = Tema.TestoCella;
            }

            DataGridViewCell cellaCorrente = dataGridViewMatrice.Rows[riga].Cells[colonna];
            cellaCorrente.Style.BackColor = Tema.EvidenziazioneCella;
            cellaCorrente.Style.SelectionBackColor = Tema.EvidenziazioneCella;
            cellaCorrente.Style.ForeColor = Tema.TestoCella;
            cellaCorrente.Style.SelectionForeColor = Tema.TestoCella;

            dataGridViewMatrice.CurrentCell = cellaCorrente;
            dataGridViewMatrice.Refresh();
        }

        private void MostraAllocazioni(int[,] allocazioni)
        {
            for (int i = 0; i < griglia.Rows; i++)
            {
                for (int j = 0; j < griglia.Columns; j++)
                {
                    if (allocazioni[i, j] <= 0)
                    {
                        continue;
                    }

                    DataGridViewCell cella = dataGridViewMatrice.Rows[i].Cells[j];
                    long costo = (long)griglia.Grid[i][j] * allocazioni[i, j];

                    cella.Style.BackColor = Tema.CellaAllocata;
                    cella.Style.ForeColor = Tema.TestoAllocata;
                    cella.Style.Font = Tema.FontCellaGrassetto;
                    cella.ToolTipText =
                        allocazioni[i, j] + " unità × " + griglia.Grid[i][j] +
                        " € = " + FormattaEuro(costo);
                }
            }

            dataGridViewMatrice.Refresh();
        }

        private void RipristinaVisibilita()
        {
            foreach (DataGridViewRow riga in dataGridViewMatrice.Rows)
            {
                riga.Visible = true;
            }

            foreach (DataGridViewColumn colonna in dataGridViewMatrice.Columns)
            {
                colonna.Visible = true;
            }
        }

        private void AggiornaCellaTotale()
        {
            if (griglia == null)
            {
                return;
            }

            int n = griglia.Rows;
            int m = griglia.Columns;

            long sommaProduzioni = LeggiProduzioni().Sum(x => (long)x);
            long sommaFabbisogni = LeggiFabbisogni().Sum(x => (long)x);

            DataGridViewCell cella = dataGridViewMatrice.Rows[n].Cells[m];
            cella.Value = sommaProduzioni;

            ApplicaStileBase(n, m);

            if (sommaProduzioni != sommaFabbisogni)
            {
                cella.Style.BackColor = Tema.CellaTotaleSbilanciata;
                cella.Style.SelectionBackColor = Tema.CellaTotaleSbilanciata;
                cella.ToolTipText =
                    "Problema non bilanciato: produzione " + sommaProduzioni +
                    ", fabbisogno " + sommaFabbisogni + ".";
            }
            else
            {
                cella.ToolTipText = "Problema bilanciato.";
            }
        }

        private bool EUnaCellaTotale(int riga, int colonna)
        {
            return griglia != null && riga == griglia.Rows && colonna == griglia.Columns;
        }

        private void dataGridViewMatrice_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (griglia == null || risoluzioneInCorso || EUnaCellaTotale(e.RowIndex, e.ColumnIndex))
            {
                e.Cancel = true;
                return;
            }

            valorePrecedenteCella = dataGridViewMatrice.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        private void dataGridViewMatrice_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (griglia == null || risoluzioneInCorso || !dataGridViewMatrice.IsCurrentCellInEditMode)
            {
                return;
            }

            string testo = Convert.ToString(e.FormattedValue);

            if (string.IsNullOrWhiteSpace(testo))
            {
                return;
            }

            int valore;

            if (ProvaLeggiIntero(testo, out valore))
            {
                return;
            }

            e.Cancel = true;

            if (dataGridViewMatrice.EditingControl != null)
            {
                dataGridViewMatrice.EditingControl.Text = Convert.ToString(valorePrecedenteCella);
            }

            BeginInvoke((Action)(() => MessageBox.Show(
                "Valore non valido: \"" + testo + "\".\n\n" +
                "Sono ammessi solo numeri interi maggiori o uguali a zero.\n" +
                "È stato ripristinato il valore precedente.",
                "Valore non valido",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)));
        }

        private void dataGridViewMatrice_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (griglia == null || risoluzioneInCorso)
            {
                return;
            }

            DataGridViewCell cella = dataGridViewMatrice.Rows[e.RowIndex].Cells[e.ColumnIndex];

            int numero;

            if (!ProvaLeggiIntero(Convert.ToString(cella.Value), out numero))
            {
                numero = 0;
            }

            cella.Value = numero;

            bool cambiato = Convert.ToString(valorePrecedenteCella) != numero.ToString();

            SalvaDatiMatrice();
            AggiornaCellaTotale();

            if (cambiato)
            {
                InvalidaSoluzione();
            }
        }

        public static bool ProvaLeggiIntero(string testo, out int valore)
        {
            valore = 0;

            if (testo == null)
            {
                return false;
            }

            StringBuilder pulito = new StringBuilder(testo.Length);

            foreach (char c in testo)
            {
                if (!char.IsWhiteSpace(c))
                {
                    pulito.Append(c);
                }
            }

            string cifre = pulito.ToString();

            if (cifre.Length == 0)
            {
                return false;
            }

            if (RegexMigliaia.IsMatch(cifre))
            {
                cifre = Regex.Replace(cifre, "[.,'’]", "");
            }

            foreach (char c in cifre)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }

            long numero;

            if (!long.TryParse(cifre, NumberStyles.None, CultureInfo.InvariantCulture, out numero) ||
                numero > int.MaxValue)
            {
                return false;
            }

            valore = (int)numero;
            return true;
        }

        private int LeggiValoreCella(int riga, int colonna)
        {
            object valore = dataGridViewMatrice.Rows[riga].Cells[colonna].Value;
            int numero;

            return ProvaLeggiIntero(Convert.ToString(valore), out numero) ? numero : 0;
        }

        private int[] LeggiProduzioni()
        {
            int[] produzioni = new int[griglia.Rows];

            for (int i = 0; i < griglia.Rows; i++)
            {
                produzioni[i] = LeggiValoreCella(i, griglia.Columns);
            }

            return produzioni;
        }

        private int[] LeggiFabbisogni()
        {
            int[] fabbisogni = new int[griglia.Columns];

            for (int j = 0; j < griglia.Columns; j++)
            {
                fabbisogni[j] = LeggiValoreCella(griglia.Rows, j);
            }

            return fabbisogni;
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
                    griglia.ImpostaValore(i, j, LeggiValoreCella(i, j));
                }
            }
        }

        private void btnIncolla_Click(object sender, EventArgs e)
        {
            if (risoluzioneInCorso)
            {
                return;
            }

            if (griglia == null)
            {
                MostraAvviso("Prima devi creare la matrice.");
                return;
            }

            if (!Clipboard.ContainsText())
            {
                MostraAvviso("Negli appunti non c'è nessun testo. Copia prima un intervallo da Excel.");
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
                MostraAvviso("Gli appunti sono vuoti.");
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
                    string cella = celle[c];

                    if (string.IsNullOrWhiteSpace(cella))
                    {
                        riga[c] = 0;
                    }
                    else if (!ProvaLeggiIntero(cella, out riga[c]))
                    {
                        MostraErrore(
                            "Valore non valido \"" + cella.Trim() + "\" alla riga " + (r + 1) +
                            ", colonna " + (c + 1) + " dei dati copiati.\n\n" +
                            "Sono ammessi solo numeri interi maggiori o uguali a zero " +
                            "(anche con separatore delle migliaia, es. 1.250).");
                        return;
                    }
                }

                valori.Add(riga);
                larghezzaMax = Math.Max(larghezzaMax, celle.Length);
            }

            if (rigaInizio + numeroRighe > n + 1 || colonnaInizio + larghezzaMax > m + 1)
            {
                MostraErrore(
                    "I dati copiati (" + numeroRighe + " righe × " + larghezzaMax + " colonne) " +
                    "non entrano nella tabella a partire dalla cella selezionata.\n\n" +
                    "La tabella ha " + n + " produttori e " + m + " consumatori: " +
                    "seleziona la cella in alto a sinistra e ricontrolla le dimensioni.");
                return;
            }

            for (int r = 0; r < valori.Count; r++)
            {
                for (int c = 0; c < valori[r].Length; c++)
                {
                    int riga = rigaInizio + r;
                    int colonna = colonnaInizio + c;

                    if (EUnaCellaTotale(riga, colonna))
                    {
                        continue;
                    }

                    dataGridViewMatrice.Rows[riga].Cells[colonna].Value = valori[r][c];
                }
            }

            SalvaDatiMatrice();
            AggiornaCellaTotale();
            InvalidaSoluzione();

            long sommaProduzioni = LeggiProduzioni().Sum(x => (long)x);
            long sommaFabbisogni = LeggiFabbisogni().Sum(x => (long)x);

            string avviso = "";

            if (sommaProduzioni != sommaFabbisogni)
            {
                avviso = "\n\nAttenzione: la produzione totale (" + sommaProduzioni +
                         ") è diversa dal fabbisogno totale (" + sommaFabbisogni +
                         "). Il problema non è bilanciato.";
            }

            AggiornaStato("Dati incollati da Excel.", "");

            MessageBox.Show(
                "Dati incollati correttamente." + avviso,
                "Operazione completata",
                MessageBoxButtons.OK,
                avviso == "" ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
        }

        public static bool RangeFattibile(int n, int m, int min, int max)
        {
            return (long)Math.Max(n, m) * min <= (long)Math.Min(n, m) * max;
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
            if (risoluzioneInCorso)
            {
                return;
            }

            if (griglia == null)
            {
                MostraAvviso("Prima devi creare la matrice.");
                return;
            }

            int costoMin = (int)numericRangeCostiMin.Value;
            int costoMax = (int)numericRangeCostiMax.Value;

            if (costoMin > costoMax)
            {
                MostraErrore("Il costo minimo non può essere maggiore del costo massimo.");
                return;
            }

            if (costoMax == 0)
            {
                MostraErrore("Il costo massimo deve essere maggiore di zero.");
                return;
            }

            int unitaMin = (int)numericRangeProdMin.Value;
            int unitaMax = (int)numericRangeProdMax.Value;

            if (unitaMin > unitaMax)
            {
                MostraErrore("Il numero di unità minimo non può essere maggiore del numero di unità massimo.");
                return;
            }

            if (unitaMin <= 0)
            {
                MostraErrore("Il numero di unità minimo deve essere maggiore di zero.");
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
                    MessageBoxIcon.Error);

                return;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int valore = random.Next(costoMin, costoMax + 1);

                    griglia.ImpostaValore(i, j, valore);
                    dataGridViewMatrice.Rows[i].Cells[j].Value = valore;
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

            AggiornaCellaTotale();
            InvalidaSoluzione();
            AggiornaStato("Valori casuali generati.", "");
        }

        private string VerificaDatiRisoluzione(int[] produzioni, int[] fabbisogni)
        {
            long totaleProduzione = produzioni.Sum(x => (long)x);
            long totaleFabbisogno = fabbisogni.Sum(x => (long)x);

            List<string> zeri = new List<string>();

            for (int i = 0; i < produzioni.Length; i++)
            {
                if (produzioni[i] == 0)
                {
                    zeri.Add("PRODUTTORE " + (i + 1));
                }
            }

            for (int j = 0; j < fabbisogni.Length; j++)
            {
                if (fabbisogni[j] == 0)
                {
                    zeri.Add("FABBISOGNO del CONSUMATORE " + (j + 1));
                }
            }

            if (zeri.Count > 0)
            {
                return "Produzioni e fabbisogni devono essere maggiori di zero.\n\n" +
                       "Valori nulli o mancanti:\n- " + string.Join("\n- ", zeri);
            }

            if (totaleProduzione != totaleFabbisogno)
            {
                return "Il problema non è bilanciato.\n\n" +
                       "PRODUZIONE: " + totaleProduzione + "\n" +
                       "FABBISOGNO: " + totaleFabbisogno;
            }

            bool tuttiZero = true;

            for (int i = 0; i < griglia.Rows && tuttiZero; i++)
            {
                for (int j = 0; j < griglia.Columns; j++)
                {
                    if (griglia.Grid[i][j] != 0)
                    {
                        tuttiZero = false;
                        break;
                    }
                }
            }

            if (tuttiZero)
            {
                return "Tutti i costi di trasporto sono zero: inserisci i costi prima di risolvere.";
            }

            return null;
        }

        private async void btnRisolvi_Click(object sender, EventArgs e)
        {
            if (risoluzioneInCorso)
            {
                return;
            }

            if (griglia == null)
            {
                MostraAvviso("È necessario creare la matrice.");
                return;
            }

            if (!dataGridViewMatrice.EndEdit())
            {
                return;
            }

            SalvaDatiMatrice();

            int n = griglia.Rows;
            int m = griglia.Columns;

            int[] produzioni = LeggiProduzioni();
            int[] fabbisogni = LeggiFabbisogni();

            string errore = VerificaDatiRisoluzione(produzioni, fabbisogni);

            if (errore != null)
            {
                MostraErrore(errore);
                return;
            }

            InvalidaSoluzione();

            int[,] allocazioni = new int[n, m];
            int[] produzioneResidua = (int[])produzioni.Clone();
            int[] fabbisognoResiduo = (int[])fabbisogni.Clone();

            procedimento = new StringBuilder();
            costoParziale = 0;
            passaggiEseguiti = 0;
            annullamento = new CancellationTokenSource();

            Action<string> scrivi = testo =>
            {
                procedimento.AppendLine(testo);
                System.Diagnostics.Debug.WriteLine(testo);
            };

            bool completata = false;
            long costoTotale = 0;

            ImpostaInterfacciaRisoluzione(true);
            AggiornaStato("Risoluzione in corso...", "Costo parziale: " + FormattaEuro(0));

            try
            {
                scrivi("METODO DELL'ANGOLO DI NORD-OVEST - " +
                       DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                scrivi(n + " PRODUTTORI, " + m + " CONSUMATORI");
                scrivi("");

                costoTotale = await NordOvest(
                    0,
                    0,
                    produzioneResidua,
                    fabbisognoResiduo,
                    allocazioni,
                    1,
                    scrivi,
                    annullamento.Token);

                scrivi("COSTO TOTALE: " + costoTotale + " EUR");
                completata = true;
            }
            catch (OperationCanceledException)
            {
            }
            catch (Exception ex)
            {
                if (!IsDisposed)
                {
                    MostraErrore("Errore durante la risoluzione:\n\n" + ex.Message);
                }
            }
            finally
            {
                annullamento.Dispose();
                annullamento = null;

                if (!IsDisposed)
                {
                    RipristinaVisibilita();
                    RipristinaValoriIniziali(produzioni, fabbisogni);
                    ImpostaInterfacciaRisoluzione(false);
                }
            }

            if (!completata || IsDisposed)
            {
                if (!IsDisposed)
                {
                    AggiornaStato("Risoluzione interrotta.", "");
                }

                return;
            }

            MostraAllocazioni(allocazioni);

            ultimoProcedimento = procedimento.ToString();
            btnSalvaProcedimento.Enabled = true;

            AggiornaEtichettaCosto(costoTotale);
            AggiornaStato(
                "Risoluzione completata in " + passaggiEseguiti + " passaggi. " +
                "Le celle evidenziate sono quelle con unità allocate.",
                "Costo totale: " + FormattaEuro(costoTotale));

            DialogResult risposta = MessageBox.Show(
                "Risoluzione completata.\n\n" +
                "Costo totale: " + FormattaEuro(costoTotale) + "\n\n" +
                "Vuoi salvare il procedimento su file?",
                "Risoluzione completata",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (risposta == DialogResult.Yes)
            {
                SalvaProcedimento();
            }
        }

        private async Task<long> NordOvest(
            int riga,
            int colonna,
            int[] produzioneResidua,
            int[] fabbisognoResiduo,
            int[,] allocazioni,
            int numeroPassaggio,
            Action<string> scrivi,
            CancellationToken token)
        {
            if (riga >= griglia.Rows || colonna >= griglia.Columns)
            {
                return 0;
            }

            if (produzioneResidua[riga] == 0)
            {
                await Task.Delay(RitardoSalto, token);

                return await NordOvest(
                    riga + 1, colonna,
                    produzioneResidua, fabbisognoResiduo, allocazioni,
                    numeroPassaggio, scrivi, token);
            }

            if (fabbisognoResiduo[colonna] == 0)
            {
                await Task.Delay(RitardoSalto, token);

                return await NordOvest(
                    riga, colonna + 1,
                    produzioneResidua, fabbisognoResiduo, allocazioni,
                    numeroPassaggio, scrivi, token);
            }

            EvidenziaRigaColonna(riga, colonna);

            await Task.Delay(RitardoEvidenziazione, token);

            int unitaTrasferite = Math.Min(produzioneResidua[riga], fabbisognoResiduo[colonna]);
            int prezzo = griglia.Grid[riga][colonna];

            long costoTrasferimento = (long)prezzo * unitaTrasferite;

            scrivi("PASSAGGIO " + numeroPassaggio + ": DA PRODUTTORE N." + (riga + 1) +
                   " A CONSUMATORE N." + (colonna + 1));
            scrivi(unitaTrasferite + " UNITA' TRASFERITE AL PREZZO DI " + prezzo +
                   " EUR = " + costoTrasferimento + " EUR");
            scrivi("");

            allocazioni[riga, colonna] = unitaTrasferite;
            produzioneResidua[riga] -= unitaTrasferite;
            fabbisognoResiduo[colonna] -= unitaTrasferite;

            costoParziale += costoTrasferimento;
            passaggiEseguiti = numeroPassaggio;

            AggiornaStato(
                "Passaggio " + numeroPassaggio + ": produttore " + (riga + 1) +
                " → consumatore " + (colonna + 1) + ", " + unitaTrasferite +
                " unità × " + prezzo + " € = " + FormattaEuro(costoTrasferimento),
                "Costo parziale: " + FormattaEuro(costoParziale));

            dataGridViewMatrice.Rows[riga].Cells[griglia.Columns].Value = produzioneResidua[riga];
            dataGridViewMatrice.Rows[griglia.Rows].Cells[colonna].Value = fabbisognoResiduo[colonna];
            dataGridViewMatrice.Rows[griglia.Rows].Cells[griglia.Columns].Value =
                produzioneResidua.Sum(x => (long)x);

            dataGridViewMatrice.Refresh();

            await Task.Delay(RitardoTrasferimento, token);

            ApplicaStiliGriglia();

            long costoSuccessivo = 0;

            if (produzioneResidua[riga] == 0 && fabbisognoResiduo[colonna] == 0)
            {
                dataGridViewMatrice.Rows[riga].Visible = false;
                dataGridViewMatrice.Columns[colonna].Visible = false;

                costoSuccessivo = await NordOvest(
                    riga + 1, colonna + 1,
                    produzioneResidua, fabbisognoResiduo, allocazioni,
                    numeroPassaggio + 1, scrivi, token);
            }

            else if (produzioneResidua[riga] == 0)
            {
                dataGridViewMatrice.Rows[riga].Visible = false;

                costoSuccessivo = await NordOvest(
                    riga + 1, colonna,
                    produzioneResidua, fabbisognoResiduo, allocazioni,
                    numeroPassaggio + 1, scrivi, token);
            }

            else if (fabbisognoResiduo[colonna] == 0)
            {
                dataGridViewMatrice.Columns[colonna].Visible = false;

                costoSuccessivo = await NordOvest(
                    riga, colonna + 1,
                    produzioneResidua, fabbisognoResiduo, allocazioni,
                    numeroPassaggio + 1, scrivi, token);
            }

            return costoTrasferimento + costoSuccessivo;
        }

        private void RipristinaValoriIniziali(int[] produzioni, int[] fabbisogni)
        {
            int n = griglia.Rows;
            int m = griglia.Columns;

            for (int i = 0; i < n; i++)
            {
                dataGridViewMatrice.Rows[i].Cells[m].Value = produzioni[i];
            }

            for (int j = 0; j < m; j++)
            {
                dataGridViewMatrice.Rows[n].Cells[j].Value = fabbisogni[j];
            }

            ApplicaStiliGriglia();
            AggiornaCellaTotale();
        }

        private void ImpostaInterfacciaRisoluzione(bool inCorso)
        {
            risoluzioneInCorso = inCorso;

            numericNumeroProduttori.Enabled = !inCorso;
            numericNumeroConsumatori.Enabled = !inCorso;
            numericRangeCostiMin.Enabled = !inCorso;
            numericRangeCostiMax.Enabled = !inCorso;
            numericRangeProdMin.Enabled = !inCorso;
            numericRangeProdMax.Enabled = !inCorso;

            btnCreaMatrice.Enabled = !inCorso;
            btnIncolla.Enabled = !inCorso;
            btnGenera.Enabled = !inCorso;
            btnRisolvi.Enabled = !inCorso;
            btnSalvaProcedimento.Enabled = !inCorso && ultimoProcedimento != null;

            btnRisolvi.Text = inCorso ? "RISOLUZIONE..." : "RISOLVI";

            dataGridViewMatrice.ReadOnly = inCorso;

            if (!inCorso && griglia != null)
            {
                dataGridViewMatrice.Rows[griglia.Rows].Cells[griglia.Columns].ReadOnly = true;
            }
        }

        private void InvalidaSoluzione()
        {
            ultimoProcedimento = null;
            btnSalvaProcedimento.Enabled = false;
            AggiornaEtichettaCosto(null);

            if (griglia != null)
            {
                ApplicaStiliGriglia();
                AggiornaCellaTotale();
            }
        }

        private void AggiornaStato(string testo, string testoCosto)
        {
            lblStatoPassaggio.Text = testo;
            lblStatoCosto.Text = testoCosto;
            statusStrip.Refresh();
        }

        private void AggiornaEtichettaCosto(long? costo)
        {
            if (costo.HasValue)
            {
                lblCostoTotale.Text = "COSTO TOTALE\r\n" + FormattaEuro(costo.Value);
                lblCostoTotale.ForeColor = Tema.Primario;
            }
            else
            {
                lblCostoTotale.Text = "COSTO TOTALE\r\n—";
                lblCostoTotale.ForeColor = Tema.TestoSecondario;
            }
        }

        private static string FormattaEuro(long valore)
        {
            return valore.ToString("N0", CulturaItaliana) + " €";
        }

        private void btnSalvaProcedimento_Click(object sender, EventArgs e)
        {
            SalvaProcedimento();
        }

        private void SalvaProcedimento()
        {
            if (string.IsNullOrEmpty(ultimoProcedimento))
            {
                MostraAvviso("Non c'è nessun procedimento da salvare: prima risolvi il problema.");
                return;
            }

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Salva il procedimento";
                dialog.Filter = "File di testo (*.txt)|*.txt|Tutti i file (*.*)|*.*";
                dialog.DefaultExt = "txt";
                dialog.AddExtension = true;
                dialog.FileName = "NORD_OVEST_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";

                if (dialog.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    File.WriteAllText(dialog.FileName, ultimoProcedimento, new UTF8Encoding(true));

                    AggiornaStato("Procedimento salvato in " + dialog.FileName, lblStatoCosto.Text);

                    MessageBox.Show(
                        "Procedimento salvato correttamente.",
                        "Salvataggio completato",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (UnauthorizedAccessException)
                {
                    MostraErrore(
                        "Non hai i permessi per scrivere in questa posizione.\n\n" +
                        "Scegli un'altra cartella (ad esempio Documenti) e riprova.");
                }
                catch (IOException ex)
                {
                    MostraErrore(
                        "Impossibile scrivere il file. Potrebbe essere aperto in un altro " +
                        "programma o il disco potrebbe non essere disponibile.\n\n" +
                        "Dettagli: " + ex.Message);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (annullamento != null)
            {
                annullamento.Cancel();
            }
        }

        private static void MostraAvviso(string messaggio)
        {
            MessageBox.Show(messaggio, "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private static void MostraErrore(string messaggio)
        {
            MessageBox.Show(messaggio, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AbilitaAutoSelezioneNumericUpDown(Control contenitore)
        {
            foreach (Control c in contenitore.Controls)
            {
                NumericUpDown nud = c as NumericUpDown;

                if (nud != null)
                {
                    nud.Enter += (sender, e) => nud.Select(0, nud.Text.Length);
                    nud.Click += (sender, e) => nud.Select(0, nud.Text.Length);
                }
                else if (c.HasChildren)
                {
                    AbilitaAutoSelezioneNumericUpDown(c);
                }
            }
        }
    }
}