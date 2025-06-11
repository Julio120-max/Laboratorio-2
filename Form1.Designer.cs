namespace Laboratorio_2.git_hub
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblnombre = new Label();
            txtnombre = new TextBox();
            lblservicios = new Label();
            cbxseleccionar = new ComboBox();
            btnagregar = new Button();
            ltxservicios = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            eliminarServicioToolStripMenuItem = new ToolStripMenuItem();
            lblresultado = new Label();
            btnlimpiar = new Button();
            btnnombre = new Button();
            lblmensaje = new Label();
            btnsalir = new Button();
            btncalculo = new Button();
            lblmuestra = new Label();
            lblresultado1 = new Label();
            lblresultado2 = new Label();
            contextMenuStrip2 = new ContextMenuStrip(components);
            cambiarColorDeFondoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            limpiarHistorialToolStripMenuItem = new ToolStripMenuItem();
            lblhola = new Label();
            contextMenuStrip1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnombre.Location = new Point(107, 59);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(160, 23);
            lblnombre.TabIndex = 0;
            lblnombre.Text = "Nombre del cliente:";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(354, 55);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(293, 27);
            txtnombre.TabIndex = 1;
            // 
            // lblservicios
            // 
            lblservicios.AutoSize = true;
            lblservicios.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblservicios.Location = new Point(107, 123);
            lblservicios.Name = "lblservicios";
            lblservicios.Size = new Size(180, 23);
            lblservicios.TabIndex = 2;
            lblservicios.Text = "Seleccioné un servicio:";
            // 
            // cbxseleccionar
            // 
            cbxseleccionar.FormattingEnabled = true;
            cbxseleccionar.Items.AddRange(new object[] { "Instalaciones electricas", "Limpieza profunda", "Pintura y retoques estéticos", "Mantenimiento de jardines", "Controles preventivos de plagas" });
            cbxseleccionar.Location = new Point(354, 117);
            cbxseleccionar.Name = "cbxseleccionar";
            cbxseleccionar.Size = new Size(293, 28);
            cbxseleccionar.TabIndex = 3;
            cbxseleccionar.Text = "                          Servicios";
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(664, 117);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(151, 28);
            btnagregar.TabIndex = 4;
            btnagregar.Text = "Agregar servicio";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click_1;
            // 
            // ltxservicios
            // 
            ltxservicios.ContextMenuStrip = contextMenuStrip1;
            ltxservicios.FormattingEnabled = true;
            ltxservicios.Location = new Point(107, 175);
            ltxservicios.Name = "ltxservicios";
            ltxservicios.Size = new Size(321, 184);
            ltxservicios.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { eliminarServicioToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(187, 28);
            contextMenuStrip1.Text = "Opciones";
            // 
            // eliminarServicioToolStripMenuItem
            // 
            eliminarServicioToolStripMenuItem.Name = "eliminarServicioToolStripMenuItem";
            eliminarServicioToolStripMenuItem.Size = new Size(186, 24);
            eliminarServicioToolStripMenuItem.Text = "Eliminar servicio";
            eliminarServicioToolStripMenuItem.Click += eliminarServicioToolStripMenuItem_Click;
            // 
            // lblresultado
            // 
            lblresultado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblresultado.AutoSize = true;
            lblresultado.Location = new Point(107, 451);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(145, 20);
            lblresultado.TabIndex = 7;
            lblresultado.Text = "Total con descuento:";
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(525, 509);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(94, 29);
            btnlimpiar.TabIndex = 9;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // btnnombre
            // 
            btnnombre.Location = new Point(664, 55);
            btnnombre.Name = "btnnombre";
            btnnombre.Size = new Size(151, 27);
            btnnombre.TabIndex = 10;
            btnnombre.Text = "Agregar nombre";
            btnnombre.UseVisualStyleBackColor = true;
            btnnombre.Click += btnnombre_Click;
            // 
            // lblmensaje
            // 
            lblmensaje.AutoSize = true;
            lblmensaje.Location = new Point(451, 189);
            lblmensaje.Name = "lblmensaje";
            lblmensaje.Size = new Size(0, 20);
            lblmensaje.TabIndex = 11;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(643, 509);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(107, 29);
            btnsalir.TabIndex = 12;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click_1;
            // 
            // btncalculo
            // 
            btncalculo.Location = new Point(525, 328);
            btncalculo.Margin = new Padding(3, 4, 3, 4);
            btncalculo.Name = "btncalculo";
            btncalculo.Size = new Size(197, 31);
            btncalculo.TabIndex = 13;
            btncalculo.Text = "Calcular total";
            btncalculo.UseVisualStyleBackColor = true;
            btncalculo.Click += btncalculo_Click_1;
            // 
            // lblmuestra
            // 
            lblmuestra.AutoSize = true;
            lblmuestra.Location = new Point(451, 245);
            lblmuestra.Name = "lblmuestra";
            lblmuestra.Size = new Size(0, 20);
            lblmuestra.TabIndex = 14;
            // 
            // lblresultado1
            // 
            lblresultado1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblresultado1.AutoSize = true;
            lblresultado1.Location = new Point(107, 384);
            lblresultado1.Name = "lblresultado1";
            lblresultado1.Size = new Size(117, 20);
            lblresultado1.TabIndex = 15;
            lblresultado1.Text = "Total descuento:";
            // 
            // lblresultado2
            // 
            lblresultado2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblresultado2.AutoSize = true;
            lblresultado2.Location = new Point(107, 419);
            lblresultado2.Name = "lblresultado2";
            lblresultado2.Size = new Size(45, 20);
            lblresultado2.TabIndex = 17;
            lblresultado2.Text = "Total:";
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { cambiarColorDeFondoToolStripMenuItem, salirToolStripMenuItem, limpiarHistorialToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(241, 76);
            // 
            // cambiarColorDeFondoToolStripMenuItem
            // 
            cambiarColorDeFondoToolStripMenuItem.Name = "cambiarColorDeFondoToolStripMenuItem";
            cambiarColorDeFondoToolStripMenuItem.Size = new Size(240, 24);
            cambiarColorDeFondoToolStripMenuItem.Text = "Cambiar color de fondo.";
            cambiarColorDeFondoToolStripMenuItem.Click += cambiarColorDeFondoToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(240, 24);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // limpiarHistorialToolStripMenuItem
            // 
            limpiarHistorialToolStripMenuItem.Name = "limpiarHistorialToolStripMenuItem";
            limpiarHistorialToolStripMenuItem.Size = new Size(240, 24);
            limpiarHistorialToolStripMenuItem.Text = "Limpiar todo";
            limpiarHistorialToolStripMenuItem.Click += limpiarHistorialToolStripMenuItem_Click;
            // 
            // lblhola
            // 
            lblhola.AutoSize = true;
            lblhola.Location = new Point(114, 481);
            lblhola.Name = "lblhola";
            lblhola.Size = new Size(41, 20);
            lblhola.TabIndex = 18;
            lblhola.Text = "Hola";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 550);
            ContextMenuStrip = contextMenuStrip2;
            Controls.Add(lblhola);
            Controls.Add(lblresultado2);
            Controls.Add(lblresultado1);
            Controls.Add(lblmuestra);
            Controls.Add(btncalculo);
            Controls.Add(btnsalir);
            Controls.Add(lblmensaje);
            Controls.Add(btnnombre);
            Controls.Add(btnlimpiar);
            Controls.Add(lblresultado);
            Controls.Add(ltxservicios);
            Controls.Add(btnagregar);
            Controls.Add(cbxseleccionar);
            Controls.Add(lblservicios);
            Controls.Add(txtnombre);
            Controls.Add(lblnombre);
            Name = "Form1";
            Text = "Simulador de cotización de Servicios";
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnombre;
        private TextBox txtnombre;
        private Label lblservicios;
        private ComboBox cbxseleccionar;
        private Button btnagregar;
        private ListBox ltxservicios;
        private Label lblresultado;
        private Button btnlimpiar;
        private Button btnnombre;
        private Label lblmensaje;
        private Button btnsalir;
        private Button btncalculo;
        private Label lblmuestra;
        private Label lblresultado1;
        private Label lblresultado2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem eliminarServicioToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem cambiarColorDeFondoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem limpiarHistorialToolStripMenuItem;
        private Label lblhola;
    }
}
