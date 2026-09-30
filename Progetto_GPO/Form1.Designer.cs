namespace Progetto_GPO
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pannelloLaterale = new System.Windows.Forms.Panel();
            this.groupBoxProduttoriConsumatori = new System.Windows.Forms.GroupBox();
            this.lblNumeroProduttori = new System.Windows.Forms.Label();
            this.numericNumeroProduttori = new System.Windows.Forms.NumericUpDown();
            this.lblNumeroConsumatori = new System.Windows.Forms.Label();
            this.numericNumeroConsumatori = new System.Windows.Forms.NumericUpDown();
            this.btnCreaMatrice = new System.Windows.Forms.Button();
            this.groupBoxDatiExcel = new System.Windows.Forms.GroupBox();
            this.btnIncolla = new System.Windows.Forms.Button();
            this.lblSuggerimentoExcel = new System.Windows.Forms.Label();
            this.btnRisolviQuattroMetodi = new System.Windows.Forms.Button();
            this.groupBoxValoriCasuali = new System.Windows.Forms.GroupBox();
            this.lblRangeCosti = new System.Windows.Forms.Label();
            this.numericRangeCostiMin = new System.Windows.Forms.NumericUpDown();
            this.lblRangeCostiTrattino = new System.Windows.Forms.Label();
            this.numericRangeCostiMax = new System.Windows.Forms.NumericUpDown();
            this.lblRangeProduzioniFabbisogni = new System.Windows.Forms.Label();
            this.numericRangeProdMin = new System.Windows.Forms.NumericUpDown();
            this.lblRangeProdTrattino = new System.Windows.Forms.Label();
            this.numericRangeProdMax = new System.Windows.Forms.NumericUpDown();
            this.btnGenera = new System.Windows.Forms.Button();
            this.lblIntestazione = new System.Windows.Forms.Label();
            this.lineaSeparatrice = new System.Windows.Forms.Panel();
            this.tabControlMetodi = new System.Windows.Forms.TabControl();
            this.dataGridViewMatrice = new System.Windows.Forms.DataGridView();
            this.tabMatriceIniziale = new System.Windows.Forms.TabPage();
            this.pannelloLaterale.SuspendLayout();
            this.groupBoxProduttoriConsumatori.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumeroProduttori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumeroConsumatori)).BeginInit();
            this.groupBoxDatiExcel.SuspendLayout();
            this.groupBoxValoriCasuali.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRangeCostiMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRangeCostiMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRangeProdMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRangeProdMax)).BeginInit();
            this.tabControlMetodi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrice)).BeginInit();
            this.tabMatriceIniziale.SuspendLayout();
            this.SuspendLayout();
            // 
            // pannelloLaterale
            // 
            this.pannelloLaterale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pannelloLaterale.AutoScroll = true;
            this.pannelloLaterale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.pannelloLaterale.Controls.Add(this.groupBoxProduttoriConsumatori);
            this.pannelloLaterale.Controls.Add(this.groupBoxDatiExcel);
            this.pannelloLaterale.Controls.Add(this.btnRisolviQuattroMetodi);
            this.pannelloLaterale.Controls.Add(this.groupBoxValoriCasuali);
            this.pannelloLaterale.Location = new System.Drawing.Point(12, 60);
            this.pannelloLaterale.Name = "pannelloLaterale";
            this.pannelloLaterale.Padding = new System.Windows.Forms.Padding(4);
            this.pannelloLaterale.Size = new System.Drawing.Size(312, 638);
            this.pannelloLaterale.TabIndex = 0;
            // 
            // groupBoxProduttoriConsumatori
            // 
            this.groupBoxProduttoriConsumatori.Controls.Add(this.lblNumeroProduttori);
            this.groupBoxProduttoriConsumatori.Controls.Add(this.numericNumeroProduttori);
            this.groupBoxProduttoriConsumatori.Controls.Add(this.lblNumeroConsumatori);
            this.groupBoxProduttoriConsumatori.Controls.Add(this.numericNumeroConsumatori);
            this.groupBoxProduttoriConsumatori.Controls.Add(this.btnCreaMatrice);
            this.groupBoxProduttoriConsumatori.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxProduttoriConsumatori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.groupBoxProduttoriConsumatori.Location = new System.Drawing.Point(4, 16);
            this.groupBoxProduttoriConsumatori.Name = "groupBoxProduttoriConsumatori";
            this.groupBoxProduttoriConsumatori.Padding = new System.Windows.Forms.Padding(12, 10, 12, 12);
            this.groupBoxProduttoriConsumatori.Size = new System.Drawing.Size(294, 160);
            this.groupBoxProduttoriConsumatori.TabIndex = 0;
            this.groupBoxProduttoriConsumatori.TabStop = false;
            this.groupBoxProduttoriConsumatori.Text = "IMPOSTAZIONE PRODUTTORI / CONSUMATORI";
            // 
            // lblNumeroProduttori
            // 
            this.lblNumeroProduttori.AutoSize = true;
            this.lblNumeroProduttori.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNumeroProduttori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.lblNumeroProduttori.Location = new System.Drawing.Point(16, 40);
            this.lblNumeroProduttori.Name = "lblNumeroProduttori";
            this.lblNumeroProduttori.Size = new System.Drawing.Size(121, 15);
            this.lblNumeroProduttori.TabIndex = 0;
            this.lblNumeroProduttori.Text = "Numero di Produttori";
            // 
            // numericNumeroProduttori
            // 
            this.numericNumeroProduttori.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numericNumeroProduttori.Location = new System.Drawing.Point(190, 37);
            this.numericNumeroProduttori.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNumeroProduttori.Name = "numericNumeroProduttori";
            this.numericNumeroProduttori.Size = new System.Drawing.Size(70, 24);
            this.numericNumeroProduttori.TabIndex = 1;
            this.numericNumeroProduttori.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericNumeroProduttori.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblNumeroConsumatori
            // 
            this.lblNumeroConsumatori.AutoSize = true;
            this.lblNumeroConsumatori.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNumeroConsumatori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.lblNumeroConsumatori.Location = new System.Drawing.Point(16, 75);
            this.lblNumeroConsumatori.Name = "lblNumeroConsumatori";
            this.lblNumeroConsumatori.Size = new System.Drawing.Size(136, 15);
            this.lblNumeroConsumatori.TabIndex = 2;
            this.lblNumeroConsumatori.Text = "Numero di Consumatori";
            // 
            // numericNumeroConsumatori
            // 
            this.numericNumeroConsumatori.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numericNumeroConsumatori.Location = new System.Drawing.Point(190, 72);
            this.numericNumeroConsumatori.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNumeroConsumatori.Name = "numericNumeroConsumatori";
            this.numericNumeroConsumatori.Size = new System.Drawing.Size(70, 24);
            this.numericNumeroConsumatori.TabIndex = 3;
            this.numericNumeroConsumatori.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericNumeroConsumatori.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btnCreaMatrice
            // 
            this.btnCreaMatrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(15)))), ((int)(((byte)(60)))));
            this.btnCreaMatrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreaMatrice.FlatAppearance.BorderSize = 0;
            this.btnCreaMatrice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(25)))), ((int)(((byte)(75)))));
            this.btnCreaMatrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreaMatrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCreaMatrice.ForeColor = System.Drawing.Color.White;
            this.btnCreaMatrice.Location = new System.Drawing.Point(16, 110);
            this.btnCreaMatrice.Name = "btnCreaMatrice";
            this.btnCreaMatrice.Size = new System.Drawing.Size(262, 36);
            this.btnCreaMatrice.TabIndex = 4;
            this.btnCreaMatrice.Text = "Crea Matrice";
            this.btnCreaMatrice.UseVisualStyleBackColor = false;
            this.btnCreaMatrice.Click += new System.EventHandler(this.btnCreaMatrice_Click);
            // 
            // groupBoxDatiExcel
            // 
            this.groupBoxDatiExcel.Controls.Add(this.btnIncolla);
            this.groupBoxDatiExcel.Controls.Add(this.lblSuggerimentoExcel);
            this.groupBoxDatiExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxDatiExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.groupBoxDatiExcel.Location = new System.Drawing.Point(4, 201);
            this.groupBoxDatiExcel.Name = "groupBoxDatiExcel";
            this.groupBoxDatiExcel.Padding = new System.Windows.Forms.Padding(12, 10, 12, 12);
            this.groupBoxDatiExcel.Size = new System.Drawing.Size(294, 118);
            this.groupBoxDatiExcel.TabIndex = 1;
            this.groupBoxDatiExcel.TabStop = false;
            this.groupBoxDatiExcel.Text = "DATI DA EXCEL";
            // 
            // btnIncolla
            // 
            this.btnIncolla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(15)))), ((int)(((byte)(60)))));
            this.btnIncolla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncolla.FlatAppearance.BorderSize = 0;
            this.btnIncolla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(25)))), ((int)(((byte)(75)))));
            this.btnIncolla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncolla.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnIncolla.ForeColor = System.Drawing.Color.White;
            this.btnIncolla.Location = new System.Drawing.Point(16, 32);
            this.btnIncolla.Name = "btnIncolla";
            this.btnIncolla.Size = new System.Drawing.Size(262, 36);
            this.btnIncolla.TabIndex = 0;
            this.btnIncolla.Text = "Incolla";
            this.btnIncolla.UseVisualStyleBackColor = false;
            this.btnIncolla.Click += new System.EventHandler(this.btnIncolla_Click);
            // 
            // lblSuggerimentoExcel
            // 
            this.lblSuggerimentoExcel.AutoSize = true;
            this.lblSuggerimentoExcel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic);
            this.lblSuggerimentoExcel.ForeColor = System.Drawing.Color.Gray;
            this.lblSuggerimentoExcel.Location = new System.Drawing.Point(16, 76);
            this.lblSuggerimentoExcel.Name = "lblSuggerimentoExcel";
            this.lblSuggerimentoExcel.Size = new System.Drawing.Size(181, 26);
            this.lblSuggerimentoExcel.TabIndex = 1;
            this.lblSuggerimentoExcel.Text = "Copia l\'intervallo da Excel e incollalo\r\nnella matrice attiva.";
            // 
            // btnRisolviQuattroMetodi
            // 
            this.btnRisolviQuattroMetodi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRisolviQuattroMetodi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(15)))), ((int)(((byte)(60)))));
            this.btnRisolviQuattroMetodi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRisolviQuattroMetodi.FlatAppearance.BorderSize = 0;
            this.btnRisolviQuattroMetodi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(25)))), ((int)(((byte)(75)))));
            this.btnRisolviQuattroMetodi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRisolviQuattroMetodi.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRisolviQuattroMetodi.ForeColor = System.Drawing.Color.White;
            this.btnRisolviQuattroMetodi.Location = new System.Drawing.Point(20, 558);
            this.btnRisolviQuattroMetodi.Name = "btnRisolviQuattroMetodi";
            this.btnRisolviQuattroMetodi.Size = new System.Drawing.Size(278, 60);
            this.btnRisolviQuattroMetodi.TabIndex = 2;
            this.btnRisolviQuattroMetodi.Text = "RISOLVI";
            this.btnRisolviQuattroMetodi.UseVisualStyleBackColor = false;
            this.btnRisolviQuattroMetodi.Click += new System.EventHandler(this.btnRisolviQuattroMetodi_Click);
            // 
            // groupBoxValoriCasuali
            // 
            this.groupBoxValoriCasuali.Controls.Add(this.lblRangeCosti);
            this.groupBoxValoriCasuali.Controls.Add(this.numericRangeCostiMin);
            this.groupBoxValoriCasuali.Controls.Add(this.lblRangeCostiTrattino);
            this.groupBoxValoriCasuali.Controls.Add(this.numericRangeCostiMax);
            this.groupBoxValoriCasuali.Controls.Add(this.lblRangeProduzioniFabbisogni);
            this.groupBoxValoriCasuali.Controls.Add(this.numericRangeProdMin);
            this.groupBoxValoriCasuali.Controls.Add(this.lblRangeProdTrattino);
            this.groupBoxValoriCasuali.Controls.Add(this.numericRangeProdMax);
            this.groupBoxValoriCasuali.Controls.Add(this.btnGenera);
            this.groupBoxValoriCasuali.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxValoriCasuali.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.groupBoxValoriCasuali.Location = new System.Drawing.Point(4, 338);
            this.groupBoxValoriCasuali.Name = "groupBoxValoriCasuali";
            this.groupBoxValoriCasuali.Padding = new System.Windows.Forms.Padding(12, 10, 12, 12);
            this.groupBoxValoriCasuali.Size = new System.Drawing.Size(294, 205);
            this.groupBoxValoriCasuali.TabIndex = 2;
            this.groupBoxValoriCasuali.TabStop = false;
            this.groupBoxValoriCasuali.Text = "GENERA VALORI CASUALI";
            // 
            // lblRangeCosti
            // 
            this.lblRangeCosti.AutoSize = true;
            this.lblRangeCosti.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRangeCosti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.lblRangeCosti.Location = new System.Drawing.Point(16, 38);
            this.lblRangeCosti.Name = "lblRangeCosti";
            this.lblRangeCosti.Size = new System.Drawing.Size(68, 15);
            this.lblRangeCosti.TabIndex = 0;
            this.lblRangeCosti.Text = "Range costi";
            // 
            // numericRangeCostiMin
            // 
            this.numericRangeCostiMin.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numericRangeCostiMin.Location = new System.Drawing.Point(130, 35);
            this.numericRangeCostiMin.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericRangeCostiMin.Name = "numericRangeCostiMin";
            this.numericRangeCostiMin.Size = new System.Drawing.Size(65, 24);
            this.numericRangeCostiMin.TabIndex = 1;
            this.numericRangeCostiMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRangeCostiTrattino
            // 
            this.lblRangeCostiTrattino.AutoSize = true;
            this.lblRangeCostiTrattino.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRangeCostiTrattino.ForeColor = System.Drawing.Color.Gray;
            this.lblRangeCostiTrattino.Location = new System.Drawing.Point(201, 38);
            this.lblRangeCostiTrattino.Name = "lblRangeCostiTrattino";
            this.lblRangeCostiTrattino.Size = new System.Drawing.Size(12, 15);
            this.lblRangeCostiTrattino.TabIndex = 2;
            this.lblRangeCostiTrattino.Text = "-";
            // 
            // numericRangeCostiMax
            // 
            this.numericRangeCostiMax.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numericRangeCostiMax.Location = new System.Drawing.Point(219, 35);
            this.numericRangeCostiMax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericRangeCostiMax.Name = "numericRangeCostiMax";
            this.numericRangeCostiMax.Size = new System.Drawing.Size(65, 24);
            this.numericRangeCostiMax.TabIndex = 3;
            this.numericRangeCostiMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRangeProduzioniFabbisogni
            // 
            this.lblRangeProduzioniFabbisogni.AutoSize = true;
            this.lblRangeProduzioniFabbisogni.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRangeProduzioniFabbisogni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.lblRangeProduzioniFabbisogni.Location = new System.Drawing.Point(16, 78);
            this.lblRangeProduzioniFabbisogni.Name = "lblRangeProduzioniFabbisogni";
            this.lblRangeProduzioniFabbisogni.Size = new System.Drawing.Size(169, 15);
            this.lblRangeProduzioniFabbisogni.TabIndex = 4;
            this.lblRangeProduzioniFabbisogni.Text = "Range Produzioni / Fabbisogni";
            // 
            // numericRangeProdMin
            // 
            this.numericRangeProdMin.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numericRangeProdMin.Location = new System.Drawing.Point(130, 100);
            this.numericRangeProdMin.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericRangeProdMin.Name = "numericRangeProdMin";
            this.numericRangeProdMin.Size = new System.Drawing.Size(65, 24);
            this.numericRangeProdMin.TabIndex = 5;
            this.numericRangeProdMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRangeProdTrattino
            // 
            this.lblRangeProdTrattino.AutoSize = true;
            this.lblRangeProdTrattino.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRangeProdTrattino.ForeColor = System.Drawing.Color.Gray;
            this.lblRangeProdTrattino.Location = new System.Drawing.Point(201, 103);
            this.lblRangeProdTrattino.Name = "lblRangeProdTrattino";
            this.lblRangeProdTrattino.Size = new System.Drawing.Size(12, 15);
            this.lblRangeProdTrattino.TabIndex = 6;
            this.lblRangeProdTrattino.Text = "-";
            // 
            // numericRangeProdMax
            // 
            this.numericRangeProdMax.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numericRangeProdMax.Location = new System.Drawing.Point(219, 100);
            this.numericRangeProdMax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericRangeProdMax.Name = "numericRangeProdMax";
            this.numericRangeProdMax.Size = new System.Drawing.Size(65, 24);
            this.numericRangeProdMax.TabIndex = 7;
            this.numericRangeProdMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGenera
            // 
            this.btnGenera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(15)))), ((int)(((byte)(60)))));
            this.btnGenera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenera.FlatAppearance.BorderSize = 0;
            this.btnGenera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(25)))), ((int)(((byte)(75)))));
            this.btnGenera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenera.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGenera.ForeColor = System.Drawing.Color.White;
            this.btnGenera.Location = new System.Drawing.Point(16, 145);
            this.btnGenera.Name = "btnGenera";
            this.btnGenera.Size = new System.Drawing.Size(262, 36);
            this.btnGenera.TabIndex = 8;
            this.btnGenera.Text = "Genera";
            this.btnGenera.UseVisualStyleBackColor = false;
            this.btnGenera.Click += new System.EventHandler(this.btnGenera_Click);
            // 
            // lblIntestazione
            // 
            this.lblIntestazione.AutoSize = true;
            this.lblIntestazione.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblIntestazione.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.lblIntestazione.Location = new System.Drawing.Point(16, 14);
            this.lblIntestazione.Name = "lblIntestazione";
            this.lblIntestazione.Size = new System.Drawing.Size(252, 25);
            this.lblIntestazione.TabIndex = 3;
            this.lblIntestazione.Text = "Ottimizzazione dei Trasporti";
            // 
            // lineaSeparatrice
            // 
            this.lineaSeparatrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(15)))), ((int)(((byte)(60)))));
            this.lineaSeparatrice.Location = new System.Drawing.Point(16, 46);
            this.lineaSeparatrice.Name = "lineaSeparatrice";
            this.lineaSeparatrice.Size = new System.Drawing.Size(300, 3);
            this.lineaSeparatrice.TabIndex = 4;
            // 
            // tabControlMetodi
            // 
            this.tabControlMetodi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMetodi.Controls.Add(this.tabMatriceIniziale);
            this.tabControlMetodi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tabControlMetodi.Location = new System.Drawing.Point(336, 14);
            this.tabControlMetodi.Name = "tabControlMetodi";
            this.tabControlMetodi.SelectedIndex = 0;
            this.tabControlMetodi.Size = new System.Drawing.Size(852, 684);
            this.tabControlMetodi.TabIndex = 1;
            // 
            // dataGridViewMatrice
            // 
            this.dataGridViewMatrice.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.dataGridViewMatrice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMatrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMatrice.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMatrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMatrice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(15)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMatrice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMatrice.ColumnHeadersHeight = 32;
            this.dataGridViewMatrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(200)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMatrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMatrice.EnableHeadersVisualStyles = false;
            this.dataGridViewMatrice.Location = new System.Drawing.Point(8, 8);
            this.dataGridViewMatrice.Name = "dataGridViewMatrice";
            this.dataGridViewMatrice.RowHeadersWidth = 25;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridViewMatrice.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewMatrice.RowTemplate.Height = 28;
            this.dataGridViewMatrice.Size = new System.Drawing.Size(828, 640);
            this.dataGridViewMatrice.TabIndex = 0;
            // 
            // tabMatriceIniziale
            // 
            this.tabMatriceIniziale.BackColor = System.Drawing.Color.White;
            this.tabMatriceIniziale.Controls.Add(this.dataGridViewMatrice);
            this.tabMatriceIniziale.Location = new System.Drawing.Point(4, 26);
            this.tabMatriceIniziale.Name = "tabMatriceIniziale";
            this.tabMatriceIniziale.Padding = new System.Windows.Forms.Padding(8);
            this.tabMatriceIniziale.Size = new System.Drawing.Size(844, 654);
            this.tabMatriceIniziale.TabIndex = 0;
            this.tabMatriceIniziale.Text = "Matrice iniziale";
            this.tabMatriceIniziale.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 713);
            this.Controls.Add(this.lblIntestazione);
            this.Controls.Add(this.lineaSeparatrice);
            this.Controls.Add(this.tabControlMetodi);
            this.Controls.Add(this.pannelloLaterale);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(950, 560);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ottimizzazione dei Trasporti";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pannelloLaterale.ResumeLayout(false);
            this.groupBoxProduttoriConsumatori.ResumeLayout(false);
            this.groupBoxProduttoriConsumatori.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumeroProduttori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumeroConsumatori)).EndInit();
            this.groupBoxDatiExcel.ResumeLayout(false);
            this.groupBoxDatiExcel.PerformLayout();
            this.groupBoxValoriCasuali.ResumeLayout(false);
            this.groupBoxValoriCasuali.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRangeCostiMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRangeCostiMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRangeProdMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRangeProdMax)).EndInit();
            this.tabControlMetodi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrice)).EndInit();
            this.tabMatriceIniziale.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIntestazione;
        private System.Windows.Forms.Panel lineaSeparatrice;

        private System.Windows.Forms.Panel pannelloLaterale;

        private System.Windows.Forms.GroupBox groupBoxProduttoriConsumatori;
        private System.Windows.Forms.Label lblNumeroProduttori;
        private System.Windows.Forms.NumericUpDown numericNumeroProduttori;
        private System.Windows.Forms.Label lblNumeroConsumatori;
        private System.Windows.Forms.NumericUpDown numericNumeroConsumatori;
        private System.Windows.Forms.Button btnCreaMatrice;

        private System.Windows.Forms.GroupBox groupBoxDatiExcel;
        private System.Windows.Forms.Button btnIncolla;
        private System.Windows.Forms.Label lblSuggerimentoExcel;

        private System.Windows.Forms.GroupBox groupBoxValoriCasuali;
        private System.Windows.Forms.Label lblRangeCosti;
        private System.Windows.Forms.NumericUpDown numericRangeCostiMin;
        private System.Windows.Forms.Label lblRangeCostiTrattino;
        private System.Windows.Forms.NumericUpDown numericRangeCostiMax;
        private System.Windows.Forms.Label lblRangeProduzioniFabbisogni;
        private System.Windows.Forms.NumericUpDown numericRangeProdMin;
        private System.Windows.Forms.Label lblRangeProdTrattino;
        private System.Windows.Forms.NumericUpDown numericRangeProdMax;
        private System.Windows.Forms.Button btnGenera;

        private System.Windows.Forms.TabControl tabControlMetodi;

        private System.Windows.Forms.Button btnRisolviQuattroMetodi;
        private System.Windows.Forms.TabPage tabMatriceIniziale;
        private System.Windows.Forms.DataGridView dataGridViewMatrice;
    }
}