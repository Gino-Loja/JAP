using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.vista
{
    public interface IDashboard
    {

        string UsuarioNombre { get; set; }
        string Usuarioid { get; set; }
        int UsuarioEdad { get; set; }
        string UsuarioDiscapacidad { get; set; }
        string BuscarUsuario { get; set; }
        int PagoUsuario { get; set; }

        string IdObetnidoDataGrid { get; set; }
        event EventHandler EventoBuscar;
        event EventHandler EventoSelecionarUsuario;
     
        void Show();
      
    }
}
