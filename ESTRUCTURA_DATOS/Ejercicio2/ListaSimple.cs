namespace Ejercicio2
{
    class ListaSimple
    {
        private Nodo First ;
        private Nodo Last;
        private Nodo Current;
        public void Insert(Nodo Nodo)
        {
            
            if(First == null){
                First = Nodo;
                Last = Nodo;    
            }
            else
            {
                Last.sig = Nodo;
                Last = Nodo;
            }
        }
        public void Delete(string Nombre)
        {
            while (true)
            {
                
            }
        }
    }
}
