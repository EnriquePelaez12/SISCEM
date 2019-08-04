using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SISCEM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //UsuarioId = -1;
           // Usuario = "Luis Miguel Angel Galeana";
           // Application.Run(new Principal());
            //
            Application.Run(new Acceso());
            //Application.Run(new Movimientos());
            //Application.Run(new ReportesClientes());
        }
        public static int UsuarioId { get; set; }
        public static string Usuario { get; set; }
    }
}
