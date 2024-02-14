namespace TablaMultiplicar
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
            lstResultadoMultiplicacion = new ListBox();
            btnCalcular = new Button();
            lblNumero = new Label();
            txtNumero = new TextBox();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // lstResultadoMultiplicacion
            // 
            lstResultadoMultiplicacion.BackColor = Color.DeepSkyBlue;
            lstResultadoMultiplicacion.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstResultadoMultiplicacion.ForeColor = Color.Black;
            lstResultadoMultiplicacion.FormattingEnabled = true;
            lstResultadoMultiplicacion.ItemHeight = 21;
            lstResultadoMultiplicacion.Location = new Point(90, 127);
            lstResultadoMultiplicacion.Margin = new Padding(5, 3, 5, 3);
            lstResultadoMultiplicacion.Name = "lstResultadoMultiplicacion";
            lstResultadoMultiplicacion.Size = new Size(416, 256);
            lstResultadoMultiplicacion.TabIndex = 0;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.DeepSkyBlue;
            btnCalcular.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnCalcular.ForeColor = Color.Black;
            btnCalcular.Location = new Point(90, 419);
            btnCalcular.Margin = new Padding(5, 3, 5, 3);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(118, 45);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnMostrar_Click;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblNumero.Location = new Point(149, 65);
            lblNumero.Margin = new Padding(5, 0, 5, 0);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(87, 25);
            lblNumero.TabIndex = 2;
            lblNumero.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            txtNumero.Location = new Point(280, 62);
            txtNumero.Margin = new Padding(5, 3, 5, 3);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(163, 31);
            txtNumero.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DeepSkyBlue;
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.Black;
            btnLimpiar.Location = new Point(239, 419);
            btnLimpiar.Margin = new Padding(5, 3, 5, 3);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(118, 45);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.DeepSkyBlue;
            btnCerrar.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnCerrar.ForeColor = Color.Black;
            btnCerrar.Location = new Point(388, 419);
            btnCerrar.Margin = new Padding(5, 3, 5, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(118, 45);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 563);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Controls.Add(btnCalcular);
            Controls.Add(lstResultadoMultiplicacion);
            Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(5, 3, 5, 3);
            Name = "Form1";
            Text = "Tabla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstResultadoMultiplicacion;
        private Button btnCalcular;
        private Label lblNumero;
        private TextBox txtNumero;
        private Button btnLimpiar;
        private Button btnCerrar;
    }
}