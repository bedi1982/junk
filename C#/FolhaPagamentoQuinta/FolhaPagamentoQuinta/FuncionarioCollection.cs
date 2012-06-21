using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FolhaPagamentoQuinta
{
    class FuncionarioCollection
    {
        private static List<Funcionario> func = new List<Funcionario>(); //Lista chamadda func

        public static void Insert(Funcionario funcionario){ //Vem um objeto chamado funcionario pra lista func
            func.Add(funcionario);
    }

        public static List<Funcionario> GetFuncionarios() {
            return func;
        }
    }
}