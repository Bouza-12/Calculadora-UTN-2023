using Entidades;

namespace Calculadora_UTN
{
    public partial class FrmCalculadora : Form
    {

        private Operacion? calculadora;
        private Numeracion primerOperando;
        private Numeracion segundoOperando;
        private Numeracion? resultado;
        private ESistema sistema;

        public FrmCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Confirmación para cerrar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Desea cerrar la calculadora?", "Cerrar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Inicializa los objetos del forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            //radDecimal.Checked = true;
            this.sistema = ESistema.Decimal;
            cboxOperador.Items.AddRange(new Object[] { '+', '-', '*', '/' });
            cboxOperador.SelectedIndex = 0;
        }

        /// <summary>
        /// Restarua por defecto los valores del Forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Resultado: ";
            txtOperandoUno.Text = string.Empty;
            txtOperandoDos.Text = string.Empty;
            cboxOperador.SelectedIndex = 0;
            radDecimal.Checked = true;
        }

        private void setResultado()
        {
            if (this.sistema != null)
            {
                primerOperando = new Numeracion(txtOperandoUno.Text, ESistema.Decimal);
                segundoOperando = new Numeracion(txtOperandoDos.Text, ESistema.Decimal);
                calculadora = new Operacion(this.primerOperando, this.segundoOperando);
                if(txtOperandoDos.Text == "0" && cboxOperador.Text == "/")
                {
                    MessageBox.Show("No se puede dividir por 0", "División por cero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtOperandoUno is not null && txtOperandoDos is not null && cboxOperador is not null)
                {
                    this.resultado = calculadora.Operar(cboxOperador.Text.ToCharArray()[0]);

                    if (this.sistema == ESistema.Decimal)
                    {
                        lblResultado.Text = $"Resultado: {resultado.ValorNumerico}";
                    }
                    else
                    {
                        
                        lblResultado.Text = $"Resultado: {resultado.ConvertirA(ESistema.Binario)}";

                    }
                }
            }
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            this.setResultado();
        }

        private void radBinario_CheckedChanged(object sender, EventArgs e)
        {
            this.sistema = ESistema.Binario;
            if (txtOperandoDos is not null && txtOperandoUno is not null)
            {
                this.setResultado();
            }
        }

        private void radDecimal_CheckedChanged(object sender, EventArgs e)
        {
            this.sistema = ESistema.Decimal;
            if(txtOperandoDos is not null && txtOperandoUno is not null)
            {
            this.setResultado();
            }

        }
    }
}