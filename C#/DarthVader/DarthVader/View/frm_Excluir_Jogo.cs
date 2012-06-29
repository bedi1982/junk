using System;
using System.Windows.Forms;
using DarthVader.Model;
using DarthVader.DAO;

namespace DarthVader.View
{
    public partial class frm_Excluir_Jogo : Form
    {
        //Será preenchido pelo metodo de procura e usado no metodo de delete//
        Jogo jogo = new Jogo();
        ///////////////////////
        
        public frm_Excluir_Jogo()
        {
            InitializeComponent();
        }
        
        /// ///////////////////////////// //////////////////////////

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// ///////////////////////////// //////////////////////////
        
        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            try
            {
                jogo.id = int.Parse(txtbox_InsereID.Text);
                jogo = JogosDAO.search(jogo); //Verifica se o jogo esta em casa

                if (jogo != null)
                {
                    lbl_plataforma_recuperada.Text = jogo.plataforma;
                    lbl_titulo_recuperado.Text = jogo.titulo;
                    lbl_emprestado_recuperado.Text = "Não";

                    if (jogo.emprestado == true)
                    {
                        lbl_emprestado_recuperado.Text = "Sim";
                        MessageBox.Show("Jogo se encontra emprestado, você deve usar \na opção de devolução antes.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpeza_do_form();
                        btn_Excluir.Enabled = false;
                    }
                    else {
                        btn_Excluir.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Jogo não cadastrado", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpeza_do_form();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Dados Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    /// ///////////////////////////// //////////////////////////
        
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            {
                if (JogosDAO.Delete(jogo)) {
                    MessageBox.Show("Jogo Excluido", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpeza_do_form();
                }
            }
        }

        private void limpeza_do_form()
        {
            //Limpeza//
            btn_Excluir.Enabled = false;
            lbl_plataforma_recuperada.Text = "";
            lbl_titulo_recuperado.Text = "";
            lbl_emprestado_recuperado.Text = "";
            txtbox_InsereID.Text = "";
        }
    }
}