using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace Primitivas
{
    class Aplicacoes
    {
        public static void LoadPicBox(Bitmap imageBitmapSrc)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;

            //lock dados bitmap origem
            BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int padding = bitmapDataSrc.Stride - (width * 3);

            unsafe
            {
                byte* src = (byte*)bitmapDataSrc.Scan0.ToPointer();

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        *(src++) = (byte)255;
                        *(src++) = (byte)255;
                        *(src++) = (byte)255;
                    }
                    src += padding;
                }
            }
            //unlock imagem origem
            imageBitmapSrc.UnlockBits(bitmapDataSrc);
        }

        public static void EqGeralReta(double x1, double y1, double x2, double y2, out int[,,] matriz, int h, int w, Bitmap imageBitmapSrc)
        {
            double dy = y2 - y1;
            double dx = x2 - x1;
            double y = y1;
            double x = x1;

            int[,,] mat = new int[h, w, 3];
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;

            double m = (dx == 0) ? 0 : dy / dx;

            //lock dados bitmap origem
            BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int padding = bitmapDataSrc.Stride - (width * 3);

            unsafe
            {
                byte* src;

                if (dx >= dy)
                {
                    for (int xc = (int)x1; xc <= x2; xc++)
                    {
                        y = y1 + m * (xc - x1);
                        int Y = (int)Math.Round(y);
                        /*mat[Y, x, 0] = 0;
                        mat[Y, x, 1] = 0;
                        mat[Y, x, 2] = 0;*/
                        src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                        src += Y * (width * 3 + padding) + xc * 3;
                        *(src++) = (byte)0;
                        *(src++) = (byte)0;
                        *(src++) = (byte)0;
                    }
                }
                else
                {
                    for (int yc = (int)y1; yc <= y2; yc++)
                    {
                        x = x1 + (yc - y1) / m;
                        int X = (int)Math.Round(x);
                        src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                        src += yc * (width * 3 + padding) + X * 3;
                        *(src++) = (byte)0;
                        *(src++) = (byte)0;
                        *(src++) = (byte)0;
                    }
                }

                //unlock imagem origem
                imageBitmapSrc.UnlockBits(bitmapDataSrc);
            }

            matriz = mat;
        }

        public static void DDA(int X1, int Y1, int X2, int Y2, Bitmap imageBitmapSrc)
        {
            int Length, I;
            double X, Y, Xinc, Yinc;
            int dy = Y2 - Y1;
            int dx = X2 - X1;
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;

            //lock dados bitmap origem
            BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int padding = bitmapDataSrc.Stride - (width * 3);

            unsafe
            {
                if (dx >= dy)
                {
                    Length = Math.Abs(X2 - X1);

                    if (Math.Abs(Y2 - Y1) > Length)
                        Length = Math.Abs(Y2 - Y1);
                    Xinc = (double)(X2 - X1) / Length;
                    Yinc = (double)(Y2 - Y1) / Length;

                    X = X1; Y = Y1;

                    byte* src;

                    while (X < X2)
                    {
                        int x = (int)Math.Round(X);
                        int y = (int)Math.Round(Y);
                        src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                        src += y * (width * 3 + padding) + x * 3;
                        *(src++) = (byte)0;
                        *(src++) = (byte)0;
                        *(src++) = (byte)0;
                        X = X + Xinc;
                        Y = Y + Yinc;
                    }
                }
                else
                {
                    Length = Math.Abs(Y2 - Y1);

                    if (Math.Abs(X2 - X1) > Length)
                        Length = Math.Abs(X2 - X1);
                    Xinc = (double)(X2 - X1) / Length;
                    Yinc = (double)(Y2 - Y1) / Length;

                    X = X1; Y = Y1;

                    byte* src;

                    while (Y < Y2)
                    {
                        int x = (int)Math.Round(X);
                        int y = (int)Math.Round(Y);
                        src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                        src += y * (width * 3 + padding) + x * 3;
                        *(src++) = (byte)0;
                        *(src++) = (byte)0;
                        *(src++) = (byte)0;
                        X = X + Xinc;
                        Y = Y + Yinc;
                    }
                }
                //unlock imagem origem
                imageBitmapSrc.UnlockBits(bitmapDataSrc);
            }
        }

        public static void BresenhamReta(int x1, int y1, int x2, int y2, Bitmap imageBitmapSrc)
        {
            int declive = 1;
            int dx, dy, incE, incNE, d, x, y;
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;


            //lock dados bitmap origem
            BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int padding = bitmapDataSrc.Stride - (width * 3);

            unsafe
            {


                dx = x2 - x1;
                dy = y2 - y1;

                if (Math.Abs(dx) > Math.Abs(dy))
                {
                    if (x2 < x1)
                    {
                        int a, b;
                        a = x1;
                        b = y1;

                        x1 = x2;
                        y1 = y2;

                        x2 = a;
                        y2 = b;

                        dx = x2 - x1;
                        dy = y2 - y1;

                        /*BresenhamReta(x2, y2, x1, y1, imageBitmapSrc);
                        return;*/
                    }

                    if (y2 < y1)
                    {
                        dy = -dy;
                        declive = -1;
                    }
                    //declive = (dy > 0) ? 1 : -1;

                    byte* src;

                    // Constante de Bresenham 
                    incE = 2 * dy;
                    incNE = 2 * dy - 2 * dx;
                    d = 2 * dy - dx;
                    y = y1;



                    for (x = x1; x <= x2; x++)
                    {
                        src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                        src += y * (width * 3 + padding) + x * 3;
                        *(src++) = (byte)0;
                        *(src++) = (byte)0;
                        *(src++) = (byte)0;

                        if (d <= 0)
                        {
                            d += incE;
                        }
                        else
                        {
                            d += incNE;
                            y += declive;
                        }
                    }
                }
                else
                {
                    if (y2 < y1)
                    {
                        int a, b;
                        a = x1;
                        b = y1;

                        x1 = x2;
                        y1 = y2;

                        x2 = a;
                        y2 = b;

                        dx = x2 - x1;
                        dy = y2 - y1;

                        /*BresenhamReta(x2, y2, x1, y1, imageBitmapSrc);
                        return;*/
                    }

                    if (x2 < x1)
                    {
                        dx = -dx;
                        declive = -1;
                    }

                    byte* src;

                    // Constante de Bresenham 
                    incE = 2 * dx;
                    incNE = 2 * dx - 2 * dy;
                    d = 2 * dx - dy;
                    x = x1;



                    for (y = y1; y <= y2; y++)
                    {
                        src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                        src += y * (width * 3 + padding) + x * 3;
                        *(src++) = (byte)0;
                        *(src++) = (byte)0;
                        *(src++) = (byte)0;

                        if (d <= 0)
                        {
                            d += incE;
                        }
                        else
                        {
                            d += incNE;
                            x += declive;
                        }
                    }
                }

                //unlock imagem origem
                imageBitmapSrc.UnlockBits(bitmapDataSrc);
            }
        }

        private static void circuloOrdem8(int cx, int cy, int x1, int y1, Bitmap imageBitmapSrc)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;

            //lock dados bitmap origem
            BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int padding = bitmapDataSrc.Stride - (width * 3);

            unsafe
            {
                byte* src;
                
                if (cy + y1 < height && cx + x1 < width && cy + y1 > 0 && cx + x1 > 0)
                {
                    src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                    src += (int)((cy + y1) * (width * 3 + padding) + (cx + x1) * 3);
                    *(src++) = (byte)0;
                    *(src++) = (byte)0;
                    *(src++) = (byte)0;
                }
                
                if (cy + x1 < height && cx + y1 < width && cy + x1 > 0 && cx + y1 > 0)
                {
                    src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                    src += (int)((cy + x1) * (width * 3 + padding) + (cx + y1) * 3);
                    *(src++) = (byte)0;
                    *(src++) = (byte)0;
                    *(src++) = (byte)0;
                }
                
                if (cy - x1 < height && cx + y1 < width && cy - x1 > 0 && cx + y1 > 0)
                {
                    src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                    src += (int)((cy - x1) * (width * 3 + padding) + (cx + y1) * 3);
                    *(src++) = (byte)0;
                    *(src++) = (byte)0;
                    *(src++) = (byte)0;
                }
                
                if (cy - y1 < height && cx + x1 < width && cy - y1 > 0 && cx + x1 > 0)
                {
                    src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                    src += (int)((cy - y1) * (width * 3 + padding) + (cx + x1) * 3);
                    *(src++) = (byte)0;
                    *(src++) = (byte)0;
                    *(src++) = (byte)0;
                }
                
                if (cy - y1 < height && cx - x1 < width && cy - y1 > 0 && cx - x1 > 0)
                {
                    src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                    src += (int)((cy - y1) * (width * 3 + padding) + (cx - x1) * 3);
                    *(src++) = (byte)0;
                    *(src++) = (byte)0;
                    *(src++) = (byte)0;
                }
                
                if (cy - x1 < height && cx - y1 < width && cy - x1 > 0 && cx - y1 > 0)
                {
                    src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                    src += (int)((cy - x1) * (width * 3 + padding) + (cx - y1) * 3);
                    *(src++) = (byte)0;
                    *(src++) = (byte)0;
                    *(src++) = (byte)0;
                }
                
                if (cy + x1 < height && cx - y1 < width && cy + x1 > 0 && cx - y1 > 0)
                {
                    src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                    src += (int)((cy + x1) * (width * 3 + padding) + (cx - y1) * 3);
                    *(src++) = (byte)0;
                    *(src++) = (byte)0;
                    *(src++) = (byte)0;
                }
                
                if (cy + y1 < height && cx - x1 < width && cy + y1 > 0 && cx - x1 > 0)
                {
                    src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                    src += (int)((cy + y1) * (width * 3 + padding) + (cx - x1) * 3);
                    *(src++) = (byte)0;
                    *(src++) = (byte)0;
                    *(src++) = (byte)0;
                }
            }
            

            //unlock imagem origem
            imageBitmapSrc.UnlockBits(bitmapDataSrc);
        }

        private static void elipseOrdem4(int cx, int cy, int x1, int y1, Bitmap imageBitmapSrc)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;

            //lock dados bitmap origem
            BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int padding = bitmapDataSrc.Stride - (width * 3);

            unsafe
            {
                byte* src;

                if (cy + y1 < height && cx + x1 < width && cy + y1 > 0 && cx + x1 > 0)
                {
                    src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                    src += (int)((cy + y1) * (width * 3 + padding) + (cx + x1) * 3);
                    *(src++) = (byte)0;
                    *(src++) = (byte)0;
                    *(src++) = (byte)0;
                }

                if (cy - y1 < height && cx - x1 < width && cy - y1 > 0 && cx - x1 > 0)
                {
                    src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                    src += (int)((cy - y1) * (width * 3 + padding) + (cx - x1) * 3);
                    *(src++) = (byte)0;
                    *(src++) = (byte)0;
                    *(src++) = (byte)0;
                }

                if (cy - y1 < height && cx + x1 < width && cy - y1 > 0 && cx + x1 > 0)
                {
                    src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                    src += (int)((cy - y1) * (width * 3 + padding) + (cx + x1) * 3);
                    *(src++) = (byte)0;
                    *(src++) = (byte)0;
                    *(src++) = (byte)0;
                }

                if (cy + y1 < height && cx - x1 < width && cy + y1 > 0 && cx - x1 > 0)
                {
                    src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                    src += (int)((cy + y1) * (width * 3 + padding) + (cx - x1) * 3);
                    *(src++) = (byte)0;
                    *(src++) = (byte)0;
                    *(src++) = (byte)0;
                }
            }


            //unlock imagem origem
            imageBitmapSrc.UnlockBits(bitmapDataSrc);
        }

        public static void EqGeralCircunf(int cx, int cy, int x, int y, double raio, Bitmap imageBitmapSrc)
        {
            double y1;
            
            for (int x1 = 0; x1 < raio / Math.Sqrt(2); x1++)
            {
                y1 = Math.Sqrt(Math.Pow(raio, 2) - Math.Pow(x1, 2));
                circuloOrdem8(cx, cy, x1, (int)y1, imageBitmapSrc);
            }
        }

        public static void TrigonoCircunf(int cx, int cy, int x, int y, double raio, Bitmap imageBitmapSrc)
        {
            double y1, x1;

            for (double i = 0; i < raio / Math.Sqrt(2); i += 1)
            {
                y1 = Math.Sin(i);
                x1 = Math.Cos(i);
                circuloOrdem8(cx, cy, (int)x1, (int)y1, imageBitmapSrc);
            }
        }

        public static void BresenhamCircunf(int cx, int cy, int x, int y, int raio, Bitmap imageBitmapSrc)
        {
            int x1 = 0, d = 1 - raio, y1;
            int deltaE = 3;
            int deltaSE = -2 * raio + 5;


            y1 = raio;

            circuloOrdem8(cx, cy, x1, y1, imageBitmapSrc);

            while (y1 > x1)
            {
                if (d < 0)
                { 
                    d += deltaE;
                    deltaE += 2;
                    deltaSE += 2;
                }
                else
                { 
                    d += deltaSE;
                    deltaE += 2;
                    deltaSE += 4;
                    y1--;
                }
                x1++;

                circuloOrdem8(cx, cy, x1, y1, imageBitmapSrc);
            }
        }

        public static void BresenhamElipse(int cx, int cy, int a, int b, Bitmap imageBitmapSrc)
        {
            int x, y;
            double d1, d2;

            x = 0;
            y = b;
            d1 = b * b - a * a * b + a * a / 4.0;
            elipseOrdem4(cx, cy, x, y, imageBitmapSrc);

            while (a * a * (y - 0.5) > b * b * (x + 1))
            {
                if (d1 < 0)
                {
                    d1 = d1 + b * b * (2 * x + 3);
                    x++;
                }
                else
                {
                    d1 = d1 + b * b * (2 * x + 3) + a * a * (-2 * y + 2);
                    x++;
                    y--;
                }
                elipseOrdem4(cx, cy, x, y, imageBitmapSrc);
            }

            d2 = b * b * (x + 0.5) * (x + 0.5) + a * a * (y - 1) * (y - 1) - a * a * b * b;

            while (y > 0)
            {
                if (d2 < 0)
                {
                    d2 = d2 + b * b * (2 * x + 2) + a * a * (-2 * y + 3);
                    x++;
                    y--;
                }
                else
                {
                    d2 = d2 + a * a * (-2 * y + 3);
                    y--;
                }
                elipseOrdem4(cx, cy, x, y, imageBitmapSrc);
            }
        }
    }
}
