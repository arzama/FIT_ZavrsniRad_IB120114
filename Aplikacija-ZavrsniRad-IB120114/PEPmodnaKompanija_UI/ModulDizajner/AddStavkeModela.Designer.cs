namespace PEPmodnaKompanija_UI.ModulDizajner
{
    partial class AddStavkeModela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStavkeModela));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.stavkeGrid = new System.Windows.Forms.DataGridView();
            this.SlikaThumb = new System.Windows.Forms.DataGridViewImageColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProizvodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakljuciButton = new System.Windows.Forms.Button();
            this.dodajStavkuButton = new System.Windows.Forms.Button();
            this.sifraInput = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.stavkeGrid);
            this.groupBox3.Controls.Add(this.zakljuciButton);
            this.groupBox3.Controls.Add(this.dodajStavkuButton);
            this.groupBox3.Controls.Add(this.sifraInput);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(618, 222);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stavke";
            // 
            // stavkeGrid
            // 
            this.stavkeGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.stavkeGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.stavkeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stavkeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlikaThumb,
            this.Naziv,
            this.Cijena,
            this.ProizvodID});
            this.stavkeGrid.Location = new System.Drawing.Point(6, 45);
            this.stavkeGrid.Name = "stavkeGrid";
            this.stavkeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stavkeGrid.Size = new System.Drawing.Size(438, 158);
            this.stavkeGrid.TabIndex = 7;
            this.stavkeGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stavkeGrid_CellContentClick_1);
            // 
            // SlikaThumb
            // 
            this.SlikaThumb.DataPropertyName = "SlikaThumb";
            this.SlikaThumb.HeaderText = "Slika";
            this.SlikaThumb.Name = "SlikaThumb";
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Naziv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cijena.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ProizvodID
            // 
            this.ProizvodID.DataPropertyName = "ProizvodID";
            this.ProizvodID.HeaderText = "ProizvodID";
            this.ProizvodID.Name = "ProizvodID";
            this.ProizvodID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProizvodID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProizvodID.Visible = false;
            // 
            // zakljuciButton
            // 
            this.zakljuciButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.zakljuciButton.Image = ((System.Drawing.Image)(resources.GetObject("zakljuciButton.Image")));
            this.zakljuciButton.Location = new System.Drawing.Point(461, 176);
            this.zakljuciButton.Name = "zakljuciButton";
            this.zakljuciButton.Size = new System.Drawing.Size(100, 27);
            this.zakljuciButton.TabIndex = 10;
            this.zakljuciButton.Text = "Sačuvaj";
            this.zakljuciButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.zakljuciButton.UseVisualStyleBackColor = false;
            this.zakljuciButton.Click += new System.EventHandler(this.zakljuciButton_Click);
            // 
            // dodajStavkuButton
            // 
            this.dodajStavkuButton.Image = ((System.Drawing.Image)(resources.GetObject("dodajStavkuButton.Image")));
            this.dodajStavkuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dodajStavkuButton.Location = new System.Drawing.Point(339, 8);
            this.dodajStavkuButton.Name = "dodajStavkuButton";
            this.dodajStavkuButton.Size = new System.Drawing.Size(79, 25);
            this.dodajStavkuButton.TabIndex = 9;
            this.dodajStavkuButton.Text = "Dodaj";
            this.dodajStavkuButton.UseVisualStyleBackColor = true;
            this.dodajStavkuButton.Click += new System.EventHandler(this.dodajStavkuButton_Click);
            // 
            // sifraInput
            // 
            this.sifraInput.Location = new System.Drawing.Point(199, 11);
            this.sifraInput.Name = "sifraInput";
            this.sifraInput.Size = new System.Drawing.Size(124, 20);
            this.sifraInput.TabIndex = 6;
            this.sifraInput.Validating += new System.ComponentModel.CancelEventHandler(this.sifraInput_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(113, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Šifra proizvoda:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddStavkeModela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 264);
            this.Controls.Add(this.groupBox3);
            this.Name = "AddStavkeModela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stavke looka";
            this.Load += new System.EventHandler(this.AddStavkeModela_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button zakljuciButton;
        private System.Windows.Forms.Button dodajStavkuButton;
        private System.Windows.Forms.TextBox sifraInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridView stavkeGrid;
        private System.Windows.Forms.DataGridViewImageColumn SlikaThumb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProizvodID;

    }
}