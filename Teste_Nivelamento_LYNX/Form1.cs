using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_Nivelamento_LYNX
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        // Trantando o evento de click do Desafio 1
        private void button1_Click(object sender, EventArgs e)
        {
            
            // Identificando se foi digitado um valor inteiro

            if (int.TryParse(textBox1.Text, out int Pecas_OUT))
            {
                // Executando a formula para descobrir o numero de peças

                Pecas_OUT = ((Pecas_OUT + 1) * (Pecas_OUT + 2)) / 2;
                textBox2.Text = Pecas_OUT.ToString();
            }
            else
            {
                // Solicitando ao usuario que insira um valor inteiro

                MessageBox.Show("Por favor, insira um valor inteiro válido.");
            }

              
        }



        // Trantando o evento de click do Desafio 2
        private void button2_Click(object sender, EventArgs e)
        {
            float Valor_S = 0,
                  Aux_Den = 0;

            // Identificando se foi digitado um valor inteiro

            if (int.TryParse(textBox3.Text, out int Denominador))
            {
                // Denominador é o ultimo denominador de fração da serie escolhida
                // para caso queremos um somatorio de frações maiores ou menores
                // Assim executamos o calculo do somatorio ate a ultima fração ser 1
             
                while (Denominador > 0)
                {
                    Aux_Den = Denominador;
                    Valor_S = Valor_S + (1 / Aux_Den);
                    Denominador--;
                }

                textBox4.Text = Valor_S.ToString("N2");
            }
            else
            {
                // Solicitando ao usuario que insira um valor inteiro

                MessageBox.Show("Por favor, insira um valor inteiro válido.");
            }
        }




        // Trantando o evento de click do Desafio 3
        private void button3_Click(object sender, EventArgs e)
        {

            int Hora_Chegada = 0;

            // Identificando se foi digitado um valor inteiro

            if ((int.TryParse(textBox5.Text, out int Hora_Saida))
                && (int.TryParse(textBox6.Text, out int TIME_Viagem))
                && (int.TryParse(textBox7.Text, out int Delta_Fuso)))
            {

                // Identificando se foi digitado um valor dentro dos limites

                if ((Hora_Saida  <= 23) && (Hora_Saida  >=  0)
                    && (TIME_Viagem <= 12) && (TIME_Viagem >=  1)
                    && (Delta_Fuso  <=  5) && (Delta_Fuso  >= -5))
                {

                    // Calculando a hora de chegada

                    Hora_Chegada = Hora_Saida + TIME_Viagem + Delta_Fuso;
                    if(Hora_Chegada > 23)
                    {
                        // Caso a hora ulltrapasse para o proximo dia
                        // Colocar no padrao de 24 horas

                        Hora_Chegada = Hora_Chegada - 24;
                    }

                    textBox8.Text = Hora_Chegada.ToString();
                }
                else
                {

                    // Valores não estão dentro dos limites

                    MessageBox.Show("Por favor, a hora de saída deve corresponder de 0 a 23,"
                                   + " o tempo de viagem de 1 a 12,"
                                   + " e o fuso horário de -5 a 5.");
                }
             
            }
            else
            {
                // Solicitando ao usuario que insira um valor inteiro

                MessageBox.Show("Por favor, insira um valor inteiro válido.");
            }

        }



    }
}
