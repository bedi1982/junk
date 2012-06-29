namespace DarthVader.View
{
    partial class frm_sobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sobre));
            this.lbl_sobre = new System.Windows.Forms.Label();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_sobre
            // 
            this.lbl_sobre.AutoSize = true;
            this.lbl_sobre.Location = new System.Drawing.Point(12, 9);
            this.lbl_sobre.Name = "lbl_sobre";
            this.lbl_sobre.Size = new System.Drawing.Size(273, 130);
            this.lbl_sobre.TabIndex = 0;
            this.lbl_sobre.Text = resources.GetString("lbl_sobre.Text");
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(256, 126);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(75, 24);
            this.btn_Sair.TabIndex = 1;
            this.btn_Sair.Text = "&Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DarthVader.Properties.Resources.darth_vader;
            this.pictureBox1.Location = new System.Drawing.Point(247, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 132);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frm_sobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 162);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.lbl_sobre);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_sobre";
            this.Text = "Sobre o aplicativo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_sobre;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}