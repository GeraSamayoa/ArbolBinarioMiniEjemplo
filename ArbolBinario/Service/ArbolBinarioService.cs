using ArbolBinario.Models;

namespace ArbolBinario.Service
{
    public class ArbolBinarioService
    {
        public NodoArbol NodoRaiz { get; set; }

        public ArbolBinarioService() {
            NodoRaiz = null;
        }
        bool ArbolVacio()
        {
            if (NodoRaiz == null)
            {
                return true;
            }
            return false;
        }

        public void PoblarArbol(NodoArbol nodoArbol)
        {
            if (ArbolVacio())
            {
                NodoArbol nodoArbol1 = new NodoArbol();
                Console.WriteLine("Ingrese informacion para el nodo raiz");
                nodoArbol1.DatoInformacion =Console.ReadLine();

                NodoRaiz = nodoArbol1;
                nodoArbol = nodoArbol1;


            }
            string Respuesta = "";
            Console.WriteLine("Existe una rama en el lado izquierdo del nodo raiz");
            Respuesta = Console.ReadLine();

            if (Respuesta.Equals("s") )
            {
                NodoArbol nodoArbol2 = new NodoArbol();
                Console.WriteLine("Ingrese informacion para el nodo");
                nodoArbol2.DatoInformacion = Console.ReadLine();

                nodoArbol.RamaIzquierda = nodoArbol2;

                PoblarArbol(nodoArbol.RamaIzquierda);
            }

            Console.WriteLine("Existe una rama en el lado derecho del nodo raiz");
            Respuesta = Console.ReadLine();

            if (Respuesta.Equals("s"))
            {
                NodoArbol nodoArbol2 = new NodoArbol();
                Console.WriteLine("Ingrese informacion para el nodo");
                nodoArbol2.DatoInformacion = Console.ReadLine();

                nodoArbol.RamaDerecha = nodoArbol2;

                PoblarArbol(nodoArbol.RamaDerecha);
            }

        }
    }
}
