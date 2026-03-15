namespace Calculadora_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adicao_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(num1.Text);
            double numero2 = Convert.ToDouble(num2.Text);
            double resultado = (numero1 + numero2);
            labresultado.Text = resultado.ToString("F2");
            labresultado.Text = ("Resultado: " + resultado);
        }

        private void subt_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(num1.Text);
            double numero2 = Convert.ToDouble(num2.Text);
            double resultado = (numero1 - numero2);
            labresultado.Text = resultado.ToString("F2");
            labresultado.Text = ("Resultado: " + resultado);
        }

        private void multi_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(num1.Text);
            double numero2 = Convert.ToDouble(num2.Text);
            double resultado = (numero1 * numero2);
            labresultado.Text = resultado.ToString("F2");
            labresultado.Text = ("Resultado: " + resultado);
        }

        private void div_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(num1.Text);
            double numero2 = Convert.ToDouble(num2.Text);
            double resultado = (numero1 / numero2);
            labresultado.Text = resultado.ToString("F2");
            labresultado.Text = ("Resultado: " + resultado);
        }
    }
}
