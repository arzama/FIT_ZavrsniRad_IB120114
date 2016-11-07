namespace PEPmodnaKompanija_UI.ModulDizajner
{
    partial class PregledKreacija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PregledKreacija));
            this.dgProizvodi = new System.Windows.Forms.DataGridView();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.sezonaList = new System.Windows.Forms.ComboBox();
            this.vrstaList = new System.Windows.Forms.ComboBox();
            this.nazivInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProizvodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlikaThumb = new System.Windows.Forms.DataGridViewImageColumn();
            this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Velicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgProizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProizvodi
            // 
            this.dgProizvodi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgProizvodi.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProizvodi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProizvodID,
            this.Naziv,
            this.SlikaThumb,
            this.Sifra,
            this.Cijena,
            this.Velicina,
            this.VrstaID});
            this.dgProizvodi.Location = new System.Drawing.Point(28, 77);
            this.dgProizvodi.Name = "dgProizvodi";
            this.dgProizvodi.Size = new System.Drawing.Size(544, 211);
            this.dgProizvodi.TabIndex = 0;
            this.dgProizvodi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProizvodi_CellContentClick);
            // 
            // btnPretraga
            // 
            this.btnPretraga.Image = ((System.Drawing.Image)(resources.GetObject("btnPretraga.Image")));
            this.btnPretraga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPretraga.Location = new System.Drawing.Point(604, 26);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga.TabIndex = 14;
            this.btnPretraga.Text = "Traži";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // sezonaList
            // 
            this.sezonaList.FormattingEnabled = true;
            this.sezonaList.Location = new System.Drawing.Point(451, 28);
            this.sezonaList.Name = "sezonaList";
            this.sezonaList.Size = new System.Drawing.Size(121, 21);
            this.sezonaList.TabIndex = 13;
            // 
            // vrstaList
            // 
            this.vrstaList.FormattingEnabled = true;
            this.vrstaList.Location = new System.Drawing.Point(258, 28);
            this.vrstaList.Name = "vrstaList";
            this.vrstaList.Size = new System.Drawing.Size(121, 21);
            this.vrstaList.TabIndex = 12;
            // 
            // nazivInput
            // 
            this.nazivInput.Location = new System.Drawing.Point(40, 28);
            this.nazivInput.Name = "nazivInput";
            this.nazivInput.Size = new System.Drawing.Size(175, 20);
            this.nazivInput.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sezona";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Vrsta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Naziv";
            // 
            // ProizvodID
            // 
            this.ProizvodID.DataPropertyName = "ProizvodID";
            this.ProizvodID.HeaderText = "ProizvodID";
            this.ProizvodID.Name = "ProizvodID";
            this.ProizvodID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            // 
            // SlikaThumb
            // 
            this.SlikaThumb.DataPropertyName = "SlikaThumb";
            this.SlikaThumb.HeaderText = "Slika";
            this.SlikaThumb.Name = "SlikaThumb";
            this.SlikaThumb.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SlikaThumb.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Sifra
            // 
            this.Sifra.DataPropertyName = "Sifra";
            this.Sifra.HeaderText = "Šifra";
            this.Sifra.Name = "Sifra";
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            // 
            // Velicina
            // 
            this.Velicina.DataPropertyName = "Velicina";
            this.Velicina.HeaderText = "Veličina";
            this.Velicina.Name = "Velicina";
            // 
            // VrstaID
            // 
            this.VrstaID.DataPropertyName = "VrstaID";
            this.VrstaID.HeaderText = "VrstaID";
            this.VrstaID.Name = "VrstaID";
            this.VrstaID.Visible = false;
            // 
            // PregledKreacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(718, 300);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.sezonaList);
            this.Controls.Add(this.vrstaList);
            this.Controls.Add(this.nazivInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgProizvodi);
            this.Name = "PregledKreacija";
            this.Text = "Moje kreacije";
            this.Load += new System.EventHandler(this.PregledKreacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProizvodi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProizvodi;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.ComboBox sezonaList;
        private System.Windows.Forms.ComboBox vrstaList;
        private System.Windows.Forms.TextBox nazivInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProizvodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewImageColumn SlikaThumb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Velicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaID;
    }
}