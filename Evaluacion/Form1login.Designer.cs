namespace Evaluacion
{
    partial class Form1login
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
            Btningresar = new Button();
            Btncancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            Txtusuario = new TextBox();
            txtcontraseña = new TextBox();
            SuspendLayout();
            // 
            // Btningresar
            // 
            Btningresar.Location = new Point(112, 267);
            Btningresar.Name = "Btningresar";
            Btningresar.Size = new Size(75, 23);
            Btningresar.TabIndex = 0;
            Btningresar.Text = "Ingresar";
            Btningresar.UseVisualStyleBackColor = true;
            Btningresar.Click += Btningresar_Click;
            // 
            // Btncancelar
            // 
            Btncancelar.Location = new Point(244, 267);
            Btncancelar.Name = "Btncancelar";
            Btncancelar.Size = new Size(75, 23);
            Btncancelar.TabIndex = 1;
            Btncancelar.Text = "Cancelar";
            Btncancelar.UseVisualStyleBackColor = true;
            Btncancelar.Click += Btncancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 84);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 185);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // Txtusuario
            // 
            Txtusuario.Location = new Point(112, 76);
            Txtusuario.Name = "Txtusuario";
            Txtusuario.Size = new Size(205, 23);
            Txtusuario.TabIndex = 4;
            // 
            // txtcontraseña
            // 
            txtcontraseña.Location = new Point(114, 177);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.Size = new Size(205, 23);
            txtcontraseña.TabIndex = 5;
            // 
            // Form1login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 333);
            Controls.Add(txtcontraseña);
            Controls.Add(Txtusuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Btncancelar);
            Controls.Add(Btningresar);
            Name = "Form1login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btningresar;
        private Button Btncancelar;
        private Label label1;
        private Label label2;
        private TextBox Txtusuario;
        private TextBox txtcontraseña;
    }
}
