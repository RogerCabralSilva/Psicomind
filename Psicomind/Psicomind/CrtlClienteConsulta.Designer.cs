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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrtlClienteConsulta));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnp = new Panel();
            guna2ContainerControl2 = new Guna.UI2.WinForms.Guna2ContainerControl();
            btnVoltar = new PictureBox();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            Column8 = new DataGridViewTextBoxColumn();
            clnÍcone = new DataGridViewImageColumn();
            clnId = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            pnp.SuspendLayout();
            guna2ContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnVoltar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnp
            // 
            pnp.Controls.Add(guna2ContainerControl2);
            pnp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnp.Location = new Point(1, -2);
            pnp.Name = "pnp";
            pnp.Size = new Size(1054, 696);
            pnp.TabIndex = 34;
            pnp.Paint += pnp_Paint;
            // 
            // guna2ContainerControl2
            // 
            guna2ContainerControl2.BorderRadius = 30;
            guna2ContainerControl2.Controls.Add(btnVoltar);
            guna2ContainerControl2.Controls.Add(guna2DataGridView1);
            guna2ContainerControl2.CustomizableEdges = customizableEdges1;
            guna2ContainerControl2.Location = new Point(15, 33);
            guna2ContainerControl2.Name = "guna2ContainerControl2";
            guna2ContainerControl2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ContainerControl2.Size = new Size(1015, 624);
            guna2ContainerControl2.TabIndex = 29;
            guna2ContainerControl2.Text = "guna2ContainerControl2";
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
            // 
            // guna2DataGridView1
            // 
            guna2DataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Century", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            guna2DataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 40;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column8, clnÍcone, clnId, Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(41, 122);
            guna2DataGridView1.Name = "guna2DataGridView1";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowTemplate.Height = 50;
            guna2DataGridView1.Size = new Size(930, 419);
            guna2DataGridView1.TabIndex = 0;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = new Font("Century", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.WhiteSmoke;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 40;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 50;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = SystemColors.Highlight;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // Column8
            // 
            Column8.Frozen = true;
            Column8.HeaderText = "";
            Column8.Name = "Column8";
            // 
            // clnÍcone
            // 
            clnÍcone.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            clnÍcone.Frozen = true;
            clnÍcone.HeaderText = "";
            clnÍcone.Name = "clnÍcone";
            clnÍcone.ReadOnly = true;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "Nome";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "CPF";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Número";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Email";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Cidade";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Rua";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Data de Nascimento";
            Column6.Name = "Column6";
            Column6.Width = 170;
            // 
            // Column7
            // 
            Column7.HeaderText = "Ativo";
            Column7.Name = "Column7";
            // 
            // CrtlClienteConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnp);
            Name = "CrtlClienteConsulta";
            Size = new Size(1056, 693);
            pnp.ResumeLayout(false);
            guna2ContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnVoltar).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnp;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl2;
        private PictureBox btnVoltar;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewImageColumn clnÍcone;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}
