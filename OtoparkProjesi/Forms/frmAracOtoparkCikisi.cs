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
            comboSaatUcreti.SelectedIndex = 0;
            var plakagetir = db.AracParkBilgileri.ToList();
            foreach (var item in plakagetir)
            {
                comboPlakaAra.Items.Add(item.Plaka);
            }

            var bosparkyerleri = db.AracParkYerleri.Where(x => x.Durumu == "BOŞ").ToList();
            foreach (var item in bosparkyerleri)
            {
                comboParkYeri.Items.Add(item.ParkYerleri);
            }

            var doluparkyerleri = db.AracParkYerleri.Where(x => x.Durumu == "DOLU").ToList();
            foreach (var item in doluparkyerleri)
            {
                comboParkYeriAra.Items.Add(item.ParkYerleri);
            }

            var markagetir = db.Marka.ToList();
            comboMarka.DataSource = markagetir;
            comboMarka.DisplayMember = "MarkaAdi";
            comboMarka.ValueMember = "ID";
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
    }
}
