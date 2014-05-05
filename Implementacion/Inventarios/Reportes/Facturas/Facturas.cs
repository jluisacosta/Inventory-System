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

namespace Inventarios.Reportes.Facturas
{
    public partial class Facturas : Form
    {
        private MySqlConnection con;
        private dataSet_inventarios ds;
        private FacturasTableAdapter facturas;
        private crFacturas reporte;
        private int id_fact;

        public Facturas(int id_fa)
        {
            InitializeComponent();

            id_fact = id_fa;
            con = new MySqlConnection("server=localhost;user id=root;password=root;database=si_inventarios");
            ds = new dataSet_inventarios();
            
            facturas = new FacturasTableAdapter();
            reporte = new crFacturas();
            cargarReporte();
        }

        public void cargarReporte()
        {
            facturas.Connection = con;
            facturas.Fill(ds.Facturas,id_fact);
            reporte.SetDataSource(ds);
            crv.ReportSource = reporte;
        }
    }
}
