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
    }
}
