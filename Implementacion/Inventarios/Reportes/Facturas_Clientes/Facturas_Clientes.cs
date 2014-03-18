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

namespace Inventarios.Reportes.Facturas_Clientes
{
    public partial class Facturas_Clientes : Form
    {
        MySqlConnection con;
        dataSet_inventarios ds;
        Facturas_ClienteTableAdapter facturas;
        cr_Facturas_Clientes reporte_fact;

        public Facturas_Clientes()
        {
            InitializeComponent();
            con = new MySqlConnection("server=localhost;user id=root;password=root;database=si_inventarios");
            ds = new dataSet_inventarios();
            facturas = new Facturas_ClienteTableAdapter();
            reporte_fact = new cr_Facturas_Clientes();
        }

        private void bt_generaReporte_Click(object sender, EventArgs e)
        {
            DateTime FI = fecha_Ini.Value;
            DateTime FF = fecha_Fin.Value;

            facturas.Connection = con;
            facturas.Fill(ds.Facturas_Cliente, FI, FF);
            reporte_fact.SetDataSource(ds);
            crystalReportViewer1.ReportSource = reporte_fact;
        }
    }
}
