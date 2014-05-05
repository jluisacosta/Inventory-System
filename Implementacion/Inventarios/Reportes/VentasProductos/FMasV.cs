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
using Inventarios.Reportes.Pruebas;

namespace Inventarios.Reportes.Movimientos
{
    public partial class FMasV : Form
    {
        MySqlConnection con;
        dataSet_inventarios ds;
        Mas_VendidosTableAdapter prod_mv;
        MasVendidos reporte;
        string query,fechaIni,fechaFin,top_less;

        public FMasV()
        {
            InitializeComponent();
            con = new MySqlConnection("server=localhost;user id=root;password=root;database=si_inventarios");
            prod_mv = new Mas_VendidosTableAdapter();
            reporte = new MasVendidos();
            cb_mmv.SelectedIndex = 0;
            top_less = "DESC";
        }

        public void cargarReporte()
        {
            MySqlDataAdapter adapter;
            
            fechaIni = dtp.Value.Year.ToString() + "/" + dtp.Value.Month.ToString() + "/" + dtp.Value.Day.ToString();
            fechaFin = dtp2.Value.Year.ToString() + "/" + dtp2.Value.Month.ToString() + "/" + dtp2.Value.Day.ToString();

            try
            {
                crearConsulta();
                ds = new dataSet_inventarios();
                adapter = new MySqlDataAdapter(query, con);
                adapter.Fill(ds, "Mas_Menos_Vendidos");
                reporte.SetDataSource(ds);
                crv.ReportSource = reporte;
            }
            catch(FormatException fex)
            {
                MessageBox.Show(fex.Message);
            }
        }

        public void crearConsulta()
        {
            query = "SELECT p.id_producto, CONCAT(p.categoria, ' de ', p.nombre) AS Producto, SUM(dv.cantidad) AS Cantidad, SUM(dv.subtotal) AS T " +
                "FROM productos p INNER JOIN detalle_venta dv ON p.id_producto = dv.id_producto INNER JOIN " +
                "ventas v ON dv.id_venta = v.id_venta" +
                " WHERE v.fecha >= '" + fechaIni + "' AND v.fecha < '" + fechaFin +
                "' GROUP BY p.id_producto ORDER BY T " + top_less + " LIMIT " + Convert.ToInt16(tb_n.Text).ToString();
            
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            cargarReporte();
        }

        private void cb_mmv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_mmv.SelectedIndex == 0)
            {
                top_less = "DESC";
            }
            else
            {
                top_less = "ASC";
            }
        }
    }
}




