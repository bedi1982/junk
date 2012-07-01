using System;
using System.Windows.Forms;
using System.Threading;
using DarthVader.Model;
using DarthVader.DAO;

namespace DarthVader.View
{
    public partial class frm_Emprestar_jogo : Form
    {
        Jogo jogo = new Jogo();

        public frm_Emprestar_jogo()
        {
            InitializeComponent();
            btn_emprestar.Enabled = false;
            txt_quem_vai_emprestar.Enabled = false;
            txt_RG.Enabled = false;
        }

        //////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////

        protected void btn_procurar_Click(object sender, EventArgs e)
        {
            try
            {
                jogo.id = int.Parse(txtbox_id_do_jogo.Text);
                jogo = JogosDAO.search(jogo); //Verifica se o jogo esta em casa
                if (jogo != null)
                {
                    txt_quem_vai_emprestar.Enabled = true;
                    txt_RG.Enabled = true;

                    txt_NomeDoJogo.Text = jogo.titulo;
                    if (jogo.emprestado == true)
                    {
                        btn_emprestar.Enabled = false;
                        txt_quem_vai_emprestar.Enabled = false;
                        txt_RG.Enabled = false;
                        lbl_status.Text = "Jogo já se encontra emprestado";
                    }
                    else {
                        btn_emprestar.Enabled = true;
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Dados Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////

        private void Limpeza_do_form()
        {
            txt_NomeDoJogo.Clear();
            txt_RG.Clear();
            txt_quem_vai_emprestar.Clear();
            lbl_status.Text = "";
        }

        //////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////
        
        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        //////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////

        private void btn_emprestar_Click(object sender, EventArgs e)
        {
            try
            {
                    if (jogo.emprestado == false)
                    {
                        Emprestimo emprestar = new Emprestimo(); //Ja que tem o jogo, criamos o objeto do emprestimo
                        emprestar.jogo = jogo; //Emprestimos.Jogos_ID recebe o jogo

                        //Titulo deve ser preenchido sozinho//
                        //txtbox_id_do_jogo_TextChanged(sender, e, emprestar.jogo.plataforma);
                        txt_NomeDoJogo.Text = jogo.titulo;
                        
                        txt_quem_vai_emprestar.Enabled = false;
                        txt_RG.Enabled = false;

                        emprestar.nome = txt_quem_vai_emprestar.Text;

                        //Console.WriteLine("Qual o seu RG? ");
                        emprestar.telefone = txt_RG.Text;

                        emprestar.data_do_emprestimo = DateTime.Now;
                        EmprestimosDAO.Insert(emprestar);

                        MessageBox.Show("Emprestado!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        JogosDAO.Toggler(jogo); //Só agora marca como emprestado
                        btn_emprestar.Enabled = false;
                        Limpeza_do_form();
                        
                        frm_Main main = new frm_Main();
                        //main = new frm_Main();
                        //main.btn_AtualizarEmprestadosEJogosEmCasa_Click(sender, e);
                        main.frm_Main_Load(sender, e);
                        
                        //frm_Main.Invoke(() => frm_Main));
                    }
                    else
                    {
                        MessageBox.Show("Jogo consta como já emprestado", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpeza_do_form();
                    }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Dados Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}