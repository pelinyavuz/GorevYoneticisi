namespace IsletimSistemi_GorevYoneticisi_
{
    partial class Form2
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
            this.label4 = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.tmrDeger = new System.Windows.Forms.Timer(this.components);
            this.ram = new System.Diagnostics.PerformanceCounter();
            this.ramOkuma = new System.Diagnostics.PerformanceCounter();
            this.lblOku = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbOku = new VIBlend.WinForms.Controls.vProgressBar();
            this.pbRAM = new VIBlend.WinForms.Controls.vProgressBar();
            this.ramYazma = new System.Diagnostics.PerformanceCounter();
            this.pbYaz = new VIBlend.WinForms.Controls.vProgressBar();
            this.lblYaz = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramOkuma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramYazma)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(26, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "RAM Kullanımı :";
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRAM.ForeColor = System.Drawing.Color.Red;
            this.lblRAM.Location = new System.Drawing.Point(135, 23);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(27, 13);
            this.lblRAM.TabIndex = 12;
            this.lblRAM.Text = "null";
            this.lblRAM.Click += new System.EventHandler(this.lblRAM_Click);
            // 
            // tmrDeger
            // 
            this.tmrDeger.Tick += new System.EventHandler(this.tmrDeger_Tick);
            // 
            // ram
            // 
            this.ram.CategoryName = "Memory";
            this.ram.CounterName = "% Committed Bytes In Use";
            // 
            // ramOkuma
            // 
            this.ramOkuma.CategoryName = "Bellek";
            this.ramOkuma.CounterName = "Sayfa Okuma/sn";
            // 
            // lblOku
            // 
            this.lblOku.AutoSize = true;
            this.lblOku.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOku.ForeColor = System.Drawing.Color.Red;
            this.lblOku.Location = new System.Drawing.Point(135, 71);
            this.lblOku.Name = "lblOku";
            this.lblOku.Size = new System.Drawing.Size(27, 13);
            this.lblOku.TabIndex = 15;
            this.lblOku.Text = "null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "RAM Okuma :";
            // 
            // pbOku
            // 
            this.pbOku.BackColor = System.Drawing.Color.Transparent;
            this.pbOku.Location = new System.Drawing.Point(29, 99);
            this.pbOku.Name = "pbOku";
            this.pbOku.RoundedCornersMask = ((byte)(15));
            this.pbOku.Size = new System.Drawing.Size(187, 20);
            this.pbOku.TabIndex = 16;
            this.pbOku.Text = "vProgressBar1";
            this.pbOku.Value = 0;
            this.pbOku.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.STEEL;
            // 
            // pbRAM
            // 
            this.pbRAM.BackColor = System.Drawing.Color.Transparent;
            this.pbRAM.Location = new System.Drawing.Point(29, 39);
            this.pbRAM.Name = "pbRAM";
            this.pbRAM.RoundedCornersMask = ((byte)(15));
            this.pbRAM.Size = new System.Drawing.Size(187, 20);
            this.pbRAM.TabIndex = 17;
            this.pbRAM.Text = "vProgressBar1";
            this.pbRAM.Value = 0;
            this.pbRAM.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.STEEL;
            // 
            // ramYazma
            // 
            this.ramYazma.CategoryName = "Bellek";
            this.ramYazma.CounterName = "Sayfa Yazma/sn";
            // 
            // pbYaz
            // 
            this.pbYaz.BackColor = System.Drawing.Color.Transparent;
            this.pbYaz.Location = new System.Drawing.Point(29, 158);
            this.pbYaz.Name = "pbYaz";
            this.pbYaz.RoundedCornersMask = ((byte)(15));
            this.pbYaz.Size = new System.Drawing.Size(187, 20);
            this.pbYaz.TabIndex = 20;
            this.pbYaz.Text = "vProgressBar1";
            this.pbYaz.Value = 0;
            this.pbYaz.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.STEEL;
            // 
            // lblYaz
            // 
            this.lblYaz.AutoSize = true;
            this.lblYaz.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYaz.ForeColor = System.Drawing.Color.Red;
            this.lblYaz.Location = new System.Drawing.Point(135, 130);
            this.lblYaz.Name = "lblYaz";
            this.lblYaz.Size = new System.Drawing.Size(27, 13);
            this.lblYaz.TabIndex = 19;
            this.lblYaz.Text = "null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "RAM Yazma :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 201);
            this.Controls.Add(this.pbYaz);
            this.Controls.Add(this.lblYaz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbRAM);
            this.Controls.Add(this.pbOku);
            this.Controls.Add(this.lblOku);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.label4);
            this.Name = "Form2";
            this.Text = "RAM";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramOkuma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramYazma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Timer tmrDeger;
        private System.Diagnostics.PerformanceCounter ram;
        private System.Diagnostics.PerformanceCounter ramOkuma;
        private System.Windows.Forms.Label lblOku;
        private System.Windows.Forms.Label label2;
        private VIBlend.WinForms.Controls.vProgressBar pbOku;
        private VIBlend.WinForms.Controls.vProgressBar pbRAM;
        private System.Diagnostics.PerformanceCounter ramYazma;
        private VIBlend.WinForms.Controls.vProgressBar pbYaz;
        private System.Windows.Forms.Label lblYaz;
        private System.Windows.Forms.Label label3;
    }
}