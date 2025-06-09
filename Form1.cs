using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using System.Security.Policy;
using System.Windows.Forms;

namespace Laboratorio_2.git_hub
{
    public partial class Form1 : Form
    {
        string nombre = string.Empty;
        int[] precios = { 5000, 10000, 8000, 4000, 6750 };
        List<int> valores = new List<int>();
        int suma = 0;
        public Form1()
        {
            InitializeComponent();
            ltxservicios.ContextMenuStrip = contextMenuStrip1;
        }

        // def validar nombre vacio.
        public void nombrevacio()
        {
            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
 
                lblmensaje.Text = " Por favor, ingrese un nombre ";
                lblmensaje.ForeColor = Color.Red;
               
            }
            else if (ltxservicios.Items.Contains($"Clientes: {nombre}"))
            {

            }
        }
        // def validar nombre.
        public void validarnombre()
        {
            string nombre = txtnombre.Text;

            if (string.IsNullOrWhiteSpace(txtnombre.Text) || ltxservicios.Items.Contains($"Clientes:{nombre}"))
            {
                nombrevacio();
            }
            else
            {
                lblmensaje.Text = " El nombre se ha guardado correctamente.";
                lblmensaje.ForeColor = Color.Black;
                ltxservicios.Items.Add($"Clientes: {nombre}");

            }
        }
        // def validar servicio.
        public void validarservicio()
        {
            if (string.IsNullOrWhiteSpace(txtnombre.Text) || ltxservicios.Items.Contains($"Clientes: {nombre}"))
            {
                nombrevacio();
            }
            if (cbxseleccionar.SelectedItem != null)
            {
                lblmensaje.Text = " El servicio se ha agregado correctamente.";
                ltxservicios.Items.Add(cbxseleccionar.SelectedItem);
            }
            else
            {
                lblmensaje.Text = (" Por favor, seleccione un servicio.");
                lblmensaje.ForeColor = Color.Red;
                return;
            }
        }

        // def agregar precios.
        public void agregarprecios()
        {
            if (cbxseleccionar.SelectedIndex == -1)
            {
                validarservicio();
                return;
            }

            int lugar = cbxseleccionar.SelectedIndex;
            int valor = precios[lugar];
            valores.Add(precios[lugar]);
            ltxservicios.Items.Add($"{cbxseleccionar.SelectedItem} - ¢{valor}");
            lblmensaje.Text = " El servicio se ha agregado correctamente.";
            lblmensaje.ForeColor = Color.Black;

        }
        // def selección de combobox.
        public void seleccioncbx()
        {
            if (string.IsNullOrWhiteSpace(txtnombre.Text) || ltxservicios.Items.Contains($"Clientes:{nombre}"))
            {
                nombrevacio();
            }
            else if (cbxseleccionar.SelectedItem == null)
            {
                validarservicio();
            }
            else
            {
                agregarprecios();
            }

        }
        // def salir de todo.
        public void salirdetodo()
        {
            this.Close();
        }
        public void limpiar()
        {
            txtnombre.Clear();
            ltxservicios.Items.Clear();
            lblresultado.Text = "Resultado: ";
            lblresultado2.Text = "Resultado:";
            lblresultado1.Text = "Resultado:";
            cbxseleccionar.Text = "";
        }

        private void btncalculo_Click(object sender, EventArgs e)
        {
            CalcularTotal();
        }
        public void CalcularTotal()
        {
            if (string.IsNullOrWhiteSpace(txtnombre.Text) || ltxservicios.Items.Contains($"Clientes: {nombre}"))
            {
                nombrevacio();
            }
            else if (cbxseleccionar.SelectedItem == null)
            {
                validarservicio();
            }
            else
            {

                suma = valores.Sum();
                int candtidaddeservicios = ltxservicios.Items.Count;
                lblresultado1.Text = "Total descuentos: ¢0";
                lblresultado2.Text = $"Total: ¢{suma}";
                lblresultado.Text = $"Total con descuento aplicado: No hay descuentos. ";
                if (candtidaddeservicios >= 4)
                {
                    suma -= 3000;
                    lblresultado1.Text = $"Total de descuentos: ¢{3000} ";
                    lblmuestra.Text = " Se ha aplicado el descuento.";
                    lblresultado.Text = $"Total con descuento aplicados: ¢{suma}. ";

                    if (suma > 35000)
                    {
                        lblmensaje.Text = " Total elevado, revise su selección . ";
                    }


                }
            }

        }

        //Botones
        public void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnsalir_Click_1(object sender, EventArgs e)

        {
            salirdetodo();
        }

        private void btncalculo_Click_1(object sender, EventArgs e)
        {

            CalcularTotal();
        }

        private void btnnombre_Click(object sender, EventArgs e)
        {
            validarnombre();

        }

        private void btnagregar_Click_1(object sender, EventArgs e)
        {
            seleccioncbx();
        }
        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            eliminarServicioToolStripMenuItem.Enabled = (ltxservicios.SelectedItem != null);
        }
        private void eliminarServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = ltxservicios.SelectedIndex;

            if (index == -1)
            {
                lblresultado.Text = "Por favor selecciona un ítem para eliminar.";
                return;
            }
            if (index < valores.Count)
            {
                valores.RemoveAt(index);
            }

            ltxservicios.Items.RemoveAt(index);
            lblresultado.Text = 
            lblresultado2.Text = "";
        }
    }
}





