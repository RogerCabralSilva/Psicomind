﻿namespace Psicomind
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnSair = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnAgendamento = new Guna.UI2.WinForms.Guna2Button();
            btnClientes = new Guna.UI2.WinForms.Guna2Button();
            btnUsuarios = new Guna.UI2.WinForms.Guna2Button();
            btnProfissional = new Guna.UI2.WinForms.Guna2Button();
            btnHome = new Guna.UI2.WinForms.Guna2Button();
            ctrlPrincipal1 = new CtrlPrincipal();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            btnSair.Location = new Point(1041, 12);
            btnSair.Name = "btnSair";
            btnSair.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSair.Size = new Size(35, 23);
            btnSair.TabIndex = 9;
            btnSair.Text = "X";
            btnSair.Click += btnSair_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnAgendamento);
            panel1.Controls.Add(btnClientes);
            panel1.Controls.Add(btnUsuarios);
            panel1.Controls.Add(btnProfissional);
            panel1.Controls.Add(btnHome);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 653);
            panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnAgendamento
            // 
            btnAgendamento.BorderRadius = 12;
            btnAgendamento.Cursor = Cursors.Hand;
            btnAgendamento.CustomizableEdges = customizableEdges3;
            btnAgendamento.DisabledState.BorderColor = Color.DarkGray;
            btnAgendamento.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAgendamento.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAgendamento.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAgendamento.FillColor = Color.White;
            btnAgendamento.Font = new Font("Segoe UI", 9.75F);
            btnAgendamento.ForeColor = SystemColors.GrayText;
            btnAgendamento.Image = (Image)resources.GetObject("btnAgendamento.Image");
            btnAgendamento.ImageAlign = HorizontalAlignment.Left;
            btnAgendamento.ImageSize = new Size(25, 23);
            btnAgendamento.Location = new Point(12, 410);
            btnAgendamento.Name = "btnAgendamento";
            btnAgendamento.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAgendamento.Size = new Size(224, 45);
            btnAgendamento.TabIndex = 13;
            btnAgendamento.Text = "Agendamentos";
            btnAgendamento.TextAlign = HorizontalAlignment.Left;
            btnAgendamento.Click += btnClientes_Click;
            // 
            // btnClientes
            // 
            btnClientes.BorderRadius = 12;
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.CustomizableEdges = customizableEdges5;
            btnClientes.DisabledState.BorderColor = Color.DarkGray;
            btnClientes.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClientes.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClientes.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClientes.FillColor = Color.White;
            btnClientes.Font = new Font("Segoe UI", 9.75F);
            btnClientes.ForeColor = SystemColors.GrayText;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = HorizontalAlignment.Left;
            btnClientes.ImageSize = new Size(25, 23);
            btnClientes.Location = new Point(12, 359);
            btnClientes.Name = "btnClientes";
            btnClientes.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnClientes.Size = new Size(224, 45);
            btnClientes.TabIndex = 13;
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = HorizontalAlignment.Left;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BorderRadius = 12;
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.CustomizableEdges = customizableEdges7;
            btnUsuarios.DisabledState.BorderColor = Color.DarkGray;
            btnUsuarios.DisabledState.CustomBorderColor = Color.DarkGray;
            btnUsuarios.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnUsuarios.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnUsuarios.FillColor = Color.White;
            btnUsuarios.Font = new Font("Segoe UI", 9.75F);
            btnUsuarios.ForeColor = SystemColors.GrayText;
            btnUsuarios.Image = (Image)resources.GetObject("btnUsuarios.Image");
            btnUsuarios.ImageAlign = HorizontalAlignment.Left;
            btnUsuarios.ImageSize = new Size(25, 23);
            btnUsuarios.Location = new Point(12, 308);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnUsuarios.Size = new Size(224, 45);
            btnUsuarios.TabIndex = 13;
            btnUsuarios.Text = "Usuários";
            btnUsuarios.TextAlign = HorizontalAlignment.Left;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnProfissional
            // 
            btnProfissional.BorderRadius = 12;
            btnProfissional.Cursor = Cursors.Hand;
            btnProfissional.CustomizableEdges = customizableEdges9;
            btnProfissional.DisabledState.BorderColor = Color.DarkGray;
            btnProfissional.DisabledState.CustomBorderColor = Color.DarkGray;
            btnProfissional.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnProfissional.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnProfissional.FillColor = Color.White;
            btnProfissional.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProfissional.ForeColor = SystemColors.GrayText;
            btnProfissional.Image = (Image)resources.GetObject("btnProfissional.Image");
            btnProfissional.ImageAlign = HorizontalAlignment.Left;
            btnProfissional.ImageSize = new Size(25, 23);
            btnProfissional.Location = new Point(12, 259);
            btnProfissional.Name = "btnProfissional";
            btnProfissional.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnProfissional.Size = new Size(224, 43);
            btnProfissional.TabIndex = 13;
            btnProfissional.Text = "Profissionais";
            btnProfissional.TextAlign = HorizontalAlignment.Left;
            // 
            // btnHome
            // 
            btnHome.BorderRadius = 12;
            btnHome.Cursor = Cursors.Hand;
            btnHome.CustomizableEdges = customizableEdges11;
            btnHome.DisabledState.BorderColor = Color.DarkGray;
            btnHome.DisabledState.CustomBorderColor = Color.DarkGray;
            btnHome.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnHome.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnHome.FillColor = Color.White;
            btnHome.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = SystemColors.GrayText;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = HorizontalAlignment.Left;
            btnHome.ImageSize = new Size(25, 23);
            btnHome.Location = new Point(12, 197);
            btnHome.Name = "btnHome";
            btnHome.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnHome.Size = new Size(224, 56);
            btnHome.TabIndex = 13;
            btnHome.Text = "Home";
            btnHome.TextAlign = HorizontalAlignment.Left;
            btnHome.Click += btnHome_Click;
            // 
            // ctrlPrincipal1
            // 
            ctrlPrincipal1.Location = new Point(256, 0);
            ctrlPrincipal1.Name = "ctrlPrincipal1";
            ctrlPrincipal1.Size = new Size(834, 653);
            ctrlPrincipal1.TabIndex = 11;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 653);
            Controls.Add(ctrlPrincipal1);
            Controls.Add(panel1);
            Controls.Add(btnSair);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSair;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnUsuarios;
        private Guna.UI2.WinForms.Guna2Button btnClientes;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnProfissional;
        private Guna.UI2.WinForms.Guna2Button btnAgendamento;
        private CtrlPrincipal ctrlPrincipal1;
        private PictureBox pictureBox1;
    }
}