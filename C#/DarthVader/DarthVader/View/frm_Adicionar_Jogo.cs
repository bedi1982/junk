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
    public partial class frm_Adicionar_Jogo : Form
    {
        int escolha = 3; //Para a plataforma

        public frm_Adicionar_Jogo()
        {
            InitializeComponent();
        }
        
        private void radiobtn_Xbox360_CheckedChanged(object sender, EventArgs e)
        {
            escolha = 0;
            //MessageBox.Show("escolha: " + escolha);
        }

        private void radiobtn_PS3_CheckedChanged(object sender, EventArgs e)
        {
            escolha = 1;
            //MessageBox.Show("escolha: " + escolha);
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((escolha != 1) && (escolha != 0))
                {
                    //googled://
                    //MessageBox.Show("escolha: " + escolha);
                    throw new System.ArgumentException("Selecione uma plataforma!");
                }
                
                Jogo jogo = new Jogo();
                //1 para PS3 da variavel global escolha//
                if (escolha == 1)
                {
                    jogo.plataforma = "Playstation 3"; //Ja adicionando a plataforma.
                }
                else
                {
                    jogo.plataforma = "Xbox 360"; //Ja adicionando a plataforma.
                }
                jogo.titulo = txt_NomeDoJogo.Text;
                jogo.quantidade = int.Parse(txt_Quantidade.Text);
                jogo.ano = int.Parse(txt_AnoLancamento.Text);
                jogo.custo = float.Parse(txt_Custo.Text);
                MessageBox.Show("Valor passado: " + jogo.custo);
                jogo.emprestado = false; //Não emprestado por padrão
                jogo.data_cadastro = DateTime.Now;
                JogosDAO.Insert(jogo);
                MessageBox.Show("Jogo adicionado a coleção!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpeza_do_form(sender, e);
            }
            catch(SystemException ex) {
                MessageBox.Show(ex.Message, "Dados Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void Limpeza_do_form(object sender, EventArgs e) {
            txt_NomeDoJogo.Clear();
            txt_Quantidade.Clear();
            txt_AnoLancamento.Clear();
            txt_Custo.Clear();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
