using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using System.Security.Policy;
using System.Windows.Forms;

namespace Laboratorio_2.git_hub
{
    public partial class Form1 : Form
    {
        string nombre = string.Empty; // Declaramos la variable nombre y usamos string.Empty esto es equivalente a escibir (string nombre = "";) lo usamos para evitar errores en ciertas partes.
        int[] precios = { 5000, 10000, 8000, 4000, 6750 };// Declaramos los precios de los servicios con una lista estatica(Array):
        List<int> valores = new List<int>();// Declaramos una lista nueva la diferencia es que con esta podemos usar metodos como lo son Suma(),Add(),Remove(), Esta es modificada con los servicos que se eligen.

        public Form1()
        {
            InitializeComponent();
        }

        // def validar nombre vacio.
        public void nombrevacio() 
        {
            if (string.IsNullOrWhiteSpace(txtnombre.Text))// Verificamos que se haya ingresado un nombre, si no se lo pedimos al usuario.
            {

                lblmensaje.Text = " Por favor, ingrese un nombre ";
                lblmensaje.ForeColor = Color.Red;

            }
            else if (ltxservicios.Items.Contains($"Clientes: {nombre}"))// Si ya existe un nombre por más que se le de click al btnagregarnmbre no se agregara nada a menos que se elimine el nombre existente.
            {
                
            }
        }
        // def validar nombre.
        public void validarnombre()
        {
            string nombre = txtnombre.Text;

            if (string.IsNullOrWhiteSpace(txtnombre.Text) || ltxservicios.Items.Contains(($"Clientes: {nombre}")))// Verificamos que exista un nombre.
            {
                nombrevacio();// Si no llamamos a la función de (nombrevacio) para que se ejecute y vuelva a pedir el nombre, ademas no dejara que los demas botones ejecuten nada por que no hay un nombre.
            }
            else// Si hay nombre se mostrara un mensaje de exito y se procedera a añadir el nombre a la listbos de la siguiente manera: (Clientes: nombre).
            {
                lblmensaje.Text = " El nombre se ha guardado correctamente.";
                lblmensaje.ForeColor = Color.Black;
                ltxservicios.Items.Add($"Clientes: {nombre}");

            }
        }
        // def validar servicio.
        public void validarservicio()
        {
            if (string.IsNullOrWhiteSpace(txtnombre.Text) || ltxservicios.Items.Contains(($"Clientes: {nombre}")))// Nueva mente validamos que haya nombre.
            {
                nombrevacio();
            }
            if (cbxseleccionar.SelectedItem != null)// Verificamos si hay un servicio elegido lo añadimos a la listbox y mostramos mensaje de exito.
            {
                lblmensaje.Text = " El servicio se ha agregado correctamente.";
                ltxservicios.Items.Add(cbxseleccionar.SelectedItem); 
                
            }
            else// Si no hay un servicio elegido mostramos un mesaje en letras rojas.
            {
                lblmensaje.Text = (" Por favor, seleccione un servicio.");
                lblmensaje.ForeColor = Color.Red;
                return;
            }
        }

        // def agregar precios.
        public void agregarprecios()
        {
            if (cbxseleccionar.SelectedIndex == -1)// validamos si se a elegido algun servicio del comboBox.
            {
                validarservicio(); // si no se a elegido ninguno llamamos la función (validarservicio).
                return;
            }
            // Si existe un servicio entonces:

            int lugar = cbxseleccionar.SelectedIndex; // Primero averiguamos el número de indice de la opción seleccionana en el comboBox y loguardamos en la variante lugar.
            int valor = precios[lugar];// Aqui podemos entrar a la lista precios y gracias al indice encontrar su valor.
            valores.Add(precios[lugar]);// Aqui agreamos el precio a la lista que se puede mosdificar que es valores.
            ltxservicios.Items.Add($"{cbxseleccionar.SelectedItem} - ¢{valor}");// Utilizamos esto para ingresar el servicio y el precio ya que tenemos sus indices.
            lblmensaje.Text = " El servicio se ha agregado correctamente.";// Despues mostramos un mensaje de exito.
            lblmensaje.ForeColor = Color.Black;// En color negro.
        }
        // def quitar precios.
        public void quitarprecio()
        {
            if (string.IsNullOrWhiteSpace(txtnombre.Text) || ltxservicios.Items.Contains(($"Clientes: {nombre}")))// Verificamos nuevamente si existe un nombre.
            {
                nombrevacio();
            }
            else if (ltxservicios.SelectedItem != null) // verificamos de que se haya elegido un elemento de la listbox.
            {

                int indice = ltxservicios.SelectedIndex;// Guardamos el índice de el elmento elegido. 
                string seleccion = ltxservicios.SelectedItem.ToString() ?? string.Empty;
                ;
                if (seleccion.StartsWith("Clientes:"))// Despues verificamos si el elemento elegido es un (clientes).
                {
                    txtnombre.Text = "";  // Si es un cliente limpiamos el txtnombre.
                    lblmensaje.Text = "El nombre ha sido eliminado. No se pueden agregar más servicios.";// mostramos un mensaje.
                    lblmensaje.ForeColor = Color.Red;// En color rojo.

                    cbxseleccionar.Text = "                          Servicios";// y el comboBox lo reiniciamos con el titulo (Servicios).
                  
                }

                ltxservicios.Items.RemoveAt(indice);// Eliminamos el elemento elegido de la listbox.

                if (indice < valores.Count)// Se verifica si el índice se encuentre dento de la lista (Valores).
                {
                    valores.RemoveAt(indice);// Si el elemento selecionado tiene un precio lo elimina.
                }
            }
            else// Si no hay un elemento elegido entonces muestra el siguiente mensaje en color rojo .
            {
                lblmensaje.Text = " Por favor selecione un servicio para poder eliminarlo.";
                lblmensaje.ForeColor = Color.Red;
            }
        }
        // def selección de combobox.
        public void seleccioncbx()
        {
            if (string.IsNullOrWhiteSpace(txtnombre.Text) || ltxservicios.Items.Contains(($"Clientes: {nombre}")))
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
        // def cambiar color de fondo.
        public void colordefondo()
        {
            // El usuario al dar clck le aparecera un con muchos colores para seleccionar.
            ColorDialog new_color = new ColorDialog();
            if (new_color.ShowDialog() == DialogResult.OK)// Si es cierto que el usuario selectiono una se cunpira lo siguiente:
            {
                this.BackColor = new_color.Color; // Si es cierto entonces el Form cambiara de color.
            }
        }
        //def limpiar.
        public void limpiar()
        {
            // Aqui limpiamos lo que so btn,lbl y ltx.
            txtnombre.Text = "";
            ltxservicios.Items.Clear();
            lblresultado.Text = "Total descuento: ";
            lblresultado2.Text = "Total:";
            lblresultado1.Text = "Total con descuento:";
            cbxseleccionar.Text = "";
            lblmensaje.Text = "";
            lblmuestra.Text = "";
        }
        public void CalcularTotal()
        {
            if (string.IsNullOrWhiteSpace(txtnombre.Text) || ltxservicios.Items.Contains($"Clientes: {nombre}"))// Primero verificamos si existe un nombre.
            {
                nombrevacio();
                return;
            }

            if (cbxseleccionar.SelectedItem == null) // verificamos si existe al menos un servicio elegido.
            {
                validarservicio();
                return;
            }

            int suma = 0; // La variable suma iniciara en cero.
            valores.Clear(); // Se limpia la lista para recalcular desde cero, por si aquello de que se haya eliminado algun elemento con precio.

            foreach (var item in ltxservicios.Items)
            {
                string elemento = item.ToString() ?? string.Empty;// Utilizamos esto para que el elemento se convierta en una cadena de texto completa, y utilizamos (?? string.Empty)  para evitar errores de que si item no existe.


                if (elemento.Contains(" - ¢"))// Verifica si el elemento elegido contiene el siguiente simbolo " - ¢".
                {
                    string[] partes = elemento.Split(new string[] { " - ¢" }, StringSplitOptions.None);// Esto divide el elemento elegido en dos partes, giandose por " - ¢" y las guarda en la nueva lista (partes).
                    if (partes.Length == 2 && int.TryParse(partes[1], out int precio))// Esto verifica de que el la lista partes existan 2 partes, si es asi la segunda parte que es (" - ¢") se convertira e un número entero y lo añadira a una variable llamada precio. 
                    {
                        valores.Add(precio);// Si todo va bien hasta el momento entonces el precio se añadira a la lista valores con lo que podremos hacer los calculos del total de precios más adelante.
                    }
                }
            }

            suma = valores.Sum();// Aqui sumamos todo los precios que se almacenarón en la lista.
            lblresultado1.Text = "Total descuentos: ¢0"; // El texto de el total de descuentos empieza en ¢0.
            lblresultado2.Text = $"Total: ¢{suma}";// Luego mostramos la suma de todos los precios almacenados en la lista valores, estos sin decuento ni nada. 
            lblresultado.Text = $"Total con descuento aplicado: No hay descuentos.";// Mostramos el texto de descuento aplicado con un mensaje que dice que no hay descuentos aplicados.

            if (ltxservicios.Items.Count >= 4) // Luego validamos la cantidad de servicios en la listbox, (hemos puesto > 4 porque el nombre de usuario me lo contaba como un elemnto) entonces esta fue nuestra solución, si es mayor que 4 se muestran los siguientes mensajes:
            {
                suma -= 3000;
                lblresultado1.Text = $"Total de descuentos: ¢{3000}";// El descuento total.
                lblmuestra.Text = "Se ha aplicado el descuento.";// Un mensaje de que se ha aplicado un descuento.
                lblresultado.Text = $"Total con descuento aplicados: ¢{suma}.";// Y el mensaje de el monto total - el descuento.

                if (suma > 35000)// Si el monto supera los 35000, entonces mostrara un mensaje:
                {
                    lblmensaje.Text = "Total elevado, revise su selección.";// Este.
                }
            }
        }

        //Botones
        // Luego ya mamos las funciones necesarias para cada boton.
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

        // Creamos 2 ContextMenúStrip uno para poder eliminar algun elemneto de la listbox y otro para que el usuario pueda personalisar un poco los colores.
        private void eliminarServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quitarprecio();
        }

        private void cambiarColorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colordefondo();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salirdetodo();
        }

        private void limpiarHistorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}





