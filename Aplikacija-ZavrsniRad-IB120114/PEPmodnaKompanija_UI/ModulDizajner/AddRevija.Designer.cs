namespace PEPmodnaKompanija_UI.ModulDizajner
{
    partial class AddRevija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRevija));
            this.datumDatePicker = new System.Windows.Forms.DateTimePicker();
            this.nazivInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.napomenaInput = new System.Windows.Forms.RichTextBox();
            this.revijeGrid = new System.Windows.Forms.DataGridView();
            this.RevijaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DodajRevijuBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.revijeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // datumDatePicker
            // 
            this.datumDatePicker.Location = new System.Drawing.Point(139, 54);
            this.datumDatePicker.Name = "datumDatePicker";
            this.datumDatePicker.Size = new System.Drawing.Size(217, 20);
            this.datumDatePicker.TabIndex = 20;
            this.datumDatePicker.Validating += new System.ComponentModel.CancelEventHandler(this.datumDatePicker_Validating);
            // 
            // nazivInput
            // 
            this.nazivInput.Location = new System.Drawing.Point(139, 22);
            this.nazivInput.Name = "nazivInput";
            this.nazivInput.Size = new System.Drawing.Size(217, 20);
            this.nazivInput.TabIndex = 16;
            this.nazivInput.TabStop = false;
            this.nazivInput.Validating += new System.ComponentModel.CancelEventHandler(this.nazivInput_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Datum održavanja: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Naziv:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Napomena: ";
            // 
            // napomenaInput
            // 
            this.napomenaInput.Location = new System.Drawing.Point(139, 90);
            this.napomenaInput.Name = "napomenaInput";
            this.napomenaInput.Size = new System.Drawing.Size(217, 62);
            this.napomenaInput.TabIndex = 21;
            this.napomenaInput.TabStop = false;
            this.napomenaInput.Text = "";
            // 
            // revijeGrid
            // 
            this.revijeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.revijeGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.revijeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.revijeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RevijaID,
            this.Naziv,
            this.Datum,
            this.Napomena});
            this.revijeGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.revijeGrid.Location = new System.Drawing.Point(0, 202);
            this.revijeGrid.Name = "revijeGrid";
            this.revijeGrid.ReadOnly = true;
            this.revijeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.revijeGrid.Size = new System.Drawing.Size(421, 162);
            this.revijeGrid.TabIndex = 41;
            this.revijeGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.revijeGrid_CellDoubleClick);
            // 
            // RevijaID
            // 
            this.RevijaID.DataPropertyName = "RevijaID";
            this.RevijaID.HeaderText = "RevijaID";
            this.RevijaID.Name = "RevijaID";
            this.RevijaID.ReadOnly = true;
            this.RevijaID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Održana datuma";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Napomena
            // 
            this.Napomena.DataPropertyName = "Napomena";
            this.Napomena.HeaderText = "Napomena";
            this.Napomena.Name = "Napomena";
            this.Napomena.ReadOnly = true;
            // 
            // DodajRevijuBtn
            // 
            this.DodajRevijuBtn.Image = ((System.Drawing.Image)(resources.GetObject("DodajRevijuBtn.Image")));
            this.DodajRevijuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DodajRevijuBtn.Location = new System.Drawing.Point(261, 158);
            this.DodajRevijuBtn.Name = "DodajRevijuBtn";
            this.DodajRevijuBtn.Size = new System.Drawing.Size(95, 27);
            this.DodajRevijuBtn.TabIndex = 25;
            this.DodajRevijuBtn.Text = "Sačuvaj";
            this.DodajRevijuBtn.UseVisualStyleBackColor = true;
            this.DodajRevijuBtn.Click += new System.EventHandler(this.DodajRevijuBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "*Klikom na reviju možete urediti podatke.";
            // 
            // AddRevija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(421, 364);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DodajRevijuBtn);
            this.Controls.Add(this.revijeGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.napomenaInput);
            this.Controls.Add(this.datumDatePicker);
            this.Controls.Add(this.nazivInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Name = "AddRevija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova revija";
            this.Load += new System.EventHandler(this.AddRevija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.revijeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datumDatePicker;
        private System.Windows.Forms.TextBox nazivInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox napomenaInput;
        private System.Windows.Forms.DataGridView revijeGrid;
        private System.Windows.Forms.Button DodajRevijuBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RevijaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
    }
}