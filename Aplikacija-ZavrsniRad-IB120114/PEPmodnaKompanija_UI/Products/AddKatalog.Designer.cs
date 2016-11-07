namespace PEPmodnaKompanija_UI.Products
{
    partial class AddKatalog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddKatalog));
            this.nazivInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgProizvodi = new System.Windows.Forms.DataGridView();
            this.addKatalogBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.sezoneList = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grou = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ProizvodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odaberi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrsta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sezona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgProizvodi)).BeginInit();
            this.grou.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nazivInput
            // 
            this.nazivInput.Location = new System.Drawing.Point(132, 28);
            this.nazivInput.Name = "nazivInput";
            this.nazivInput.Size = new System.Drawing.Size(278, 20);
            this.nazivInput.TabIndex = 0;
            this.nazivInput.Validating += new System.ComponentModel.CancelEventHandler(this.nazivInput_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv kataloga:";
            // 
            // dgProizvodi
            // 
            this.dgProizvodi.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProizvodi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProizvodID,
            this.Odaberi,
            this.Naziv,
            this.Sifra,
            this.Cijena,
            this.Vrsta,
            this.Sezona});
            this.dgProizvodi.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgProizvodi.Location = new System.Drawing.Point(21, 120);
            this.dgProizvodi.Name = "dgProizvodi";
            this.dgProizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProizvodi.Size = new System.Drawing.Size(745, 256);
            this.dgProizvodi.TabIndex = 7;
            this.dgProizvodi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProizvodi_CellContentClick);
            // 
            // addKatalogBtn
            // 
            this.addKatalogBtn.Image = ((System.Drawing.Image)(resources.GetObject("addKatalogBtn.Image")));
            this.addKatalogBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addKatalogBtn.Location = new System.Drawing.Point(644, 468);
            this.addKatalogBtn.Name = "addKatalogBtn";
            this.addKatalogBtn.Size = new System.Drawing.Size(124, 39);
            this.addKatalogBtn.TabIndex = 8;
            this.addKatalogBtn.Text = "Dodaj katalog";
            this.addKatalogBtn.UseVisualStyleBackColor = true;
            this.addKatalogBtn.Click += new System.EventHandler(this.addKatalogBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(202, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Sezona:";
            // 
            // sezoneList
            // 
            this.sezoneList.FormattingEnabled = true;
            this.sezoneList.Location = new System.Drawing.Point(273, 34);
            this.sezoneList.Name = "sezoneList";
            this.sezoneList.Size = new System.Drawing.Size(121, 21);
            this.sezoneList.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(433, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Pretraži";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "*Klikom na checkbox odaberite proizvode za katalog.";
            // 
            // grou
            // 
            this.grou.Controls.Add(this.label5);
            this.grou.Controls.Add(this.dgProizvodi);
            this.grou.Controls.Add(this.button1);
            this.grou.Controls.Add(this.sezoneList);
            this.grou.Controls.Add(this.label4);
            this.grou.Location = new System.Drawing.Point(16, 80);
            this.grou.Name = "grou";
            this.grou.Size = new System.Drawing.Size(811, 382);
            this.grou.TabIndex = 22;
            this.grou.TabStop = false;
            this.grou.Text = "Stavke kataloga";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ProizvodID
            // 
            this.ProizvodID.DataPropertyName = "ProizvodID";
            this.ProizvodID.HeaderText = "ProizvodID";
            this.ProizvodID.Name = "ProizvodID";
            this.ProizvodID.Visible = false;
            // 
            // Odaberi
            // 
            this.Odaberi.HeaderText = "Odaberi";
            this.Odaberi.Name = "Odaberi";
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
            this.Sifra.HeaderText = "Sifra";
            this.Sifra.Name = "Sifra";
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            // 
            // Vrsta
            // 
            this.Vrsta.DataPropertyName = "Vrsta";
            this.Vrsta.HeaderText = "Vrsta";
            this.Vrsta.Name = "Vrsta";
            // 
            // Sezona
            // 
            this.Sezona.DataPropertyName = "Sezona";
            this.Sezona.HeaderText = "Sezona";
            this.Sezona.Name = "Sezona";
            // 
            // AddKatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 529);
            this.Controls.Add(this.grou);
            this.Controls.Add(this.addKatalogBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nazivInput);
            this.Name = "AddKatalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi katalog";
            this.Load += new System.EventHandler(this.AddKatalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProizvodi)).EndInit();
            this.grou.ResumeLayout(false);
            this.grou.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nazivInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgProizvodi;
        private System.Windows.Forms.Button addKatalogBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sezoneList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grou;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProizvodID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Odaberi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrsta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sezona;
    }
}