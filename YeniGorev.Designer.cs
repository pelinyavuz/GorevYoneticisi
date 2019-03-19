namespace IsletimSistemi_GorevYoneticisi_
{
    partial class YeniGorev
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
            this.vTextBox1 = new VIBlend.WinForms.Controls.vTextBox();
            this.vButton1 = new VIBlend.WinForms.Controls.vButton();
            this.SuspendLayout();
            // 
            // vTextBox1
            // 
            this.vTextBox1.BackColor = System.Drawing.Color.White;
            this.vTextBox1.BoundsOffset = new System.Drawing.Size(1, 1);
            this.vTextBox1.ControlBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.vTextBox1.DefaultText = "Empty...";
            this.vTextBox1.Location = new System.Drawing.Point(12, 25);
            this.vTextBox1.MaxLength = 32767;
            this.vTextBox1.Name = "vTextBox1";
            this.vTextBox1.PasswordChar = '\0';
            this.vTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.vTextBox1.SelectionLength = 0;
            this.vTextBox1.SelectionStart = 0;
            this.vTextBox1.Size = new System.Drawing.Size(198, 23);
            this.vTextBox1.TabIndex = 0;
            this.vTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.vTextBox1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.STEEL;
            // 
            // vButton1
            // 
            this.vButton1.AllowAnimations = true;
            this.vButton1.BackColor = System.Drawing.Color.Transparent;
            this.vButton1.Location = new System.Drawing.Point(218, 53);
            this.vButton1.Name = "vButton1";
            this.vButton1.RoundedCornersMask = ((byte)(15));
            this.vButton1.Size = new System.Drawing.Size(100, 30);
            this.vButton1.TabIndex = 1;
            this.vButton1.Text = "Başlat";
            this.vButton1.UseVisualStyleBackColor = false;
            this.vButton1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.STEEL;
            this.vButton1.Click += new System.EventHandler(this.vButton1_Click);
            // 
            // YeniGorev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 95);
            this.Controls.Add(this.vButton1);
            this.Controls.Add(this.vTextBox1);
            this.Name = "YeniGorev";
            this.Text = "YeniGorev";
            this.ResumeLayout(false);

        }

        #endregion

        private VIBlend.WinForms.Controls.vTextBox vTextBox1;
        private VIBlend.WinForms.Controls.vButton vButton1;
    }
}