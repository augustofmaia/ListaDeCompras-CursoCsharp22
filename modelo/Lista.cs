namespace Modelo;

public class Lista {
    public readonly string Nome;
    public DateTime DataDesejadaDaCompra { get; private set; }

    public Lista(string nome, DateTime dataDesejadaDaCompra)
    {
        Nome = nome;
        DataDesejadaDaCompra = dataDesejadaDaCompra;
    }
}