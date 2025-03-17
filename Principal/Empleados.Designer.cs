namespace Principal
{
    partial class Empleados
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(244, 73);
            label1.Name = "label1";
            label1.Size = new Size(374, 21);
            label1.TabIndex = 0;
            label1.Text = "Seleccione el empleado con el cual va a ser la factura";
            // 
            // button1
            // 
            button1.Location = new Point(193, 162);
            button1.Name = "button1";
            button1.Size = new Size(105, 35);
            button1.TabIndex = 1;
            button1.Text = "Sebastian";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(366, 162);
            button2.Name = "button2";
            button2.Size = new Size(118, 35);
            button2.TabIndex = 2;
            button2.Text = "Luis";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(543, 162);
            button3.Name = "button3";
            button3.Size = new Size(110, 35);
            button3.TabIndex = 3;
            button3.Text = "Simon";
            button3.UseVisualStyleBackColor = true;
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Empleados";
            Text = "Empleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}