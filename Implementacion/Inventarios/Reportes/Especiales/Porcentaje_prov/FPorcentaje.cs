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

namespace Inventarios.Reportes.Especiales.Porcentaje_prov
{
    public partial class FPorcentaje : Form
    {
        MySqlConnection con;
        dataSet_inventarios ds;
        crPorcentaje reporte;
        string query,fechaIni,fechaFin,top_less;

        public FPorcentaje()
        {
            InitializeComponent();
            con = new MySqlConnection("server=localhost;user id=root;password=root;database=si_inventarios");
            reporte = new crPorcentaje();
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
                adapter.Fill(ds, "Porcentaje_Prov");
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
            query = "select mp.id_materia,mp.nombre,p.razon_social,count(mp.id_materia) as ordenes,sum(oc.costo_total) as Total "+
            "from materias_primas mp, ordenes_compra oc, detalle_compra dc, proveedores p "+
            "where mp.id_materia = dc.id_materia_prima and oc.id_orden_compra = dc.id_orden_compra "+
            "and oc.id_proveedor = p.id_proveedor and oc.fecha_pedido >= '" + fechaIni + "' and oc.fecha_pedido < '" + fechaFin +"' "+
            "group by oc.id_proveedor order by Total " + top_less + " limit " + Convert.ToInt16(tb_n.Text).ToString();
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
