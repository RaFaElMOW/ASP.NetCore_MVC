using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Etec.Aula2802.MCV.Models
{
    public class Produto
    {
        [DisplayName("Cod. Produto")]
        public int cdProduto { get; set; }

        [DisplayName("Nome Produto")]
        public string nmProduto { get; set; }

        [DisplayName("Valor")]
        public decimal valor { get; set; }

        [DisplayName("Descrição")]
        public string descricao { get; set; }

        [DisplayName("Quantidade")]
        public int quantidade { get; set; }
    }
}
