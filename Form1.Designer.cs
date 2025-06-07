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
            SuspendLayout();
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnombre.Location = new Point(94, 28);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(127, 19);
            lblnombre.TabIndex = 0;
            lblnombre.Text = "Nombre del cliente:";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(302, 26);
            txtnombre.Margin = new Padding(3, 2, 3, 2);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(202, 23);
            txtnombre.TabIndex = 1;
            // 
            // lblservicios
            // 
            lblservicios.AutoSize = true;
            lblservicios.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblservicios.Location = new Point(94, 67);
            lblservicios.Name = "lblservicios";
            lblservicios.Size = new Size(143, 19);
            lblservicios.TabIndex = 2;
            lblservicios.Text = "Seleccioné un servicio:";
            // 
            // cbxseleccionar
            // 
            cbxseleccionar.FormattingEnabled = true;
            cbxseleccionar.Items.AddRange(new object[] { "Instalaciones electricas.", "Limpieza profunda.", "Pintura y retoques estéticos.", "Mantenimiento de jardines.", "Controles preventivos de plagas." });
            cbxseleccionar.Location = new Point(302, 66);
            cbxseleccionar.Margin = new Padding(3, 2, 3, 2);
            cbxseleccionar.Name = "cbxseleccionar";
            cbxseleccionar.Size = new Size(202, 23);
            cbxseleccionar.TabIndex = 3;
            cbxseleccionar.Text = "                     Servicios";
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(508, 67);
            btnagregar.Margin = new Padding(3, 2, 3, 2);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(116, 22);
            btnagregar.TabIndex = 4;
            btnagregar.Text = "Agregar servicio";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // ltxservicios
            // 
            ltxservicios.FormattingEnabled = true;
            ltxservicios.ItemHeight = 15;
            ltxservicios.Location = new Point(94, 109);
            ltxservicios.Margin = new Padding(3, 2, 3, 2);
            ltxservicios.Name = "ltxservicios";
            ltxservicios.Size = new Size(246, 109);
            ltxservicios.TabIndex = 5;
            // 
            // lblresultado
            // 
            lblresultado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblresultado.Location = new Point(94, 244);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(489, 45);
            lblresultado.TabIndex = 7;
            lblresultado.Text = "\r\nResultado:";
            // 
            // btntotal
            // 
            btntotal.Location = new Point(336, 307);
            btntotal.Margin = new Padding(3, 2, 3, 2);
            btntotal.Name = "btntotal";
            btntotal.Size = new Size(98, 22);
            btntotal.TabIndex = 8;
            btntotal.Text = "Calcular total";
            btntotal.UseVisualStyleBackColor = true;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(467, 307);
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
            btnnombre.Location = new Point(508, 24);
            btnnombre.Margin = new Padding(3, 2, 3, 2);
            btnnombre.Name = "btnnombre";
            btnnombre.Size = new Size(116, 22);
            btnnombre.TabIndex = 10;
            btnnombre.Text = "Agregar nombre";
            btnnombre.UseVisualStyleBackColor = true;
            btnnombre.Click += btnnombre_Click;
            // 
            // lblmensaje
            // 
            lblmensaje.AutoSize = true;
            lblmensaje.Location = new Point(344, 130);
            lblmensaje.Name = "lblmensaje";
            lblmensaje.Size = new Size(0, 15);
            lblmensaje.TabIndex = 11;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(584, 307);
            btnsalir.Margin = new Padding(3, 2, 3, 2);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(82, 22);
            btnsalir.TabIndex = 12;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // btncalculo
            // 
            btncalculo.Location = new Point(398, 153);
            btncalculo.Name = "btncalculo";
            btncalculo.Size = new Size(97, 23);
            btncalculo.TabIndex = 13;
            btncalculo.Text = "Calcular total";
            btncalculo.UseVisualStyleBackColor = true;
            btncalculo.Click += btncalculo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
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
            Text = "Form1";
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
        private Button btncalcular;
        private Label lblresultado;
        private Button btntotal;
        private Button btnlimpiar;
        private Button btnnombre;
        private Label lblmensaje;
        private Button btnsalir;
        private Button btncalculo;
    }
}
