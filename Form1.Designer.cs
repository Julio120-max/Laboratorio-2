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
            textBox1 = new TextBox();
            lblservicios = new Label();
            cbxseleccionar = new ComboBox();
            btnagregar = new Button();
            ltx = new ListBox();
            btncalcular = new Button();
            lblresultado = new Label();
            btntotal = new Button();
            btnlimpiar = new Button();
            SuspendLayout();
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnombre.Location = new Point(107, 38);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(160, 23);
            lblnombre.TabIndex = 0;
            lblnombre.Text = "Nombre del cliente:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(345, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(321, 27);
            textBox1.TabIndex = 1;
            // 
            // lblservicios
            // 
            lblservicios.AutoSize = true;
            lblservicios.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblservicios.Location = new Point(107, 89);
            lblservicios.Name = "lblservicios";
            lblservicios.Size = new Size(180, 23);
            lblservicios.TabIndex = 2;
            lblservicios.Text = "Seleccioné un servicio:";
            // 
            // cbxseleccionar
            // 
            cbxseleccionar.FormattingEnabled = true;
            cbxseleccionar.Location = new Point(345, 88);
            cbxseleccionar.Name = "cbxseleccionar";
            cbxseleccionar.Size = new Size(151, 28);
            cbxseleccionar.TabIndex = 3;
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(521, 89);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(145, 29);
            btnagregar.TabIndex = 4;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = true;
            // 
            // ltx
            // 
            ltx.FormattingEnabled = true;
            ltx.Location = new Point(107, 145);
            ltx.Name = "ltx";
            ltx.Size = new Size(240, 144);
            ltx.TabIndex = 5;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(431, 203);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(168, 29);
            btncalcular.TabIndex = 6;
            btncalcular.Text = "Calcular total";
            btncalcular.UseVisualStyleBackColor = true;
            // 
            // lblresultado
            // 
            lblresultado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblresultado.Location = new Point(107, 325);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(559, 60);
            lblresultado.TabIndex = 7;
            lblresultado.Text = "\r\nResultado:";
            // 
            // btntotal
            // 
            btntotal.Location = new Point(431, 409);
            btntotal.Name = "btntotal";
            btntotal.Size = new Size(112, 29);
            btntotal.TabIndex = 8;
            btntotal.Text = "Calcular total";
            btntotal.UseVisualStyleBackColor = true;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(572, 409);
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
            Controls.Add(btntotal);
            Controls.Add(lblresultado);
            Controls.Add(btncalcular);
            Controls.Add(ltx);
            Controls.Add(btnagregar);
            Controls.Add(cbxseleccionar);
            Controls.Add(lblservicios);
            Controls.Add(textBox1);
            Controls.Add(lblnombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnombre;
        private TextBox textBox1;
        private Label lblservicios;
        private ComboBox cbxseleccionar;
        private Button btnagregar;
        private ListBox ltx;
        private Button btncalcular;
        private Label lblresultado;
        private Button btntotal;
        private Button btnlimpiar;
    }
}
