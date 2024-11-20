using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaGrafos.Estrutura;

namespace BibliotecaGrafos.Interfaces
{
    public interface IGrafo
    {
        // verifica se grafo é vazio
        bool IsGrafoVazio();

        // verifica se grafo é completo 
        bool IsGrafoCompleto();

        // verifica se o grafo é direcionado
        bool IsDirecionado();

        // obtém todos os vértices do grafo 
        List<Vertice> GetVertices();

        // obtém qtd total de vértices do grafo
        int GetQtdVertices();

        // retorna se o vértice procurado existe no grafo
        bool HasVertice(string id_vertice);

        // verifica adjacência entre dois vértices
        bool IsVerticeAdjacente(int v_origem, int v_destino);

        // adicionar um vértice ao grafo
        void AddVertice(string id, string nome);

        // remover um vértice do grafo (e consequentemente suas arestas adjacentes)
        void RemoveVertice(string id);

        // pondera vértice com peso específico
        void PonderarVertice(string id_vertice, int peso);

        // rotula vértice com nome desejado
        void RotularVertice(string id_vertice, string nome);

        // obtém todas as arestas do grafo 
        List<Aresta> GetAresta();

        // obtém qtd total de arestas do grafo
        int GetQtdAresta();

        // retorna se a aresta procurada existe no grafo
        bool HasAresta(string id_aresta);

        // verifica adjacencia entre duas arestas
        bool IsArestasAdjacentes(Aresta a1, Aresta a2);

        // adicionar aresta ao grafo
        void AddAresta(string v_origem, string v_destino, int peso);

        // remover uma aresta do grafo 
        void RemoveAresta(string v_origem, string v_destino);

        // pondera aresta com peso específico
        void PonderarAresta(string v_origem, string v_destino, int peso);

        // rotula aresta com nome desejado
        void RotularAresta(string v_origem, string v_destino, string nome);

        // verifica se grafo é simplesmente conexo
        bool IsSimplesmenteConexo();

        // verifica se grafo é semi-fortemente conexo
        bool IsSemiFortementeConexo();

        // verifica se grafo é fortemente conexo
        bool IsFortementeConexo();

        // checagem de quantidade de componentes fortemente conexos com Kosaraju
        int GetQtdComponentesFortementeConexos();

        // verificando pontes
        List<Aresta> GetPontes();

        // verificando articulações
        List<Vertice> GetArticulacoes();
    }
}
