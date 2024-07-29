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
                txtEspecializaçãoProfissional.Text,
                dptDataContrato.Value,
                dptDataNascimentoProfissional.Value,
                Genero.ObterPorId(Convert.ToInt32(cmbGeneroProfissional.SelectedValue)),
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
                txtEspecializaçãoProfissional.Clear();
                cmbGeneroProfissional.SelectedIndex = -1;
                cmbTipoTelefoneProfissional.SelectedIndex = -1;
                mtxTelefoneProfissional.Clear();
                dptDataContrato.Value = DateTime.Today;
                dptDataNascimentoProfissional.Value = DateTime.Today;
                chkAtivoProfissional.Checked = false;

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
                    txtEspecializaçãoProfissional.Text = profissional.Especializacao;
                    cmbGeneroProfissional.SelectedValue = profissional.Genero.Id;
                    chkAtivoProfissional.Checked = profissional.Ativo;
                    dptDataContrato.Value = profissional.Data_contrato;
                    dptDataNascimentoProfissional.Value = profissional.Data_nasc;


                    // Buscando telefone Profissional

                    if (telefoneProfissional.Id != 0)
                    {

                        // Verificando se o cliente possui telefone

                        mtxTelefoneProfissional.Text = telefoneProfissional.Numero;
                        cmbTipoTelefoneProfissional.SelectedValue = telefoneProfissional.Telefonetipo_id.Id;


                    }

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
                    txtEspecializaçãoProfissional.Clear();
                    cmbGeneroProfissional.SelectedIndex = -1;
                    cmbTipoTelefoneProfissional.SelectedIndex = -1;
                    mtxTelefoneProfissional.Clear();
                    dptDataContrato.Value = DateTime.Today;
                    dptDataNascimentoProfissional.Value = DateTime.Today;
                    chkAtivoProfissional.Checked = false;


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
            txtEspecializaçãoProfissional.Clear();
            cmbGeneroProfissional.SelectedIndex = -1;
            cmbTipoTelefoneProfissional.SelectedIndex = -1;
            mtxTelefoneProfissional.Clear();
            dptDataContrato.Value = DateTime.Today;
            dptDataNascimentoProfissional.Value = DateTime.Today;
            chkAtivoProfissional.Checked = false;
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
