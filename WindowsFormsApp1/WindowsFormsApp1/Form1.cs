using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class divisao : Form
    {
        double a;
        double b;
        double c;
        string funcao = "";
        string num1 = "";
        string num2 = "";
        
        public divisao()
        {
            InitializeComponent();


           // barra.Text = "";
          //  barra2.Text = "";



        }

        

        private void um_Click(object sender, EventArgs e)
        {


            if (a == 0)
            {
                num1 += "1";
                barrinha.Text = num1;

            }
            else
            {
                num2 += "1";
                barrinha.Text = num2;
            }

           
        }

        private void dois_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                num1 += "2";
                barrinha.Text = num1;

            }
            else
            {
                num2 += "2";
                barrinha.Text = num2;
            }
        }

        private void tres_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                num1 += "3";
                barrinha.Text = num1;

            }
            else
            {
                num2 += "3";
                barrinha.Text = num2;
            }
        }

        private void quatro_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                num1 += "4";
                barrinha.Text = num1;

            }
            else
            {
                num2 += "4";
                barrinha.Text = num2;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                num1 += "5";
                barrinha.Text = num1;

            }
            else
            {
                num2 += "5";
                barrinha.Text = num2;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                num1 += "6";
                barrinha.Text = num1;

            }
            else
            {
                num2 += "6";
                barrinha.Text = num2;
            }
        }

        private void sete_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                num1 += "7";
                barrinha.Text = num1;

            }
            else
            {
                num2 += "7";
                barrinha.Text = num2;
            }
        }

        private void oito_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                num1 += "8";
                barrinha.Text = num1;

            }
            else
            {
                num2 += "8";
                barrinha.Text = num2;
            }
        }

        private void nove_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                num1 += "9";
                barrinha.Text = num1;

            }
            else
            {
                num2 += "9";
                barrinha.Text = num2;
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                num1 += "0";
                barrinha.Text = num1;

            }
            else
            {
                num2 += "0";
                barrinha.Text = num2;
            }
        }

        private void x_Click(object sender, EventArgs e)
        {
            if (funcao == "")
            {
                funcao = "*";
            }
            a = double.Parse(num1);



            // c = a * b;
            // barra.Text = c.ToString();
        }

        private void mais_Click(object sender, EventArgs e)
        {
            if (funcao == "")
            {
                funcao = "+";
            }
            a = double.Parse(num1);
            
            


           // c = a + b;
           //barra.Text = c.ToString();

        }

        private void menos_Click(object sender, EventArgs e)
        {
            if (funcao == "")
            {
                funcao = "-";
            }
            a = double.Parse(num1);

            // c = a - b;
            //barra.Text = c.ToString();
        }

        private void virgula_Click(object sender, EventArgs e)
        {
            if(a==0)
            {
                num1 += ",";
                barrinha.Text = num1;

            }
            else
            {
                num2 += ",";
                barrinha.Text = num2;
            }
        }

        private void barra_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void barra2_TextChanged(object sender, EventArgs e)
        {
          


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (funcao == "")
            {
                funcao = "/";
            }


            a = double.Parse(num1);

            // c = a / b;
            // barra.Text = c.ToString();

        }

        private void CE(object sender, EventArgs e)
        {
            barrinha.Text = "";
            barra.Text = "";
            barra2.Text = "";
            funcao = "";
            num1 = "";
            num2 = "";

            a = 0;
            b = 0;  

           

        }

        private void igual_Click(object sender, EventArgs e)
        {

            if (funcao == "+")
            {
                b = double.Parse(num2);
                c = a + b;
            }
            if (funcao == "-")
            {
                b = double.Parse(num2);
                c = a - b;
            }
            if (funcao == "*")
            {
                b = double.Parse(num2);
                c = a * b;
            }
            if (funcao=="/")
            {
                b = double.Parse(num2);
                c = a / b;
            }
            if(funcao=="√")
            {
                a = double.Parse(num1);

                c = a;

            }
            barrinha.Text = c.ToString();

        }

        private void barrinha_TextChanged(object sender, EventArgs e)
        {

        }

        private void raiz_Click(object sender, EventArgs e)
        {
            if (funcao == "")
            {
                funcao = "√";
            }
            a = double.Parse(num1);
        }
    }
}
