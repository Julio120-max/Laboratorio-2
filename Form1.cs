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
        List<int> valores = [];
        int suma = 0;
        int residuo = 3000;
        List<int> valores = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        // def validar nombre 1.
        public void nombrevacio()
        {
            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                lblmensaje.Text = " Por favor ingrese un nombre ";
                lblmensaje.ForeColor = Color.Red;
            }
            else if (ltxservicios.Items.Contains(nombre))
            {
                lblmuestra.Text = (" Ya existe un nombre");
                lblmuestra.ForeColor = Color.Black;
            }
        }
        
        
    
            
        // def validar nombre.
        public void validarnombre()
        {
            string nombre = txtnombre.Text;

            if (string.IsNullOrWhiteSpace(txtnombre.Text) || ltxservicios.Items.Contains(nombre))
            {
                nombrevacio();
            }
            else
            {
                lblmensaje.Text = " El nombre ha sido guardado correctamente.";
                lblmensaje.ForeColor = Color.Black;
                ltxservicios.Items.Add(nombre);
            }
        }
        // def validar servicio.
        public void validarservicio()
        {
            if (string.IsNullOrWhiteSpace(txtnombre.Text) || ltxservicios.Items.Contains(nombre))
            {
                nombrevacio();
            } 
            if (cbxseleccionar.SelectedItem == null)
                validarservicio();
            }
            else if (cbxseleccionar.SelectedItem == null)
            {
                lblmensaje.Text = (" Por favor selecciones un servicio.");
                lblmensaje.ForeColor = Color.Red;
                return;
            }
            else
            {
                lblmensaje.Text = " El servicio ha sido agregado correctamente";
                ltxservicios.Items.Add(cbxseleccionar.SelectedItem);
            }
            

        }
        // def agregar precios.
        public void agregarprecios()
        {
            int lugar = cbxseleccionar.SelectedIndex;
            int valor = precios[lugar];
            valores.Add(precios[lugar]);
            lblmensaje.Text = " El servicio se agrego correctamente ";
            lblmensaje.ForeColor = Color.Black;
            ltxservicios.Items.Add($"{cbxseleccionar.SelectedItem} - ¢{valor}");
        }
        // def selección de combobox.
        public void seleccioncbx()
        {
            if (string.IsNullOrWhiteSpace(txtnombre.Text) || ltxservicios.Items.Contains(nombre))
            {
                nombrevacio();
                validarnombre();
            }
            else if (cbxseleccionar.SelectedItem == null)
            {
                validarservicio();
            }
            else
            {
                agregarprecios();
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

        // def limpiar.
        public void limpiar()
        {
            txtnombre.Clear();
            ltxservicios.Items.Clear();
            lblresultado.Text = " Resultado: ";
        }



        public void CalcularTotal()
        {
            if (string.IsNullOrWhiteSpace(txtnombre.Text) || ltxservicios.Items.Contains(nombre))
            {
                nombrevacio();
            }
            else if (cbxseleccionar.SelectedItem == null)
            {
                validarservicio();
            }
            else
            {
                
                foreach (var valor in valores)
                {
                    suma += valor;
                }

                
                int candtidaddeservicios = ltxservicios.Items.Count;

                lblresultado1.Text = $"Total descuentos: ¢{3000} : Sub total: ¢{suma} :";

                if (candtidaddeservicios > 3)
                {
                    suma -= 3000;
                    lblmuestra.Text = " Se ha aplicado el descuento.";
                    lblresultado.Text = $"\nTotal con descuento aplicado: ¢{suma}. ";
                }
                else if ( suma > 35000)
                {
                    lblmensaje.Text = "Total elevado revise su seleccion: ";
                }
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
                int cantidadServicios = ltxservicios.Items.Count;
                if (cantidadServicios > 3)
                {
                    suma -= 3000;
                    lblresultado.Text = $"Total con descuento: {suma}";
                }
                else
                {
                    lblresultado.Text = $"Total sin descuento: {suma}";
                }
            }
        }

        //Botones
        private void btnnombre_Click(object sender, EventArgs e)

        public void btnlimpiar_Click(object sender, EventArgs e)
        {
            validarnombre();
            txtnombre.Clear();
            ltxservicios.Items.Clear();
            lblresultado.Text = "";
            valores.Clear();

        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            seleccioncbx();
        }
        private void btncalculo_Click(object sender, EventArgs e)
        {
            CalcularTotal();
        }
        public void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            salirdetodo();
        }

    }
}
