using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DarthVader.Model;
using DarthVader.DAO;

namespace DarthVader.View
{
    public partial class frm_emprestar_jogo : Form
    {
        public frm_emprestar_jogo()
        {
            InitializeComponent();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            Jogo jogo = new Jogo();
            jogo.titulo = txt_NomeDoJogo.Text;

            jogo = JogosDAO.search(jogo); //Verifica se o jogo esta em casa

            if (jogo != null)
            {
                if (!jogo.emprestado)
                {

                    //Console.WriteLine("Achou");
                    JogosDAO.Toggler(jogo); //Marca como emprestado

                    Emprestimo emprestar = new Emprestimo(); //Ja que tem o jogo, criamos o objeto do emprestimo
                    emprestar.jogo = jogo; //Emprestimos.Jogos_ID recebe o jogo

                    //Console.WriteLine("Qual o seu nome? ");
                    emprestar.nome = txt_quem_vai_emprestar.Text;

                    //Console.WriteLine("Qual o seu RG? ");
                    emprestar.rg = int.Parse(txt_RG.Text);

                    emprestar.data_do_emprestimo = DateTime.Now;
                    EmprestimosDAO.Insert(emprestar);

                    MessageBox.Show("Emprestado!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpeza_do_form(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Jogo não cadastrado na coleção.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpeza_do_form(sender, e);
            }
        }
        private void Limpeza_do_form(object sender, EventArgs e)
        {
            txt_NomeDoJogo.Clear();
            txt_RG.Clear();
            txt_quem_vai_emprestar.Clear();
            lbl_Plataforma.Text = "Insira o nome do jogo acima";
        }
    }
}
