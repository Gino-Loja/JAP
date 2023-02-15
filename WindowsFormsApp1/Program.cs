using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.presentador;
using WindowsFormsApp1.repositorio;
using WindowsFormsApp1.vista;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=root;database=junta_mariscal;";
            Irepositorio repo = new Repositorio(connectionString);
            Iform1 vis = new Form1();
            new presentadorU(vis, repo);
            Application.Run((Form)vis);
        }
    }
}
