using Modelo;
using Repositorio;

OperacaoInicial();

void OperacaoInicial(){
    while(true){
        Console.WriteLine("Imforme a operação desejada.");
        Console.WriteLine("1 - Criar lista");
        Console.WriteLine("2 - Editar lista");
        Console.WriteLine("3 - Obter lista");
        var operacaoDesejada = Console.ReadLine();
        if(operacaoDesejada == "1")
            OperacaoCriarLista();
        else if(operacaoDesejada == "2")
            OperacaoEditarLista();
        else if(operacaoDesejada == "3")
            OperacaoObterListas();
        else
            OperacaoInicial();
    }    
}

void OperacaoCriarLista(){
    Console.WriteLine("Nome: ");
    var nome = Console.ReadLine();
    Console.WriteLine("Data desejada: ");
    var dataDesejada = Console.ReadLine();
    var dataDesejadaConvertida = DateTime.Parse(dataDesejada);
    var lista = new Lista(nome, dataDesejadaConvertida);
    ListaRepositorio.Adicionar(lista);
    Console.WriteLine($"Lista {lista.Nome} criada para a data {lista.DataDesejadaDaCompra} ");

    OperacaoInicial();
}

void OperacaoEditarLista(){
    while(true){
        Console.WriteLine("Imforme a operação desejada.");
        Console.WriteLine("1 - adicionar produto");
        Console.WriteLine("2 - Editar produto");
        var operacaoDesejada = Console.ReadLine();
        if (operacaoDesejada == "1")
            OperacaoAdicionarProduto();
        else if(operacaoDesejada == "2")
            OperacaoEditarProduto();

        OperacaoInicial();
    }    
}

void OperacaoAdicionarProduto(){
    Console.WriteLine("Informe o nome da lista");
    var nomeDaListaDesejada = Console.ReadLine();
    var listas = ListaRepositorio.ObterTodos();
    var listaDesejada = listas.FirstOrDefault(1 => 1.Nome == nomeDaListaDesejada);
    if (listaDesejada == null){
        Console.WriteLine("Lista não encontrada");
        OperacaoEditarLista();
    }
    Console.WriteLine("Nome do produto:");
    var nomeDoProduto = Console.ReadLine();
    Console.WriteLine("Categoria do produto (0 - Mercado, 1 - Escritorio, 2 - Manutenção):");
    var categoriaDoProdutoConsole = Console.ReadLine();
    var categoriaDoProduto = (CategoriaDoProduto)Enum.Parse(typeof(CategoriaDoProduto), categoriaDoProdutoConsole); 
    var produto = new Produto(nomeDoProduto,categoriaDoProduto);
    listaDesejada.Adicionar(produto);
}

void OperacaoEditarProduto(){
    Console.WriteLine("Informe o nome da lista");
    var nomeDaListaDesejada = Console.ReadLine();
    var listas = ListaRepositorio.ObterTodos();
    var listaDesejada = listas.FirstOrDefault(1 => 1.Nome == nomeDaListaDesejada);
    if (listaDesejada == null){
        Console.WriteLine("Lista não encontrada");
        OperacaoEditarLista();
    }
    Console.WriteLine("Nome do produto:");
    var nomeDoProduto = Console.ReadLine();
    var ProdutoDesejado = listaDesejada.Produtos.FirstOrDefault(p => p.Nome == nomeDoProduto);
    if(ProdutoDesejado == null){
        Console.WriteLine("Produto não encontrada");
        OperacaoEditarLista();
    }
    Console.WriteLine("Valor pago: ");
    var valorPago = Console.ReadLine();
    ProdutoDesejado.informarValorPago(decimal.Parse(valorPago));

}

void OperacaoObterListas(){
    var listas = ListaRepositorio.ObterTodos();
   foreach (var item in listas){
        Console.WriteLine(@$"Lista '{item.Nome}' criada para a data
        {item.DataDesejadaDaCompra} com{item.Produtos.Count()} produto(s)");
        foreach(var produto in item.Produtos){
            Console.WriteLine($"Produto '{produto.Nome}' - {produto.CategoriaDoProduto} com valor {produto.ValorPago}");
        }
   }    
    OperacaoInicial();
}