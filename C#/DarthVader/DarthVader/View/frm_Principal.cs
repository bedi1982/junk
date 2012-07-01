using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DarthVader.Model;
using DarthVader.DAO;

namespace DarthVader.View
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        ////////////////////////////////////////////////////////////////////

        public void frm_Main_Load(object sender, EventArgs e)
        {
            btn_AtualizarEmprestadosEJogosEmCasa_Click(sender, e);
        }
        
        ////////////////////////////////////////////////////////////////////

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        ////////////////////////////////////////////////////////////////////
        
        private void Main_Btn_Jogos_Em_Casa_Grid_Adicionar_Click(object sender, EventArgs e)
        {
            frm_Adicionar_Jogo adicionar = new frm_Adicionar_Jogo();
            adicionar.ShowDialog();
            //Atualiza as Grids//
            btn_AtualizarEmprestadosEJogosEmCasa_Click(sender, e);
        }

        ////////////////////////////////////////////////////////////////////

        private void btn_emprestar_jogos_em_casa_Click(object sender, EventArgs e)
        {
            //Testar se as Lista está vazia//
            frm_Emprestar_jogo emprestar = new frm_Emprestar_jogo();
            emprestar.ShowDialog();
            //Atualiza as grids//
            btn_AtualizarEmprestadosEJogosEmCasa_Click(sender, e);
        }
        private void Main_Btn_JogoisEmCasaGrid_Excluir_Click_1(object sender, EventArgs e)
        {
            frm_Excluir_Jogo excluir = new frm_Excluir_Jogo();
            excluir.ShowDialog();
            //Atualiza as grids//
            btn_AtualizarEmprestadosEJogosEmCasa_Click(sender, e);
        }

        private void Main_Btn_EmprestimosGrid_Devolucao_Click(object sender, EventArgs e)
        {
            frm_Devolucao devolucao = new frm_Devolucao();
            devolucao.ShowDialog();
            btn_AtualizarEmprestadosEJogosEmCasa_Click(sender, e);
        }

        public void btn_AtualizarEmprestadosEJogosEmCasa_Click(object sender, EventArgs e)
        {
            //////////////////////////Adiciona Jogos em casa a Grid////////////////////////////
            List<Jogo> jogos = new List<Jogo>();
            jogos = JogosDAO.Lista();

            //Desativa botões da interface//
            btn_Emprestar.Enabled = false;
            btn_Excluir.Enabled = false;
            btn_Devolucao.Enabled = false;

            Main_dataGrid_JogosEmCasa.Rows.Clear(); //limpa grid

            if (jogos != null)
            {
                double tot_em_casa = 0;
                foreach (Jogo x in jogos)
                {
                    Main_dataGrid_JogosEmCasa.Rows.Add(x.id, x.titulo, x.plataforma, x.ano, x.custo, x.quantidade, x.data_cadastro);
                    tot_em_casa += x.custo;
                }
                btn_Emprestar.Enabled = true;
                btn_Excluir.Enabled = true;
                lbl_valor_total_em_casa.Text = tot_em_casa.ToString("C2");
                //txtMoney.Text = money.ToString("C");
            }

            List<Emprestimo> emprestados = new List<Emprestimo>();
            emprestados = EmprestimosDAO.Lista();
            Main_dataGrid_JogosEmprestados.Rows.Clear(); //limpa grid

            //////////////////////////Adiciona Emprestados a Grid////////////////////////////
            if (emprestados != null)
            {
                btn_Devolucao.Enabled = true;
                double tot_em_casa = 0;
                foreach (Emprestimo x in emprestados)
                {
                    if (x.jogo.emprestado == true)
                    {
                        tot_em_casa += x.jogo.custo;
                        Main_dataGrid_JogosEmprestados.Rows.Add(x.id, x.jogo.titulo, x.nome, x.telefone, x.data_do_emprestimo);
                    }
                }
                lbl_valor_total_emprestados.Text = tot_em_casa.ToString("C2");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frm_DarthVader darth = new frm_DarthVader();
            darth.Show();
        }

        private void btn_sobre_Click(object sender, EventArgs e)
        {
            frm_sobre sobre = new frm_sobre();
            sobre.Show();
        }
    }
}