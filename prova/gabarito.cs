using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prova
{
    public partial class Gabarito : Form
    {
        public Gabarito()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] array = new string[10];
            array[0] = "A";
            array[1] = "B";
            array[2] = "C";
            array[3] = "D";
            array[4] = "E";
            array[6] = "A";
            array[7] = "B";
            array[8] = "C";
            array[9] = "D";
            array[10] = "A";

            for (int i = 0; i < array.Length; i++)
            {
                MessageBox.Show(array[i]);
            }
            string armazenar0 = array[0];
            string armazenar1 = array[1];
            string armazenar2 = array[2];
            string armazenar3 = array[3];
            string armazenar4 = array[4];
            string armazenar5 = array[5];
            string armazenar6 = array[6];
            string armazenar7 = array[7];
            string armazenar8 = array[8];
            string armazenar9 = array[9];
            string armazenar10 = array[10];


            if(tx_avaliacao.Text == armazenar0)
            {
                MessageBox.Show("esta certo");
            }
            else if(tx_avaliacao.Text != armazenar1)
            {
                MessageBox.Show("esta errado");      
            }
            if (tx_avaliacao.Text == armazenar2)
            {
                MessageBox.Show("esta certo");
            }
            else if (tx_avaliacao.Text != armazenar3)
            {
                MessageBox.Show("esta errado");
            }
            if (tx_avaliacao.Text == armazenar4)
            {
                MessageBox.Show("esta certo");
            }
            else if (tx_avaliacao.Text != armazenar5)
            {
                MessageBox.Show("esta errado");
            }
            if (tx_avaliacao.Text == armazenar6)
            {
                MessageBox.Show("esta certo");
            }
            else if (tx_avaliacao.Text != armazenar7)
            {

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           if(textBox1.Text == armazenar)

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
