﻿namespace Evaluacion
{
    partial class Forminicio
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
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            Panel = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(891, 100);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(71, 43);
            button2.Name = "button2";
            button2.Size = new Size(182, 23);
            button2.TabIndex = 1;
            button2.Text = "Grafica de cambo peso dolar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(586, 43);
            button1.Name = "button1";
            button1.Size = new Size(138, 23);
            button1.TabIndex = 0;
            button1.Text = "Cambio peso dolar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Panel
            // 
            Panel.Location = new Point(2, 99);
            Panel.Name = "Panel";
            Panel.Size = new Size(888, 414);
            Panel.TabIndex = 1;
            // 
            // Forminicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 512);
            Controls.Add(Panel);
            Controls.Add(panel1);
            Name = "Forminicio";
            Text = "Forminicio";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Panel Panel;
        private Button button2;
    }
}