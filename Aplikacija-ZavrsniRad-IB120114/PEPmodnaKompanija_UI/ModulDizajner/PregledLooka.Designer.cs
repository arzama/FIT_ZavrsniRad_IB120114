namespace PEPmodnaKompanija_UI.ModulDizajner
{
    partial class PregledLooka
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
            this.ModelpictureBox = new System.Windows.Forms.PictureBox();
            this.dgStavkeModela = new System.Windows.Forms.DataGridView();
            this.SlikaThumb = new System.Windows.Forms.DataGridViewImageColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvodPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ModelpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStavkeModela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModelpictureBox
            // 
            this.ModelpictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ModelpictureBox.Location = new System.Drawing.Point(160, 12);
            this.ModelpictureBox.Name = "ModelpictureBox";
            this.ModelpictureBox.Size = new System.Drawing.Size(200, 280);
            this.ModelpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ModelpictureBox.TabIndex = 51;
            this.ModelpictureBox.TabStop = false;
            this.ModelpictureBox.Click += new System.EventHandler(this.ModelpictureBox_Click);
            // 
            // dgStavkeModela
            // 
            this.dgStavkeModela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStavkeModela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlikaThumb,
            this.Naziv,
            this.Cijena});
            this.dgStavkeModela.Location = new System.Drawing.Point(6, 53);
            this.dgStavkeModela.Name = "dgStavkeModela";
            this.dgStavkeModela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgStavkeModela.Size = new System.Drawing.Size(360, 150);
            this.dgStavkeModela.TabIndex = 52;
            this.dgStavkeModela.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgStavkeModela_CellClick);
            this.dgStavkeModela.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgStavkeModela_CellContentClick);
            // 
            // SlikaThumb
            // 
            this.SlikaThumb.DataPropertyName = "SlikaThumb";
            this.SlikaThumb.HeaderText = "Slika proizvoda";
            this.SlikaThumb.Name = "SlikaThumb";
            this.SlikaThumb.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SlikaThumb.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SlikaThumb.Visible = false;
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
            // proizvodPictureBox
            // 
            this.proizvodPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.proizvodPictureBox.Location = new System.Drawing.Point(372, 72);
            this.proizvodPictureBox.Name = "proizvodPictureBox";
            this.proizvodPictureBox.Size = new System.Drawing.Size(120, 120);
            this.proizvodPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.proizvodPictureBox.TabIndex = 82;
            this.proizvodPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "*Klikom na proizvod vidite sliku.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgStavkeModela);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.proizvodPictureBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 219);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proizvodi sa modela";
            // 
            // PregledLooka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 583);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ModelpictureBox);
            this.Name = "PregledLooka";
            this.Text = "Look i stavke look-a";
            this.Load += new System.EventHandler(this.PregledLooka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ModelpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStavkeModela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ModelpictureBox;
        private System.Windows.Forms.DataGridView dgStavkeModela;
        private System.Windows.Forms.PictureBox proizvodPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewImageColumn SlikaThumb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
    }
}