using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;

namespace _2024._10._15_QR_KOD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                QRCodeEncoder turet = new QRCodeEncoder();
                pictureBox1.Image = turet.Encode(textBox1.Text);
            }
            else
            {
                MessageBox.Show("AŞAĞIYA BİR KAYNAK VERİSİ YAZINIZ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("QR kod oluşturunuz!!");
                return;
            }
            var resim = pictureBox1.Image;
            resim.Save(Application.StartupPath + "\\" + DateTime.Now.ToShortDateString() +
                DateTime.Now.ToFileTime() + ".png");
            MessageBox.Show("QR CODE başarıyla kaydedildi!!");
            pictureBox1.Image = null;
            textBox1.Text = "";
            
        }
    }
}
