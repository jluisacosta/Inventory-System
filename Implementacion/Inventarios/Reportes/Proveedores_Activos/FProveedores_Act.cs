using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;
using Inventarios.dataSet_inventariosTableAdapters;

namespace Inventarios.Reportes.Proveedores_Activos
{
    public partial class FProveedores_Act : Form
    {
        MySqlConnection con;
        dataSet_inventarios ds;
        Proveedores_ActivosTableAdapter provee_act;
        cr_Proveedores_Act reporte;

        public FProveedores_Act()
        {
            InitializeComponent();
            con = new MySqlConnection("server=localhost;user id=root;password=root;database=si_inventarios");
            ds = new dataSet_inventarios();
            provee_act = new Proveedores_ActivosTableAdapter();
            reporte = new cr_Proveedores_Act();
        }

        private void bt_generaReporte_Click(object sender, EventArgs e)
        {
            DateTime FI = fecha_Ini.Value;
            DateTime FF = fecha_Fin.Value;

            provee_act.Connection = con;
            provee_act.Fill(ds.Proveedores_Activos, FI, FF);
            reporte.SetDataSource(ds);
            crystalReportViewer1.ReportSource = reporte;
        }
    }
}