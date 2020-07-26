using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDProdutosASPNETCoreMVC.Models
{
    public class Produto
    {
        [Key]
        public int Produto_id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public Decimal Preco { get; set; }
    }
}
