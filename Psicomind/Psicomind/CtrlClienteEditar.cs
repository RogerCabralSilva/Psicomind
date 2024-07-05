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
    public partial class CtrlClienteEditar : UserControl
    {
        public CtrlClienteEditar()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Tirando os traços do maskedTexBox
            mtxCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mtxTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            Cliente cliente = new(
                txtNome.Text,
                txtSenha,
                dptDataNascimento.Value,
                Genero.ObterPorId(Convert.ToInt32(cmbGenero.SelectedValue))

                
                );
        }
    }
}
