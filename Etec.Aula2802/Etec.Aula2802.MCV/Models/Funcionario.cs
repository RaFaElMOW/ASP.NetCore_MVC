using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Etec.Aula2802.MCV.Models
{
    public class Funcionario
    {
        [DisplayName("Cod. Funcionario")]
        public int cdFuncionario { get; set; }

        [DisplayName("Nome Funcionário")]
        public string nmFuncionario { get; set; }

        [DisplayName("Endereço")]
        public string endereco { get; set; }

        [DisplayName("Telefone")]
        public string telefone { get; set; }

        [DisplayName("RG Funcionário")]
        public string rg { get; set; }

        [DisplayName("CPF Funcionário")]
        public string cpf { get; set; }

        [DisplayName("Cargo")]
        public string cargo { get; set; }

    }
}
