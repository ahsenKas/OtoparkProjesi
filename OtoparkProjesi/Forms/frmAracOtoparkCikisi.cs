using OtoparkProjesi.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkProjesi.Forms
{
    public partial class frmAracOtoparkCikisi : Form
    {
        public frmAracOtoparkCikisi()
        {
            InitializeComponent();
        }
        OtoparkDbContext db = new OtoparkDbContext();
        private void frmAracOtoparkCikisi_Load(object sender, EventArgs e)
        {
            #region FormLoad
            comboSaatUcreti.SelectedIndex = 0;
           
            

            Yenile();
            var markagetir = db.Marka.ToList();
            comboMarka.DataSource = markagetir;
            comboMarka.DisplayMember = "MarkaAdi";
            comboMarka.ValueMember = "ID";
            #endregion
        }

        private void Yenile()
        {
            comboPlakaAra.Text = "";
            comboPlakaAra.Items.Clear();

            var plakagetir = db.AracParkBilgileri.ToList();
            foreach (var item in plakagetir)
            {
                comboPlakaAra.Items.Add(item.Plaka);
            }
            var bosparkyerleri = db.AracParkYerleri.Where(x => x.Durumu == "BOŞ").ToList();
            comboParkYeri.DataSource = bosparkyerleri;
            comboParkYeri.DisplayMember = "ParkYerleri";
            comboParkYeri.ValueMember = "ID";

            var doluparkyerleri = db.AracParkYerleri.Where(x => x.Durumu == "DOLU").ToList();
            comboParkYeriAra.DataSource = doluparkyerleri;
            comboParkYeriAra.DisplayMember = "ParkYerleri";
            comboParkYeriAra.ValueMember = "ID";
            comboParkYeriAra.Text = "";
            comboParkYeri.Text = "";


        }

        private void comboMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var turgetir = db.Tur.Where(x=>x.MarkaID==(int)comboMarka.SelectedValue).ToList();
                comboTur.DataSource = turgetir;
                comboTur.DisplayMember = "tur";
                comboTur.ValueMember = "ID";
            }
            catch (Exception)
            {

               
            }
        }
        private void comboMarka_ValueMemberChanged(object sender, EventArgs e)
        {
            var turgetir = db.Tur.Where(x => x.MarkaID == (int)comboMarka.SelectedValue).ToList();
            comboTur.DataSource = turgetir;
            comboTur.DisplayMember = "tur";
            comboTur.ValueMember = "ID";

        }

        void UcretHesapla()
        {
            try
            {
                lblCikisTarihi.Text = DateTime.Now.ToString();
                TimeSpan fark;
                fark = DateTime.Parse(lblCikisTarihi.Text) - DateTime.Parse(lblGirisTarihi.Text);
                decimal saatucreti = 0, sure = 0, tutar = 0;
                lblSure.Text = fark.TotalHours.ToString("0.00");
                saatucreti = decimal.Parse(comboSaatUcreti.Text);

                sure = decimal.Parse(lblSure.Text);

                tutar = sure * saatucreti;
                lblUcret.Text = tutar.ToString("0.00");

            }
            catch (Exception)
            {

            }
        }
        private void txtIDAra_TextChanged(object sender, EventArgs e)
        {
            if(txtIDAra.Text=="")
            {
                foreach (Control item in panelBilgiler.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }

            #region ID_Ara
            var IDAra = (from x in db.AracParkBilgileri
                         join y in db.Marka on
                         x.MarkaID equals y.ID
                         join z in db.Tur on x.TurID equals z.ID
                         join
                         w in db.AracParkYerleri on x.ParkyeriID equals w.ID
                         select new { x.ID, x.MusteriID, x.AdiSoyadi, x.Telefon, x.Plaka, x.Aciklama,x.GirisTarihi, 
                         y.MarkaAdi, z.tur, w.ParkYerleri
                         }).Where(ara => ara.ID.ToString() == txtIDAra.Text).ToList();

            foreach(var item in IDAra)
            {
                txtID.Text = item.ID.ToString();
                txtMusteriID.Text = item.MusteriID.ToString();
                txtAdiSoyadi.Text = item.AdiSoyadi;
                txtTelefon.Text = item.Telefon;
                comboMarka.Text = item.MarkaAdi;
                comboTur.Text = item.tur;
                txtPlaka.Text=item.Plaka;
                comboParkYeri.Text = item.ParkYerleri;
                txtAciklama.Text = item.Aciklama;
                lblGirisTarihi.Text = item.GirisTarihi.ToString();
                UcretHesapla();
            }
            #endregion

        }

        private void txtMusteriIDAra_TextChanged(object sender, EventArgs e)
        {
            if (txtMusteriIDAra.Text == "")
            {
                foreach (Control item in panelBilgiler.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }

            #region MusteriID_Ara
            var MusteriIDAra = (from x in db.AracParkBilgileri
                         join y in db.Marka on
                         x.MarkaID equals y.ID
                         join z in db.Tur on x.TurID equals z.ID
                         join
                         w in db.AracParkYerleri on x.ParkyeriID equals w.ID
                         select new
                         {
                             x.ID,
                             x.MusteriID,
                             x.AdiSoyadi,
                             x.Telefon,
                             x.Plaka,
                             x.GirisTarihi,
                             y.MarkaAdi,
                             z.tur,
                             w.ParkYerleri
                         }).Where(ara => ara.MusteriID.ToString() == txtMusteriIDAra.Text).ToList();

            foreach (var item in MusteriIDAra)
            {
                txtID.Text = item.ID.ToString();
                txtMusteriID.Text = item.MusteriID.ToString();
                txtAdiSoyadi.Text = item.AdiSoyadi;
                txtTelefon.Text = item.Telefon;
                comboMarka.Text = item.MarkaAdi;
                comboTur.Text = item.tur;
                txtPlaka.Text = item.Plaka;
                comboParkYeri.Text = item.ParkYerleri;
                lblGirisTarihi.Text = item.GirisTarihi.ToString();
                UcretHesapla();
            }
            #endregion

        }
        private void txtAdSoyadAra_TextChanged(object sender, EventArgs e)
        {
            if (txtAdSoyadAra.Text == "")
            {
                foreach (Control item in panelBilgiler.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }

            #region AraSoyad_Ara
            var AdSoyadAra = (from x in db.AracParkBilgileri
                                join y in db.Marka on
                                x.MarkaID equals y.ID
                                join z in db.Tur on x.TurID equals z.ID
                                join
                                w in db.AracParkYerleri on x.ParkyeriID equals w.ID
                                select new
                                {
                                    x.ID,
                                    x.MusteriID,
                                    x.AdiSoyadi,
                                    x.Telefon,
                                    x.Plaka,
                                    x.GirisTarihi,
                                    y.MarkaAdi,
                                    z.tur,
                                    w.ParkYerleri
                                }).Where(ara => ara.AdiSoyadi.ToString() == txtAdSoyadAra.Text).ToList();

            foreach (var item in AdSoyadAra)
            {
                txtID.Text = item.ID.ToString();
                txtMusteriID.Text = item.MusteriID.ToString();
                txtAdiSoyadi.Text = item.AdiSoyadi;
                txtTelefon.Text = item.Telefon;
                comboMarka.Text = item.MarkaAdi;
                comboTur.Text = item.tur;
                txtPlaka.Text = item.Plaka;
                comboParkYeri.Text = item.ParkYerleri;
                lblGirisTarihi.Text = item.GirisTarihi.ToString();
                UcretHesapla();
            }
            #endregion
        }

        private void comboPlakaAra_SelectedIndexChanged(object sender, EventArgs e)
        {        

            #region Plaka_Ara
            var PlakaAra = (from x in db.AracParkBilgileri
                                join y in db.Marka on
                                x.MarkaID equals y.ID
                                join z in db.Tur on x.TurID equals z.ID
                                join
                                w in db.AracParkYerleri on x.ParkyeriID equals w.ID
                                select new
                                {
                                    x.ID,
                                    x.MusteriID,
                                    x.AdiSoyadi,
                                    x.Telefon,
                                    x.Plaka,
                                    x.GirisTarihi,
                                    y.MarkaAdi,
                                    z.tur,
                                    w.ParkYerleri
                                }).Where(ara => ara.Plaka.ToString() ==comboPlakaAra.Text).ToList();

            foreach (var item in PlakaAra)
            {
                txtID.Text = item.ID.ToString();
                txtMusteriID.Text = item.MusteriID.ToString();
                txtAdiSoyadi.Text = item.AdiSoyadi;
                txtTelefon.Text = item.Telefon;
                comboMarka.Text = item.MarkaAdi;
                comboTur.Text = item.tur;
                txtPlaka.Text = item.Plaka;
                comboParkYeri.Text = item.ParkYerleri;
                lblGirisTarihi.Text = item.GirisTarihi.ToString();
                UcretHesapla();
            }
            #endregion
        }
        private void comboParkYeriAra_SelectedIndexChanged(object sender, EventArgs e)
        {            

            #region ParkYeri_Ara
            var ParkYeriAra = (from x in db.AracParkBilgileri
                                join y in db.Marka on
                                x.MarkaID equals y.ID
                                join z in db.Tur on x.TurID equals z.ID
                                join
                                w in db.AracParkYerleri on x.ParkyeriID equals w.ID
                                select new
                                {
                                    x.ID,
                                    x.MusteriID,
                                    x.AdiSoyadi,
                                    x.Telefon,
                                    x.Plaka,
                                    x.GirisTarihi,
                                    y.MarkaAdi,
                                    z.tur,
                                    w.ParkYerleri
                                }).Where(ara => ara.ParkYerleri.ToString() == comboParkYeriAra.Text).ToList();

            foreach (var item in ParkYeriAra)
            {
                txtID.Text = item.ID.ToString();
                txtMusteriID.Text = item.MusteriID.ToString();
                txtAdiSoyadi.Text = item.AdiSoyadi;
                txtTelefon.Text = item.Telefon;
                comboMarka.Text = item.MarkaAdi;
                comboTur.Text = item.tur;
                txtPlaka.Text = item.Plaka;
                comboParkYeri.Text = item.ParkYerleri;
                lblGirisTarihi.Text = item.GirisTarihi.ToString();
                UcretHesapla();
            }
            #endregion
        }

        private void comboPlakaAra_TextChanged(object sender, EventArgs e)
        {
            if(comboPlakaAra.Text=="")
            {
                foreach(Control item in panelBilgiler.Controls)
                {
                    if(item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void comboParkYeriAra_TextChanged(object sender, EventArgs e)
        {
            if (comboParkYeriAra.Text == "")
            {
                foreach (Control item in panelBilgiler.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }

        }

        private void btnParkYeriGuncelle_Click(object sender, EventArgs e)
        {
            var DoluParkYeriDegistir = db.AracParkYerleri.FirstOrDefault(x => x.ParkYerleri == comboParkYeriAra.Text);
            DoluParkYeriDegistir.Durumu = "BOŞ";
            db.SaveChanges();
            var BosParkYeriDegistir = db.AracParkYerleri.FirstOrDefault(x => x.ParkYerleri == comboParkYeri.Text);
            BosParkYeriDegistir.Durumu = "DOLU";
            db.SaveChanges();
            var aracparkyeridegistir = db.AracParkBilgileri.FirstOrDefault(x => x.Plaka == txtPlaka.Text);
            aracparkyeridegistir.ParkyeriID = (int)comboParkYeri.SelectedValue;
            db.SaveChanges();
            MessageBox.Show("Araç park yeri güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            comboParkYeriAra.Items.Clear();
            Yenile();
            btnTemizle.PerformClick();
            lblSure.Text = "0.00";
            lblUcret.Text = "0.00";
            lblGirisTarihi.Text = DateTime.Now.ToString();
            lblCikisTarihi.Text = DateTime.Now.ToString();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach(Control item in panelArama.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }

                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in panelBilgiler.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }

                if (item is ComboBox)
                {
                    if(item!=comboSaatUcreti)
                    {
                        item.Text = "";
                    }
                  
                }
            }
            lblSure.Text = "0.00";
            lblUcret.Text = "0.00";
            lblGirisTarihi.Text = DateTime.Now.ToString();
            lblCikisTarihi.Text = DateTime.Now.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            #region sil
            KayitSil();
            #endregion
            MessageBox.Show("Araç park yeri kaydı silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            comboParkYeriAra.Items.Clear();
            Yenile();
            btnTemizle.PerformClick();
            lblSure.Text = "0.00";
            lblUcret.Text = "0.00";
            lblGirisTarihi.Text = DateTime.Now.ToString();
            lblCikisTarihi.Text = DateTime.Now.ToString();
        }

        private void KayitSil()
        {
            var sil = db.AracParkBilgileri.FirstOrDefault(x => x.Plaka == txtPlaka.Text);
            db.AracParkBilgileri.Remove(sil);
            db.SaveChanges();

            var aracparkyeribosalt = db.AracParkYerleri.FirstOrDefault(x => x.ParkYerleri == comboParkYeri.Text);
            aracparkyeribosalt.Durumu = "BOŞ";
            db.SaveChanges();
        }

        private void btnAracCikisi_Click(object sender, EventArgs e)
        {
            #region araccikisi
            if (comboParkYeriAra.Text!="")
            {
                var ekle = new Ucret();
                ekle.UcretId = int.Parse(txtID.Text);
                ekle.MusteriId = int.Parse(txtMusteriID.Text);
                ekle.Adi_Soyadi = txtAdiSoyadi.Text;
                ekle.MarkaID = (int)comboMarka.SelectedValue;
                ekle.TurID = (int)comboTur.SelectedValue;
                ekle.Plaka = txtPlaka.Text;

                ekle.ParkyeriID = (int)comboParkYeriAra.SelectedValue;


                ekle.saatUcreti = decimal.Parse(comboSaatUcreti.Text);
                ekle.Sure = decimal.Parse(lblSure.Text);
                ekle.Tutar = decimal.Parse(lblUcret.Text);
                ekle.Aciklama = txtAciklama.Text;
                ekle.GirisTarihi = DateTime.Parse(lblGirisTarihi.Text);
                ekle.CıkısTarihi = DateTime.Parse(lblCikisTarihi.Text);
                db.Ucret.Add(ekle);
                db.SaveChanges();
                MessageBox.Show("Araç otopark çıkışı yapıldı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KayitSil();
                Yenile();
                btnTemizle.PerformClick();
                
                lblSure.Text = "0.00";
                lblUcret.Text = "0.00";
                lblGirisTarihi.Text = DateTime.Now.ToString();
                lblCikisTarihi.Text= DateTime.Now.ToString();
            }

            else
            {
                MessageBox.Show("Dolu Park Yerinin Seçilmesi Gerekir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            
            #endregion

        }

        private void comboSaatUcreti_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcretHesapla();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var guncelle = db.AracParkBilgileri.FirstOrDefault(x => x.ID.ToString() == txtID.Text);
            guncelle.MarkaID = (int)comboMarka.SelectedValue;
            guncelle.TurID = (int)comboTur.SelectedValue;
            guncelle.Plaka = txtPlaka.Text;
            guncelle.Aciklama = txtAciklama.Text;
            db.SaveChanges();

            MessageBox.Show("Araç bilgiler güncellendi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Yenile();
            btnTemizle.PerformClick();
            lblSure.Text = "0.00";
            lblUcret.Text = "0.00";
            lblGirisTarihi.Text = DateTime.Now.ToString();
            lblCikisTarihi.Text = DateTime.Now.ToString();

        }
    }
}
