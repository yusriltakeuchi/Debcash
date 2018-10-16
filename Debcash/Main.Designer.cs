namespace Debcash
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Tanggal", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Keterangan", 2, 2);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Pengeluaran", 3, 3);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Pemasukan", 4, 4);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Saldo", 5, 5);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Terendah", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Tanggal", 1, 1);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Keterangan", 2, 2);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Pengeluaran", 3, 3);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Pemasukan", 4, 4);
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Saldo", 5, 5);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Tertinggi", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Filter by", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode12});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Harian", 1, 1);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Bulanan", 1, 1);
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Tahunan", 1, 1);
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Filter by", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.debitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsername = new System.Windows.Forms.ToolStripMenuItem();
            this.lblKeluar = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.lblKenaikanTertinggi = new MetroFramework.Controls.MetroLabel();
            this.lblPersenUntung = new MetroFramework.Controls.MetroLabel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lblPengeluarans = new MetroFramework.Controls.MetroLabel();
            this.lblTanggalPengeluaran = new MetroFramework.Controls.MetroLabel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.lblPemasukan = new MetroFramework.Controls.MetroLabel();
            this.lblTanggalPemasukan = new MetroFramework.Controls.MetroLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTotalPemasukan = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.lblTotalPengeluaran = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblSaldo = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.iconExport = new System.Windows.Forms.PictureBox();
            this.btnExportSummary = new MetroFramework.Controls.MetroButton();
            this.iconClear = new System.Windows.Forms.PictureBox();
            this.iconApply = new System.Windows.Forms.PictureBox();
            this.btnClearTable = new MetroFramework.Controls.MetroButton();
            this.btnApplyTable = new MetroFramework.Controls.MetroButton();
            this.filterTree = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TableSumGrid = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.iconExport2 = new System.Windows.Forms.PictureBox();
            this.btnExportPembukuan = new MetroFramework.Controls.MetroButton();
            this.iconApply2 = new System.Windows.Forms.PictureBox();
            this.GridPembukuan = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnApply = new MetroFramework.Controls.MetroButton();
            this.treePembukuan = new System.Windows.Forms.TreeView();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.GridHistory = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconApply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableSumGrid)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconExport2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconApply2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPembukuan)).BeginInit();
            this.metroTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debitToolStripMenuItem,
            this.kreditToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.lblUsername});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // debitToolStripMenuItem
            // 
            this.debitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("debitToolStripMenuItem.Image")));
            this.debitToolStripMenuItem.Name = "debitToolStripMenuItem";
            this.debitToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.debitToolStripMenuItem.Text = "Pemasukan";
            this.debitToolStripMenuItem.Click += new System.EventHandler(this.debitToolStripMenuItem_Click);
            // 
            // kreditToolStripMenuItem
            // 
            this.kreditToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kreditToolStripMenuItem.Image")));
            this.kreditToolStripMenuItem.Name = "kreditToolStripMenuItem";
            this.kreditToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.kreditToolStripMenuItem.Text = "Pengeluaran";
            this.kreditToolStripMenuItem.Click += new System.EventHandler(this.kreditToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblUsername.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblKeluar});
            this.lblUsername.Image = ((System.Drawing.Image)(resources.GetObject("lblUsername.Image")));
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(88, 20);
            this.lblUsername.Text = "Username";
            // 
            // lblKeluar
            // 
            this.lblKeluar.Name = "lblKeluar";
            this.lblKeluar.Size = new System.Drawing.Size(107, 22);
            this.lblKeluar.Text = "Keluar";
            this.lblKeluar.Click += new System.EventHandler(this.lblKeluar_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.metroTabPage4);
            this.metroTabControl1.Location = new System.Drawing.Point(20, 87);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(801, 344);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.groupBox8);
            this.metroTabPage1.Controls.Add(this.groupBox5);
            this.metroTabPage1.Controls.Add(this.groupBox6);
            this.metroTabPage1.Controls.Add(this.groupBox4);
            this.metroTabPage1.Controls.Add(this.groupBox3);
            this.metroTabPage1.Controls.Add(this.groupBox2);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(793, 302);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Summary";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.White;
            this.groupBox8.Controls.Add(this.pictureBox6);
            this.groupBox8.Controls.Add(this.metroLabel16);
            this.groupBox8.Controls.Add(this.lblKenaikanTertinggi);
            this.groupBox8.Controls.Add(this.lblPersenUntung);
            this.groupBox8.Location = new System.Drawing.Point(507, 132);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(286, 149);
            this.groupBox8.TabIndex = 9;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Kenaikan Pemasukan Bulan Terakhir";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(113, 19);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(66, 45);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // metroLabel16
            // 
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel16.Location = new System.Drawing.Point(6, 94);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(274, 15);
            this.metroLabel16.TabIndex = 8;
            this.metroLabel16.Text = "-----------------------------";
            this.metroLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKenaikanTertinggi
            // 
            this.lblKenaikanTertinggi.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblKenaikanTertinggi.Location = new System.Drawing.Point(3, 103);
            this.lblKenaikanTertinggi.Name = "lblKenaikanTertinggi";
            this.lblKenaikanTertinggi.Size = new System.Drawing.Size(277, 36);
            this.lblKenaikanTertinggi.TabIndex = 4;
            this.lblKenaikanTertinggi.Text = "Tertinggi pada bulan : 0%";
            this.lblKenaikanTertinggi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPersenUntung
            // 
            this.lblPersenUntung.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPersenUntung.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblPersenUntung.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPersenUntung.Location = new System.Drawing.Point(3, 61);
            this.lblPersenUntung.Name = "lblPersenUntung";
            this.lblPersenUntung.Size = new System.Drawing.Size(277, 39);
            this.lblPersenUntung.TabIndex = 3;
            this.lblPersenUntung.Text = "0% Kenaikan";
            this.lblPersenUntung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPersenUntung.UseCustomForeColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.pictureBox5);
            this.groupBox5.Controls.Add(this.metroLabel6);
            this.groupBox5.Controls.Add(this.lblPengeluarans);
            this.groupBox5.Controls.Add(this.lblTanggalPengeluaran);
            this.groupBox5.Location = new System.Drawing.Point(249, 132);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(252, 149);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pengeluaran Terbanyak";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(93, 19);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(66, 45);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // metroLabel6
            // 
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(6, 94);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(240, 15);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "-----------------------------";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPengeluarans
            // 
            this.lblPengeluarans.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblPengeluarans.Location = new System.Drawing.Point(3, 103);
            this.lblPengeluarans.Name = "lblPengeluarans";
            this.lblPengeluarans.Size = new System.Drawing.Size(243, 36);
            this.lblPengeluarans.TabIndex = 4;
            this.lblPengeluarans.Text = "Rp0";
            this.lblPengeluarans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTanggalPengeluaran
            // 
            this.lblTanggalPengeluaran.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTanggalPengeluaran.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTanggalPengeluaran.Location = new System.Drawing.Point(3, 61);
            this.lblTanggalPengeluaran.Name = "lblTanggalPengeluaran";
            this.lblTanggalPengeluaran.Size = new System.Drawing.Size(243, 39);
            this.lblTanggalPengeluaran.TabIndex = 3;
            this.lblTanggalPengeluaran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.White;
            this.groupBox6.Controls.Add(this.pictureBox4);
            this.groupBox6.Controls.Add(this.metroLabel14);
            this.groupBox6.Controls.Add(this.lblPemasukan);
            this.groupBox6.Controls.Add(this.lblTanggalPemasukan);
            this.groupBox6.Location = new System.Drawing.Point(0, 132);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(243, 149);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Pemasukan Terbanyak";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(89, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(66, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // metroLabel14
            // 
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel14.Location = new System.Drawing.Point(6, 94);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(231, 15);
            this.metroLabel14.TabIndex = 8;
            this.metroLabel14.Text = "-----------------------------";
            this.metroLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPemasukan
            // 
            this.lblPemasukan.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblPemasukan.Location = new System.Drawing.Point(3, 103);
            this.lblPemasukan.Name = "lblPemasukan";
            this.lblPemasukan.Size = new System.Drawing.Size(234, 36);
            this.lblPemasukan.TabIndex = 4;
            this.lblPemasukan.Text = "Rp0";
            this.lblPemasukan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTanggalPemasukan
            // 
            this.lblTanggalPemasukan.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTanggalPemasukan.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTanggalPemasukan.Location = new System.Drawing.Point(3, 61);
            this.lblTanggalPemasukan.Name = "lblTanggalPemasukan";
            this.lblTanggalPemasukan.Size = new System.Drawing.Size(234, 39);
            this.lblTanggalPemasukan.TabIndex = 3;
            this.lblTanggalPemasukan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.lblTotalPemasukan);
            this.groupBox4.Controls.Add(this.metroLabel12);
            this.groupBox4.Location = new System.Drawing.Point(0, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(243, 123);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Total Pemasukan";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblTotalPemasukan
            // 
            this.lblTotalPemasukan.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTotalPemasukan.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTotalPemasukan.Location = new System.Drawing.Point(6, 83);
            this.lblTotalPemasukan.Name = "lblTotalPemasukan";
            this.lblTotalPemasukan.Size = new System.Drawing.Size(231, 30);
            this.lblTotalPemasukan.TabIndex = 9;
            this.lblTotalPemasukan.Text = "Rp0";
            this.lblTotalPemasukan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel12
            // 
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(6, 61);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(231, 22);
            this.metroLabel12.TabIndex = 9;
            this.metroLabel12.Text = "Semua periode";
            this.metroLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.metroLabel10);
            this.groupBox3.Controls.Add(this.lblTotalPengeluaran);
            this.groupBox3.Location = new System.Drawing.Point(249, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 123);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total Pengeluaran";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(93, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // metroLabel10
            // 
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(6, 61);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(240, 22);
            this.metroLabel10.TabIndex = 8;
            this.metroLabel10.Text = "Semua periode";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPengeluaran
            // 
            this.lblTotalPengeluaran.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTotalPengeluaran.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTotalPengeluaran.Location = new System.Drawing.Point(6, 83);
            this.lblTotalPengeluaran.Name = "lblTotalPengeluaran";
            this.lblTotalPengeluaran.Size = new System.Drawing.Size(240, 30);
            this.lblTotalPengeluaran.TabIndex = 1;
            this.lblTotalPengeluaran.Text = "Rp0";
            this.lblTotalPengeluaran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.lblSaldo);
            this.groupBox2.Controls.Add(this.metroLabel11);
            this.groupBox2.Location = new System.Drawing.Point(507, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 123);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Saldo";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(113, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(66, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // lblSaldo
            // 
            this.lblSaldo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSaldo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblSaldo.Location = new System.Drawing.Point(6, 83);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(274, 30);
            this.lblSaldo.TabIndex = 10;
            this.lblSaldo.Text = "Rp0";
            this.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel11
            // 
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(6, 61);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(274, 22);
            this.metroLabel11.TabIndex = 9;
            this.metroLabel11.Text = "Semua periode";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.iconExport);
            this.metroTabPage2.Controls.Add(this.btnExportSummary);
            this.metroTabPage2.Controls.Add(this.iconClear);
            this.metroTabPage2.Controls.Add(this.iconApply);
            this.metroTabPage2.Controls.Add(this.btnClearTable);
            this.metroTabPage2.Controls.Add(this.btnApplyTable);
            this.metroTabPage2.Controls.Add(this.filterTree);
            this.metroTabPage2.Controls.Add(this.TableSumGrid);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(793, 302);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Table Summary";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // iconExport
            // 
            this.iconExport.Image = ((System.Drawing.Image)(resources.GetObject("iconExport.Image")));
            this.iconExport.Location = new System.Drawing.Point(30, 246);
            this.iconExport.Name = "iconExport";
            this.iconExport.Size = new System.Drawing.Size(15, 15);
            this.iconExport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconExport.TabIndex = 15;
            this.iconExport.TabStop = false;
            // 
            // btnExportSummary
            // 
            this.btnExportSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.btnExportSummary.ForeColor = System.Drawing.Color.White;
            this.btnExportSummary.Location = new System.Drawing.Point(8, 241);
            this.btnExportSummary.Name = "btnExportSummary";
            this.btnExportSummary.Size = new System.Drawing.Size(164, 23);
            this.btnExportSummary.TabIndex = 14;
            this.btnExportSummary.Text = "Export to Excel";
            this.btnExportSummary.UseCustomBackColor = true;
            this.btnExportSummary.UseCustomForeColor = true;
            this.btnExportSummary.UseSelectable = true;
            this.btnExportSummary.Click += new System.EventHandler(this.btnExportSummary_Click);
            // 
            // iconClear
            // 
            this.iconClear.Image = ((System.Drawing.Image)(resources.GetObject("iconClear.Image")));
            this.iconClear.Location = new System.Drawing.Point(97, 274);
            this.iconClear.Name = "iconClear";
            this.iconClear.Size = new System.Drawing.Size(15, 15);
            this.iconClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconClear.TabIndex = 13;
            this.iconClear.TabStop = false;
            // 
            // iconApply
            // 
            this.iconApply.Image = ((System.Drawing.Image)(resources.GetObject("iconApply.Image")));
            this.iconApply.Location = new System.Drawing.Point(8, 274);
            this.iconApply.Name = "iconApply";
            this.iconApply.Size = new System.Drawing.Size(15, 15);
            this.iconApply.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconApply.TabIndex = 11;
            this.iconApply.TabStop = false;
            // 
            // btnClearTable
            // 
            this.btnClearTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.btnClearTable.ForeColor = System.Drawing.Color.White;
            this.btnClearTable.Location = new System.Drawing.Point(92, 270);
            this.btnClearTable.Name = "btnClearTable";
            this.btnClearTable.Size = new System.Drawing.Size(80, 23);
            this.btnClearTable.TabIndex = 12;
            this.btnClearTable.Text = "Clear";
            this.btnClearTable.UseCustomBackColor = true;
            this.btnClearTable.UseCustomForeColor = true;
            this.btnClearTable.UseSelectable = true;
            this.btnClearTable.Click += new System.EventHandler(this.btnClearTable_Click);
            // 
            // btnApplyTable
            // 
            this.btnApplyTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.btnApplyTable.ForeColor = System.Drawing.Color.White;
            this.btnApplyTable.Location = new System.Drawing.Point(6, 270);
            this.btnApplyTable.Name = "btnApplyTable";
            this.btnApplyTable.Size = new System.Drawing.Size(80, 23);
            this.btnApplyTable.TabIndex = 11;
            this.btnApplyTable.Text = "Apply";
            this.btnApplyTable.UseCustomBackColor = true;
            this.btnApplyTable.UseCustomForeColor = true;
            this.btnApplyTable.UseSelectable = true;
            this.btnApplyTable.Click += new System.EventHandler(this.btnApplyTable_Click);
            // 
            // filterTree
            // 
            this.filterTree.ImageIndex = 0;
            this.filterTree.ImageList = this.imageList1;
            this.filterTree.Location = new System.Drawing.Point(3, 9);
            this.filterTree.Name = "filterTree";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "ORDER BY tanggal ASC";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "Tanggal";
            treeNode2.ImageIndex = 2;
            treeNode2.Name = "ORDER BY keterangan ASC";
            treeNode2.SelectedImageIndex = 2;
            treeNode2.Text = "Keterangan";
            treeNode3.ImageIndex = 3;
            treeNode3.Name = "ORDER BY pengeluaran ASC";
            treeNode3.SelectedImageIndex = 3;
            treeNode3.Text = "Pengeluaran";
            treeNode4.ImageIndex = 4;
            treeNode4.Name = "ORDER BY pemasukan ASC";
            treeNode4.SelectedImageIndex = 4;
            treeNode4.Text = "Pemasukan";
            treeNode5.ImageIndex = 5;
            treeNode5.Name = "ORDER BY saldo ASC";
            treeNode5.SelectedImageIndex = 5;
            treeNode5.Text = "Saldo";
            treeNode6.Name = "Node0";
            treeNode6.Text = "Terendah";
            treeNode7.ImageIndex = 1;
            treeNode7.Name = "ORDER BY tanggal DESC";
            treeNode7.SelectedImageIndex = 1;
            treeNode7.Text = "Tanggal";
            treeNode8.ImageIndex = 2;
            treeNode8.Name = "ORDER BY keterangan DESC";
            treeNode8.SelectedImageIndex = 2;
            treeNode8.Text = "Keterangan";
            treeNode9.ImageIndex = 3;
            treeNode9.Name = "ORDER BY pengeluaran DESC";
            treeNode9.SelectedImageIndex = 3;
            treeNode9.Text = "Pengeluaran";
            treeNode10.ImageIndex = 4;
            treeNode10.Name = "ORDER BY pemasukan DESC";
            treeNode10.SelectedImageIndex = 4;
            treeNode10.Text = "Pemasukan";
            treeNode11.ImageIndex = 5;
            treeNode11.Name = "ORDER BY saldo DESC";
            treeNode11.SelectedImageIndex = 5;
            treeNode11.Text = "Saldo";
            treeNode12.Name = "Node1";
            treeNode12.Text = "Tertinggi";
            treeNode13.Name = "Node0";
            treeNode13.Text = "Filter by";
            this.filterTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13});
            this.filterTree.SelectedImageIndex = 0;
            this.filterTree.Size = new System.Drawing.Size(172, 290);
            this.filterTree.TabIndex = 0;
            this.filterTree.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.filterTree_AfterCheck);
            this.filterTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.filterTree_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "filter-tool-black-shape.png");
            this.imageList1.Images.SetKeyName(1, "calendar-with-spring-binder-and-date-blocks.png");
            this.imageList1.Images.SetKeyName(2, "sort-by-alphabet.png");
            this.imageList1.Images.SetKeyName(3, "payment-method.png");
            this.imageList1.Images.SetKeyName(4, "money-bag-with-dollar-symbol.png");
            this.imageList1.Images.SetKeyName(5, "dollar-sign-and-piles-of-coins.png");
            // 
            // TableSumGrid
            // 
            this.TableSumGrid.AllowUserToAddRows = false;
            this.TableSumGrid.AllowUserToDeleteRows = false;
            this.TableSumGrid.AllowUserToResizeRows = false;
            this.TableSumGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TableSumGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableSumGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TableSumGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableSumGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TableSumGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableSumGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableSumGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.TableSumGrid.EnableHeadersVisualStyles = false;
            this.TableSumGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TableSumGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TableSumGrid.Location = new System.Drawing.Point(181, 9);
            this.TableSumGrid.Name = "TableSumGrid";
            this.TableSumGrid.ReadOnly = true;
            this.TableSumGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableSumGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TableSumGrid.RowHeadersVisible = false;
            this.TableSumGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TableSumGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableSumGrid.Size = new System.Drawing.Size(606, 290);
            this.TableSumGrid.Style = MetroFramework.MetroColorStyle.Orange;
            this.TableSumGrid.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tanggal";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Keterangan";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column2.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Pemasukan";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Pengeluaran";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Saldo";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.iconExport2);
            this.metroTabPage3.Controls.Add(this.btnExportPembukuan);
            this.metroTabPage3.Controls.Add(this.iconApply2);
            this.metroTabPage3.Controls.Add(this.GridPembukuan);
            this.metroTabPage3.Controls.Add(this.btnApply);
            this.metroTabPage3.Controls.Add(this.treePembukuan);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(793, 302);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Pembukuan";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // iconExport2
            // 
            this.iconExport2.Image = ((System.Drawing.Image)(resources.GetObject("iconExport2.Image")));
            this.iconExport2.Location = new System.Drawing.Point(26, 244);
            this.iconExport2.Name = "iconExport2";
            this.iconExport2.Size = new System.Drawing.Size(15, 15);
            this.iconExport2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconExport2.TabIndex = 18;
            this.iconExport2.TabStop = false;
            // 
            // btnExportPembukuan
            // 
            this.btnExportPembukuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.btnExportPembukuan.ForeColor = System.Drawing.Color.White;
            this.btnExportPembukuan.Location = new System.Drawing.Point(9, 240);
            this.btnExportPembukuan.Name = "btnExportPembukuan";
            this.btnExportPembukuan.Size = new System.Drawing.Size(158, 23);
            this.btnExportPembukuan.TabIndex = 17;
            this.btnExportPembukuan.Text = "Export to Excel";
            this.btnExportPembukuan.UseCustomBackColor = true;
            this.btnExportPembukuan.UseCustomForeColor = true;
            this.btnExportPembukuan.UseSelectable = true;
            this.btnExportPembukuan.Click += new System.EventHandler(this.btnExportPembukuan_Click);
            // 
            // iconApply2
            // 
            this.iconApply2.Image = ((System.Drawing.Image)(resources.GetObject("iconApply2.Image")));
            this.iconApply2.Location = new System.Drawing.Point(48, 273);
            this.iconApply2.Name = "iconApply2";
            this.iconApply2.Size = new System.Drawing.Size(15, 15);
            this.iconApply2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconApply2.TabIndex = 16;
            this.iconApply2.TabStop = false;
            // 
            // GridPembukuan
            // 
            this.GridPembukuan.AllowUserToAddRows = false;
            this.GridPembukuan.AllowUserToDeleteRows = false;
            this.GridPembukuan.AllowUserToResizeRows = false;
            this.GridPembukuan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridPembukuan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridPembukuan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridPembukuan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPembukuan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridPembukuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPembukuan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.Column7,
            this.dataGridViewTextBoxColumn3,
            this.Column8});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridPembukuan.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridPembukuan.EnableHeadersVisualStyles = false;
            this.GridPembukuan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridPembukuan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridPembukuan.Location = new System.Drawing.Point(181, 9);
            this.GridPembukuan.Name = "GridPembukuan";
            this.GridPembukuan.ReadOnly = true;
            this.GridPembukuan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPembukuan.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridPembukuan.RowHeadersVisible = false;
            this.GridPembukuan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridPembukuan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPembukuan.Size = new System.Drawing.Size(606, 290);
            this.GridPembukuan.Style = MetroFramework.MetroColorStyle.Orange;
            this.GridPembukuan.TabIndex = 15;
            this.GridPembukuan.UseCustomForeColor = true;
            this.GridPembukuan.UseStyleColors = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Tanggal";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn1.Width = 110;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Pemasukan";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Perubahan";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Pengeluaran";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Perubahan";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(9, 269);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(158, 23);
            this.btnApply.TabIndex = 13;
            this.btnApply.Text = "Apply";
            this.btnApply.UseCustomBackColor = true;
            this.btnApply.UseCustomForeColor = true;
            this.btnApply.UseSelectable = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // treePembukuan
            // 
            this.treePembukuan.ImageIndex = 0;
            this.treePembukuan.ImageList = this.imageList1;
            this.treePembukuan.Location = new System.Drawing.Point(3, 9);
            this.treePembukuan.Name = "treePembukuan";
            treeNode14.ImageIndex = 1;
            treeNode14.Name = "Harian";
            treeNode14.SelectedImageIndex = 1;
            treeNode14.Text = "Harian";
            treeNode15.ImageIndex = 1;
            treeNode15.Name = "Bulanan";
            treeNode15.SelectedImageIndex = 1;
            treeNode15.Text = "Bulanan";
            treeNode16.ImageIndex = 1;
            treeNode16.Name = "Tahunan";
            treeNode16.SelectedImageIndex = 1;
            treeNode16.Text = "Tahunan";
            treeNode17.Name = "Node0";
            treeNode17.Text = "Filter by";
            this.treePembukuan.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode17});
            this.treePembukuan.SelectedImageIndex = 0;
            this.treePembukuan.Size = new System.Drawing.Size(172, 290);
            this.treePembukuan.TabIndex = 2;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.GridHistory);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(793, 302);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "History";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // GridHistory
            // 
            this.GridHistory.AllowUserToAddRows = false;
            this.GridHistory.AllowUserToDeleteRows = false;
            this.GridHistory.AllowUserToResizeRows = false;
            this.GridHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GridHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Column6});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridHistory.DefaultCellStyle = dataGridViewCellStyle8;
            this.GridHistory.EnableHeadersVisualStyles = false;
            this.GridHistory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridHistory.Location = new System.Drawing.Point(3, 9);
            this.GridHistory.Name = "GridHistory";
            this.GridHistory.ReadOnly = true;
            this.GridHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.GridHistory.RowHeadersVisible = false;
            this.GridHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridHistory.Size = new System.Drawing.Size(791, 290);
            this.GridHistory.Style = MetroFramework.MetroColorStyle.Orange;
            this.GridHistory.TabIndex = 16;
            this.GridHistory.UseCustomForeColor = true;
            this.GridHistory.UseStyleColors = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tanggal";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Informasi";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn5.Width = 250;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Keterangan";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn6.Width = 250;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Nominal";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(20, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(66, 45);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 10;
            this.pictureBox7.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 440);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "         Debcash";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconApply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableSumGrid)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconExport2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconApply2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPembukuan)).EndInit();
            this.metroTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kreditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroGrid TableSumGrid;
        private System.Windows.Forms.TreeView filterTree;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel lblPemasukan;
        private MetroFramework.Controls.MetroLabel lblTanggalPemasukan;
        private MetroFramework.Controls.MetroLabel lblTotalPengeluaran;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel lblTotalPemasukan;
        private MetroFramework.Controls.MetroLabel lblSaldo;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel lblKenaikanTertinggi;
        private MetroFramework.Controls.MetroLabel lblPersenUntung;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel lblPengeluarans;
        private MetroFramework.Controls.MetroLabel lblTanggalPengeluaran;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private MetroFramework.Controls.MetroButton btnClearTable;
        private MetroFramework.Controls.MetroButton btnApplyTable;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem lblUsername;
        private System.Windows.Forms.ToolStripMenuItem lblKeluar;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroGrid GridPembukuan;
        private MetroFramework.Controls.MetroButton btnApply;
        private System.Windows.Forms.TreeView treePembukuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroGrid GridHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.PictureBox iconApply;
        private System.Windows.Forms.PictureBox iconApply2;
        private System.Windows.Forms.PictureBox iconClear;
        private MetroFramework.Controls.MetroButton btnExportSummary;
        private MetroFramework.Controls.MetroButton btnExportPembukuan;
        private System.Windows.Forms.PictureBox iconExport;
        private System.Windows.Forms.PictureBox iconExport2;
    }
}

