OperacaoInicial();

void OperacaoInicial(){
    while(true){
        Console.WriteLine("Imforme a operação desejada.");
        Console.WriteLine("1 - Criar lista");
        Console.WriteLine("2 - Editar lista");
        var operacaoDesejada = Console.ReadLine();
        if(operacaoDesejada == "1")
            OperacaoCriarLista();
        else if(operacaoDesejada == "2")
            OperacaoEditarLista();
        else
            OperacaoInicial();
    }    
}

void OperacaoCriarLista(){
    Console.WriteLine("Nome: ");
    var nome = Console.ReadLine();
    Console.WriteLine("Data: ");
    var data = Console.ReadLine();
    OperacaoInicial();
}

void OperacaoEditarLista(){
    while(true){
        Console.WriteLine("Imforme a operação desejada.");
        Console.WriteLine("1 - adicionar itens");
        Console.WriteLine("2 - Editar itens");
        var operacaoDesejada = Console.ReadLine();
    }    
}

void OperacaoAdicionarItens(){
    Console.WriteLine("Nome: ");
    var nome = Console.ReadLine();
    Console.WriteLine("Data: ");
    var data = Console.ReadLine();
    OperacaoInicial();
}
