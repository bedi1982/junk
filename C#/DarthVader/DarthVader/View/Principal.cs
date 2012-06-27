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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            btn_AtualizarEmprestadosEJogosEmCasa_Click_1(sender, e);
        }


        //Atualiza as duas GRIDS
        private void btn_AtualizarEmprestadosEJogosEmCasa_Click_1(object sender, EventArgs e)
        {
            //////////////////////////Adiciona Jogos em casa a Grid////////////////////////////
            List<Jogo> jogos = new List<Jogo>();
            jogos = JogosDAO.Lista();

            Main_dataGrid_JogosEmCasa.Rows.Clear(); //limpa grid

            if (jogos != null)
            {
                foreach (Jogo x in jogos)
                {
                    Main_dataGrid_JogosEmCasa.Rows.Add(x.titulo, x.plataforma, x.quantidade, x.ano, x.custo, x.data_cadastro);
                }
            }
            else
            {
                MessageBox.Show("Nenhum Jogo Em Casa");
            }
            List<Emprestimo> emprestados = new List<Emprestimo>();
            emprestados = EmprestimosDAO.Lista();
            Main_dataGrid_JogosEmprestados.Rows.Clear(); //limpa grid

            //////////////////////////Adiciona Emprestados a Grid////////////////////////////
            foreach (Emprestimo x in emprestados)
            {
                if (x.jogo.emprestado == true)
                {
                    Main_dataGrid_JogosEmprestados.Rows.Add(x.nome, x.rg, x.data_do_emprestimo, x.jogo.titulo);
                }
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Main_Btn_Jogos_Em_Casa_Grid_Adicionar_Click(object sender, EventArgs e)
        {
            frm_Adicionar_Jogo adicionar = new frm_Adicionar_Jogo();
            adicionar.ShowDialog();
        }

        private void btn_emprestar_jogos_em_casa_Click(object sender, EventArgs e)
        {
            frm_emprestar_jogo emprestar = new frm_emprestar_jogo();
            emprestar.ShowDialog();
        }
            
    }
}
