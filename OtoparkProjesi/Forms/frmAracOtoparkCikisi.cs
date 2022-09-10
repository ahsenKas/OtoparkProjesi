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
            var plakagetir = db.AracParkBilgileri.ToList();
            foreach (var item in plakagetir)
            {
                comboPlakaAra.Items.Add(item.Plaka);
            }

            Yenile();

            var markagetir = db.Marka.ToList();
            comboMarka.DataSource = markagetir;
            comboMarka.DisplayMember = "MarkaAdi";
            comboMarka.ValueMember = "ID";
            #endregion
        }

        private void Yenile()
        {
            var bosparkyerleri = db.AracParkYerleri.Where(x => x.Durumu == "BOŞ").ToList();
            comboParkYeri.DataSource = bosparkyerleri;
            comboParkYeri.DisplayMember = "ParkYerleri";
            comboParkYeri.ValueMember = "ID";
            var doluparkyerleri = db.AracParkYerleri.Where(x => x.Durumu == "DOLU").ToList();
            foreach (var item in doluparkyerleri)
            {
                comboParkYeriAra.Items.Add(item.ParkYerleri);
            }
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
                         select new { x.ID, x.MusteriID, x.AdiSoyadi, x.Telefon, x.Plaka, x.GirisTarihi,
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
                lblGirisTarihi.Text = item.GirisTarihi.ToString();                
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
            Yenile();
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
        }
    }
}
