namespace Debcash
{
    partial class FirstSaldo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstSaldo));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtSaldo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateAwal = new MetroFramework.Controls.MetroDateTime();
            this.btnOK = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(15, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(42, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Saldo";
            // 
            // txtSaldo
            // 
            // 
            // 
            // 
            this.txtSaldo.CustomButton.Image = null;
            this.txtSaldo.CustomButton.Location = new System.Drawing.Point(211, 1);
            this.txtSaldo.CustomButton.Name = "";
            this.txtSaldo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSaldo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSaldo.CustomButton.TabIndex = 1;
            this.txtSaldo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSaldo.CustomButton.UseSelectable = true;
            this.txtSaldo.CustomButton.Visible = false;
            this.txtSaldo.Lines = new string[0];
            this.txtSaldo.Location = new System.Drawing.Point(15, 106);
            this.txtSaldo.MaxLength = 32767;
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.PasswordChar = '\0';
            this.txtSaldo.PromptText = "0";
            this.txtSaldo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSaldo.SelectedText = "";
            this.txtSaldo.SelectionLength = 0;
            this.txtSaldo.SelectionStart = 0;
            this.txtSaldo.ShortcutsEnabled = true;
            this.txtSaldo.Size = new System.Drawing.Size(233, 23);
            this.txtSaldo.TabIndex = 1;
            this.txtSaldo.UseSelectable = true;
            this.txtSaldo.WaterMark = "0";
            this.txtSaldo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSaldo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 16);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(239, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Masukkan jumlah saldo keuangan Anda";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateAwal);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.txtSaldo);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(13, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 172);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Starting Money";
            // 
            // dateAwal
            // 
            this.dateAwal.CustomFormat = "dd-MM-yyyy";
            this.dateAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateAwal.Location = new System.Drawing.Point(15, 47);
            this.dateAwal.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateAwal.Name = "dateAwal";
            this.dateAwal.Size = new System.Drawing.Size(233, 29);
            this.dateAwal.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(138, 135);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(110, 31);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseCustomBackColor = true;
            this.btnOK.UseCustomForeColor = true;
            this.btnOK.UseSelectable = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FirstSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 244);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FirstSaldo";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Saldo Awal";
            this.Load += new System.EventHandler(this.FirstSaldo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtSaldo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnOK;
        private MetroFramework.Controls.MetroDateTime dateAwal;
    }
}