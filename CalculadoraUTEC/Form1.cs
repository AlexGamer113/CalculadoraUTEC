namespace CalculadoraUTEC
{
    public partial class Form1 : Form
    {
        double primerNumero = 0;
        double segundoNumero = 0;
        string operacion = "";
        bool trackingOperacion = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0" || trackingOperacion)
            {
                txtPantalla.Clear();
            }

            trackingOperacion = false;

            Button boton = (Button)sender;
            txtPantalla.Text += boton.Text;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            primerNumero = Convert.ToDouble(txtPantalla.Text);
            Button boton = (Button)sender;
            operacion = boton.Text;
            trackingOperacion = true;
            lblHistorial.Text = primerNumero.ToString() + " " + operacion;
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            segundoNumero = Convert.ToDouble(txtPantalla.Text);
            double resultado = 0;

            lblHistorial.Text += " " + segundoNumero.ToString() + " =";

            switch (operacion)
            {
                case "+":
                    resultado = primerNumero + segundoNumero;
                    break;
                case "-":
                    resultado = primerNumero - segundoNumero;
                    break;
                case "X":
                    resultado = primerNumero * segundoNumero;
                    break;
                case "/":
                    if (segundoNumero != 0)
                    {
                        resultado = primerNumero / segundoNumero;
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir por cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPantalla.Text = "0";
                        return;
                    }
                    break;
            }

            txtPantalla.Text = resultado.ToString();
            primerNumero = resultado;
            trackingOperacion = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            primerNumero = 0;
            segundoNumero = 0;
            operacion = "";
            trackingOperacion = false;
            txtPantalla.Text = "0";
            lblHistorial.Text = "";
        }
    }
}
