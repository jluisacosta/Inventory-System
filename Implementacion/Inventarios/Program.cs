using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Inventarios.Formularios;
using Inventarios.Reportes.Movimientos;
using Inventarios.Reportes.Ordenes_Compra;
using Inventarios.Reportes.Facturas_Clientes;
using Inventarios.Reportes.Proveedores_Activos;
using Inventarios.Reportes.Orden_Produccion;
using Inventarios.Reportes.Facturas;
<<<<<<< HEAD
using Inventarios.Reportes.Pruebas;
=======
using Inventarios.Reportes.Especiales.Porcentaje_prov;
>>>>>>> f30243cc61b400b2b8f77c712dea428bd9ab79f8

namespace Inventarios
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FPrueba1());
        }
    }
}
