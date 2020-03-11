using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTRUCTURA_DATOS
{
    class ListaSimple
    {
        public ListaSimple( )
        {

        }
        public ListaSimple(int size){
            setSize(size);
        }

        private int size;
        private Nodo First;
        private Nodo Current;
        private Nodo Last;
 
        public void setSize(int cant)
        {
            size = cant;
        }
        public bool isEmpty()
        {
            return First == null;
        }
        public bool isFull()
        {
            Current = First;
            int c = 0;
            while (Current != null)
            {
                Current = Current.sig;
                c++;
            }
            Current = null;
            return c == size;
        }
        public void insertLast(Nodo nodo)
        {
            if (!isFull())
            {
                if (First == null)
                {
                    First = nodo;
                    Last = nodo;
                }
                else
                {
                    Last.sig = nodo;
                    Last = nodo;
                }
            }
            else
            {
                throw new Exception("Lista al maximo...");
            }                         
        }
        public void insertFirst(Nodo nodo)
        {
            if (!isFull())
            {
                if (First == null)
                {
                    First = nodo;
                    Last = nodo;
                }
                else
                {
                    nodo.sig = First;
                    First = nodo;
                }
            }
            else
            {
                throw new Exception("Lista al maximo...");
            }
        }
        public void insert(Nodo nodo,int pos)
        {
            if (!isFull())
            {
                if (First == null)
                {
                    First = nodo;
                    Last = nodo;
                }
                else if (pos == 0)
                {
                    nodo.sig = First;
                    First = nodo;
                }
                else
                {
                    int c = 0;
                    Current = First;
                    while (Current != null)
                    {
                        c++;                     
                        if (c == pos)
                        {
                            nodo.sig = Current.sig;
                            Current.sig = nodo;
                            break;
                        }
                        else
                        {
                            Current = Current.sig;
                        }                        
                    }
                    Current = null;
                    if (c != pos) throw new Exception("Esa posicion aun no se encuentra");                
                }
            }
            else
            {
                throw new Exception("Lista al maximo...");
            }
        }
        public bool remove(string Nombre)
        {
            Current = First;
            if (Current.Nombre.Equals(Nombre))
            {
                First = Current.sig;
                return true;
            }
            while(Current != null)
            {
                if (Current.sig.Nombre.Equals(Last.Nombre))
                {
                    Current.sig = null;
                    Last = Current;

                    return true;
                }
                else if (Current.sig.Nombre.Equals(Nombre))
                {
                    Current.sig = Current.sig.sig;
                    return true;
                }
                Current = Current.sig;                
            }
            return false;
        }
        public int indexOf(string Nombre)
        {
            Current = First;
            int c = 0;
            while (Current != null)
            {
                if (Current.Nombre.Equals(Nombre))return c;

                Current = Current.sig;
                c++;
            }
            return -1;
        }
        public int countKey(string Nombre)
        {
            Current = First;
            int c = 0;
            while (Current != null)
            {
                if (Current.Nombre.Equals(Nombre)) c++;

                Current = Current.sig;
            }
            return c;
        }
        public Nodo search(string Nombre)
        {
            Current = First;
            while (Current != null)
            {
                if (Current.Nombre.Equals(Nombre)) return Current;
                Current = Current.sig;
            }
            return null;
        }
        public Nodo search(string Nombre, int pos)
        {
            Current = First;
            int c = 0;
            while (Current != null )
            {
                if (c >= pos && Current.Nombre.Equals(Nombre)) return Current;
                c++;
                Current = Current.sig;
            }
            return null;
        }
    }
}
