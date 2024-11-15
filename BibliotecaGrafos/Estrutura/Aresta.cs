using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGrafos.Estrutura
{
    // construindo a classe da aresta que representa as relações entre os vértices
    public class Aresta
    {
        public int Id { get; set; }
        public Vertice VerticeOrigem { get; set; }
        public Vertice VerticeDestino { get; set; } 
        public int Peso { get; set; } 

        // construtor
        public Aresta(Vertice v_origem, Vertice v_destino, int peso)
        {
            VerticeOrigem = v_origem;
            VerticeDestino = v_destino;
            Peso = peso;
        }
    }
}
