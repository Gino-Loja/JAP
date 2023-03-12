using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.vista;

namespace WindowsFormsApp1.Vista
{
    public partial class VCostoM : Form, ICostoM
    {
        public VCostoM()
        {
            InitializeComponent();
        }

        private static VCostoM instancia;
        public static VCostoM Instancia_VCostoM()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new VCostoM();


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
