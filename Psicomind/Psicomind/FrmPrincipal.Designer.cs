namespace Psicomind
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
            btnSair = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
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
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 653);
            panel1.TabIndex = 10;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 653);
            Controls.Add(panel1);
            Controls.Add(btnSair);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSair;
        private Panel panel1;
    }
}