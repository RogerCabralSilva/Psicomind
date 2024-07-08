namespace Psicomind
{
    partial class CrtlClienteConsulta
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrtlClienteConsulta));
            pnp = new Panel();
            guna2ContainerControl2 = new Guna.UI2.WinForms.Guna2ContainerControl();
            dgvClientes = new Guna.UI2.WinForms.Guna2DataGridView();
            btnVoltar = new PictureBox();
            clnNome = new DataGridViewTextBoxColumn();
            clnCpf = new DataGridViewTextBoxColumn();
            clnNumero = new DataGridViewTextBoxColumn();
            ClnEmail = new DataGridViewTextBoxColumn();
            clnCidade = new DataGridViewTextBoxColumn();
            clnRua = new DataGridViewTextBoxColumn();
            clnDatadeNascimento = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewTextBoxColumn();
            pnp.SuspendLayout();
            guna2ContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnVoltar).BeginInit();
            SuspendLayout();
            // 
            // pnp
            // 
            pnp.Controls.Add(guna2ContainerControl2);
            pnp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnp.Location = new Point(1, 0);
            pnp.Name = "pnp";
            pnp.Size = new Size(1054, 696);
            pnp.TabIndex = 34;
            // 
            // guna2ContainerControl2
            // 
            guna2ContainerControl2.BorderRadius = 30;
            guna2ContainerControl2.Controls.Add(dgvClientes);
            guna2ContainerControl2.Controls.Add(btnVoltar);
            guna2ContainerControl2.CustomizableEdges = customizableEdges1;
            guna2ContainerControl2.Location = new Point(15, 33);
            guna2ContainerControl2.Name = "guna2ContainerControl2";
            guna2ContainerControl2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ContainerControl2.Size = new Size(1015, 624);
            guna2ContainerControl2.TabIndex = 29;
            guna2ContainerControl2.Text = "guna2ContainerControl2";
            // 
            // dgvClientes
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8F);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.ColumnHeadersHeight = 40;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { clnNome, clnCpf, clnNumero, ClnEmail, clnCidade, clnRua, clnDatadeNascimento, clnAtivo });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvClientes.GridColor = Color.FromArgb(242, 245, 250);
            dgvClientes.Location = new Point(44, 72);
            dgvClientes.Name = "dgvClientes";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowTemplate.Height = 40;
            dgvClientes.Size = new Size(923, 518);
            dgvClientes.TabIndex = 42;
            dgvClientes.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvClientes.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvClientes.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvClientes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvClientes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvClientes.ThemeStyle.BackColor = Color.White;
            dgvClientes.ThemeStyle.GridColor = Color.FromArgb(242, 245, 250);
            dgvClientes.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(242, 245, 250);
            dgvClientes.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvClientes.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 8F);
            dgvClientes.ThemeStyle.HeaderStyle.ForeColor = Color.DimGray;
            dgvClientes.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvClientes.ThemeStyle.HeaderStyle.Height = 40;
            dgvClientes.ThemeStyle.ReadOnly = false;
            dgvClientes.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvClientes.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClientes.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvClientes.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvClientes.ThemeStyle.RowsStyle.Height = 40;
            dgvClientes.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(0, 0, 192);
            dgvClientes.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.White;
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.Location = new Point(15, 18);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(50, 30);
            btnVoltar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnVoltar.TabIndex = 41;
            btnVoltar.TabStop = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // clnNome
            // 
            clnNome.FillWeight = 74.10537F;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            // 
            // clnCpf
            // 
            clnCpf.FillWeight = 74.10537F;
            clnCpf.HeaderText = "CPF";
            clnCpf.Name = "clnCpf";
            // 
            // clnNumero
            // 
            clnNumero.FillWeight = 74.10537F;
            clnNumero.HeaderText = "Número";
            clnNumero.Name = "clnNumero";
            // 
            // ClnEmail
            // 
            ClnEmail.FillWeight = 74.10537F;
            ClnEmail.HeaderText = "Email";
            ClnEmail.Name = "ClnEmail";
            // 
            // clnCidade
            // 
            clnCidade.FillWeight = 74.10537F;
            clnCidade.HeaderText = "Cidade";
            clnCidade.Name = "clnCidade";
            // 
            // clnRua
            // 
            clnRua.FillWeight = 74.10537F;
            clnRua.HeaderText = "Rua";
            clnRua.Name = "clnRua";
            // 
            // clnDatadeNascimento
            // 
            clnDatadeNascimento.FillWeight = 169.923126F;
            clnDatadeNascimento.HeaderText = "Data de Nascimento";
            clnDatadeNascimento.Name = "clnDatadeNascimento";
            // 
            // clnAtivo
            // 
            clnAtivo.FillWeight = 74.10537F;
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            // 
            // CrtlClienteConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnp);
            Name = "CrtlClienteConsulta";
            Size = new Size(1056, 693);
            Load += CrtlClienteConsulta_Load;
            pnp.ResumeLayout(false);
            guna2ContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnVoltar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnp;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl2;
        private PictureBox btnVoltar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvClientes;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnCpf;
        private DataGridViewTextBoxColumn clnNumero;
        private DataGridViewTextBoxColumn ClnEmail;
        private DataGridViewTextBoxColumn clnCidade;
        private DataGridViewTextBoxColumn clnRua;
        private DataGridViewTextBoxColumn clnDatadeNascimento;
        private DataGridViewTextBoxColumn clnAtivo;
    }
}
