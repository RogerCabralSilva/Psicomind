namespace Psicomind
{
    partial class FrmAgendamentoConsulta
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgendamentoConsulta));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            btn_consultar_dados_pessoais_cliente = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            txtNomeConsulta = new Guna.UI2.WinForms.Guna2TextBox();
            btnVoltar = new PictureBox();
            dgvClientesDados = new Guna.UI2.WinForms.Guna2DataGridView();
            clnClienteId = new DataGridViewTextBoxColumn();
            clnNomeCliente = new DataGridViewTextBoxColumn();
            clnEmailCliente = new DataGridViewTextBoxColumn();
            clnCpfCliente = new DataGridViewTextBoxColumn();
            clnDataCadCliente = new DataGridViewTextBoxColumn();
            clnDataNascCliente = new DataGridViewTextBoxColumn();
            clnGeneroCliente = new DataGridViewTextBoxColumn();
            clnAtivoCliente = new DataGridViewCheckBoxColumn();
            label3 = new Label();
            txtEmailConsulta = new Guna.UI2.WinForms.Guna2TextBox();
            dtpDataConsulta = new Guna.UI2.WinForms.Guna2DateTimePicker();
            guna2ContainerControl3 = new Guna.UI2.WinForms.Guna2ContainerControl();
            mskHorarioInicio = new MaskedTextBox();
            guna2ContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnVoltar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientesDados).BeginInit();
            guna2ContainerControl3.SuspendLayout();
            SuspendLayout();
            // 
            // guna2ContainerControl1
            // 
            guna2ContainerControl1.BorderRadius = 15;
            guna2ContainerControl1.Controls.Add(guna2ContainerControl3);
            guna2ContainerControl1.Controls.Add(dtpDataConsulta);
            guna2ContainerControl1.Controls.Add(txtEmailConsulta);
            guna2ContainerControl1.Controls.Add(label3);
            guna2ContainerControl1.Controls.Add(btn_consultar_dados_pessoais_cliente);
            guna2ContainerControl1.Controls.Add(label1);
            guna2ContainerControl1.Controls.Add(txtNomeConsulta);
            guna2ContainerControl1.Controls.Add(btnVoltar);
            guna2ContainerControl1.Controls.Add(dgvClientesDados);
            guna2ContainerControl1.CustomizableEdges = customizableEdges11;
            guna2ContainerControl1.Location = new Point(64, 36);
            guna2ContainerControl1.Name = "guna2ContainerControl1";
            guna2ContainerControl1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2ContainerControl1.Size = new Size(1228, 737);
            guna2ContainerControl1.TabIndex = 1;
            guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // btn_consultar_dados_pessoais_cliente
            // 
            btn_consultar_dados_pessoais_cliente.BackColor = Color.White;
            btn_consultar_dados_pessoais_cliente.BorderRadius = 10;
            btn_consultar_dados_pessoais_cliente.CustomizableEdges = customizableEdges7;
            btn_consultar_dados_pessoais_cliente.DisabledState.BorderColor = Color.DarkGray;
            btn_consultar_dados_pessoais_cliente.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_consultar_dados_pessoais_cliente.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_consultar_dados_pessoais_cliente.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_consultar_dados_pessoais_cliente.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_consultar_dados_pessoais_cliente.ForeColor = Color.White;
            btn_consultar_dados_pessoais_cliente.Location = new Point(1007, 160);
            btn_consultar_dados_pessoais_cliente.Name = "btn_consultar_dados_pessoais_cliente";
            btn_consultar_dados_pessoais_cliente.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btn_consultar_dados_pessoais_cliente.Size = new Size(122, 29);
            btn_consultar_dados_pessoais_cliente.TabIndex = 56;
            btn_consultar_dados_pessoais_cliente.Text = "Consultar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(74, 136);
            label1.Name = "label1";
            label1.Size = new Size(193, 16);
            label1.TabIndex = 51;
            label1.Text = "Digite os campos para consulta:";
            // 
            // txtNomeConsulta
            // 
            txtNomeConsulta.BackColor = SystemColors.ButtonHighlight;
            txtNomeConsulta.BorderColor = Color.White;
            txtNomeConsulta.BorderRadius = 10;
            txtNomeConsulta.CustomizableEdges = customizableEdges9;
            txtNomeConsulta.DefaultText = "";
            txtNomeConsulta.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNomeConsulta.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNomeConsulta.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNomeConsulta.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNomeConsulta.FillColor = Color.FromArgb(224, 224, 224);
            txtNomeConsulta.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNomeConsulta.Font = new Font("Segoe UI", 9F);
            txtNomeConsulta.ForeColor = Color.Black;
            txtNomeConsulta.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNomeConsulta.IconLeftSize = new Size(15, 15);
            txtNomeConsulta.IconRightSize = new Size(15, 15);
            txtNomeConsulta.Location = new Point(73, 159);
            txtNomeConsulta.Name = "txtNomeConsulta";
            txtNomeConsulta.PasswordChar = '\0';
            txtNomeConsulta.PlaceholderForeColor = Color.Silver;
            txtNomeConsulta.PlaceholderText = "Nome";
            txtNomeConsulta.SelectedText = "";
            txtNomeConsulta.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtNomeConsulta.Size = new Size(230, 29);
            txtNomeConsulta.TabIndex = 50;
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.None;
            btnVoltar.BackColor = Color.White;
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.Location = new Point(40, 51);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(50, 30);
            btnVoltar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnVoltar.TabIndex = 48;
            btnVoltar.TabStop = false;
            // 
            // dgvClientesDados
            // 
            dgvClientesDados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 128, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvClientesDados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientesDados.Anchor = AnchorStyles.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0, true);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvClientesDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvClientesDados.ColumnHeadersHeight = 50;
            dgvClientesDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvClientesDados.Columns.AddRange(new DataGridViewColumn[] { clnClienteId, clnNomeCliente, clnEmailCliente, clnCpfCliente, clnDataCadCliente, clnDataNascCliente, clnGeneroCliente, clnAtivoCliente });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 128, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvClientesDados.DefaultCellStyle = dataGridViewCellStyle3;
            dgvClientesDados.GridColor = Color.FromArgb(242, 245, 250);
            dgvClientesDados.Location = new Point(73, 215);
            dgvClientesDados.Name = "dgvClientesDados";
            dgvClientesDados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvClientesDados.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvClientesDados.RowHeadersVisible = false;
            dgvClientesDados.RowTemplate.Height = 30;
            dgvClientesDados.Size = new Size(1056, 482);
            dgvClientesDados.TabIndex = 49;
            dgvClientesDados.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvClientesDados.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvClientesDados.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvClientesDados.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvClientesDados.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvClientesDados.ThemeStyle.BackColor = Color.White;
            dgvClientesDados.ThemeStyle.GridColor = Color.FromArgb(242, 245, 250);
            dgvClientesDados.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(242, 245, 250);
            dgvClientesDados.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvClientesDados.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 8F);
            dgvClientesDados.ThemeStyle.HeaderStyle.ForeColor = Color.DimGray;
            dgvClientesDados.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvClientesDados.ThemeStyle.HeaderStyle.Height = 50;
            dgvClientesDados.ThemeStyle.ReadOnly = false;
            dgvClientesDados.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvClientesDados.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClientesDados.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 8F);
            dgvClientesDados.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvClientesDados.ThemeStyle.RowsStyle.Height = 30;
            dgvClientesDados.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(0, 0, 192);
            dgvClientesDados.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // clnClienteId
            // 
            clnClienteId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            clnClienteId.FillWeight = 50F;
            clnClienteId.Frozen = true;
            clnClienteId.HeaderText = "ID";
            clnClienteId.Name = "clnClienteId";
            clnClienteId.ReadOnly = true;
            // 
            // clnNomeCliente
            // 
            clnNomeCliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            clnNomeCliente.Frozen = true;
            clnNomeCliente.HeaderText = "Nome";
            clnNomeCliente.Name = "clnNomeCliente";
            clnNomeCliente.ReadOnly = true;
            clnNomeCliente.Width = 200;
            // 
            // clnEmailCliente
            // 
            clnEmailCliente.FillWeight = 120F;
            clnEmailCliente.HeaderText = "Email";
            clnEmailCliente.Name = "clnEmailCliente";
            clnEmailCliente.ReadOnly = true;
            // 
            // clnCpfCliente
            // 
            clnCpfCliente.FillWeight = 90F;
            clnCpfCliente.HeaderText = "CPF";
            clnCpfCliente.Name = "clnCpfCliente";
            clnCpfCliente.ReadOnly = true;
            // 
            // clnDataCadCliente
            // 
            clnDataCadCliente.HeaderText = "Cadastro";
            clnDataCadCliente.Name = "clnDataCadCliente";
            clnDataCadCliente.ReadOnly = true;
            // 
            // clnDataNascCliente
            // 
            clnDataNascCliente.FillWeight = 120F;
            clnDataNascCliente.HeaderText = "Data de Nascimento";
            clnDataNascCliente.Name = "clnDataNascCliente";
            clnDataNascCliente.ReadOnly = true;
            // 
            // clnGeneroCliente
            // 
            clnGeneroCliente.FillWeight = 80F;
            clnGeneroCliente.HeaderText = "Genero";
            clnGeneroCliente.Name = "clnGeneroCliente";
            clnGeneroCliente.ReadOnly = true;
            // 
            // clnAtivoCliente
            // 
            clnAtivoCliente.FillWeight = 50F;
            clnAtivoCliente.HeaderText = "Ativo";
            clnAtivoCliente.Name = "clnAtivoCliente";
            clnAtivoCliente.ReadOnly = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(455, 64);
            label3.Name = "label3";
            label3.Size = new Size(324, 32);
            label3.TabIndex = 57;
            label3.Text = "Agendamento Consulta";
            // 
            // txtEmailConsulta
            // 
            txtEmailConsulta.BackColor = SystemColors.ButtonHighlight;
            txtEmailConsulta.BorderColor = Color.White;
            txtEmailConsulta.BorderRadius = 10;
            txtEmailConsulta.CustomizableEdges = customizableEdges5;
            txtEmailConsulta.DefaultText = "";
            txtEmailConsulta.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmailConsulta.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmailConsulta.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmailConsulta.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmailConsulta.FillColor = Color.FromArgb(224, 224, 224);
            txtEmailConsulta.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmailConsulta.Font = new Font("Segoe UI", 9F);
            txtEmailConsulta.ForeColor = Color.Black;
            txtEmailConsulta.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmailConsulta.IconLeftSize = new Size(15, 15);
            txtEmailConsulta.IconRightSize = new Size(15, 15);
            txtEmailConsulta.Location = new Point(320, 159);
            txtEmailConsulta.Name = "txtEmailConsulta";
            txtEmailConsulta.PasswordChar = '\0';
            txtEmailConsulta.PlaceholderForeColor = Color.Silver;
            txtEmailConsulta.PlaceholderText = "Email";
            txtEmailConsulta.SelectedText = "";
            txtEmailConsulta.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtEmailConsulta.Size = new Size(260, 29);
            txtEmailConsulta.TabIndex = 58;
            // 
            // dtpDataConsulta
            // 
            dtpDataConsulta.BackColor = Color.Transparent;
            dtpDataConsulta.BorderRadius = 10;
            dtpDataConsulta.Checked = true;
            dtpDataConsulta.CustomizableEdges = customizableEdges3;
            dtpDataConsulta.FillColor = Color.White;
            dtpDataConsulta.Font = new Font("Segoe UI", 9F);
            dtpDataConsulta.Format = DateTimePickerFormat.Short;
            dtpDataConsulta.Location = new Point(603, 159);
            dtpDataConsulta.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpDataConsulta.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpDataConsulta.Name = "dtpDataConsulta";
            dtpDataConsulta.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtpDataConsulta.Size = new Size(187, 30);
            dtpDataConsulta.TabIndex = 60;
            dtpDataConsulta.Value = new DateTime(2024, 8, 19, 11, 43, 41, 124);
            // 
            // guna2ContainerControl3
            // 
            guna2ContainerControl3.BackColor = Color.Transparent;
            guna2ContainerControl3.BorderColor = Color.FromArgb(213, 218, 223);
            guna2ContainerControl3.BorderRadius = 10;
            guna2ContainerControl3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            guna2ContainerControl3.BorderThickness = 1;
            guna2ContainerControl3.Controls.Add(mskHorarioInicio);
            guna2ContainerControl3.CustomizableEdges = customizableEdges1;
            guna2ContainerControl3.FillColor = Color.FromArgb(224, 224, 224);
            guna2ContainerControl3.ForeColor = Color.FromArgb(125, 137, 149);
            guna2ContainerControl3.Location = new Point(817, 159);
            guna2ContainerControl3.Name = "guna2ContainerControl3";
            guna2ContainerControl3.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ContainerControl3.Size = new Size(157, 30);
            guna2ContainerControl3.TabIndex = 61;
            guna2ContainerControl3.Text = "guna2ContainerControl3";
            // 
            // mskHorarioInicio
            // 
            mskHorarioInicio.BackColor = Color.FromArgb(224, 224, 224);
            mskHorarioInicio.BorderStyle = BorderStyle.None;
            mskHorarioInicio.Location = new Point(12, 7);
            mskHorarioInicio.Mask = "90:00";
            mskHorarioInicio.Name = "mskHorarioInicio";
            mskHorarioInicio.Size = new Size(100, 16);
            mskHorarioInicio.TabIndex = 56;
            mskHorarioInicio.ValidatingType = typeof(DateTime);
            // 
            // FrmAgendamentoConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 815);
            Controls.Add(guna2ContainerControl1);
            Name = "FrmAgendamentoConsulta";
            Text = "FrmAgendamentoConsulta";
            guna2ContainerControl1.ResumeLayout(false);
            guna2ContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnVoltar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientesDados).EndInit();
            guna2ContainerControl3.ResumeLayout(false);
            guna2ContainerControl3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private Guna.UI2.WinForms.Guna2Button btn_consultar_dados_pessoais_cliente;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtNomeConsulta;
        private PictureBox btnVoltar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvClientesDados;
        private DataGridViewTextBoxColumn clnClienteId;
        private DataGridViewTextBoxColumn clnNomeCliente;
        private DataGridViewTextBoxColumn clnEmailCliente;
        private DataGridViewTextBoxColumn clnCpfCliente;
        private DataGridViewTextBoxColumn clnDataCadCliente;
        private DataGridViewTextBoxColumn clnDataNascCliente;
        private DataGridViewTextBoxColumn clnGeneroCliente;
        private DataGridViewCheckBoxColumn clnAtivoCliente;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtEmailConsulta;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDataConsulta;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl3;
        private MaskedTextBox mskHorarioInicio;
    }
}