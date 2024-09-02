using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pregunta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNo_MouseHover(object sender, EventArgs e)
        {
            mover();

        }

        private void mover()
        {
            Random random = new Random();
            int x = random.Next(0, this.ClientSize.Width - btnNo.Width);
            int y = random.Next(0, this.ClientSize.Height - btnNo.Height);
            btnNo.Location = new Point(x, y);
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            mover();
            DialogResult resultado = MessageBox.Show(
                "¿Estas seguro que no quiere ser ingeniero 🧐?",
                "ISI",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Tú te lo pierdes.", "ISI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bienvenido a la poderosa carrera de ISI", "ISI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Opacity -= 0.1;
        }


        private void cerrar()
        {
            if(this.Opacity <= 0)
            {
                this.Close();
            }
        }

        private void btnSI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a la poderosa carrera de ISI", "ISI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNo.Visible = false;
        }
    }
}
