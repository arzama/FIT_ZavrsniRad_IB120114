namespace PEPmodnaKompanija_UI.ModulDizajner
{
    partial class AddLookBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLookBook));
            this.modeliList = new System.Windows.Forms.CheckedListBox();
            this.DodajLookBookBtn = new System.Windows.Forms.Button();
            this.nazivInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // modeliList
            // 
            this.modeliList.FormattingEnabled = true;
            this.modeliList.Location = new System.Drawing.Point(12, 76);
            this.modeliList.Name = "modeliList";
            this.modeliList.Size = new System.Drawing.Size(314, 169);
            this.modeliList.TabIndex = 0;
            this.modeliList.Validating += new System.ComponentModel.CancelEventHandler(this.modeliList_Validating);
            // 
            // DodajLookBookBtn
            // 
            this.DodajLookBookBtn.Image = ((System.Drawing.Image)(resources.GetObject("DodajLookBookBtn.Image")));
            this.DodajLookBookBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DodajLookBookBtn.Location = new System.Drawing.Point(223, 251);
            this.DodajLookBookBtn.Name = "DodajLookBookBtn";
            this.DodajLookBookBtn.Size = new System.Drawing.Size(103, 27);
            this.DodajLookBookBtn.TabIndex = 1;
            this.DodajLookBookBtn.Text = "Sačuvaj";
            this.DodajLookBookBtn.UseVisualStyleBackColor = true;
            this.DodajLookBookBtn.Click += new System.EventHandler(this.DodajLookBookBtn_Click);
            // 
            // nazivInput
            // 
            this.nazivInput.Location = new System.Drawing.Point(108, 20);
            this.nazivInput.Name = "nazivInput";
            this.nazivInput.Size = new System.Drawing.Size(218, 20);
            this.nazivInput.TabIndex = 2;
            this.nazivInput.Validating += new System.ComponentModel.CancelEventHandler(this.nazivInput_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Naziv:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Odaberite look-ove koji će se nalaziti u lookbooku.";
            // 
            // AddLookBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(383, 303);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nazivInput);
            this.Controls.Add(this.DodajLookBookBtn);
            this.Controls.Add(this.modeliList);
            this.Name = "AddLookBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi LookBook";
            this.Load += new System.EventHandler(this.AddLookBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox modeliList;
        private System.Windows.Forms.Button DodajLookBookBtn;
        private System.Windows.Forms.TextBox nazivInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
    }
}