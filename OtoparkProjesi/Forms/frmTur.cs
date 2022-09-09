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
    public partial class frmTur : Form
    {
        public frmTur()
        {
            InitializeComponent();
        }
        OtoparkDbContext db = new OtoparkDbContext();
        private void frmTur_Load(object sender, EventArgs e)
        {
            Listele();
            var comboliste = db.Marka.ToList();
            comboMarka.DataSource = comboliste;
            comboMarka.DisplayMember = "MarkaAdi";
            comboMarka.ValueMember = "ID";

        }

        private void Listele()
        {
            listView1.Items.Clear();
            var liste = from x in db.Tur
                        join y in db.Marka on
                        x.MarkaID equals y.ID
                        select new
                        {
                            x.ID,
                            y.MarkaAdi,
                            x.tur
                        };

            foreach (var item in liste)

            {
                ListViewItem viewItem = new ListViewItem(item.ID.ToString());
                viewItem.SubItems.Add(item.MarkaAdi);
                viewItem.SubItems.Add(item.tur);
                listView1.Items.Add(viewItem);
            }
        }

        void Temizle()
        {
            txtID.Text = "";
            txtTur.Text = "";
            comboMarka.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int markaid = (int)comboMarka.SelectedValue;
            var ekle = new Tur();
            ekle.MarkaID = markaid;
            ekle.tur = txtTur.Text;
            db.Tur.Add(ekle);
            db.SaveChanges();
            Temizle();
            Listele();
            MessageBox.Show("Araç türü eklendi", "Ekleme ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ListViewItem SecilenID = listView1.SelectedItems[0];
            int secilenID = int.Parse(SecilenID.SubItems[0].Text);
            var sil = db.Tur.FirstOrDefault(x => x.ID == secilenID);
            db.Tur.Remove(sil);
            db.SaveChanges();
            MessageBox.Show("Araç türü silindi", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var guncelle = db.Tur.FirstOrDefault(x => x.ID== id);
            guncelle.MarkaID = (int)comboMarka.SelectedValue;
            guncelle.tur = txtTur.Text;
            db.SaveChanges();
            MessageBox.Show("Araç türü güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem secilen = listView1.SelectedItems[0];
            if (listView1.SelectedItems.Count > 0)

            {
                txtID.Text = secilen.SubItems[0].Text;
                comboMarka.Text = secilen.SubItems[1].Text;
                txtTur.Text = secilen.SubItems[2].Text;
            }
        }
    }
}
