using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsletimSistemi_GorevYoneticisi_
{
    public partial class SistemBilgileri : Form
    {
        public SistemBilgileri()
        {
            InitializeComponent();


            
        }

        private void vButton1_Click(object sender, EventArgs e)
        {
            label5.Text = Getir(cbdonanim.Text, cbozellik.Text);
        }
        private static string Getir(string TableName, string MethodName)
        {
            ManagementObjectSearcher MOS = new ManagementObjectSearcher("Select * from Win32_" + TableName);
            
            foreach (ManagementObject MO in MOS.Get())
            
            {
                try
                {
                    return MO[MethodName].ToString();
                   
                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show(e.Message);
                }
            }
            return "";
        }
    }
}
