using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    class ListaSimple
    {
        // LISTA SIMPLEMENTE ENLAZADA DE DATOS ENTEROS

        int dat = 0;
        private Nodo Primero;
        private int size;
        public ListaSimple()
        {
            this.Primero = null;
            this.size = 0;
        }
        public void Vacia()
        {
            if (Primero == null)
            {
                Console.WriteLine("LISTA VACIA");
            }
            else
            {
                Console.WriteLine("LISTA CON DATOS");
            }
        }
        public void InsertarDato(int dato)
        {
            Nodo Nuevo = new Nodo(dato);
            Nuevo.siguiente = Primero;
            Primero = Nuevo;
            size++;
        }
        public int Size()
        {
            return size;
        }
        public void Visualizar()
        {
            Nodo actual = Primero;
            while (actual != null)
            {
                Console.WriteLine("[" + actual.dato + "]");
                actual = actual.siguiente;
            }
        }
        static void Main(string[] args)
        {
            ListaSimple Lista = new ListaSimple();
            Lista.Vacia();
            Lista.InsertarDato(13);
            Lista.InsertarDato(26);
            Lista.InsertarDato(63);
            Lista.InsertarDato(57);
            Lista.InsertarDato(17);
            Lista.Visualizar();
            Console.WriteLine("TAMAÑO DE LA LISTA: " + Lista.Size());
            Lista.Vacia();
            Console.ReadKey();
        }
    }
}
