using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Inventarios
{
    class Simulacion
    {
        List<int> idProducts;
        private MySqlConnection conexion;
        private MySqlCommand cmd;
        private DataTable productos;
        private Random aleatorio;
        
        private string query;
        
        public Simulacion()
        {
            aleatorio = new Random();
            conexion = new MySqlConnection("server=localhost;user id=root;password=root;database=si_inventarios");
            productos = new DataTable();
            idProducts = new List<int>();

            new MySqlDataAdapter("select id_articulo,precio from inventarios where tipo_articulo='Producto'", conexion).Fill(productos);
        }

        private void ejecutaConsulta()
        {
            conexion.Open();
            try
            {
                cmd = conexion.CreateCommand();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        public void Iniciar()
        {
            int totalSer, numVenta = 0;

            for (int d = 0; d < 2400; d++)
            {
                totalSer = aleatorio.Next(200, 250);
                for (int i = 0; i < totalSer; i++)
                    crearVenta(++numVenta);
            }
        }

        public void crearVenta(int idVenta)
        {
            List<List<object>> dV;
            int idEmp,totalDeta,cantPro,idPro,numPro;
            float precio, subT, totalNeto, IVA;

            dV = new List<List<object>>();
            
            numPro = aleatorio.Next(10);
            totalDeta = aleatorio.Next(1,10);
            subT = totalNeto = idPro = 0;
            precio = 0;
            idProducts.Clear();

            for (int i = 0; i < totalDeta; i++)
            {
                //Se crea un detalle de venta
                dV.Add(new List<object>());
                //Se recupera un producto y su precio
                obtenerProducto(ref idPro,ref precio);
                cantPro = aleatorio.Next(1,5);

                //Crear registro del producto
                dV[i].Add(idVenta);
                dV[i].Add(idPro);
                dV[i].Add(cantPro);
                
                subT += precio * cantPro;
                dV[i].Add(subT);
                totalNeto += subT;
            }

            IVA = totalNeto * 0.16f;
            idEmp = 1;//aleatorio.Next(50);//Todos los empleados
            totalNeto += IVA;
            query = "INSERT INTO VENTAS (fecha,id_empleado,iva,total)VALUES ('2014/02/06',1," + IVA + "," + totalNeto + ")";
            ejecutaConsulta();
            
            foreach (List<object> lo in dV)
            {
                query = "INSERT INTO DETALLE_VENTA (id_venta,id_articulo,cantidad,subtotal) VALUES ("+
                lo[0].ToString()+","+lo[1].ToString()+","+lo[2].ToString()+","+lo[3].ToString()+")";
                ejecutaConsulta();
            }
        }

        private void obtenerProducto(ref int id, ref float precio)
        {
            int idP;
            
            while (true)
            {
                idP = aleatorio.Next(productos.Rows.Count);
                if (!idProducts.Contains(idP))
                {
                    idProducts.Add(idP);
                    break;
                }
            }

            id = (int)productos.Rows[idP][0];
            precio = Convert.ToSingle(productos.Rows[idP][1]);
        }
    }
}
