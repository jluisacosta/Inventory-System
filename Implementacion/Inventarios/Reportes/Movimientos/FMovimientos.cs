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

namespace Inventarios.Reportes.Movimientos
{
    public partial class FMovimientos : Form
    {
        MySqlConnection con;
        dataSet_inventarios ds;
        MovimientosTableAdapter movs;
        Movimientos reporte_mv;

        public FMovimientos()
        {
            InitializeComponent();
            con = new MySqlConnection("server=localhost;user id=root;password=root;database=si_inventarios");
            ds = new dataSet_inventarios();
            movs = new MovimientosTableAdapter();
            reporte_mv = new Movimientos();
            cargarReporte();
        }

        public void cargarReporte()
        {
            movs.Connection = con;
            movs.Fill(ds.Movimientos, new DateTime(2013, 1, 1));
            reporte_mv.SetDataSource(ds);
            crv.ReportSource = reporte_mv;
        }
    }
}
