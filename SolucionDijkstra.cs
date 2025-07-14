using System.Collections.Generic;

namespace Aplicativo.Dijkstra
{
    public class SolucionDijkstra
    {
        public static List<ResultadoCamino> Calcular(Grafo grafo, int inicio)
        {
            int n = grafo.GetNumNodos();
            int INF = int.MaxValue;
            int[] dist = new int[n + 1];
            int[] previo = new int[n + 1];
            bool[] visto = new bool[n + 1];

            for (int i = 1; i <= n; i++)
            {
                dist[i] = INF;
                previo[i] = -1;
                visto[i] = false;
            }
            dist[inicio] = 0;

            for (int k = 1; k <= n; k++)
            {
                int u = -1;
                int min = INF;
                for (int i = 1; i <= n; i++)
                {
                    if (!visto[i] && dist[i] < min)
                    {
                        min = dist[i];
                        u = i;
                    }
                }
                if (u == -1) break;
                visto[u] = true;

                List<Arista> ady = grafo.ObtenerAristasDesde(u);
                for (int j = 0; j < ady.Count; j++)
                {
                    int v = ady[j].Destino;
                    int peso = ady[j].Peso;
                    if (!visto[v] && dist[u] + peso < dist[v])
                    {
                        dist[v] = dist[u] + peso;
                        previo[v] = u;
                    }
                }
            }

            List<ResultadoCamino> resultado = new List<ResultadoCamino>();
            for (int destino = 1; destino <= n; destino++)
            {
                if (destino == inicio) continue;

                if (dist[destino] == INF)
                {
                    resultado.Add(new ResultadoCamino(destino, new List<int>(), INF));
                }
                else
                {
                    List<int> camino = new List<int>();
                    int v = destino;
                    while (v != -1)
                    {
                        camino.Insert(0, v);
                        v = previo[v];
                    }
                    resultado.Add(new ResultadoCamino(destino, camino, dist[destino]));
                }
            }
            return resultado;
        }
    }
}
