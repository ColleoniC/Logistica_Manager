using System.Drawing;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnRisolvi = new System.Windows.Forms.Button();
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
            this.tabMatriceIniziale = new System.Windows.Forms.TabPage();
            this.dataGridViewMatrice = new System.Windows.Forms.DataGridView();
            this.tabControlMetodi = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.tabMatriceIniziale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrice)).BeginInit();
            this.tabControlMetodi.SuspendLayout();
            this.SuspendLayout();
            // 
            // pannelloLaterale
            // 
            this.pannelloLaterale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pannelloLaterale.AutoScroll = true;
            this.pannelloLaterale.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pannelloLaterale.Controls.Add(this.groupBoxProduttoriConsumatori);
            this.pannelloLaterale.Controls.Add(this.groupBoxDatiExcel);
            this.pannelloLaterale.Controls.Add(this.btnRisolvi);
            this.pannelloLaterale.Controls.Add(this.groupBoxValoriCasuali);
            this.pannelloLaterale.Location = new System.Drawing.Point(13, 60);
            this.pannelloLaterale.Name = "pannelloLaterale";
            this.pannelloLaterale.Padding = new System.Windows.Forms.Padding(4);
            this.pannelloLaterale.Size = new System.Drawing.Size(303, 638);
            this.pannelloLaterale.TabIndex = 0;
            // 
            // groupBoxProduttoriConsumatori
            // 
            this.groupBoxProduttoriConsumatori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.groupBoxProduttoriConsumatori.Controls.Add(this.label2);
            this.groupBoxProduttoriConsumatori.Controls.Add(this.label1);
            this.groupBoxProduttoriConsumatori.Controls.Add(this.lblNumeroProduttori);
            this.groupBoxProduttoriConsumatori.Controls.Add(this.numericNumeroProduttori);
            this.groupBoxProduttoriConsumatori.Controls.Add(this.lblNumeroConsumatori);
            this.groupBoxProduttoriConsumatori.Controls.Add(this.numericNumeroConsumatori);
            this.groupBoxProduttoriConsumatori.Controls.Add(this.btnCreaMatrice);
            this.groupBoxProduttoriConsumatori.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxProduttoriConsumatori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(143)))));
            this.groupBoxProduttoriConsumatori.Location = new System.Drawing.Point(0, 16);
            this.groupBoxProduttoriConsumatori.Name = "groupBoxProduttoriConsumatori";
            this.groupBoxProduttoriConsumatori.Padding = new System.Windows.Forms.Padding(12, 10, 12, 12);
            this.groupBoxProduttoriConsumatori.Size = new System.Drawing.Size(303, 160);
            this.groupBoxProduttoriConsumatori.TabIndex = 0;
            this.groupBoxProduttoriConsumatori.TabStop = false;
            this.groupBoxProduttoriConsumatori.Text = "IMPOSTAZIONE PRODUTTORI / CONSUMATORI";
            // 
            // lblNumeroProduttori
            // 
            this.lblNumeroProduttori.AutoSize = true;
            this.lblNumeroProduttori.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNumeroProduttori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.lblNumeroProduttori.Location = new System.Drawing.Point(13, 26);
            this.lblNumeroProduttori.Name = "lblNumeroProduttori";
            this.lblNumeroProduttori.Size = new System.Drawing.Size(71, 15);
            this.lblNumeroProduttori.TabIndex = 0;
            this.lblNumeroProduttori.Text = "NUMERO DI";
            // 
            // numericNumeroProduttori
            // 
            this.numericNumeroProduttori.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numericNumeroProduttori.Location = new System.Drawing.Point(214, 29);
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
            this.lblNumeroConsumatori.Location = new System.Drawing.Point(15, 62);
            this.lblNumeroConsumatori.Name = "lblNumeroConsumatori";
            this.lblNumeroConsumatori.Size = new System.Drawing.Size(71, 15);
            this.lblNumeroConsumatori.TabIndex = 2;
            this.lblNumeroConsumatori.Text = "NUMERO DI";
            // 
            // numericNumeroConsumatori
            // 
            this.numericNumeroConsumatori.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numericNumeroConsumatori.Location = new System.Drawing.Point(214, 62);
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
            this.btnCreaMatrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(143)))));
            this.btnCreaMatrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreaMatrice.FlatAppearance.BorderSize = 0;
            this.btnCreaMatrice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(25)))), ((int)(((byte)(75)))));
            this.btnCreaMatrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreaMatrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCreaMatrice.ForeColor = System.Drawing.Color.White;
            this.btnCreaMatrice.Location = new System.Drawing.Point(16, 110);
            this.btnCreaMatrice.Name = "btnCreaMatrice";
            this.btnCreaMatrice.Size = new System.Drawing.Size(268, 36);
            this.btnCreaMatrice.TabIndex = 4;
            this.btnCreaMatrice.Text = "CREA MATRICE";
            this.btnCreaMatrice.UseVisualStyleBackColor = false;
            this.btnCreaMatrice.Click += new System.EventHandler(this.btnCreaMatrice_Click);
            // 
            // groupBoxDatiExcel
            // 
            this.groupBoxDatiExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.groupBoxDatiExcel.Controls.Add(this.btnIncolla);
            this.groupBoxDatiExcel.Controls.Add(this.lblSuggerimentoExcel);
            this.groupBoxDatiExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxDatiExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(143)))));
            this.groupBoxDatiExcel.Location = new System.Drawing.Point(0, 201);
            this.groupBoxDatiExcel.Name = "groupBoxDatiExcel";
            this.groupBoxDatiExcel.Padding = new System.Windows.Forms.Padding(12, 10, 12, 12);
            this.groupBoxDatiExcel.Size = new System.Drawing.Size(303, 118);
            this.groupBoxDatiExcel.TabIndex = 1;
            this.groupBoxDatiExcel.TabStop = false;
            this.groupBoxDatiExcel.Text = "DATI DA EXCEL";
            // 
            // btnIncolla
            // 
            this.btnIncolla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(143)))));
            this.btnIncolla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncolla.FlatAppearance.BorderSize = 0;
            this.btnIncolla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(25)))), ((int)(((byte)(75)))));
            this.btnIncolla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncolla.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnIncolla.ForeColor = System.Drawing.Color.White;
            this.btnIncolla.Location = new System.Drawing.Point(16, 32);
            this.btnIncolla.Name = "btnIncolla";
            this.btnIncolla.Size = new System.Drawing.Size(268, 36);
            this.btnIncolla.TabIndex = 0;
            this.btnIncolla.Text = "INCOLLA";
            this.btnIncolla.UseVisualStyleBackColor = false;
            this.btnIncolla.Click += new System.EventHandler(this.btnIncolla_Click);
            // 
            // lblSuggerimentoExcel
            // 
            this.lblSuggerimentoExcel.AutoSize = true;
            this.lblSuggerimentoExcel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic);
            this.lblSuggerimentoExcel.ForeColor = System.Drawing.Color.Gray;
            this.lblSuggerimentoExcel.Location = new System.Drawing.Point(55, 71);
            this.lblSuggerimentoExcel.Name = "lblSuggerimentoExcel";
            this.lblSuggerimentoExcel.Size = new System.Drawing.Size(181, 26);
            this.lblSuggerimentoExcel.TabIndex = 1;
            this.lblSuggerimentoExcel.Text = "Copia l\'intervallo da Excel e incollalo\r\nnella matrice attiva.";
            this.lblSuggerimentoExcel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRisolvi
            // 
            this.btnRisolvi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRisolvi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(143)))));
            this.btnRisolvi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRisolvi.FlatAppearance.BorderSize = 0;
            this.btnRisolvi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(25)))), ((int)(((byte)(75)))));
            this.btnRisolvi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRisolvi.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRisolvi.ForeColor = System.Drawing.Color.White;
            this.btnRisolvi.Location = new System.Drawing.Point(0, 574);
            this.btnRisolvi.Name = "btnRisolvi";
            this.btnRisolvi.Size = new System.Drawing.Size(303, 60);
            this.btnRisolvi.TabIndex = 2;
            this.btnRisolvi.Text = "RISOLVI";
            this.btnRisolvi.UseVisualStyleBackColor = false;
            this.btnRisolvi.Click += new System.EventHandler(this.btnRisolviQuattroMetodi_Click);
            // 
            // groupBoxValoriCasuali
            // 
            this.groupBoxValoriCasuali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.groupBoxValoriCasuali.Controls.Add(this.label3);
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
            this.groupBoxValoriCasuali.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(143)))));
            this.groupBoxValoriCasuali.Location = new System.Drawing.Point(0, 338);
            this.groupBoxValoriCasuali.Name = "groupBoxValoriCasuali";
            this.groupBoxValoriCasuali.Padding = new System.Windows.Forms.Padding(12, 10, 12, 12);
            this.groupBoxValoriCasuali.Size = new System.Drawing.Size(303, 176);
            this.groupBoxValoriCasuali.TabIndex = 2;
            this.groupBoxValoriCasuali.TabStop = false;
            this.groupBoxValoriCasuali.Text = "GENERA VALORI CASUALI";
            // 
            // lblRangeCosti
            // 
            this.lblRangeCosti.AutoSize = true;
            this.lblRangeCosti.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRangeCosti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.lblRangeCosti.Location = new System.Drawing.Point(12, 29);
            this.lblRangeCosti.Name = "lblRangeCosti";
            this.lblRangeCosti.Size = new System.Drawing.Size(101, 15);
            this.lblRangeCosti.TabIndex = 0;
            this.lblRangeCosti.Text = "RANGE DEI COSTI";
            // 
            // numericRangeCostiMin
            // 
            this.numericRangeCostiMin.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numericRangeCostiMin.Location = new System.Drawing.Point(140, 29);
            this.numericRangeCostiMin.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericRangeCostiMin.Name = "numericRangeCostiMin";
            this.numericRangeCostiMin.Size = new System.Drawing.Size(59, 24);
            this.numericRangeCostiMin.TabIndex = 1;
            this.numericRangeCostiMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRangeCostiTrattino
            // 
            this.lblRangeCostiTrattino.AutoSize = true;
            this.lblRangeCostiTrattino.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRangeCostiTrattino.ForeColor = System.Drawing.Color.Gray;
            this.lblRangeCostiTrattino.Location = new System.Drawing.Point(203, 33);
            this.lblRangeCostiTrattino.Name = "lblRangeCostiTrattino";
            this.lblRangeCostiTrattino.Size = new System.Drawing.Size(12, 15);
            this.lblRangeCostiTrattino.TabIndex = 2;
            this.lblRangeCostiTrattino.Text = "-";
            // 
            // numericRangeCostiMax
            // 
            this.numericRangeCostiMax.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numericRangeCostiMax.Location = new System.Drawing.Point(221, 29);
            this.numericRangeCostiMax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericRangeCostiMax.Name = "numericRangeCostiMax";
            this.numericRangeCostiMax.Size = new System.Drawing.Size(63, 24);
            this.numericRangeCostiMax.TabIndex = 3;
            this.numericRangeCostiMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRangeProduzioniFabbisogni
            // 
            this.lblRangeProduzioniFabbisogni.AutoSize = true;
            this.lblRangeProduzioniFabbisogni.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRangeProduzioniFabbisogni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.lblRangeProduzioniFabbisogni.Location = new System.Drawing.Point(13, 71);
            this.lblRangeProduzioniFabbisogni.Name = "lblRangeProduzioniFabbisogni";
            this.lblRangeProduzioniFabbisogni.Size = new System.Drawing.Size(118, 15);
            this.lblRangeProduzioniFabbisogni.TabIndex = 4;
            this.lblRangeProduzioniFabbisogni.Text = "RANGE PRODUZIONI";
            // 
            // numericRangeProdMin
            // 
            this.numericRangeProdMin.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numericRangeProdMin.Location = new System.Drawing.Point(144, 71);
            this.numericRangeProdMin.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericRangeProdMin.Name = "numericRangeProdMin";
            this.numericRangeProdMin.Size = new System.Drawing.Size(57, 24);
            this.numericRangeProdMin.TabIndex = 5;
            this.numericRangeProdMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRangeProdTrattino
            // 
            this.lblRangeProdTrattino.AutoSize = true;
            this.lblRangeProdTrattino.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRangeProdTrattino.ForeColor = System.Drawing.Color.Gray;
            this.lblRangeProdTrattino.Location = new System.Drawing.Point(207, 75);
            this.lblRangeProdTrattino.Name = "lblRangeProdTrattino";
            this.lblRangeProdTrattino.Size = new System.Drawing.Size(12, 15);
            this.lblRangeProdTrattino.TabIndex = 6;
            this.lblRangeProdTrattino.Text = "-";
            // 
            // numericRangeProdMax
            // 
            this.numericRangeProdMax.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numericRangeProdMax.Location = new System.Drawing.Point(225, 71);
            this.numericRangeProdMax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericRangeProdMax.Name = "numericRangeProdMax";
            this.numericRangeProdMax.Size = new System.Drawing.Size(59, 24);
            this.numericRangeProdMax.TabIndex = 7;
            this.numericRangeProdMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGenera
            // 
            this.btnGenera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(143)))));
            this.btnGenera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenera.FlatAppearance.BorderSize = 0;
            this.btnGenera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(25)))), ((int)(((byte)(75)))));
            this.btnGenera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenera.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGenera.ForeColor = System.Drawing.Color.White;
            this.btnGenera.Location = new System.Drawing.Point(16, 118);
            this.btnGenera.Name = "btnGenera";
            this.btnGenera.Size = new System.Drawing.Size(268, 36);
            this.btnGenera.TabIndex = 8;
            this.btnGenera.Text = "GENERA";
            this.btnGenera.UseVisualStyleBackColor = false;
            this.btnGenera.Click += new System.EventHandler(this.btnGenera_Click);
            // 
            // lblIntestazione
            // 
            this.lblIntestazione.AutoSize = true;
            this.lblIntestazione.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntestazione.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(143)))));
            this.lblIntestazione.Location = new System.Drawing.Point(8, 15);
            this.lblIntestazione.Name = "lblIntestazione";
            this.lblIntestazione.Size = new System.Drawing.Size(313, 25);
            this.lblIntestazione.TabIndex = 3;
            this.lblIntestazione.Text = "OTTIMIZZAZIONE DEI TRASPORTI";
            // 
            // lineaSeparatrice
            // 
            this.lineaSeparatrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(143)))));
            this.lineaSeparatrice.Location = new System.Drawing.Point(39, 43);
            this.lineaSeparatrice.Name = "lineaSeparatrice";
            this.lineaSeparatrice.Size = new System.Drawing.Size(251, 2);
            this.lineaSeparatrice.TabIndex = 4;
            // 
            // tabMatriceIniziale
            // 
            this.tabMatriceIniziale.BackColor = System.Drawing.Color.White;
            this.tabMatriceIniziale.Controls.Add(this.dataGridViewMatrice);
            this.tabMatriceIniziale.Location = new System.Drawing.Point(4, 26);
            this.tabMatriceIniziale.Name = "tabMatriceIniziale";
            this.tabMatriceIniziale.Padding = new System.Windows.Forms.Padding(8);
            this.tabMatriceIniziale.Size = new System.Drawing.Size(729, 654);
            this.tabMatriceIniziale.TabIndex = 0;
            this.tabMatriceIniziale.Text = "MATRICE";
            this.tabMatriceIniziale.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMatrice
            // 
            this.dataGridViewMatrice.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.dataGridViewMatrice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewMatrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMatrice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.dataGridViewMatrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMatrice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(15)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMatrice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewMatrice.ColumnHeadersHeight = 32;
            this.dataGridViewMatrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(200)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMatrice.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewMatrice.EnableHeadersVisualStyles = false;
            this.dataGridViewMatrice.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewMatrice.Name = "dataGridViewMatrice";
            this.dataGridViewMatrice.RowHeadersWidth = 25;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.dataGridViewMatrice.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewMatrice.RowTemplate.Height = 28;
            this.dataGridViewMatrice.Size = new System.Drawing.Size(721, 648);
            this.dataGridViewMatrice.TabIndex = 0;
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
            this.tabControlMetodi.Size = new System.Drawing.Size(737, 684);
            this.tabControlMetodi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "PRODUTTORI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(16, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "CONSUMATORI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "E FABBISOGNI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1085, 713);
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
            this.tabMatriceIniziale.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrice)).EndInit();
            this.tabControlMetodi.ResumeLayout(false);
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

        private System.Windows.Forms.Button btnRisolvi;
        private System.Windows.Forms.TabPage tabMatriceIniziale;
        private System.Windows.Forms.DataGridView dataGridViewMatrice;
        private System.Windows.Forms.TabControl tabControlMetodi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}