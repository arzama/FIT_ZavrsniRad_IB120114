namespace PEPmodnaKompanija_UI.ModulDizajner
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
            this.pretragaDButton = new System.Windows.Forms.Button();
            this.telefonDInput = new System.Windows.Forms.TextBox();
            this.kontaktDInput = new System.Windows.Forms.TextBox();
            this.nazivDInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.revijeList = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.revijeCbx = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nazivInput = new System.Windows.Forms.TextBox();
            this.dodajModelBtn = new System.Windows.Forms.Button();
            this.doajSlikuModelaBtn = new System.Windows.Forms.Button();
            this.ModelpictureBox = new System.Windows.Forms.PictureBox();
            this.slikaModelaInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.opisInput = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.revijeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModelpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // pretragaDButton
            // 
            this.pretragaDButton.Location = new System.Drawing.Point(336, 60);
            this.pretragaDButton.Name = "pretragaDButton";
            this.pretragaDButton.Size = new System.Drawing.Size(100, 47);
            this.pretragaDButton.TabIndex = 7;
            this.pretragaDButton.Text = "Pretraga";
            this.pretragaDButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pretragaDButton.UseVisualStyleBackColor = true;
            // 
            // telefonDInput
            // 
            this.telefonDInput.Location = new System.Drawing.Point(103, 87);
            this.telefonDInput.Name = "telefonDInput";
            this.telefonDInput.ReadOnly = true;
            this.telefonDInput.Size = new System.Drawing.Size(217, 20);
            this.telefonDInput.TabIndex = 3;
            this.telefonDInput.TabStop = false;
            // 
            // kontaktDInput
            // 
            this.kontaktDInput.Location = new System.Drawing.Point(103, 58);
            this.kontaktDInput.Name = "kontaktDInput";
            this.kontaktDInput.ReadOnly = true;
            this.kontaktDInput.Size = new System.Drawing.Size(217, 20);
            this.kontaktDInput.TabIndex = 4;
            this.kontaktDInput.TabStop = false;
            // 
            // nazivDInput
            // 
            this.nazivDInput.Location = new System.Drawing.Point(103, 29);
            this.nazivDInput.Name = "nazivDInput";
            this.nazivDInput.ReadOnly = true;
            this.nazivDInput.Size = new System.Drawing.Size(217, 20);
            this.nazivDInput.TabIndex = 5;
            this.nazivDInput.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kontakt osoba:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // revijeList
            // 
            this.revijeList.BackColor = System.Drawing.Color.White;
            this.revijeList.Controls.Add(this.label5);
            this.revijeList.Controls.Add(this.revijeCbx);
            this.revijeList.Controls.Add(this.label4);
            this.revijeList.Controls.Add(this.nazivInput);
            this.revijeList.Controls.Add(this.dodajModelBtn);
            this.revijeList.Controls.Add(this.doajSlikuModelaBtn);
            this.revijeList.Controls.Add(this.ModelpictureBox);
            this.revijeList.Controls.Add(this.slikaModelaInput);
            this.revijeList.Controls.Add(this.label7);
            this.revijeList.Controls.Add(this.opisInput);
            this.revijeList.Controls.Add(this.label12);
            this.revijeList.Location = new System.Drawing.Point(8, 12);
            this.revijeList.Name = "revijeList";
            this.revijeList.Size = new System.Drawing.Size(653, 278);
            this.revijeList.TabIndex = 14;
            this.revijeList.TabStop = false;
            this.revijeList.Text = "Look";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 84;
            this.label5.Text = "Revija:";
            // 
            // revijeCbx
            // 
            this.revijeCbx.FormattingEnabled = true;
            this.revijeCbx.Location = new System.Drawing.Point(103, 19);
            this.revijeCbx.Name = "revijeCbx";
            this.revijeCbx.Size = new System.Drawing.Size(217, 21);
            this.revijeCbx.TabIndex = 83;
            this.revijeCbx.Validating += new System.ComponentModel.CancelEventHandler(this.revijeCbx_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 82;
            this.label4.Text = "Naziv";
            // 
            // nazivInput
            // 
            this.nazivInput.Location = new System.Drawing.Point(103, 76);
            this.nazivInput.Name = "nazivInput";
            this.nazivInput.Size = new System.Drawing.Size(217, 20);
            this.nazivInput.TabIndex = 81;
            this.nazivInput.Validating += new System.ComponentModel.CancelEventHandler(this.nazivInput_Validating);
            // 
            // dodajModelBtn
            // 
            this.dodajModelBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dodajModelBtn.Image = ((System.Drawing.Image)(resources.GetObject("dodajModelBtn.Image")));
            this.dodajModelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dodajModelBtn.Location = new System.Drawing.Point(211, 213);
            this.dodajModelBtn.Name = "dodajModelBtn";
            this.dodajModelBtn.Size = new System.Drawing.Size(109, 42);
            this.dodajModelBtn.TabIndex = 80;
            this.dodajModelBtn.Text = "Dodaj look";
            this.dodajModelBtn.UseVisualStyleBackColor = false;
            this.dodajModelBtn.Click += new System.EventHandler(this.dodajModelBtn_Click);
            // 
            // doajSlikuModelaBtn
            // 
            this.doajSlikuModelaBtn.Location = new System.Drawing.Point(326, 48);
            this.doajSlikuModelaBtn.Name = "doajSlikuModelaBtn";
            this.doajSlikuModelaBtn.Size = new System.Drawing.Size(51, 23);
            this.doajSlikuModelaBtn.TabIndex = 79;
            this.doajSlikuModelaBtn.Text = "Dodaj";
            this.doajSlikuModelaBtn.UseVisualStyleBackColor = true;
            this.doajSlikuModelaBtn.Click += new System.EventHandler(this.doajSlikuModelaBtn_Click);
            // 
            // ModelpictureBox
            // 
            this.ModelpictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ModelpictureBox.Location = new System.Drawing.Point(413, 22);
            this.ModelpictureBox.Name = "ModelpictureBox";
            this.ModelpictureBox.Size = new System.Drawing.Size(220, 220);
            this.ModelpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ModelpictureBox.TabIndex = 50;
            this.ModelpictureBox.TabStop = false;
            // 
            // slikaModelaInput
            // 
            this.slikaModelaInput.Location = new System.Drawing.Point(103, 50);
            this.slikaModelaInput.Name = "slikaModelaInput";
            this.slikaModelaInput.Size = new System.Drawing.Size(217, 20);
            this.slikaModelaInput.TabIndex = 8;
            this.slikaModelaInput.TabStop = false;
            this.slikaModelaInput.Validating += new System.ComponentModel.CancelEventHandler(this.slikaModelaInput_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Opis:";
            // 
            // opisInput
            // 
            this.opisInput.Location = new System.Drawing.Point(103, 114);
            this.opisInput.Name = "opisInput";
            this.opisInput.Size = new System.Drawing.Size(217, 74);
            this.opisInput.TabIndex = 5;
            this.opisInput.Text = "";
            this.opisInput.Validating += new System.ComponentModel.CancelEventHandler(this.opisInput_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Slika:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(702, 301);
            this.Controls.Add(this.revijeList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi look";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.AddForm_Validating);
            this.revijeList.ResumeLayout(false);
            this.revijeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModelpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pretragaDButton;
        private System.Windows.Forms.TextBox telefonDInput;
        private System.Windows.Forms.TextBox kontaktDInput;
        private System.Windows.Forms.TextBox nazivDInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox revijeList;
        private System.Windows.Forms.PictureBox ModelpictureBox;
        private System.Windows.Forms.TextBox slikaModelaInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox opisInput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button doajSlikuModelaBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button dodajModelBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nazivInput;
        private System.Windows.Forms.ComboBox revijeCbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}