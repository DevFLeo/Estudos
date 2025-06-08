using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Shared.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;
        public Cliente? Cliente { get; set; } 
        public Vendedor? Vendedor { get; set; }
        public List<ItemDeVenda> Itens { get; set; } = new List<ItemDeVenda>();
    }
}
