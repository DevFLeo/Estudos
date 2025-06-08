using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja.Shared.Contexts;
using Loja.Shared.Models;
using static System.Console;

namespace Loja.Console.Helpers
{
    internal class ClienteHelper
    {
        public static void Cadastrar()
        {
            var cliente = new Cliente();
            MenuHelper.CriarCabecalho("CADASTRO DE CLIENTES");
            Write(" Código: ");
            cliente.Id = Convert.ToInt32(ReadLine());
            Write(" Nome:   ");
            cliente.Nome = ReadLine();
            Write(" CPF: ");
            cliente.Cpf = ReadLine();
            Write(" Celular: ");
            cliente.Celular = ReadLine();
            Write(" Email: ");
            cliente.Email = ReadLine();
            LojaContext.Clientes.Add(cliente);
            Write(" [Enter] para continuar... ");
            ReadLine();
            MenuHelper.MenuCliente();

        }
        public static void Listar()
        {
            MenuHelper.CriarCabecalho("LISTA DE CLIENTES");
            if (LojaContext.Clientes.Count == 0)
            {
                WriteLine(" Nenhum Cliente cadastrado.");
            }
            else
            {
                foreach (var cliente in LojaContext.Clientes)
                {
                    WriteLine(" " + cliente);
                }
            }
            MenuHelper.CriarLinha();
            Write(" [Enter] para continuar... ");
            ReadLine();
            MenuHelper.MenuProduto();
        }

        public static void Editar()
        {

        }
        public static void Excluir()
        {

        }
    }
}
