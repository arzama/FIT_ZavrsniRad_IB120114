namespace PEPmodnaKompanija_UI
{
    partial class frmKorisnici
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
            this.korisniciGrid = new System.Windows.Forms.DataGridView();
            this.apiCallerBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // korisniciGrid
            // 
            this.korisniciGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.korisniciGrid.Location = new System.Drawing.Point(0, 58);
            this.korisniciGrid.Name = "korisniciGrid";
            this.korisniciGrid.Size = new System.Drawing.Size(466, 204);
            this.korisniciGrid.TabIndex = 0;
            this.korisniciGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.korisniciGrid_CellContentClick);
            // 
            // apiCallerBtn
            // 
            this.apiCallerBtn.Location = new System.Drawing.Point(25, 12);
            this.apiCallerBtn.Name = "apiCallerBtn";
            this.apiCallerBtn.Size = new System.Drawing.Size(75, 23);
            this.apiCallerBtn.TabIndex = 1;
            this.apiCallerBtn.Text = "Call API";
            this.apiCallerBtn.UseVisualStyleBackColor = true;
            this.apiCallerBtn.Click += new System.EventHandler(this.apiCallerBtn_Click);
            // 
            // frmKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 261);
            this.Controls.Add(this.apiCallerBtn);
            this.Controls.Add(this.korisniciGrid);
            this.Name = "frmKorisnici";
            this.Text = "Korisnici";
            ((System.ComponentModel.ISupportInitialize)(this.korisniciGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView korisniciGrid;
        private System.Windows.Forms.Button apiCallerBtn;
    }
}

