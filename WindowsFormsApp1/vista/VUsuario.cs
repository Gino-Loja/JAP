using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.vista
{
    public partial class VUsuario : Form, IUsuarios
    {
        public VUsuario()
        {
            InitializeComponent();
        }



        private static VUsuario instancia;

        public static VUsuario Instancia_VUsuario()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new VUsuario();


            }
            else
            {
                if (instancia.WindowState == FormWindowState.Minimized)
                {
                    instancia.WindowState = FormWindowState.Normal;
                }
                instancia.BringToFront();
            }
            return instancia;
        }
        private void VUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
