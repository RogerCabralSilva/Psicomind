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

            // Limpa as linhas existentes no DataGridView
            dgvEscala.Rows.Clear();

            // Adiciona as linhas de escala ao DataGridView
            foreach (var escala in escalas)
            {
                int rowIndex = dgvEscala.Rows.Add();
                dgvEscala.Rows[count].Cells[0].Value = escala.Dia.Date.ToString("dd/MM/yyyy");
                dgvEscala.Rows[count].Cells[1].Value = escala.Horario;
                count++;
            }

            // Verifica se a coluna de botões já existe, para não adicionar duplicadamente
            if (dgvEscala.Columns["btnDeletar"] == null)
            {
                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                button.Name = "btnDeletar";
                button.HeaderText = "Ação";
                button.Text = "Deletar";
                button.UseColumnTextForButtonValue = true; // Exibe o texto do botão

                button.Width = 100;
                dgvEscala.Columns.Add(button); // Adiciona a coluna de botão ao DataGridView
            }
        }



    private void dgvEscala_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica se a linha clicada é válida
            {
                DataGridViewRow row = dgvEscala.Rows[e.RowIndex];

                // Tenta converter o valor da célula para DateTime
                DateTime data;
                if (DateTime.TryParse(row.Cells["clnData"].Value.ToString(), out data))
                {
                    // Formata a data para "dd/MM/yyyy"
                    string dataFormatada = data.ToString("yyyy/MM/dd");

                    // Exibe a mensagem de confirmação com a data formatada
                    if (MessageBox.Show(
                            string.Format("Você quer deletar essa linha? Data: {0}, Horário: {1}",
                            dataFormatada, row.Cells["clnHorario"].Value),
                            "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // Deleta a linha passando os valores da célula para o método Deletar
                        Escala.Deletar(dataFormatada, Convert.ToString(row.Cells["clnHorario"].Value));

                        // Recarrega a escala
                        CarregaEscala();
                    }
                }
                else
                {
                    MessageBox.Show("A data selecionada não é válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
