using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGrafos.Estrutura
{
    // um grafo é um conjunto de vertices e suas relações 
    public class Grafo
    {
        // criando lista de vertices (ex: ["A", "B", "C"]) 
        public List<Vertice> Vertices { get; set; } 

        // criando lista de arestas (ex: [("A", "B"), ("A", "C"), ("B", "C")]
        public List<Aresta> Arestas { get; set; }

        // construtor
        // construtor vazio pra deixar o grafo flexivel ao usuario, nao precisando ter ele completo logo na criação
        public Grafo()
        {
            Vertices = new List<Vertice>();
            Arestas = new List<Aresta>();
        }
    }
}
