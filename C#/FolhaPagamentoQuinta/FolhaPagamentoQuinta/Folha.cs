using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FolhaPagamentoQuinta
{
    class Folha
    {
        public Funcionario funcionario { get; set; }
        public int mes {get; set;}
        public int ano { get; set; }
        public int HorasTrabalhadas { get; set; }
        public float ValorDaHora { get; set; }
    }
}