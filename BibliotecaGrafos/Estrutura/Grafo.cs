using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGrafos.Estrutura
{
    // um grafo é um conjunto de vertices e suas relações 
    public class Grafo(List<Vertice> vertices, List<Aresta> arestas)
    {
        // criando lista de vertices (ex: ["A", "B", "C"]) 
        public List<Vertice> Vertices { get; set; } = vertices;

        // criando lista de arestas (ex: [("A", "B"), ("A", "C"), ("B", "C")]
        public List<Aresta> Arestas { get; set; } = arestas;
    }
}
