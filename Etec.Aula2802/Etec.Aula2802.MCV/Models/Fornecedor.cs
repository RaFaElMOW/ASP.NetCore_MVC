using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Etec.Aula2802.MCV.Models
{
    public class Fornecedor
    {
        [DisplayName("Cod. Fornecedor")]
        public int cdFornecedor { get; set; }

        [DisplayName("Nome Fornecedor")]
        public string nmFornecedor { get; set; }

        [DisplayName("CNPJ Fornecedor")]
        public string CPNJ { get; set; }

        [DisplayName("Endereço")]
        public string endereco { get; set; }

        [DisplayName("Telefone")]
        public string telefone { get; set; }
    }
}
