namespace OpenCV
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnGorselIsle;
        private System.Windows.Forms.PictureBox pbKaynak;
        private System.Windows.Forms.PictureBox pbSonuc;
        private System.Windows.Forms.Label lblKaynak;
        private System.Windows.Forms.Label lblSonuc;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnGorselIsle = new System.Windows.Forms.Button();
            this.pbKaynak = new System.Windows.Forms.PictureBox();
            this.pbSonuc = new System.Windows.Forms.PictureBox();
            this.lblKaynak = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbKaynak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSonuc)).BeginInit();
            this.SuspendLayout();
           
            this.btnGorselIsle.Location = new System.Drawing.Point(300, 10);
            this.btnGorselIsle.Name = "btnGorselIsle";
            this.btnGorselIsle.Size = new System.Drawing.Size(180, 40);
            this.btnGorselIsle.TabIndex = 0;
            this.btnGorselIsle.Text = "Görsel Seç ve İşle";
            this.btnGorselIsle.UseVisualStyleBackColor = true;
            this.btnGorselIsle.Click += new System.EventHandler(this.btnGorselIsle_Click);
             
            this.pbKaynak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbKaynak.Location = new System.Drawing.Point(20, 80);
            this.pbKaynak.Name = "pbKaynak";
            this.pbKaynak.Size = new System.Drawing.Size(350, 300);
            this.pbKaynak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbKaynak.TabIndex = 1;
            this.pbKaynak.TabStop = false;
            
            this.pbSonuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSonuc.Location = new System.Drawing.Point(410, 80);
            this.pbSonuc.Name = "pbSonuc";
            this.pbSonuc.Size = new System.Drawing.Size(350, 300);
            this.pbSonuc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSonuc.TabIndex = 2;
            this.pbSonuc.TabStop = false;
            
            this.lblKaynak.AutoSize = true;
            this.lblKaynak.Location = new System.Drawing.Point(140, 60);
            this.lblKaynak.Name = "lblKaynak";
            this.lblKaynak.Text = "Kaynak Görsel";
            
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(520, 60);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Text = "İşlenmiş Görsel (Canny Kenar Tespiti)";
           
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lblKaynak);
            this.Controls.Add(this.pbSonuc);
            this.Controls.Add(this.pbKaynak);
            this.Controls.Add(this.btnGorselIsle);
            this.Name = "Form1";
            this.Text = "OpenCV C# Ödevi";

            
            ((System.ComponentModel.ISupportInitialize)(this.pbKaynak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSonuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}