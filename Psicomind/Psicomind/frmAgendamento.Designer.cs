namespace Psicomind
{
    partial class frmAgendamento
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            sfCalendar1 = new Syncfusion.WinForms.Input.SfCalendar();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbProfissionais = new Guna.UI2.WinForms.Guna2ComboBox();
            label3 = new Label();
            cmbHorarios = new Guna.UI2.WinForms.Guna2ComboBox();
            btnConsultarProfissional = new Guna.UI2.WinForms.Guna2Button();
            label5 = new Label();
            guna2ContainerControl1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2ContainerControl1
            // 
            guna2ContainerControl1.Anchor = AnchorStyles.None;
            guna2ContainerControl1.BorderRadius = 20;
            guna2ContainerControl1.Controls.Add(sfCalendar1);
            guna2ContainerControl1.Controls.Add(label4);
            guna2ContainerControl1.Controls.Add(label5);
            guna2ContainerControl1.Controls.Add(label2);
            guna2ContainerControl1.Controls.Add(label1);
            guna2ContainerControl1.Controls.Add(cmbProfissionais);
            guna2ContainerControl1.Controls.Add(label3);
            guna2ContainerControl1.Controls.Add(cmbHorarios);
            guna2ContainerControl1.Controls.Add(btnConsultarProfissional);
            guna2ContainerControl1.CustomizableEdges = customizableEdges7;
            guna2ContainerControl1.Location = new Point(46, 41);
            guna2ContainerControl1.Name = "guna2ContainerControl1";
            guna2ContainerControl1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2ContainerControl1.Size = new Size(1124, 582);
            guna2ContainerControl1.TabIndex = 1;
            guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // sfCalendar1
            // 
            sfCalendar1.Anchor = AnchorStyles.None;
            sfCalendar1.CanOverrideStyle = true;
            sfCalendar1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sfCalendar1.ForeColor = SystemColors.ControlText;
            sfCalendar1.ImeMode = ImeMode.NoControl;
            sfCalendar1.Location = new Point(383, 206);
            sfCalendar1.MinimumSize = new Size(196, 196);
            sfCalendar1.Name = "sfCalendar1";
            sfCalendar1.Size = new Size(315, 213);
            sfCalendar1.Style.BorderColor = Color.Transparent;
            sfCalendar1.Style.Cell.CellFont = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sfCalendar1.Style.Header.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sfCalendar1.TabIndex = 49;
            sfCalendar1.Text = "sfCalendar1";
            sfCalendar1.Click += sfCalendar1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(489, 178);
            label4.Name = "label4";
            label4.Size = new Size(107, 16);
            label4.TabIndex = 48;
            label4.Text = "Selecione a data\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(471, 485);
            label2.Name = "label2";
            label2.Size = new Size(123, 16);
            label2.TabIndex = 46;
            label2.Text = "Horários Disponíveis";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(505, 91);
            label1.Name = "label1";
            label1.Size = new Size(71, 16);
            label1.TabIndex = 45;
            label1.Text = "Profissional";
            // 
            // cmbProfissionais
            // 
            cmbProfissionais.BackColor = Color.Transparent;
            cmbProfissionais.BorderRadius = 15;
            cmbProfissionais.CustomizableEdges = customizableEdges1;
            cmbProfissionais.DrawMode = DrawMode.OwnerDrawFixed;
            cmbProfissionais.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProfissionais.FillColor = Color.WhiteSmoke;
            cmbProfissionais.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbProfissionais.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbProfissionais.Font = new Font("Segoe UI", 10F);
            cmbProfissionais.ForeColor = Color.FromArgb(68, 88, 112);
            cmbProfissionais.ItemHeight = 30;
            cmbProfissionais.Location = new Point(374, 114);
            cmbProfissionais.Name = "cmbProfissionais";
            cmbProfissionais.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cmbProfissionais.Size = new Size(333, 36);
            cmbProfissionais.TabIndex = 44;
            cmbProfissionais.SelectedIndexChanged += cmbProfissionais_SelectedIndexChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(358, 38);
            label3.Name = "label3";
            label3.Size = new Size(364, 32);
            label3.TabIndex = 29;
            label3.Text = "Agendamento de Consulta";
            // 
            // cmbHorarios
            // 
            cmbHorarios.BackColor = Color.Transparent;
            cmbHorarios.BorderRadius = 15;
            cmbHorarios.CustomizableEdges = customizableEdges3;
            cmbHorarios.DrawMode = DrawMode.OwnerDrawFixed;
            cmbHorarios.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHorarios.FillColor = Color.WhiteSmoke;
            cmbHorarios.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbHorarios.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbHorarios.Font = new Font("Segoe UI", 10F);
            cmbHorarios.ForeColor = Color.FromArgb(68, 88, 112);
            cmbHorarios.ItemHeight = 30;
            cmbHorarios.Location = new Point(407, 511);
            cmbHorarios.Name = "cmbHorarios";
            cmbHorarios.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cmbHorarios.Size = new Size(251, 36);
            cmbHorarios.TabIndex = 4;
            // 
            // btnConsultarProfissional
            // 
            btnConsultarProfissional.BackColor = Color.Transparent;
            btnConsultarProfissional.BorderRadius = 10;
            btnConsultarProfissional.CustomizableEdges = customizableEdges5;
            btnConsultarProfissional.DisabledState.BorderColor = Color.DarkGray;
            btnConsultarProfissional.DisabledState.CustomBorderColor = Color.DarkGray;
            btnConsultarProfissional.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnConsultarProfissional.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnConsultarProfissional.FillColor = SystemColors.MenuHighlight;
            btnConsultarProfissional.Font = new Font("Segoe UI", 9F);
            btnConsultarProfissional.ForeColor = Color.White;
            btnConsultarProfissional.Location = new Point(476, 435);
            btnConsultarProfissional.Name = "btnConsultarProfissional";
            btnConsultarProfissional.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnConsultarProfissional.Size = new Size(120, 30);
            btnConsultarProfissional.TabIndex = 3;
            btnConsultarProfissional.Text = "consultar";
            btnConsultarProfissional.Click += btnConsultarProfissional_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(338, 22);
            label5.Name = "label5";
            label5.Size = new Size(430, 16);
            label5.TabIndex = 46;
            label5.Text = "Os dias marcados em azul são as datas disponiveis para agendamentos.";
            // 
            // frmAgendamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 650);
            Controls.Add(guna2ContainerControl1);
            Name = "frmAgendamento";
            Text = "frmAgendamento";
            Load += frmAgendamento_Load;
            guna2ContainerControl1.ResumeLayout(false);
            guna2ContainerControl1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private Guna.UI2.WinForms.Guna2Button btnConsultarProfissional;
        private Guna.UI2.WinForms.Guna2ComboBox cmbHorarios;
        private Label label3;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbProfissionais;
        private Label label2;
        private Label label4;
        private ToolTip toolTip1;
        private Syncfusion.WinForms.Input.SfCalendar sfCalendar1;
        private Label label5;
    }
}