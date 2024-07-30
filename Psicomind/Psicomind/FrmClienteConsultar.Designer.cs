namespace Psicomind
{
    partial class FrmClienteConsultar
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
            pngClienteTelefone = new Guna.UI2.WinForms.Guna2TabControl();
            pngTelefoneCliente = new TabPage();
            pngClienteDados = new TabPage();
            guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            pngClienteEndereco = new TabPage();
            pngClienteTelefone.SuspendLayout();
            pngClienteDados.SuspendLayout();
            SuspendLayout();
            // 
            // pngClienteTelefone
            // 
            pngClienteTelefone.Alignment = TabAlignment.Left;
            pngClienteTelefone.Controls.Add(pngClienteDados);
            pngClienteTelefone.Controls.Add(pngTelefoneCliente);
            pngClienteTelefone.Controls.Add(pngClienteEndereco);
            pngClienteTelefone.ItemSize = new Size(180, 40);
            pngClienteTelefone.Location = new Point(52, 31);
            pngClienteTelefone.Name = "pngClienteTelefone";
            pngClienteTelefone.SelectedIndex = 0;
            pngClienteTelefone.Size = new Size(1212, 639);
            pngClienteTelefone.TabButtonHoverState.BorderColor = Color.Empty;
            pngClienteTelefone.TabButtonHoverState.FillColor = Color.FromArgb(40, 52, 70);
            pngClienteTelefone.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F);
            pngClienteTelefone.TabButtonHoverState.ForeColor = Color.White;
            pngClienteTelefone.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            pngClienteTelefone.TabButtonIdleState.BorderColor = Color.Empty;
            pngClienteTelefone.TabButtonIdleState.FillColor = Color.FromArgb(33, 42, 57);
            pngClienteTelefone.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F);
            pngClienteTelefone.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
            pngClienteTelefone.TabButtonIdleState.InnerColor = Color.FromArgb(33, 42, 57);
            pngClienteTelefone.TabButtonSelectedState.BorderColor = Color.Empty;
            pngClienteTelefone.TabButtonSelectedState.FillColor = Color.FromArgb(29, 37, 49);
            pngClienteTelefone.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F);
            pngClienteTelefone.TabButtonSelectedState.ForeColor = Color.White;
            pngClienteTelefone.TabButtonSelectedState.InnerColor = Color.FromArgb(76, 132, 255);
            pngClienteTelefone.TabButtonSize = new Size(180, 40);
            pngClienteTelefone.TabIndex = 47;
            pngClienteTelefone.TabMenuBackColor = Color.FromArgb(33, 42, 57);
            // 
            // pngTelefoneCliente
            // 
            pngTelefoneCliente.Location = new Point(184, 4);
            pngTelefoneCliente.Name = "pngTelefoneCliente";
            pngTelefoneCliente.Padding = new Padding(3);
            pngTelefoneCliente.Size = new Size(1024, 631);
            pngTelefoneCliente.TabIndex = 1;
            pngTelefoneCliente.Text = "Telefone";
            pngTelefoneCliente.UseVisualStyleBackColor = true;
            // 
            // pngClienteDados
            // 
            pngClienteDados.Controls.Add(guna2ContainerControl1);
            pngClienteDados.Location = new Point(184, 4);
            pngClienteDados.Name = "pngClienteDados";
            pngClienteDados.Padding = new Padding(3);
            pngClienteDados.Size = new Size(1024, 631);
            pngClienteDados.TabIndex = 0;
            pngClienteDados.Text = "Dados Pessoais";
            pngClienteDados.UseVisualStyleBackColor = true;
            // 
            // guna2ContainerControl1
            // 
            guna2ContainerControl1.CustomizableEdges = customizableEdges1;
            guna2ContainerControl1.Location = new Point(-2, -1);
            guna2ContainerControl1.Name = "guna2ContainerControl1";
            guna2ContainerControl1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ContainerControl1.Size = new Size(1028, 639);
            guna2ContainerControl1.TabIndex = 0;
            guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // pngClienteEndereco
            // 
            pngClienteEndereco.Location = new Point(184, 4);
            pngClienteEndereco.Name = "pngClienteEndereco";
            pngClienteEndereco.Padding = new Padding(3);
            pngClienteEndereco.Size = new Size(1024, 631);
            pngClienteEndereco.TabIndex = 2;
            pngClienteEndereco.Text = "Endereço";
            pngClienteEndereco.UseVisualStyleBackColor = true;
            // 
            // FrmClienteConsultar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 712);
            Controls.Add(pngClienteTelefone);
            Name = "FrmClienteConsultar";
            Text = "FrmClienteConsultar";
            pngClienteTelefone.ResumeLayout(false);
            pngClienteDados.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl pngClienteTelefone;
        private TabPage pngClienteDados;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private TabPage pngTelefoneCliente;
        private TabPage pngClienteEndereco;
    }
}