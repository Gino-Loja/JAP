using DocumentFormat.OpenXml.Office2013.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Presentador;
using WindowsFormsApp1.repositorio;
using WindowsFormsApp1.vista;
using WindowsFormsApp1.Vista;

namespace WindowsFormsApp1.presentador
{
    public class PPrincipal
    {
        private Iform1 view;
        private readonly string sqlConexionString;

        public PPrincipal(Iform1 view, string conexion)
        {
            this.view = view;
            this.sqlConexionString = conexion;
            this.view.EventoMostrarDashboard += Dashboard_EventoMostrarDashboard;
            this.view.EventoMostrarVUsuarios += View_EventoMostrarVUsuarios;
            this.view.EventoMostrarVistaPeriodo += View_EventoMostrarVistaPeriodo;
            this.view.EventoMostrarVistaCostoM += View_EventoMostrarVistaCostoM;
            this.view.EventoMostrarVistaConsumos += View_EventoMostrarVistaConsumos;
        }

        private void View_EventoMostrarVistaConsumos(object sender, EventArgs e)
        {
            IConsumos consumo =  VConsumos.Instancia_VConsumos();
            new PConsumos(consumo);
        }

        private void View_EventoMostrarVistaCostoM(object sender, EventArgs e)
        {
            ICostoM costoM = VCostoM.Instancia_VCostoM();
            new PCostoM(costoM);
        }

        private void View_EventoMostrarVistaPeriodo(object sender, EventArgs e)
        {
            IPeriodo periodo = VPeriodo.Instancia_VPeriodo();
            new PPeriodo(periodo);
        }

        private void View_EventoMostrarVUsuarios(object sender, EventArgs e)
        {
            IUsuarios VUsuarios = VUsuario.Instancia_VUsuario();
            Irepositorio repositorio = new Repositorio(sqlConexionString);
            new PUsuarios(VUsuarios, repositorio);
        }

        private void Dashboard_EventoMostrarDashboard(object sender, EventArgs e)
        {
            IDashboard dashboard = VDashboard.Instancia_Dashboard();
            Irepositorio repositorio = new Repositorio(sqlConexionString);
            new PDashboard(dashboard, repositorio);

        }
    }
}
