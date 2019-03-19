using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsletimSistemi_GorevYoneticisi_
{
    public partial class MANTIKSALbilgi : Form
    {
        public MANTIKSALbilgi()
        {
            InitializeComponent();
        }
      

        private void CPUbilgi_Load(object sender, EventArgs e)
        {
            tmrDeger.Enabled = true;
        }

        private void tmrDeger_Tick_1(object sender, EventArgs e)
        {
            float cYuzde = MantıksalBellek.NextValue();
            lblCPU.Text = "% " + cYuzde.ToString("N2");
            pbCPU.Value = (int)cYuzde;

            float czaman = zaman.NextValue();
            label3.Text = czaman.ToString("N2") + " sn";
            vProgressBar2.Value = (int)czaman;
        }
    }
}
