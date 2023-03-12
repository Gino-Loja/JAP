using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Vista
{
    public partial class VConsumos : Form, IConsumos
    {
        public VConsumos()
        {
            InitializeComponent();
        }

        private static VConsumos instancia;
        public static VConsumos Instancia_VConsumos()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new VConsumos();


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
    }
}
