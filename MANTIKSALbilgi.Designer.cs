namespace IsletimSistemi_GorevYoneticisi_
{
    partial class MANTIKSALbilgi
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
            this.pbCPU = new VIBlend.WinForms.Controls.vProgressBar();
            this.lblCPU = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tmrDeger = new System.Windows.Forms.Timer(this.components);
            this.MantıksalBellek = new System.Diagnostics.PerformanceCounter();
            this.vProgressBar2 = new VIBlend.WinForms.Controls.vProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.zaman = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.MantıksalBellek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaman)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCPU
            // 
            this.pbCPU.BackColor = System.Drawing.Color.Transparent;
            this.pbCPU.Location = new System.Drawing.Point(15, 37);
            this.pbCPU.Name = "pbCPU";
            this.pbCPU.RoundedCornersMask = ((byte)(15));
            this.pbCPU.Size = new System.Drawing.Size(187, 20);
            this.pbCPU.TabIndex = 26;
            this.pbCPU.Text = "vProgressBar1";
            this.pbCPU.Value = 0;
            this.pbCPU.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.STEEL;
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCPU.ForeColor = System.Drawing.Color.Red;
            this.lblCPU.Location = new System.Drawing.Point(121, 21);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(27, 13);
            this.lblCPU.TabIndex = 22;
            this.lblCPU.Text = "null";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "C Kullanımı :";
            // 
            // tmrDeger
            // 
            this.tmrDeger.Tick += new System.EventHandler(this.tmrDeger_Tick_1);
            // 
            // MantıksalBellek
            // 
            this.MantıksalBellek.CategoryName = "MantıksalDisk";
            this.MantıksalBellek.CounterName = "% Boş Alan";
            this.MantıksalBellek.InstanceName = "C:";
            // 
            // vProgressBar2
            // 
            this.vProgressBar2.BackColor = System.Drawing.Color.Transparent;
            this.vProgressBar2.Location = new System.Drawing.Point(15, 101);
            this.vProgressBar2.Name = "vProgressBar2";
            this.vProgressBar2.RoundedCornersMask = ((byte)(15));
            this.vProgressBar2.Size = new System.Drawing.Size(187, 20);
            this.vProgressBar2.TabIndex = 29;
            this.vProgressBar2.Text = "vProgressBar1";
            this.vProgressBar2.Value = 0;
            this.vProgressBar2.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.STEEL;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(121, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "null";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "C Boş Zaman :";
            // 
            // zaman
            // 
            this.zaman.CategoryName = "MantıksalDisk";
            this.zaman.CounterName = "% Boşta Zaman";
            this.zaman.InstanceName = "C:";
            // 
            // MANTIKSALbilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 149);
            this.Controls.Add(this.vProgressBar2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbCPU);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.label4);
            this.Name = "MANTIKSALbilgi";
            this.Text = "Mantıksal Bellek";
            this.Load += new System.EventHandler(this.CPUbilgi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MantıksalBellek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VIBlend.WinForms.Controls.vProgressBar pbCPU;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer tmrDeger;
        private System.Diagnostics.PerformanceCounter MantıksalBellek;
        private VIBlend.WinForms.Controls.vProgressBar vProgressBar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Diagnostics.PerformanceCounter zaman;
    }
}