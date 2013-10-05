using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// here add QR library
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace QR_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Save button
        /// </summary>
      
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog(); //Prompts the user to select a location for saving a file.
            s.Filter = "PNG|*.png|JPEG|*.jpeg|BMP|*.bmp|GIF|*.gif";
            if(s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                qrimage.Image.Save(s.FileName);
            }
        }


        /// <summary>
        /// create buuton : create QR code
        /// </summary>
        
        private void button1_Click(object sender, EventArgs e)
        {
            string URL = url.Text; // textbox string
            QRCodeEncoder encoder = new QRCodeEncoder();
            Bitmap qrcode = encoder.Encode(URL); // encode url into the image
            qrimage.Image = qrcode as Image; // present image in the imagebox
        }

        /// <summary>
        /// extract code from image
        /// </summary>
     
        private void button4_Click(object sender, EventArgs e)
        {
            QRCodeDecoder decoder = new QRCodeDecoder();
            MessageBox.Show(decoder.decode(new QRCodeBitmapImage(qrimage.Image as Bitmap)));
        }

        private void qrimage_Click(object sender, EventArgs e)
        {

        }
    }
}
