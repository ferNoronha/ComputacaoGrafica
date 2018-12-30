using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade1
{
    public partial class Form1 : Form
    {
        private Image image;
        private Bitmap imageBitmap;
        private Hsi[,] mat;
        public Form1()
        {
            InitializeComponent();
            trackBar1.Enabled = false;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter= "Arquivos de Imagem (*.jpg; *.gif; *.bmp; *.png)| *.jpg; *.gif; *.bmp; *.png";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(openFileDialog1.FileName);
                pcbox.Image = image;
                pcbox.SizeMode = PictureBoxSizeMode.Normal;

                carregaMatriz(image);
                trackBar1.Enabled = true;
            }
        }

        private void carregaMatriz(Image image)
        {
           imageBitmap = (Bitmap)image;
           int width = imageBitmap.Width;
           int height = imageBitmap.Height;

            mat = new Hsi[width,height];
            double r, g, b;
            double h =0, s=0, i=0;
            double H=0, S=0, I=0;
            double minimo;
            double primeirafuncao, segundafuncao;
            for(int x=0;x<width;x++)
            {
                for(int y=0;y<height;y++)
                {
                    Color cor = imageBitmap.GetPixel(x, y);

                    if (cor.R != 0 && cor.G != 0 && cor.B != 0)
                    {
                        r = (double)cor.R / (cor.R + cor.G + cor.B);
                        g = (double)cor.G / (cor.R + cor.G + cor.B);
                        b = (double)cor.B / (cor.R + cor.G + cor.B);
                        /*r = (double)100 / (100 + 150 + 200);
                        g = (double)150 / (100 + 150 + 200);
                        b = (double)200 / (100 + 150 + 200);*/
                    }
                    else
                    {
                        r = g = b = 0;
                    }
                    minimo = Math.Min(r, g);
                    s = 1 - 3 * Math.Min(Math.Min(r,g), b);

                    i = (r + g + b) / (3);
                    
                    primeirafuncao= 0.5 * ((r - g) + (r - b));
                    segundafuncao = Math.Pow((Math.Pow((r-g),2)+((r-b)*(g- b))),0.5);

                    if(primeirafuncao!=0 && segundafuncao!=0)
                    {
                        if (b <= g)
                            h = Math.Acos(primeirafuncao / segundafuncao);
                        else
                            h = 2*Math.PI- Math.Acos(primeirafuncao / segundafuncao);
                    }
                    else
                    {
                        h = 0;
                    }


                    H = h * 180 / Math.PI;
                    S = s * 100;
                    I = i * 255;
                    
                    mat[x,y] = new Hsi();
                    mat[x,y].setH(H);
                    mat[x,y].setS(S);
                    mat[x,y].setI(I);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pcbox.Image = null;
            /*Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.convert_to_grayDMA(imageBitmap, imgDest);
            pcbox.Image = imgDest;*/
        }

        private void mover(object sender, MouseEventArgs e)
        {

            imageBitmap = (Bitmap)image;

            if(imageBitmap!=null)
            {
                
                int width = imageBitmap.Width;
                int height = imageBitmap.Height;
                int c, m, y;
                int px, py;
                px = e.X;
                py = e.Y;

                if (px >0 && px < width && py> 0 && py < height)
                {
                    Color cor = imageBitmap.GetPixel(px, py);
                    lblR.Text = "" + cor.R;
                    lblG.Text = "" + cor.G;
                    lblB.Text = "" + cor.B;

                   lblC.Text = "" + (255 - cor.R);
                   lblM.Text = "" + (255 - cor.G);
                   lblY.Text = "" + (255 - cor.B);

                    lblH.Text = "" + mat[px,py].getH();
                    lblS.Text = "" + mat[px,py].getS();
                    lblI.Text = "" + mat[px,py].getI();

                }
            }
           
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
          //  lblB.Text = "" + trackBar1.Value;
            aumentabrilho(image);
        }

        private void aumentabrilho(Image image)
        {
            imageBitmap = (Bitmap)image;
            if(imageBitmap!=null)
            {
                int width = imageBitmap.Width;
                int height = imageBitmap.Height;
              //  int h, s, i;


                
               

            }
          
        }
    }
}
