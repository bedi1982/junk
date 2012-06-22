using System;

namespace DarthVader.Model
{
    class Jogo //Dados do jogo e video game
    {
        public int id { set; get; }
        public string titulo { set; get; }
        public string plataforma { set; get; }
        public int quantidade { set; get; }
        public int ano { set; get; }
        public float custo { set; get; }
        public bool emprestado { set; get; }
        public DateTime data_cadastro { set; get; }
    }
}