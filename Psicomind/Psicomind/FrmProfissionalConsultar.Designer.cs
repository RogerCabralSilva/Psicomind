namespace Psicomind
{
    partial class FrmProfissionalConsultar
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfissionalConsultar));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            guna2ContainerControl2 = new Guna.UI2.WinForms.Guna2ContainerControl();
            label1 = new Label();
            txtBuscarProfissional = new Guna.UI2.WinForms.Guna2TextBox();
            guna2DataGridView2 = new Guna.UI2.WinForms.Guna2DataGridView();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            btnVoltar = new PictureBox();
            dgvProfissional = new Guna.UI2.WinForms.Guna2DataGridView();
            clnNomeProfissional = new DataGridViewTextBoxColumn();
            clnEmailProfissional = new DataGridViewTextBoxColumn();
            clnCpfProfissional = new DataGridViewTextBoxColumn();
            clnEspecializacao = new DataGridViewTextBoxColumn();
            clnDataNascProfissional = new DataGridViewTextBoxColumn();
            clnGeneroProfissional = new DataGridViewTextBoxColumn();
            clnAtivoProfissional = new DataGridViewCheckBoxColumn();
            guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            guna2ContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnVoltar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProfissional).BeginInit();
            guna2TabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2ContainerControl2
            // 
            guna2ContainerControl2.Anchor = AnchorStyles.None;
            guna2ContainerControl2.BorderRadius = 30;
            guna2ContainerControl2.Controls.Add(label1);
            guna2ContainerControl2.Controls.Add(txtBuscarProfissional);
            guna2ContainerControl2.Controls.Add(guna2DataGridView2);
            guna2ContainerControl2.Controls.Add(btnVoltar);
            guna2ContainerControl2.Controls.Add(dgvProfissional);
            guna2ContainerControl2.CustomizableEdges = customizableEdges3;
            guna2ContainerControl2.Location = new Point(32, 24);
            guna2ContainerControl2.Name = "guna2ContainerControl2";
            guna2ContainerControl2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ContainerControl2.Size = new Size(1012, 624);
            guna2ContainerControl2.TabIndex = 47;
            guna2ContainerControl2.Text = "guna2ContainerControl2";
            guna2ContainerControl2.Click += guna2ContainerControl2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(49, 105);
            label1.Name = "label1";
            label1.Size = new Size(174, 16);
            label1.TabIndex = 47;
            label1.Text = "Digite o nome para consulta:";
            // 
            // txtBuscarProfissional
            // 
            txtBuscarProfissional.BackColor = SystemColors.ButtonHighlight;
            txtBuscarProfissional.BorderColor = Color.White;
            txtBuscarProfissional.BorderRadius = 10;
            txtBuscarProfissional.CustomizableEdges = customizableEdges1;
            txtBuscarProfissional.DefaultText = "";
            txtBuscarProfissional.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBuscarProfissional.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBuscarProfissional.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBuscarProfissional.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBuscarProfissional.FillColor = Color.FromArgb(224, 224, 224);
            txtBuscarProfissional.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuscarProfissional.Font = new Font("Segoe UI", 9F);
            txtBuscarProfissional.ForeColor = Color.Black;
            txtBuscarProfissional.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuscarProfissional.IconLeftSize = new Size(15, 15);
            txtBuscarProfissional.IconRight = (Image)resources.GetObject("txtBuscarProfissional.IconRight");
            txtBuscarProfissional.IconRightSize = new Size(15, 15);
            txtBuscarProfissional.Location = new Point(49, 128);
            txtBuscarProfissional.Name = "txtBuscarProfissional";
            txtBuscarProfissional.PasswordChar = '\0';
            txtBuscarProfissional.PlaceholderForeColor = Color.Silver;
            txtBuscarProfissional.PlaceholderText = "";
            txtBuscarProfissional.SelectedText = "";
            txtBuscarProfissional.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtBuscarProfissional.Size = new Size(601, 29);
            txtBuscarProfissional.TabIndex = 46;
            // 
            // guna2DataGridView2
            // 
            guna2DataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 128, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            guna2DataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView2.Anchor = AnchorStyles.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0, true);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView2.ColumnHeadersHeight = 50;
            guna2DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14, dataGridViewTextBoxColumn15, dataGridViewTextBoxColumn16 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 128, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView2.GridColor = Color.FromArgb(242, 245, 250);
            guna2DataGridView2.Location = new Point(903, 902);
            guna2DataGridView2.Name = "guna2DataGridView2";
            guna2DataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            guna2DataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            guna2DataGridView2.RowHeadersVisible = false;
            guna2DataGridView2.RowTemplate.Height = 30;
            guna2DataGridView2.Size = new Size(836, 186);
            guna2DataGridView2.TabIndex = 44;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView2.ThemeStyle.BackColor = Color.White;
            guna2DataGridView2.ThemeStyle.GridColor = Color.FromArgb(242, 245, 250);
            guna2DataGridView2.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(242, 245, 250);
            guna2DataGridView2.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView2.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView2.ThemeStyle.HeaderStyle.ForeColor = Color.DimGray;
            guna2DataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView2.ThemeStyle.HeaderStyle.Height = 50;
            guna2DataGridView2.ThemeStyle.ReadOnly = false;
            guna2DataGridView2.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView2.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView2.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 8F);
            guna2DataGridView2.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView2.ThemeStyle.RowsStyle.Height = 30;
            guna2DataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(0, 0, 192);
            guna2DataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.FillWeight = 74.10537F;
            dataGridViewTextBoxColumn9.HeaderText = "Nome";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.FillWeight = 74.10537F;
            dataGridViewTextBoxColumn10.HeaderText = "CPF";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.FillWeight = 74.10537F;
            dataGridViewTextBoxColumn11.HeaderText = "Número";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.FillWeight = 74.10537F;
            dataGridViewTextBoxColumn12.HeaderText = "Email";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.FillWeight = 74.10537F;
            dataGridViewTextBoxColumn13.HeaderText = "Cidade";
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.FillWeight = 74.10537F;
            dataGridViewTextBoxColumn14.HeaderText = "Rua";
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.FillWeight = 169.923126F;
            dataGridViewTextBoxColumn15.HeaderText = "Data de Nascimento";
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.FillWeight = 74.10537F;
            dataGridViewTextBoxColumn16.HeaderText = "Ativo";
            dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.None;
            btnVoltar.BackColor = Color.White;
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.Location = new Point(20, 6);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(50, 30);
            btnVoltar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnVoltar.TabIndex = 41;
            btnVoltar.TabStop = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // dgvProfissional
            // 
            dgvProfissional.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 128, 255);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dgvProfissional.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvProfissional.Anchor = AnchorStyles.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle6.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0, true);
            dataGridViewCellStyle6.ForeColor = Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvProfissional.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvProfissional.ColumnHeadersHeight = 50;
            dgvProfissional.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvProfissional.Columns.AddRange(new DataGridViewColumn[] { clnNomeProfissional, clnEmailProfissional, clnCpfProfissional, clnEspecializacao, clnDataNascProfissional, clnGeneroProfissional, clnAtivoProfissional });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(0, 128, 255);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvProfissional.DefaultCellStyle = dataGridViewCellStyle7;
            dgvProfissional.GridColor = Color.FromArgb(242, 245, 250);
            dgvProfissional.Location = new Point(41, 147);
            dgvProfissional.Name = "dgvProfissional";
            dgvProfissional.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.White;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvProfissional.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvProfissional.RowHeadersVisible = false;
            dgvProfissional.RowTemplate.Height = 30;
            dgvProfissional.Size = new Size(926, 386);
            dgvProfissional.TabIndex = 42;
            dgvProfissional.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvProfissional.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvProfissional.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvProfissional.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvProfissional.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvProfissional.ThemeStyle.BackColor = Color.White;
            dgvProfissional.ThemeStyle.GridColor = Color.FromArgb(242, 245, 250);
            dgvProfissional.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(242, 245, 250);
            dgvProfissional.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProfissional.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 8F);
            dgvProfissional.ThemeStyle.HeaderStyle.ForeColor = Color.DimGray;
            dgvProfissional.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvProfissional.ThemeStyle.HeaderStyle.Height = 50;
            dgvProfissional.ThemeStyle.ReadOnly = false;
            dgvProfissional.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvProfissional.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProfissional.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 8F);
            dgvProfissional.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvProfissional.ThemeStyle.RowsStyle.Height = 30;
            dgvProfissional.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(0, 0, 192);
            dgvProfissional.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // clnNomeProfissional
            // 
            clnNomeProfissional.FillWeight = 188.281708F;
            clnNomeProfissional.HeaderText = "Nome";
            clnNomeProfissional.Name = "clnNomeProfissional";
            clnNomeProfissional.ReadOnly = true;
            // 
            // clnEmailProfissional
            // 
            clnEmailProfissional.FillWeight = 188.281708F;
            clnEmailProfissional.HeaderText = "Email";
            clnEmailProfissional.Name = "clnEmailProfissional";
            clnEmailProfissional.ReadOnly = true;
            // 
            // clnCpfProfissional
            // 
            clnCpfProfissional.FillWeight = 188.281708F;
            clnCpfProfissional.HeaderText = "CPF";
            clnCpfProfissional.Name = "clnCpfProfissional";
            clnCpfProfissional.ReadOnly = true;
            // 
            // clnEspecializacao
            // 
            clnEspecializacao.FillWeight = 188.281708F;
            clnEspecializacao.HeaderText = "Especialização";
            clnEspecializacao.Name = "clnEspecializacao";
            clnEspecializacao.ReadOnly = true;
            // 
            // clnDataNascProfissional
            // 
            clnDataNascProfissional.FillWeight = 200.4F;
            clnDataNascProfissional.HeaderText = "Data de Nascimento";
            clnDataNascProfissional.Name = "clnDataNascProfissional";
            clnDataNascProfissional.ReadOnly = true;
            // 
            // clnGeneroProfissional
            // 
            clnGeneroProfissional.HeaderText = "Genero";
            clnGeneroProfissional.Name = "clnGeneroProfissional";
            clnGeneroProfissional.ReadOnly = true;
            // 
            // clnAtivoProfissional
            // 
            clnAtivoProfissional.FillWeight = 110.2F;
            clnAtivoProfissional.HeaderText = "Ativo";
            clnAtivoProfissional.Name = "clnAtivoProfissional";
            clnAtivoProfissional.ReadOnly = true;
            // 
            // guna2TabControl1
            // 
            guna2TabControl1.Alignment = TabAlignment.Left;
            guna2TabControl1.Controls.Add(tabPage1);
            guna2TabControl1.Controls.Add(tabPage2);
            guna2TabControl1.ItemSize = new Size(180, 40);
            guna2TabControl1.Location = new Point(55, 24);
            guna2TabControl1.Name = "guna2TabControl1";
            guna2TabControl1.SelectedIndex = 0;
            guna2TabControl1.Size = new Size(1267, 676);
            guna2TabControl1.TabButtonHoverState.BorderColor = Color.Empty;
            guna2TabControl1.TabButtonHoverState.FillColor = Color.FromArgb(40, 52, 70);
            guna2TabControl1.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F);
            guna2TabControl1.TabButtonHoverState.ForeColor = Color.White;
            guna2TabControl1.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            guna2TabControl1.TabButtonIdleState.BorderColor = Color.Empty;
            guna2TabControl1.TabButtonIdleState.FillColor = Color.FromArgb(33, 42, 57);
            guna2TabControl1.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F);
            guna2TabControl1.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
            guna2TabControl1.TabButtonIdleState.InnerColor = Color.FromArgb(33, 42, 57);
            guna2TabControl1.TabButtonSelectedState.BorderColor = Color.Empty;
            guna2TabControl1.TabButtonSelectedState.FillColor = Color.FromArgb(29, 37, 49);
            guna2TabControl1.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F);
            guna2TabControl1.TabButtonSelectedState.ForeColor = Color.White;
            guna2TabControl1.TabButtonSelectedState.InnerColor = Color.FromArgb(76, 132, 255);
            guna2TabControl1.TabButtonSize = new Size(180, 40);
            guna2TabControl1.TabIndex = 48;
            guna2TabControl1.TabMenuBackColor = Color.FromArgb(33, 42, 57);
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(guna2ContainerControl2);
            tabPage1.Location = new Point(184, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1079, 668);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(184, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(913, 668);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // FrmProfissionalConsultar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 712);
            Controls.Add(guna2TabControl1);
            Name = "FrmProfissionalConsultar";
            Text = "FrmProfissionalConsultar";
            guna2ContainerControl2.ResumeLayout(false);
            guna2ContainerControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnVoltar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProfissional).EndInit();
            guna2TabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarProfissional;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private PictureBox btnVoltar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProfissional;
        private DataGridViewTextBoxColumn clnNomeProfissional;
        private DataGridViewTextBoxColumn clnEmailProfissional;
        private DataGridViewTextBoxColumn clnCpfProfissional;
        private DataGridViewTextBoxColumn clnEspecializacao;
        private DataGridViewTextBoxColumn clnDataNascProfissional;
        private DataGridViewTextBoxColumn clnGeneroProfissional;
        private DataGridViewCheckBoxColumn clnAtivoProfissional;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}