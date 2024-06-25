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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            btnSair = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(376, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(458, 653);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnSair
            // 
            btnSair.Cursor = Cursors.Hand;
            btnSair.CustomizableEdges = customizableEdges1;
            btnSair.DisabledState.BorderColor = Color.DarkGray;
            btnSair.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSair.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSair.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSair.FillColor = Color.FromArgb(224, 224, 224);
            btnSair.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(785, 16);
            btnSair.Name = "btnSair";
            btnSair.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSair.Size = new Size(35, 23);
            btnSair.TabIndex = 9;
            btnSair.Text = "X";
            btnSair.Click += btnSair_Click;
            // 
            // CtrlPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSair);
            Controls.Add(pictureBox1);
            Name = "CtrlPrincipal";
            Size = new Size(834, 653);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnSair;
    }
}
