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

namespace Inventarios.Reportes.Corte
{
    public partial class FCorte : Form
    {
        MySqlConnection con;
        dataSet_inventarios ds;

        CorteTableAdapter corte;
        crCorte reporte;

        public FCorte()
        {
            InitializeComponent();
            con = new MySqlConnection("server=localhost;user id=root;password=root;database=si_inventarios");
            ds = new dataSet_inventarios();
            corte = new CorteTableAdapter();
            reporte = new crCorte();
        }

        public void cargarReporte()
        {
            corte.Connection = con;
            corte.Fill(ds.Corte, dtp.Value);
            reporte.SetDataSource(ds);
            crv.ReportSource = reporte;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            cargarReporte();
        }
    }
}
