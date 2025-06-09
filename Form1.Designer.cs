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
            lblresultado = new Label();
            btnlimpiar = new Button();
            btnnombre = new Button();
            lblmensaje = new Label();
            btnsalir = new Button();
            btncalculo = new Button();
            lblmuestra = new Label();
            lblresultado1 = new Label();
            lblresultado2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            eliminarServicioToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnombre.Location = new Point(79, 41);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(127, 19);
            lblnombre.TabIndex = 0;
            lblnombre.Text = "Nombre del cliente:";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(310, 41);
            txtnombre.Margin = new Padding(3, 2, 3, 2);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(257, 23);
            txtnombre.TabIndex = 1;
            // 
            // lblservicios
            // 
            lblservicios.AutoSize = true;
            lblservicios.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblservicios.Location = new Point(94, 92);
            lblservicios.Name = "lblservicios";
            lblservicios.Size = new Size(143, 19);
            lblservicios.TabIndex = 2;
            lblservicios.Text = "Seleccioné un servicio:";
            // 
            // cbxseleccionar
            // 
            cbxseleccionar.FormattingEnabled = true;
            cbxseleccionar.Items.AddRange(new object[] { "Instalaciones electricas.", "Limpieza profunda.", "Pintura y retoques estéticos.", "Mantenimiento de jardines.", "Controles preventivos de plagas." });
            cbxseleccionar.Location = new Point(310, 88);
            cbxseleccionar.Margin = new Padding(3, 2, 3, 2);
            cbxseleccionar.Name = "cbxseleccionar";
            cbxseleccionar.Size = new Size(257, 23);
            cbxseleccionar.TabIndex = 3;
            cbxseleccionar.Text = "                          Servicios";
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(581, 88);
            btnagregar.Margin = new Padding(3, 2, 3, 2);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(132, 21);
            btnagregar.TabIndex = 4;
            btnagregar.Text = "Agregar servicio";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click_1;
            // 
            // ltxservicios
            // 
            ltxservicios.FormattingEnabled = true;
            ltxservicios.ItemHeight = 15;
            ltxservicios.Location = new Point(94, 146);
            ltxservicios.Margin = new Padding(3, 2, 3, 2);
            ltxservicios.Name = "ltxservicios";
            ltxservicios.Size = new Size(281, 139);
            ltxservicios.TabIndex = 5;
            // 
            // lblresultado
            // 
            lblresultado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblresultado.Location = new Point(107, 497);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(639, 26);
            lblresultado.TabIndex = 7;
            lblresultado.Text = "Total con descuento:";
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(484, 409);
            btnlimpiar.Margin = new Padding(3, 2, 3, 2);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(82, 22);
            btnlimpiar.TabIndex = 9;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // btnnombre
            // 
            btnnombre.Location = new Point(581, 41);
            btnnombre.Margin = new Padding(3, 2, 3, 2);
            btnnombre.Name = "btnnombre";
            btnnombre.Size = new Size(132, 31);
            btnnombre.TabIndex = 10;
            btnnombre.Text = "Agregar nombre";
            btnnombre.UseVisualStyleBackColor = true;
            btnnombre.Click += btnnombre_Click;
            // 
            // lblmensaje
            // 
            lblmensaje.AutoSize = true;
            lblmensaje.Location = new Point(447, 222);
            lblmensaje.Name = "lblmensaje";
            lblmensaje.Size = new Size(0, 15);
            lblmensaje.TabIndex = 11;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(620, 409);
            btnsalir.Margin = new Padding(3, 2, 3, 2);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(94, 22);
            btnsalir.TabIndex = 12;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click_1;
            // 
            // btncalculo
            // 
            btncalculo.Location = new Point(444, 261);
            btncalculo.Name = "btncalculo";
            btncalculo.Size = new Size(172, 23);
            btncalculo.TabIndex = 13;
            btncalculo.Text = "Calcular total";
            btncalculo.UseVisualStyleBackColor = true;
            btncalculo.Click += btncalculo_Click_1;
            // 
            // lblmuestra
            // 
            lblmuestra.AutoSize = true;
            lblmuestra.Location = new Point(447, 264);
            lblmuestra.Name = "lblmuestra";
            lblmuestra.Size = new Size(0, 15);
            lblmuestra.TabIndex = 14;
            // 
            // lblresultado1
            // 
            lblresultado1.AutoSize = true;
            lblresultado1.Location = new Point(94, 312);
            lblresultado1.Name = "lblresultado1";
            lblresultado1.Size = new Size(93, 15);
            lblresultado1.TabIndex = 15;
            lblresultado1.Text = "Total descuento:";
            // 
            // lblresultado2
            // 
            lblresultado2.AutoSize = true;
            lblresultado2.Location = new Point(107, 456);
            lblresultado2.Name = "lblresultado2";
            lblresultado2.Size = new Size(35, 15);
            lblresultado2.TabIndex = 17;
            lblresultado2.Text = "Total:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { eliminarServicioToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(161, 26);
            contextMenuStrip1.Text = "Opciones";
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // eliminarServicioToolStripMenuItem
            // 
            eliminarServicioToolStripMenuItem.Name = "eliminarServicioToolStripMenuItem";
            eliminarServicioToolStripMenuItem.Size = new Size(160, 22);
            eliminarServicioToolStripMenuItem.Text = "Eliminar servicio";
            eliminarServicioToolStripMenuItem.Click += eliminarServicioToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 600);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Simulador de cotización de Servicios";
            contextMenuStrip1.ResumeLayout(false);
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
    }
}
