namespace Evaluacion
{
    partial class Formdatagred
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
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            btnconsulta = new Button();
            dgvResults = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(21, 58);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(200, 23);
            dtpStartDate.TabIndex = 0;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(21, 127);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(200, 23);
            dtpEndDate.TabIndex = 1;
            // 
            // btnconsulta
            // 
            btnconsulta.Location = new Point(68, 204);
            btnconsulta.Name = "btnconsulta";
            btnconsulta.Size = new Size(110, 44);
            btnconsulta.TabIndex = 2;
            btnconsulta.Text = "Consulta";
            btnconsulta.UseVisualStyleBackColor = true;
            btnconsulta.Click += btnconsulta_Click;
            // 
            // dgvResults
            // 
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Location = new Point(354, 58);
            dgvResults.Name = "dgvResults";
            dgvResults.Size = new Size(412, 251);
            dgvResults.TabIndex = 3;
            // 
            // Formdatagred
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvResults);
            Controls.Add(btnconsulta);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formdatagred";
            Text = "Formdatagred";
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Button btnconsulta;
        private DataGridView dgvResults;
    }
}