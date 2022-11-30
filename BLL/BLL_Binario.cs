using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Binario
    {
       public BE_Binario Convertir(int numero)
        {
            BE_Binario Binario = new BE_Binario();
            int Potencia = 0;

           for (int x = 0; Potencia < numero; x++)
            {
                Potencia = Convert.ToInt32(Math.Pow(Convert.ToDouble(numero),Convert.ToDouble(x)));
            }



            return Binario;
        }

    }
}
