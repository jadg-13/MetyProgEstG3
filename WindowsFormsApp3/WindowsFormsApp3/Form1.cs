using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.rpt;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. Crear el DataSet
            DataSet dataSet1 = new DataSet("DataSet1");

            // 2. Crear el DataTable
            DataTable dataTable1 = new DataTable("DataTable1");

            // 3. Definir las columnas del DataTable
            dataTable1.Columns.Add("Name", typeof(string));
            dataTable1.Columns.Add("Age", typeof(int));

            // 4. Agregar el DataTable al DataSet
            dataSet1.Tables.Add(dataTable1);

            // 5. Llenar el DataTable con datos
            dataTable1.Rows.Add("Juan", 25);
            dataTable1.Rows.Add("María", 30);
            dataTable1.Rows.Add("Pedro", 22);

            // 6. Configurar el ReportDataSource
            ReportDataSource rds = new ReportDataSource("DataSet1", dataTable1);

            // 7. Limpiar fuentes de datos anteriores (si es necesario)
            this.reportViewer1.LocalReport.DataSources.Clear();

            // 8. Agregar el nuevo ReportDataSource al ReportViewer
            this.reportViewer1.LocalReport.DataSources.Add(rds);

            // 9. Refrescar el ReportViewer para que se muestren los datos
            this.reportViewer1.RefreshReport();
        }
    }
}
