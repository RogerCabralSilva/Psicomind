namespace Psicomind
{
    partial class CtrlPrincipal
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
            components = new System.ComponentModel.Container();
            lblRelogio = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lblSemana = new Label();
            SuspendLayout();
            // 
            // lblRelogio
            // 
            lblRelogio.AutoSize = true;
            lblRelogio.Font = new Font("Tw Cen MT", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRelogio.ForeColor = Color.RoyalBlue;
            lblRelogio.Location = new Point(28, 99);
            lblRelogio.Name = "lblRelogio";
            lblRelogio.Size = new Size(215, 74);
            lblRelogio.TabIndex = 14;
            lblRelogio.Text = "Horário";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblSemana
            // 
            lblSemana.AutoSize = true;
            lblSemana.Font = new Font("Tw Cen MT", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSemana.ForeColor = Color.RoyalBlue;
            lblSemana.Location = new Point(43, 173);
            lblSemana.Name = "lblSemana";
            lblSemana.Size = new Size(34, 22);
            lblSemana.TabIndex = 15;
            lblSemana.Text = "Dia";
            // 
            // CtrlPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblSemana);
            Controls.Add(lblRelogio);
            Name = "CtrlPrincipal";
            Size = new Size(1056, 653);
            Load += CtrlPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRelogio;
        private System.Windows.Forms.Timer timer1;
        private Label lblSemana;
    }
}
