using System;
using System.Collections.Generic;
using System.Linq;
using DarthVader.Model;

namespace DarthVader.DAO
{
    class JogosDAO
    {
        public static bool Insert(Jogo jogo)
        {
            DarthVaderEntities db = SingletonObjectContext.Instance.Context;
            db.Jogos.Add(jogo);
            Console.WriteLine("Adicionado ao BANCO o título: " + jogo.titulo);
            db.SaveChanges();
            return true;
        }

        /////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////

        public static Jogo search(Jogo jogo)
        {
            DarthVaderEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                jogo = db.Jogos.FirstOrDefault(x => x.titulo.Contains(jogo.titulo));
                return jogo;
            }
            catch
            {
                Console.WriteLine("Catcheou");
                return null;
            }
        }

        /////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////

        public static List<Jogo> Lista()
        { //Retorna uma lista com todos os jogos em casa

            List<Jogo> jogos = new List<Jogo>();
            
            DarthVaderEntities db = SingletonObjectContext.Instance.Context;

            try
            {
                foreach (Jogo x in db.Jogos)
                { 
                    if (x.emprestado == false)
                    {
                       jogos.Add(x);
                    }
                }
                return jogos;
            }
            catch
            {
                return null;
            }
        }

        /////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////
          
        public static Jogo Toggler(Jogo jogo) //Marca true ou falso para emprestado
        {
            DarthVaderEntities db = SingletonObjectContext.Instance.Context;
            Console.WriteLine("VEIO: " + jogo.titulo);

            if (!jogo.emprestado) //Se é falso (Não emprestado)
            {
                jogo = db.Jogos.FirstOrDefault(x => x.id.Equals(jogo.id));
                jogo.emprestado = true; //Transforme em emprestado
            }
            else
            {
                jogo.emprestado = false; //Devolvendo transforma em true
            }
            db.SaveChanges();
            return jogo;
        }
    }
}