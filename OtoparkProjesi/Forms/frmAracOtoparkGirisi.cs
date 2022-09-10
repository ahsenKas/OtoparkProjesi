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
    public partial class frmAracOtoparkGirisi : Form
    {
        public frmAracOtoparkGirisi()
        {
            InitializeComponent();
        }

        OtoparkDbContext db = new OtoparkDbContext();
        private void frmAracOtoparkGirisi_Load(object sender, EventArgs e)
        {

            var markagetir = db.Marka.ToList();
            comboMarka.DataSource = markagetir;
            comboMarka.DisplayMember = "MarkaAdi";
            comboMarka.ValueMember = "ID";

            ParkYeriYenile();

            var turgetir = db.Tur.ToList();
            comboTur.DataSource = turgetir;
            comboTur.DisplayMember = "Tur";
            comboTur.ValueMember = "ID";
        }

        private void ParkYeriYenile()
        {
            var parkyerigetir = db.AracParkYerleri.Where(x => x.Durumu == "BOŞ").ToList();
            comboParkYeri.DataSource = parkyerigetir;
            comboParkYeri.DisplayMember = "ParkYerleri";
            comboParkYeri.ValueMember = "ID";
        }

        private void txtMusteriID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var MusteriGetir = db.Musteri.Where(x => x.ID.ToString() == txtMusteriID.Text).ToList();
                foreach (var item in MusteriGetir)
                {
                    txtAdiSoyadi.Text = item.AdiSoyadi;
                    txtTelefon.Text = item.Telefon;
                }
                if (txtMusteriID.Text == "")
                {
                    txtAdiSoyadi.Text = "";
                    txtTelefon.Text = "";
                }
            }
            catch (Exception)
            {


            }
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var ekle = new AracParkBilgileri();
            ekle.MusteriID = int.Parse(txtMusteriID.Text);
            ekle.AdiSoyadi = txtAdiSoyadi.Text;
            ekle.Telefon = txtTelefon.Text;
            ekle.MarkaID = (int)comboMarka.SelectedValue;
            ekle.TurID = (int)comboTur.SelectedValue;
            ekle.Plaka = txtPlaka.Text;
            ekle.ParkyeriID= (int)comboParkYeri.SelectedValue;
            ekle.Aciklama = txtAciklama.Text;
            ekle.GirisTarihi = DateTime.Now;
            db.AracParkBilgileri.Add(ekle);
            db.SaveChanges();


            var parkyeridoldur = db.AracParkYerleri.FirstOrDefault(x => x.ID == (int)comboParkYeri.SelectedValue);
            parkyeridoldur.Durumu = "DOLU";
            db.SaveChanges();

            MessageBox.Show("Kayıt işlemi başarılı", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnTemizle.PerformClick();
            ParkYeriYenile();
        }
    }
}
