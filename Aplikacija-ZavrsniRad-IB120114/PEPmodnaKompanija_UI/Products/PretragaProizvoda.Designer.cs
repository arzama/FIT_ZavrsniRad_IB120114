namespace PEPmodnaKompanija_UI.Products
{
    partial class PretragaProizvoda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PretragaProizvoda));
            this.dgProizvodi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nazivInput = new System.Windows.Forms.TextBox();
            this.vrstaList = new System.Windows.Forms.ComboBox();
            this.sezonaList = new System.Windows.Forms.ComboBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Velicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrsta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sezona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DizajnerP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgProizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProizvodi
            // 
            this.dgProizvodi.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProizvodi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.Sifra,
            this.Velicina,
            this.Cijena,
            this.Vrsta,
            this.Sezona,
            this.DizajnerP});
            this.dgProizvodi.Location = new System.Drawing.Point(2, 93);
            this.dgProizvodi.Name = "dgProizvodi";
            this.dgProizvodi.ReadOnly = true;
            this.dgProizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProizvodi.Size = new System.Drawing.Size(772, 273);
            this.dgProizvodi.TabIndex = 0;
            this.dgProizvodi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProizvodi_CellClick);
            this.dgProizvodi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProizvodi_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vrsta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sezona";
            // 
            // nazivInput
            // 
            this.nazivInput.Location = new System.Drawing.Point(65, 28);
            this.nazivInput.Name = "nazivInput";
            this.nazivInput.Size = new System.Drawing.Size(199, 20);
            this.nazivInput.TabIndex = 4;
            // 
            // vrstaList
            // 
            this.vrstaList.FormattingEnabled = true;
            this.vrstaList.Location = new System.Drawing.Point(322, 30);
            this.vrstaList.Name = "vrstaList";
            this.vrstaList.Size = new System.Drawing.Size(121, 21);
            this.vrstaList.TabIndex = 5;
            // 
            // sezonaList
            // 
            this.sezonaList.FormattingEnabled = true;
            this.sezonaList.Location = new System.Drawing.Point(515, 30);
            this.sezonaList.Name = "sezonaList";
            this.sezonaList.Size = new System.Drawing.Size(121, 21);
            this.sezonaList.TabIndex = 6;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Image = ((System.Drawing.Image)(resources.GetObject("btnPretraga.Image")));
            this.btnPretraga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPretraga.Location = new System.Drawing.Point(645, 24);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(89, 31);
            this.btnPretraga.TabIndex = 7;
            this.btnPretraga.Text = "Traži";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "*Klikom na odabrani proizvod prikazat će se slika.";
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            this.Sifra.HeaderText = "Šifra";
            this.Sifra.Name = "Sifra";
            this.Sifra.ReadOnly = true;
            // 
            // Velicina
            // 
            this.Velicina.DataPropertyName = "Velicina";
            this.Velicina.HeaderText = "Veličina";
            this.Velicina.Name = "Velicina";
            this.Velicina.ReadOnly = true;
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
            // DizajnerP
            // 
            this.DizajnerP.DataPropertyName = "DizajnerP";
            this.DizajnerP.HeaderText = "Dizajner";
            this.DizajnerP.Name = "DizajnerP";
            this.DizajnerP.ReadOnly = true;
            // 
            // PretragaProizvoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(776, 366);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.sezonaList);
            this.Controls.Add(this.vrstaList);
            this.Controls.Add(this.nazivInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgProizvodi);
            this.MaximizeBox = false;
            this.Name = "PretragaProizvoda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga proizvoda";
            this.Load += new System.EventHandler(this.PretragaProizvoda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProizvodi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProizvodi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nazivInput;
        private System.Windows.Forms.ComboBox vrstaList;
        private System.Windows.Forms.ComboBox sezonaList;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Velicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrsta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sezona;
        private System.Windows.Forms.DataGridViewTextBoxColumn DizajnerP;
    }
}