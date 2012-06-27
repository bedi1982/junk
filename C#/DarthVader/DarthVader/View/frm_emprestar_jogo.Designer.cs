namespace DarthVader.View
{
    partial class frm_emprestar_jogo
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
            this.lbl_Plataforma = new System.Windows.Forms.Label();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.lbl_nome_de_quem_vai_emprestar = new System.Windows.Forms.Label();
            this.txt_quem_vai_emprestar = new System.Windows.Forms.TextBox();
            this.label_RG = new System.Windows.Forms.Label();
            this.txt_RG = new System.Windows.Forms.TextBox();
            this.label_nome_do_jogo = new System.Windows.Forms.Label();
            this.txt_NomeDoJogo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_texto_plataforma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Plataforma
            // 
            this.lbl_Plataforma.AutoSize = true;
            this.lbl_Plataforma.Location = new System.Drawing.Point(27, 110);
            this.lbl_Plataforma.Name = "lbl_Plataforma";
            this.lbl_Plataforma.Size = new System.Drawing.Size(60, 13);
            this.lbl_Plataforma.TabIndex = 28;
            this.lbl_Plataforma.Text = "Plataforma:";
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(250, 110);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(74, 23);
            this.btn_Adicionar.TabIndex = 25;
            this.btn_Adicionar.Text = "Confirmar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(330, 110);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.btn_Sair.TabIndex = 27;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // lbl_nome_de_quem_vai_emprestar
            // 
            this.lbl_nome_de_quem_vai_emprestar.AutoSize = true;
            this.lbl_nome_de_quem_vai_emprestar.Location = new System.Drawing.Point(2, 46);
            this.lbl_nome_de_quem_vai_emprestar.Name = "lbl_nome_de_quem_vai_emprestar";
            this.lbl_nome_de_quem_vai_emprestar.Size = new System.Drawing.Size(104, 13);
            this.lbl_nome_de_quem_vai_emprestar.TabIndex = 22;
            this.lbl_nome_de_quem_vai_emprestar.Text = "Quem vai emprestar:";
            // 
            // txt_quem_vai_emprestar
            // 
            this.txt_quem_vai_emprestar.AcceptsReturn = true;
            this.txt_quem_vai_emprestar.AcceptsTab = true;
            this.txt_quem_vai_emprestar.Location = new System.Drawing.Point(112, 43);
            this.txt_quem_vai_emprestar.Name = "txt_quem_vai_emprestar";
            this.txt_quem_vai_emprestar.Size = new System.Drawing.Size(212, 20);
            this.txt_quem_vai_emprestar.TabIndex = 21;
            // 
            // label_RG
            // 
            this.label_RG.AutoSize = true;
            this.label_RG.Location = new System.Drawing.Point(80, 72);
            this.label_RG.Name = "label_RG";
            this.label_RG.Size = new System.Drawing.Size(26, 13);
            this.label_RG.TabIndex = 19;
            this.label_RG.Text = "RG:";
            // 
            // txt_RG
            // 
            this.txt_RG.AcceptsReturn = true;
            this.txt_RG.AcceptsTab = true;
            this.txt_RG.Location = new System.Drawing.Point(112, 69);
            this.txt_RG.Name = "txt_RG";
            this.txt_RG.Size = new System.Drawing.Size(136, 20);
            this.txt_RG.TabIndex = 23;
            // 
            // label_nome_do_jogo
            // 
            this.label_nome_do_jogo.AutoSize = true;
            this.label_nome_do_jogo.Location = new System.Drawing.Point(27, 20);
            this.label_nome_do_jogo.Name = "label_nome_do_jogo";
            this.label_nome_do_jogo.Size = new System.Drawing.Size(79, 13);
            this.label_nome_do_jogo.TabIndex = 16;
            this.label_nome_do_jogo.Text = "Nome do Jogo:";
            // 
            // txt_NomeDoJogo
            // 
            this.txt_NomeDoJogo.AcceptsReturn = true;
            this.txt_NomeDoJogo.AcceptsTab = true;
            this.txt_NomeDoJogo.Location = new System.Drawing.Point(112, 17);
            this.txt_NomeDoJogo.Name = "txt_NomeDoJogo";
            this.txt_NomeDoJogo.Size = new System.Drawing.Size(212, 20);
            this.txt_NomeDoJogo.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DarthVader.Properties.Resources.game_icon;
            this.pictureBox1.InitialImage = global::DarthVader.Properties.Resources.game_icon;
            this.pictureBox1.Location = new System.Drawing.Point(331, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_texto_plataforma
            // 
            this.lbl_texto_plataforma.AutoSize = true;
            this.lbl_texto_plataforma.Location = new System.Drawing.Point(93, 110);
            this.lbl_texto_plataforma.Name = "lbl_texto_plataforma";
            this.lbl_texto_plataforma.Size = new System.Drawing.Size(139, 13);
            this.lbl_texto_plataforma.TabIndex = 30;
            this.lbl_texto_plataforma.Text = "Insira o nome do jogo acima";
            // 
            // frm_emprestar_jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 157);
            this.Controls.Add(this.lbl_texto_plataforma);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Plataforma);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.lbl_nome_de_quem_vai_emprestar);
            this.Controls.Add(this.txt_quem_vai_emprestar);
            this.Controls.Add(this.label_RG);
            this.Controls.Add(this.txt_RG);
            this.Controls.Add(this.label_nome_do_jogo);
            this.Controls.Add(this.txt_NomeDoJogo);
            this.Name = "frm_emprestar_jogo";
            this.Text = "Emprestar Jogo";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Plataforma;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Label lbl_nome_de_quem_vai_emprestar;
        private System.Windows.Forms.TextBox txt_quem_vai_emprestar;
        private System.Windows.Forms.Label label_RG;
        private System.Windows.Forms.TextBox txt_RG;
        private System.Windows.Forms.Label label_nome_do_jogo;
        private System.Windows.Forms.TextBox txt_NomeDoJogo;
        private System.Windows.Forms.Label lbl_texto_plataforma;
    }
}