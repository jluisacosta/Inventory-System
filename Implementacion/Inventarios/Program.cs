using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Inventarios.Formularios;
using Inventarios.Reportes.Movimientos;
using Inventarios.Reportes.Ordenes_Compra;
<<<<<<< HEAD
using Inventarios.Reportes.Facturas_Clientes;
using Inventarios.Reportes.Proveedores_Activos;
=======
using Inventarios.Reportes.Corte;
using Inventarios.Reportes.OCxProveedor;
>>>>>>> 9e3d15e071b2bc272fc096781ad9f324353ca502

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
            Application.Run(new FReportes());
        }
    }
}
