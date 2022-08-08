using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generador_de_QR
{
    public partial class FormPrincipal : Form
    {
        private enum SizeImage
        {
            DosxDos = 0,
            TresxTres = 1,
            CincoxCinco = 2
        }

        private int sizeImage;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void GenerarBTN_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(TextTXT.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            string pathImg = Path.Combine(Application.StartupPath, "Img\\IconoMultimedioRosario.png");
            Bitmap qrCodeImage = qrCode.GetGraphic(20, Color.Black, Color.White, (Bitmap)Bitmap.FromFile(pathImg));
            PictureBoxQr.Image = qrCodeImage;
            GuardarBTN.Enabled = true;
        }

        private void GuardarBTN_Click(object sender, EventArgs e)
        {
            string pathImgSave = "";
            Image i = resizeImage(PictureBoxQr.Image, new Size(354, 354));

            if (!System.IO.Directory.Exists(Path.Combine(Application.StartupPath, "GeneratedQR")))
                Directory.CreateDirectory(Path.Combine(Application.StartupPath, "GeneratedQR"));

            switch (sizeImage)
            {
                case (int)SizeImage.DosxDos:
                    pathImgSave = Path.Combine(Application.StartupPath, "GeneratedQR\\QR - 2x2 .png");
                    i = resizeImage(PictureBoxQr.Image, new Size(236, 236));
                    i.Save(pathImgSave, System.Drawing.Imaging.ImageFormat.Png);
                    break;
                case (int)SizeImage.TresxTres:
                    pathImgSave = Path.Combine(Application.StartupPath, "GeneratedQR\\QR - 3x3 .png");
                    i = resizeImage(PictureBoxQr.Image, new Size(354, 354));
                    i.Save(pathImgSave, System.Drawing.Imaging.ImageFormat.Png);
                    break;
                case (int)SizeImage.CincoxCinco:
                    pathImgSave = Path.Combine(Application.StartupPath, "GeneratedQR\\QR - 5x5 .png");
                    i = resizeImage(PictureBoxQr.Image, new Size(591, 591));
                    i.Save(pathImgSave, System.Drawing.Imaging.ImageFormat.Png);
                    break;
            }

            MessageBox.Show("Se genero el QR correctamente");
        }

        private static System.Drawing.Image resizeImage(System.Drawing.Image imgToResize, Size size)
        {
            //Get the image current width  
            int sourceWidth = imgToResize.Width;
            //Get the image current height  
            int sourceHeight = imgToResize.Height;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            //Calulate  width with new desired size  
            nPercentW = ((float)size.Width / (float)sourceWidth);
            //Calculate height with new desired size  
            nPercentH = ((float)size.Height / (float)sourceHeight);
            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;
            //New Width  
            int destWidth = (int)(sourceWidth * nPercent);
            //New Height  
            int destHeight = (int)(sourceHeight * nPercent);
            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            // Draw image with new width and height  
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return (System.Drawing.Image)b;
        }

        private void rd2x2_CheckedChanged(object sender, EventArgs e)
        {
            sizeImage = (int)SizeImage.DosxDos;
        }

        private void rd3x3_CheckedChanged(object sender, EventArgs e)
        {
            sizeImage = (int)SizeImage.TresxTres;
        }

        private void rd5x5_CheckedChanged(object sender, EventArgs e)
        {
            sizeImage = (int)SizeImage.CincoxCinco;
        }
    }
}
