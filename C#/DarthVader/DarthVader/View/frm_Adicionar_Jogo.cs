using System;
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
        
        ////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////
        protected void btn_Adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((escolha != 1) && (escolha != 0))
                {
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
                jogo.ano = int.Parse(mkd_txtbox_AnoLancamento.Text);
                jogo.custo = float.Parse(txt_Custo.Text.Replace(".",","));
                jogo.emprestado = false; //Não emprestado por padrão
                jogo.data_cadastro = DateTime.Now;
                JogosDAO.Insert(jogo);
   
                // Invoke an anonymous method on the thread of the form.
                //this.Invoke((MethodInvoker) delegate
                //{
                //});

                MessageBox.Show("Jogo adicionado a coleção!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpeza_do_form();

            } catch(Exception ex) {
                MessageBox.Show(ex.Message, "Você inseriu dados de forma errada.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////

        private void Limpeza_do_form() {
            txt_NomeDoJogo.Clear();
            txt_Quantidade.Clear();
            mkd_txtbox_AnoLancamento.Clear();
            txt_Custo.Clear();
            mkd_txtbox_AnoLancamento.Text = "2012";
        }
        
        ////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////
        
        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        ////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////

        private void radiobtn_Xbox360_CheckedChanged(object sender, EventArgs e)
        {
            escolha = 0;
        }

        ////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////

        private void radiobtn_PS3_CheckedChanged(object sender, EventArgs e)
        {
            escolha = 1;
        }
    }
}
