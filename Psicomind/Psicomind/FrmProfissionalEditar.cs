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
    public partial class FrmProfissionalEditar : Form
    {
        public FrmProfissionalEditar()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Tirando os traços do maskedTexBox
            mtxTelefoneProfissional.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            // Editando profissional

            Profissional profissional = new(

                int.Parse(txtProfissionalId.Text),
                txtNomeProfissional.Text,
                txtSenhaProfissional.Text,
                dptDataNascimentoProfissional.Value,
                Genero.ObterPorId(Convert.ToInt32(cmbGeneroProfissional.SelectedValue)),
                Cargo.ObterPorId(Convert.ToInt32(cmbCargos.SelectedValue)),
                chkAtivoProfissional.Checked
                );

            // Editando telefone Profissional

            TelefoneProfissional telefoneProfissional = new(
                   mtxTelefoneProfissional.Text,
                   int.Parse(txtProfissionalId.Text),
                   TelefoneTipo.ObterPorId(Convert.ToInt32(cmbTipoTelefoneProfissional.SelectedValue))
            );


            if (profissional.Editar(profissional.Id))
            {
                FrmProfissionalEditar_Load(sender, e);
                MessageBox.Show($"O Profissional {profissional.Nome} foi alterado com sucesso!");

                //Limpando após editar Profissional

                txtProfissionalId.Clear();
                txtNomeProfissional.Clear();
                txtSenhaProfissional.Clear();
                cmbGeneroProfissional.SelectedIndex = -1;
                cmbTipoTelefoneProfissional.SelectedIndex = -1;
                mtxTelefoneProfissional.Clear();
                dptDataNascimentoProfissional.Value = DateTime.Today;
                chkAtivoProfissional.Checked = false;
                cmbCargos.SelectedValue = -1;

            }
            else
            {
                MessageBox.Show("Falha ao alterar o Profissional");
            }


            if (profissional.Editar(profissional.Id))
            {
                FrmProfissionalEditar_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Falha ao alterar o Profissional");
            }


            // Retorna True ou false e roda o que tiver dentro do if

            if (telefoneProfissional.Editar(profissional.Id))
            {
                FrmProfissionalEditar_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Falha ao alterar o Cliente");
            }
        }

        private void FrmProfissionalEditar_Load(object sender, EventArgs e)
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

            var cargo = Cargo.ObterLista();
            cmbCargos.DataSource = cargo;
            cmbCargos.DisplayMember = "nome";
            cmbCargos.ValueMember = "id";

            // Preenchendo via ID

            if (txtProfissionalId.Text != string.Empty)
            {

                // Busca o cliente

                var profissional = Profissional.ObterPorId(int.Parse(txtProfissionalId.Text)); ;
                txtNomeProfissional.Text = profissional.Nome;
                txtSenhaProfissional.Text = profissional.Senha;
                cmbGeneroProfissional.SelectedValue = profissional.Genero.Id;
                chkAtivoProfissional.Checked = profissional.Ativo;
                dptDataNascimentoProfissional.Value = profissional.Data_nasc;
                cmbCargos.SelectedValue = profissional.Cargo.Nome;


                // Busca o Telefone
                mtxTelefoneProfissional.Text = profissional.TelefoneProfissional.Numero;
                cmbTipoTelefoneProfissional.SelectedValue = profissional.TelefoneProfissional.Id;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Se o profissionalId for maior que 0 faça isso

            // Convertendo o valor atribuído ao componente txtProfissionalId do tipo text em INT para 
            // o uso do método ObterPorId, armazenando no objeto profissional

            if (txtProfissionalId.Text.Length != 0)
            {
                Profissional profissional = Profissional.ObterPorId(int.Parse(txtProfissionalId.Text));
                TelefoneProfissional telefoneProfissional = TelefoneProfissional.ObterPorId(int.Parse(txtProfissionalId.Text));

                if (profissional.Id != 0)
                {

                    // Buscando Profissional

                    txtNomeProfissional.Text = profissional.Nome;
                    //txtSenhaProfissional.PlaceholderText = "Insira sua nova senha";
                    txtSenhaProfissional.Text = profissional.Senha;
                    cmbGeneroProfissional.SelectedValue = profissional.Genero.Id;
                    chkAtivoProfissional.Checked = profissional.Ativo;
                    dptDataNascimentoProfissional.Value = profissional.Data_nasc;
                    cmbCargos.SelectedValue = profissional.Cargo.Id;
                    cmbTipoTelefoneProfissional.SelectedValue = profissional.TelefoneProfissional.Id;
                    mtxTelefoneProfissional.Text = profissional.TelefoneProfissional.Numero;
                    cmbTipoTelefoneProfissional.SelectedValue = profissional.TelefoneProfissional.Id;


                    btnEditar.Enabled = true;

                }
                else
                {
                    // Profissional não encontrado, exibe mensagem de erro e limpa os campos
                    MessageBox.Show("Profissional não encontrado.");
                    btnEditar.Enabled = false;

                    // Limpando campos do formulário

                    txtProfissionalId.Clear();
                    txtNomeProfissional.Clear();
                    txtSenhaProfissional.Clear();
                    cmbGeneroProfissional.SelectedIndex = -1;
                    cmbTipoTelefoneProfissional.SelectedIndex = -1;
                    mtxTelefoneProfissional.Clear();
                    dptDataNascimentoProfissional.Value = DateTime.Today;
                    chkAtivoProfissional.Checked = false;
                    cmbCargos.SelectedValue = -1;


                }


            }
        }

        private void txtProfissionalId_TextChanged(object sender, EventArgs e)
        {
            // Verifica se há valor no campo ProfissionalId

            if (txtProfissionalId.Text.Length == 0)
            {
                btnEditar.Enabled = false;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpando campos do formulário

            txtProfissionalId.Clear();
            txtNomeProfissional.Clear();
            txtSenhaProfissional.Clear();
            cmbGeneroProfissional.SelectedIndex = -1;
            cmbTipoTelefoneProfissional.SelectedIndex = -1;
            mtxTelefoneProfissional.Clear();
            dptDataNascimentoProfissional.Value = DateTime.Today;
            chkAtivoProfissional.Checked = false;
            cmbCargos.SelectedValue = -1;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FrmProfissionalMenu FrmProfissionalMenu = new FrmProfissionalMenu();

            FrmProfissionalMenu.StartPosition = FormStartPosition.CenterScreen;

            FrmProfissionalMenu.Show();

            this.Close();
        }
    }
}
