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
            float precio,subT,totalNeto,IVA;
            List<List<object>> detalle = new List<List<object>>();

            //Detalle Venta
            numPro = 10;
            totalDeta = 5;//1-5
            subT = 0;
            totalNeto = 0;
            for (int i = 0; i<totalDeta ; i++)
            {
                idPro = 1;//
                //Sacar precio
                precio = 2.5f;
                cantPro = 2;//1-5
                detalle[i] = new List<object>();

                detalle[i].Add(idPro);
                detalle[i].Add(precio);
                detalle[i].Add(cantPro);

                subT += precio*cantPro;
                totalNeto += subT;
            }

            IVA = totalNeto*0.16f;
            idEmp = 1;//Todos los empleados
            totalNeto += IVA;
            //INSERT INTO VENTAS (fecha,id_empleado,iva,total)VALUES (FECHA,idEmp,IVA,totalNeto);
            
        }
    }
}
