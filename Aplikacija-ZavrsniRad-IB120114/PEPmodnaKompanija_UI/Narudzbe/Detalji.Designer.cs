namespace PEPmodnaKompanija_UI.Narudzbe
{
    partial class Detalji
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
            this.label5 = new System.Windows.Forms.Label();
            this.skladistaList = new System.Windows.Forms.ComboBox();
            this.procesirajButton = new System.Windows.Forms.Button();
            this.iznosNarudzbeLabel = new System.Windows.Forms.Label();
            this.kupacLabel = new System.Windows.Forms.Label();
            this.datumLabel = new System.Windows.Forms.Label();
            this.brNarudzbeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stavkeNarudzbeGrid = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.stavkeNarudzbeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "Skladište:";
            // 
            // skladistaList
            // 
            this.skladistaList.FormattingEnabled = true;
            this.skladistaList.Location = new System.Drawing.Point(180, 253);
            this.skladistaList.Name = "skladistaList";
            this.skladistaList.Size = new System.Drawing.Size(202, 21);
            this.skladistaList.TabIndex = 68;
            this.skladistaList.Validating += new System.ComponentModel.CancelEventHandler(this.skladistaList_Validating);
            // 
            // procesirajButton
            // 
            this.procesirajButton.Location = new System.Drawing.Point(394, 247);
            this.procesirajButton.Name = "procesirajButton";
            this.procesirajButton.Size = new System.Drawing.Size(100, 30);
            this.procesirajButton.TabIndex = 67;
            this.procesirajButton.Text = "Procesiraj";
            this.procesirajButton.UseVisualStyleBackColor = true;
            this.procesirajButton.Click += new System.EventHandler(this.procesirajButton_Click);
            // 
            // iznosNarudzbeLabel
            // 
            this.iznosNarudzbeLabel.AutoSize = true;
            this.iznosNarudzbeLabel.Location = new System.Drawing.Point(350, 10);
            this.iznosNarudzbeLabel.Name = "iznosNarudzbeLabel";
            this.iznosNarudzbeLabel.Size = new System.Drawing.Size(32, 13);
            this.iznosNarudzbeLabel.TabIndex = 66;
            this.iznosNarudzbeLabel.Text = "Iznos";
            // 
            // kupacLabel
            // 
            this.kupacLabel.AutoSize = true;
            this.kupacLabel.Location = new System.Drawing.Point(350, -17);
            this.kupacLabel.Name = "kupacLabel";
            this.kupacLabel.Size = new System.Drawing.Size(38, 13);
            this.kupacLabel.TabIndex = 65;
            this.kupacLabel.Text = "Kupac";
            // 
            // datumLabel
            // 
            this.datumLabel.AutoSize = true;
            this.datumLabel.Location = new System.Drawing.Point(114, 10);
            this.datumLabel.Name = "datumLabel";
            this.datumLabel.Size = new System.Drawing.Size(38, 13);
            this.datumLabel.TabIndex = 64;
            this.datumLabel.Text = "Datum";
            // 
            // brNarudzbeLabel
            // 
            this.brNarudzbeLabel.AutoSize = true;
            this.brNarudzbeLabel.Location = new System.Drawing.Point(114, -17);
            this.brNarudzbeLabel.Name = "brNarudzbeLabel";
            this.brNarudzbeLabel.Size = new System.Drawing.Size(72, 13);
            this.brNarudzbeLabel.TabIndex = 63;
            this.brNarudzbeLabel.Text = "Broj narudžbe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, -17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Broj narudžbe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Iznos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, -17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Kupac:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Datum:";
            // 
            // stavkeNarudzbeGrid
            // 
            this.stavkeNarudzbeGrid.AllowUserToAddRows = false;
            this.stavkeNarudzbeGrid.AllowUserToDeleteRows = false;
            this.stavkeNarudzbeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stavkeNarudzbeGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.stavkeNarudzbeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stavkeNarudzbeGrid.Location = new System.Drawing.Point(36, 47);
            this.stavkeNarudzbeGrid.Name = "stavkeNarudzbeGrid";
            this.stavkeNarudzbeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stavkeNarudzbeGrid.Size = new System.Drawing.Size(458, 193);
            this.stavkeNarudzbeGrid.TabIndex = 58;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Detalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(539, 333);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.skladistaList);
            this.Controls.Add(this.procesirajButton);
            this.Controls.Add(this.iznosNarudzbeLabel);
            this.Controls.Add(this.kupacLabel);
            this.Controls.Add(this.datumLabel);
            this.Controls.Add(this.brNarudzbeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stavkeNarudzbeGrid);
            this.Name = "Detalji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalji narudžbe";
            this.Load += new System.EventHandler(this.Detalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stavkeNarudzbeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox skladistaList;
        private System.Windows.Forms.Button procesirajButton;
        private System.Windows.Forms.Label iznosNarudzbeLabel;
        private System.Windows.Forms.Label kupacLabel;
        private System.Windows.Forms.Label datumLabel;
        private System.Windows.Forms.Label brNarudzbeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView stavkeNarudzbeGrid;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}