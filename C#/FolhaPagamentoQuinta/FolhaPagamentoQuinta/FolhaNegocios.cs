using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FolhaPagamentoQuinta
{
    class FolhaNegocios
    {
        public static bool ValidaCpf(Funcionario func)
        {
            //ME FAÇA!//
            return true;
        }

        //Nao permitir dados repetidos com o mesmo fun, mes e ano:///
        public static bool ValidaData(Folha folha)
        {
            foreach (Folha x in FolhaCollection.GetFolhas())
            {
                if (x.funcionario.nome.Equals(folha.funcionario.nome) && x.ano == folha.ano && x.mes == folha.mes)
                {
                    return true; //Ja tem essa data
                }
            }
            return false;
        }
        //Nao permitir dados repetidos com o mesmo fun, mes e ano:///
    }
}
