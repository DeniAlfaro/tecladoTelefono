using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficadorSeñales
{
    class FuncionSigno
    {
        public List<Muestra> Muestras { get; set; }

        public FuncionSigno()
        {
            Muestras = new List<Muestra>();
        }
        public double evaluar(double tiempo)
        {
            double resultado = 0;

            if (tiempo > 0)
            {
                resultado = 1.0;
            }
            if (tiempo == 0)
            {
                resultado = 0;
            }
            if (tiempo < 0)
            {
                resultado = -1;
            }
            

            return resultado;
        }
    }
}
