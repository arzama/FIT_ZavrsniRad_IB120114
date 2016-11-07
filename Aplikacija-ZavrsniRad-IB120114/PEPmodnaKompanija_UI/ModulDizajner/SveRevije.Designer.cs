namespace PEPmodnaKompanija_UI.ModulDizajner
{
    partial class SveRevije
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SveRevije));
            this.dgAllRevije = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DizajnerR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odPicker = new System.Windows.Forms.DateTimePicker();
            this.doPicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPretraga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAllRevije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAllRevije
            // 
            this.dgAllRevije.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgAllRevije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAllRevije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.Datum,
            this.Napomena,
            this.DizajnerR,
            this.Email});
            this.dgAllRevije.Location = new System.Drawing.Point(32, 63);
            this.dgAllRevije.Name = "dgAllRevije";
            this.dgAllRevije.Size = new System.Drawing.Size(570, 232);
            this.dgAllRevije.TabIndex = 0;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // Napomena
            // 
            this.Napomena.DataPropertyName = "Napomena";
            this.Napomena.HeaderText = "Napomena";
            this.Napomena.Name = "Napomena";
            // 
            // DizajnerR
            // 
            this.DizajnerR.DataPropertyName = "DizajnerR";
            this.DizajnerR.HeaderText = "Dizajner";
            this.DizajnerR.Name = "DizajnerR";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // odPicker
            // 
            this.odPicker.Location = new System.Drawing.Point(52, 22);
            this.odPicker.Name = "odPicker";
            this.odPicker.Size = new System.Drawing.Size(200, 20);
            this.odPicker.TabIndex = 1;
            // 
            // doPicker
            // 
            this.doPicker.Location = new System.Drawing.Point(332, 22);
            this.doPicker.Name = "doPicker";
            this.doPicker.Size = new System.Drawing.Size(200, 20);
            this.doPicker.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Od:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Do:";
            // 
            // btnPretraga
            // 
            this.btnPretraga.Image = ((System.Drawing.Image)(resources.GetObject("btnPretraga.Image")));
            this.btnPretraga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPretraga.Location = new System.Drawing.Point(559, 15);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 27);
            this.btnPretraga.TabIndex = 5;
            this.btnPretraga.Text = "Traži";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // SveRevije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(646, 310);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doPicker);
            this.Controls.Add(this.odPicker);
            this.Controls.Add(this.dgAllRevije);
            this.Name = "SveRevije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Održane revije";
            this.Load += new System.EventHandler(this.SveRevije_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgAllRevije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAllRevije;
        private System.Windows.Forms.DateTimePicker odPicker;
        private System.Windows.Forms.DateTimePicker doPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
        private System.Windows.Forms.DataGridViewTextBoxColumn DizajnerR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}