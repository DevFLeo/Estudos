using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Shared.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Celular { get; set; }
        public string? Email { get; set; }

        public override string ToString()
        {
            return $"V{Id.ToString("D3")} {Nome} - CPF{Cpf}";
        }
    }
}
