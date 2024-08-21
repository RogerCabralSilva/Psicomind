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
    public partial class FrmShowEscala : Form
    {

        private int profissionalId;
        private Profissional Profissional;

        public FrmShowEscala(int profissionalId)
        {
            InitializeComponent();
            this.profissionalId = profissionalId;
        }

        private void FrmShowEscala_Load(object sender, EventArgs e)
        {

            CarregaEscala();
            ExibirNome();

        }

        private void ExibirNome()
        {

            string nome = Profissional.ObterNomePorId(profissionalId);
            lblProfissional.Text = nome;

        }

        private void CarregaEscala()
        {


            var escalas = Escala.ObterListaProfissional(profissionalId);
            int count = 0;


            dgvEscala.Rows.Clear();
            foreach (var escala in escalas)
            {
                int rowIndex = dgvEscala.Rows.Add();
                dgvEscala.Rows[count].Cells[0].Value = escala.Dia;
                dgvEscala.Rows[count].Cells[1].Value = escala.Horario;

                count++;


            }

        }

        private void dgvEscala_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
