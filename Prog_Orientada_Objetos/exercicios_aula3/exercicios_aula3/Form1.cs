using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicios_aula3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int contador,
            delta_x = 1,
            delta_y = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            // definir tamanho do form
            int W = this.Size.Width - 15,
                H = this.Size.Height - 30;
            // definir tamanho do picturebox
            int w = pictureBox1.Size.Width,
                h = pictureBox1.Size.Height;
            // definir localização do picturebox
            int x = pictureBox1.Location.X,
                y = pictureBox1.Location.Y;

            x = x + delta_x;
            y = y + delta_y;

            // verifica se a imagem passou da direita ou da esquerda do form
            if ((x > (W - w)) || (x < 0))
            {
                delta_x = -delta_x;
            }
            // verifica se a imagem passou da parte de baixo ou de cima do form
            if ((y > (H - h)) || (y < 0))
            {
                delta_y = -delta_y;
            }
            // atualiza a localização da imagem
            else
            {
                pictureBox1.Location = new Point(x, y);
            }
        }
    }
}
