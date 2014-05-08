using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inventarios.Reportes.Especiales.Promedio_comp
{
    public partial class FPromedio : Form
    {
        MySqlConnection con;
        dataSet_inventarios ds;
        crPromedio reporte;
        string query, fechaIni, fechaFin, top_less;

        public FPromedio()
        {
            InitializeComponent();
            con = new MySqlConnection("server=localhost;user id=root;password=root;database=si_inventarios");
            reporte = new crPromedio();
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
                adapter.Fill(ds, "PromedioCompra");
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
            query = "select c.id_cliente,c.razon_social,c.rfc,c.telefono,c.email,count(v.id_venta) ventas,AVG(v.total) promedio " +
                    "from clientes c, facturas f, ventas v where c.id_cliente = f.id_cliente and f.id_venta = v.id_venta " +
                    "and v.fecha >= '" + fechaIni + "' and v.fecha < '" + fechaFin + "' group by c.id_cliente order by promedio "+
                    top_less + " limit " + Convert.ToInt16(tb_n.Text).ToString();
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
