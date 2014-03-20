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
        string query,fechaIni,fechaFin;
        int N;

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
            fechaIni = dtp.Value.Year.ToString() + "/" + dtp.Value.Month.ToString() + "/" + dtp.Value.Day.ToString();
            fechaFin = dtp2.Value.Year.ToString() + "/" + dtp2.Value.Month.ToString() + "/" + dtp2.Value.Day.ToString();

            crearConsulta();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query,con);
        
            adapter.Fill(ds,"Mas_Menos_Vendidos");
            reporte.SetDataSource(ds);
            crv.ReportSource = reporte;
        }

        public void crearConsulta()
        {
            query = "SELECT p.id_producto, CONCAT(p.categoria, ' de ', p.nombre) AS Producto, SUM(dv.cantidad) AS Cantidad, SUM(dv.subtotal) AS T" +
                "FROM productos p INNER JOIN detalle_venta dv ON p.id_producto = dv.id_producto INNER JOIN " +
                "ventas v ON dv.id_venta = v.id_venta" +
                "WHERE v.fecha >= '" + fechaIni + "' AND v.fecha < '" + fechaFin +
                "' GROUP BY p.id_producto ORDER BY T DESC LIMIT 10";
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            cargarReporte();
        }
    }
}




