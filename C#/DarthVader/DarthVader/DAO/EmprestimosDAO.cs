using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public static List<Emprestimo> Lista()
        { //Retorna uma lista com todos os jogos no banco

            List<Emprestimo> lista = new List<Emprestimo>();
            DarthVaderEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                foreach (Emprestimo x in db.Emprestimos)
                { //Thanks google :) - Cria uma lista a partir do bd.
                    //db.Emprestimos.Remove(x); // DANGER: Limpa o banco
                    //db.SaveChanges();
                    lista.Add(x);
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