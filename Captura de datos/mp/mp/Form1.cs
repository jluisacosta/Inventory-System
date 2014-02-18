using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace mp
{
    public partial class Form1 : Form
    {
        MySqlConnection con;
        MySqlCommand comand;
        string sql;

        public Form1()
        {
            InitializeComponent();
            con = new MySqlConnection("server=localhost;user id=root;password=root;persistsecurityinfo=True;database=si_inventarios");
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            sql = "INSERT INTO materiaporproducto (id_materia,id_producto,cantidad) VALUES " +
                  "(" + tb_m.Text + "," + tb_p.Text + "," + tb_c.Text + ")";
            ejecuta();
        }

        public void ejecuta()
        {
            try
            {
                con.Open();
                comand = new MySqlCommand(sql, con);
                comand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Agregado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'si_inventariosDataSet1.inventarios' Puede moverla o quitarla según sea necesario.
            this.inventariosTableAdapter1.Fill(this.si_inventariosDataSet1.inventarios);
            // TODO: esta línea de código carga datos en la tabla 'si_inventariosDataSet.inventarios' Puede moverla o quitarla según sea necesario.
            this.inventariosTableAdapter.Fill(this.si_inventariosDataSet.inventarios);
            // TODO: esta línea de código carga datos en la tabla 'si_inventariosDataSet.inventarios' Puede moverla o quitarla según sea necesario.
            this.inventariosTableAdapter.Fill(this.si_inventariosDataSet.inventarios);
            // TODO: esta línea de código carga datos en la tabla 'si_inventariosDataSet.inventarios' Puede moverla o quitarla según sea necesario.
            this.inventariosTableAdapter.Fill(this.si_inventariosDataSet.inventarios);

        }

        private void fillBy7ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.inventariosTableAdapter.FillBy7(this.si_inventariosDataSet.inventarios);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy7ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.inventariosTableAdapter.FillBy7(this.si_inventariosDataSet.inventarios);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void inventariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.si_inventariosDataSet);

        }

        private void inventariosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.inventariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.si_inventariosDataSet);

        }
    }
}
