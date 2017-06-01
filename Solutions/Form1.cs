using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solutions
{
 

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
           
            Glob.n1 = Convert.ToDouble(painel.Text);
            Glob.hop = 1;
            painel.Text += "+";
            Glob.status = 2;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menos_Click(object sender, EventArgs e)
        {
            Glob.n1 = Convert.ToDouble(painel.Text);
            Glob.hop = 2;
            painel.Text += "-";
            Glob.status = 2;
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            Glob.n1 = Convert.ToDouble(painel.Text);
            Glob.hop = 3;
            painel.Text += "÷";
            Glob.status = 2;
        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {
            Glob.n1 = Convert.ToDouble(painel.Text);
            Glob.hop = 4;
            painel.Text += "x";
            Glob.status = 2;
        }

        private void clean_Click(object sender, EventArgs e)
        {
            Glob.n1 = 0;
            Glob.n2 = 0;
            painel.Clear();
            Glob.status = 1;
        }

        private void Resultado_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Glob.status==1)
            painel.Text += "1";
            else
            {
                painel.Clear();
                painel.Text += "1";
                Glob.status = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Glob.status==1)
            painel.Text += "2";
            else
            {
                painel.Clear();
                painel.Text += "2";
                Glob.status = 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Glob.status == 1)
                painel.Text += "3";
            else
            {
                painel.Clear();
                painel.Text += "3";
                Glob.status = 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Glob.status == 1)
                painel.Text += "4";
            else
            {
                painel.Clear();
                painel.Text += "4";
                Glob.status = 1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Glob.status == 1)
                painel.Text += "5";
            else
            {
                painel.Clear();
                painel.Text += "5";
                Glob.status = 1;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Glob.status == 1)
                painel.Text += "6";
            else
            {
                painel.Clear();
                painel.Text += "6";
                Glob.status = 1;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Glob.status == 1)
                painel.Text += "7";
            else
            {
                painel.Clear();
                painel.Text += "7";
                Glob.status = 1;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Glob.status == 1)
                painel.Text += "8";
            else
            {
                painel.Clear();
                painel.Text += "8";
                Glob.status = 1;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Glob.status == 1)
                painel.Text += "9";
            else
            {
                painel.Clear();
                painel.Text += "9";
                Glob.status = 1;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Glob.status == 1)
                painel.Text += "0";
            else
            {
                painel.Clear();
                painel.Text += "0";
                Glob.status = 1;
            }
        }


        private void button11_Click(object sender, EventArgs e)
        {
            Glob.n2 = Convert.ToDouble(painel.Text);
            double res=0;
            Glob.status = 1;

            //Soma
            if (Glob.hop == 1)
            {
                res = Glob.n1 + Glob.n2;
            }
            //subtracao
            else if (Glob.hop == 2)
            {
                res = Glob.n1 - Glob.n2;
            }
            //divisao
            else if (Glob.hop == 3)
            {
                res = Glob.n1 / Glob.n2;
            }
            //Multiplicação
            else if (Glob.hop == 4)
            {
                res = Glob.n1 * Glob.n2;
            }
            painel.Text = Convert.ToString(res);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            painel.Text += ",";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double res = 0;

            double n1 = Convert.ToDouble(painel.Text);
            res = n1*n1;
            painel.Text =Convert.ToString(res);
           

        }

        private void button14_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(painel.Text);
            double res = Math.Sqrt(Convert.ToDouble(n1));
            painel.Text = Convert.ToString(res);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double res = 0;
            Glob.n1 = Convert.ToDouble(painel.Text);
            res = Glob.n1/2;
            painel.Text = Convert.ToString(res);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double res = 0;
            double n1 = Convert.ToDouble(painel.Text);
            res = n1/100;
            painel.Text = Convert.ToString(res);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double res = 0;
            res = Fat.fat(Convert.ToDouble(painel.Text));
            painel.Text = Convert.ToString(res);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            painel.Text = "Daniel(2215102089) / Gerson(2215101344)";
        }
    }
}
