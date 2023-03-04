using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.model;
using WindowsFormsApp1.repositorio;
using WindowsFormsApp1.vista;

namespace WindowsFormsApp1.presentador
{
    public class PDashboard
    {

        //campos

        private IDashboard vista;
        private Irepositorio repositorio;
        private IEnumerable<ModeloUsuarios> listaUsuarios;
        private IEnumerable<lecturaUsuario> listaLectura;
        private BindingSource recursoUsuario;
        private BindingSource recursoLectura;

        public PDashboard(IDashboard vista, Irepositorio repositorio)
        {
            this.recursoUsuario = new BindingSource();
            this.recursoLectura = new BindingSource();
            this.vista = vista;
            this.repositorio = repositorio;
            this.vista.EventoBuscar += BuscarUsuario;
            this.vista.EventoSelecionarUsuario += SeleccionarUsuario;
           
            CargarUsuarioIniciar();
            this.vista.Show();
        }

        private void SeleccionarUsuario(object sender, EventArgs e)
        {
            listaLectura = this.repositorio.GetlecturasUsuario(this.vista.IdObetnidoDataGrid);
            this.recursoLectura.DataSource = listaLectura;
        }

        private void CargarUsuarioIniciar()
        {
            listaUsuarios = repositorio.GetTodo();
            recursoUsuario.DataSource = listaUsuarios;
            
        }

        private void BuscarUsuario(object sender, EventArgs e)

        {
            
            if (string.IsNullOrWhiteSpace(this.vista.BuscarUsuario))
            {
                listaUsuarios = repositorio.GetTodo();
            }
            else
            {
                listaUsuarios = repositorio.GetPorId(this.vista.BuscarUsuario);

            }

            Console.WriteLine(listaUsuarios.ToList());
            recursoUsuario.DataSource = listaUsuarios;
            //this.vista.EstablecerListaDatagrid(recursoUsuario);
            
        }
    }
}
