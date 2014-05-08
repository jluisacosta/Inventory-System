using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Inventarios
{
    public class Conexion
    {
        private MySqlConnection con;
        private MySqlCommand cmd;
        
        public Conexion()
        {
            con = new MySqlConnection("server=localhost;user id=root;password=root;database=si_inventarios");
        }

        public void ejecutaConsulta(string query)
        {
            try
            {
                cmd = new MySqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
