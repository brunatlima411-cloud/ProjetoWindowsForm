namespace Form1
{

    public partial class FrmImc : Form
    {

        float imc;

        public FrmImc()
        {
            InitializeComponent();
        }

        private float MetodoImc(float peso, float altura)
        {
            imc = peso / (altura * altura);
            return imc;
        }

        private void btnImc_Click(object sender, EventArgs e)
        {
            float peso;
            float altura;


            if (!float.TryParse(txtPeso.Text, out peso))            

                {
                    MessageBox.Show("digite um peso válido.");
                    return;
                }
                if (!float.TryParse(txtAltura.Text, out altura))

                {
                    MessageBox.Show("digite uma altura válida.");
                    return;
                }

                MetodoImc(peso, altura);



                string tipoimc;

                switch (imc)

                {
                    case >= 40:
                        tipoimc = "Obesidade III";
                        break;
                    case >= 35:
                        tipoimc = "Obesidade II";
                        break;
                    case >= 30:
                        tipoimc = "Obesidade I";
                        break;
                    case >= 25:
                        tipoimc = "Levemente acima do peso";
                        break;
                    case >= 18:
                        tipoimc = "Peso Ideal";
                        break;
                    default:
                        tipoimc = "Abaixo do peso";
                        break;
                }

                MessageBox.Show($"{imc:F2} Grau {tipoimc}");
            }


        }
            
        }
