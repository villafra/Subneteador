using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace BLL
{
    public class BLL_Subneteador
    {
        public void Subnetear(BE_Subneteador IPBase, List<int> Hosts)
        {
            List<int> ListaOrdenada = Ordenar(Hosts);

        }

        private List<int> Ordenar(List<int> Hosts)
        {
            int tamaño = Hosts.Count;

            for (int x = 0; x < tamaño; x++)
            {
                int min = x;

                for (int y = x + 1; y < tamaño; y++)
                {
                    if (Hosts[min] > Hosts[y])
                    {
                        min = y;
                    }
                    int aux = Hosts[x];
                    Hosts[x] = Hosts[min];
                    Hosts[min] = aux;
                }
            }
            return Hosts;
        }
    }
}
