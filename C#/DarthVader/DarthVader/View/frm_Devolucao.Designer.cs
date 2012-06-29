namespace DarthVader.View
{
    partial class frm_Devolucao
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
            this.lbl_plataforma_recuperada = new System.Windows.Forms.Label();
            this.lbl_titulo_recuperado = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_plataforma = new System.Windows.Forms.Label();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_devolver = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.txtbox_InsereID = new System.Windows.Forms.TextBox();
            this.lbl_GameID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_emprestado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_emprestado_recuperado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_plataforma_recuperada
            // 
            this.lbl_plataforma_recuperada.AutoSize = true;
            this.lbl_plataforma_recuperada.Location = new System.Drawing.Point(85, 64);
            this.lbl_plataforma_recuperada.Name = "lbl_plataforma_recuperada";
            this.lbl_plataforma_recuperada.Size = new System.Drawing.Size(0, 13);
            this.lbl_plataforma_recuperada.TabIndex = 23;
            // 
            // lbl_titulo_recuperado
            // 
            this.lbl_titulo_recuperado.AutoSize = true;
            this.lbl_titulo_recuperado.Location = new System.Drawing.Point(85, 41);
            this.lbl_titulo_recuperado.Name = "lbl_titulo_recuperado";
            this.lbl_titulo_recuperado.Size = new System.Drawing.Size(0, 13);
            this.lbl_titulo_recuperado.TabIndex = 22;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Location = new System.Drawing.Point(19, 41);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(38, 13);
            this.lbl_titulo.TabIndex = 21;
            this.lbl_titulo.Text = "Título:";
            // 
            // lbl_plataforma
            // 
            this.lbl_plataforma.AutoSize = true;
            this.lbl_plataforma.Location = new System.Drawing.Point(19, 64);
            this.lbl_plataforma.Name = "lbl_plataforma";
            this.lbl_plataforma.Size = new System.Drawing.Size(60, 13);
            this.lbl_plataforma.TabIndex = 20;
            this.lbl_plataforma.Text = "Plataforma:";
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(180, 12);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_atualizar.TabIndex = 2;
            this.btn_atualizar.Text = "&Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_devolver
            // 
            this.btn_devolver.Enabled = false;
            this.btn_devolver.Location = new System.Drawing.Point(170, 128);
            this.btn_devolver.Name = "btn_devolver";
            this.btn_devolver.Size = new System.Drawing.Size(75, 23);
            this.btn_devolver.TabIndex = 3;
            this.btn_devolver.Text = "&Devolver";
            this.btn_devolver.UseVisualStyleBackColor = true;
            this.btn_devolver.Click += new System.EventHandler(this.btn_devolver_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Sair.Location = new System.Drawing.Point(260, 128);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.btn_Sair.TabIndex = 4;
            this.btn_Sair.Text = "&Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // txtbox_InsereID
            // 
            this.txtbox_InsereID.Location = new System.Drawing.Point(116, 12);
            this.txtbox_InsereID.Name = "txtbox_InsereID";
            this.txtbox_InsereID.Size = new System.Drawing.Size(48, 20);
            this.txtbox_InsereID.TabIndex = 1;
            // 
            // lbl_GameID
            // 
            this.lbl_GameID.AutoSize = true;
            this.lbl_GameID.Location = new System.Drawing.Point(19, 15);
            this.lbl_GameID.Name = "lbl_GameID";
            this.lbl_GameID.Size = new System.Drawing.Size(91, 13);
            this.lbl_GameID.TabIndex = 15;
            this.lbl_GameID.Text = "&Id do Empréstimo:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DarthVader.Properties.Resources.game_icon;
            this.pictureBox1.Location = new System.Drawing.Point(261, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_emprestado
            // 
            this.lbl_emprestado.AutoSize = true;
            this.lbl_emprestado.Location = new System.Drawing.Point(19, 90);
            this.lbl_emprestado.Name = "lbl_emprestado";
            this.lbl_emprestado.Size = new System.Drawing.Size(66, 13);
            this.lbl_emprestado.TabIndex = 24;
            this.lbl_emprestado.Text = "Emprestado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 26;
            // 
            // lbl_emprestado_recuperado
            // 
            this.lbl_emprestado_recuperado.AutoSize = true;
            this.lbl_emprestado_recuperado.Location = new System.Drawing.Point(88, 91);
            this.lbl_emprestado_recuperado.Name = "lbl_emprestado_recuperado";
            this.lbl_emprestado_recuperado.Size = new System.Drawing.Size(0, 13);
            this.lbl_emprestado_recuperado.TabIndex = 27;
            // 
            // frm_Devolucao
            // 
            this.AcceptButton = this.btn_atualizar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btn_Sair;
            this.ClientSize = new System.Drawing.Size(344, 159);
            this.Controls.Add(this.lbl_emprestado_recuperado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_emprestado);
            this.Controls.Add(this.lbl_plataforma_recuperada);
            this.Controls.Add(this.lbl_titulo_recuperado);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.lbl_plataforma);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.btn_devolver);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.txtbox_InsereID);
            this.Controls.Add(this.lbl_GameID);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Devolucao";
            this.Text = "Devolucao";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_plataforma_recuperada;
        private System.Windows.Forms.Label lbl_titulo_recuperado;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_plataforma;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_devolver;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.TextBox txtbox_InsereID;
        private System.Windows.Forms.Label lbl_GameID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_emprestado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_emprestado_recuperado;
    }
}