namespace OtoparkProjesi.Forms
{
    partial class frmAracOtoparkCikisi
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
            this.panelArama = new System.Windows.Forms.Panel();
            this.comboParkYeriAra = new System.Windows.Forms.ComboBox();
            this.txtIDAra = new System.Windows.Forms.TextBox();
            this.comboPlakaAra = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdSoyadAra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMusteriIDAra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelIslemler = new System.Windows.Forms.Panel();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnParkYeriGuncelle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnAracCikisi = new System.Windows.Forms.Button();
            this.lblUcret = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblCikisTarihi = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblGirisTarihi = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panelBilgiler = new System.Windows.Forms.Panel();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboSaatUcreti = new System.Windows.Forms.ComboBox();
            this.comboParkYeri = new System.Windows.Forms.ComboBox();
            this.comboTur = new System.Windows.Forms.ComboBox();
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdiSoyadi = new System.Windows.Forms.TextBox();
            this.txtMusteriID = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelArama.SuspendLayout();
            this.panelIslemler.SuspendLayout();
            this.panelBilgiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelArama
            // 
            this.panelArama.Controls.Add(this.comboParkYeriAra);
            this.panelArama.Controls.Add(this.txtIDAra);
            this.panelArama.Controls.Add(this.comboPlakaAra);
            this.panelArama.Controls.Add(this.label5);
            this.panelArama.Controls.Add(this.txtAdSoyadAra);
            this.panelArama.Controls.Add(this.label4);
            this.panelArama.Controls.Add(this.txtMusteriIDAra);
            this.panelArama.Controls.Add(this.label3);
            this.panelArama.Controls.Add(this.label2);
            this.panelArama.Controls.Add(this.label1);
            this.panelArama.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelArama.Location = new System.Drawing.Point(0, 0);
            this.panelArama.Name = "panelArama";
            this.panelArama.Size = new System.Drawing.Size(647, 75);
            this.panelArama.TabIndex = 0;
            // 
            // comboParkYeriAra
            // 
            this.comboParkYeriAra.FormattingEnabled = true;
            this.comboParkYeriAra.Location = new System.Drawing.Point(482, 34);
            this.comboParkYeriAra.Name = "comboParkYeriAra";
            this.comboParkYeriAra.Size = new System.Drawing.Size(108, 21);
            this.comboParkYeriAra.TabIndex = 9;
            this.comboParkYeriAra.SelectedIndexChanged += new System.EventHandler(this.comboParkYeriAra_SelectedIndexChanged);
            this.comboParkYeriAra.TextChanged += new System.EventHandler(this.comboParkYeriAra_TextChanged);
            // 
            // txtIDAra
            // 
            this.txtIDAra.Location = new System.Drawing.Point(26, 34);
            this.txtIDAra.Name = "txtIDAra";
            this.txtIDAra.Size = new System.Drawing.Size(108, 20);
            this.txtIDAra.TabIndex = 5;
            this.txtIDAra.TextChanged += new System.EventHandler(this.txtIDAra_TextChanged);
            // 
            // comboPlakaAra
            // 
            this.comboPlakaAra.FormattingEnabled = true;
            this.comboPlakaAra.Location = new System.Drawing.Point(368, 34);
            this.comboPlakaAra.Name = "comboPlakaAra";
            this.comboPlakaAra.Size = new System.Drawing.Size(108, 21);
            this.comboPlakaAra.TabIndex = 8;
            this.comboPlakaAra.SelectedIndexChanged += new System.EventHandler(this.comboPlakaAra_SelectedIndexChanged);
            this.comboPlakaAra.TextChanged += new System.EventHandler(this.comboPlakaAra_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Park Yeri Ara";
            // 
            // txtAdSoyadAra
            // 
            this.txtAdSoyadAra.Location = new System.Drawing.Point(254, 34);
            this.txtAdSoyadAra.Name = "txtAdSoyadAra";
            this.txtAdSoyadAra.Size = new System.Drawing.Size(108, 20);
            this.txtAdSoyadAra.TabIndex = 6;
            this.txtAdSoyadAra.TextChanged += new System.EventHandler(this.txtAdSoyadAra_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Plaka Ara";
            // 
            // txtMusteriIDAra
            // 
            this.txtMusteriIDAra.Location = new System.Drawing.Point(140, 34);
            this.txtMusteriIDAra.Name = "txtMusteriIDAra";
            this.txtMusteriIDAra.Size = new System.Drawing.Size(108, 20);
            this.txtMusteriIDAra.TabIndex = 7;
            this.txtMusteriIDAra.TextChanged += new System.EventHandler(this.txtMusteriIDAra_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad Soyad Ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Müşteri ID Ara";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Ara";
            // 
            // panelIslemler
            // 
            this.panelIslemler.Controls.Add(this.btnTemizle);
            this.panelIslemler.Controls.Add(this.btnCikis);
            this.panelIslemler.Controls.Add(this.btnSil);
            this.panelIslemler.Controls.Add(this.btnParkYeriGuncelle);
            this.panelIslemler.Controls.Add(this.btnGuncelle);
            this.panelIslemler.Controls.Add(this.btnAracCikisi);
            this.panelIslemler.Controls.Add(this.lblUcret);
            this.panelIslemler.Controls.Add(this.label23);
            this.panelIslemler.Controls.Add(this.lblSure);
            this.panelIslemler.Controls.Add(this.label21);
            this.panelIslemler.Controls.Add(this.lblCikisTarihi);
            this.panelIslemler.Controls.Add(this.label19);
            this.panelIslemler.Controls.Add(this.lblGirisTarihi);
            this.panelIslemler.Controls.Add(this.label16);
            this.panelIslemler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelIslemler.Location = new System.Drawing.Point(0, 272);
            this.panelIslemler.Name = "panelIslemler";
            this.panelIslemler.Size = new System.Drawing.Size(647, 106);
            this.panelIslemler.TabIndex = 1;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(405, 71);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(76, 23);
            this.btnTemizle.TabIndex = 29;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(568, 71);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(76, 23);
            this.btnCikis.TabIndex = 28;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(487, 71);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(76, 23);
            this.btnSil.TabIndex = 27;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnParkYeriGuncelle
            // 
            this.btnParkYeriGuncelle.Location = new System.Drawing.Point(285, 71);
            this.btnParkYeriGuncelle.Name = "btnParkYeriGuncelle";
            this.btnParkYeriGuncelle.Size = new System.Drawing.Size(114, 23);
            this.btnParkYeriGuncelle.TabIndex = 26;
            this.btnParkYeriGuncelle.Text = "Park Yeri Güncelle";
            this.btnParkYeriGuncelle.UseVisualStyleBackColor = true;
            this.btnParkYeriGuncelle.Click += new System.EventHandler(this.btnParkYeriGuncelle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(206, 71);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(73, 23);
            this.btnGuncelle.TabIndex = 25;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnAracCikisi
            // 
            this.btnAracCikisi.Location = new System.Drawing.Point(124, 71);
            this.btnAracCikisi.Name = "btnAracCikisi";
            this.btnAracCikisi.Size = new System.Drawing.Size(76, 23);
            this.btnAracCikisi.TabIndex = 24;
            this.btnAracCikisi.Text = "Araç Çıkış";
            this.btnAracCikisi.UseVisualStyleBackColor = true;
            this.btnAracCikisi.Click += new System.EventHandler(this.btnAracCikisi_Click);
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUcret.Location = new System.Drawing.Point(298, 37);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(13, 14);
            this.lblUcret.TabIndex = 7;
            this.lblUcret.Text = "5";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(298, 12);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(34, 14);
            this.label23.TabIndex = 6;
            this.label23.Text = "Ücret";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSure.Location = new System.Drawing.Point(229, 37);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(13, 14);
            this.lblSure.TabIndex = 5;
            this.lblSure.Text = "3";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(229, 12);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(30, 14);
            this.label21.TabIndex = 4;
            this.label21.Text = "Süre";
            // 
            // lblCikisTarihi
            // 
            this.lblCikisTarihi.AutoSize = true;
            this.lblCikisTarihi.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCikisTarihi.Location = new System.Drawing.Point(125, 37);
            this.lblCikisTarihi.Name = "lblCikisTarihi";
            this.lblCikisTarihi.Size = new System.Drawing.Size(91, 14);
            this.lblCikisTarihi.TabIndex = 3;
            this.lblCikisTarihi.Text = "09.09.2022 19:57";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(125, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 14);
            this.label19.TabIndex = 2;
            this.label19.Text = "Çıkış Tarihi";
            // 
            // lblGirisTarihi
            // 
            this.lblGirisTarihi.AutoSize = true;
            this.lblGirisTarihi.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGirisTarihi.Location = new System.Drawing.Point(23, 37);
            this.lblGirisTarihi.Name = "lblGirisTarihi";
            this.lblGirisTarihi.Size = new System.Drawing.Size(91, 14);
            this.lblGirisTarihi.TabIndex = 1;
            this.lblGirisTarihi.Text = "09.09.2022 16:40";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(23, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 14);
            this.label16.TabIndex = 0;
            this.label16.Text = "Giriş Tarihi";
            // 
            // panelBilgiler
            // 
            this.panelBilgiler.Controls.Add(this.txtAciklama);
            this.panelBilgiler.Controls.Add(this.label14);
            this.panelBilgiler.Controls.Add(this.comboSaatUcreti);
            this.panelBilgiler.Controls.Add(this.comboParkYeri);
            this.panelBilgiler.Controls.Add(this.comboTur);
            this.panelBilgiler.Controls.Add(this.comboMarka);
            this.panelBilgiler.Controls.Add(this.label15);
            this.panelBilgiler.Controls.Add(this.txtPlaka);
            this.panelBilgiler.Controls.Add(this.label10);
            this.panelBilgiler.Controls.Add(this.label11);
            this.panelBilgiler.Controls.Add(this.label12);
            this.panelBilgiler.Controls.Add(this.label13);
            this.panelBilgiler.Controls.Add(this.txtTelefon);
            this.panelBilgiler.Controls.Add(this.txtAdiSoyadi);
            this.panelBilgiler.Controls.Add(this.txtMusteriID);
            this.panelBilgiler.Controls.Add(this.txtID);
            this.panelBilgiler.Controls.Add(this.label9);
            this.panelBilgiler.Controls.Add(this.label8);
            this.panelBilgiler.Controls.Add(this.label7);
            this.panelBilgiler.Controls.Add(this.label6);
            this.panelBilgiler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBilgiler.Location = new System.Drawing.Point(0, 75);
            this.panelBilgiler.Name = "panelBilgiler";
            this.panelBilgiler.Size = new System.Drawing.Size(647, 197);
            this.panelBilgiler.TabIndex = 2;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(93, 116);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(121, 20);
            this.txtAciklama.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Aciklama";
            // 
            // comboSaatUcreti
            // 
            this.comboSaatUcreti.FormattingEnabled = true;
            this.comboSaatUcreti.Items.AddRange(new object[] {
            "7",
            "1"});
            this.comboSaatUcreti.Location = new System.Drawing.Point(365, 115);
            this.comboSaatUcreti.Name = "comboSaatUcreti";
            this.comboSaatUcreti.Size = new System.Drawing.Size(121, 21);
            this.comboSaatUcreti.TabIndex = 23;
            this.comboSaatUcreti.SelectedIndexChanged += new System.EventHandler(this.comboSaatUcreti_SelectedIndexChanged);
            // 
            // comboParkYeri
            // 
            this.comboParkYeri.FormattingEnabled = true;
            this.comboParkYeri.Location = new System.Drawing.Point(365, 88);
            this.comboParkYeri.Name = "comboParkYeri";
            this.comboParkYeri.Size = new System.Drawing.Size(121, 21);
            this.comboParkYeri.TabIndex = 22;
            // 
            // comboTur
            // 
            this.comboTur.FormattingEnabled = true;
            this.comboTur.Location = new System.Drawing.Point(365, 40);
            this.comboTur.Name = "comboTur";
            this.comboTur.Size = new System.Drawing.Size(121, 21);
            this.comboTur.TabIndex = 21;
            // 
            // comboMarka
            // 
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(365, 14);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(121, 21);
            this.comboMarka.TabIndex = 20;
            this.comboMarka.SelectedIndexChanged += new System.EventHandler(this.comboMarka_SelectedIndexChanged);
            this.comboMarka.ValueMemberChanged += new System.EventHandler(this.comboMarka_ValueMemberChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(295, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Saat Ücreti";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(365, 64);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(121, 20);
            this.txtPlaka.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(297, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Plaka";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(295, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Park Yeri";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(297, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Tür";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(295, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Marka";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(93, 89);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(121, 20);
            this.txtTelefon.TabIndex = 7;
            // 
            // txtAdiSoyadi
            // 
            this.txtAdiSoyadi.Location = new System.Drawing.Point(93, 64);
            this.txtAdiSoyadi.Name = "txtAdiSoyadi";
            this.txtAdiSoyadi.Size = new System.Drawing.Size(121, 20);
            this.txtAdiSoyadi.TabIndex = 6;
            // 
            // txtMusteriID
            // 
            this.txtMusteriID.Location = new System.Drawing.Point(93, 40);
            this.txtMusteriID.Name = "txtMusteriID";
            this.txtMusteriID.Size = new System.Drawing.Size(121, 20);
            this.txtMusteriID.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(93, 15);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(121, 20);
            this.txtID.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Adı Soyadı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Telefon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Müşteri ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID";
            // 
            // frmAracOtoparkCikisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 378);
            this.Controls.Add(this.panelBilgiler);
            this.Controls.Add(this.panelIslemler);
            this.Controls.Add(this.panelArama);
            this.Name = "frmAracOtoparkCikisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Otopark Çıkış Sayfası";
            this.Load += new System.EventHandler(this.frmAracOtoparkCikisi_Load);
            this.panelArama.ResumeLayout(false);
            this.panelArama.PerformLayout();
            this.panelIslemler.ResumeLayout(false);
            this.panelIslemler.PerformLayout();
            this.panelBilgiler.ResumeLayout(false);
            this.panelBilgiler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelArama;
        private System.Windows.Forms.ComboBox comboParkYeriAra;
        private System.Windows.Forms.TextBox txtIDAra;
        private System.Windows.Forms.ComboBox comboPlakaAra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdSoyadAra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMusteriIDAra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelIslemler;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboSaatUcreti;
        private System.Windows.Forms.ComboBox comboParkYeri;
        private System.Windows.Forms.ComboBox comboTur;
        private System.Windows.Forms.ComboBox comboMarka;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdiSoyadi;
        private System.Windows.Forms.TextBox txtMusteriID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblCikisTarihi;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblGirisTarihi;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnParkYeriGuncelle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnAracCikisi;
        private System.Windows.Forms.Panel panelBilgiler;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnTemizle;
    }
}