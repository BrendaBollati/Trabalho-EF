using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace PersistenceProject
{
    public class Repositorio
    {
        private IList<Categoria> categorias = new List<Categoria>();
        private IList<Departamento> departamentos = new List<Departamento>();
        private IList<Marca> marcas = new List<Marca>();
        private IList<PrecoVenda> precoVendas = new List<PrecoVenda>();
        private IList<Produto> produtos = new List<Produto>();
        private IList<ProdutoSimilar> produtoSimilares = new List<ProdutoSimilar>();
        private IList<Subcategoria> subcategorias = new List<Subcategoria>();
        private IList<UnidadeMedida> unidadeMedidas = new List<UnidadeMedida>();

        public Categoria AdicionarCategoria(Categoria categoria)
        {
            this.categorias.Add(categoria);
            return categoria;
        }
        public Categoria RemoverCategoria(Categoria categoria)
        {
            this.categorias.Remove(categoria);
            return categoria;
        }
        public IList<Categoria> GetAllCategorias()
        {
            return this.categorias;
        }
        public Categoria UpdateCategoria(Categoria categoria)
        {
            this.categorias[this.categorias.IndexOf(categoria)] = categoria;
            return categoria;
        }
        //--------------------------------------------------------------------------------

        public Departamento AdicionarDepartamento(Departamento departamento)
        {
            this.departamentos.Add(departamento);
            return departamento;
        }
        public Departamento RemoverDepartamento(Departamento departamento)
        {
            this.departamentos.Remove(departamento);
            return departamento;
        }
        public IList<Departamento> GetAllDepartamentos()
        {
            return this.departamentos;
        }
        public Departamento UpdateDepartamentos(Departamento departamento)
        {
            this.departamentos[this.departamentos.IndexOf(departamento)] = departamento;
            return departamento;
        }
        //-----------------------------------------------------------------------------------

        public Marca AdicionarMarca(Marca marca)
        {
            this.marcas.Add(marca);
            return marca;
        }
        public Marca RemoverMarca(Marca marca)
        {
            this.marcas.Remove(marca);
            return marca;
        }
        public IList<Marca> GetAllMarcas()
        {
            return this.marcas;
        }
        public Marca UpdateMarca(Marca marca)
        {
            this.marcas[this.marcas.IndexOf(marca)] = marca;
            return marca;
        }
        //-----------------------------------------------------------------------------------

        public PrecoVenda AdicionarPrecaVenda(PrecoVenda precoVenda)
        {
            this.precoVendas.Add(precoVenda);
            return precoVenda;
        }
        public PrecoVenda RemoverPrecoVenda(PrecoVenda precoVenda)
        {
            this.precoVendas.Remove(precoVenda);
            return precoVenda;
        }
        public IList<PrecoVenda> GetAllPrecoVendas()
        {
            return this.precoVendas;
        }
        public PrecoVenda UpdatePrecoVenda(PrecoVenda precoVenda)
        {
            this.precoVendas[this.precoVendas.IndexOf(precoVenda)] = precoVenda;
            return precoVenda;
        }
        //-----------------------------------------------------------------------------

        public Produto AdicionarProduto(Produto produto)
        {
            this.produtos.Add(produto);
            return produto;
        }
        public Produto RemoverProduto(Produto produto)
        {
            this.produtos.Remove(produto);
            return produto;
        }
        public IList<Produto> GetAllProdutos()
        {
            return this.produtos;
        }
        public Produto UpdateProduto(Produto produto)
        {
            this.produtos[this.produtos.IndexOf(produto)] = produto;
            return produto;
        }
        //-------------------------------------------------------------------------------

        public ProdutoSimilar AdicionarProdutoSimilar(ProdutoSimilar produtoSimilar)
        {
            this.produtoSimilares.Add(produtoSimilar);
            return produtoSimilar;
        }
        public ProdutoSimilar RemoverProdutoSimilar(ProdutoSimilar produtoSimilar)
        {
            this.produtoSimilares.Remove(produtoSimilar);
            return produtoSimilar;
        }
        public IList<ProdutoSimilar> GetAllProdutoSimilares()
        {
            return this.produtoSimilares;
        }
        public ProdutoSimilar UpdateProdutoSimilar(ProdutoSimilar produtoSimilar)
        {
            this.produtoSimilares[this.produtoSimilares.IndexOf(produtoSimilar)] = produtoSimilar;
            return produtoSimilar;
        }
        //--------------------------------------------------------------------------------------------

        public Subcategoria AdicionarSubcategoria(Subcategoria subcategoria)
        {
            this.subcategorias.Add(subcategoria);
            return subcategoria;
        }
        public Subcategoria RemoverSubcategoria(Subcategoria subcategoria)
        {
            this.subcategorias.Remove(subcategoria);
            return subcategoria;
        }
        public IList<Subcategoria> GetAllSubcategorias()
        {
            return this.subcategorias;
        }
        public Subcategoria UpdateSubcategorias(Subcategoria subcategoria)
        {
            this.subcategorias[this.subcategorias.IndexOf(subcategoria)] = subcategoria;
            return subcategoria;
        }
        //-----------------------------------------------------------------------------------

        public UnidadeMedida AdicionarUnidadeMedida(UnidadeMedida unidadeMedida)
        {
            this.unidadeMedidas.Add(unidadeMedida);
            return unidadeMedida;
        }
        public UnidadeMedida RemoverUnidadeMedida(UnidadeMedida unidadeMedida)
        {
            this.unidadeMedidas.Remove(unidadeMedida);
            return unidadeMedida;
        }
        public IList<UnidadeMedida> GetAllUnidadeMedidas()
        {
            return this.unidadeMedidas;
        }
        public UnidadeMedida UpdateUnidadeMedida(UnidadeMedida unidadeMedida)
        {
            this.unidadeMedidas[this.unidadeMedidas.IndexOf(unidadeMedida)] = unidadeMedida;
            return unidadeMedida;
        }
        //-------------------------------------------------------------------------------
    }
}
