using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\stajyer2\c#-demos\adonet\tickets-August-15-2022-12_37.xlsx;Extended Properties='Excel 12.0 Xml; HDR=YES;'");

        void Veriler()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("Select * From [Sayfa1$]", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();


                OleDbCommand komut = new OleDbCommand("insert into [Sayfa1$] (Onay_durumu,Kategori,Kapatıldığı_zaman,Oluşturulduğu_zaman,Departman,Bildirim_No,Süre_Sonu,İlk_Cevap_Verildiği_Zaman_Saat,İlk_Yanıt_Durumu,Initial_Response_Time,Grup,Harici_Sistem_Ticket_No,Etki,Oyuncu_Etkileşimi,Öğe,Temsilci_etkileşimleri,Öncelik,Talep_sahibi_eposta_adresi,Talep_Sahibi_Adı,Çözümleme_durumu,Çözüldüğü_Zaman_Saat,Çözüldüğü_Zaman,Temsilci,Kaynak,Durum,Alt_kategori,Konu,Anket_sonuçları,Etiketler,Tür,Zaman_Kaydedildi,Tip,En_Son_güncellendiği_zaman,Aciliyet,Çözüm_üreten) values (@pq,@pw,@pe,@pr,@pt,@py,@pu,@pı,@po,@pp,@pğ,@pü,@pa,@ps,@pd,@pf,@pg,@ph,@pj,@pk,@pl,@pş,@pi,@pz,@px,@pc,@pv,@pb,@pn,@pm,@pö,@pç,@paa,@pbb,@pcc)", baglanti);


                komut.Parameters.AddWithValue("@Onay_durumu", Onay_durumu.Text);
                komut.Parameters.AddWithValue("@Kategori", Kategori.Text);
                komut.Parameters.AddWithValue("@Kapatildigi_Zaman", Kapatıldığı_zaman.Text);
                komut.Parameters.AddWithValue("@Olusturuldugu_Zaman", Oluşturulduğu_zaman.Text);
                komut.Parameters.AddWithValue("@Departman", Departman.Text);
                komut.Parameters.AddWithValue("@Bildirim_No", Bildirim_No.Text);
                komut.Parameters.AddWithValue("@Süre_Sonu", Süre_sonu.Text);
                komut.Parameters.AddWithValue("@İlk_Cevap_Veridigi_Zaman_Saat", İlk_Cevap_Verildiği_Zaman_Saat.Text);
                komut.Parameters.AddWithValue("@İlk_Yanit_Durumu", İlk_yanıt_durumu.Text);
                komut.Parameters.AddWithValue("@Initial_Response_Time", Initial_Response_Time.Text);
                komut.Parameters.AddWithValue("@Grup", Grup.Text);
                komut.Parameters.AddWithValue("@Harici_Sistem_Ticket_No#", Harici_sistem_ticket_no.Text);
                komut.Parameters.AddWithValue("@Etki", Etki.Text);
                komut.Parameters.AddWithValue("@Oyuncu_Etkilesimi", Oyuncu_Etkileşimi.Text);
                komut.Parameters.AddWithValue("@Öge", Öğe.Text);
                komut.Parameters.AddWithValue("@Temsilci_Etkilesimleri", Temsilci_etkileşimleri.Text);
                komut.Parameters.AddWithValue("@Öncelik", Öncelik.Text);
                komut.Parameters.AddWithValue("@Talep_Sahibi_E-posta_Adresi", Talep_sahibi_eposta_adresi.Text);
                komut.Parameters.AddWithValue("@Talep_Sahibi_Adı", Talep_Sahibi_Adı.Text);
                komut.Parameters.AddWithValue("@Cözümleme_Durumu", Çözümleme_durumu.Text);
                komut.Parameters.AddWithValue("@Zaman", Çözüldüğü_Zaman_Saat.Text);
                komut.Parameters.AddWithValue("@Zaman_Saat", Çözüldüğü_Zaman.Text);
                komut.Parameters.AddWithValue("@Temsilci", Temsilci.Text);
                komut.Parameters.AddWithValue("@Kaynak", Kaynak.Text);
                komut.Parameters.AddWithValue("@Durum", Durum.Text);
                komut.Parameters.AddWithValue("@Alt_Kategori", Alt_kategori.Text);
                komut.Parameters.AddWithValue("@Konu", Konu.Text);
                komut.Parameters.AddWithValue("@Anket_Sonuclari", Anket_sonuçları.Text);
                komut.Parameters.AddWithValue("@Etiketler", Etiketler.Text);
                komut.Parameters.AddWithValue("@Tür", Tür.Text);
                komut.Parameters.AddWithValue("@Zaman_Kaydedildi", Zaman_Kaydedildi.Text);
                komut.Parameters.AddWithValue("@Tip", Tip.Text);
                komut.Parameters.AddWithValue("@En_Son_Güncellendigi_Zaman", En_son_güncellendiği_zaman.Text);
                komut.Parameters.AddWithValue("@Aciliyet", Aciliyet.Text);
                komut.Parameters.AddWithValue("@Cözüm_Ureten", Cözüm_üreten.Text);


                komut.ExecuteNonQuery();
                baglanti.Close();


                MessageBox.Show("Kayıt etme başarılı.");
            }
            catch (Exception error)
            {
                MessageBox.Show("Hata meydana geldi " + error.Message);
            }
        
    }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            Onay_durumu.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            Kategori.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            Kapatıldığı_zaman.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            Oluşturulduğu_zaman.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            Departman.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            Bildirim_No.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            Süre_sonu.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            İlk_Cevap_Verildiği_Zaman_Saat.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            İlk_yanıt_durumu.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            Initial_Response_Time.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            Grup.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            Harici_sistem_ticket_no.Text = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            Etki.Text = dataGridView1.Rows[secilen].Cells[12].Value.ToString();
            Oyuncu_Etkileşimi.Text = dataGridView1.Rows[secilen].Cells[13].Value.ToString();
            Öğe.Text = dataGridView1.Rows[secilen].Cells[14].Value.ToString();
            Temsilci_etkileşimleri.Text = dataGridView1.Rows[secilen].Cells[15].Value.ToString();
            Öncelik.Text = dataGridView1.Rows[secilen].Cells[16].Value.ToString();
            Talep_sahibi_eposta_adresi.Text = dataGridView1.Rows[secilen].Cells[17].Value.ToString();
            Talep_Sahibi_Adı.Text = dataGridView1.Rows[secilen].Cells[18].Value.ToString();
            Çözümleme_durumu.Text = dataGridView1.Rows[secilen].Cells[19].Value.ToString();
            Çözüldüğü_Zaman_Saat.Text = dataGridView1.Rows[secilen].Cells[20].Value.ToString();
            Çözüldüğü_Zaman.Text = dataGridView1.Rows[secilen].Cells[21].Value.ToString();
            Temsilci.Text = dataGridView1.Rows[secilen].Cells[22].Value.ToString();
            Kaynak.Text = dataGridView1.Rows[secilen].Cells[23].Value.ToString();
            Durum.Text = dataGridView1.Rows[secilen].Cells[24].Value.ToString();
            Alt_kategori.Text = dataGridView1.Rows[secilen].Cells[25].Value.ToString();
            Konu.Text = dataGridView1.Rows[secilen].Cells[26].Value.ToString();
            Anket_sonuçları.Text = dataGridView1.Rows[secilen].Cells[27].Value.ToString();
            Etiketler.Text = dataGridView1.Rows[secilen].Cells[28].Value.ToString();
            Tür.Text = dataGridView1.Rows[secilen].Cells[29].Value.ToString();
            Zaman_Kaydedildi.Text = dataGridView1.Rows[secilen].Cells[30].Value.ToString();
            Tip.Text = dataGridView1.Rows[secilen].Cells[31].Value.ToString();
            En_son_güncellendiği_zaman.Text = dataGridView1.Rows[secilen].Cells[32].Value.ToString();
            Aciliyet.Text = dataGridView1.Rows[secilen].Cells[33].Value.ToString();
            Cözüm_üreten.Text = dataGridView1.Rows[secilen].Cells[34].Value.ToString();
        }

        private void güncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                OleDbCommand komut = new OleDbCommand("update [Sayfa1$] set Kategori=@p2,Kapatıldığı_Zaman=@p3,Oluşturulduğu_Zaman=@p4,Departman=@p5,Bildirim_No=@p6,Süre_Sonu=@p7,İlk_Cevap_Verildiği_Zaman_Saat=@p8,İlk_Yanıt_Durumu=@p9,Initial_Response_Time=@p10,Grup=@p11,Harici_Sistem_Ticket_No=@p12,Etki=@p13,Oyuncu_Etkileşimi=@p14,Öğe=@p15,Temsilci_etkileşimleri=@p16,Öncelik=@p17,Talep_sahibi_eposta_adresi=@p18,Talep_Sahibi_Adı=@p19,Çözümleme_durumu=@p20,Çözüldüğü_Zaman_Saat=@p21,Çözüldüğü_Zaman=@p22,Temsilci=@p23,Kaynak=@p24,Durum=@p25,Alt_kategori=@p26,Konu=@p27,Anket_sonuçları=@p28,Etiketler=@p29,Tür=@p30,Zaman_Kaydedildi=@p31,Tip=@p32,En_son_güncellendiği_zaman=@p33,Aciliyet=@p34,Çözüm_üreten=@p35 where Onay_durumu=@p1", baglanti);

                komut.Parameters.AddWithValue("@p2", Kategori.Text);
                komut.Parameters.AddWithValue("@p3", Kapatıldığı_zaman.Text);
                komut.Parameters.AddWithValue("@p4", Oluşturulduğu_zaman.Text);
                komut.Parameters.AddWithValue("@p5", Departman.Text);
                komut.Parameters.AddWithValue("@p6", Bildirim_No.Text);
                komut.Parameters.AddWithValue("@p7", Süre_sonu.Text);
                komut.Parameters.AddWithValue("@p8", İlk_Cevap_Verildiği_Zaman_Saat.Text);
                komut.Parameters.AddWithValue("@p9", İlk_yanıt_durumu.Text);
                komut.Parameters.AddWithValue("@p10", Initial_Response_Time.Text);
                komut.Parameters.AddWithValue("@p11", Grup.Text);
                komut.Parameters.AddWithValue("@p12", Harici_sistem_ticket_no.Text);
                komut.Parameters.AddWithValue("@p13", Etki.Text);
                komut.Parameters.AddWithValue("@p14", Oyuncu_Etkileşimi.Text);
                komut.Parameters.AddWithValue("@p15", Öğe.Text);
                komut.Parameters.AddWithValue("@p16", Temsilci_etkileşimleri.Text);
                komut.Parameters.AddWithValue("@p17", Öncelik.Text);
                komut.Parameters.AddWithValue("@p18", Talep_sahibi_eposta_adresi.Text);
                komut.Parameters.AddWithValue("@p19", Talep_Sahibi_Adı.Text);
                komut.Parameters.AddWithValue("@p20", Çözümleme_durumu.Text);
                komut.Parameters.AddWithValue("@p21", Çözüldüğü_Zaman_Saat.Text);
                komut.Parameters.AddWithValue("@p22", Çözüldüğü_Zaman.Text);
                komut.Parameters.AddWithValue("@p23", Temsilci.Text);
                komut.Parameters.AddWithValue("@p24", Kaynak.Text);
                komut.Parameters.AddWithValue("@p25", Durum.Text);
                komut.Parameters.AddWithValue("@p26", Alt_kategori.Text);
                komut.Parameters.AddWithValue("@p27", Konu.Text);
                komut.Parameters.AddWithValue("@p28", Anket_sonuçları.Text);
                komut.Parameters.AddWithValue("@p29", Etiketler.Text);
                komut.Parameters.AddWithValue("@p30", Tür.Text);
                komut.Parameters.AddWithValue("@p31", Zaman_Kaydedildi.Text);
                komut.Parameters.AddWithValue("@p32", Tip.Text);
                komut.Parameters.AddWithValue("@p33", En_son_güncellendiği_zaman.Text);
                komut.Parameters.AddWithValue("@p34", Aciliyet.Text);
                komut.Parameters.AddWithValue("@p35", Cözüm_üreten.Text);
                komut.Parameters.AddWithValue("@p1", Onay_durumu.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Veriler Güncellendi.", "Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Veriler();

            }
            catch (Exception error)
            {
                MessageBox.Show("Hata meydana geldi" + error.Message);
            }

        }

        private void listele_Click(object sender, EventArgs e)
        {
            Veriler();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "Delete [Sayfa1$] where Onay_durumu=@Onay_durumu";
            OleDbCommand komut = new OleDbCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Onay_durumu", Onay_durumu.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Veriler Silindi", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Veriler();
        }
    }
}
