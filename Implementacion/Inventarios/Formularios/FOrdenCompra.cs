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

namespace Inventarios.Formularios
{
    public partial class FOrdenCompra : Form
    {
        private MySqlConnection conexion;


        public FOrdenCompra()
        {
            InitializeComponent();

            conexion = new MySqlConnection("server=localhost; Uid=root; password=root; database=esquemaloc; port=3306");

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }
    }
}
