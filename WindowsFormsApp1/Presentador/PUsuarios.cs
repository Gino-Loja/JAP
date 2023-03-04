using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.repositorio;
using WindowsFormsApp1.vista;

namespace WindowsFormsApp1.presentador
{
    public class PUsuarios
    {
        private IUsuarios Vusuario;
        private Irepositorio repo;
       public PUsuarios(IUsuarios Vusuarios, Irepositorio repo)
       {
            this.Vusuario = Vusuarios;
            this.repo = repo;
            this.Vusuario.Show();
       }


    }
}
