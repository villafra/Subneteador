using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BE_Subneteador
    {
        private string IP { get; set; }
        private string MAC { get; set; }
        private string MACAddress { get; set; }

        public BE_Subneteador(string iP)
        {
            IP = iP;
        }
    }
}
