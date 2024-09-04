using Ejemplo1.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMayor_Click(object sender, EventArgs e)
        {
            Operacion op = new Operacion();
            int num1, num2, mayor;
            num1 = Convert.ToInt32(tbNum1.Text);
            num2 = Convert.ToInt32(tbNum2.Text);
            mayor = op.ObtenerMayor(num1, num2);
            MessageBox.Show(mayor.ToString());

        }
    }
}
