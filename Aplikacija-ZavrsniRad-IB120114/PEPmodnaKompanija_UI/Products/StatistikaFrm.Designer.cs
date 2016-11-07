namespace PEPmodnaKompanija_UI.Products
{
    partial class StatistikaFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dgProizvodiOcjena = new System.Windows.Forms.DataGridView();
            this.SlikaThumb = new System.Windows.Forms.DataGridViewImageColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDizajneri = new System.Windows.Forms.DataGridView();
            this.Dizajner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProizvodiNajprodavaniji = new System.Windows.Forms.DataGridView();
            this.SlikaThumb2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Proizvod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Broj2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_mjesec = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnPrint1 = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnPrint2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProizvodiOcjena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDizajneri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProizvodiNajprodavaniji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProizvodiOcjena
            // 
            this.dgProizvodiOcjena.AllowUserToResizeColumns = false;
            this.dgProizvodiOcjena.AllowUserToResizeRows = false;
            this.dgProizvodiOcjena.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgProizvodiOcjena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProizvodiOcjena.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlikaThumb,
            this.Naziv,
            this.Cijena,
            this.Ocjena});
            this.dgProizvodiOcjena.Location = new System.Drawing.Point(12, 47);
            this.dgProizvodiOcjena.Name = "dgProizvodiOcjena";
            this.dgProizvodiOcjena.Size = new System.Drawing.Size(489, 252);
            this.dgProizvodiOcjena.TabIndex = 0;
            // 
            // SlikaThumb
            // 
            this.SlikaThumb.DataPropertyName = "SlikaThumb";
            this.SlikaThumb.HeaderText = "Slika";
            this.SlikaThumb.Name = "SlikaThumb";
            this.SlikaThumb.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SlikaThumb.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            // 
            // Ocjena
            // 
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Prosječna ocjena";
            this.Ocjena.Name = "Ocjena";
            // 
            // dgDizajneri
            // 
            this.dgDizajneri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDizajneri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dizajner,
            this.Email,
            this.Ocjena2});
            this.dgDizajneri.Location = new System.Drawing.Point(53, 392);
            this.dgDizajneri.Name = "dgDizajneri";
            this.dgDizajneri.Size = new System.Drawing.Size(386, 160);
            this.dgDizajneri.TabIndex = 1;
            // 
            // Dizajner
            // 
            this.Dizajner.DataPropertyName = "Dizajner";
            this.Dizajner.HeaderText = "Dizajner";
            this.Dizajner.Name = "Dizajner";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Ocjena2
            // 
            this.Ocjena2.DataPropertyName = "Ocjena";
            this.Ocjena2.HeaderText = "Ocjena";
            this.Ocjena2.Name = "Ocjena2";
            // 
            // dgProizvodiNajprodavaniji
            // 
            this.dgProizvodiNajprodavaniji.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgProizvodiNajprodavaniji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProizvodiNajprodavaniji.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlikaThumb2,
            this.Proizvod,
            this.Cijena2,
            this.Broj2});
            this.dgProizvodiNajprodavaniji.Location = new System.Drawing.Point(24, 683);
            this.dgProizvodiNajprodavaniji.Name = "dgProizvodiNajprodavaniji";
            this.dgProizvodiNajprodavaniji.Size = new System.Drawing.Size(459, 226);
            this.dgProizvodiNajprodavaniji.TabIndex = 2;
            // 
            // SlikaThumb2
            // 
            this.SlikaThumb2.DataPropertyName = "SlikaThumb";
            this.SlikaThumb2.HeaderText = "Slika";
            this.SlikaThumb2.Name = "SlikaThumb2";
            this.SlikaThumb2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SlikaThumb2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Proizvod
            // 
            this.Proizvod.DataPropertyName = "Naziv";
            this.Proizvod.HeaderText = "Proizvod";
            this.Proizvod.Name = "Proizvod";
            // 
            // Cijena2
            // 
            this.Cijena2.DataPropertyName = "Cijena";
            this.Cijena2.HeaderText = "Cijena";
            this.Cijena2.Name = "Cijena2";
            // 
            // Broj2
            // 
            this.Broj2.DataPropertyName = "Broj2";
            this.Broj2.HeaderText = "Količina";
            this.Broj2.Name = "Broj2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(104, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Top 5 najbolje ocijenjenih proizvoda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(69, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Top 5 najbolje ocijenjenih dizajnera";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(132, 617);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Top 5 najprodavanijih proizvoda";
            // 
            // dtp_mjesec
            // 
            this.dtp_mjesec.CustomFormat = "MM/yyyy";
            this.dtp_mjesec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtp_mjesec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_mjesec.Location = new System.Drawing.Point(201, 654);
            this.dtp_mjesec.Name = "dtp_mjesec";
            this.dtp_mjesec.Size = new System.Drawing.Size(128, 26);
            this.dtp_mjesec.TabIndex = 6;
            this.dtp_mjesec.ValueChanged += new System.EventHandler(this.dtp_mjesec_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(59, 659);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Filtriraj po mjesecu:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(758, 62);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Total";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(424, 286);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Ukupna zarada od prodaje po mjesecima izražena u KM";
            this.chart1.Titles.Add(title1);
            // 
            // btnPrint1
            // 
            this.btnPrint1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPrint1.Location = new System.Drawing.Point(711, 62);
            this.btnPrint1.Name = "btnPrint1";
            this.btnPrint1.Size = new System.Drawing.Size(84, 30);
            this.btnPrint1.TabIndex = 9;
            this.btnPrint1.Text = "Isprintaj";
            this.btnPrint1.UseVisualStyleBackColor = false;
            this.btnPrint1.Click += new System.EventHandler(this.btnPrint1_Click);
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            this.chart2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart2.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(691, 478);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Vrsta";
            series2.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.DarkRed;
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(491, 259);
            this.chart2.TabIndex = 10;
            this.chart2.Text = "chart2";
            title2.Name = "Title1";
            title2.Text = "Količina prodanih proizvoda u tekućem mjesecu";
            this.chart2.Titles.Add(title2);
            // 
            // btnPrint2
            // 
            this.btnPrint2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPrint2.Location = new System.Drawing.Point(709, 462);
            this.btnPrint2.Name = "btnPrint2";
            this.btnPrint2.Size = new System.Drawing.Size(95, 34);
            this.btnPrint2.TabIndex = 11;
            this.btnPrint2.Text = "Isprintaj";
            this.btnPrint2.UseVisualStyleBackColor = false;
            this.btnPrint2.Click += new System.EventHandler(this.btnPrint2_Click);
            // 
            // StatistikaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1242, 741);
            this.Controls.Add(this.btnPrint2);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.btnPrint1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_mjesec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgProizvodiNajprodavaniji);
            this.Controls.Add(this.dgDizajneri);
            this.Controls.Add(this.dgProizvodiOcjena);
            this.Name = "StatistikaFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistika";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StatistikaFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProizvodiOcjena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDizajneri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProizvodiNajprodavaniji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProizvodiOcjena;
        private System.Windows.Forms.DataGridView dgDizajneri;
        private System.Windows.Forms.DataGridView dgProizvodiNajprodavaniji;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dizajner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewImageColumn SlikaThumb2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proizvod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Broj2;
        private System.Windows.Forms.DateTimePicker dtp_mjesec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnPrint1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button btnPrint2;
        private System.Windows.Forms.DataGridViewImageColumn SlikaThumb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
    }
}