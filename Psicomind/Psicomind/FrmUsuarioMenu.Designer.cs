﻿namespace Psicomind
{
    partial class FrmUsuarioMenu
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarioMenu));
            txtPsicomind = new Label();
            txtTitulo = new Label();
            btnPagConsultarUsuario = new Guna.UI2.WinForms.Guna2ContainerControl();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            label7 = new Label();
            btnVoltar = new PictureBox();
            btnPagConsultarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnVoltar).BeginInit();
            SuspendLayout();
            // 
            // txtPsicomind
            // 
            txtPsicomind.Anchor = AnchorStyles.None;
            txtPsicomind.AutoSize = true;
            txtPsicomind.Font = new Font("Arial Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPsicomind.ForeColor = SystemColors.Highlight;
            txtPsicomind.Location = new Point(387, 94);
            txtPsicomind.Name = "txtPsicomind";
            txtPsicomind.Size = new Size(141, 28);
            txtPsicomind.TabIndex = 45;
            txtPsicomind.Text = "PSICOMIND";
            // 
            // txtTitulo
            // 
            txtTitulo.Anchor = AnchorStyles.None;
            txtTitulo.AutoSize = true;
            txtTitulo.Font = new Font("Arial Black", 32F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTitulo.ForeColor = Color.Black;
            txtTitulo.Location = new Point(346, 110);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(233, 60);
            txtTitulo.TabIndex = 44;
            txtTitulo.Text = "Usuários";
            // 
            // btnPagConsultarUsuario
            // 
            btnPagConsultarUsuario.Anchor = AnchorStyles.None;
            btnPagConsultarUsuario.BackColor = SystemColors.Control;
            btnPagConsultarUsuario.BorderRadius = 40;
            btnPagConsultarUsuario.Controls.Add(label6);
            btnPagConsultarUsuario.Controls.Add(pictureBox3);
            btnPagConsultarUsuario.Controls.Add(label5);
            btnPagConsultarUsuario.Controls.Add(label7);
            btnPagConsultarUsuario.Cursor = Cursors.Hand;
            btnPagConsultarUsuario.CustomizableEdges = customizableEdges1;
            btnPagConsultarUsuario.FillColor = Color.LightGray;
            btnPagConsultarUsuario.Location = new Point(346, 234);
            btnPagConsultarUsuario.Name = "btnPagConsultarUsuario";
            btnPagConsultarUsuario.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnPagConsultarUsuario.Size = new Size(212, 197);
            btnPagConsultarUsuario.TabIndex = 42;
            btnPagConsultarUsuario.Text = "guna2ContainerControl1";
            btnPagConsultarUsuario.Click += btnPagConsultarUsuario_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightGray;
            label6.Enabled = false;
            label6.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(49, 68);
            label6.Name = "label6";
            label6.Size = new Size(115, 29);
            label6.TabIndex = 28;
            label6.Text = "Usuários";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.LightGray;
            pictureBox3.Enabled = false;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(59, 104);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(96, 60);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 24;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightGray;
            label5.Enabled = false;
            label5.Font = new Font("Arial", 18F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(44, 42);
            label5.Name = "label5";
            label5.Size = new Size(125, 29);
            label5.TabIndex = 25;
            label5.Text = "Consultar";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightGray;
            label7.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(66, 37);
            label7.Name = "label7";
            label7.Size = new Size(99, 32);
            label7.TabIndex = 23;
            label7.Text = "Inserir";
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.None;
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.Location = new Point(49, 38);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(50, 30);
            btnVoltar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnVoltar.TabIndex = 46;
            btnVoltar.TabStop = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FrmUsuarioMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 561);
            Controls.Add(btnVoltar);
            Controls.Add(txtPsicomind);
            Controls.Add(txtTitulo);
            Controls.Add(btnPagConsultarUsuario);
            Name = "FrmUsuarioMenu";
            Text = "FrmUsuarioMenu";
            btnPagConsultarUsuario.ResumeLayout(false);
            btnPagConsultarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnVoltar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtPsicomind;
        private Label txtTitulo;
        private Guna.UI2.WinForms.Guna2ContainerControl btnPagConsultarUsuario;
        private Label label6;
        private PictureBox pictureBox3;
        private Label label5;
        private Label label7;
        private PictureBox btnVoltar;
    }
}