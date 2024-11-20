using BibliotecaGrafos.Estrutura;
using BibliotecaGrafos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGrafos.Representacoes.ListaAdjacencia
{
    public class ListaAdjacencia : IGrafo
    {
        private List<Vertice> vertices;
        private bool isDirecionado;
        private List<List<Aresta>> lista_adjacencia;

        // construtor
        public ListaAdjacencia(int qtd_vertices, bool isDirecionado) // finalizado 
        {
            vertices = new List<Vertice>();
            this.isDirecionado = isDirecionado;
            lista_adjacencia = new List<List<Aresta>>();

            for(int v=1; v <= qtd_vertices; v++)
            {
                string id = v.ToString();
                AddVertice(id, $"v{id}");
            }
        }

        public void AddAresta(string v_origem, string v_destino, int peso)
        {
            throw new NotImplementedException();
        }

        public void AddVertice(string id, string nome) // finalizado
        {
            if(HasVertice(id)) // checando se vertice existe 
            {
                throw new InvalidOperationException($"O vértice de id {id} já existe!");
            } else
            {
                Vertice novo_vertice = new Vertice(id, nome);
                vertices.Add(novo_vertice); // add vertice na lista de vertices
                lista_adjacencia.Add(new List<Aresta>()); // criando a lista de adjacencia do novo vertice

                Console.WriteLine($"O vértice {id} foi adicionado ao Grafo.");
            }
        }

        public List<Aresta> GetAresta()
        {
            throw new NotImplementedException();
        }

        public List<Vertice> GetArticulacoes()
        {
            throw new NotImplementedException();
        }

        public List<Aresta> GetPontes()
        {
            throw new NotImplementedException();
        }

        public int GetQtdAresta()
        {
            throw new NotImplementedException();
        }

        public int GetQtdComponentesFortementeConexos()
        {
            throw new NotImplementedException();
        }

        public int GetQtdVertices() // finalizado
        {
            return vertices.Count;
        }

        public List<Vertice> GetVertices() // finalizado
        {
            return vertices;
        }

        public bool HasAresta(string id_aresta)
        {
            throw new NotImplementedException();
        }

        public bool HasVertice(string id_vertice) // finalizado
        {
            return vertices.Exists(v => v.Id_vertice.Equals(id_vertice));
        }

        public bool IsArestasAdjacentes(Aresta a1, Aresta a2)
        {
            throw new NotImplementedException();
        }

        public bool IsDirecionado() // finalizado
        {
            return this.isDirecionado;
        }

        public bool IsFortementeConexo()
        {
            throw new NotImplementedException();
        }

        public bool IsGrafoCompleto()
        {
            throw new NotImplementedException();
        }

        public bool IsGrafoVazio()
        {
            throw new NotImplementedException();
        }

        public bool IsSemiFortementeConexo()
        {
            throw new NotImplementedException();
        }

        public bool IsSimplesmenteConexo()
        {
            throw new NotImplementedException();
        }

        public bool IsVerticeAdjacente(int v_origem, int v_destino)
        {
            throw new NotImplementedException();
        }

        public void PonderarAresta(string v_origem, string v_destino, int peso)
        {
            throw new NotImplementedException();
        }

        public void PonderarVertice(string id_vertice, int peso)
        {
            throw new NotImplementedException();
        }

        public void RemoveAresta(string v_origem, string v_destino)
        {
            throw new NotImplementedException();
        }

        public void RemoveVertice(string id)
        {
            throw new NotImplementedException();
        }

        public void RotularAresta(string v_origem, string v_destino, string nome)
        {
            throw new NotImplementedException();
        }

        public void RotularVertice(string id_vertice, string nome)
        {
            throw new NotImplementedException();
        }
    }
}