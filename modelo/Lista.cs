namespace Modelo;

public class Lista {
    public readonly string Nome;
    public DateTime DataDesejadaDaCompra { get; private set; }
    public List<Produto> Produtos {get; private set; } = new List<Produto>();
    public Lista(string nome, DateTime dataDesejadaDaCompra)
    {
        Nome = nome;
        DataDesejadaDaCompra = dataDesejadaDaCompra;
    }

    public void Adicionar(Produto produto){
        Produtos.Add(produto);
    }
    
}