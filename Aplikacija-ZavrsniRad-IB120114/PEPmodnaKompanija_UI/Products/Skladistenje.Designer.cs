namespace PEPmodnaKompanija_UI.Products
{
    partial class Skladistenje
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Skladistenje));
            this.label1 = new System.Windows.Forms.Label();
            this.skladisteList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNoviProizvod = new System.Windows.Forms.Button();
            this.kolicinaInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sifraInput = new System.Windows.Forms.TextBox();
            this.dgStavkeSkladistenja = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnPretraziProizvode = new System.Windows.Forms.Button();
            this.ProizvodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrsta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dizajner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgStavkeSkladistenja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Skladište:";
            // 
            // skladisteList
            // 
            this.skladisteList.FormattingEnabled = true;
            this.skladisteList.Location = new System.Drawing.Point(113, 23);
            this.skladisteList.Name = "skladisteList";
            this.skladisteList.Size = new System.Drawing.Size(163, 21);
            this.skladisteList.TabIndex = 1;
            this.skladisteList.SelectedIndexChanged += new System.EventHandler(this.skladisteList_SelectedIndexChanged);
            this.skladisteList.Validating += new System.ComponentModel.CancelEventHandler(this.skladisteList_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Šifra proizvoda:";
            // 
            // btnNoviProizvod
            // 
            this.btnNoviProizvod.Image = ((System.Drawing.Image)(resources.GetObject("btnNoviProizvod.Image")));
            this.btnNoviProizvod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoviProizvod.Location = new System.Drawing.Point(536, 13);
            this.btnNoviProizvod.Name = "btnNoviProizvod";
            this.btnNoviProizvod.Size = new System.Drawing.Size(138, 36);
            this.btnNoviProizvod.TabIndex = 3;
            this.btnNoviProizvod.Text = "Novi proizvod";
            this.btnNoviProizvod.UseVisualStyleBackColor = true;
            this.btnNoviProizvod.Click += new System.EventHandler(this.btnNoviProizvod_Click);
            // 
            // kolicinaInput
            // 
            this.kolicinaInput.Location = new System.Drawing.Point(300, 92);
            this.kolicinaInput.Name = "kolicinaInput";
            this.kolicinaInput.Size = new System.Drawing.Size(100, 20);
            this.kolicinaInput.TabIndex = 4;
            this.kolicinaInput.Validating += new System.ComponentModel.CancelEventHandler(this.kolicinaInput_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Količina:";
            // 
            // sifraInput
            // 
            this.sifraInput.Location = new System.Drawing.Point(123, 92);
            this.sifraInput.Name = "sifraInput";
            this.sifraInput.Size = new System.Drawing.Size(100, 20);
            this.sifraInput.TabIndex = 6;
            this.sifraInput.Validating += new System.ComponentModel.CancelEventHandler(this.sifraInput_Validating);
            // 
            // dgStavkeSkladistenja
            // 
            this.dgStavkeSkladistenja.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgStavkeSkladistenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStavkeSkladistenja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProizvodID,
            this.Naziv,
            this.Sifra,
            this.Vrsta,
            this.Kolicina,
            this.Cijena,
            this.Dizajner});
            this.dgStavkeSkladistenja.Location = new System.Drawing.Point(31, 132);
            this.dgStavkeSkladistenja.Name = "dgStavkeSkladistenja";
            this.dgStavkeSkladistenja.Size = new System.Drawing.Size(643, 213);
            this.dgStavkeSkladistenja.TabIndex = 7;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDodaj.Image = ((System.Drawing.Image)(resources.GetObject("btnDodaj.Image")));
            this.btnDodaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodaj.Location = new System.Drawing.Point(420, 88);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(101, 27);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnPretraziProizvode
            // 
            this.btnPretraziProizvode.Image = ((System.Drawing.Image)(resources.GetObject("btnPretraziProizvode.Image")));
            this.btnPretraziProizvode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPretraziProizvode.Location = new System.Drawing.Point(536, 55);
            this.btnPretraziProizvode.Name = "btnPretraziProizvode";
            this.btnPretraziProizvode.Size = new System.Drawing.Size(138, 36);
            this.btnPretraziProizvode.TabIndex = 9;
            this.btnPretraziProizvode.Text = "Pretraži proizvode";
            this.btnPretraziProizvode.UseVisualStyleBackColor = true;
            this.btnPretraziProizvode.Click += new System.EventHandler(this.btnPretraziProizvode_Click);
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
            // Sifra
            // 
            this.Sifra.DataPropertyName = "Sifra";
            this.Sifra.HeaderText = "Šifra";
            this.Sifra.Name = "Sifra";
            // 
            // Vrsta
            // 
            this.Vrsta.DataPropertyName = "Vrsta";
            this.Vrsta.HeaderText = "Vrsta";
            this.Vrsta.Name = "Vrsta";
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Količina";
            this.Kolicina.Name = "Kolicina";
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            // 
            // Dizajner
            // 
            this.Dizajner.DataPropertyName = "Dizajner";
            this.Dizajner.HeaderText = "Dizajner";
            this.Dizajner.Name = "Dizajner";
            // 
            // Skladistenje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(712, 357);
            this.Controls.Add(this.btnPretraziProizvode);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgStavkeSkladistenja);
            this.Controls.Add(this.sifraInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kolicinaInput);
            this.Controls.Add(this.btnNoviProizvod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.skladisteList);
            this.Controls.Add(this.label1);
            this.Name = "Skladistenje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skladištenje proizvoda";
            this.Load += new System.EventHandler(this.Skladistenje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgStavkeSkladistenja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox skladisteList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNoviProizvod;
        private System.Windows.Forms.TextBox kolicinaInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sifraInput;
        private System.Windows.Forms.DataGridView dgStavkeSkladistenja;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnPretraziProizvode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProizvodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrsta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dizajner;
    }
}