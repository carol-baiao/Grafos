using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGrafos.Estrutura
{
    // separando Vertice em um objeto, visto que um grafo é um conjunto de objetos e suas relações,
    // e para fins de organização do código 
    public class Vertice(string id, string nome, List<Aresta> arestaOrigem, List<Aresta> arestaDestino)
    {
        public string Id_vertice { get; set; } = id;
        public string Nome { get; set; } = nome;
        public List<Aresta> ArestaOrigem { get; set; } = arestaOrigem; // lista de arestas que *saem* do vertice
        public List<Aresta> ArestaDestino { get; set; } = arestaDestino; // lista de arestas que *chegam* no vertice
    }
}
