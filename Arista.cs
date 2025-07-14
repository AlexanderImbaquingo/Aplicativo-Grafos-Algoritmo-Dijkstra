namespace Aplicativo.Dijkstra
{
    public class Arista
    {
        public int Origen { get; }
        public int Destino { get; }
        public int Peso { get; }

        public Arista(int origen, int destino, int peso)
        {
            Origen = origen;
            Destino = destino;
            Peso = peso;
        }
    }
}
