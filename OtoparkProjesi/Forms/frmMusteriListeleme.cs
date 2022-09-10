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
    public partial class frmMusteriListeleme : Form
    {
        public frmMusteriListeleme()
        {
            InitializeComponent();
        }

        OtoparkDbContext db = new OtoparkDbContext();
        private void frmMusteriListeleme_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Musteri.ToList();
        }

        void Temizle()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            dateTimeTarih.Value = DateTime.Now;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            var ara = from x in db.Musteri
                      where x.ID.ToString() == txtID.Text
                      select x;
            foreach (var item in ara)
            {
                txtAdiSoyadi.Text = item.AdiSoyadi;
                txtTelefon.Text = item.Telefon;
                dateTimeTarih.Value = item.Tarih;

            }

            if(txtID.Text=="")
            {
                Temizle();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var ekle = new Musteri();
            ekle.AdiSoyadi = txtAdiSoyadi.Text;
            ekle.Telefon = txtTelefon.Text;
            ekle.Tarih = dateTimeTarih.Value;
            db.Musteri.Add(ekle);
            db.SaveChanges();
            MessageBox.Show("Ekleme işlemi başarılı", "Ekleme ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
            dataGridView1.DataSource = db.Musteri.ToList();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var sil = db.Musteri.FirstOrDefault(x => x.ID == id);
            db.Musteri.Remove(sil);
            db.SaveChanges();
            MessageBox.Show("Silme işlemi başarılı", "Silme ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
            dataGridView1.DataSource = db.Musteri.ToList();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var guncelle = db.Musteri.FirstOrDefault(x => x.ID == id);
            guncelle.AdiSoyadi = txtAdiSoyadi.Text;
            guncelle.Telefon = txtTelefon.Text;
            guncelle.Tarih = dateTimeTarih.Value;
            db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi başarılı", "Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
            dataGridView1.DataSource = db.Musteri.ToList();
        }
    }
}
