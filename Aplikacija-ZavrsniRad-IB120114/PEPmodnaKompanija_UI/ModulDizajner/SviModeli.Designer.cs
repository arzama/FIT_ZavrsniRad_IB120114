namespace PEPmodnaKompanija_UI.ModulDizajner
{
    partial class SviModeli
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
            this.dgModeli = new System.Windows.Forms.DataGridView();
            this.ModelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Revija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgStavkeModela = new System.Windows.Forms.DataGridView();
            this.SlikaThumb = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelpictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgModeli)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStavkeModela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dgModeli
            // 
            this.dgModeli.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgModeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgModeli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModelID,
            this.Naziv,
            this.Revija,
            this.Opis});
            this.dgModeli.Location = new System.Drawing.Point(255, 56);
            this.dgModeli.Name = "dgModeli";
            this.dgModeli.ReadOnly = true;
            this.dgModeli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgModeli.Size = new System.Drawing.Size(345, 200);
            this.dgModeli.TabIndex = 0;
            this.dgModeli.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgModeli_CellClick);
            // 
            // ModelID
            // 
            this.ModelID.DataPropertyName = "ModelID";
            this.ModelID.HeaderText = "ModelID";
            this.ModelID.Name = "ModelID";
            this.ModelID.ReadOnly = true;
            this.ModelID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Revija
            // 
            this.Revija.DataPropertyName = "Revija";
            this.Revija.HeaderText = "Revija";
            this.Revija.Name = "Revija";
            this.Revija.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "*Klikom na look prikažite detalje.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgStavkeModela);
            this.groupBox1.Location = new System.Drawing.Point(444, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 261);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proizvodi sa look-a";
            // 
            // dgStavkeModela
            // 
            this.dgStavkeModela.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgStavkeModela.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgStavkeModela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStavkeModela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlikaThumb,
            this.dataGridViewTextBoxColumn1,
            this.Cijena});
            this.dgStavkeModela.Location = new System.Drawing.Point(27, 33);
            this.dgStavkeModela.Name = "dgStavkeModela";
            this.dgStavkeModela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgStavkeModela.Size = new System.Drawing.Size(360, 202);
            this.dgStavkeModela.TabIndex = 52;
            // 
            // SlikaThumb
            // 
            this.SlikaThumb.DataPropertyName = "SlikaThumb";
            this.SlikaThumb.HeaderText = "Slika proizvoda";
            this.SlikaThumb.Name = "SlikaThumb";
            this.SlikaThumb.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SlikaThumb.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Naziv";
            this.dataGridViewTextBoxColumn1.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            // 
            // ModelpictureBox
            // 
            this.ModelpictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ModelpictureBox.Location = new System.Drawing.Point(12, 302);
            this.ModelpictureBox.Name = "ModelpictureBox";
            this.ModelpictureBox.Size = new System.Drawing.Size(400, 250);
            this.ModelpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ModelpictureBox.TabIndex = 85;
            this.ModelpictureBox.TabStop = false;
            // 
            // SviModeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(866, 601);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ModelpictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgModeli);
            this.Name = "SviModeli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prikaz svih lookova";
            this.Load += new System.EventHandler(this.SviModeli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgModeli)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgStavkeModela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgModeli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Revija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgStavkeModela;
        private System.Windows.Forms.PictureBox ModelpictureBox;
        private System.Windows.Forms.DataGridViewImageColumn SlikaThumb;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
    }
}