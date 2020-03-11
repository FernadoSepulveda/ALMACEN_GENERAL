using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaSimple l = new ListaSimple();

            l.Insert(new Nodo("Axel"));
            l.Insert(new Nodo("Pelas"));
            l.Insert(new Nodo("Fernando"));
            l.Insert(new Nodo("Pablo"));
            l.Insert(new Nodo("Daniel"));

        }
    }
}
