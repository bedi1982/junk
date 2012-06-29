//using System;
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
            db.SaveChanges();
            return true;
        }

        public static bool Delete(Jogo jogo)
        {
            DarthVaderEntities db = SingletonObjectContext.Instance.Context;
            //Jogo vaimorrer = new Jogo();

            try
            {
                foreach (Jogo x in db.Jogos)
                {
                    if (x.id.Equals(jogo.id))
                    {
                        jogo = x;
                        break;
                    }
                }
                //necessário senão banco reclama de threads extras//
                db.Jogos.Remove(jogo);
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

        /// //////ALO VOCE --- TRY CATCH DESLIGADO PARA TESTES- LIGUEME DEPOIS///////
        public static Jogo search(Jogo jogo)
        {
            DarthVaderEntities db = SingletonObjectContext.Instance.Context;
            //try
            //{
            foreach (Jogo x in db.Jogos)
            {
                if (x.id.Equals(jogo.id))
                {
                    //Ainda uso o console para debug//
                    //Console.WriteLine("Search retornando: " + x.titulo);
                    return x;
                }
            }
            return null;
        }
        //catch
        //{
        //    return null;
        //}
        //}

        /////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////

        public static List<Jogo> Lista()
        { //Retorna uma lista com todos os jogos em casa

            List<Jogo> jogos = new List<Jogo>();
            DarthVaderEntities db = SingletonObjectContext.Instance.Context;

            //try
            //{
            int i = 0;
            foreach (Jogo x in db.Jogos)
            {
                if (x.emprestado == false)
                {
                    i++;
                    jogos.Add(x);
                }
            }

            if (i == 0)
            {
                return null;
            }
            else
                return jogos;
        }
        //catch
        //{
        //   return null;
        //}

        public static Jogo Retorna_Jogo_emprestado(Jogo jogo)
        {
            DarthVaderEntities db = SingletonObjectContext.Instance.Context;
            //try
            //{
                foreach (Jogo x in db.Jogos)
                {
                    if ((x.id.Equals(jogo.id)) && (x.emprestado == true)) //Atenção aqui mais tarde talvez//
                    {
                        return x;
                    }
                }
            //}catch ()
            //{
             //   return null;
            //}
            return null;
        }

        /////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////

        public static Jogo Toggler(Jogo jogo) //Marca true ou falso para emprestado
        {
            DarthVaderEntities db = SingletonObjectContext.Instance.Context;
            //Console.WriteLine("VEIO: " + jogo.titulo);

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