using Modelo;
using Repositorio;

namespace   Cmd;

    public static class OperacaoCriarLista {

        public static void Executar(){
            Console.WriteLine("Nome: ");
            var nome = Console.ReadLine();
            Console.WriteLine("Data desejada: ");
            var dataDesejada = Console.ReadLine();
            var dataDesejadaConvertida = DateTime.Parse(dataDesejada);
            var lista = new Lista(nome, dataDesejadaConvertida);
            ListaRepositorio.Adicionar(lista);
            Console.WriteLine($"Lista {lista.Nome} criada para a data {lista.DataDesejadaDaCompra} ");

            OperacaoInicial.Executar();
        }
    }