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
    public partial class frmMarka : Form
    {
        public frmMarka()
        {
            InitializeComponent();
        }

        OtoparkDbContext db =new OtoparkDbContext();


        private void frmMarka_Load(object sender, EventArgs e)
        {
            MarkaListele();
        }

        private void MarkaListele()
        {

            listView1.Items.Clear();
            var markalistesi = db.Marka.ToList();
            for (int i = 0; i < markalistesi.Count; i++)
            {
                ListViewItem ekle = new ListViewItem(markalistesi[i].ID.ToString());
                ekle.SubItems.Add(markalistesi[i].MarkaAdi);
                listView1.Items.Add(ekle);
                


            }
        }


        void Temizle()
        {
            txtID.Text = "";
            txtMarkaAdi.Text = "";
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            var ekle = new Marka();
            ekle.MarkaAdi = txtMarkaAdi.Text;
            db.Marka.Add(ekle);
            db.SaveChanges();
            MessageBox.Show("Araç markası eklendi", "Ekleme ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MarkaListele();
            Temizle();

        }
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem secilen = listView1.SelectedItems[0];
            if(listView1.SelectedItems.Count > 0)
            {
                txtID.Text = secilen.SubItems[0].Text;
                txtMarkaAdi.Text = secilen.SubItems[1].Text;
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ListViewItem SecilenID = listView1.SelectedItems[0];
            int secilenId = int.Parse(SecilenID.SubItems[0].Text);
            var sil = db.Marka.FirstOrDefault(x => x.ID == secilenId);
            db.Marka.Remove(sil);
            db.SaveChanges();
            MessageBox.Show("Araç markası silindi", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MarkaListele();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var guncelle = db.Marka.FirstOrDefault(x => x.ID == id);
            guncelle.MarkaAdi = txtMarkaAdi.Text;
            db.SaveChanges();
            MessageBox.Show("Araç markası güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MarkaListele();
            Temizle();
        }
    }
}
