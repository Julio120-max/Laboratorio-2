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
            ltx = new ListBox();
            btncalcular = new Button();
            lblresultado = new Label();
            button1 = new Button();
            btnlimpiar = new Button();
            SuspendLayout();
            // 
            // lblnombre
            // 
            lblnombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblnombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnombre.Location = new Point(84, 36);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(177, 20);
            lblnombre.TabIndex = 0;
            lblnombre.Text = "Nombre del cliente:";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(302, 36);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(283, 27);
            txtnombre.TabIndex = 1;
            // 
            // lblservicios
            // 
            lblservicios.AutoSize = true;
            lblservicios.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblservicios.Location = new Point(84, 82);
            lblservicios.Name = "lblservicios";
            lblservicios.Size = new Size(180, 23);
            lblservicios.TabIndex = 2;
            lblservicios.Text = "Seleccione un servicio:";
            // 
            // cbxseleccionar
            // 
            cbxseleccionar.FormattingEnabled = true;
            cbxseleccionar.Location = new Point(302, 82);
            cbxseleccionar.Name = "cbxseleccionar";
            cbxseleccionar.Size = new Size(151, 28);
            cbxseleccionar.TabIndex = 3;
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(491, 82);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(94, 29);
            btnagregar.TabIndex = 4;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = true;
            // 
            // ltx
            // 
            ltx.FormattingEnabled = true;
            ltx.Location = new Point(84, 141);
            ltx.Name = "ltx";
            ltx.Size = new Size(269, 144);
            ltx.TabIndex = 5;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(386, 202);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(199, 29);
            btncalcular.TabIndex = 6;
            btncalcular.Text = "Calcular total";
            btncalcular.UseVisualStyleBackColor = true;
            // 
            // lblresultado
            // 
            lblresultado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblresultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblresultado.Location = new Point(84, 330);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(568, 44);
            lblresultado.TabIndex = 7;
            lblresultado.Text = "Resultado:";
            // 
            // button1
            // 
            button1.Location = new Point(386, 394);
            button1.Name = "button1";
            button1.Size = new Size(131, 29);
            button1.TabIndex = 8;
            button1.Text = "Calcular total";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(558, 394);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(94, 29);
            btnlimpiar.TabIndex = 9;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnlimpiar);
            Controls.Add(button1);
            Controls.Add(lblresultado);
            Controls.Add(btncalcular);
            Controls.Add(ltx);
            Controls.Add(btnagregar);
            Controls.Add(cbxseleccionar);
            Controls.Add(lblservicios);
            Controls.Add(txtnombre);
            Controls.Add(lblnombre);
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
        private ListBox ltx;
        private Button btncalcular;
        private Label lblresultado;
        private Button button1;
        private Button btnlimpiar;
    }
}
