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
    public partial class FrmProfissionalMenu : Form
    {
        public FrmProfissionalMenu()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = FrmPrincipal.GetInstance();
            frmPrincipal.StartPosition = FormStartPosition.CenterScreen;
            this.Close();
        }

        private void btnPagInserirProfissionais_Click(object sender, EventArgs e)
        {
            FrmProfissionalInserir FrmProfissionalInserir = new FrmProfissionalInserir();
            FrmProfissionalInserir.StartPosition = FormStartPosition.CenterScreen;
            FrmProfissionalInserir.ShowDialog();
            this.Close();
        }

        private void btnPagConsultarProfissionais_Click(object sender, EventArgs e)
        {
            FrmProfissionalConsultar FrmProfissionalConsultar = new FrmProfissionalConsultar();
            FrmProfissionalConsultar.StartPosition = FormStartPosition.CenterScreen;
            FrmProfissionalConsultar.ShowDialog();
            this.Close();
        }

        private void btnPagEditarProfissionais_Click(object sender, EventArgs e)
        {
            FrmProfissionalEditar FrmProfissionalEditar = new FrmProfissionalEditar();
            FrmProfissionalEditar.StartPosition = FormStartPosition.CenterScreen;
            FrmProfissionalEditar.ShowDialog();
            this.Close();
        }
    }
}
