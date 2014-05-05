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

namespace Inventarios.Reportes.Orden_Produccion
{
    public partial class FOrden_Produccion : Form
    {
        private MySqlConnection con;
        private dataSet_inventarios ds;
        private Orden_ProduccionTableAdapter orden_prod;
        private crOrdenProduccion reporte;
        private int id_orden;       

        public FOrden_Produccion(int id_orden_prod)
        {
            InitializeComponent();
            id_orden = id_orden_prod;
            
            con = new MySqlConnection("server=localhost;user id=root;password=root;database=si_inventarios");
            ds = new dataSet_inventarios();
            orden_prod = new Orden_ProduccionTableAdapter();
            reporte = new crOrdenProduccion();
            cargarReporte();
        }

        private void cargarReporte()
        {
            orden_prod.Connection = con;
            orden_prod.Fill(ds.Orden_Produccion,id_orden);
            reporte.SetDataSource(ds);
            crv.ReportSource = reporte;
        }
    }
}
