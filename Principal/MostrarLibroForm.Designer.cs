namespace Principal
{
    partial class MostrarLibroForm
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
            btMostrar = new Button();
            lbResultado = new Label();
            SuspendLayout();
            // 
            // btMostrar
            // 
            btMostrar.Location = new Point(309, 97);
            btMostrar.Name = "btMostrar";
            btMostrar.Size = new Size(156, 50);
            btMostrar.TabIndex = 0;
            btMostrar.Text = "Mostrar";
            btMostrar.UseVisualStyleBackColor = true;
            btMostrar.Click += btMostrar_Click;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(375, 192);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(38, 15);
            lbResultado.TabIndex = 1;
            lbResultado.Text = "label1";
            // 
            // MostrarLibroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbResultado);
            Controls.Add(btMostrar);
            Name = "MostrarLibroForm";
            Text = "MostrarLibroForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btMostrar;
        private Label lbResultado;
    }
}