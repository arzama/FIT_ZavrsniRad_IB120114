namespace PEPmodnaKompanija_UI.Products
{
    partial class PregledKataloga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PregledKataloga));
            this.dgKatalog = new System.Windows.Forms.DataGridView();
            this.KatalogID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DizajnerK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgKatalogStavke = new System.Windows.Forms.DataGridView();
            this.ProizvodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlikaThumb = new System.Windows.Forms.DataGridViewImageColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrsta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sezona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgKatalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKatalogStavke)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgKatalog
            // 
            this.dgKatalog.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgKatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKatalog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KatalogID,
            this.NazivK,
            this.Datum,
            this.VrstaK,
            this.DizajnerK});
            this.dgKatalog.Location = new System.Drawing.Point(28, 50);
            this.dgKatalog.Name = "dgKatalog";
            this.dgKatalog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKatalog.Size = new System.Drawing.Size(344, 216);
            this.dgKatalog.TabIndex = 2;
            this.dgKatalog.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKatalog_CellClick);
            // 
            // KatalogID
            // 
            this.KatalogID.DataPropertyName = "KatalogID";
            this.KatalogID.HeaderText = "KatalogID";
            this.KatalogID.Name = "KatalogID";
            this.KatalogID.Visible = false;
            // 
            // NazivK
            // 
            this.NazivK.DataPropertyName = "NazivK";
            this.NazivK.HeaderText = "Naziv";
            this.NazivK.Name = "NazivK";
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // VrstaK
            // 
            this.VrstaK.DataPropertyName = "VrstaK";
            this.VrstaK.HeaderText = "Vrsta";
            this.VrstaK.Name = "VrstaK";
            this.VrstaK.Visible = false;
            // 
            // DizajnerK
            // 
            this.DizajnerK.DataPropertyName = "DizajnerK";
            this.DizajnerK.HeaderText = "Dizajner";
            this.DizajnerK.Name = "DizajnerK";
            // 
            // dgKatalogStavke
            // 
            this.dgKatalogStavke.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgKatalogStavke.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgKatalogStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKatalogStavke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProizvodID,
            this.SlikaThumb,
            this.Naziv,
            this.Sifra,
            this.Cijena,
            this.Vrsta,
            this.Sezona});
            this.dgKatalogStavke.Location = new System.Drawing.Point(27, 44);
            this.dgKatalogStavke.Name = "dgKatalogStavke";
            this.dgKatalogStavke.ReadOnly = true;
            this.dgKatalogStavke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKatalogStavke.Size = new System.Drawing.Size(645, 232);
            this.dgKatalogStavke.TabIndex = 3;
            // 
            // ProizvodID
            // 
            this.ProizvodID.DataPropertyName = "ProizvodID";
            this.ProizvodID.HeaderText = "ProizvodID";
            this.ProizvodID.Name = "ProizvodID";
            this.ProizvodID.ReadOnly = true;
            this.ProizvodID.Visible = false;
            // 
            // SlikaThumb
            // 
            this.SlikaThumb.DataPropertyName = "SlikaThumb";
            this.SlikaThumb.HeaderText = "Slika";
            this.SlikaThumb.Name = "SlikaThumb";
            this.SlikaThumb.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Sifra
            // 
            this.Sifra.DataPropertyName = "Sifra";
            this.Sifra.HeaderText = "Sifra";
            this.Sifra.Name = "Sifra";
            this.Sifra.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // Vrsta
            // 
            this.Vrsta.DataPropertyName = "Vrsta";
            this.Vrsta.HeaderText = "Vrsta";
            this.Vrsta.Name = "Vrsta";
            this.Vrsta.ReadOnly = true;
            // 
            // Sezona
            // 
            this.Sezona.DataPropertyName = "Sezona";
            this.Sezona.HeaderText = "Sezona";
            this.Sezona.Name = "Sezona";
            this.Sezona.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.dgKatalogStavke);
            this.groupBox1.Location = new System.Drawing.Point(28, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 309);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proizvodi iz kataloga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 13);
            this.label2.TabIndex = 85;
            this.label2.Text = "*Klikom na željeni katalog pogledajte listu proizvoda,";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(392, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 174);
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // PregledKataloga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 624);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgKatalog);
            this.Name = "PregledKataloga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled kataloga";
            this.Load += new System.EventHandler(this.PregledKataloga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKatalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKatalogStavke)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgKatalog;
        private System.Windows.Forms.DataGridView dgKatalogStavke;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn KatalogID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DizajnerK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProizvodID;
        private System.Windows.Forms.DataGridViewImageColumn SlikaThumb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrsta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sezona;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}