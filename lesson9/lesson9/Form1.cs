using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            Random R = new Random();
            int[,] mas = new int[5, 3];
            int max = 0, flag = 0, summa = 0;
            for (int i = 0; i < 5; i++)
            {
                summa = 0;
                for (int j = 0; j < 3; j++)
                {
                    mas[i, j] = R.Next(10, 100);
                    summa += mas[i, j];
                    richTextBox1.Text += mas[i, j] + " ";
                }
                if (summa > max)
                {
                    max = summa;
                    flag = i;
                }
                richTextBox1.Text += "\n";
            }
            richTextBox1.Text += "\nМаксимальная сумма в " + (flag + 1) + "строке" + "\n";
            for (int j = 0; j < 3; j++)
            {
                richTextBox1.Text += mas[flag, j] + " ";
            }






            for (int j = 0; j < 3; j++)
            {
                summa = 0;
                for (int i = 0; i < 5; i++)
                {
                    summa += mas[i, j];

                }
                if (summa > max)
                {
                    max = summa;
                    flag = j;
                }

            }
            richTextBox1.Text += "\nМаксимальная сумма в " + (flag + 1) + " столбце" + "\n";
            for (int j = 0; j < 5; j++)
            { richTextBox1.Text += mas[j, flag] + "\n"; }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            Random R = new Random();
            int[,] mas = new int[5, 5];
            int summa = 0;
            for (int i = 0; i < 5; i++)
            {
                summa = 0;
                for (int j = 0; j < 5; j++)
                {
                    mas[i, j] = R.Next(10, 100);
                    richTextBox1.Text += mas[i, j] + " ";

                }
                richTextBox1.Text += "\n";
                

            }
            summa = 0;
            for(int i=0;i<5;i++)
            {
                summa += mas[i, i];
                

            }
            richTextBox1.Text += "\nСумма - "+ summa;

            summa = 0;
            for (int i = 0; i < 5; i++)
            {
                summa += mas[i,4-i];
            }
            richTextBox1.Text += "\nСумма -" + summa;
        } 
    }
}
