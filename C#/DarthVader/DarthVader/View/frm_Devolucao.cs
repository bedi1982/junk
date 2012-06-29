using System;
using System.Windows.Forms;
using DarthVader.DAO;
using DarthVader.Model;

namespace DarthVader.View
{
    public partial class frm_Devolucao : Form
    {
        Jogo devolucao = new Jogo(); //Dados do Jogo
        Emprestimo emprestado = new Emprestimo(); //Dados de quem emprestou

        public frm_Devolucao()
        {
            InitializeComponent();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            try
            {
                emprestado.id = int.Parse(txtbox_InsereID.Text);
                //devolucao = JogosDAO.Retorna_Jogo_emprestado(devolucao); //Verifica se o jogo esta em casa
                emprestado = EmprestimosDAO.search(emprestado);

                if (emprestado != null)
                {
                    btn_devolver.Enabled = true;
                    lbl_emprestado_recuperado.Text = "Sim";
                    lbl_plataforma_recuperada.Text = emprestado.jogo.plataforma;
                    lbl_titulo_recuperado.Text = emprestado.jogo.titulo;
                    devolucao = emprestado.jogo;
                }
                else {
                    MessageBox.Show("Jogo não encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Dados Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_devolver_Click(object sender, EventArgs e)
        {
            JogosDAO.Toggler(devolucao);
            EmprestimosDAO.Delete(emprestado);
            MessageBox.Show("Jogo voltou para o lar doce lar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_devolver.Enabled = false;
            lbl_emprestado_recuperado.Text = "";
            lbl_plataforma_recuperada.Text = "";
        }
    }
}