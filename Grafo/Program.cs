using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grafo
{
    public class Grafo
    {
        private Dictionary<int, List<int>> vertices;

        public Grafo()
        {
            vertices = new Dictionary<int, List<int>>();
        }

        public void AdicionarVertice(int vertice) {
            if (!vertices.ContainsKey(vertice)) {
                vertices.Add(vertice, new List<int>());
            } else {
                throw new Exception("El vertice ya existe");
            }
        }

        public void AdicionarArista(int origen, int destino) {
            if (vertices.ContainsKey(origen) && vertices.ContainsKey(destino)) {
                vertices[origen].Add(destino);
                vertices[destino].Add(origen);
            } else {
                throw new Exception("Error al agregar arista");
            }
        }

        public void ImprimirGrafo() {
            foreach (var vertice in vertices) {
                Console.Write(vertice.Key + ": ");
                foreach (var arista in vertice.Value) {
                    Console.Write(arista + " ");
                }
                Console.WriteLine();
            }
        }
    }
    public class Program
    {
        public static void Main() {
            var grafo = new Grafo();

            grafo.AdicionarVertice(1);
            grafo.AdicionarVertice(2);
            grafo.AdicionarVertice(3);
            grafo.AdicionarVertice(4);

            grafo.AdicionarArista(1, 2);
            grafo.AdicionarArista(1, 3);
            grafo.AdicionarArista(2, 3);
            grafo.AdicionarArista(2, 4);
            grafo.AdicionarArista(3, 4);

            grafo.ImprimirGrafo();
        }
    }
}