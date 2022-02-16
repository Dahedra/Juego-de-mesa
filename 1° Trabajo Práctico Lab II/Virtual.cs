using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1__Trabajo_Práctico_Lab_II
{
    class Virtual : Ficha
    {
        string[] nombreAleatorio = { "Camila", "Florencia", "Cristian", "Jorge"};

        public Virtual(int pos)
        {
            nombre = nombreAleatorio[pos];
        }
    }
}
