using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inventarios.Reportes.Pruebas
{
    public partial class FPrueba1 : Form
    {
        public FPrueba1()
        {
            InitializeComponent();
        }

        private void FPrueba1_Load(object sender, EventArgs e)
        {
         
        }

        private void bt_generaReporte_Click(object sender, EventArgs e)
        {
            DateTime FI = fecha_Ini.Value;
            DateTime FF = fecha_Fin.Value;

            this.ventas_EmpleadoTableAdapter.Fill(this.dataSet_inventarios.Ventas_Empleado, FI, FF);
            this.reportViewer1.RefreshReport();
        }


    }
}
