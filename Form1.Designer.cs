namespace IsletimSistemi_GorevYoneticisi_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secenekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simgeDurumunaKüçüldüğündeGizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simgeDurumunaKüçüldüğündeGizleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanımDurumuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şimdiYenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lisansBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemPanel = new System.Windows.Forms.Panel();
            this.vTabControl1 = new VIBlend.WinForms.Controls.vTabControl();
            this.vTabPage1 = new VIBlend.WinForms.Controls.vTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.vButton3 = new VIBlend.WinForms.Controls.vButton();
            this.button1 = new VIBlend.WinForms.Controls.vButton();
            this.lblTotal = new VIBlend.WinForms.Controls.vLabel();
            this.Label1 = new VIBlend.WinForms.Controls.vLabel();
            this.btnTaskEnd = new VIBlend.WinForms.Controls.vButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.PA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CPU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CAL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vTabPage2 = new VIBlend.WinForms.Controls.vTabPage();
            this.vGroupBox2 = new VIBlend.WinForms.Controls.vGroupBox();
            this.chartTotalCpuUsage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.vGroupBox1 = new VIBlend.WinForms.Controls.vGroupBox();
            this.vButton6 = new VIBlend.WinForms.Controls.vButton();
            this.vButton2 = new VIBlend.WinForms.Controls.vButton();
            this.vButton1 = new VIBlend.WinForms.Controls.vButton();
            this.vTabPage3 = new VIBlend.WinForms.Controls.vTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal2 = new VIBlend.WinForms.Controls.vLabel();
            this.vButton4 = new VIBlend.WinForms.Controls.vButton();
            this.vLabel3 = new VIBlend.WinForms.Controls.vLabel();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SistemBilgileri = new System.Diagnostics.PerformanceCounter();
            this.menuStrip1.SuspendLayout();
            this.vTabControl1.SuspendLayout();
            this.vTabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.vTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalCpuUsage)).BeginInit();
            this.vGroupBox1.SuspendLayout();
            this.vTabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SistemBilgileri)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.secenekToolStripMenuItem,
            this.görüntüleToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Menu";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // cıkışToolStripMenuItem
            // 
            this.cıkışToolStripMenuItem.Name = "cıkışToolStripMenuItem";
            this.cıkışToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cıkışToolStripMenuItem.Text = "Cıkıs";
            this.cıkışToolStripMenuItem.Click += new System.EventHandler(this.cıkışToolStripMenuItem_Click);
            // 
            // secenekToolStripMenuItem
            // 
            this.secenekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simgeDurumunaKüçüldüğündeGizleToolStripMenuItem,
            this.simgeDurumunaKüçüldüğündeGizleToolStripMenuItem1,
            this.kullanımDurumuToolStripMenuItem});
            this.secenekToolStripMenuItem.Name = "secenekToolStripMenuItem";
            this.secenekToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.secenekToolStripMenuItem.Text = "Secenek";
            // 
            // simgeDurumunaKüçüldüğündeGizleToolStripMenuItem
            // 
            this.simgeDurumunaKüçüldüğündeGizleToolStripMenuItem.Name = "simgeDurumunaKüçüldüğündeGizleToolStripMenuItem";
            this.simgeDurumunaKüçüldüğündeGizleToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.simgeDurumunaKüçüldüğündeGizleToolStripMenuItem.Text = "Her Zaman Üstte";
            this.simgeDurumunaKüçüldüğündeGizleToolStripMenuItem.Click += new System.EventHandler(this.simgeDurumunaKüçüldüğündeGizleToolStripMenuItem_Click);
            // 
            // simgeDurumunaKüçüldüğündeGizleToolStripMenuItem1
            // 
            this.simgeDurumunaKüçüldüğündeGizleToolStripMenuItem1.Name = "simgeDurumunaKüçüldüğündeGizleToolStripMenuItem1";
            this.simgeDurumunaKüçüldüğündeGizleToolStripMenuItem1.Size = new System.Drawing.Size(276, 22);
            this.simgeDurumunaKüçüldüğündeGizleToolStripMenuItem1.Text = "Simge Durumuna Küçüldüğünde Gizle";
            this.simgeDurumunaKüçüldüğündeGizleToolStripMenuItem1.Click += new System.EventHandler(this.simgeDurumunaKüçüldüğündeGizleToolStripMenuItem1_Click);
            // 
            // kullanımDurumuToolStripMenuItem
            // 
            this.kullanımDurumuToolStripMenuItem.Name = "kullanımDurumuToolStripMenuItem";
            this.kullanımDurumuToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.kullanımDurumuToolStripMenuItem.Text = "Kullanım Durumu";
            this.kullanımDurumuToolStripMenuItem.Click += new System.EventHandler(this.kullanımDurumuToolStripMenuItem_Click);
            // 
            // görüntüleToolStripMenuItem
            // 
            this.görüntüleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şimdiYenileToolStripMenuItem});
            this.görüntüleToolStripMenuItem.Name = "görüntüleToolStripMenuItem";
            this.görüntüleToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.görüntüleToolStripMenuItem.Text = "Görüntüle";
            // 
            // şimdiYenileToolStripMenuItem
            // 
            this.şimdiYenileToolStripMenuItem.Name = "şimdiYenileToolStripMenuItem";
            this.şimdiYenileToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.şimdiYenileToolStripMenuItem.Text = "Şimdi Yenile";
            this.şimdiYenileToolStripMenuItem.Click += new System.EventHandler(this.şimdiYenileToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemBilgileriToolStripMenuItem,
            this.lisansBilgileriToolStripMenuItem});
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // sistemBilgileriToolStripMenuItem
            // 
            this.sistemBilgileriToolStripMenuItem.Name = "sistemBilgileriToolStripMenuItem";
            this.sistemBilgileriToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sistemBilgileriToolStripMenuItem.Text = "Sistem Bilgileri";
            this.sistemBilgileriToolStripMenuItem.Click += new System.EventHandler(this.sistemBilgileriToolStripMenuItem_Click);
            // 
            // lisansBilgileriToolStripMenuItem
            // 
            this.lisansBilgileriToolStripMenuItem.Name = "lisansBilgileriToolStripMenuItem";
            this.lisansBilgileriToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lisansBilgileriToolStripMenuItem.Text = "Lisans Bilgileri";
            //this.lisansBilgileriToolStripMenuItem.Click += new System.EventHandler(this.lisansBilgileriToolStripMenuItem_Click);
            // 
            // ItemPanel
            // 
            this.ItemPanel.AutoScroll = true;
            this.ItemPanel.Location = new System.Drawing.Point(1, 30);
            this.ItemPanel.Name = "ItemPanel";
            this.ItemPanel.Size = new System.Drawing.Size(145, 0);
            this.ItemPanel.TabIndex = 1;
            // 
            // vTabControl1
            // 
            this.vTabControl1.AllowAnimations = true;
            this.vTabControl1.Controls.Add(this.vTabPage1);
            this.vTabControl1.Controls.Add(this.vTabPage2);
            this.vTabControl1.Controls.Add(this.vTabPage3);
            this.vTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vTabControl1.Location = new System.Drawing.Point(0, 24);
            this.vTabControl1.Name = "vTabControl1";
            this.vTabControl1.Padding = new System.Windows.Forms.Padding(0, 27, 0, 0);
            this.vTabControl1.Size = new System.Drawing.Size(742, 433);
            this.vTabControl1.TabAlignment = VIBlend.WinForms.Controls.vTabPageAlignment.Top;
            this.vTabControl1.TabIndex = 1;
            this.vTabControl1.TabPages.Add(this.vTabPage1);
            this.vTabControl1.TabPages.Add(this.vTabPage2);
            this.vTabControl1.TabPages.Add(this.vTabPage3);
            this.vTabControl1.TabsAreaBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.vTabControl1.TabsInitialOffset = 0;
            this.vTabControl1.TabsShape = VIBlend.WinForms.Controls.TabsShape.Chrome;
            this.vTabControl1.TabsSpacing = 0;
            this.vTabControl1.TitleHeight = 27;
            this.vTabControl1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.STEEL;
            // 
            // vTabPage1
            // 
            this.vTabPage1.Controls.Add(this.panel2);
            this.vTabPage1.Controls.Add(this.listView1);
            this.vTabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vTabPage1.Location = new System.Drawing.Point(0, 27);
            this.vTabPage1.Name = "vTabPage1";
            this.vTabPage1.Padding = new System.Windows.Forms.Padding(0);
            this.vTabPage1.Size = new System.Drawing.Size(742, 406);
            this.vTabPage1.TabIndex = 3;
            this.vTabPage1.Text = "İslemler";
            this.vTabPage1.TooltipText = "TabPage";
            this.vTabPage1.UseTabPageSpecificThemeSetters = false;
            this.vTabPage1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.STEEL;
            this.vTabPage1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.vButton3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.Label1);
            this.panel2.Controls.Add(this.btnTaskEnd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(4, 340);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 62);
            this.panel2.TabIndex = 1;
            // 
            // vButton3
            // 
            this.vButton3.AllowAnimations = true;
            this.vButton3.BackColor = System.Drawing.Color.Transparent;
            this.vButton3.Location = new System.Drawing.Point(226, 28);
            this.vButton3.Name = "vButton3";
            this.vButton3.RoundedCornersMask = ((byte)(15));
            this.vButton3.Size = new System.Drawing.Size(165, 23);
            this.vButton3.TabIndex = 6;
            this.vButton3.Text = "Yeni Görev Başlat";
            this.vButton3.UseVisualStyleBackColor = false;
            this.vButton3.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.STEEL;
            this.vButton3.Click += new System.EventHandler(this.vButton3_Click);
            // 
            // button1
            // 
            this.button1.AllowAnimations = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(4, 28);
            this.button1.Name = "button1";
            this.button1.RoundedCornersMask = ((byte)(15));
            this.button1.Size = new System.Drawing.Size(165, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Yenile";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.STEEL;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.DisplayStyle = VIBlend.WinForms.Controls.LabelItemStyle.TextOnly;
            this.lblTotal.Ellipsis = false;
            this.lblTotal.ImageAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTotal.Location = new System.Drawing.Point(226, 4);
            this.lblTotal.Multiline = true;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(80, 14);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "null";
            this.lblTotal.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTotal.UseMnemonics = true;
            this.lblTotal.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.STEEL;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.DisplayStyle = VIBlend.WinForms.Controls.LabelItemStyle.TextOnly;
            this.Label1.Ellipsis = false;
            this.Label1.ImageAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Label1.Location = new System.Drawing.Point(44, 4);
            this.Label1.Multiline = true;
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(147, 18);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Calisan Uygulama :";
            this.Label1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Label1.UseMnemonics = true;
            this.Label1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.STEEL;
            // 
            // btnTaskEnd
            // 
            this.btnTaskEnd.AllowAnimations = true;
            this.btnTaskEnd.BackColor = System.Drawing.Color.Transparent;
            this.btnTaskEnd.Location = new System.Drawing.Point(520, 4);
            this.btnTaskEnd.Name = "btnTaskEnd";
            this.btnTaskEnd.RoundedCornersMask = ((byte)(15));
            this.btnTaskEnd.Size = new System.Drawing.Size(207, 30);
            this.btnTaskEnd.TabIndex = 0;
            this.btnTaskEnd.Text = "Gorevi Sonlandir";
            this.btnTaskEnd.UseVisualStyleBackColor = false;
            this.btnTaskEnd.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.STEEL;
            this.btnTaskEnd.Click += new System.EventHandler(this.btnTaskEnd_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PA,
            this.PID,
            this.CPU,
            this.CAL});
            this.listView1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(734, 334);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // PA
            // 
            this.PA.Text = "Programin Adi";
            this.PA.Width = 203;
            // 
            // PID
            // 
            this.PID.Text = "PID";
            this.PID.Width = 173;
            // 
            // CPU
            // 
            this.CPU.Text = "CPU";
            this.CPU.Width = 178;
            // 
            // CAL
            // 
            this.CAL.Text = "Calisma";
            this.CAL.Width = 158;
            // 
            // vTabPage2
            // 
            this.vTabPage2.Controls.Add(this.vGroupBox2);
            this.vTabPage2.Controls.Add(this.chartTotalCpuUsage);
            this.vTabPage2.Controls.Add(this.vGroupBox1);
            this.vTabPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vTabPage2.Location = new System.Drawing.Point(0, 27);
            this.vTabPage2.Name = "vTabPage2";
            this.vTabPage2.Padding = new System.Windows.Forms.Padding(0);
            this.vTabPage2.Size = new System.Drawing.Size(742, 406);
            this.vTabPage2.TabIndex = 4;
            this.vTabPage2.Text = "Performans";
            this.vTabPage2.TooltipText = "TabPage";
            this.vTabPage2.UseTabPageSpecificThemeSetters = false;
            this.vTabPage2.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.STEEL;
            this.vTabPage2.Visible = false;
            // 
            // vGroupBox2
            // 
            this.vGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.vGroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.vGroupBox2.Location = new System.Drawing.Point(164, 317);
            this.vGroupBox2.Name = "vGroupBox2";
            this.vGroupBox2.Size = new System.Drawing.Size(574, 85);
            this.vGroupBox2.TabIndex = 6;
            this.vGroupBox2.TabStop = false;
            this.vGroupBox2.UseThemeBorderColor = true;
            this.vGroupBox2.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            // 
            // chartTotalCpuUsage
            // 
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.Maximum = 100D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.IsMarginVisible = false;
            chartArea1.Name = "ChartAreaTotalCpuUsage";
            this.chartTotalCpuUsage.ChartAreas.Add(chartArea1);
            this.chartTotalCpuUsage.Location = new System.Drawing.Point(168, 7);
            this.chartTotalCpuUsage.Name = "chartTotalCpuUsage";
            series1.ChartArea = "ChartAreaTotalCpuUsage";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "TotalCpuUsageSeries";
            series1.ToolTip = "TotalCpuUsageSeries";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartTotalCpuUsage.Series.Add(series1);
            this.chartTotalCpuUsage.Size = new System.Drawing.Size(574, 304);
            this.chartTotalCpuUsage.SuppressExceptions = true;
            this.chartTotalCpuUsage.TabIndex = 5;
            this.chartTotalCpuUsage.Text = "Total CPU Usage";
            title1.Name = "TitleTotal";
            title1.Text = " CPU Usage";
            this.chartTotalCpuUsage.Titles.Add(title1);
            // 
            // vGroupBox1
            // 
            this.vGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.vGroupBox1.Controls.Add(this.vButton6);
            this.vGroupBox1.Controls.Add(this.vButton2);
            this.vGroupBox1.Controls.Add(this.vButton1);
            this.vGroupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.vGroupBox1.Location = new System.Drawing.Point(4, 4);
            this.vGroupBox1.Name = "vGroupBox1";
            this.vGroupBox1.Size = new System.Drawing.Size(160, 398);
            this.vGroupBox1.TabIndex = 0;
            this.vGroupBox1.TabStop = false;
            this.vGroupBox1.UseThemeBorderColor = true;
            this.vGroupBox1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.STEEL;
            // 
            // vButton6
            // 
            this.vButton6.AllowAnimations = true;
            this.vButton6.BackColor = System.Drawing.Color.Transparent;
            this.vButton6.Location = new System.Drawing.Point(8, 163);
            this.vButton6.Name = "vButton6";
            this.vButton6.RoundedCornersMask = ((byte)(15));
            this.vButton6.Size = new System.Drawing.Size(128, 47);
            this.vButton6.TabIndex = 2;
            this.vButton6.Text = "Mantıksal Bellek";
            this.vButton6.UseVisualStyleBackColor = false;
            this.vButton6.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            this.vButton6.Click += new System.EventHandler(this.vButton6_Click_1);
            // 
            // vButton2
            // 
            this.vButton2.AllowAnimations = true;
            this.vButton2.BackColor = System.Drawing.Color.Transparent;
            this.vButton2.Location = new System.Drawing.Point(8, 93);
            this.vButton2.Name = "vButton2";
            this.vButton2.RoundedCornersMask = ((byte)(15));
            this.vButton2.Size = new System.Drawing.Size(128, 47);
            this.vButton2.TabIndex = 1;
            this.vButton2.Text = "BELLEK kullanim";
            this.vButton2.UseVisualStyleBackColor = false;
            this.vButton2.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            this.vButton2.Click += new System.EventHandler(this.vButton2_Click);
            // 
            // vButton1
            // 
            this.vButton1.AllowAnimations = true;
            this.vButton1.BackColor = System.Drawing.Color.Transparent;
            this.vButton1.Location = new System.Drawing.Point(8, 19);
            this.vButton1.Name = "vButton1";
            this.vButton1.RoundedCornersMask = ((byte)(15));
            this.vButton1.Size = new System.Drawing.Size(128, 47);
            this.vButton1.TabIndex = 0;
            this.vButton1.Text = "CPU Kullanim";
            this.vButton1.UseVisualStyleBackColor = false;
            this.vButton1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            this.vButton1.Click += new System.EventHandler(this.vButton1_Click);
            // 
            // vTabPage3
            // 
            this.vTabPage3.Controls.Add(this.panel1);
            this.vTabPage3.Controls.Add(this.listView2);
            this.vTabPage3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vTabPage3.Location = new System.Drawing.Point(0, 27);
            this.vTabPage3.Name = "vTabPage3";
            this.vTabPage3.Padding = new System.Windows.Forms.Padding(0);
            this.vTabPage3.Size = new System.Drawing.Size(742, 406);
            this.vTabPage3.TabIndex = 5;
            this.vTabPage3.Text = "Açık Uygulamalar";
            this.vTabPage3.TooltipText = "TabPage";
            this.vTabPage3.UseTabPageSpecificThemeSetters = false;
            this.vTabPage3.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.STEEL;
            this.vTabPage3.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotal2);
            this.panel1.Controls.Add(this.vButton4);
            this.panel1.Controls.Add(this.vLabel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(4, 330);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 72);
            this.panel1.TabIndex = 8;
            // 
            // lblTotal2
            // 
            this.lblTotal2.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal2.DisplayStyle = VIBlend.WinForms.Controls.LabelItemStyle.TextOnly;
            this.lblTotal2.Ellipsis = false;
            this.lblTotal2.ImageAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTotal2.Location = new System.Drawing.Point(243, 15);
            this.lblTotal2.Multiline = true;
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.Size = new System.Drawing.Size(80, 24);
            this.lblTotal2.TabIndex = 11;
            this.lblTotal2.Text = "Label";
            this.lblTotal2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTotal2.UseMnemonics = true;
            this.lblTotal2.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            // 
            // vButton4
            // 
            this.vButton4.AllowAnimations = true;
            this.vButton4.BackColor = System.Drawing.Color.Transparent;
            this.vButton4.Location = new System.Drawing.Point(482, 15);
            this.vButton4.Name = "vButton4";
            this.vButton4.RoundedCornersMask = ((byte)(15));
            this.vButton4.Size = new System.Drawing.Size(147, 28);
            this.vButton4.TabIndex = 8;
            this.vButton4.Text = "Yeni Görev Başlat";
            this.vButton4.UseVisualStyleBackColor = false;
            this.vButton4.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.STEEL;
            this.vButton4.Click += new System.EventHandler(this.vButton4_Click);
            // 
            // vLabel3
            // 
            this.vLabel3.BackColor = System.Drawing.Color.Transparent;
            this.vLabel3.DisplayStyle = VIBlend.WinForms.Controls.LabelItemStyle.TextOnly;
            this.vLabel3.Ellipsis = false;
            this.vLabel3.ImageAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.vLabel3.Location = new System.Drawing.Point(64, 15);
            this.vLabel3.Multiline = true;
            this.vLabel3.Name = "vLabel3";
            this.vLabel3.Size = new System.Drawing.Size(134, 24);
            this.vLabel3.TabIndex = 10;
            this.vLabel3.Text = "Açık Program Sayısı :";
            this.vLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.vLabel3.UseMnemonics = true;
            this.vLabel3.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.STEEL;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView2.Location = new System.Drawing.Point(4, 4);
            this.listView2.Name = "listView2";
            this.listView2.ShowGroups = false;
            this.listView2.Size = new System.Drawing.Size(734, 320);
            this.listView2.TabIndex = 7;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Yansıma Adı";
            this.columnHeader1.Width = 258;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Windows Başlığı";
            this.columnHeader2.Width = 470;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // SistemBilgileri
            // 
            this.SistemBilgileri.CategoryName = "SQLServer:SSIS Service 11.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(742, 457);
            this.Controls.Add(this.vTabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "İşletim Sistemleri Projesi(Task Manager)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.vTabControl1.ResumeLayout(false);
            this.vTabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.vTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalCpuUsage)).EndInit();
            this.vGroupBox1.ResumeLayout(false);
            this.vTabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cıkışToolStripMenuItem;
        private System.Windows.Forms.Panel ItemPanel;
        private VIBlend.WinForms.Controls.vTabControl vTabControl1;
        private VIBlend.WinForms.Controls.vTabPage vTabPage1;
        private VIBlend.WinForms.Controls.vTabPage vTabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader PA;
        private System.Windows.Forms.ColumnHeader PID;
        private System.Windows.Forms.ColumnHeader CPU;
        private System.Windows.Forms.ColumnHeader CAL;
        private VIBlend.WinForms.Controls.vGroupBox vGroupBox1;
        private VIBlend.WinForms.Controls.vButton vButton2;
        private VIBlend.WinForms.Controls.vButton btnTaskEnd;
        private VIBlend.WinForms.Controls.vButton button1;
        private VIBlend.WinForms.Controls.vLabel lblTotal;
        private VIBlend.WinForms.Controls.vLabel Label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotalCpuUsage;
        private System.Windows.Forms.Timer timer2;
        private VIBlend.WinForms.Controls.vButton vButton1;
        private VIBlend.WinForms.Controls.vGroupBox vGroupBox2;
        private VIBlend.WinForms.Controls.vButton vButton3;
        private VIBlend.WinForms.Controls.vTabPage vTabPage3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel1;
        private VIBlend.WinForms.Controls.vLabel lblTotal2;
        private VIBlend.WinForms.Controls.vButton vButton4;
        private VIBlend.WinForms.Controls.vLabel vLabel3;
        private VIBlend.WinForms.Controls.vButton vButton6;
        private System.Windows.Forms.ToolStripMenuItem secenekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simgeDurumunaKüçüldüğündeGizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simgeDurumunaKüçüldüğündeGizleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem görüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem kullanımDurumuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şimdiYenileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemBilgileriToolStripMenuItem;
        private System.Diagnostics.PerformanceCounter SistemBilgileri;
        private System.Windows.Forms.ToolStripMenuItem lisansBilgileriToolStripMenuItem;




    }
}

