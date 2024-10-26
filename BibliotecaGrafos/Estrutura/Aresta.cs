using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGrafos.Estrutura
{
    // construindo a classe da aresta que representa as relações entre os vértices
    public class Aresta(Vertice v_origem, Vertice v_destino, int peso)
    {
        public int Id { get; set; }
        public Vertice VerticeOrigem { get; set; } = v_origem;
        public Vertice VerticeDestino { get; set; } = v_destino;
        public int Peso { get; set; } = peso;
    }
}
