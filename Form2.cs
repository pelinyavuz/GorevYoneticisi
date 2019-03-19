using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace IsletimSistemi_GorevYoneticisi_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void tmrDeger_Tick(object sender, EventArgs e)
        {
            float ramYuzde = ram.NextValue();
            lblRAM.Text = "% " + ramYuzde.ToString("N2");
            pbRAM.Value = (int)ramYuzde;

            float ramOku = ramOkuma.NextValue();
            lblOku.Text = "% " + ramOku.ToString("N2");
            pbOku.Value = (int)ramOku;

            float ramYaz = ramYazma.NextValue();
            lblYaz.Text = "% " + ramYaz.ToString("N2");
            pbYaz.Value = (int)ramYaz;  
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tmrDeger.Enabled = true;
        }

        private void lblRAM_Click(object sender, EventArgs e)
        {

        }
    }
}
