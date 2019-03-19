using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace IsletimSistemi_GorevYoneticisi_
{
    public partial class YeniGorev : Form
    {
        public YeniGorev()
        {
            InitializeComponent();
        }

        private void vButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(vTextBox1.Text);
            }
            catch 
            {
                System.Windows.Forms.MessageBox.Show("Böyle Bir Program Bulunamadı");
            }
        }
    }
}
