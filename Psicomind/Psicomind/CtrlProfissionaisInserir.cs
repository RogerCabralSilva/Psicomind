using PsicomindClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psicomind
{
    public partial class CtrlProfissionaisInserir : UserControl
    {
        public CtrlProfissionaisInserir()
        {
            InitializeComponent();
        }

        private void AddUserControl(UserControl userControl)
        {

            CtrlProfissional ctrlProfissional = new();

            userControl.Dock = DockStyle.Fill;
            pnp.Controls.Clear();
            pnp.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            CtrlProfissional ctrlProfissional = new();
            AddUserControl(ctrlProfissional);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeProfissional.Clear();
            txtEmailProfissional.Clear();
            txtSenhaProfissional.Clear();
            mtxCpfProfissional.Clear();
            mtxTelefoneProfissional.Clear();
        }

        private void btnInserirProfissional_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNomeProfissional.Text))
            {
                MessageBox.Show("O nome é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEmailProfissional.Text))
            {
                MessageBox.Show("O email é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSenhaProfissional.Text))
            {
                MessageBox.Show("A senha é obrigatória.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbGeneroProfissional.SelectedValue == null)
            {
                MessageBox.Show("O gênero é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void CtrlProfissionaisInserir_Load(object sender, EventArgs e)
        {

            // Preencher combo box ao carregar componente

            var genero = Genero.ObterLista();
            cmbGeneroProfissional.DataSource = genero;
            cmbGeneroProfissional.DisplayMember = "Genero_nome";
            cmbGeneroProfissional.ValueMember = "id";

            var tipoTelefone = TelefoneTipo.ObterLista();
            cmbTipoTelefoneProfissional.DataSource = tipoTelefone;
            cmbTipoTelefoneProfissional.DisplayMember = "tipo";
            cmbTipoTelefoneProfissional.ValueMember = "id";

        }
    }
}
