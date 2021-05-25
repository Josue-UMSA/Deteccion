using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deteccion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'seccionDataSet.color' Puede moverla o quitarla según sea necesario.
            this.colorTableAdapter.Fill(this.seccionDataSet.color);
            // TODO: esta línea de código carga datos en la tabla 'seccionDataSet.seccion' Puede moverla o quitarla según sea necesario.
            this.seccionTableAdapter.Fill(this.seccionDataSet.seccion);

        }

        private void cargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dia = new OpenFileDialog();
            dia.ShowDialog();
            string imagen = dia.FileName;
            original.Image = Image.FromFile(imagen);
            pictureBox.Image = Image.FromFile(imagen);
            clasificar.Enabled = true;
            seccion.Enabled = true;
            Bitmap x = new Bitmap(original.Image);
            progressBar1.Maximum=x.Width;
        }

        private void clasificar_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            Bitmap bmp = new Bitmap(original.Image);
            Bitmap resultado = new Bitmap(original.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width,bmp.Height);
            Color c = new Color();
            foreach (DataRow r in seccionDataSet.color.Rows)
            {
                if (r[1].ToString()==seccion.SelectedValue.ToString())
                {
                    int cR = int.Parse(r[2].ToString());
                    int cG = int.Parse(r[3].ToString());
                    int cB = int.Parse(r[4].ToString());
                    Bitmap bmpAux = new Bitmap(bmp.Width, bmp.Height);
                    int cRto, cGto, cBto;
                    for (int i = 0; i < bmp.Width - 10; i = i + 10) { 
                        for (int j = 0; j < bmp.Height - 10; j = j + 10)
                        {

                            cRto = 0; cGto = 0; cBto = 0;
                            for (int k = i; k < i + 10; k++)
                                for (int l = j; l < j + 10; l++)
                                {
                                    c = bmp.GetPixel(k, l);
                                    cRto = c.R + cRto; cGto = c.G + cGto; cBto = c.B + cBto;
                                }
                            cRto = cRto / 100;
                            cGto = cGto / 100;
                            cBto = cBto / 100;
                            c = bmp.GetPixel(i, j);
                            if (((cR - 10 <= cRto) && (cRto <= cR + 10)) && ((cGto - 10 <= cG) && (cG <= cGto + 10)) && ((cBto - 10 <= cB) && (cB <= cBto + 10))) { 
                                for (int k = i; k < i + 10; k++) { 
                                    for (int l = j; l < j + 10; l++)
                                    {
                                        bmpAux.SetPixel(k, l, Color.Black);


                                    }
                                }
                            }else { 
                                for (int k = i; k < i + 10; k++) {
                                    for (int l = j; l < j + 10; l++)
                                    {
                                        bmpAux.SetPixel(k, l, Color.FromArgb(0, 0, 0, 0));
                                    }
                                }
                            }
                        }
                    }
                    /* for (int i = 0; i < bmp.Width; i++) { 
                         for (int j = 0; j < bmp.Height; j++)
                         {
                             c = bmp.GetPixel(i, j);
                             int cRto, cGto, cBto;
                             if ((cR - 10 <= c.R && c.R <= cR + 10) && (cG - 10 <= c.G && c.G <= cG + 10) && (cB - 10 <= c.B && c.B <= cB + 10))
                                 bmpAux.SetPixel(i, j, FromArgb(0, 0, 0, 0));
                             else
                                 bmpAux.SetPixel(i, j, Color.Black);
                         }
                     }*/
                    using (Graphics g = Graphics.FromImage(bmp2))
                    {
                        g.DrawImage(bmpAux, Point.Empty);
                    }
                    for (int i = 0; i < bmp2.Width; i++)
                    {
                        for (int j = 0; j < bmp2.Height; j++)
                        {
                            if (bmp2.GetPixel(i,j) == Color.FromArgb(0,0,0,0))
                            {
                                bmp2.SetPixel(i, j, Color.White);
                            }
                        }
                    }  
                }
            }
            bmp2 = Bordes(bmp2);
            using (Graphics g = Graphics.FromImage(resultado))
            {
                g.DrawImage(bmp2, Point.Empty);
            }

            pictureBox.Image = resultado;
        }

        Bitmap Bordes(Bitmap imagen)
        {
            int M = imagen.Width;
            int N = imagen.Height;
            int[,] Kh = new int[,] { { -1, 0, 1 }, { -1, 0, 1 }, { -1, 0, 1 } };
            int[,] Kv = new int[,] { { -1, -1, -1 }, { 0, 0, 0 }, { 1, 1, 1 } };
            for (int x = 0; x < M; x++)
            {
                progressBar1.PerformStep();
                for (int y = 0; y < N; y++)
                {
                    int sx = mulMatriz(imagen, x, y, Kh);
                    int sy = mulMatriz(imagen, x, y, Kv);


                    double gx = Math.Pow(sx / 9, 2);
                    double gy = Math.Pow(sy / 9, 2);
                    int g = (int)(Math.Sqrt(gx + gy));

                    if (g > 0)
                    {
                        imagen.SetPixel(x, y, Color.Red);
                    }
                    else
                    {
                        imagen.SetPixel(x, y, Color.FromArgb(0, 0, 0, 0));
                    }

                }
            }
            return imagen;
        }

        int mulMatriz(Bitmap imagen, int x, int y, int[,] mascara)
        {
            int s = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if ((x + i) < imagen.Width && (y + j) < imagen.Height)
                    {

                        s += imagen.GetPixel(x + i, y + j).R * mascara[i, j];
                    }
                    else
                    {
                        s += 0;
                    }
                }
            }
            return s;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox.Height += 40;
            pictureBox.Width += 40;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox.Height > 50)
            {
                pictureBox.Height -= 40;
                pictureBox.Width -= 40;
            }
        }
    }
}
