using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inventarios.Formularios
{
    public partial class FClientes : Form
    {
        private Conexion con;

        public FClientes()
        {
            InitializeComponent();
            con = new Conexion();
        }

        private void b_alta_Click(object sender, EventArgs e)
        {
            con.ejecutaConsulta("INSERT INTO Clientes(razon_social,rfc,ciudad,cp,direccion,telefono,email)VALUES('" +
                            tb_rs.Text + "','" + tb_rfc.Text + "','" + tb_ciudad.Text + "','" + tb_cp.Text + "','" + tb_direccion.Text + "','" +
                            tb_tel.Text + "','" + tb_email.Text + "')");
        }
        
        private void b_baja_Click(object sender, EventArgs e)
        {
            con.ejecutaConsulta("DELETE FROM Clientes WHERE id_cliente = "+tb_id.Text);
        }

        private void b_modif_Click(object sender, EventArgs e)
        {
            con.ejecutaConsulta("UPDATE Clientes set razon_social='" + tb_rs.Text +
                                                  "',rfc='" + tb_rfc.Text +
                                                  "',ciudad='" + tb_ciudad.Text +
                                                  "',cp='" + tb_cp.Text +
                                                  "',direccion='" + tb_direccion.Text +
                                                  "',telefono='" + tb_tel.Text +
                                                  "',email='" + tb_email.Text + "' WHERE id_cliente =" + tb_id.Text);
        }

        private void FClientes_Load(object sender, EventArgs e)
        {
          /*  MySqlDataAdapter da =new MySqlDataAdapter("select * from CLIENTE", conexion); 
            DataSet ds = new DataSet(); 
            da.Fill(ds); 
            dataGridView1.DataSource = ds.Tables[0];
            */
         //   sgc_cli.ActiveGrid.DataSource = 
        }
    }
}
