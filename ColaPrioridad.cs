using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo.Dijkstra
{
    public class ColaPrioridad
    {
        private int capacidad;
        private int conteo;
        private int indiceInicio;
        private int indiceFin;
        private NodoPrioritario[] datos;

        private class NodoPrioritario
        {
            public int Nodo;
            public int Prioridad;
        }

        public ColaPrioridad(int capacidadMaxima)
        {
            capacidad = capacidadMaxima;
            conteo = 0;
            indiceInicio = 0;
            indiceFin = 0;
            datos = new NodoPrioritario[capacidad];
        }

        public bool EstaVacia()
        {
            return conteo == 0;
        }

        public bool EstaLlena()
        {
            return conteo == capacidad;
        }

        public void Enqueue(int nodo, int prioridad)
        {
            if (EstaLlena())
                throw new InvalidOperationException("Cola llena");
            NodoPrioritario np = new NodoPrioritario();
            np.Nodo = nodo;
            np.Prioridad = prioridad;
            datos[indiceFin] = np;
            indiceFin = (indiceFin + 1) % capacidad;
            conteo++;
        }

        public int DequeueMin()
        {
            if (EstaVacia())
                throw new InvalidOperationException("Cola vacía");
            int mejorIdx = indiceInicio;
            int mejorPrio = datos[indiceInicio].Prioridad;
            for (int i = 1; i < conteo; i++)
            {
                int idx = (indiceInicio + i) % capacidad;
                if (datos[idx].Prioridad < mejorPrio)
                {
                    mejorPrio = datos[idx].Prioridad;
                    mejorIdx = idx;
                }
            }
            int nodoMin = datos[mejorIdx].Nodo;
            for (int i = 0; i < conteo - 1; i++)
            {
                int desde = (mejorIdx + 1 + i) % capacidad;
                int hasta = (mejorIdx + i) % capacidad;
                datos[hasta] = datos[desde];
            }
            indiceFin = (indiceFin - 1 + capacidad) % capacidad;
            conteo--;
            return nodoMin;
        }
    }
}
