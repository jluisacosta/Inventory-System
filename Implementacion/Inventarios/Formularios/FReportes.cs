using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Inventarios.Reportes.Facturas_Clientes;
using Inventarios.Reportes.Movimientos;
using Inventarios.Reportes.Ordenes_Compra;
using Inventarios.Reportes.Proveedores_Activos;

namespace Inventarios.Formularios
{
    public partial class FReportes : Form
    {
        public FReportes()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FReportes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Facturas_Clientes fac = new Facturas_Clientes();
            fac.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FMovimientos mov = new FMovimientos();
            mov.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FProveedores_Act pro_act = new FProveedores_Act();
            pro_act.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FOrdenes_Compra ord = new FOrdenes_Compra();
            ord.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
