using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Vista;

namespace WindowsFormsApp1.Presentador
{
    public class PConsumos
    {
        private IConsumos consumo;

        public PConsumos(IConsumos consumo)
        {
            this.consumo = consumo;
            this.consumo.Show();
        }
    }
}
