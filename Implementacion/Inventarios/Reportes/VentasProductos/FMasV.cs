using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Inventarios.dataSet_inventariosTableAdapters;
using Inventarios.Reportes.VentasProductos;

namespace Inventarios.Reportes.Movimientos
{
    public partial class FMasV : Form
    {
        MySqlConnection con;
        dataSet_inventarios ds;
        Mas_VendidosTableAdapter prod_mv;
        MasVendidos reporte;

        public FMasV()
        {
            InitializeComponent();
            con = new MySqlConnection("server=localhost;user id=root;password=root;database=si_inventarios");
            ds = new dataSet_inventarios();
            prod_mv = new Mas_VendidosTableAdapter();
            reporte = new MasVendidos();
        }

        public void cargarReporte()
        {
            prod_mv.Connection = con;
            prod_mv.Fill(ds.Mas_Vendidos,dtp.Value,dtp2.Value);
            reporte.SetDataSource(ds);
            crv.ReportSource = reporte;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            cargarReporte();
        }
    }
}
