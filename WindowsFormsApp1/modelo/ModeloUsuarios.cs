using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.model
{
    public class ModeloUsuarios
    {



        private string id;
        private string nombre  ;
        private string comunidad ;
        private string discapacidad;
        private string edad;
      

        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        
        public string Edad { get => edad; set => edad = value; }
        public string Comunidad { get => comunidad; set => comunidad = value; }
        public string Discapacidad { get => discapacidad; set => discapacidad = value; }
    }
}
