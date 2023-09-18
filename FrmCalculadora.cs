namespace Calculadora_UTN
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            radDecimal.Checked = true;

            cboxOperador.Items.AddRange(new Object[] { '+', '-', '*', '/' });
            cboxOperador.SelectedIndex = 0;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Resultado: ";
            txtOperandoUno.Text = string.Empty;
            txtOperandoDos.Text = string.Empty;
            
        }
    }
}