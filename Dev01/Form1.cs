using System.Diagnostics.CodeAnalysis;

namespace Dev01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 5;



            int Suma = a + b;
            textBox1.Text = Suma.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 5;



            int Restar = a + b;
            textBox2.Text = Restar.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 5;



            int Multiplicar = a + b;
            textBox3.Text = Multiplicar.ToString();
        }
    }
}
