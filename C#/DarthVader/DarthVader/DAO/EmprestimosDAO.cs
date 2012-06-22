using System;
using System.Collections.Generic;
using System.Linq;
using DarthVader.Model;

namespace DarthVader.DAO
{
    class EmprestimosDAO
    {
        public static void Insert(Emprestimo emprestar)
        {
            DarthVaderEntities db = SingletonObjectContext.Instance.Context;
            db.Emprestimos.Add(emprestar);
            db.SaveChanges();
        }
        
        /////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////
        
        public static List<Emprestimo> Lista() //Retorna a lista de emprestados
        { 
            DarthVaderEntities db = SingletonObjectContext.Instance.Context; //banco up
            List<Emprestimo> lista = new List<Emprestimo>(); //lista de Emprestimo

            try
            {
                lista = db.Emprestimos.Include("jogo").ToList();
                return lista;
            }
            catch
            {
                Console.WriteLine("BUAAAAA");
                return null;
           }
        }

        /////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////

        public static string Consulta_RG(int rg)
        { 
            DarthVaderEntities db = SingletonObjectContext.Instance.Context;
            Emprestimo consulta = new Emprestimo();
            try
            {
                consulta = db.Emprestimos.FirstOrDefault(x => consulta.rg.Equals(rg));
                if (consulta != null) {
                    return consulta.nome;
                }
                return null;
            }
            catch
            {
                Console.WriteLine("Catcheou");
                return null;
            }
        }
    }
}