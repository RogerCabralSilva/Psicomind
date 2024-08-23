namespace Psicomind
{
    partial class FrmShowEscala
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShowEscala));
            guna2ContainerControl2 = new Guna.UI2.WinForms.Guna2ContainerControl();
            lblProfissional = new Label();
            dgvEscala = new Guna.UI2.WinForms.Guna2DataGridView();
            clnData = new DataGridViewTextBoxColumn();
            clnHorario = new DataGridViewTextBoxColumn();
            clnExcluir = new DataGridViewButtonColumn();
            label1 = new Label();
            btnVoltar = new PictureBox();
            label3 = new Label();
            guna2ContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEscala).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnVoltar).BeginInit();
            SuspendLayout();
            // 
            // guna2ContainerControl2
            // 
            guna2ContainerControl2.Anchor = AnchorStyles.None;
            guna2ContainerControl2.BackColor = Color.Transparent;
            guna2ContainerControl2.BorderRadius = 30;
            guna2ContainerControl2.Controls.Add(lblProfissional);
            guna2ContainerControl2.Controls.Add(dgvEscala);
            guna2ContainerControl2.Controls.Add(label1);
            guna2ContainerControl2.Controls.Add(btnVoltar);
            guna2ContainerControl2.Controls.Add(label3);
            guna2ContainerControl2.CustomizableEdges = customizableEdges1;
            guna2ContainerControl2.Location = new Point(145, 16);
            guna2ContainerControl2.Name = "guna2ContainerControl2";
            guna2ContainerControl2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ContainerControl2.Size = new Size(748, 624);
            guna2ContainerControl2.TabIndex = 31;
            guna2ContainerControl2.Text = "guna2ContainerControl2";
            // 
            // lblProfissional
            // 
            lblProfissional.AutoSize = true;
            lblProfissional.BackColor = Color.White;
            lblProfissional.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProfissional.ForeColor = Color.Black;
            lblProfissional.Location = new Point(293, 153);
            lblProfissional.Name = "lblProfissional";
            lblProfissional.Size = new Size(169, 32);
            lblProfissional.TabIndex = 45;
            lblProfissional.Text = "Dr. Douglas";
            // 
            // dgvEscala
            // 
            dgvEscala.AllowUserToAddRows = false;
            dgvEscala.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvEscala.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(34, 145, 255);
            dataGridViewCellStyle2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(34, 145, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEscala.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvEscala.ColumnHeadersHeight = 34;
            dgvEscala.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvEscala.Columns.AddRange(new DataGridViewColumn[] { clnData, clnHorario, clnExcluir });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvEscala.DefaultCellStyle = dataGridViewCellStyle4;
            dgvEscala.GridColor = Color.FromArgb(231, 229, 255);
            dgvEscala.Location = new Point(139, 215);
            dgvEscala.Name = "dgvEscala";
            dgvEscala.ReadOnly = true;
            dgvEscala.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvEscala.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvEscala.RowHeadersVisible = false;
            dgvEscala.RowTemplate.Height = 29;
            dgvEscala.Size = new Size(498, 346);
            dgvEscala.TabIndex = 44;
            dgvEscala.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvEscala.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F);
            dgvEscala.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            dgvEscala.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvEscala.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvEscala.ThemeStyle.BackColor = Color.White;
            dgvEscala.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvEscala.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(34, 145, 255);
            dgvEscala.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvEscala.ThemeStyle.HeaderStyle.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvEscala.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvEscala.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvEscala.ThemeStyle.HeaderStyle.Height = 34;
            dgvEscala.ThemeStyle.ReadOnly = true;
            dgvEscala.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvEscala.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEscala.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvEscala.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvEscala.ThemeStyle.RowsStyle.Height = 29;
            dgvEscala.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvEscala.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvEscala.CellContentClick += dgvEscala_CellContentClick;
            // 
            // clnData
            // 
            clnData.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            clnData.Frozen = true;
            clnData.HeaderText = "Data";
            clnData.Name = "clnData";
            clnData.ReadOnly = true;
            clnData.Width = 195;
            // 
            // clnHorario
            // 
            clnHorario.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            clnHorario.Frozen = true;
            clnHorario.HeaderText = "Horário";
            clnHorario.Name = "clnHorario";
            clnHorario.ReadOnly = true;
            clnHorario.Width = 194;
            // 
            // clnExcluir
            // 
            clnExcluir.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            clnExcluir.DefaultCellStyle = dataGridViewCellStyle3;
            clnExcluir.Frozen = true;
            clnExcluir.HeaderText = "";
            clnExcluir.Name = "clnExcluir";
            clnExcluir.ReadOnly = true;
            clnExcluir.Text = "Excluir";
            clnExcluir.ToolTipText = "sla";
            clnExcluir.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(338, 137);
            label1.Name = "label1";
            label1.Size = new Size(71, 16);
            label1.TabIndex = 43;
            label1.Text = "Profissional";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.White;
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.Location = new Point(22, 30);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(50, 30);
            btnVoltar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnVoltar.TabIndex = 41;
            btnVoltar.TabStop = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(306, 91);
            label3.Name = "label3";
            label3.Size = new Size(152, 22);
            label3.TabIndex = 28;
            label3.Text = "Escala Inserida";
            // 
            // FrmShowEscala
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 657);
            Controls.Add(guna2ContainerControl2);
            Name = "FrmShowEscala";
            Text = "FrmShowEscala";
            Load += FrmShowEscala_Load;
            guna2ContainerControl2.ResumeLayout(false);
            guna2ContainerControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEscala).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnVoltar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl2;
        private Label label1;
        private PictureBox btnVoltar;
        private Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvEscala;
        private Label lblProfissional;
        private DataGridViewTextBoxColumn clnData;
        private DataGridViewTextBoxColumn clnHorario;
        private DataGridViewButtonColumn clnExcluir;
    }
}