using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventarios
{
    class Simulacion
    {
        public void Iniciar()
        {
            int numSer = 250; //200-250
            for (int i = 0; i < numSer; i++)
            {
                crearVenta();
                //
            }
        }

        public void crearVenta()
        {
            int idEmp;
            int totalDeta;
            int cantPro;
            int idPro;
            int numPro;
            float precio, subT, totalNeto, IVA;
            List<List<object>> detalle = new List<List<object>>();

            //Detalle Venta
            numPro = 10;
            totalDeta = 5;//1-5
            subT = 0;
            totalNeto = 0;
            for (int i = 0; i < totalDeta; i++)
            {
                idPro = 1;//
                //Sacar precio
                precio = 2.5f;
                cantPro = 2;//1-5
                detalle[i] = new List<object>();

                detalle[i].Add(idPro);
                detalle[i].Add(precio);
                detalle[i].Add(cantPro);

                subT += precio * cantPro;
                detalle[i].Add(subT);
                totalNeto += subT;
            }

            IVA = totalNeto * 0.16f;
            idEmp = 1;//Todos los empleados
            totalNeto += IVA;
            //INSERT INTO VENTAS (fecha,id_empleado,iva,total)VALUES (FECHA,idEmp,IVA,totalNeto);
            //ejecutar consulta

            foreach (List<object> lo in detalle)
            {
                string sql = "INSERT INTO DETALLE_VENTA (id_venta,id_producto,cantidad,subtotal) VALUES ("+
                lo[0].ToString()+","+lo[1].ToString()+","+lo[2].ToString()+","+lo[3].ToString()+")";
                //ejecutar consulta
            }

        }

        public void creaOrdenProd(int idPro, int cant)
        {
            int idEmp = 2;//aleatorio entre todos los encargados de produ
            string fechaIni = "", fechaEnt = "";
            
            string sql = "INSERT INTO ORDENES_PRODUCCION (fecha_inicio,fecha_entrega,id_empleado,id_producto,cantidad) VALUES (" +
             fechaIni + "," + fechaEnt + "," + idEmp.ToString() + "," + idPro.ToString()+ ","+ cant.ToString() +")" ;
            
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
