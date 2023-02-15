using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.model;

namespace WindowsFormsApp1.repositorio
{
    public interface Irepositorio
    {

        IEnumerable<ModeloUsuarios> GetTodo();
        IEnumerable<ModeloUsuarios> GetPorId(string valor);

        IEnumerable<lecturaUsuario> GetlecturasUsuario( string id);
    }
}
