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
            lblnombre = new Label();
            txtnombre = new TextBox();
            lblservicios = new Label();
            cbxseleccionar = new ComboBox();
            btnagregar = new Button();
            ltxservicios = new ListBox();
            lblresultado = new Label();
            btntotal = new Button();
            btnlimpiar = new Button();
            btnnombre = new Button();
            lblmensaje = new Label();
            btnsalir = new Button();
            btncalculo = new Button();
            lblmuestra = new Label();
            lblresultado1 = new Label();
            lblresultado2 = new Label();
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
            lblservicios.Location = new Point(107, 122);
            lblservicios.Name = "lblservicios";
            lblservicios.Size = new Size(180, 23);
            lblservicios.TabIndex = 2;
            lblservicios.Text = "Seleccioné un servicio:";
            // 
            // cbxseleccionar
            // 
            cbxseleccionar.FormattingEnabled = true;
            cbxseleccionar.Items.AddRange(new object[] { "Instalaciones electricas.", "Limpieza profunda.", "Pintura y retoques estéticos.", "Mantenimiento de jardines.", "Controles preventivos de plagas." });
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
            btnagregar.Click += btnagregar_Click;
            // 
            // ltxservicios
            // 
            ltxservicios.FormattingEnabled = true;
            ltxservicios.Location = new Point(107, 195);
            ltxservicios.Name = "ltxservicios";
            ltxservicios.Size = new Size(321, 184);
            ltxservicios.TabIndex = 5;
            // 
            // lblresultado
            // 
            lblresultado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblresultado.Location = new Point(107, 497);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(708, 26);
            lblresultado.TabIndex = 7;
            lblresultado.Text = "Total con descuento:";
            // 
            // btntotal
            // 
            btntotal.Location = new Point(390, 545);
            btntotal.Name = "btntotal";
            btntotal.Size = new Size(112, 29);
            btntotal.TabIndex = 8;
            btntotal.Text = "Calcular total";
            btntotal.UseVisualStyleBackColor = true;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(553, 545);
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
            lblmensaje.Location = new Point(447, 222);
            lblmensaje.Name = "lblmensaje";
            lblmensaje.Size = new Size(0, 20);
            lblmensaje.TabIndex = 11;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(708, 545);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(107, 29);
            btnsalir.TabIndex = 12;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // btncalculo
            // 
            btncalculo.Location = new Point(507, 348);
            btncalculo.Margin = new Padding(3, 4, 3, 4);
            btncalculo.Name = "btncalculo";
            btncalculo.Size = new Size(197, 31);
            btncalculo.TabIndex = 13;
            btncalculo.Text = "Calcular total";
            btncalculo.UseVisualStyleBackColor = true;
            btncalculo.Click += btncalculo_Click;
            // 
            // lblmuestra
            // 
            lblmuestra.AutoSize = true;
            lblmuestra.Location = new Point(447, 264);
            lblmuestra.Name = "lblmuestra";
            lblmuestra.Size = new Size(0, 20);
            lblmuestra.TabIndex = 14;
            // 
            // lblresultado1
            // 
            lblresultado1.AutoSize = true;
            lblresultado1.Location = new Point(107, 416);
            lblresultado1.Name = "lblresultado1";
            lblresultado1.Size = new Size(117, 20);
            lblresultado1.TabIndex = 15;
            lblresultado1.Text = "Total descuento:";
            // 
            // lblresultado2
            // 
            lblresultado2.AutoSize = true;
            lblresultado2.Location = new Point(107, 456);
            lblresultado2.Name = "lblresultado2";
            lblresultado2.Size = new Size(45, 20);
            lblresultado2.TabIndex = 17;
            lblresultado2.Text = "Total:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(lblresultado2);
            Controls.Add(lblresultado1);
            Controls.Add(lblmuestra);
            Controls.Add(btncalculo);
            Controls.Add(btnsalir);
            Controls.Add(lblmensaje);
            Controls.Add(btnnombre);
            Controls.Add(btnlimpiar);
            Controls.Add(btntotal);
            Controls.Add(lblresultado);
            Controls.Add(ltxservicios);
            Controls.Add(btnagregar);
            Controls.Add(cbxseleccionar);
            Controls.Add(lblservicios);
            Controls.Add(txtnombre);
            Controls.Add(lblnombre);
            Name = "Form1";
            Text = "Simulador de cotización de Servicios";
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
        private Button btntotal;
        private Button btnlimpiar;
        private Button btnnombre;
        private Label lblmensaje;
        private Button btnsalir;
        private Button btncalculo;
        private Label lblmuestra;
        private Label lblresultado1;
        private Label lblresultado2;
    }
}
