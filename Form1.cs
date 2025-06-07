namespace Laboratorio_2.git_hub
{

    public partial class Form1 : Form
    {
        string nombre = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        public void validarnombre()
        {
            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                lblmensaje.Text = " Por favor, ingrese un nombre.";
                lblmensaje.ForeColor = Color.Red;
            }
            else if (ltx.Items.Contains(nombre))
            {
                lblmensaje.Text = " Ya existe un nombre";
                lblmensaje.ForeColor = Color.Black;
            }
            else
            {
                lblmensaje.Text = " El nombre ha sido guardado correctamente.";
                lblmensaje.ForeColor = Color.Black;
                nombre = txtnombre.Text;
                ltx.Items.Add(nombre);
            }
        }
        public void agregarprecios()
        {
            int[] precios = { 5000, 10000, 8000, 4000, 6750 };
            int lugar = cbxseleccionar.SelectedIndex;
            int valor = precios[lugar];
            lblmensaje.Text = " El servicio se agrego correctamente ";
            lblmensaje.ForeColor = Color.Black;
            ltx.Items.Add($"{cbxseleccionar.SelectedItem} - ¢{valor}");
        }

        public void seleccioncbx()
        {
            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                validarnombre();
            }
            else if (cbxseleccionar.SelectedItem == null)
            {
                lblmensaje.Text = "Por favor, seleccione un servicio.";
                lblmensaje.ForeColor = Color.Red;
            }
            else
            {
                agregarprecios();
            }
        }
        public void salirdetodo ()
        {
            this.Close();
        }

        private void btnnombre_Click(object sender, EventArgs e)
        {
            validarnombre();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            seleccioncbx();

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            salirdetodo();
        }
    }
}
