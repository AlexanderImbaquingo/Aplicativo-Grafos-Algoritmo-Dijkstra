namespace Aplicativo.Dijkstra
{
    public class Nodo
    {
        private object info;
        private Nodo siguiente { get; set; }
        private Nodo anterior { get; set; }
        public Nodo(object info)
        {
            this.info = info;
            this.siguiente = null;
        }
        public object Info
        {
            get { return info; }
            set { info = value; }
        }
        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public Nodo Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }
    }
}
