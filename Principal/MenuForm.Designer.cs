namespace Principal
{
    partial class MenuForm
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
            btCrearLibro = new Button();
            btMostrar = new Button();
            SuspendLayout();
            // 
            // btCrearLibro
            // 
            btCrearLibro.Location = new Point(231, 120);
            btCrearLibro.Name = "btCrearLibro";
            btCrearLibro.Size = new Size(147, 107);
            btCrearLibro.TabIndex = 0;
            btCrearLibro.Text = "Crear";
            btCrearLibro.UseVisualStyleBackColor = true;
            btCrearLibro.Click += btCrearLibro_Click;
            // 
            // btMostrar
            // 
            btMostrar.Location = new Point(437, 120);
            btMostrar.Name = "btMostrar";
            btMostrar.Size = new Size(138, 107);
            btMostrar.TabIndex = 1;
            btMostrar.Text = "Mostrar";
            btMostrar.UseVisualStyleBackColor = true;
            btMostrar.Click += btMostrar_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btMostrar);
            Controls.Add(btCrearLibro);
            Name = "MenuForm";
            Text = "MenuForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btCrearLibro;
        private Button btMostrar;
    }
}