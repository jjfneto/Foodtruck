using Foodtruck.Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Foodtruck.Grafico
{
    public partial class TelaListaLanches : Form
    {
        public TelaListaLanches()
        {
            InitializeComponent();
        }

        private void AbreTelaInclusaoAlteracao(Lanche lancheSelecionado)
        {
            ManterLanche tela = new ManterLanche();
            tela.MdiParent = this.MdiParent;
            tela.LancheSelecionado = lancheSelecionado;
            tela.FormClosed += Tela_FormClosed;
            tela.Show();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            AbreTelaInclusaoAlteracao(null);
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarLanches();
        }

        private void CarregarLanches()
        {
            dgLanches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgLanches.MultiSelect = false;
            dgLanches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgLanches.AutoGenerateColumns = false;
            List<Lanche> lanches = Program.Gerenciador.TodosOsLanches();
            dgLanches.DataSource = lanches;
        }

        private void TelaListaLanches_Load(object sender, EventArgs e)
        {
            CarregarLanches();
            this.WindowState = FormWindowState.Maximized;
        }

        private bool VerificarSelecao()
        {
            if (dgLanches.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                DialogResult resultado = MessageBox.Show("Tem certeza?", "Quer remover?", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    Lanche lancheSelecionado = (Lanche)dgLanches.SelectedRows[0].DataBoundItem;
                    var validacao = Program.Gerenciador.RemoverLanche(lancheSelecionado);
                    if (validacao.Valido)
                    {
                        MessageBox.Show("Lanche removido com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um problema ao remover o lanche");
                    }
                    CarregarLanches();
                }
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                Lanche lancheSelecionada = (Lanche)dgLanches.SelectedRows[0].DataBoundItem;
                AbreTelaInclusaoAlteracao(lancheSelecionada);
            }
        }
    }
}
