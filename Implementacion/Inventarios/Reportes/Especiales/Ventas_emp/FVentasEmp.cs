using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inventarios.Reportes.Especiales.Ventas_emp
{
    public partial class FVentasEmp : Form
    {
        MySqlConnection con;
        dataSet_inventarios ds;
        crVentasEmp reporte;
        string query,fechaIni;

        public FVentasEmp()
        {
            InitializeComponent();
            con = new MySqlConnection("server=localhost;user id=root;password=root;database=si_inventarios");
            reporte = new crVentasEmp();
        }

        public void cargarReporte()
        {
            MySqlDataAdapter adapter;
            
            fechaIni = dtp.Value.Year.ToString() + "/" + dtp.Value.Month.ToString() + "/" + dtp.Value.Day.ToString();

            try
            {
                crearConsulta();
                ds = new dataSet_inventarios();
                adapter = new MySqlDataAdapter(query, con);
                adapter.Fill(ds, "VentasEmp");
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
            query = "select e.id_empleado,e.nombre,count(v.id_venta) as n_ventas,v.total " +
                    "from Empleados e,Ventas v where e.id_empleado = v.id_empleado " +
                    "and v.fecha = '" + fechaIni + "' group by e.id_empleado";
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            cargarReporte();
        }
    }
}
