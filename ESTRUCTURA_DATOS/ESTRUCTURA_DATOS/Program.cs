using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTRUCTURA_DATOS
{
    class Program
    {
        static void Main(string[] args)
        {            

            ListaSimple lista = new ListaSimple(10);
            lista.insertLast(new Nodo("Aurora"));
            lista.insertLast(new Nodo("Daniel"));
            lista.insertFirst(new Nodo("Fernando"));
            lista.insert(new Nodo("Pablo"), 3);            
            lista.search("Aurora");
            lista.insertLast(new Nodo("Arian"));
            lista.remove("Daniel");

        }
    }
}
