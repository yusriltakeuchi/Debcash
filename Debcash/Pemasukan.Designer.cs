namespace Debcash
{
    partial class Pemasukan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pemasukan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBatal = new MetroFramework.Controls.MetroButton();
            this.btnTambah = new MetroFramework.Controls.MetroButton();
            this.txtNominal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtKeterangan = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.datePemasukan = new MetroFramework.Controls.MetroDateTime();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBatal);
            this.groupBox1.Controls.Add(this.btnTambah);
            this.groupBox1.Controls.Add(this.txtNominal);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.txtKeterangan);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.datePemasukan);
            this.groupBox1.Location = new System.Drawing.Point(14, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proses Data Pemasukan";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.Location = new System.Drawing.Point(125, 222);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(117, 31);
            this.btnBatal.TabIndex = 4;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseCustomBackColor = true;
            this.btnBatal.UseCustomForeColor = true;
            this.btnBatal.UseSelectable = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(9, 222);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(110, 31);
            this.btnTambah.TabIndex = 3;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseCustomBackColor = true;
            this.btnTambah.UseCustomForeColor = true;
            this.btnTambah.UseSelectable = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // txtNominal
            // 
            // 
            // 
            // 
            this.txtNominal.CustomButton.Image = null;
            this.txtNominal.CustomButton.Location = new System.Drawing.Point(211, 1);
            this.txtNominal.CustomButton.Name = "";
            this.txtNominal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNominal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNominal.CustomButton.TabIndex = 1;
            this.txtNominal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNominal.CustomButton.UseSelectable = true;
            this.txtNominal.CustomButton.Visible = false;
            this.txtNominal.Lines = new string[0];
            this.txtNominal.Location = new System.Drawing.Point(9, 100);
            this.txtNominal.MaxLength = 32767;
            this.txtNominal.Name = "txtNominal";
            this.txtNominal.PasswordChar = '\0';
            this.txtNominal.PromptText = "0";
            this.txtNominal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNominal.SelectedText = "";
            this.txtNominal.SelectionLength = 0;
            this.txtNominal.SelectionStart = 0;
            this.txtNominal.ShortcutsEnabled = true;
            this.txtNominal.Size = new System.Drawing.Size(233, 23);
            this.txtNominal.TabIndex = 1;
            this.txtNominal.UseSelectable = true;
            this.txtNominal.WaterMark = "0";
            this.txtNominal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNominal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(9, 78);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Nominal";
            // 
            // txtKeterangan
            // 
            // 
            // 
            // 
            this.txtKeterangan.CustomButton.Image = null;
            this.txtKeterangan.CustomButton.Location = new System.Drawing.Point(171, 2);
            this.txtKeterangan.CustomButton.Name = "";
            this.txtKeterangan.CustomButton.Size = new System.Drawing.Size(59, 59);
            this.txtKeterangan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKeterangan.CustomButton.TabIndex = 1;
            this.txtKeterangan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKeterangan.CustomButton.UseSelectable = true;
            this.txtKeterangan.CustomButton.Visible = false;
            this.txtKeterangan.Lines = new string[0];
            this.txtKeterangan.Location = new System.Drawing.Point(9, 152);
            this.txtKeterangan.MaxLength = 32767;
            this.txtKeterangan.Multiline = true;
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.PasswordChar = '\0';
            this.txtKeterangan.PromptText = "Keterangan mengenai pemasukan";
            this.txtKeterangan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKeterangan.SelectedText = "";
            this.txtKeterangan.SelectionLength = 0;
            this.txtKeterangan.SelectionStart = 0;
            this.txtKeterangan.ShortcutsEnabled = true;
            this.txtKeterangan.Size = new System.Drawing.Size(233, 64);
            this.txtKeterangan.TabIndex = 2;
            this.txtKeterangan.UseSelectable = true;
            this.txtKeterangan.WaterMark = "Keterangan mengenai pemasukan";
            this.txtKeterangan.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKeterangan.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(9, 130);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Keterangan";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(9, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Tanggal";
            // 
            // datePemasukan
            // 
            this.datePemasukan.CustomFormat = "dd-MM-yyyy";
            this.datePemasukan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePemasukan.Location = new System.Drawing.Point(9, 44);
            this.datePemasukan.MinimumSize = new System.Drawing.Size(0, 29);
            this.datePemasukan.Name = "datePemasukan";
            this.datePemasukan.Size = new System.Drawing.Size(233, 29);
            this.datePemasukan.TabIndex = 0;
            // 
            // Pemasukan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 365);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pemasukan";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Pemasukan";
            this.Load += new System.EventHandler(this.Pemasukan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtKeterangan;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime datePemasukan;
        private MetroFramework.Controls.MetroTextBox txtNominal;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnBatal;
        private MetroFramework.Controls.MetroButton btnTambah;
    }
}