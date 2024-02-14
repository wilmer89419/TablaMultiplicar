namespace TablaMultiplicar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int Numero;
            Numero = int.Parse(txtNumero.Text);

            for (int i = 1; i <= 12; i++)
            {
                int resultado = Numero * i;
                // Agregar la multiplicación al ListBox
                lstResultadoMultiplicacion.Items.Add($"{Numero} x {i} = {resultado}");





            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstResultadoMultiplicacion.Items.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
