namespace PEPmodnaKompanija_UI.Users
{
    partial class AdministracijaKorisnika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministracijaKorisnika));
            this.label1 = new System.Windows.Forms.Label();
            this.imePrezimeInput = new System.Windows.Forms.TextBox();
            this.dgKorisnici = new System.Windows.Forms.DataGridView();
            this.KorisnikID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.noviKorisnik_btn = new System.Windows.Forms.Button();
            this.btn_Trazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime i prezime:";
            // 
            // imePrezimeInput
            // 
            this.imePrezimeInput.Location = new System.Drawing.Point(101, 16);
            this.imePrezimeInput.Name = "imePrezimeInput";
            this.imePrezimeInput.Size = new System.Drawing.Size(252, 20);
            this.imePrezimeInput.TabIndex = 6;
            // 
            // dgKorisnici
            // 
            this.dgKorisnici.AllowUserToAddRows = false;
            this.dgKorisnici.AllowUserToDeleteRows = false;
            this.dgKorisnici.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKorisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KorisnikID,
            this.Ime,
            this.Prezime,
            this.Email,
            this.Telefon,
            this.KorisnickoIme,
            this.Aktivan});
            this.dgKorisnici.Location = new System.Drawing.Point(-1, 63);
            this.dgKorisnici.Name = "dgKorisnici";
            this.dgKorisnici.ReadOnly = true;
            this.dgKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKorisnici.Size = new System.Drawing.Size(681, 303);
            this.dgKorisnici.TabIndex = 12;
            this.dgKorisnici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKorisnici_CellContentClick);
            // 
            // KorisnikID
            // 
            this.KorisnikID.DataPropertyName = "KorisnikID";
            this.KorisnikID.HeaderText = "KorisnikID";
            this.KorisnikID.Name = "KorisnikID";
            this.KorisnikID.ReadOnly = true;
            this.KorisnikID.Visible = false;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "Korisničko ime";
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.ReadOnly = true;
            // 
            // Aktivan
            // 
            this.Aktivan.DataPropertyName = "Status";
            this.Aktivan.HeaderText = "Aktivan";
            this.Aktivan.Name = "Aktivan";
            this.Aktivan.ReadOnly = true;
            this.Aktivan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Aktivan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // noviKorisnik_btn
            // 
            this.noviKorisnik_btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.noviKorisnik_btn.Image = ((System.Drawing.Image)(resources.GetObject("noviKorisnik_btn.Image")));
            this.noviKorisnik_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.noviKorisnik_btn.Location = new System.Drawing.Point(487, 12);
            this.noviKorisnik_btn.Name = "noviKorisnik_btn";
            this.noviKorisnik_btn.Size = new System.Drawing.Size(114, 33);
            this.noviKorisnik_btn.TabIndex = 14;
            this.noviKorisnik_btn.Text = "Novi korisnik";
            this.noviKorisnik_btn.UseVisualStyleBackColor = false;
            this.noviKorisnik_btn.Click += new System.EventHandler(this.noviKorisnik_btn_Click);
            // 
            // btn_Trazi
            // 
            this.btn_Trazi.Image = ((System.Drawing.Image)(resources.GetObject("btn_Trazi.Image")));
            this.btn_Trazi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Trazi.Location = new System.Drawing.Point(359, 14);
            this.btn_Trazi.Name = "btn_Trazi";
            this.btn_Trazi.Size = new System.Drawing.Size(95, 23);
            this.btn_Trazi.TabIndex = 15;
            this.btn_Trazi.Text = "Traži";
            this.btn_Trazi.UseVisualStyleBackColor = true;
            this.btn_Trazi.Click += new System.EventHandler(this.btn_Trazi_Click);
            // 
            // AdministracijaKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 367);
            this.Controls.Add(this.btn_Trazi);
            this.Controls.Add(this.noviKorisnik_btn);
            this.Controls.Add(this.dgKorisnici);
            this.Controls.Add(this.imePrezimeInput);
            this.Controls.Add(this.label1);
            this.Name = "AdministracijaKorisnika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled korisnika";
            this.Load += new System.EventHandler(this.AdministracijaKorisnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox imePrezimeInput;
        private System.Windows.Forms.DataGridView dgKorisnici;
        private System.Windows.Forms.Button noviKorisnik_btn;
        private System.Windows.Forms.Button btn_Trazi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktivan;
    }
}