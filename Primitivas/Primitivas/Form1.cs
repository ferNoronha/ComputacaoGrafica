using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primitivas
{
    public partial class Primitivas : Form
    {
        private int[,,] matriz;
        private double x1, y1, x2, y2;
        private Bitmap bm;
        private int op;

        public Primitivas()
        {
            InitializeComponent();
        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            Aplicacoes.LoadPicBox(bm);
            picBox.Image = bm;
        }

        private void picBox_MouseUp(object sender, MouseEventArgs e)
        {
            Bitmap bitmap = new Bitmap(picBox.Image);

            x2 = e.X;
            y2 = e.Y;

            switch(op)
            {
                case 1: Aplicacoes.EqGeralReta(x1, y1, x2, y2, out matriz, picBox.Size.Height, picBox.Size.Width, bitmap);
                    break;
                case 2:
                    Aplicacoes.DDA((int)x1, (int)y1, (int)x2, (int)y2, bitmap);
                    break;
                case 3:
                    Aplicacoes.BresenhamReta((int)x1, (int)y1, (int)x2, (int)y2, bitmap);
                    break;

                case 4:
                    Aplicacoes.EqGeralCircunf((int)x1, (int)y1, (int)x2, (int)y2, Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), bitmap);
                    break;
                case 5:
                    Aplicacoes.TrigonoCircunf((int)x1, (int)y1, (int)x2, (int)y2, (int)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), bitmap);
                    break;
                case 6:
                    Aplicacoes.BresenhamCircunf((int)x1, (int)y1, (int)x2, (int)y2, (int)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), bitmap);
                    break;

                case 7:
                    Aplicacoes.BresenhamElipse((int)x1, (int)y1, (int)((x2 - x1) / 2), (int)((y2 - y1) / 2), bitmap);
                    break;
            }

            picBox.Image = bitmap;
        }

        private void btnDDA_Click(object sender, EventArgs e)
        {
            op = 2;
        }

        private void btnBresenhamReta_Click(object sender, EventArgs e)
        {
            op = 3;
        }

        private void btnEqGeralCircunf_Click(object sender, EventArgs e)
        {
            op = 4;
        }

        private void btnTrig_Click(object sender, EventArgs e)
        {
            op = 5;
        }

        private void btnBresenhamCircunf_Click(object sender, EventArgs e)
        {
            op = 6;
        }

        private void btnBresenhamElipse_Click(object sender, EventArgs e)
        {
            op = 7;
        }

        private void picBox_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
        }

        private void btnEqGeral_Click(object sender, EventArgs e)
        {
            op = 1;
        }

        private void Primitivas_Load(object sender, EventArgs e)
        {
            bm = new Bitmap(picBox.Size.Width, picBox.Size.Height);

            matriz = new int[picBox.Size.Height, picBox.Size.Width, 3];
            
            Aplicacoes.LoadPicBox(bm);
            picBox.Image = bm;
            picBox.SizeMode = PictureBoxSizeMode.Normal;
            x1 = y1 = 0;
        }
    }
}
