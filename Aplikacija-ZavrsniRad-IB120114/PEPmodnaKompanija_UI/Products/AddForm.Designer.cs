namespace PEPmodnaKompanija_UI.Products
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
            this.dodajButton = new System.Windows.Forms.Button();
            this.dodajSlikuButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.slikaInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nazivInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sifraInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sezonaList = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.vrstaList = new System.Windows.Forms.ComboBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.dizajneriList = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cijenaInput = new System.Windows.Forms.TextBox();
            this.velicinaList = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dodajButton
            // 
            this.dodajButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dodajButton.Image = ((System.Drawing.Image)(resources.GetObject("dodajButton.Image")));
            this.dodajButton.Location = new System.Drawing.Point(582, 241);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(98, 43);
            this.dodajButton.TabIndex = 56;
            this.dodajButton.Text = "Sačuvaj";
            this.dodajButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dodajButton.UseVisualStyleBackColor = false;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // dodajSlikuButton
            // 
            this.dodajSlikuButton.Location = new System.Drawing.Point(443, 215);
            this.dodajSlikuButton.Name = "dodajSlikuButton";
            this.dodajSlikuButton.Size = new System.Drawing.Size(51, 23);
            this.dodajSlikuButton.TabIndex = 54;
            this.dodajSlikuButton.Text = "Dodaj";
            this.dodajSlikuButton.UseVisualStyleBackColor = true;
            this.dodajSlikuButton.Click += new System.EventHandler(this.dodajSlikuButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(560, 28);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(120, 120);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 64;
            this.pictureBox.TabStop = false;
            // 
            // slikaInput
            // 
            this.slikaInput.Location = new System.Drawing.Point(228, 217);
            this.slikaInput.Name = "slikaInput";
            this.slikaInput.Size = new System.Drawing.Size(209, 20);
            this.slikaInput.TabIndex = 58;
            this.slikaInput.TabStop = false;
            this.slikaInput.Validating += new System.ComponentModel.CancelEventHandler(this.slikaInput_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Slika:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Vrsta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Cijena:";
            // 
            // nazivInput
            // 
            this.nazivInput.Location = new System.Drawing.Point(228, 114);
            this.nazivInput.Name = "nazivInput";
            this.nazivInput.Size = new System.Drawing.Size(209, 20);
            this.nazivInput.TabIndex = 52;
            this.nazivInput.Validating += new System.ComponentModel.CancelEventHandler(this.nazivInput_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Naziv:";
            // 
            // sifraInput
            // 
            this.sifraInput.Location = new System.Drawing.Point(228, 88);
            this.sifraInput.Name = "sifraInput";
            this.sifraInput.Size = new System.Drawing.Size(209, 20);
            this.sifraInput.TabIndex = 51;
            this.sifraInput.Validating += new System.ComponentModel.CancelEventHandler(this.sifraInput_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Šifra:";
            // 
            // sezonaList
            // 
            this.sezonaList.FormattingEnabled = true;
            this.sezonaList.Location = new System.Drawing.Point(228, 61);
            this.sezonaList.Name = "sezonaList";
            this.sezonaList.Size = new System.Drawing.Size(209, 21);
            this.sezonaList.TabIndex = 65;
            this.sezonaList.Validating += new System.ComponentModel.CancelEventHandler(this.sezonaList_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "Sezona:";
            // 
            // vrstaList
            // 
            this.vrstaList.FormattingEnabled = true;
            this.vrstaList.Location = new System.Drawing.Point(228, 28);
            this.vrstaList.Name = "vrstaList";
            this.vrstaList.Size = new System.Drawing.Size(209, 21);
            this.vrstaList.TabIndex = 67;
            this.vrstaList.Validating += new System.ComponentModel.CancelEventHandler(this.vrstaList_Validating);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 70;
            this.label8.Text = "Dizajner:";
            // 
            // dizajneriList
            // 
            this.dizajneriList.FormattingEnabled = true;
            this.dizajneriList.Location = new System.Drawing.Point(228, 143);
            this.dizajneriList.Name = "dizajneriList";
            this.dizajneriList.Size = new System.Drawing.Size(209, 21);
            this.dizajneriList.TabIndex = 71;
            this.dizajneriList.Validating += new System.ComponentModel.CancelEventHandler(this.dizajneriList_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cijenaInput
            // 
            this.cijenaInput.Location = new System.Drawing.Point(228, 171);
            this.cijenaInput.Name = "cijenaInput";
            this.cijenaInput.Size = new System.Drawing.Size(83, 20);
            this.cijenaInput.TabIndex = 83;
            this.cijenaInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cijenaInput_KeyPress);
            this.cijenaInput.Validating += new System.ComponentModel.CancelEventHandler(this.cijenaInput_Validating);
            // 
            // velicinaList
            // 
            this.velicinaList.FormattingEnabled = true;
            this.velicinaList.Location = new System.Drawing.Point(378, 170);
            this.velicinaList.Name = "velicinaList";
            this.velicinaList.Size = new System.Drawing.Size(59, 21);
            this.velicinaList.TabIndex = 85;
            this.velicinaList.Validating += new System.ComponentModel.CancelEventHandler(this.velicinaList_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(324, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 84;
            this.label9.Text = "Veličina:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 125);
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(701, 335);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.velicinaList);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cijenaInput);
            this.Controls.Add(this.dizajneriList);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.vrstaList);
            this.Controls.Add(this.sezonaList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.dodajSlikuButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.slikaInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nazivInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sifraInput);
            this.Controls.Add(this.label1);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi proizvod";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Button dodajSlikuButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox slikaInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nazivInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sifraInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sezonaList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox vrstaList;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox dizajneriList;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox cijenaInput;
        private System.Windows.Forms.ComboBox velicinaList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}