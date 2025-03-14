using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion
{
    public partial class Forminicio : Form
    {
        public Forminicio()
        {
            InitializeComponent();
        }

        public void Abrirform(object formgrafica)
        {
            if (this.Panel.Controls.Count > 0)
                this.Panel.Controls.RemoveAt(0);
            Form Fi = formgrafica as Form;
            Fi.TopLevel = false;
            Fi.Dock = DockStyle.Fill;
            this.Panel.Controls.Add(Fi);
            this.Panel.Tag = Fi;
            Fi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Abrirform(new Grafica());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abrirform(new Formdatagred());
        }
    }
}
