namespace DarthVader.View
{
    partial class frm_DarthVader
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
            this.picture_darthVader = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_darthVader)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_darthVader
            // 
            this.picture_darthVader.Image = global::DarthVader.Properties.Resources.DarthVader;
            this.picture_darthVader.Location = new System.Drawing.Point(12, 12);
            this.picture_darthVader.Name = "picture_darthVader";
            this.picture_darthVader.Size = new System.Drawing.Size(300, 297);
            this.picture_darthVader.TabIndex = 0;
            this.picture_darthVader.TabStop = false;
            this.picture_darthVader.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frm_DarthVader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 319);
            this.Controls.Add(this.picture_darthVader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_DarthVader";
            this.Text = "Luke, i am your father!";
            ((System.ComponentModel.ISupportInitialize)(this.picture_darthVader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_darthVader;
    }
}