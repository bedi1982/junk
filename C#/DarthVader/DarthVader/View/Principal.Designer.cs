namespace DarthVader.View
{
    partial class frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grp_JogosEmprestados = new System.Windows.Forms.GroupBox();
            this.Main_dataGrid_JogosEmprestados = new System.Windows.Forms.DataGridView();
            this.Main_Data_Grid_Jogos_emprestados_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Main_Data_Grid_Jogos_emprestados_RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Main_Data_Grid_Jogos_emprestados_Data_do_Emprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Main_Data_Grid_Jogos_emprestados_titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Main_Btn_EmprestimosGrid_Adicionar = new System.Windows.Forms.Button();
            this.Main_Btn_EmprestimosGrid_Devolucao = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.grp_JogosEmCasa = new System.Windows.Forms.GroupBox();
            this.Main_Btn_JogoisEmCasaGrid_Remover = new System.Windows.Forms.Button();
            this.Main_Btn_Jogos_Em_Casa_Grid_Adicionar = new System.Windows.Forms.Button();
            this.Main_dataGrid_JogosEmCasa = new System.Windows.Forms.DataGridView();
            this.btn_AtualizarEmprestadosEJogosEmCasa = new System.Windows.Forms.Button();
            this.Main_Data_Grid_Jogos_Em_Casa_Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Main_Data_Grid_Jogos_Em_Casa_Plataforma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Main_Data_Grid_Jogos_Em_Casa_Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Main_Data_Grid_Jogos_Em_Casa_Custo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Main_Data_Grid_Jogos_Em_Casa_Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Main_Data_Grid_Jogos_Em_Casa_DataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_emprestar_jogos_em_casa = new System.Windows.Forms.Button();
            this.grp_JogosEmprestados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_dataGrid_JogosEmprestados)).BeginInit();
            this.grp_JogosEmCasa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_dataGrid_JogosEmCasa)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_JogosEmprestados
            // 
            this.grp_JogosEmprestados.Controls.Add(this.Main_dataGrid_JogosEmprestados);
            this.grp_JogosEmprestados.Controls.Add(this.Main_Btn_EmprestimosGrid_Adicionar);
            this.grp_JogosEmprestados.Controls.Add(this.Main_Btn_EmprestimosGrid_Devolucao);
            this.grp_JogosEmprestados.Location = new System.Drawing.Point(12, 236);
            this.grp_JogosEmprestados.Name = "grp_JogosEmprestados";
            this.grp_JogosEmprestados.Size = new System.Drawing.Size(689, 234);
            this.grp_JogosEmprestados.TabIndex = 1;
            this.grp_JogosEmprestados.TabStop = false;
            this.grp_JogosEmprestados.Text = "Jogos Emprestados";
            // 
            // Main_dataGrid_JogosEmprestados
            // 
            this.Main_dataGrid_JogosEmprestados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Main_dataGrid_JogosEmprestados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Main_Data_Grid_Jogos_emprestados_Nome,
            this.Main_Data_Grid_Jogos_emprestados_RG,
            this.Main_Data_Grid_Jogos_emprestados_Data_do_Emprestimo,
            this.Main_Data_Grid_Jogos_emprestados_titulo});
            this.Main_dataGrid_JogosEmprestados.Location = new System.Drawing.Point(6, 48);
            this.Main_dataGrid_JogosEmprestados.Name = "Main_dataGrid_JogosEmprestados";
            this.Main_dataGrid_JogosEmprestados.Size = new System.Drawing.Size(677, 178);
            this.Main_dataGrid_JogosEmprestados.TabIndex = 5;
            // 
            // Main_Data_Grid_Jogos_emprestados_Nome
            // 
            this.Main_Data_Grid_Jogos_emprestados_Nome.HeaderText = "Nome";
            this.Main_Data_Grid_Jogos_emprestados_Nome.Name = "Main_Data_Grid_Jogos_emprestados_Nome";
            this.Main_Data_Grid_Jogos_emprestados_Nome.Width = 170;
            // 
            // Main_Data_Grid_Jogos_emprestados_RG
            // 
            this.Main_Data_Grid_Jogos_emprestados_RG.HeaderText = "RG";
            this.Main_Data_Grid_Jogos_emprestados_RG.Name = "Main_Data_Grid_Jogos_emprestados_RG";
            // 
            // Main_Data_Grid_Jogos_emprestados_Data_do_Emprestimo
            // 
            this.Main_Data_Grid_Jogos_emprestados_Data_do_Emprestimo.HeaderText = "Emprestou em";
            this.Main_Data_Grid_Jogos_emprestados_Data_do_Emprestimo.Name = "Main_Data_Grid_Jogos_emprestados_Data_do_Emprestimo";
            this.Main_Data_Grid_Jogos_emprestados_Data_do_Emprestimo.Width = 114;
            // 
            // Main_Data_Grid_Jogos_emprestados_titulo
            // 
            this.Main_Data_Grid_Jogos_emprestados_titulo.HeaderText = "Título";
            this.Main_Data_Grid_Jogos_emprestados_titulo.Name = "Main_Data_Grid_Jogos_emprestados_titulo";
            this.Main_Data_Grid_Jogos_emprestados_titulo.Width = 250;
            // 
            // Main_Btn_EmprestimosGrid_Adicionar
            // 
            this.Main_Btn_EmprestimosGrid_Adicionar.Location = new System.Drawing.Point(6, 19);
            this.Main_Btn_EmprestimosGrid_Adicionar.Name = "Main_Btn_EmprestimosGrid_Adicionar";
            this.Main_Btn_EmprestimosGrid_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.Main_Btn_EmprestimosGrid_Adicionar.TabIndex = 7;
            this.Main_Btn_EmprestimosGrid_Adicionar.Text = "Adicionar";
            this.Main_Btn_EmprestimosGrid_Adicionar.UseVisualStyleBackColor = true;
            // 
            // Main_Btn_EmprestimosGrid_Devolucao
            // 
            this.Main_Btn_EmprestimosGrid_Devolucao.Location = new System.Drawing.Point(87, 19);
            this.Main_Btn_EmprestimosGrid_Devolucao.Name = "Main_Btn_EmprestimosGrid_Devolucao";
            this.Main_Btn_EmprestimosGrid_Devolucao.Size = new System.Drawing.Size(75, 23);
            this.Main_Btn_EmprestimosGrid_Devolucao.TabIndex = 8;
            this.Main_Btn_EmprestimosGrid_Devolucao.Text = "Devolver";
            this.Main_Btn_EmprestimosGrid_Devolucao.UseVisualStyleBackColor = true;
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(707, 429);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.btn_Sair.TabIndex = 3;
            this.btn_Sair.TabStop = false;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // grp_JogosEmCasa
            // 
            this.grp_JogosEmCasa.Controls.Add(this.btn_emprestar_jogos_em_casa);
            this.grp_JogosEmCasa.Controls.Add(this.Main_Btn_JogoisEmCasaGrid_Remover);
            this.grp_JogosEmCasa.Controls.Add(this.Main_Btn_Jogos_Em_Casa_Grid_Adicionar);
            this.grp_JogosEmCasa.Controls.Add(this.Main_dataGrid_JogosEmCasa);
            this.grp_JogosEmCasa.Location = new System.Drawing.Point(12, 12);
            this.grp_JogosEmCasa.Name = "grp_JogosEmCasa";
            this.grp_JogosEmCasa.Size = new System.Drawing.Size(689, 218);
            this.grp_JogosEmCasa.TabIndex = 6;
            this.grp_JogosEmCasa.TabStop = false;
            this.grp_JogosEmCasa.Text = "Jogos em Casa";
            // 
            // Main_Btn_JogoisEmCasaGrid_Remover
            // 
            this.Main_Btn_JogoisEmCasaGrid_Remover.Location = new System.Drawing.Point(87, 24);
            this.Main_Btn_JogoisEmCasaGrid_Remover.Name = "Main_Btn_JogoisEmCasaGrid_Remover";
            this.Main_Btn_JogoisEmCasaGrid_Remover.Size = new System.Drawing.Size(75, 23);
            this.Main_Btn_JogoisEmCasaGrid_Remover.TabIndex = 9;
            this.Main_Btn_JogoisEmCasaGrid_Remover.Text = "Remover";
            this.Main_Btn_JogoisEmCasaGrid_Remover.UseVisualStyleBackColor = true;
            // 
            // Main_Btn_Jogos_Em_Casa_Grid_Adicionar
            // 
            this.Main_Btn_Jogos_Em_Casa_Grid_Adicionar.Location = new System.Drawing.Point(6, 24);
            this.Main_Btn_Jogos_Em_Casa_Grid_Adicionar.Name = "Main_Btn_Jogos_Em_Casa_Grid_Adicionar";
            this.Main_Btn_Jogos_Em_Casa_Grid_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.Main_Btn_Jogos_Em_Casa_Grid_Adicionar.TabIndex = 8;
            this.Main_Btn_Jogos_Em_Casa_Grid_Adicionar.Text = "Adicionar";
            this.Main_Btn_Jogos_Em_Casa_Grid_Adicionar.UseVisualStyleBackColor = true;
            this.Main_Btn_Jogos_Em_Casa_Grid_Adicionar.Click += new System.EventHandler(this.Main_Btn_Jogos_Em_Casa_Grid_Adicionar_Click);
            // 
            // Main_dataGrid_JogosEmCasa
            // 
            this.Main_dataGrid_JogosEmCasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Main_dataGrid_JogosEmCasa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Main_Data_Grid_Jogos_Em_Casa_Titulo,
            this.Main_Data_Grid_Jogos_Em_Casa_Plataforma,
            this.Main_Data_Grid_Jogos_Em_Casa_Ano,
            this.Main_Data_Grid_Jogos_Em_Casa_Custo,
            this.Main_Data_Grid_Jogos_Em_Casa_Quantidade,
            this.Main_Data_Grid_Jogos_Em_Casa_DataCadastro});
            this.Main_dataGrid_JogosEmCasa.Location = new System.Drawing.Point(6, 53);
            this.Main_dataGrid_JogosEmCasa.Name = "Main_dataGrid_JogosEmCasa";
            this.Main_dataGrid_JogosEmCasa.Size = new System.Drawing.Size(677, 159);
            this.Main_dataGrid_JogosEmCasa.TabIndex = 6;
            // 
            // btn_AtualizarEmprestadosEJogosEmCasa
            // 
            this.btn_AtualizarEmprestadosEJogosEmCasa.Location = new System.Drawing.Point(707, 32);
            this.btn_AtualizarEmprestadosEJogosEmCasa.Name = "btn_AtualizarEmprestadosEJogosEmCasa";
            this.btn_AtualizarEmprestadosEJogosEmCasa.Size = new System.Drawing.Size(75, 27);
            this.btn_AtualizarEmprestadosEJogosEmCasa.TabIndex = 9;
            this.btn_AtualizarEmprestadosEJogosEmCasa.Text = "Atualizar";
            this.btn_AtualizarEmprestadosEJogosEmCasa.UseVisualStyleBackColor = true;
            this.btn_AtualizarEmprestadosEJogosEmCasa.Click += new System.EventHandler(this.btn_AtualizarEmprestadosEJogosEmCasa_Click_1);
            // 
            // Main_Data_Grid_Jogos_Em_Casa_Titulo
            // 
            this.Main_Data_Grid_Jogos_Em_Casa_Titulo.HeaderText = "Título";
            this.Main_Data_Grid_Jogos_Em_Casa_Titulo.Name = "Main_Data_Grid_Jogos_Em_Casa_Titulo";
            this.Main_Data_Grid_Jogos_Em_Casa_Titulo.ToolTipText = "Nome do Jogo";
            this.Main_Data_Grid_Jogos_Em_Casa_Titulo.Width = 250;
            // 
            // Main_Data_Grid_Jogos_Em_Casa_Plataforma
            // 
            this.Main_Data_Grid_Jogos_Em_Casa_Plataforma.HeaderText = "Plataforma";
            this.Main_Data_Grid_Jogos_Em_Casa_Plataforma.Name = "Main_Data_Grid_Jogos_Em_Casa_Plataforma";
            this.Main_Data_Grid_Jogos_Em_Casa_Plataforma.ToolTipText = "Nome do Jogo";
            this.Main_Data_Grid_Jogos_Em_Casa_Plataforma.Width = 102;
            // 
            // Main_Data_Grid_Jogos_Em_Casa_Ano
            // 
            this.Main_Data_Grid_Jogos_Em_Casa_Ano.HeaderText = "Ano";
            this.Main_Data_Grid_Jogos_Em_Casa_Ano.Name = "Main_Data_Grid_Jogos_Em_Casa_Ano";
            this.Main_Data_Grid_Jogos_Em_Casa_Ano.ToolTipText = "Ano de Produção";
            this.Main_Data_Grid_Jogos_Em_Casa_Ano.Width = 40;
            // 
            // Main_Data_Grid_Jogos_Em_Casa_Custo
            // 
            this.Main_Data_Grid_Jogos_Em_Casa_Custo.HeaderText = "Custo";
            this.Main_Data_Grid_Jogos_Em_Casa_Custo.Name = "Main_Data_Grid_Jogos_Em_Casa_Custo";
            this.Main_Data_Grid_Jogos_Em_Casa_Custo.ToolTipText = "Quanto Pagou?";
            this.Main_Data_Grid_Jogos_Em_Casa_Custo.Width = 40;
            // 
            // Main_Data_Grid_Jogos_Em_Casa_Quantidade
            // 
            this.Main_Data_Grid_Jogos_Em_Casa_Quantidade.HeaderText = "Qtd";
            this.Main_Data_Grid_Jogos_Em_Casa_Quantidade.Name = "Main_Data_Grid_Jogos_Em_Casa_Quantidade";
            this.Main_Data_Grid_Jogos_Em_Casa_Quantidade.ToolTipText = "Quantas Cópias Tem Em casa?";
            this.Main_Data_Grid_Jogos_Em_Casa_Quantidade.Width = 40;
            // 
            // Main_Data_Grid_Jogos_Em_Casa_DataCadastro
            // 
            this.Main_Data_Grid_Jogos_Em_Casa_DataCadastro.HeaderText = "Adicionado";
            this.Main_Data_Grid_Jogos_Em_Casa_DataCadastro.Name = "Main_Data_Grid_Jogos_Em_Casa_DataCadastro";
            this.Main_Data_Grid_Jogos_Em_Casa_DataCadastro.ToolTipText = "Jogo Adicionado a Coleção em";
            this.Main_Data_Grid_Jogos_Em_Casa_DataCadastro.Width = 145;
            // 
            // btn_emprestar_jogos_em_casa
            // 
            this.btn_emprestar_jogos_em_casa.Location = new System.Drawing.Point(168, 24);
            this.btn_emprestar_jogos_em_casa.Name = "btn_emprestar_jogos_em_casa";
            this.btn_emprestar_jogos_em_casa.Size = new System.Drawing.Size(75, 23);
            this.btn_emprestar_jogos_em_casa.TabIndex = 10;
            this.btn_emprestar_jogos_em_casa.Text = "Emprestar";
            this.btn_emprestar_jogos_em_casa.UseVisualStyleBackColor = true;
            this.btn_emprestar_jogos_em_casa.Click += new System.EventHandler(this.btn_emprestar_jogos_em_casa_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 474);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_AtualizarEmprestadosEJogosEmCasa);
            this.Controls.Add(this.grp_JogosEmCasa);
            this.Controls.Add(this.grp_JogosEmprestados);
            this.Name = "frm_Main";
            this.Text = "DarthVader";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.grp_JogosEmprestados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Main_dataGrid_JogosEmprestados)).EndInit();
            this.grp_JogosEmCasa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Main_dataGrid_JogosEmCasa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_JogosEmprestados;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.DataGridView Main_dataGrid_JogosEmprestados;
        private System.Windows.Forms.GroupBox grp_JogosEmCasa;
        private System.Windows.Forms.DataGridView Main_dataGrid_JogosEmCasa;
        private System.Windows.Forms.Button Main_Btn_EmprestimosGrid_Adicionar;
        private System.Windows.Forms.Button Main_Btn_EmprestimosGrid_Devolucao;
        private System.Windows.Forms.Button Main_Btn_JogoisEmCasaGrid_Remover;
        private System.Windows.Forms.Button Main_Btn_Jogos_Em_Casa_Grid_Adicionar;
        private System.Windows.Forms.Button btn_AtualizarEmprestadosEJogosEmCasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Main_Data_Grid_Jogos_emprestados_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Main_Data_Grid_Jogos_emprestados_RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Main_Data_Grid_Jogos_emprestados_Data_do_Emprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Main_Data_Grid_Jogos_emprestados_titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Main_Data_Grid_Jogos_Em_Casa_Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Main_Data_Grid_Jogos_Em_Casa_Plataforma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Main_Data_Grid_Jogos_Em_Casa_Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Main_Data_Grid_Jogos_Em_Casa_Custo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Main_Data_Grid_Jogos_Em_Casa_Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Main_Data_Grid_Jogos_Em_Casa_DataCadastro;
        private System.Windows.Forms.Button btn_emprestar_jogos_em_casa;
    }
}