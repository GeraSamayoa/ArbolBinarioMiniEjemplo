namespace ArbolBinario.Models
{
    public class NodoArbol
    {
        public NodoArbol RamaIzquierda { get; set; }
        public NodoArbol RamaDerecha { get; set; }

        public object DatoInformacion { get; set; }

        public NodoArbol()
        {
            RamaIzquierda = null;
            RamaDerecha = null;
            DatoInformacion = null;
        }

        public NodoArbol (object datoInformacion )
        {
            RamaIzquierda = null;
            RamaDerecha = null;
            DatoInformacion = datoInformacion;
        }
    }
}
