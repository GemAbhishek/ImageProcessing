using System;
using System.Drawing;
using System.Windows.Forms;

namespace Image_Proccessing_BAsic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog Opfile = new OpenFileDialog();
            Opfile.Filter = "Image File (*.bmp,*.jpg)| *.bmp;*.jpg";
            if(DialogResult.OK==Opfile.ShowDialog())
            {
                this.picOriginal.Image = new Bitmap(Opfile.FileName);
            }
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            Bitmap coppy = new Bitmap((Bitmap)this.picOriginal.Image);

            Method.ConvertToGray(coppy);
            this.picResult.Image = coppy;
        }

        private void btnCyan_Click(object sender, EventArgs e)
        {
            Bitmap coppy = new Bitmap((Bitmap)this.picOriginal.Image);

            Method.ConvertToCyan(coppy);
            this.picResult.Image = coppy;
        }

        private void btnGrayAndGray_Click(object sender, EventArgs e)
        {
            Bitmap coppy = new Bitmap((Bitmap)this.picOriginal.Image);

            Method.ConvertToGrayAndGray(coppy);
            this.picResult.Image = coppy;
        }
    }
}
