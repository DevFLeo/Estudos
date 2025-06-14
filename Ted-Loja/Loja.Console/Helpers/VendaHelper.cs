using Loja.Shared.Contexts;
using Loja.Shared.Models;
using static System.Console;
// fazer um helper para ajudar na hora de fazer uma classe que faz ligação com o menu helper

namespace Loja.Console.Helpers
{
    internal class VendaHelper
    {
        public static void Cadastrar()
        {
            var itemDeVenda = new ItemDeVenda();
            MenuHelper.CriarCabecalho("CADASTRO DE VENDAS");
            Write("Código: ");
            itemDeVenda.Id = Convert.ToInt32(ReadLine());
            Write("Cliente: ");
            itemDeVenda.Cliente = ReadLine();
            Write("Vendedor: ");
            itemDeVenda.Vendedor = ReadLine();
            Write("Produto Da Venda: ");
            itemDeVenda.Produto = ReadLine();
            LojaContext.ItemDeVenda.Add(itemDeVenda);
            Write(" [Enter] para continuar... ");
            ReadLine();
            MenuHelper.MenuVenda();
        }
        public static void Listar() 
        {
            MenuHelper.CriarCabecalho("LISTA DE VENDAS");
            if (LojaContext.ItemDeVenda.Count == 0)
            {
                WriteLine("Nenhuma Venda Registrada.");
            }
            else
            {
                foreach (var itemDeVenda in LojaContext.ItemDeVenda)
                {
                    WriteLine(" " + itemDeVenda);
                }
            }
            MenuHelper.CriarLinha();
            Write(" [Enter] para continuar... ");
            ReadLine();
            MenuHelper.MenuVenda();
        }
        public static void Editar() 
        {
            MenuHelper.CriarCabecalho("EDITAR VENDA");
            Write(" Informe o código do Vendedor: ");
            int codigo = Convert.ToInt32(ReadLine());
            var itemDeVenda = LojaContext.ItemDeVenda.FirstOrDefault(ItemDeVenda => ItemDeVenda.Id == codigo);

            if (itemDeVenda == null) 
            {
                WriteLine(" Venda não encontrado.");
            }
            else 
            {
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine($"\n Produto Atual: {itemDeVenda.Produto}");
                ForegroundColor = ConsoleColor.White;
                Write(" Novo Produto:  ");
                var produto = ReadLine();
                if (!string.IsNullOrEmpty(produto))
                    itemDeVenda.Produto = produto;

                ForegroundColor = ConsoleColor.Yellow;
                WriteLine($"\n Cliente Atual: {itemDeVenda.Cliente}");
                ForegroundColor = ConsoleColor.White;
                Write("Novo Cliente: ");
                var cliente = ReadLine();
                if (! string.IsNullOrEmpty(cliente))
                    itemDeVenda.Cliente = cliente;

                ForegroundColor = ConsoleColor.Yellow;
                WriteLine($"\n Vendedor Atual: {itemDeVenda.Vendedor} ");
                ForegroundColor = ConsoleColor.White;
                WriteLine($"\n Novo Vendedor: ");
                var vendedor = ReadLine();
                if (!string.IsNullOrEmpty (vendedor))
                    itemDeVenda.Vendedor = vendedor;

                WriteLine("\n Vendedor atualizado com sucesso.");
            }
            MenuHelper.CriarLinha();
            Write(" [Enter] para continuar... ");
            ReadLine();
            MenuHelper.MenuVenda();
        }
        public static void Excluir() 
        {
            MenuHelper.CriarCabecalho("EXCLUIR VENDA");
            Write(" Informe o código da venda: ");
            int codigo = Convert.ToInt32(ReadLine());
            var itemDeVenda = LojaContext.ItemDeVenda.FirstOrDefault(ItemDeVenda => ItemDeVenda.Id == codigo);

            if (itemDeVenda == null)
            {
                WriteLine("Venda não encontrada.");
            }
            else
            {
                WriteLine(" \n Deseja realmente excluir?");
                WriteLine(" " + itemDeVenda);
                Write(" [S] Sim / [N] Não: ");
                var opcao = ReadLine()?.ToUpper();
                if (opcao == "S")
                {
                    LojaContext.Produtos.Remove(itemDeVenda);
                    WriteLine(" Venda excluida com sucesso.");
                }
            }
            MenuHelper.CriarLinha();
            Write(" [Enter] para continuar... ");
            ReadLine();
            MenuHelper.MenuVenda();
        }
}