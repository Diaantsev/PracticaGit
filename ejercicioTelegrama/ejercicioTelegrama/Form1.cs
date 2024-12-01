namespace ejercicioTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras = 0;
            double coste;
            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            if (radioUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }
            else if (radioOrdinario.Checked)
            {
                tipoTelegrama = ' ';
            }
            else {
                MessageBox.Show("Por favor, selecciona la urgencia del telegrama");
                return;
            }
            //Obtengo el número de palabras que forma el telegrama
            numPalabras = textoTelegrama.Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
            //Si el telegrama es ordinario
            if (tipoTelegrama == ' ')
            {
                if (numPalabras <= 10)
                {
                    coste = 3;
                }
                else
                {
                    coste = ((numPalabras - 10) * 0.5) + 2.5;
                }
            }
            else
            //Si el telegrama es urgente
            {
                if (tipoTelegrama == 'u')
                {
                    if (numPalabras <= 10)
                    {
                        coste = 6;
                    }
                    else
                    {
                        coste = 5 + 0.75 * (numPalabras - 10);
                    }
                }
                else
                {
                    coste = 0;
                }
            }
            txtPrecio.Text = coste.ToString() + " euros";
        }
    } 
}
