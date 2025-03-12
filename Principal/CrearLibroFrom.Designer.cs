namespace Principal
{
    partial class CrearLibroFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbNombre = new TextBox();
            tbReferencia = new TextBox();
            btGuardar = new Button();
            lbResultado = new Label();
            SuspendLayout();
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(249, 69);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(284, 23);
            tbNombre.TabIndex = 0;
            tbNombre.TextChanged += tbNombre_TextChanged;
            // 
            // tbReferencia
            // 
            tbReferencia.Location = new Point(249, 122);
            tbReferencia.Name = "tbReferencia";
            tbReferencia.Size = new Size(284, 23);
            tbReferencia.TabIndex = 1;
            // 
            // btGuardar
            // 
            btGuardar.Location = new Point(333, 195);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(128, 57);
            btGuardar.TabIndex = 2;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(371, 290);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(38, 15);
            lbResultado.TabIndex = 3;
            lbResultado.Text = "label1";
            // 
            // CrearLibroFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbResultado);
            Controls.Add(btGuardar);
            Controls.Add(tbReferencia);
            Controls.Add(tbNombre);
            Name = "CrearLibroFrom";
            Text = "CrearLibroFrom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNombre;
        private TextBox tbReferencia;
        private Button btGuardar;
        private Label lbResultado;
    }
}