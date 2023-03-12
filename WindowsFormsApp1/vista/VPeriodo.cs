﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Vista;

namespace WindowsFormsApp1.vista
{
    public partial class VPeriodo : Form, IPeriodo
    {
        public VPeriodo()
        {
            InitializeComponent();
        }

        private static VPeriodo instancia;
        
        public static VPeriodo Instancia_VPeriodo()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new VPeriodo();


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


        private void VPeriodo_Load(object sender, EventArgs e)
        {

        }
    }
}
