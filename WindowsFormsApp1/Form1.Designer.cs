namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.güncelle = new System.Windows.Forms.Button();
            this.listele = new System.Windows.Forms.Button();
            this.ekle = new System.Windows.Forms.Button();
            this.Cözüm_üreten = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.Aciliyet = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.En_son_güncellendiği_zaman = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.Tip = new System.Windows.Forms.TextBox();
            this.label71 = new System.Windows.Forms.Label();
            this.Zaman_Kaydedildi = new System.Windows.Forms.TextBox();
            this.label72 = new System.Windows.Forms.Label();
            this.Tür = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.Etiketler = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.Anket_sonuçları = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.Konu = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.Alt_kategori = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.Durum = new System.Windows.Forms.TextBox();
            this.label66 = new System.Windows.Forms.Label();
            this.Kaynak = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.Temsilci = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.Çözüldüğü_Zaman = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.Çözüldüğü_Zaman_Saat = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.Çözümleme_durumu = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.Talep_Sahibi_Adı = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.Talep_sahibi_eposta_adresi = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.Öncelik = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.Temsilci_etkileşimleri = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.Öğe = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.Oyuncu_Etkileşimi = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.Etki = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.Harici_sistem_ticket_no = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.Grup = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.Initial_Response_Time = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.İlk_yanıt_durumu = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.İlk_Cevap_Verildiği_Zaman_Saat = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.Süre_sonu = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.Bildirim_No = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.Departman = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.Oluşturulduğu_zaman = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Kapatıldığı_zaman = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Kategori = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Onay_durumu = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // güncelle
            // 
            this.güncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.güncelle.Location = new System.Drawing.Point(1942, 712);
            this.güncelle.Name = "güncelle";
            this.güncelle.Size = new System.Drawing.Size(118, 62);
            this.güncelle.TabIndex = 292;
            this.güncelle.Text = "Güncelle";
            this.güncelle.UseVisualStyleBackColor = false;
            this.güncelle.Click += new System.EventHandler(this.güncelle_Click);
            // 
            // listele
            // 
            this.listele.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listele.Location = new System.Drawing.Point(1942, 491);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(118, 61);
            this.listele.TabIndex = 291;
            this.listele.Text = "Listele";
            this.listele.UseVisualStyleBackColor = false;
            this.listele.Click += new System.EventHandler(this.listele_Click);
            // 
            // ekle
            // 
            this.ekle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ekle.Location = new System.Drawing.Point(1942, 604);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(118, 62);
            this.ekle.TabIndex = 290;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = false;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // Cözüm_üreten
            // 
            this.Cözüm_üreten.Location = new System.Drawing.Point(1696, 891);
            this.Cözüm_üreten.Name = "Cözüm_üreten";
            this.Cözüm_üreten.Size = new System.Drawing.Size(100, 20);
            this.Cözüm_üreten.TabIndex = 289;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(1501, 898);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(72, 13);
            this.label68.TabIndex = 288;
            this.label68.Text = "Çözüm üreten";
            // 
            // Aciliyet
            // 
            this.Aciliyet.Location = new System.Drawing.Point(1696, 845);
            this.Aciliyet.Name = "Aciliyet";
            this.Aciliyet.Size = new System.Drawing.Size(100, 20);
            this.Aciliyet.TabIndex = 287;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(1501, 852);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(40, 13);
            this.label69.TabIndex = 286;
            this.label69.Text = "Aciliyet";
            // 
            // En_son_güncellendiği_zaman
            // 
            this.En_son_güncellendiği_zaman.Location = new System.Drawing.Point(1696, 799);
            this.En_son_güncellendiği_zaman.Name = "En_son_güncellendiği_zaman";
            this.En_son_güncellendiği_zaman.Size = new System.Drawing.Size(100, 20);
            this.En_son_güncellendiği_zaman.TabIndex = 285;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(1501, 806);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(127, 13);
            this.label70.TabIndex = 284;
            this.label70.Text = "En son güncelleiği zaman";
            // 
            // Tip
            // 
            this.Tip.Location = new System.Drawing.Point(1696, 757);
            this.Tip.Name = "Tip";
            this.Tip.Size = new System.Drawing.Size(100, 20);
            this.Tip.TabIndex = 283;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(1501, 760);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(22, 13);
            this.label71.TabIndex = 282;
            this.label71.Text = "Tip";
            // 
            // Zaman_Kaydedildi
            // 
            this.Zaman_Kaydedildi.Location = new System.Drawing.Point(1696, 708);
            this.Zaman_Kaydedildi.Name = "Zaman_Kaydedildi";
            this.Zaman_Kaydedildi.Size = new System.Drawing.Size(100, 20);
            this.Zaman_Kaydedildi.TabIndex = 281;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(1501, 711);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(91, 13);
            this.label72.TabIndex = 280;
            this.label72.Text = "Zaman Kaydedildi";
            // 
            // Tür
            // 
            this.Tür.Location = new System.Drawing.Point(1045, 938);
            this.Tür.Name = "Tür";
            this.Tür.Size = new System.Drawing.Size(100, 20);
            this.Tür.TabIndex = 279;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(850, 945);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(23, 13);
            this.label61.TabIndex = 278;
            this.label61.Text = "Tür";
            // 
            // Etiketler
            // 
            this.Etiketler.Location = new System.Drawing.Point(1045, 884);
            this.Etiketler.Name = "Etiketler";
            this.Etiketler.Size = new System.Drawing.Size(100, 20);
            this.Etiketler.TabIndex = 277;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(850, 891);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(45, 13);
            this.label62.TabIndex = 276;
            this.label62.Text = "Etiketler";
            // 
            // Anket_sonuçları
            // 
            this.Anket_sonuçları.Location = new System.Drawing.Point(1045, 838);
            this.Anket_sonuçları.Name = "Anket_sonuçları";
            this.Anket_sonuçları.Size = new System.Drawing.Size(100, 20);
            this.Anket_sonuçları.TabIndex = 275;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(850, 845);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(82, 13);
            this.label63.TabIndex = 274;
            this.label63.Text = "Anket Sonuçları";
            // 
            // Konu
            // 
            this.Konu.Location = new System.Drawing.Point(1045, 792);
            this.Konu.Name = "Konu";
            this.Konu.Size = new System.Drawing.Size(100, 20);
            this.Konu.TabIndex = 273;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(850, 799);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(32, 13);
            this.label64.TabIndex = 272;
            this.label64.Text = "Konu";
            // 
            // Alt_kategori
            // 
            this.Alt_kategori.Location = new System.Drawing.Point(1045, 750);
            this.Alt_kategori.Name = "Alt_kategori";
            this.Alt_kategori.Size = new System.Drawing.Size(100, 20);
            this.Alt_kategori.TabIndex = 271;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(850, 753);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(61, 13);
            this.label65.TabIndex = 270;
            this.label65.Text = "Alt Kategori";
            // 
            // Durum
            // 
            this.Durum.Location = new System.Drawing.Point(1045, 701);
            this.Durum.Name = "Durum";
            this.Durum.Size = new System.Drawing.Size(100, 20);
            this.Durum.TabIndex = 269;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(850, 704);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(38, 13);
            this.label66.TabIndex = 268;
            this.label66.Text = "Durum";
            // 
            // Kaynak
            // 
            this.Kaynak.Location = new System.Drawing.Point(270, 962);
            this.Kaynak.Name = "Kaynak";
            this.Kaynak.Size = new System.Drawing.Size(100, 20);
            this.Kaynak.TabIndex = 267;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(75, 969);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(43, 13);
            this.label55.TabIndex = 266;
            this.label55.Text = "Kaynak";
            // 
            // Temsilci
            // 
            this.Temsilci.Location = new System.Drawing.Point(270, 908);
            this.Temsilci.Name = "Temsilci";
            this.Temsilci.Size = new System.Drawing.Size(100, 20);
            this.Temsilci.TabIndex = 265;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(75, 915);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(45, 13);
            this.label56.TabIndex = 264;
            this.label56.Text = "Temsilci";
            // 
            // Çözüldüğü_Zaman
            // 
            this.Çözüldüğü_Zaman.Location = new System.Drawing.Point(270, 862);
            this.Çözüldüğü_Zaman.Name = "Çözüldüğü_Zaman";
            this.Çözüldüğü_Zaman.Size = new System.Drawing.Size(100, 20);
            this.Çözüldüğü_Zaman.TabIndex = 263;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(75, 869);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(91, 13);
            this.label57.TabIndex = 262;
            this.label57.Text = "Çözüldüğü zaman";
            // 
            // Çözüldüğü_Zaman_Saat
            // 
            this.Çözüldüğü_Zaman_Saat.Location = new System.Drawing.Point(270, 816);
            this.Çözüldüğü_Zaman_Saat.Name = "Çözüldüğü_Zaman_Saat";
            this.Çözüldüğü_Zaman_Saat.Size = new System.Drawing.Size(100, 20);
            this.Çözüldüğü_Zaman_Saat.TabIndex = 261;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(75, 823);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(124, 13);
            this.label58.TabIndex = 260;
            this.label58.Text = "Çözüldüğü Zaman (Saat)";
            // 
            // Çözümleme_durumu
            // 
            this.Çözümleme_durumu.Location = new System.Drawing.Point(270, 774);
            this.Çözümleme_durumu.Name = "Çözümleme_durumu";
            this.Çözümleme_durumu.Size = new System.Drawing.Size(100, 20);
            this.Çözümleme_durumu.TabIndex = 259;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(75, 777);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(99, 13);
            this.label59.TabIndex = 258;
            this.label59.Text = "Çözümleme durumu";
            // 
            // Talep_Sahibi_Adı
            // 
            this.Talep_Sahibi_Adı.Location = new System.Drawing.Point(270, 725);
            this.Talep_Sahibi_Adı.Name = "Talep_Sahibi_Adı";
            this.Talep_Sahibi_Adı.Size = new System.Drawing.Size(100, 20);
            this.Talep_Sahibi_Adı.TabIndex = 257;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(75, 728);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(84, 13);
            this.label60.TabIndex = 256;
            this.label60.Text = "Talep Sahibi Adı";
            // 
            // Talep_sahibi_eposta_adresi
            // 
            this.Talep_sahibi_eposta_adresi.Location = new System.Drawing.Point(1693, 619);
            this.Talep_sahibi_eposta_adresi.Name = "Talep_sahibi_eposta_adresi";
            this.Talep_sahibi_eposta_adresi.Size = new System.Drawing.Size(100, 20);
            this.Talep_sahibi_eposta_adresi.TabIndex = 255;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(1498, 626);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(133, 13);
            this.label49.TabIndex = 254;
            this.label49.Text = "Talep sahibi e-posta adresi";
            // 
            // Öncelik
            // 
            this.Öncelik.Location = new System.Drawing.Point(1693, 565);
            this.Öncelik.Name = "Öncelik";
            this.Öncelik.Size = new System.Drawing.Size(100, 20);
            this.Öncelik.TabIndex = 253;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(1498, 572);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(43, 13);
            this.label50.TabIndex = 252;
            this.label50.Text = "Öncelik";
            // 
            // Temsilci_etkileşimleri
            // 
            this.Temsilci_etkileşimleri.Location = new System.Drawing.Point(1693, 519);
            this.Temsilci_etkileşimleri.Name = "Temsilci_etkileşimleri";
            this.Temsilci_etkileşimleri.Size = new System.Drawing.Size(100, 20);
            this.Temsilci_etkileşimleri.TabIndex = 251;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(1498, 526);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(102, 13);
            this.label51.TabIndex = 250;
            this.label51.Text = "Temsilci Etkileşimleri";
            // 
            // Öğe
            // 
            this.Öğe.Location = new System.Drawing.Point(1693, 473);
            this.Öğe.Name = "Öğe";
            this.Öğe.Size = new System.Drawing.Size(100, 20);
            this.Öğe.TabIndex = 249;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(1498, 480);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(27, 13);
            this.label52.TabIndex = 248;
            this.label52.Text = "Öğe";
            // 
            // Oyuncu_Etkileşimi
            // 
            this.Oyuncu_Etkileşimi.Location = new System.Drawing.Point(1693, 431);
            this.Oyuncu_Etkileşimi.Name = "Oyuncu_Etkileşimi";
            this.Oyuncu_Etkileşimi.Size = new System.Drawing.Size(100, 20);
            this.Oyuncu_Etkileşimi.TabIndex = 247;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(1498, 434);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(90, 13);
            this.label53.TabIndex = 246;
            this.label53.Text = "Oyuncu Etkileşimi";
            // 
            // Etki
            // 
            this.Etki.BackColor = System.Drawing.SystemColors.Window;
            this.Etki.Location = new System.Drawing.Point(1693, 382);
            this.Etki.Name = "Etki";
            this.Etki.Size = new System.Drawing.Size(100, 20);
            this.Etki.TabIndex = 245;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(1498, 385);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(25, 13);
            this.label54.TabIndex = 244;
            this.label54.Text = "Etki";
            // 
            // Harici_sistem_ticket_no
            // 
            this.Harici_sistem_ticket_no.Location = new System.Drawing.Point(1045, 612);
            this.Harici_sistem_ticket_no.Name = "Harici_sistem_ticket_no";
            this.Harici_sistem_ticket_no.Size = new System.Drawing.Size(100, 20);
            this.Harici_sistem_ticket_no.TabIndex = 243;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(850, 619);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(120, 13);
            this.label38.TabIndex = 242;
            this.label38.Text = "Harici sistem ticket no #";
            // 
            // Grup
            // 
            this.Grup.Location = new System.Drawing.Point(1045, 558);
            this.Grup.Name = "Grup";
            this.Grup.Size = new System.Drawing.Size(100, 20);
            this.Grup.TabIndex = 241;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(850, 565);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(30, 13);
            this.label39.TabIndex = 240;
            this.label39.Text = "Grup";
            // 
            // Initial_Response_Time
            // 
            this.Initial_Response_Time.Location = new System.Drawing.Point(1045, 512);
            this.Initial_Response_Time.Name = "Initial_Response_Time";
            this.Initial_Response_Time.Size = new System.Drawing.Size(100, 20);
            this.Initial_Response_Time.TabIndex = 239;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(850, 519);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(108, 13);
            this.label40.TabIndex = 238;
            this.label40.Text = "İnitial Response Time";
            // 
            // İlk_yanıt_durumu
            // 
            this.İlk_yanıt_durumu.Location = new System.Drawing.Point(1045, 466);
            this.İlk_yanıt_durumu.Name = "İlk_yanıt_durumu";
            this.İlk_yanıt_durumu.Size = new System.Drawing.Size(100, 20);
            this.İlk_yanıt_durumu.TabIndex = 237;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(850, 473);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(81, 13);
            this.label46.TabIndex = 236;
            this.label46.Text = "İlk yanıt durumu";
            // 
            // İlk_Cevap_Verildiği_Zaman_Saat
            // 
            this.İlk_Cevap_Verildiği_Zaman_Saat.Location = new System.Drawing.Point(1045, 424);
            this.İlk_Cevap_Verildiği_Zaman_Saat.Name = "İlk_Cevap_Verildiği_Zaman_Saat";
            this.İlk_Cevap_Verildiği_Zaman_Saat.Size = new System.Drawing.Size(100, 20);
            this.İlk_Cevap_Verildiği_Zaman_Saat.TabIndex = 235;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(850, 427);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(158, 13);
            this.label47.TabIndex = 234;
            this.label47.Text = "İlk Cevap Verildiği Zaman (Saat)";
            // 
            // Süre_sonu
            // 
            this.Süre_sonu.Location = new System.Drawing.Point(1045, 375);
            this.Süre_sonu.Name = "Süre_sonu";
            this.Süre_sonu.Size = new System.Drawing.Size(100, 20);
            this.Süre_sonu.TabIndex = 233;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(850, 378);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(57, 13);
            this.label48.TabIndex = 232;
            this.label48.Text = "Süre Sonu";
            // 
            // Bildirim_No
            // 
            this.Bildirim_No.Location = new System.Drawing.Point(270, 626);
            this.Bildirim_No.Name = "Bildirim_No";
            this.Bildirim_No.Size = new System.Drawing.Size(100, 20);
            this.Bildirim_No.TabIndex = 231;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(75, 626);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(56, 13);
            this.label37.TabIndex = 230;
            this.label37.Text = "Bildirim No";
            // 
            // Departman
            // 
            this.Departman.Location = new System.Drawing.Point(270, 565);
            this.Departman.Name = "Departman";
            this.Departman.Size = new System.Drawing.Size(100, 20);
            this.Departman.TabIndex = 229;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(75, 572);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(59, 13);
            this.label36.TabIndex = 228;
            this.label36.Text = "Departman";
            // 
            // Oluşturulduğu_zaman
            // 
            this.Oluşturulduğu_zaman.Location = new System.Drawing.Point(270, 519);
            this.Oluşturulduğu_zaman.Name = "Oluşturulduğu_zaman";
            this.Oluşturulduğu_zaman.Size = new System.Drawing.Size(100, 20);
            this.Oluşturulduğu_zaman.TabIndex = 227;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(75, 526);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 13);
            this.label15.TabIndex = 226;
            this.label15.Text = "Oluşturduğu Zaman";
            // 
            // Kapatıldığı_zaman
            // 
            this.Kapatıldığı_zaman.Location = new System.Drawing.Point(270, 473);
            this.Kapatıldığı_zaman.Name = "Kapatıldığı_zaman";
            this.Kapatıldığı_zaman.Size = new System.Drawing.Size(100, 20);
            this.Kapatıldığı_zaman.TabIndex = 225;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(75, 480);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 13);
            this.label14.TabIndex = 224;
            this.label14.Text = "Kapatıldğı zaman";
            // 
            // Kategori
            // 
            this.Kategori.Location = new System.Drawing.Point(270, 431);
            this.Kategori.Name = "Kategori";
            this.Kategori.Size = new System.Drawing.Size(100, 20);
            this.Kategori.TabIndex = 223;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(75, 434);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 222;
            this.label13.Text = "Kategori";
            // 
            // Onay_durumu
            // 
            this.Onay_durumu.Location = new System.Drawing.Point(270, 382);
            this.Onay_durumu.Name = "Onay_durumu";
            this.Onay_durumu.Size = new System.Drawing.Size(100, 20);
            this.Onay_durumu.TabIndex = 221;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(75, 385);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 220;
            this.label12.Text = "Onay Durumu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(2132, 320);
            this.dataGridView1.TabIndex = 219;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2132, 996);
            this.Controls.Add(this.güncelle);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.Cözüm_üreten);
            this.Controls.Add(this.label68);
            this.Controls.Add(this.Aciliyet);
            this.Controls.Add(this.label69);
            this.Controls.Add(this.En_son_güncellendiği_zaman);
            this.Controls.Add(this.label70);
            this.Controls.Add(this.Tip);
            this.Controls.Add(this.label71);
            this.Controls.Add(this.Zaman_Kaydedildi);
            this.Controls.Add(this.label72);
            this.Controls.Add(this.Tür);
            this.Controls.Add(this.label61);
            this.Controls.Add(this.Etiketler);
            this.Controls.Add(this.label62);
            this.Controls.Add(this.Anket_sonuçları);
            this.Controls.Add(this.label63);
            this.Controls.Add(this.Konu);
            this.Controls.Add(this.label64);
            this.Controls.Add(this.Alt_kategori);
            this.Controls.Add(this.label65);
            this.Controls.Add(this.Durum);
            this.Controls.Add(this.label66);
            this.Controls.Add(this.Kaynak);
            this.Controls.Add(this.label55);
            this.Controls.Add(this.Temsilci);
            this.Controls.Add(this.label56);
            this.Controls.Add(this.Çözüldüğü_Zaman);
            this.Controls.Add(this.label57);
            this.Controls.Add(this.Çözüldüğü_Zaman_Saat);
            this.Controls.Add(this.label58);
            this.Controls.Add(this.Çözümleme_durumu);
            this.Controls.Add(this.label59);
            this.Controls.Add(this.Talep_Sahibi_Adı);
            this.Controls.Add(this.label60);
            this.Controls.Add(this.Talep_sahibi_eposta_adresi);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.Öncelik);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.Temsilci_etkileşimleri);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.Öğe);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.Oyuncu_Etkileşimi);
            this.Controls.Add(this.label53);
            this.Controls.Add(this.Etki);
            this.Controls.Add(this.label54);
            this.Controls.Add(this.Harici_sistem_ticket_no);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.Grup);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.Initial_Response_Time);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.İlk_yanıt_durumu);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.İlk_Cevap_Verildiği_Zaman_Saat);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.Süre_sonu);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.Bildirim_No);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.Departman);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.Oluşturulduğu_zaman);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Kapatıldığı_zaman);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Kategori);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Onay_durumu);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button güncelle;
        private System.Windows.Forms.Button listele;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.TextBox Cözüm_üreten;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.TextBox Aciliyet;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.TextBox En_son_güncellendiği_zaman;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.TextBox Tip;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.TextBox Zaman_Kaydedildi;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.TextBox Tür;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.TextBox Etiketler;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.TextBox Anket_sonuçları;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.TextBox Konu;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TextBox Alt_kategori;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.TextBox Durum;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.TextBox Kaynak;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox Temsilci;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.TextBox Çözüldüğü_Zaman;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TextBox Çözüldüğü_Zaman_Saat;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TextBox Çözümleme_durumu;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.TextBox Talep_Sahibi_Adı;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.TextBox Talep_sahibi_eposta_adresi;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox Öncelik;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox Temsilci_etkileşimleri;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox Öğe;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox Oyuncu_Etkileşimi;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox Etki;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox Harici_sistem_ticket_no;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox Grup;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox Initial_Response_Time;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox İlk_yanıt_durumu;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox İlk_Cevap_Verildiği_Zaman_Saat;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox Süre_sonu;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox Bildirim_No;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox Departman;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox Oluşturulduğu_zaman;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Kapatıldığı_zaman;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Kategori;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Onay_durumu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

