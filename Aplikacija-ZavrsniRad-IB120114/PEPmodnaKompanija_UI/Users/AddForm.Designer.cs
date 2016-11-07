namespace PEPmodnaKompanija_UI.Users
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dodaj_btn = new System.Windows.Forms.Button();
            this.Imetxt = new System.Windows.Forms.TextBox();
            this.Prezimetxt = new System.Windows.Forms.TextBox();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.KorisnickoImetxt = new System.Windows.Forms.TextBox();
            this.Lozinkatxt = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Telefontxt = new System.Windows.Forms.MaskedTextBox();
            this.radioDizajner = new System.Windows.Forms.RadioButton();
            this.radioAdministrator = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Korisničko ime";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lozinka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(384, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Uloga";
            // 
            // dodaj_btn
            // 
            this.dodaj_btn.Image = ((System.Drawing.Image)(resources.GetObject("dodaj_btn.Image")));
            this.dodaj_btn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.dodaj_btn.Location = new System.Drawing.Point(518, 283);
            this.dodaj_btn.Name = "dodaj_btn";
            this.dodaj_btn.Size = new System.Drawing.Size(104, 33);
            this.dodaj_btn.TabIndex = 7;
            this.dodaj_btn.Text = "Sačuvaj";
            this.dodaj_btn.UseVisualStyleBackColor = true;
            this.dodaj_btn.Click += new System.EventHandler(this.dodaj_btn_Click);
            // 
            // Imetxt
            // 
            this.Imetxt.Location = new System.Drawing.Point(438, 46);
            this.Imetxt.Name = "Imetxt";
            this.Imetxt.Size = new System.Drawing.Size(184, 20);
            this.Imetxt.TabIndex = 8;
            this.Imetxt.Validating += new System.ComponentModel.CancelEventHandler(this.Imetxt_Validating);
            // 
            // Prezimetxt
            // 
            this.Prezimetxt.Location = new System.Drawing.Point(438, 72);
            this.Prezimetxt.Name = "Prezimetxt";
            this.Prezimetxt.Size = new System.Drawing.Size(184, 20);
            this.Prezimetxt.TabIndex = 9;
            // 
            // Emailtxt
            // 
            this.Emailtxt.Location = new System.Drawing.Point(438, 104);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(184, 20);
            this.Emailtxt.TabIndex = 10;
            this.Emailtxt.Validating += new System.ComponentModel.CancelEventHandler(this.Emailtxt_Validating);
            // 
            // KorisnickoImetxt
            // 
            this.KorisnickoImetxt.Location = new System.Drawing.Point(438, 158);
            this.KorisnickoImetxt.Name = "KorisnickoImetxt";
            this.KorisnickoImetxt.Size = new System.Drawing.Size(184, 20);
            this.KorisnickoImetxt.TabIndex = 12;
            this.KorisnickoImetxt.Validating += new System.ComponentModel.CancelEventHandler(this.KorisnickoImetxt_Validating);
            // 
            // Lozinkatxt
            // 
            this.Lozinkatxt.Location = new System.Drawing.Point(438, 184);
            this.Lozinkatxt.Name = "Lozinkatxt";
            this.Lozinkatxt.Size = new System.Drawing.Size(184, 20);
            this.Lozinkatxt.TabIndex = 13;
            this.Lozinkatxt.Validating += new System.ComponentModel.CancelEventHandler(this.Lozinkatxt_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // Telefontxt
            // 
            this.Telefontxt.Location = new System.Drawing.Point(438, 130);
            this.Telefontxt.Mask = "(999) 000-0000";
            this.Telefontxt.Name = "Telefontxt";
            this.Telefontxt.Size = new System.Drawing.Size(184, 20);
            this.Telefontxt.TabIndex = 15;
            // 
            // radioDizajner
            // 
            this.radioDizajner.AutoSize = true;
            this.radioDizajner.Location = new System.Drawing.Point(438, 215);
            this.radioDizajner.Name = "radioDizajner";
            this.radioDizajner.Size = new System.Drawing.Size(63, 17);
            this.radioDizajner.TabIndex = 16;
            this.radioDizajner.TabStop = true;
            this.radioDizajner.Text = "Dizajner";
            this.radioDizajner.UseVisualStyleBackColor = true;
            this.radioDizajner.Validating += new System.ComponentModel.CancelEventHandler(this.radioDizajner_Validating);
            // 
            // radioAdministrator
            // 
            this.radioAdministrator.AutoSize = true;
            this.radioAdministrator.Location = new System.Drawing.Point(438, 239);
            this.radioAdministrator.Name = "radioAdministrator";
            this.radioAdministrator.Size = new System.Drawing.Size(85, 17);
            this.radioAdministrator.TabIndex = 17;
            this.radioAdministrator.TabStop = true;
            this.radioAdministrator.Text = "Administrator";
            this.radioAdministrator.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(31, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 264);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(651, 360);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radioAdministrator);
            this.Controls.Add(this.radioDizajner);
            this.Controls.Add(this.Telefontxt);
            this.Controls.Add(this.Lozinkatxt);
            this.Controls.Add(this.KorisnickoImetxt);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.Prezimetxt);
            this.Controls.Add(this.Imetxt);
            this.Controls.Add(this.dodaj_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi korisnik";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button dodaj_btn;
        private System.Windows.Forms.TextBox Imetxt;
        private System.Windows.Forms.TextBox Prezimetxt;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.TextBox KorisnickoImetxt;
        private System.Windows.Forms.TextBox Lozinkatxt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox Telefontxt;
        private System.Windows.Forms.RadioButton radioAdministrator;
        private System.Windows.Forms.RadioButton radioDizajner;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}