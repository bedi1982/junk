namespace DarthVader.View
{
    partial class frm_Emprestar_jogo
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
            this.btn_emprestar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.lbl_nome_de_quem_vai_emprestar = new System.Windows.Forms.Label();
            this.txt_quem_vai_emprestar = new System.Windows.Forms.TextBox();
            this.label_RG = new System.Windows.Forms.Label();
            this.txt_RG = new System.Windows.Forms.TextBox();
            this.label_nome_do_jogo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_id_do_jogo = new System.Windows.Forms.Label();
            this.txtbox_id_do_jogo = new System.Windows.Forms.TextBox();
            this.btn_procurar = new System.Windows.Forms.Button();
            this.txt_NomeDoJogo = new System.Windows.Forms.TextBox();
            this.lbl_status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_emprestar
            // 
            this.btn_emprestar.Enabled = false;
            this.btn_emprestar.Location = new System.Drawing.Point(256, 137);
            this.btn_emprestar.Name = "btn_emprestar";
            this.btn_emprestar.Size = new System.Drawing.Size(74, 23);
            this.btn_emprestar.TabIndex = 4;
            this.btn_emprestar.Text = "&Emprestar";
            this.btn_emprestar.UseVisualStyleBackColor = true;
            this.btn_emprestar.Click += new System.EventHandler(this.btn_emprestar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Sair.Location = new System.Drawing.Point(336, 137);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.btn_Sair.TabIndex = 5;
            this.btn_Sair.Text = "&Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // lbl_nome_de_quem_vai_emprestar
            // 
            this.lbl_nome_de_quem_vai_emprestar.AutoSize = true;
            this.lbl_nome_de_quem_vai_emprestar.Location = new System.Drawing.Point(7, 78);
            this.lbl_nome_de_quem_vai_emprestar.Name = "lbl_nome_de_quem_vai_emprestar";
            this.lbl_nome_de_quem_vai_emprestar.Size = new System.Drawing.Size(104, 13);
            this.lbl_nome_de_quem_vai_emprestar.TabIndex = 22;
            this.lbl_nome_de_quem_vai_emprestar.Text = "&Quem vai emprestar:";
            // 
            // txt_quem_vai_emprestar
            // 
            this.txt_quem_vai_emprestar.AcceptsReturn = true;
            this.txt_quem_vai_emprestar.AcceptsTab = true;
            this.txt_quem_vai_emprestar.Location = new System.Drawing.Point(117, 75);
            this.txt_quem_vai_emprestar.Name = "txt_quem_vai_emprestar";
            this.txt_quem_vai_emprestar.Size = new System.Drawing.Size(212, 20);
            this.txt_quem_vai_emprestar.TabIndex = 2;
            // 
            // label_RG
            // 
            this.label_RG.AutoSize = true;
            this.label_RG.Location = new System.Drawing.Point(52, 104);
            this.label_RG.Name = "label_RG";
            this.label_RG.Size = new System.Drawing.Size(52, 13);
            this.label_RG.TabIndex = 19;
            this.label_RG.Text = "&Telefone:";
            // 
            // txt_RG
            // 
            this.txt_RG.AcceptsReturn = true;
            this.txt_RG.AcceptsTab = true;
            this.txt_RG.Location = new System.Drawing.Point(117, 101);
            this.txt_RG.Name = "txt_RG";
            this.txt_RG.Size = new System.Drawing.Size(136, 20);
            this.txt_RG.TabIndex = 3;
            // 
            // label_nome_do_jogo
            // 
            this.label_nome_do_jogo.AutoSize = true;
            this.label_nome_do_jogo.Location = new System.Drawing.Point(32, 52);
            this.label_nome_do_jogo.Name = "label_nome_do_jogo";
            this.label_nome_do_jogo.Size = new System.Drawing.Size(79, 13);
            this.label_nome_do_jogo.TabIndex = 16;
            this.label_nome_do_jogo.Text = "&Nome do Jogo:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DarthVader.Properties.Resources.game_icon;
            this.pictureBox1.InitialImage = global::DarthVader.Properties.Resources.game_icon;
            this.pictureBox1.Location = new System.Drawing.Point(337, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // label_id_do_jogo
            // 
            this.label_id_do_jogo.AutoSize = true;
            this.label_id_do_jogo.Location = new System.Drawing.Point(52, 26);
            this.label_id_do_jogo.Name = "label_id_do_jogo";
            this.label_id_do_jogo.Size = new System.Drawing.Size(60, 13);
            this.label_id_do_jogo.TabIndex = 31;
            this.label_id_do_jogo.Text = "&Id do Jogo:";
            // 
            // txtbox_id_do_jogo
            // 
            this.txtbox_id_do_jogo.Location = new System.Drawing.Point(118, 23);
            this.txtbox_id_do_jogo.Name = "txtbox_id_do_jogo";
            this.txtbox_id_do_jogo.Size = new System.Drawing.Size(50, 20);
            this.txtbox_id_do_jogo.TabIndex = 1;
            // 
            // btn_procurar
            // 
            this.btn_procurar.Location = new System.Drawing.Point(191, 21);
            this.btn_procurar.Name = "btn_procurar";
            this.btn_procurar.Size = new System.Drawing.Size(75, 23);
            this.btn_procurar.TabIndex = 32;
            this.btn_procurar.Text = "&Procurar";
            this.btn_procurar.UseVisualStyleBackColor = true;
            this.btn_procurar.Click += new System.EventHandler(this.btn_procurar_Click);
            // 
            // txt_NomeDoJogo
            // 
            this.txt_NomeDoJogo.AcceptsReturn = true;
            this.txt_NomeDoJogo.AcceptsTab = true;
            this.txt_NomeDoJogo.Enabled = false;
            this.txt_NomeDoJogo.Location = new System.Drawing.Point(117, 49);
            this.txt_NomeDoJogo.Name = "txt_NomeDoJogo";
            this.txt_NomeDoJogo.Size = new System.Drawing.Size(212, 20);
            this.txt_NomeDoJogo.TabIndex = 17;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(36, 136);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 13);
            this.lbl_status.TabIndex = 33;
            // 
            // frm_Emprestar_jogo
            // 
            this.AcceptButton = this.btn_emprestar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btn_Sair;
            this.ClientSize = new System.Drawing.Size(414, 172);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.btn_procurar);
            this.Controls.Add(this.txtbox_id_do_jogo);
            this.Controls.Add(this.label_id_do_jogo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_emprestar);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.lbl_nome_de_quem_vai_emprestar);
            this.Controls.Add(this.txt_quem_vai_emprestar);
            this.Controls.Add(this.label_RG);
            this.Controls.Add(this.txt_RG);
            this.Controls.Add(this.label_nome_do_jogo);
            this.Controls.Add(this.txt_NomeDoJogo);
            this.MaximizeBox = false;
            this.Name = "frm_Emprestar_jogo";
            this.Text = "Emprestar Jogo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_emprestar;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Label lbl_nome_de_quem_vai_emprestar;
        private System.Windows.Forms.TextBox txt_quem_vai_emprestar;
        private System.Windows.Forms.Label label_RG;
        private System.Windows.Forms.TextBox txt_RG;
        private System.Windows.Forms.Label label_nome_do_jogo;
        private System.Windows.Forms.Label label_id_do_jogo;
        private System.Windows.Forms.TextBox txtbox_id_do_jogo;
        private System.Windows.Forms.Button btn_procurar;
        private System.Windows.Forms.TextBox txt_NomeDoJogo;
        private System.Windows.Forms.Label lbl_status;
    }
}