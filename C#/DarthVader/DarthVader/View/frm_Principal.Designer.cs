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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grp_JogosEmprestados = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_valor_total_emprestados = new System.Windows.Forms.Label();
            this.Main_dataGrid_JogosEmprestados = new System.Windows.Forms.DataGridView();
            this.Main_Data_Grid_Jogos_emprestados_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Main_Data_Grid_Jogos_emprestados_titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Main_Data_Grid_Jogos_emprestados_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Main_Data_Grid_Jogos_emprestados_RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Main_Data_Grid_Jogos_emprestados_Data_do_Emprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Devolucao = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.grp_JogosEmCasa = new System.Windows.Forms.GroupBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_valor_total_em_casa = new System.Windows.Forms.Label();
            this.btn_Emprestar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.Main_dataGrid_JogosEmCasa = new System.Windows.Forms.DataGridView();
            this.Main_Data_Grid_Jogos_Em_Casa_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Main_Data_Grid_Jogos_Em_Casa_Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Main_Data_Grid_Jogos_Em_Casa_Plataforma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Main_Data_Grid_Jogos_Em_Casa_Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Main_Data_Grid_Jogos_Em_Casa_Custo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Main_Data_Grid_Jogos_Em_Casa_Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Main_Data_Grid_Jogos_Em_Casa_DataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_sobre = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grp_JogosEmprestados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_dataGrid_JogosEmprestados)).BeginInit();
            this.grp_JogosEmCasa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_dataGrid_JogosEmCasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_JogosEmprestados
            // 
            this.grp_JogosEmprestados.Controls.Add(this.label1);
            this.grp_JogosEmprestados.Controls.Add(this.lbl_valor_total_emprestados);
            this.grp_JogosEmprestados.Controls.Add(this.Main_dataGrid_JogosEmprestados);
            this.grp_JogosEmprestados.Controls.Add(this.btn_Devolucao);
            this.grp_JogosEmprestados.Location = new System.Drawing.Point(12, 261);
            this.grp_JogosEmprestados.Name = "grp_JogosEmprestados";
            this.grp_JogosEmprestados.Size = new System.Drawing.Size(689, 234);
            this.grp_JogosEmprestados.TabIndex = 1;
            this.grp_JogosEmprestados.TabStop = false;
            this.grp_JogosEmprestados.Text = "Jogos Emprestados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Valor dos Jogos Emprestados:";
            // 
            // lbl_valor_total_emprestados
            // 
            this.lbl_valor_total_emprestados.AutoSize = true;
            this.lbl_valor_total_emprestados.Location = new System.Drawing.Point(597, 29);
            this.lbl_valor_total_emprestados.Name = "lbl_valor_total_emprestados";
            this.lbl_valor_total_emprestados.Size = new System.Drawing.Size(0, 13);
            this.lbl_valor_total_emprestados.TabIndex = 8;
            // 
            // Main_dataGrid_JogosEmprestados
            // 
            this.Main_dataGrid_JogosEmprestados.AllowUserToAddRows = false;
            this.Main_dataGrid_JogosEmprestados.AllowUserToDeleteRows = false;
            this.Main_dataGrid_JogosEmprestados.AllowUserToResizeColumns = false;
            this.Main_dataGrid_JogosEmprestados.AllowUserToResizeRows = false;
            this.Main_dataGrid_JogosEmprestados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Main_dataGrid_JogosEmprestados.CausesValidation = false;
            this.Main_dataGrid_JogosEmprestados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Main_dataGrid_JogosEmprestados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Main_Data_Grid_Jogos_emprestados_id,
            this.Main_Data_Grid_Jogos_emprestados_titulo,
            this.Main_Data_Grid_Jogos_emprestados_Nome,
            this.Main_Data_Grid_Jogos_emprestados_RG,
            this.Main_Data_Grid_Jogos_emprestados_Data_do_Emprestimo});
            this.Main_dataGrid_JogosEmprestados.Location = new System.Drawing.Point(6, 48);
            this.Main_dataGrid_JogosEmprestados.Name = "Main_dataGrid_JogosEmprestados";
            this.Main_dataGrid_JogosEmprestados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Main_dataGrid_JogosEmprestados.Size = new System.Drawing.Size(677, 178);
            this.Main_dataGrid_JogosEmprestados.TabIndex = 5;
            // 
            // Main_Data_Grid_Jogos_emprestados_id
            // 
            this.Main_Data_Grid_Jogos_emprestados_id.HeaderText = "id";
            this.Main_Data_Grid_Jogos_emprestados_id.Name = "Main_Data_Grid_Jogos_emprestados_id";
            this.Main_Data_Grid_Jogos_emprestados_id.Width = 40;
            // 
            // Main_Data_Grid_Jogos_emprestados_titulo
            // 
            this.Main_Data_Grid_Jogos_emprestados_titulo.HeaderText = "Título";
            this.Main_Data_Grid_Jogos_emprestados_titulo.Name = "Main_Data_Grid_Jogos_emprestados_titulo";
            this.Main_Data_Grid_Jogos_emprestados_titulo.Width = 245;
            // 
            // Main_Data_Grid_Jogos_emprestados_Nome
            // 
            this.Main_Data_Grid_Jogos_emprestados_Nome.HeaderText = "Nome";
            this.Main_Data_Grid_Jogos_emprestados_Nome.Name = "Main_Data_Grid_Jogos_emprestados_Nome";
            this.Main_Data_Grid_Jogos_emprestados_Nome.Width = 130;
            // 
            // Main_Data_Grid_Jogos_emprestados_RG
            // 
            dataGridViewCellStyle3.Format = "9999-9999";
            dataGridViewCellStyle3.NullValue = null;
            this.Main_Data_Grid_Jogos_emprestados_RG.DefaultCellStyle = dataGridViewCellStyle3;
            this.Main_Data_Grid_Jogos_emprestados_RG.HeaderText = "Telefone";
            this.Main_Data_Grid_Jogos_emprestados_RG.MaxInputLength = 99999999;
            this.Main_Data_Grid_Jogos_emprestados_RG.Name = "Main_Data_Grid_Jogos_emprestados_RG";
            this.Main_Data_Grid_Jogos_emprestados_RG.Width = 90;
            // 
            // Main_Data_Grid_Jogos_emprestados_Data_do_Emprestimo
            // 
            this.Main_Data_Grid_Jogos_emprestados_Data_do_Emprestimo.HeaderText = "Emprestou em";
            this.Main_Data_Grid_Jogos_emprestados_Data_do_Emprestimo.Name = "Main_Data_Grid_Jogos_emprestados_Data_do_Emprestimo";
            this.Main_Data_Grid_Jogos_emprestados_Data_do_Emprestimo.Width = 130;
            // 
            // btn_Devolucao
            // 
            this.btn_Devolucao.Enabled = false;
            this.btn_Devolucao.Location = new System.Drawing.Point(6, 19);
            this.btn_Devolucao.Name = "btn_Devolucao";
            this.btn_Devolucao.Size = new System.Drawing.Size(75, 23);
            this.btn_Devolucao.TabIndex = 4;
            this.btn_Devolucao.Text = "&Devolução";
            this.btn_Devolucao.UseVisualStyleBackColor = true;
            this.btn_Devolucao.Click += new System.EventHandler(this.Main_Btn_EmprestimosGrid_Devolucao_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Sair.Location = new System.Drawing.Point(707, 472);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.btn_Sair.TabIndex = 6;
            this.btn_Sair.TabStop = false;
            this.btn_Sair.Text = "&Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // grp_JogosEmCasa
            // 
            this.grp_JogosEmCasa.Controls.Add(this.lbl_total);
            this.grp_JogosEmCasa.Controls.Add(this.lbl_valor_total_em_casa);
            this.grp_JogosEmCasa.Controls.Add(this.btn_Emprestar);
            this.grp_JogosEmCasa.Controls.Add(this.btn_Excluir);
            this.grp_JogosEmCasa.Controls.Add(this.btn_Adicionar);
            this.grp_JogosEmCasa.Controls.Add(this.Main_dataGrid_JogosEmCasa);
            this.grp_JogosEmCasa.Location = new System.Drawing.Point(12, 12);
            this.grp_JogosEmCasa.Name = "grp_JogosEmCasa";
            this.grp_JogosEmCasa.Size = new System.Drawing.Size(689, 243);
            this.grp_JogosEmCasa.TabIndex = 6;
            this.grp_JogosEmCasa.TabStop = false;
            this.grp_JogosEmCasa.Text = "Jogos em Casa";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(506, 34);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(85, 13);
            this.lbl_total.TabIndex = 8;
            this.lbl_total.Text = "Valor dos Jogos:";
            // 
            // lbl_valor_total_em_casa
            // 
            this.lbl_valor_total_em_casa.AutoSize = true;
            this.lbl_valor_total_em_casa.Location = new System.Drawing.Point(597, 34);
            this.lbl_valor_total_em_casa.Name = "lbl_valor_total_em_casa";
            this.lbl_valor_total_em_casa.Size = new System.Drawing.Size(0, 13);
            this.lbl_valor_total_em_casa.TabIndex = 7;
            // 
            // btn_Emprestar
            // 
            this.btn_Emprestar.Enabled = false;
            this.btn_Emprestar.Location = new System.Drawing.Point(87, 24);
            this.btn_Emprestar.Name = "btn_Emprestar";
            this.btn_Emprestar.Size = new System.Drawing.Size(75, 23);
            this.btn_Emprestar.TabIndex = 2;
            this.btn_Emprestar.Text = "&Emprestar";
            this.btn_Emprestar.UseVisualStyleBackColor = true;
            this.btn_Emprestar.Click += new System.EventHandler(this.btn_emprestar_jogos_em_casa_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Enabled = false;
            this.btn_Excluir.Location = new System.Drawing.Point(168, 24);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 3;
            this.btn_Excluir.Text = "E&xcluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.Main_Btn_JogoisEmCasaGrid_Excluir_Click_1);
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(6, 24);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_Adicionar.TabIndex = 1;
            this.btn_Adicionar.Text = "&Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.Main_Btn_Jogos_Em_Casa_Grid_Adicionar_Click);
            // 
            // Main_dataGrid_JogosEmCasa
            // 
            this.Main_dataGrid_JogosEmCasa.AllowUserToAddRows = false;
            this.Main_dataGrid_JogosEmCasa.AllowUserToDeleteRows = false;
            this.Main_dataGrid_JogosEmCasa.AllowUserToResizeColumns = false;
            this.Main_dataGrid_JogosEmCasa.AllowUserToResizeRows = false;
            this.Main_dataGrid_JogosEmCasa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Main_dataGrid_JogosEmCasa.CausesValidation = false;
            this.Main_dataGrid_JogosEmCasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Main_dataGrid_JogosEmCasa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Main_Data_Grid_Jogos_Em_Casa_id,
            this.Main_Data_Grid_Jogos_Em_Casa_Titulo,
            this.Main_Data_Grid_Jogos_Em_Casa_Plataforma,
            this.Main_Data_Grid_Jogos_Em_Casa_Ano,
            this.Main_Data_Grid_Jogos_Em_Casa_Custo,
            this.Main_Data_Grid_Jogos_Em_Casa_Quantidade,
            this.Main_Data_Grid_Jogos_Em_Casa_DataCadastro});
            this.Main_dataGrid_JogosEmCasa.Enabled = false;
            this.Main_dataGrid_JogosEmCasa.Location = new System.Drawing.Point(6, 53);
            this.Main_dataGrid_JogosEmCasa.MultiSelect = false;
            this.Main_dataGrid_JogosEmCasa.Name = "Main_dataGrid_JogosEmCasa";
            this.Main_dataGrid_JogosEmCasa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Main_dataGrid_JogosEmCasa.ShowEditingIcon = false;
            this.Main_dataGrid_JogosEmCasa.Size = new System.Drawing.Size(677, 184);
            this.Main_dataGrid_JogosEmCasa.TabIndex = 6;
            // 
            // Main_Data_Grid_Jogos_Em_Casa_id
            // 
            this.Main_Data_Grid_Jogos_Em_Casa_id.HeaderText = "id";
            this.Main_Data_Grid_Jogos_Em_Casa_id.Name = "Main_Data_Grid_Jogos_Em_Casa_id";
            this.Main_Data_Grid_Jogos_Em_Casa_id.ToolTipText = "Identificação";
            this.Main_Data_Grid_Jogos_Em_Casa_id.Width = 40;
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
            this.Main_Data_Grid_Jogos_Em_Casa_Plataforma.Width = 72;
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
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Main_Data_Grid_Jogos_Em_Casa_Custo.DefaultCellStyle = dataGridViewCellStyle4;
            this.Main_Data_Grid_Jogos_Em_Casa_Custo.HeaderText = "Custo";
            this.Main_Data_Grid_Jogos_Em_Casa_Custo.Name = "Main_Data_Grid_Jogos_Em_Casa_Custo";
            this.Main_Data_Grid_Jogos_Em_Casa_Custo.ToolTipText = "Quanto Pagou?";
            this.Main_Data_Grid_Jogos_Em_Casa_Custo.Width = 70;
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
            this.Main_Data_Grid_Jogos_Em_Casa_DataCadastro.Width = 123;
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Atualizar.Location = new System.Drawing.Point(707, 32);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(75, 27);
            this.btn_Atualizar.TabIndex = 5;
            this.btn_Atualizar.Text = "At&ualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_AtualizarEmprestadosEJogosEmCasa_Click);
            // 
            // btn_sobre
            // 
            this.btn_sobre.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_sobre.Location = new System.Drawing.Point(707, 65);
            this.btn_sobre.Name = "btn_sobre";
            this.btn_sobre.Size = new System.Drawing.Size(75, 27);
            this.btn_sobre.TabIndex = 11;
            this.btn_sobre.Text = "&Sobre";
            this.btn_sobre.UseVisualStyleBackColor = true;
            this.btn_sobre.Click += new System.EventHandler(this.btn_sobre_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DarthVader.Properties.Resources.darth_vader;
            this.pictureBox1.Location = new System.Drawing.Point(687, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btn_Sair;
            this.ClientSize = new System.Drawing.Size(787, 507);
            this.Controls.Add(this.btn_sobre);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.grp_JogosEmCasa);
            this.Controls.Add(this.grp_JogosEmprestados);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "frm_Main";
            this.Text = "DarthVader";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.grp_JogosEmprestados.ResumeLayout(false);
            this.grp_JogosEmprestados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_dataGrid_JogosEmprestados)).EndInit();
            this.grp_JogosEmCasa.ResumeLayout(false);
            this.grp_JogosEmCasa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_dataGrid_JogosEmCasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_JogosEmprestados;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.GroupBox grp_JogosEmCasa;
        private System.Windows.Forms.Button btn_Devolucao;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.Button btn_Emprestar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_sobre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Main_Data_Grid_Jogos_emprestados_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Main_Data_Grid_Jogos_emprestados_titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Main_Data_Grid_Jogos_emprestados_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Main_Data_Grid_Jogos_emprestados_RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Main_Data_Grid_Jogos_emprestados_Data_do_Emprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Main_Data_Grid_Jogos_Em_Casa_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Main_Data_Grid_Jogos_Em_Casa_Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Main_Data_Grid_Jogos_Em_Casa_Plataforma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Main_Data_Grid_Jogos_Em_Casa_Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Main_Data_Grid_Jogos_Em_Casa_Custo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Main_Data_Grid_Jogos_Em_Casa_Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Main_Data_Grid_Jogos_Em_Casa_DataCadastro;
        protected System.Windows.Forms.DataGridView Main_dataGrid_JogosEmprestados;
        protected System.Windows.Forms.DataGridView Main_dataGrid_JogosEmCasa;
        private System.Windows.Forms.Label lbl_valor_total_em_casa;
        private System.Windows.Forms.Label lbl_valor_total_emprestados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_total;
    }
}