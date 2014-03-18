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

namespace Inventarios.Reportes.OCxProveedor
{
    public partial class FOCproveedor : Form
    {
        MySqlConnection con;
        dataSet_inventarios ds;
        OC_por_proveedorTableAdapter ocpp;
        crOCproveedor reporte;

        public FOCproveedor()
        {
            InitializeComponent();
            con = new MySqlConnection("server=localhost;user id=root;password=root;database=si_inventarios");
            ds = new dataSet_inventarios();
            ocpp = new OC_por_proveedorTableAdapter();
            reporte = new crOCproveedor();
            
        }

        public void cargarReporte()
        {
            ocpp.Connection = con;
            ocpp.Fill(ds.OC_por_proveedor, dtp.Value, dtp2.Value);
            reporte.SetDataSource(ds);
            crv.ReportSource = reporte;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            cargarReporte();
        }
    }
}
