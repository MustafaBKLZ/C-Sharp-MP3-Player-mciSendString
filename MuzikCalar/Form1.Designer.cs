namespace MuzikCalar
{//https://mustafabukulmez.com/2019/01/09/c-mp3-calar-uygulamasi-mcisendstring/
    partial class Form1
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
            //https://mustafabukulmez.com/2019/01/09/c-mp3-calar-uygulamasi-mcisendstring/
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Muzik_sec = new System.Windows.Forms.Button();
            this.btn_muzik_oynat = new System.Windows.Forms.Button();
            this.btn_muzik_durdur = new System.Windows.Forms.Button();
            this.list_Muzik_Liste = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_liste_temizle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tck_bas = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.tck_tiz = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tck_ana_ses = new System.Windows.Forms.TrackBar();
            this.lbl_ana_ses = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tck_sol_ses = new System.Windows.Forms.TrackBar();
            this.lbl_sol_ses = new System.Windows.Forms.Label();
            this.tck_sag_ses = new System.Windows.Forms.TrackBar();
            this.lbl_sag_ses = new System.Windows.Forms.Label();
            this.btn_onceki = new System.Windows.Forms.Button();
            this.btn_sonraki = new System.Windows.Forms.Button();
            this.lbl_toplam_sn = new System.Windows.Forms.Label();
            this.lbl_pozisyon_sn = new System.Windows.Forms.Label();
            this.btn_duraklat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk_tekrarla = new System.Windows.Forms.CheckBox();
            this.chk_karistir = new System.Windows.Forms.CheckBox();
            this.btn_rastgele = new System.Windows.Forms.Button();
            this.grp_muzik = new System.Windows.Forms.GroupBox();
            this.tck_muzik_durum = new System.Windows.Forms.TrackBar();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tck_bas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tck_tiz)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tck_ana_ses)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tck_sol_ses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tck_sag_ses)).BeginInit();
            this.panel1.SuspendLayout();
            this.grp_muzik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tck_muzik_durum)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Muzik_sec
            // 
            this.btn_Muzik_sec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Muzik_sec.Image = ((System.Drawing.Image)(resources.GetObject("btn_Muzik_sec.Image")));
            this.btn_Muzik_sec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Muzik_sec.Location = new System.Drawing.Point(0, 0);
            this.btn_Muzik_sec.Name = "btn_Muzik_sec";
            this.btn_Muzik_sec.Size = new System.Drawing.Size(344, 75);
            this.btn_Muzik_sec.TabIndex = 2;
            this.btn_Muzik_sec.Text = "Oynatma Listesi Oluştur";
            this.btn_Muzik_sec.UseVisualStyleBackColor = true;
            this.btn_Muzik_sec.Click += new System.EventHandler(this.btn_Muzik_sec_Click);
            // 
            // btn_muzik_oynat
            // 
            this.btn_muzik_oynat.BackColor = System.Drawing.Color.Transparent;
            this.btn_muzik_oynat.Enabled = false;
            this.btn_muzik_oynat.FlatAppearance.BorderSize = 0;
            this.btn_muzik_oynat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_muzik_oynat.Image = ((System.Drawing.Image)(resources.GetObject("btn_muzik_oynat.Image")));
            this.btn_muzik_oynat.Location = new System.Drawing.Point(269, 95);
            this.btn_muzik_oynat.Name = "btn_muzik_oynat";
            this.btn_muzik_oynat.Size = new System.Drawing.Size(75, 75);
            this.btn_muzik_oynat.TabIndex = 3;
            this.btn_muzik_oynat.UseVisualStyleBackColor = false;
            this.btn_muzik_oynat.Click += new System.EventHandler(this.btn_muzik_oynat_Click);
            // 
            // btn_muzik_durdur
            // 
            this.btn_muzik_durdur.BackColor = System.Drawing.Color.Transparent;
            this.btn_muzik_durdur.Enabled = false;
            this.btn_muzik_durdur.FlatAppearance.BorderSize = 0;
            this.btn_muzik_durdur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_muzik_durdur.Image = ((System.Drawing.Image)(resources.GetObject("btn_muzik_durdur.Image")));
            this.btn_muzik_durdur.Location = new System.Drawing.Point(674, 95);
            this.btn_muzik_durdur.Name = "btn_muzik_durdur";
            this.btn_muzik_durdur.Size = new System.Drawing.Size(75, 75);
            this.btn_muzik_durdur.TabIndex = 4;
            this.btn_muzik_durdur.UseVisualStyleBackColor = false;
            this.btn_muzik_durdur.Click += new System.EventHandler(this.btn_muzik_durdur_Click);
            // 
            // list_Muzik_Liste
            // 
            this.list_Muzik_Liste.ContextMenuStrip = this.contextMenuStrip1;
            this.list_Muzik_Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_Muzik_Liste.FormattingEnabled = true;
            this.list_Muzik_Liste.ItemHeight = 16;
            this.list_Muzik_Liste.Location = new System.Drawing.Point(0, 75);
            this.list_Muzik_Liste.Name = "list_Muzik_Liste";
            this.list_Muzik_Liste.Size = new System.Drawing.Size(667, 408);
            this.list_Muzik_Liste.TabIndex = 5;
            this.list_Muzik_Liste.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.list_Muzik_Liste.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            this.list_Muzik_Liste.MouseDown += new System.Windows.Forms.MouseEventHandler(this.list_Musik_Liste_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 28);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.list_Muzik_Liste);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1071, 483);
            this.splitContainer1.SplitterDistance = 667;
            this.splitContainer1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Muzik_sec);
            this.panel2.Controls.Add(this.btn_liste_temizle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 75);
            this.panel2.TabIndex = 6;
            // 
            // btn_liste_temizle
            // 
            this.btn_liste_temizle.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_liste_temizle.Image = ((System.Drawing.Image)(resources.GetObject("btn_liste_temizle.Image")));
            this.btn_liste_temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_liste_temizle.Location = new System.Drawing.Point(344, 0);
            this.btn_liste_temizle.Name = "btn_liste_temizle";
            this.btn_liste_temizle.Size = new System.Drawing.Size(323, 75);
            this.btn_liste_temizle.TabIndex = 3;
            this.btn_liste_temizle.Text = "Listeyi Temizle";
            this.btn_liste_temizle.UseVisualStyleBackColor = true;
            this.btn_liste_temizle.Click += new System.EventHandler(this.btn_liste_temizle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tck_bas);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tck_tiz);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(236, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(164, 483);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ses Efekt";
            // 
            // tck_bas
            // 
            this.tck_bas.Location = new System.Drawing.Point(19, 21);
            this.tck_bas.Maximum = 100;
            this.tck_bas.Name = "tck_bas";
            this.tck_bas.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tck_bas.Size = new System.Drawing.Size(56, 421);
            this.tck_bas.TabIndex = 21;
            this.tck_bas.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tck_bas.Value = 100;
            this.tck_bas.Scroll += new System.EventHandler(this.tck_bas_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 445);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Bas";
            // 
            // tck_tiz
            // 
            this.tck_tiz.Location = new System.Drawing.Point(81, 21);
            this.tck_tiz.Maximum = 100;
            this.tck_tiz.Name = "tck_tiz";
            this.tck_tiz.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tck_tiz.Size = new System.Drawing.Size(56, 421);
            this.tck_tiz.TabIndex = 24;
            this.tck_tiz.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tck_tiz.Value = 100;
            this.tck_tiz.Scroll += new System.EventHandler(this.tck_tiz_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tiz";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tck_ana_ses);
            this.groupBox2.Controls.Add(this.lbl_ana_ses);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(153, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(83, 483);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ana Ses";
            // 
            // tck_ana_ses
            // 
            this.tck_ana_ses.Location = new System.Drawing.Point(14, 21);
            this.tck_ana_ses.Maximum = 100;
            this.tck_ana_ses.Name = "tck_ana_ses";
            this.tck_ana_ses.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tck_ana_ses.Size = new System.Drawing.Size(56, 421);
            this.tck_ana_ses.TabIndex = 12;
            this.tck_ana_ses.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tck_ana_ses.Value = 100;
            this.tck_ana_ses.Scroll += new System.EventHandler(this.tck_ana_ses_Scroll);
            // 
            // lbl_ana_ses
            // 
            this.lbl_ana_ses.AutoSize = true;
            this.lbl_ana_ses.Location = new System.Drawing.Point(26, 445);
            this.lbl_ana_ses.Name = "lbl_ana_ses";
            this.lbl_ana_ses.Size = new System.Drawing.Size(33, 17);
            this.lbl_ana_ses.TabIndex = 14;
            this.lbl_ana_ses.Text = "Ana";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tck_sol_ses);
            this.groupBox1.Controls.Add(this.lbl_sol_ses);
            this.groupBox1.Controls.Add(this.tck_sag_ses);
            this.groupBox1.Controls.Add(this.lbl_sag_ses);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 483);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sol / Sağ Ses";
            // 
            // tck_sol_ses
            // 
            this.tck_sol_ses.Location = new System.Drawing.Point(16, 21);
            this.tck_sol_ses.Maximum = 100;
            this.tck_sol_ses.Name = "tck_sol_ses";
            this.tck_sol_ses.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tck_sol_ses.Size = new System.Drawing.Size(56, 421);
            this.tck_sol_ses.TabIndex = 15;
            this.tck_sol_ses.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tck_sol_ses.Value = 100;
            this.tck_sol_ses.Scroll += new System.EventHandler(this.tck_sol_ses_Scroll);
            // 
            // lbl_sol_ses
            // 
            this.lbl_sol_ses.AutoSize = true;
            this.lbl_sol_ses.Location = new System.Drawing.Point(30, 445);
            this.lbl_sol_ses.Name = "lbl_sol_ses";
            this.lbl_sol_ses.Size = new System.Drawing.Size(28, 17);
            this.lbl_sol_ses.TabIndex = 17;
            this.lbl_sol_ses.Text = "Sol";
            // 
            // tck_sag_ses
            // 
            this.tck_sag_ses.Location = new System.Drawing.Point(78, 21);
            this.tck_sag_ses.Maximum = 100;
            this.tck_sag_ses.Name = "tck_sag_ses";
            this.tck_sag_ses.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tck_sag_ses.Size = new System.Drawing.Size(56, 421);
            this.tck_sag_ses.TabIndex = 18;
            this.tck_sag_ses.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tck_sag_ses.Value = 100;
            this.tck_sag_ses.Scroll += new System.EventHandler(this.tck_sag_ses_Scroll);
            // 
            // lbl_sag_ses
            // 
            this.lbl_sag_ses.AutoSize = true;
            this.lbl_sag_ses.Location = new System.Drawing.Point(90, 445);
            this.lbl_sag_ses.Name = "lbl_sag_ses";
            this.lbl_sag_ses.Size = new System.Drawing.Size(33, 17);
            this.lbl_sag_ses.TabIndex = 20;
            this.lbl_sag_ses.Text = "Sağ";
            // 
            // btn_onceki
            // 
            this.btn_onceki.BackColor = System.Drawing.Color.Transparent;
            this.btn_onceki.Enabled = false;
            this.btn_onceki.FlatAppearance.BorderSize = 0;
            this.btn_onceki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_onceki.Image = ((System.Drawing.Image)(resources.GetObject("btn_onceki.Image")));
            this.btn_onceki.Location = new System.Drawing.Point(512, 95);
            this.btn_onceki.Name = "btn_onceki";
            this.btn_onceki.Size = new System.Drawing.Size(75, 75);
            this.btn_onceki.TabIndex = 33;
            this.btn_onceki.UseVisualStyleBackColor = false;
            this.btn_onceki.Click += new System.EventHandler(this.btn_onceki_Click);
            // 
            // btn_sonraki
            // 
            this.btn_sonraki.BackColor = System.Drawing.Color.Transparent;
            this.btn_sonraki.Enabled = false;
            this.btn_sonraki.FlatAppearance.BorderSize = 0;
            this.btn_sonraki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sonraki.Image = ((System.Drawing.Image)(resources.GetObject("btn_sonraki.Image")));
            this.btn_sonraki.Location = new System.Drawing.Point(593, 95);
            this.btn_sonraki.Name = "btn_sonraki";
            this.btn_sonraki.Size = new System.Drawing.Size(75, 75);
            this.btn_sonraki.TabIndex = 32;
            this.btn_sonraki.UseVisualStyleBackColor = false;
            this.btn_sonraki.Click += new System.EventHandler(this.btn_sonraki_Click);
            // 
            // lbl_toplam_sn
            // 
            this.lbl_toplam_sn.AutoSize = true;
            this.lbl_toplam_sn.BackColor = System.Drawing.Color.Transparent;
            this.lbl_toplam_sn.Location = new System.Drawing.Point(995, 66);
            this.lbl_toplam_sn.Name = "lbl_toplam_sn";
            this.lbl_toplam_sn.Size = new System.Drawing.Size(64, 17);
            this.lbl_toplam_sn.TabIndex = 31;
            this.lbl_toplam_sn.Text = "00:00:00";
            this.lbl_toplam_sn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_pozisyon_sn
            // 
            this.lbl_pozisyon_sn.AutoSize = true;
            this.lbl_pozisyon_sn.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pozisyon_sn.Location = new System.Drawing.Point(926, 66);
            this.lbl_pozisyon_sn.Name = "lbl_pozisyon_sn";
            this.lbl_pozisyon_sn.Size = new System.Drawing.Size(64, 17);
            this.lbl_pozisyon_sn.TabIndex = 30;
            this.lbl_pozisyon_sn.Text = "00:00:00";
            this.lbl_pozisyon_sn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_duraklat
            // 
            this.btn_duraklat.BackColor = System.Drawing.Color.Transparent;
            this.btn_duraklat.Enabled = false;
            this.btn_duraklat.FlatAppearance.BorderSize = 0;
            this.btn_duraklat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_duraklat.Image = ((System.Drawing.Image)(resources.GetObject("btn_duraklat.Image")));
            this.btn_duraklat.Location = new System.Drawing.Point(431, 95);
            this.btn_duraklat.Name = "btn_duraklat";
            this.btn_duraklat.Size = new System.Drawing.Size(75, 75);
            this.btn_duraklat.TabIndex = 7;
            this.btn_duraklat.UseVisualStyleBackColor = false;
            this.btn_duraklat.Click += new System.EventHandler(this.btn_duraklat_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chk_tekrarla);
            this.panel1.Controls.Add(this.chk_karistir);
            this.panel1.Controls.Add(this.btn_rastgele);
            this.panel1.Controls.Add(this.grp_muzik);
            this.panel1.Controls.Add(this.btn_muzik_durdur);
            this.panel1.Controls.Add(this.btn_sonraki);
            this.panel1.Controls.Add(this.btn_onceki);
            this.panel1.Controls.Add(this.btn_duraklat);
            this.panel1.Controls.Add(this.btn_muzik_oynat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 483);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 179);
            this.panel1.TabIndex = 8;
            // 
            // chk_tekrarla
            // 
            this.chk_tekrarla.AutoSize = true;
            this.chk_tekrarla.Location = new System.Drawing.Point(12, 122);
            this.chk_tekrarla.Name = "chk_tekrarla";
            this.chk_tekrarla.Size = new System.Drawing.Size(129, 21);
            this.chk_tekrarla.TabIndex = 37;
            this.chk_tekrarla.Text = "Şarkıyı Tekrarla";
            this.chk_tekrarla.UseVisualStyleBackColor = true;
            // 
            // chk_karistir
            // 
            this.chk_karistir.AutoSize = true;
            this.chk_karistir.Location = new System.Drawing.Point(12, 95);
            this.chk_karistir.Name = "chk_karistir";
            this.chk_karistir.Size = new System.Drawing.Size(74, 21);
            this.chk_karistir.TabIndex = 36;
            this.chk_karistir.Text = "Karıştır";
            this.chk_karistir.UseVisualStyleBackColor = true;
            // 
            // btn_rastgele
            // 
            this.btn_rastgele.BackColor = System.Drawing.Color.Transparent;
            this.btn_rastgele.Enabled = false;
            this.btn_rastgele.FlatAppearance.BorderSize = 0;
            this.btn_rastgele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rastgele.Image = ((System.Drawing.Image)(resources.GetObject("btn_rastgele.Image")));
            this.btn_rastgele.Location = new System.Drawing.Point(350, 95);
            this.btn_rastgele.Name = "btn_rastgele";
            this.btn_rastgele.Size = new System.Drawing.Size(75, 75);
            this.btn_rastgele.TabIndex = 35;
            this.btn_rastgele.UseVisualStyleBackColor = false;
            this.btn_rastgele.Click += new System.EventHandler(this.btn_rastgele_Click);
            // 
            // grp_muzik
            // 
            this.grp_muzik.Controls.Add(this.lbl_toplam_sn);
            this.grp_muzik.Controls.Add(this.lbl_pozisyon_sn);
            this.grp_muzik.Controls.Add(this.tck_muzik_durum);
            this.grp_muzik.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_muzik.Location = new System.Drawing.Point(0, 0);
            this.grp_muzik.Name = "grp_muzik";
            this.grp_muzik.Size = new System.Drawing.Size(1071, 89);
            this.grp_muzik.TabIndex = 34;
            this.grp_muzik.TabStop = false;
            this.grp_muzik.Text = "Çalan Müzik : ...";
            // 
            // tck_muzik_durum
            // 
            this.tck_muzik_durum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tck_muzik_durum.Location = new System.Drawing.Point(6, 24);
            this.tck_muzik_durum.Maximum = 500;
            this.tck_muzik_durum.Name = "tck_muzik_durum";
            this.tck_muzik_durum.Size = new System.Drawing.Size(1059, 56);
            this.tck_muzik_durum.TabIndex = 4;
            this.tck_muzik_durum.Scroll += new System.EventHandler(this.tck_muzik_durum_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 662);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Mustafa BÜKÜLMEZ Basit MP3 Çalar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tck_bas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tck_tiz)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tck_ana_ses)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tck_sol_ses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tck_sag_ses)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grp_muzik.ResumeLayout(false);
            this.grp_muzik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tck_muzik_durum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Muzik_sec;
        private System.Windows.Forms.Button btn_muzik_oynat;
        private System.Windows.Forms.Button btn_muzik_durdur;
        private System.Windows.Forms.ListBox list_Muzik_Liste;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_duraklat;
        private System.Windows.Forms.TrackBar tck_ana_ses;
        private System.Windows.Forms.Label lbl_ana_ses;
        private System.Windows.Forms.Label lbl_sol_ses;
        private System.Windows.Forms.TrackBar tck_sol_ses;
        private System.Windows.Forms.Label lbl_sag_ses;
        private System.Windows.Forms.TrackBar tck_sag_ses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tck_tiz;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar tck_bas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_pozisyon_sn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_toplam_sn;
        private System.Windows.Forms.Button btn_sonraki;
        private System.Windows.Forms.Button btn_onceki;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_liste_temizle;
        private System.Windows.Forms.TrackBar tck_muzik_durum;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.GroupBox grp_muzik;
        private System.Windows.Forms.Button btn_rastgele;
        private System.Windows.Forms.CheckBox chk_tekrarla;
        private System.Windows.Forms.CheckBox chk_karistir;
    }
}

//https://mustafabukulmez.com/2019/01/09/c-mp3-calar-uygulamasi-mcisendstring/