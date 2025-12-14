using System;
using System.Drawing;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace OpenCV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGorselIsle_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string secilenDosyaYolu = ofd.FileName;
                    GorselIsleme(secilenDosyaYolu);
                }
            }
        }

        private void GorselIsleme(string dosyaYolu)
        {
            using (Mat kaynakGorsel = Cv2.ImRead(dosyaYolu, ImreadModes.Color))
            {
                if (kaynakGorsel.Empty())
                {
                    MessageBox.Show("Görüntü yüklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                pbKaynak.Image = BitmapConverter.ToBitmap(kaynakGorsel);

                using (Mat griGorsel = new Mat())
                {
                    Cv2.CvtColor(kaynakGorsel, griGorsel, ColorConversionCodes.BGR2GRAY);

                    using (Mat kenarGorsel = new Mat())
                    {
                        Cv2.Canny(griGorsel, kenarGorsel, 100, 200);

                        try
                        {
                            pbSonuc.Image = BitmapConverter.ToBitmap(kenarGorsel);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Sonuç görüntüsü yüklenirken hata oluştu: " + ex.Message);
                        }
                    }
                }
            }
        }
    }
}