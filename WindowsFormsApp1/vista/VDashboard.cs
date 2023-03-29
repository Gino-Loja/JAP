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
    public partial class VDashboard : Form, IDashboard
    {
        public VDashboard()
        {
            InitializeComponent();
        }


        private static VDashboard instancia;

        public event EventHandler EventoBuscar;
        public event EventHandler EventoSelecionarUsuario;

        public string UsuarioNombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Usuarioid { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int UsuarioEdad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UsuarioDiscapacidad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string BuscarUsuario { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int PagoUsuario { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string IdObetnidoDataGrid { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public static VDashboard Instancia_Dashboard(Form ContenedorPadre)
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new VDashboard();
                instancia.MdiParent = ContenedorPadre;
                instancia.Dock = DockStyle.Fill;


            }
            else
            {
                if(instancia.WindowState == FormWindowState.Minimized)
                {
                    instancia.WindowState = FormWindowState.Normal; 
                }
                instancia.BringToFront();
            }
            return instancia;
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

      
    }
}
