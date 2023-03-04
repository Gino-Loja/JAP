using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.vista;

namespace WindowsFormsApp1.Vista
{
    public class ControladorInstancia
    {
        

        public static Form control( Form formulario)
        {
            if (formulario == null || formulario.IsDisposed)
            {
                formulario = new Form();


            }
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }
                formulario.BringToFront();
            }
            return formulario;
        }


    }
}
