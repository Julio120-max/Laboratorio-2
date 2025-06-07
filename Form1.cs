using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Laboratorio_2.git_hub
{

    public partial class Form1 : Form
    {
        string nombre = string.Empty;
<<<<<<< HEAD
        int[] precios = { 5000, 10000, 8000, 4000, 6750 };
        List<int> valores = [];
=======
>>>>>>> 0c735cc311d78ab34d530ad2843047469e4ec8b8

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
<<<<<<< HEAD
            else if (ltxservicios.Items.Contains(nombre))
=======
            else if (ltx.Items.Contains(nombre))
>>>>>>> 0c735cc311d78ab34d530ad2843047469e4ec8b8
            {
                lblmensaje.Text = " Ya existe un nombre";
                lblmensaje.ForeColor = Color.Black;
            }
            else
            {
                lblmensaje.Text = " El nombre ha sido guardado correctamente.";
                lblmensaje.ForeColor = Color.Black;
                nombre = txtnombre.Text;
<<<<<<< HEAD
                ltxservicios.Items.Add(nombre);
            }
        }
        public void validarservicio()
        {
            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                validarnombre();
            }
            else if (cbxseleccionar.SelectedItem == null)
            {
                lblmensaje.Text = "Por favor selecciones un servicio.";
                lblmensaje.ForeColor = Color.Red;
=======
                ltx.Items.Add(nombre);
>>>>>>> 0c735cc311d78ab34d530ad2843047469e4ec8b8
            }
        }
        public void agregarprecios()
        {
<<<<<<< HEAD
            int lugar = cbxseleccionar.SelectedIndex;
            int valor = precios[lugar];
            valores.Add(precios[lugar]);
            lblmensaje.Text = " El servicio se agrego correctamente ";
            lblmensaje.ForeColor = Color.Black;
            ltxservicios.Items.Add($"{cbxseleccionar.SelectedItem} - ¢{valor}");
=======
            int[] precios = { 5000, 10000, 8000, 4000, 6750 };
            int lugar = cbxseleccionar.SelectedIndex;
            int valor = precios[lugar];
            lblmensaje.Text = " El servicio se agrego correctamente ";
            lblmensaje.ForeColor = Color.Black;
            ltx.Items.Add($"{cbxseleccionar.SelectedItem} - ¢{valor}");
>>>>>>> 0c735cc311d78ab34d530ad2843047469e4ec8b8
        }

        public void seleccioncbx()
        {
            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                validarnombre();
            }
            else if (cbxseleccionar.SelectedItem == null)
            {
<<<<<<< HEAD
                validarservicio();
=======
                lblmensaje.Text = "Por favor, seleccione un servicio.";
                lblmensaje.ForeColor = Color.Red;
>>>>>>> 0c735cc311d78ab34d530ad2843047469e4ec8b8
            }
            else
            {
                agregarprecios();
            }
        }
<<<<<<< HEAD
        public void salirdetodo()
=======
        public void salirdetodo ()
>>>>>>> 0c735cc311d78ab34d530ad2843047469e4ec8b8
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
<<<<<<< HEAD
        private void btncalculo_Click(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        public void CalcularTotal()
        {
            validarservicio();

            int suma = 0;
            foreach (var valores in valores)
            {
                suma += valores;
                lblresultado.Text = $"{suma}";

                if (suma > 35000)

                    lblresultado.Text = "Total con descuento: " + suma;

                else
                    suma -= 3000;
                lblresultado.Text = "Total con descuento: " + suma;
            }
        }

        public void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnombre.Clear();
            ltxservicios.Items.Clear();
            lblresultado.Text = "";

        }
    }
}







