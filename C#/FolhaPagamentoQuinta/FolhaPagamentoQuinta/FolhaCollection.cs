using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FolhaPagamentoQuinta
{
    class FolhaCollection
    {
        private static List<Folha> folhas = new List<Folha>(); //Lista chamadda folhas

        public static void Insert(Folha folha)
        { //Vem um objeto chamado funcionario pra lista func
            folhas.Add(folha);
        }

        public static List<Folha> GetFolhas()
        {
            return folhas;
        }
    }
}