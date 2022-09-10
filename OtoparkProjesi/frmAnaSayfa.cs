using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkProjesi
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void markaTool_Click(object sender, EventArgs e)
        {
            Forms.frmMarka marka = new Forms.frmMarka();
            marka.Show();
        }

        private void turTool_Click(object sender, EventArgs e)
        {

            Forms.frmTur tur = new Forms.frmTur();
            tur.Show();
        }

        private void müşteriListeleTool_Click(object sender, EventArgs e)
        {
            Forms.frmMusteriListeleme frm = new Forms.frmMusteriListeleme();
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saatToolStripMenuItem.Text = DateTime.Now.ToString();
        }

        private void OtoparkYerleriTool_Click(object sender, EventArgs e)
        {
            Forms.frmOtoparkYerleri frm = new Forms.frmOtoparkYerleri();
            frm.Show();
        }

        private void araçOtoparkGirişiTool_Click(object sender, EventArgs e)
        {
            Forms.frmAracOtoparkGirisi frm = new Forms.frmAracOtoparkGirisi();
            frm.Show();

        }

        private void araçOtoparkÇıkışıTool_Click(object sender, EventArgs e)
        {
            Forms.frmAracOtoparkCikisi frm = new Forms.frmAracOtoparkCikisi();
            frm.Show();

        }
    }
}
