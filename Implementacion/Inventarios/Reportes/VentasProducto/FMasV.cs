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
            cargarReporte();
        }

        public void cargarReporte()
        {
            prod_mv.Connection = con;
            prod_mv.Fill(ds.Mas_Vendidos,new DateTime(2010,2,1),new DateTime(2010,2,2));
            reporte.SetDataSource(ds);
            crv.ReportSource = reporte;
        }
    }
}
