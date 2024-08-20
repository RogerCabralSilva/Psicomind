namespace Psicomind
{
    partial class FrmAgendamentoMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgendamentoMenu));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnVoltar = new PictureBox();
            txtPsicomind = new Label();
            txtTitulo = new Label();
            btnPagEditarUsuario = new Guna.UI2.WinForms.Guna2ContainerControl();
            pictureBox5 = new PictureBox();
            label9 = new Label();
            btnPagConsultarUsuario = new Guna.UI2.WinForms.Guna2ContainerControl();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            label7 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnVoltar).BeginInit();
            btnPagEditarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            btnPagConsultarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.Location = new Point(62, 54);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(50, 30);
            btnVoltar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnVoltar.TabIndex = 51;
            btnVoltar.TabStop = false;
            // 
            // txtPsicomind
            // 
            txtPsicomind.AutoSize = true;
            txtPsicomind.Font = new Font("Arial Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPsicomind.ForeColor = SystemColors.Highlight;
            txtPsicomind.Location = new Point(396, 101);
            txtPsicomind.Name = "txtPsicomind";
            txtPsicomind.Size = new Size(141, 28);
            txtPsicomind.TabIndex = 50;
            txtPsicomind.Text = "PSICOMIND";
            // 
            // txtTitulo
            // 
            txtTitulo.AutoSize = true;
            txtTitulo.Font = new Font("Arial Black", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTitulo.ForeColor = Color.Black;
            txtTitulo.Location = new Point(319, 120);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(305, 50);
            txtTitulo.TabIndex = 49;
            txtTitulo.Text = "Agendamentos";
            // 
            // btnPagEditarUsuario
            // 
            btnPagEditarUsuario.BackColor = SystemColors.Control;
            btnPagEditarUsuario.BorderRadius = 40;
            btnPagEditarUsuario.Controls.Add(label2);
            btnPagEditarUsuario.Controls.Add(pictureBox5);
            btnPagEditarUsuario.Controls.Add(label9);
            btnPagEditarUsuario.Cursor = Cursors.Hand;
            btnPagEditarUsuario.CustomizableEdges = customizableEdges1;
            btnPagEditarUsuario.FillColor = Color.LightGray;
            btnPagEditarUsuario.Location = new Point(214, 247);
            btnPagEditarUsuario.Name = "btnPagEditarUsuario";
            btnPagEditarUsuario.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnPagEditarUsuario.Size = new Size(212, 197);
            btnPagEditarUsuario.TabIndex = 48;
            btnPagEditarUsuario.Text = "guna2ContainerControl1";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.LightGray;
            pictureBox5.Enabled = false;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(46, 94);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(114, 70);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 24;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.LightGray;
            label9.Enabled = false;
            label9.Font = new Font("Arial", 18F, FontStyle.Bold);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(64, 33);
            label9.Name = "label9";
            label9.Size = new Size(86, 29);
            label9.TabIndex = 25;
            label9.Text = "Inserir";
            // 
            // btnPagConsultarUsuario
            // 
            btnPagConsultarUsuario.BackColor = SystemColors.Control;
            btnPagConsultarUsuario.BorderRadius = 40;
            btnPagConsultarUsuario.Controls.Add(label6);
            btnPagConsultarUsuario.Controls.Add(pictureBox3);
            btnPagConsultarUsuario.Controls.Add(label5);
            btnPagConsultarUsuario.Controls.Add(label7);
            btnPagConsultarUsuario.Cursor = Cursors.Hand;
            btnPagConsultarUsuario.CustomizableEdges = customizableEdges3;
            btnPagConsultarUsuario.FillColor = Color.LightGray;
            btnPagConsultarUsuario.Location = new Point(501, 247);
            btnPagConsultarUsuario.Name = "btnPagConsultarUsuario";
            btnPagConsultarUsuario.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnPagConsultarUsuario.Size = new Size(212, 197);
            btnPagConsultarUsuario.TabIndex = 47;
            btnPagConsultarUsuario.Text = "guna2ContainerControl1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightGray;
            label6.Enabled = false;
            label6.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(20, 60);
            label6.Name = "label6";
            label6.Size = new Size(166, 26);
            label6.TabIndex = 28;
            label6.Text = "Agendamentos";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.LightGray;
            pictureBox3.Enabled = false;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(66, 94);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(77, 73);
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
            label5.Location = new Point(43, 34);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightGray;
            label2.Enabled = false;
            label2.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(23, 57);
            label2.Name = "label2";
            label2.Size = new Size(166, 26);
            label2.TabIndex = 29;
            label2.Text = "Agendamentos";
            // 
            // FrmAgendamentoMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 561);
            Controls.Add(btnVoltar);
            Controls.Add(txtPsicomind);
            Controls.Add(txtTitulo);
            Controls.Add(btnPagEditarUsuario);
            Controls.Add(btnPagConsultarUsuario);
            Name = "FrmAgendamentoMenu";
            Text = "FrmAgendamentoMenu";
            ((System.ComponentModel.ISupportInitialize)btnVoltar).EndInit();
            btnPagEditarUsuario.ResumeLayout(false);
            btnPagEditarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            btnPagConsultarUsuario.ResumeLayout(false);
            btnPagConsultarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnVoltar;
        private Label txtPsicomind;
        private Label txtTitulo;
        private Guna.UI2.WinForms.Guna2ContainerControl btnPagEditarUsuario;
        private PictureBox pictureBox5;
        private Label label9;
        private Guna.UI2.WinForms.Guna2ContainerControl btnPagConsultarUsuario;
        private Label label6;
        private PictureBox pictureBox3;
        private Label label5;
        private Label label7;
        private Label label2;
    }
}