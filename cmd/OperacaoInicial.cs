namespace Cmd;

public static class OperacaoInicial {
    public static void Executar(){
        while(true){
            Console.WriteLine("Imforme a operação desejada.");
            Console.WriteLine("1 - Criar lista");
            Console.WriteLine("2 - Editar lista");
            Console.WriteLine("3 - Obter lista");
            Console.WriteLine("4 - Relatório");
            var operacaoDesejada = Console.ReadLine();
            if(operacaoDesejada == "1")
                OperacaoCriarLista.Executar();
            else if(operacaoDesejada == "2")
                OperacaoEditarLista.Executar();
            else if(operacaoDesejada == "3")
                OperacaoObterListas.Executar();
            else if(operacaoDesejada == "4")
                OperacaoRelatorio.Executar();
            else
                OperacaoInicial.Executar();
        }   
    }
}