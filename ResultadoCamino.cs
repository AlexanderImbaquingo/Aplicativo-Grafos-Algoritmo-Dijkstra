using System.Collections.Generic;
using System.Linq;

namespace Aplicativo.Dijkstra
{
    public class ResultadoCamino
    {
        public List<int> Camino { get; set; }
        public int Destino { get; set; }
        public int PesoTotal { get; }

        public ResultadoCamino(int destino, List<int> camino, int pesoTotal)
        {
            Destino = destino;
            Camino = camino;
            PesoTotal = pesoTotal;
        }
    }
}
