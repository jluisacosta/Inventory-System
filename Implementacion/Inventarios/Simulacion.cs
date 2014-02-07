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
        private Random aleatorio;
        private MySqlConnection conexion;
        private MySqlCommand cmd;
        private string query;
        
        public Simulacion()
        {
            aleatorio = new Random();
            conexion = new MySqlConnection("server=localhost;user id=root;password=root;database=si_inventarios");
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
            int numSer = aleatorio.Next(200, 250); //200-250
            
            for (int i = 0; i < numSer; i++)
            {
                crearVenta(i+1);
            }
        }

        public void crearVenta(int idVenta)
        {
            List<List<object>> dV;
            int idEmp,totalDeta,cantPro,idPro,numPro;
            float precio, subT, totalNeto, IVA;

            dV = new List<List<object>>();
            
            //Detalle Venta
            numPro = aleatorio.Next(10);
            totalDeta = aleatorio.Next(5);
            subT = 0;
            totalNeto = 0;

            for (int i = 0; i < totalDeta; i++)
            {
                dV.Add(new List<object>());//Se crea un detalle de venta

                idPro = 1;
                //Sacar precio
                precio = 120.0f;
                cantPro = aleatorio.Next(5);
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

        public void creaOrdenProd(int idPro, int cant)
        {
            int idEmp = 2;//aleatorio entre todos los encargados de produ
            string fechaIni = "", fechaEnt = "";
            
            string sql = "INSERT INTO ORDENES_PRODUCCION (fecha_inicio,fecha_entrega,id_empleado,id_producto,cantidad) VALUES (" +
             fechaIni + "," + fechaEnt + "," + idEmp + "," + idPro+ ","+ cant+")" ;
            
            //execute query
        }

        public void creaOrdenRequisicion(int idPro)
        {
            int idEmp = 2;//aleatorio entre todos los encargados de produ
            string query , fecha = "";

            //Obtener lista de materia para el producto con id = idPro
            query = "SELECT id_materia,cantidad" +
                    "FROM MATERIAS_PRIMAS_POR_PRODUCTO WHERE id_producto = "+idPro;
            //execute query -> ListaMat
        }
    }
}
