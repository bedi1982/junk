using System;

namespace DarthVader.Model
{
    class Emprestimo //Dados de quem vai emprestar
    {
        public int id { set; get; }
        public string nome { set; get; } //Para Quem?
        public string telefone { set; get; }
        public DateTime data_do_emprestimo { set; get; }
        public virtual Jogo jogo { set; get; }
    }
}