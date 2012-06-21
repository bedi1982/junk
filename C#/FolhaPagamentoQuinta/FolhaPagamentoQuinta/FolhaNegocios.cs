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

        public static bool ValidaData(Folha folha)
        {
            foreach (Folha x in FolhaCollection.GetFolhas())
            {
                if (x.ano.Equals(folha.ano) && x.mes.Equals(folha.mes) && x.funcionario.nome.Equals(folha.funcionario.nome))
                {
                    //Console.Write("Objetos:" + x);
                    return true; //Ja tem essa data
                }
            }
            //Console.Write("Saiu do if: - good");
            return false;
        }
        
        //Nao permitir dados repetidos com o mesmo fun, mes e ano:///
        //Retorna o funcionario baseado em nome, mes e ano:///
        public static Folha VerificaDataUsuario(string nome, int mes, int ano)
        {
            foreach (Folha x in FolhaCollection.GetFolhas())
            {
                if (x.mes.Equals(mes) && x.ano.Equals(ano) && x.funcionario.nome.Equals(nome))
                {
                    //Console.WriteLine("tem"); //teste status
                    return x; //retornar um objeto é o mesmo que true :) //
                }
            }
            return null; //Nao tem :P
        }
    }
}