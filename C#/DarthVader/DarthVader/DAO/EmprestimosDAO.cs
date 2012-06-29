using System.Collections.Generic;
using System.Linq;
using DarthVader.Model;
using System;

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

        public static Emprestimo search(Emprestimo emprestimo)
        {
            DarthVaderEntities db = SingletonObjectContext.Instance.Context;
            //try
            //{
            foreach (Emprestimo x in db.Emprestimos)
            {
                if (x.id.Equals(emprestimo.id))
                {
                    //Ainda uso o console para debug//
                    //Console.WriteLine("Search retornando: " + x.titulo);
                    return x;
                }
            }
            return null;
        }

        /////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////

        public static bool Delete(Emprestimo emprestimo)
        {
            DarthVaderEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                foreach (Emprestimo x in db.Emprestimos)
                {
                    if (x.id.Equals(emprestimo.id))
                    {
                        emprestimo = x;
                        break;
                    }
                }
                //necessário senão banco reclama de threads extras//
                db.Emprestimos.Remove(emprestimo);
                db.SaveChanges();
                return true; //fazer o retorno feliz
            }
            catch
            {
                return false;
            }
        }

        /////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////

        public static List<Emprestimo> Lista() //Retorna a lista de emprestados
        {
            List<Emprestimo> lista = new List<Emprestimo>(); //lista de Emprestimo
            DarthVaderEntities db = SingletonObjectContext.Instance.Context; //banco up
            try
            {
                lista = db.Emprestimos.Include("jogo").ToList();

                //Lista Nova filtrando//
                List<Emprestimo> emprestimos = new List<Emprestimo>();
                int i = 0;
                //Filtro//
                foreach (Emprestimo x in lista)
                {
                    if (x.jogo.emprestado == true)
                    {
                        i++;
                        emprestimos.Add(x);
                    }
                }
                if (i == 0)
                {
                    lista = null;
                }
                return lista;
            }
            catch
            {
                return null;
            }
        }
    }
}