namespace PEPmodnaKompanija_UI.Narudzbe
{
    partial class AktivneNarudzbe
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
            this.dgAktivneNarudzbe = new System.Windows.Forms.DataGridView();
            this.NarudzbaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojNarudzbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KupacID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kupac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.skladistaList = new System.Windows.Forms.ComboBox();
            this.procesirajButton = new System.Windows.Forms.Button();
            this.iznosNarudzbeLabel = new System.Windows.Forms.Label();
            this.datumLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stavkeNarudzbeGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgAktivneNarudzbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeNarudzbeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAktivneNarudzbe
            // 
            this.dgAktivneNarudzbe.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgAktivneNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAktivneNarudzbe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NarudzbaID,
            this.BrojNarudzbe,
            this.KupacID,
            this.Datum,
            this.Kupac});
            this.dgAktivneNarudzbe.Location = new System.Drawing.Point(12, 78);
            this.dgAktivneNarudzbe.Name = "dgAktivneNarudzbe";
            this.dgAktivneNarudzbe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAktivneNarudzbe.Size = new System.Drawing.Size(344, 342);
            this.dgAktivneNarudzbe.TabIndex = 0;
            this.dgAktivneNarudzbe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAktivneNarudzbe_CellDoubleClick);
            // 
            // NarudzbaID
            // 
            this.NarudzbaID.DataPropertyName = "NarudzbaID";
            this.NarudzbaID.HeaderText = "NarudzbaID";
            this.NarudzbaID.Name = "NarudzbaID";
            this.NarudzbaID.Visible = false;
            // 
            // BrojNarudzbe
            // 
            this.BrojNarudzbe.DataPropertyName = "BrojNarudzbe";
            this.BrojNarudzbe.HeaderText = "BrojNarudzbe";
            this.BrojNarudzbe.Name = "BrojNarudzbe";
            // 
            // KupacID
            // 
            this.KupacID.DataPropertyName = "KupacID";
            this.KupacID.HeaderText = "KupacID";
            this.KupacID.Name = "KupacID";
            this.KupacID.Visible = false;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // Kupac
            // 
            this.Kupac.DataPropertyName = "Kupac";
            this.Kupac.HeaderText = "Kupac";
            this.Kupac.Name = "Kupac";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "*Dvostruki klik - detalji narudžbe.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(515, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "Skladište:";
            // 
            // skladistaList
            // 
            this.skladistaList.FormattingEnabled = true;
            this.skladistaList.Location = new System.Drawing.Point(581, 343);
            this.skladistaList.Name = "skladistaList";
            this.skladistaList.Size = new System.Drawing.Size(202, 21);
            this.skladistaList.TabIndex = 76;
            // 
            // procesirajButton
            // 
            this.procesirajButton.Location = new System.Drawing.Point(795, 337);
            this.procesirajButton.Name = "procesirajButton";
            this.procesirajButton.Size = new System.Drawing.Size(100, 30);
            this.procesirajButton.TabIndex = 75;
            this.procesirajButton.Text = "Procesiraj";
            this.procesirajButton.UseVisualStyleBackColor = true;
            this.procesirajButton.Click += new System.EventHandler(this.procesirajButton_Click);
            // 
            // iznosNarudzbeLabel
            // 
            this.iznosNarudzbeLabel.AutoSize = true;
            this.iznosNarudzbeLabel.Location = new System.Drawing.Point(783, 86);
            this.iznosNarudzbeLabel.Name = "iznosNarudzbeLabel";
            this.iznosNarudzbeLabel.Size = new System.Drawing.Size(32, 13);
            this.iznosNarudzbeLabel.TabIndex = 74;
            this.iznosNarudzbeLabel.Text = "Iznos";
            // 
            // datumLabel
            // 
            this.datumLabel.AutoSize = true;
            this.datumLabel.Location = new System.Drawing.Point(547, 86);
            this.datumLabel.Name = "datumLabel";
            this.datumLabel.Size = new System.Drawing.Size(38, 13);
            this.datumLabel.TabIndex = 73;
            this.datumLabel.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(726, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Iznos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "Datum:";
            // 
            // stavkeNarudzbeGrid
            // 
            this.stavkeNarudzbeGrid.AllowUserToAddRows = false;
            this.stavkeNarudzbeGrid.AllowUserToDeleteRows = false;
            this.stavkeNarudzbeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stavkeNarudzbeGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.stavkeNarudzbeGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.stavkeNarudzbeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stavkeNarudzbeGrid.Location = new System.Drawing.Point(469, 123);
            this.stavkeNarudzbeGrid.Name = "stavkeNarudzbeGrid";
            this.stavkeNarudzbeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stavkeNarudzbeGrid.Size = new System.Drawing.Size(458, 193);
            this.stavkeNarudzbeGrid.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(62, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 16);
            this.label4.TabIndex = 78;
            this.label4.Text = "Lista aktivnih narudžbi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(587, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 16);
            this.label6.TabIndex = 79;
            this.label6.Text = "Detalji narudžbe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 82;
            this.label7.Text = "label7";
            // 
            // AktivneNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(939, 470);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.skladistaList);
            this.Controls.Add(this.procesirajButton);
            this.Controls.Add(this.iznosNarudzbeLabel);
            this.Controls.Add(this.datumLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stavkeNarudzbeGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgAktivneNarudzbe);
            this.Name = "AktivneNarudzbe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Aktivne narudžbe";
            this.Load += new System.EventHandler(this.AktivneNarudzbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAktivneNarudzbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeNarudzbeGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAktivneNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NarudzbaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn KupacID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kupac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox skladistaList;
        private System.Windows.Forms.Button procesirajButton;
        private System.Windows.Forms.Label iznosNarudzbeLabel;
        private System.Windows.Forms.Label datumLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView stavkeNarudzbeGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}