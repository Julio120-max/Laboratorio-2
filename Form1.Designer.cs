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
            lblnombre.Location = new Point(94, 44);
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
            lblresultado.Location = new Point(94, 346);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(620, 39);
            lblresultado.TabIndex = 7;
            lblresultado.Text = "Total con descuento:";
            // 
            // btntotal
            // 
            btntotal.Location = new Point(341, 409);
            btntotal.Margin = new Padding(3, 2, 3, 2);
            btntotal.Name = "btntotal";
            btntotal.Size = new Size(98, 22);
            btntotal.TabIndex = 8;
            btntotal.Text = "Calcular total";
            btntotal.UseVisualStyleBackColor = true;
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
            // 
            // btnnombre
            // 
            btnnombre.Location = new Point(581, 41);
            btnnombre.Margin = new Padding(3, 2, 3, 2);
            btnnombre.Name = "btnnombre";
            btnnombre.Size = new Size(132, 20);
            btnnombre.TabIndex = 10;
            btnnombre.Text = "Agregar nombre";
            btnnombre.UseVisualStyleBackColor = true;
            // 
            // lblmensaje
            // 
            lblmensaje.AutoSize = true;
            lblmensaje.Location = new Point(400, 168);
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
            // 
            // btncalculo
            // 
            btncalculo.Location = new Point(444, 261);
            btncalculo.Name = "btncalculo";
            btncalculo.Size = new Size(172, 23);
            btncalculo.TabIndex = 13;
            btncalculo.Text = "Calcular total";
            btncalculo.UseVisualStyleBackColor = true;
            // 
            // lblmuestra
            // 
            lblmuestra.AutoSize = true;
            lblmuestra.Location = new Point(400, 209);
            lblmuestra.Name = "lblmuestra";
            lblmuestra.Size = new Size(0, 15);
            lblmuestra.TabIndex = 14;
            // 
            // lblresultado1
            // 
            lblresultado1.AutoSize = true;
            lblresultado1.Location = new Point(94, 312);
            lblresultado1.Name = "lblresultado1";
            lblresultado1.Size = new Size(59, 15);
            lblresultado1.TabIndex = 15;
            lblresultado1.Text = "Resultado";
            lblresultado1.Click += lblresultado1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Margin = new Padding(3, 2, 3, 2);
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
