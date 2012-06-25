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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.grp_JogosEmCasa = new System.Windows.Forms.GroupBox();
            this.dataGrid_JogosEmCasa = new System.Windows.Forms.DataGridView();
            this.btn_AdicionarJogoEmCasa = new System.Windows.Forms.Button();
            this.grp_JogosEmprestados = new System.Windows.Forms.GroupBox();
            this.dataGrid_JogosEmprestados = new System.Windows.Forms.DataGridView();
            this.btn_AdicionarEmprestimo = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_AtualizarEmprestadosEJogosEmCasa = new System.Windows.Forms.Button();
            this.grp_JogosEmCasa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_JogosEmCasa)).BeginInit();
            this.grp_JogosEmprestados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_JogosEmprestados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_JogosEmCasa
            // 
            this.grp_JogosEmCasa.Controls.Add(this.dataGrid_JogosEmCasa);
            this.grp_JogosEmCasa.Controls.Add(this.btn_AdicionarJogoEmCasa);
            this.grp_JogosEmCasa.Location = new System.Drawing.Point(12, 215);
            this.grp_JogosEmCasa.Name = "grp_JogosEmCasa";
            this.grp_JogosEmCasa.Size = new System.Drawing.Size(562, 142);
            this.grp_JogosEmCasa.TabIndex = 0;
            this.grp_JogosEmCasa.TabStop = false;
            this.grp_JogosEmCasa.Text = "Jogos em Casa";
            // 
            // dataGrid_JogosEmCasa
            // 
            this.dataGrid_JogosEmCasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_JogosEmCasa.Location = new System.Drawing.Point(6, 19);
            this.dataGrid_JogosEmCasa.Name = "dataGrid_JogosEmCasa";
            this.dataGrid_JogosEmCasa.Size = new System.Drawing.Size(455, 117);
            this.dataGrid_JogosEmCasa.TabIndex = 6;
            // 
            // btn_AdicionarJogoEmCasa
            // 
            this.btn_AdicionarJogoEmCasa.Location = new System.Drawing.Point(481, 106);
            this.btn_AdicionarJogoEmCasa.Name = "btn_AdicionarJogoEmCasa";
            this.btn_AdicionarJogoEmCasa.Size = new System.Drawing.Size(75, 23);
            this.btn_AdicionarJogoEmCasa.TabIndex = 2;
            this.btn_AdicionarJogoEmCasa.Text = "Adicionar";
            this.btn_AdicionarJogoEmCasa.UseVisualStyleBackColor = true;
            // 
            // grp_JogosEmprestados
            // 
            this.grp_JogosEmprestados.Controls.Add(this.dataGrid_JogosEmprestados);
            this.grp_JogosEmprestados.Controls.Add(this.btn_AdicionarEmprestimo);
            this.grp_JogosEmprestados.Location = new System.Drawing.Point(12, 55);
            this.grp_JogosEmprestados.Name = "grp_JogosEmprestados";
            this.grp_JogosEmprestados.Size = new System.Drawing.Size(562, 142);
            this.grp_JogosEmprestados.TabIndex = 1;
            this.grp_JogosEmprestados.TabStop = false;
            this.grp_JogosEmprestados.Text = "Jogos Emprestados";
            // 
            // dataGrid_JogosEmprestados
            // 
            this.dataGrid_JogosEmprestados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_JogosEmprestados.Location = new System.Drawing.Point(6, 19);
            this.dataGrid_JogosEmprestados.Name = "dataGrid_JogosEmprestados";
            this.dataGrid_JogosEmprestados.Size = new System.Drawing.Size(455, 117);
            this.dataGrid_JogosEmprestados.TabIndex = 5;
            this.dataGrid_JogosEmprestados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_AdicionarEmprestimo
            // 
            this.btn_AdicionarEmprestimo.Location = new System.Drawing.Point(481, 113);
            this.btn_AdicionarEmprestimo.Name = "btn_AdicionarEmprestimo";
            this.btn_AdicionarEmprestimo.Size = new System.Drawing.Size(75, 23);
            this.btn_AdicionarEmprestimo.TabIndex = 4;
            this.btn_AdicionarEmprestimo.Text = "Adicionar";
            this.btn_AdicionarEmprestimo.UseVisualStyleBackColor = true;
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(626, 334);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.btn_Sair.TabIndex = 3;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DarthVader.Properties.Resources.darth_vader;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(580, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 142);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_AtualizarEmprestadosEJogosEmCasa
            // 
            this.btn_AtualizarEmprestadosEJogosEmCasa.Location = new System.Drawing.Point(12, 22);
            this.btn_AtualizarEmprestadosEJogosEmCasa.Name = "btn_AtualizarEmprestadosEJogosEmCasa";
            this.btn_AtualizarEmprestadosEJogosEmCasa.Size = new System.Drawing.Size(75, 27);
            this.btn_AtualizarEmprestadosEJogosEmCasa.TabIndex = 4;
            this.btn_AtualizarEmprestadosEJogosEmCasa.Text = "Atualizar";
            this.btn_AtualizarEmprestadosEJogosEmCasa.UseVisualStyleBackColor = true;
            this.btn_AtualizarEmprestadosEJogosEmCasa.Click += new System.EventHandler(this.btn_AtualizarEmprestadosEJogosEmCasa_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 369);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_AtualizarEmprestadosEJogosEmCasa);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.grp_JogosEmprestados);
            this.Controls.Add(this.grp_JogosEmCasa);
            this.Name = "frm_Main";
            this.Text = "DarthVader";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.grp_JogosEmCasa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_JogosEmCasa)).EndInit();
            this.grp_JogosEmprestados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_JogosEmprestados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_JogosEmCasa;
        private System.Windows.Forms.Button btn_AdicionarJogoEmCasa;
        private System.Windows.Forms.GroupBox grp_JogosEmprestados;
        private System.Windows.Forms.Button btn_AdicionarEmprestimo;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGrid_JogosEmCasa;
        private System.Windows.Forms.DataGridView dataGrid_JogosEmprestados;
        private System.Windows.Forms.Button btn_AtualizarEmprestadosEJogosEmCasa;
    }
}