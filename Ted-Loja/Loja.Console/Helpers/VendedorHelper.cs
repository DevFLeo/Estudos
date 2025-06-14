using Loja.Shared.Contexts;
using Loja.Shared.Models;
using static System.Console;

namespace Loja.Console.Helpers
{
    internal class VendedorHelper
    {
        public static void Cadastrar()
        {
            var vendedor = new Vendedor();
            MenuHelper.CriarCabecalho("CADASTRO DE VENDEDORES");
            Write(" Código: ");
            vendedor.Id = Convert.ToInt32(ReadLine());
            Write(" Nome:   ");
            vendedor.Nome = ReadLine();
            Write(" CPF: ");
            vendedor.Cpf = ReadLine();
            Write(" Celular: ");
            vendedor.Celular = ReadLine();
            Write(" Email: ");
            vendedor.Email = ReadLine();
            LojaContext.Vendedor.Add(vendedor);
            Write(" [Enter] para continuar... ");
            ReadLine();
            MenuHelper.MenuVendedores();

        }
        public static void Listar()
        {
            MenuHelper.CriarCabecalho("LISTA DE VENDEDORES");
            if (LojaContext.Vendedor.Count == 0)
            {
                WriteLine(" Nenhum Vendedor cadastrado.");
            }
            else
            {
                foreach (var vendedor in LojaContext.Vendedor)
                {
                    WriteLine(" " + vendedor);
                }
            }
            MenuHelper.CriarLinha();
            Write(" [Enter] para continuar... ");
            ReadLine();
            MenuHelper.MenuVendedores();
        }

        public static void Editar()
        {
            MenuHelper.CriarCabecalho("EDITAR VENDEDOR");
            Write(" Informe o código do Vendedor: ");
            int id = Convert.ToInt32(ReadLine());
            var vendedor = LojaContext.Vendedor.FirstOrDefault(v => v.Id == id);

            if (vendedor == null)
            {
                WriteLine(" Produto não encontrado.");
            }
            else
            {
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine($"\n Nome Atual: {vendedor.Nome}");
                ForegroundColor = ConsoleColor.White;
                Write(" Novo Nome:  ");
                var nome = ReadLine();
                if (!string.IsNullOrEmpty(nome))
                    vendedor.Nome = nome;

                ForegroundColor = ConsoleColor.Yellow;
                WriteLine($"\n CPF Atual: {vendedor.Cpf}");
                ForegroundColor = ConsoleColor.White;
                Write(" Novo CPF:  ");
                var cpf = ReadLine();
                if (!string.IsNullOrEmpty(cpf))
                    vendedor.Cpf = cpf;

                ForegroundColor = ConsoleColor.Yellow;
                WriteLine($"\n Celular Atual: {vendedor.Celular}");
                ForegroundColor = ConsoleColor.White;
                Write(" Novo Celular:  ");
                var celular = ReadLine();
                if (!string.IsNullOrEmpty(celular))
                    vendedor.Celular = celular;

                ForegroundColor = ConsoleColor.Yellow;
                WriteLine($"\n Nome Email: {vendedor.Email}");
                ForegroundColor = ConsoleColor.White;
                Write(" Novo Email:  ");
                var email = ReadLine();
                if (!string.IsNullOrEmpty(email))
                    vendedor.Email = email;

                WriteLine("\n Vendedor atualizado com sucesso.");
            }
            MenuHelper.CriarLinha();
            Write(" [Enter] para continuar... ");
            ReadLine();
            MenuHelper.MenuVendedores();
        }
        public static void Excluir()
        {
            MenuHelper.CriarCabecalho("EXCLUIR VENDEDOR");
            Write(" Informe o código do vendedor: ");
            int codigo = Convert.ToInt32(ReadLine());
            var vendedor = LojaContext.Vendedor.FirstOrDefault(p => p.Id == codigo);

            if (vendedor == null)
            {
                WriteLine(" Vendedor não encontrado.");
            }
            else
            {
                WriteLine(" \n Deseja realmente excluir");
                WriteLine(" " + vendedor);
                Write(" [S] Sim / [N] Não: ");
                var opcao = ReadLine()?.ToUpper();
                if (opcao == "S")
                {
                    LojaContext.Vendedor.Remove(vendedor);
                    WriteLine(" Produto excluído com sucesso.");
                }
            }
            MenuHelper.CriarLinha();
            Write(" [Enter] para continuar... ");
            ReadLine();
            MenuHelper.MenuVenda();
        }
    }
}
