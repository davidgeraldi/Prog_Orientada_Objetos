using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio2_aula3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random moeda = new Random();

        int contador = 0; // contador para controlar o número de vezes que a moeda gira
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start(); // ao clicar no botão inicia o timer para girar a moeda

        }

        private void resultado()
        {
            int result = moeda.Next(2);

            if (result == 0)
            {
                if (cara.Checked)
                {
                    MessageBox.Show("Você ganhou!");
                }
                else
                {
                    MessageBox.Show("Você perdeu!");
                }
            }

            if (result == 1)
            {
                if (coroa.Checked)
                {
                    MessageBox.Show("Você ganhou!");
                }
                else
                {
                    MessageBox.Show("Você perdeu!");
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(contador);
            //innverter com a outra imagem:
            if (pictureBoxCara.Visible)
            {
                pictureBoxCara.Visible = false;
                pictureBoxCoroa.Visible = true;
            }
            else
            {
                pictureBoxCara.Visible = true;
                pictureBoxCoroa.Visible = false;
            }
            contador++; // incrementa o contador a cada tick do timer
            timer1.Interval += 30;

            if (timer1.Interval >= 350)
            {
                timer1.Stop();
                contador = 0;
                resultado();
            }

        }
    }
}
