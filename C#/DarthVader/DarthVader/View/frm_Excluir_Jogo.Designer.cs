namespace DarthVader.View
{
    partial class frm_Excluir_Jogo
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
            this.lbl_GameID = new System.Windows.Forms.Label();
            this.txtbox_InsereID = new System.Windows.Forms.TextBox();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.lbl_plataforma = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_titulo_recuperado = new System.Windows.Forms.Label();
            this.lbl_plataforma_recuperada = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_emprestado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_emprestado_recuperado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_GameID
            // 
            this.lbl_GameID.AutoSize = true;
            this.lbl_GameID.Location = new System.Drawing.Point(23, 13);
            this.lbl_GameID.Name = "lbl_GameID";
            this.lbl_GameID.Size = new System.Drawing.Size(60, 13);
            this.lbl_GameID.TabIndex = 0;
            this.lbl_GameID.Text = "&Id do Jogo:";
            // 
            // txtbox_InsereID
            // 
            this.txtbox_InsereID.AcceptsTab = true;
            this.txtbox_InsereID.Location = new System.Drawing.Point(89, 10);
            this.txtbox_InsereID.Name = "txtbox_InsereID";
            this.txtbox_InsereID.Size = new System.Drawing.Size(93, 20);
            this.txtbox_InsereID.TabIndex = 1;
            this.txtbox_InsereID.AcceptsTabChanged += new System.EventHandler(this.btn_atualizar_Click);
            this.txtbox_InsereID.TabStopChanged += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(199, 108);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.btn_Sair.TabIndex = 4;
            this.btn_Sair.Text = "&Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Enabled = false;
            this.btn_Excluir.Location = new System.Drawing.Point(107, 108);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 3;
            this.btn_Excluir.Text = "&Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(199, 10);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_atualizar.TabIndex = 2;
            this.btn_atualizar.Text = "&Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // lbl_plataforma
            // 
            this.lbl_plataforma.AutoSize = true;
            this.lbl_plataforma.Location = new System.Drawing.Point(23, 62);
            this.lbl_plataforma.Name = "lbl_plataforma";
            this.lbl_plataforma.Size = new System.Drawing.Size(60, 13);
            this.lbl_plataforma.TabIndex = 7;
            this.lbl_plataforma.Text = "Plataforma:";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Location = new System.Drawing.Point(23, 39);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(38, 13);
            this.lbl_titulo.TabIndex = 8;
            this.lbl_titulo.Text = "Título:";
            // 
            // lbl_titulo_recuperado
            // 
            this.lbl_titulo_recuperado.AutoSize = true;
            this.lbl_titulo_recuperado.Location = new System.Drawing.Point(89, 39);
            this.lbl_titulo_recuperado.Name = "lbl_titulo_recuperado";
            this.lbl_titulo_recuperado.Size = new System.Drawing.Size(0, 13);
            this.lbl_titulo_recuperado.TabIndex = 9;
            // 
            // lbl_plataforma_recuperada
            // 
            this.lbl_plataforma_recuperada.AutoSize = true;
            this.lbl_plataforma_recuperada.Location = new System.Drawing.Point(89, 62);
            this.lbl_plataforma_recuperada.Name = "lbl_plataforma_recuperada";
            this.lbl_plataforma_recuperada.Size = new System.Drawing.Size(0, 13);
            this.lbl_plataforma_recuperada.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 12;
            // 
            // lbl_emprestado
            // 
            this.lbl_emprestado.AutoSize = true;
            this.lbl_emprestado.Location = new System.Drawing.Point(23, 88);
            this.lbl_emprestado.Name = "lbl_emprestado";
            this.lbl_emprestado.Size = new System.Drawing.Size(66, 13);
            this.lbl_emprestado.TabIndex = 11;
            this.lbl_emprestado.Text = "Emprestado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 13;
            // 
            // lbl_emprestado_recuperado
            // 
            this.lbl_emprestado_recuperado.AutoSize = true;
            this.lbl_emprestado_recuperado.Location = new System.Drawing.Point(92, 89);
            this.lbl_emprestado_recuperado.Name = "lbl_emprestado_recuperado";
            this.lbl_emprestado_recuperado.Size = new System.Drawing.Size(0, 13);
            this.lbl_emprestado_recuperado.TabIndex = 14;
            // 
            // frm_Excluir_Jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 152);
            this.Controls.Add(this.lbl_emprestado_recuperado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_emprestado);
            this.Controls.Add(this.lbl_plataforma_recuperada);
            this.Controls.Add(this.lbl_titulo_recuperado);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.lbl_plataforma);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.txtbox_InsereID);
            this.Controls.Add(this.lbl_GameID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Excluir_Jogo";
            this.Text = "Excluir Jogo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_GameID;
        private System.Windows.Forms.TextBox txtbox_InsereID;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Label lbl_plataforma;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_titulo_recuperado;
        private System.Windows.Forms.Label lbl_plataforma_recuperada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_emprestado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_emprestado_recuperado;
    }
}