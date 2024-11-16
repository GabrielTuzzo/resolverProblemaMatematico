using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ex61Basico
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int numContagem = 0;
        int respostaCorreta;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            int num1 = r.Next(1, 11);
            int num2 = r.Next(1, 11);
            respostaCorreta = num1 + num2;
            numContagem++;

            label1.Text = $"{num1} + {num2} =";
            textBox1.Clear();
            textBox1.Focus();

            if (numContagem > 10)
            {
                MessageBox.Show("Parab�ns! Voc� concluiu os problemas de adi��o.");
                this.Close();
            }

            listBox1.Items.Add($"Problema {numContagem}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);

            if (a == respostaCorreta)
            {
                listBox2.Items.Add("Parab�ns! O resultado est� correto.");
            }
            else
            {
                listBox2.Items.Add("O resultado est� incorreto.");
                listBox2.Items.Add($"A resposta correta � {respostaCorreta}.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}