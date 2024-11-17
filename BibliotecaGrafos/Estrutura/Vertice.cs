using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGrafos.Estrutura
{
    // separando Vertice em um objeto, visto que um grafo é um conjunto de objetos e suas relações,
    // e para fins de organização do código 
    public class Vertice
    {
        public string Id_vertice { get; set; } 
        public string Nome { get; set; } 
        public List<Aresta> ArestaOrigem { get; set; }  // lista de arestas que *saem* do vertice
        public List<Aresta> ArestaDestino { get; set; }  // lista de arestas que *chegam* no vertice

        public Vertice(string id, string nome)
        {
            Id_vertice = id;
            Nome = nome;
            ArestaOrigem = new List<Aresta>();
            ArestaDestino = new List<Aresta>();
        }
    }
}
