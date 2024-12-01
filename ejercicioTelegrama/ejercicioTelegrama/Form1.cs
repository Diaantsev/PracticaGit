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
            if (chkUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }
            //Obtengo el n�mero de palabras que forma el telegrama
            numPalabras = textoTelegrama.Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
            //Si el telegrama es ordinario
            if (tipoTelegrama == '')
            {
                if (numPalabras <= 10)
                {
                    coste = 2.5;
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
                        coste = 5;
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
