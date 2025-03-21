namespace Evaluacion
{
    partial class Grafica
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
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            dtpStartDate = new DateTimePicker();
            dtpEnddate = new DateTimePicker();
            btnconsulta2 = new Button();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(354, 74);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(422, 286);
            formsPlot1.TabIndex = 0;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(66, 74);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(200, 23);
            dtpStartDate.TabIndex = 1;
            // 
            // dtpEnddate
            // 
            dtpEnddate.Location = new Point(66, 142);
            dtpEnddate.Name = "dtpEnddate";
            dtpEnddate.Size = new Size(200, 23);
            dtpEnddate.TabIndex = 2;
            // 
            // btnconsulta2
            // 
            btnconsulta2.Location = new Point(107, 215);
            btnconsulta2.Name = "btnconsulta2";
            btnconsulta2.Size = new Size(110, 46);
            btnconsulta2.TabIndex = 3;
            btnconsulta2.Text = "Consulta";
            btnconsulta2.UseVisualStyleBackColor = true;
            btnconsulta2.Click += btnconsulta2_Click;
            // 
            // Grafica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnconsulta2);
            Controls.Add(dtpEnddate);
            Controls.Add(dtpStartDate);
            Controls.Add(formsPlot1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Grafica";
            Text = "Grafica";
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEnddate;
        private Button btnconsulta2;
    }
}