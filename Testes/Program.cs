using BibliotecaGrafos.Representacoes.ListaAdjacencia;
using System;

namespace Testes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicializando o grafo como uma lista de adjacência
            ListaAdjacencia grafo = new ListaAdjacencia(5, true);

            // Testando a adição de vértices
            Console.WriteLine("Adicionando vértices...");
            grafo.AddVertice("6", "A");
            grafo.AddVertice("7", "B");
            grafo.AddVertice("8", "C");

            // Mostrando todos os vértices adicionados
            Console.WriteLine("\nLista de Vértices:");
            foreach (var vertice in grafo.GetVertices())
            {
                Console.WriteLine($"ID: {vertice.Id_vertice}, Nome: {vertice.Nome}");
            }

            // Verificando se o grafo é direcionado
            Console.WriteLine($"\nO grafo é direcionado? {grafo.IsDirecionado()}");
        }
    }
}