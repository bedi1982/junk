namespace DarthVader.View
{
    partial class frm_Adicionar_Jogo
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
            this.txt_NomeDoJogo = new System.Windows.Forms.TextBox();
            this.label_Titulo = new System.Windows.Forms.Label();
            this.label_Quantidade = new System.Windows.Forms.Label();
            this.label_ano = new System.Windows.Forms.Label();
            this.label_Custo = new System.Windows.Forms.Label();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.radiobtn_PS3 = new System.Windows.Forms.RadioButton();
            this.radiobtn_Xbox360 = new System.Windows.Forms.RadioButton();
            this.lbl_Plataforma = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Custo = new System.Windows.Forms.MaskedTextBox();
            this.mkd_txtbox_AnoLancamento = new System.Windows.Forms.MaskedTextBox();
            this.txt_Quantidade = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_NomeDoJogo
            // 
            this.txt_NomeDoJogo.AcceptsReturn = true;
            this.txt_NomeDoJogo.AcceptsTab = true;
            this.txt_NomeDoJogo.Location = new System.Drawing.Point(113, 9);
            this.txt_NomeDoJogo.Name = "txt_NomeDoJogo";
            this.txt_NomeDoJogo.Size = new System.Drawing.Size(247, 20);
            this.txt_NomeDoJogo.TabIndex = 1;
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.Location = new System.Drawing.Point(28, 12);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(79, 13);
            this.label_Titulo.TabIndex = 11;
            this.label_Titulo.Text = "&Nome do Jogo:";
            // 
            // label_Quantidade
            // 
            this.label_Quantidade.AutoSize = true;
            this.label_Quantidade.Location = new System.Drawing.Point(42, 103);
            this.label_Quantidade.Name = "label_Quantidade";
            this.label_Quantidade.Size = new System.Drawing.Size(65, 13);
            this.label_Quantidade.TabIndex = 23;
            this.label_Quantidade.Text = "&Quantidade:";
            // 
            // label_ano
            // 
            this.label_ano.AutoSize = true;
            this.label_ano.Location = new System.Drawing.Point(1, 74);
            this.label_ano.Name = "label_ano";
            this.label_ano.Size = new System.Drawing.Size(106, 13);
            this.label_ano.TabIndex = 15;
            this.label_ano.Text = "&Ano de Lançamento:";
            // 
            // label_Custo
            // 
            this.label_Custo.AutoSize = true;
            this.label_Custo.Location = new System.Drawing.Point(25, 134);
            this.label_Custo.Name = "label_Custo";
            this.label_Custo.Size = new System.Drawing.Size(82, 13);
            this.label_Custo.TabIndex = 17;
            this.label_Custo.Text = "Quanto &Pagou?";
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(316, 140);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.btn_Sair.TabIndex = 7;
            this.btn_Sair.Text = "&Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(236, 140);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(74, 23);
            this.btn_Adicionar.TabIndex = 6;
            this.btn_Adicionar.Text = "&Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // radiobtn_PS3
            // 
            this.radiobtn_PS3.AutoSize = true;
            this.radiobtn_PS3.Location = new System.Drawing.Point(113, 39);
            this.radiobtn_PS3.Name = "radiobtn_PS3";
            this.radiobtn_PS3.Size = new System.Drawing.Size(85, 17);
            this.radiobtn_PS3.TabIndex = 2;
            this.radiobtn_PS3.TabStop = true;
            this.radiobtn_PS3.Text = "Pla&ystation 3";
            this.radiobtn_PS3.UseVisualStyleBackColor = true;
            this.radiobtn_PS3.CheckedChanged += new System.EventHandler(this.radiobtn_PS3_CheckedChanged);
            // 
            // radiobtn_Xbox360
            // 
            this.radiobtn_Xbox360.AutoSize = true;
            this.radiobtn_Xbox360.Location = new System.Drawing.Point(211, 39);
            this.radiobtn_Xbox360.Name = "radiobtn_Xbox360";
            this.radiobtn_Xbox360.Size = new System.Drawing.Size(70, 17);
            this.radiobtn_Xbox360.TabIndex = 3;
            this.radiobtn_Xbox360.TabStop = true;
            this.radiobtn_Xbox360.Text = "Xbo&x 360";
            this.radiobtn_Xbox360.UseVisualStyleBackColor = true;
            this.radiobtn_Xbox360.CheckedChanged += new System.EventHandler(this.radiobtn_Xbox360_CheckedChanged);
            // 
            // lbl_Plataforma
            // 
            this.lbl_Plataforma.AutoSize = true;
            this.lbl_Plataforma.Location = new System.Drawing.Point(42, 39);
            this.lbl_Plataforma.Name = "lbl_Plataforma";
            this.lbl_Plataforma.Size = new System.Drawing.Size(60, 13);
            this.lbl_Plataforma.TabIndex = 14;
            this.lbl_Plataforma.Text = "&Plataforma:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DarthVader.Properties.Resources.game_icon;
            this.pictureBox1.InitialImage = global::DarthVader.Properties.Resources.game_icon;
            this.pictureBox1.Location = new System.Drawing.Point(317, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Custo
            // 
            this.txt_Custo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txt_Custo.Location = new System.Drawing.Point(113, 131);
            this.txt_Custo.Name = "txt_Custo";
            this.txt_Custo.Size = new System.Drawing.Size(50, 20);
            this.txt_Custo.TabIndex = 5;
            this.txt_Custo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mkd_txtbox_AnoLancamento
            // 
            this.mkd_txtbox_AnoLancamento.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mkd_txtbox_AnoLancamento.Location = new System.Drawing.Point(113, 71);
            this.mkd_txtbox_AnoLancamento.Mask = "0000";
            this.mkd_txtbox_AnoLancamento.Name = "mkd_txtbox_AnoLancamento";
            this.mkd_txtbox_AnoLancamento.PromptChar = '.';
            this.mkd_txtbox_AnoLancamento.Size = new System.Drawing.Size(50, 20);
            this.mkd_txtbox_AnoLancamento.TabIndex = 3;
            this.mkd_txtbox_AnoLancamento.Text = "2012";
            this.mkd_txtbox_AnoLancamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txt_Quantidade.Location = new System.Drawing.Point(113, 97);
            this.txt_Quantidade.Name = "txt_Quantidade";
            this.txt_Quantidade.Size = new System.Drawing.Size(50, 20);
            this.txt_Quantidade.TabIndex = 4;
            this.txt_Quantidade.Text = "1";
            this.txt_Quantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frm_Adicionar_Jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(408, 177);
            this.Controls.Add(this.txt_Quantidade);
            this.Controls.Add(this.mkd_txtbox_AnoLancamento);
            this.Controls.Add(this.txt_Custo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Plataforma);
            this.Controls.Add(this.radiobtn_Xbox360);
            this.Controls.Add(this.radiobtn_PS3);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.label_Custo);
            this.Controls.Add(this.label_ano);
            this.Controls.Add(this.label_Quantidade);
            this.Controls.Add(this.label_Titulo);
            this.Controls.Add(this.txt_NomeDoJogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Adicionar_Jogo";
            this.Text = "Adicionar Jogo";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NomeDoJogo;
        private System.Windows.Forms.Label label_Titulo;
        private System.Windows.Forms.Label label_Quantidade;
        private System.Windows.Forms.Label label_ano;
        private System.Windows.Forms.Label label_Custo;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.RadioButton radiobtn_PS3;
        private System.Windows.Forms.RadioButton radiobtn_Xbox360;
        private System.Windows.Forms.Label lbl_Plataforma;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox txt_Custo;
        private System.Windows.Forms.MaskedTextBox mkd_txtbox_AnoLancamento;
        private System.Windows.Forms.MaskedTextBox txt_Quantidade;
    }
}