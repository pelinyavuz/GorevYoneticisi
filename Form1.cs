using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace IsletimSistemi_GorevYoneticisi_
{

    public partial class Form1 : Form
    {
        int[] xValues = new int[100];
        private TotalCpuUsageMonitor totalCpuUsageMonitor { get; set; }
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 100; i++)
            {
                xValues[i] = i;
            }

        }




        void StartMonitor()
        {


            totalCpuUsageMonitor = new TotalCpuUsageMonitor(1000, 100);
            totalCpuUsageMonitor.CpuUsageValueArrayChanged +=
                new EventHandler<CpuUsageValueArrayChangedEventArg>(
                    totalCpuUsageMonitor_CpuUsageValueArrayChanged);
            totalCpuUsageMonitor.ErrorOccurred += new EventHandler<ErrorEventArgs>(
                totalCpuUsageMonitor_ErrorOccurred);

            vButton1.Enabled = true;
        }
        void totalCpuUsageMonitor_CpuUsageValueArrayChanged(object sender,
            CpuUsageValueArrayChangedEventArg e)
        {
            this.Invoke(new EventHandler<CpuUsageValueArrayChangedEventArg>(
                totalCpuUsageMonitor_CpuUsageValueArrayChangedHandler), sender, e);
        }
        void totalCpuUsageMonitor_CpuUsageValueArrayChangedHandler(object sender,
            CpuUsageValueArrayChangedEventArg e)
        {
            var totalCpuUsageSeries = chartTotalCpuUsage.Series["TotalCpuUsageSeries"];
            var values = e.Values;


            totalCpuUsageSeries.Points.DataBindY(e.Values);

        }

        void totalCpuUsageMonitor_ErrorOccurred(object sender, ErrorEventArgs e)
        {
            this.Invoke(new EventHandler<ErrorEventArgs>(
                totalCpuUsageMonitor_ErrorOccurredHandler), sender, e);
        }

        void totalCpuUsageMonitor_ErrorOccurredHandler(object sender, ErrorEventArgs e)
        {
            if (totalCpuUsageMonitor != null)
            {

                totalCpuUsageMonitor = null;

                var totalCpuUsageSeries = chartTotalCpuUsage.Series["TotalCpuUsageSeries"];
                totalCpuUsageSeries.Points.Clear();
            }
            MessageBox.Show(e.Error.Message);
        }
        //
        //chard1
        //

        //
        //Tab1
        //
        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
        }

        private int ProcessControl()
        {
            int plus = 0;
            foreach (Process p in Process.GetProcesses("."))
            {
                plus++;

            }
            return plus;
        }
        int islem = 0;
        private void ProgramlariListele()
        {
            listView1.Items.Clear();


            int add = 0;

            foreach (Process p in Process.GetProcesses("."))
            {
                listView1.Items.Add(p.ProcessName);
                listView1.Items[add].SubItems.Add(p.Id.ToString());
                listView1.Items[add].SubItems.Add(Convert.ToInt32(Math.Round(Convert.ToDecimal(p.PrivateMemorySize64 / 1024))) + "KB");
                listView1.Items[add].SubItems.Add(p.Responding.ToString());
                add++;

            }
            lblTotal.Text = listView1.Items.Count.ToString();
            islem = add;
        }
      
        private void ProgramListele()
        {
            listView2.Items.Clear();
            foreach (Process p in Process.GetProcesses("."))
            {
                
                if (p.MainWindowTitle.Length > 0)
                {

                    ListViewItem item = new ListViewItem();
                    item.Text = p.ProcessName.ToString();
                    item.SubItems.Add(p.MainWindowTitle.ToString());
                    listView2.Items.Add(item);
                   
                }
                lblTotal2.Text = listView2.Items.Count.ToString();
            }

        }
   
        private void ProgramKapat(int pid)
        {
            Process.GetProcessById(pid).Kill();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            ProgramlariListele();
            ProgramListele();
           


        }
        private void btnTaskEnd_Click(object sender, EventArgs e)
        {
            
                ProgramKapat(Convert.ToInt32(listView1.SelectedItems[0].SubItems[1].Text));
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProgramlariListele();
        }

        //
        //Tab1
        //

        private void vButton1_Click(object sender, EventArgs e)
        {
           
            StartMonitor();
            chartTotalCpuUsage.Visible = true;


        }



        private void cıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            ProgramlariListele();
            ProgramListele();
            timer1.Enabled = false;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int tut = ProcessControl();
            if (tut != islem)
            {
                timer1.Enabled = true;
            }
           

        }


        private void vButton2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            chartTotalCpuUsage.Visible = false;
        }

        private void vButton3_Click(object sender, EventArgs e)
        {
            
                YeniGorev form3 = new YeniGorev();
                form3.Show();
        }

        private void vButton6_Click(object sender, EventArgs e)
        {
            ProgramListele();
        }

        private void vButton4_Click(object sender, EventArgs e)
        {
            YeniGorev form3 = new YeniGorev();
            form3.Show();
        }

        private void vButton6_Click_1(object sender, EventArgs e)
        {
            MANTIKSALbilgi bilgi = new MANTIKSALbilgi();
            bilgi.Show();
        }

        private void simgeDurumunaKüçüldüğündeGizleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon1.ShowBalloonTip(2000, "Görev Yöneticisi", "Çalışıyor", ToolTipIcon.Info);
            

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void simgeDurumunaKüçüldüğündeGizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void kullanımDurumuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
        }

       

        private void şimdiYenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgramlariListele();
            ProgramListele();
        }

        private void sistemBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SistemBilgileri bilgi = new SistemBilgileri();
            bilgi.Show();

        }

        private void lisansBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            System.Windows.Forms.MessageBox.Show("Bu Proje İşletim Sistemi Kapsamında Hazırlanmıştır© \n Proje Üyeleri :\n Tuğçe TURAN \n Gülbeyaz ARSLAN ");
        }

     








    }
}

