using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class BE_Binario
    {
        public string Numero { get; set; }
        public List<int> Potencias { get; set; }
        public BE_Binario()
        {
            CargarPotencias();
        }

        public void CargarPotencias()
        {
            int potencia = 0;
            int numero = 0;
            while (potencia < 33)
                {
                    numero = Convert.ToInt32(Math.Pow(Convert.ToDouble(2), Convert.ToDouble(potencia++)));
                    Potencias.Add(numero);
                }
        }
    }
}
