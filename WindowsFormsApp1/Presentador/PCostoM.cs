using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Vista;

namespace WindowsFormsApp1.Presentador
{
    public class PCostoM
    {
        private ICostoM costo;

        public PCostoM(ICostoM costo)
        {
            this.costo = costo;
            this.costo.Show();
        }
    }
}
