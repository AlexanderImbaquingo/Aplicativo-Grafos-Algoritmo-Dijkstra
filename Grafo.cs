using Aplicativo.Dijkstra;
using System.Collections.Generic;

public class Grafo
{
    private Nodo[] listaAristas;

    public Grafo(int numNodos)
    {
        listaAristas = new Nodo[numNodos + 1];
    }

    public void AgregarArista(int origen, int destino, int peso)
    {
        Arista arista = new Arista(origen, destino, peso);
        Nodo nuevoNodo = new Nodo(arista);
        nuevoNodo.Siguiente = listaAristas[origen];
        if (listaAristas[origen] != null)
        {
            listaAristas[origen].Anterior = nuevoNodo;
        }
        listaAristas[origen] = nuevoNodo;
    }

    public List<Arista> ObtenerAristasDesde(int nodo)
    {
        List<Arista> resultado = new List<Arista>();
        Nodo actual = listaAristas[nodo];
        while (actual != null)
        {
            Arista ar = (Arista)actual.Info;
            resultado.Add(ar);
            actual = actual.Siguiente;
        }
        return resultado;
    }

    public int GetNumNodos()
    {
        return listaAristas.Length - 1;
    }
}
