using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Etec.Aula2802.MCV.Models
{
    public class Cliente
    {
        [DisplayName("Código Cliente")]
        public int cdCliente { get; set; }

        [DisplayName("Nome Cliente")]
        public string nmCliente { get; set; }

        [DisplayName("Data de Nascimento")]
        public DateTime dtNascimento { get; set; }

        [DisplayName("Peso")]
        public decimal peso { get; set; }
    }
}
