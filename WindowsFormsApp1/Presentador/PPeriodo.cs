using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Vista;

namespace WindowsFormsApp1.Presentador
{
    public class PPeriodo
    {

        private IPeriodo periodo;

        public PPeriodo(IPeriodo periodo)
        {
            this.periodo = periodo;
            this.periodo.Show();
        }
    }
}
