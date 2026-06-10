namespace CalculadoraUTEC
{
    public partial class Form1 : Form
    {
        double primerNumero = 0;
        double segundoNumero = 0;
        string operacion = "";
        bool trackingOperacion = false;
        bool hayOperacionPendiente = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPantalla.ReadOnly = true;
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
            Button boton = (Button)sender;


            if (lblHistorial.Text.Contains("="))
            {
                lblHistorial.Text = primerNumero.ToString() + " " + boton.Text + " ";
            }
            else if (hayOperacionPendiente && !trackingOperacion)
            {
                lblHistorial.Text += txtPantalla.Text + " " + boton.Text + " ";
                EjecutarOperacion();
            }
            else if (!trackingOperacion)
            {
                lblHistorial.Text = txtPantalla.Text + " " + boton.Text + " ";
                primerNumero = Convert.ToDouble(txtPantalla.Text);
            }
            else
            {
                lblHistorial.Text = lblHistorial.Text.Substring(0, lblHistorial.Text.Length - 2) + boton.Text + " ";
            }

            operacion = boton.Text;
            trackingOperacion = true;
            hayOperacionPendiente = true;
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (!hayOperacionPendiente) return;

            lblHistorial.Text += txtPantalla.Text + " =";

            EjecutarOperacion();

            hayOperacionPendiente = false;
        }

        private void EjecutarOperacion()
        {
            segundoNumero = Convert.ToDouble(txtPantalla.Text);
            double resultado = 0;

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
                        btnBorrar_Click(null, null);
                        return;
                    }
                    break;
                default:
                    return;
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
            hayOperacionPendiente = false;
            txtPantalla.Text = "0";
            lblHistorial.Text = "";
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            Form2 calculadoraGuia = new Form2();
            calculadoraGuia.StartPosition = FormStartPosition.Manual;
            calculadoraGuia.Location = this.Location;
            calculadoraGuia.Show();
            this.Hide();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }
    }
};
