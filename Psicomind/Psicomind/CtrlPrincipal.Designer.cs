namespace Psicomind
{
    partial class CtrlPrincipal
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlPrincipal));
            pictureBox1 = new PictureBox();
            lblUser = new Label();
            lblBemVindo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(770, 174);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 519);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = SystemColors.Highlight;
            lblUser.Location = new Point(39, 105);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(325, 45);
            lblUser.TabIndex = 19;
            lblUser.Text = "Mariana Napolitani";
            // 
            // lblBemVindo
            // 
            lblBemVindo.AutoSize = true;
            lblBemVindo.Font = new Font("Segoe UI Black", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBemVindo.Location = new Point(39, 54);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(227, 51);
            lblBemVindo.TabIndex = 18;
            lblBemVindo.Text = "Bem Vindo";
            lblBemVindo.Click += lblBemVindo_Click;
            // 
            // CtrlPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblUser);
            Controls.Add(lblBemVindo);
            Controls.Add(pictureBox1);
            Name = "CtrlPrincipal";
            Size = new Size(1056, 693);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label lblUser;
        private Label lblBemVindo;
    }
}
