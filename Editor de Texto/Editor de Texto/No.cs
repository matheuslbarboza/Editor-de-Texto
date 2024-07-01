using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor_de_Texto
{
    internal class No
    {
        public string Valor { get; set; }
        public No Proximo { get; set; }
        public No Anterior { get; set; }

        public No(string valor)
        {
            Valor = valor;
            Proximo = null;
            Anterior = null;
        }

    }
}
