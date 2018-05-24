using Foodtruck.Negocio;
using Foodtruck.Negocio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodtruck.Grafico
{
    public partial class TelaListaPedidos : Form
    {
        Pedido pedido = new Pedido();

        public TelaListaPedidos()
        {
            InitializeComponent();
        }

        private void AbreTelaInclusaoAlteracao(Pedido pedidoSelecionado)
        {
            AdicionaPedido tela = new AdicionaPedido();
            tela.MdiParent = this.MdiParent;
            tela.PedidoSelecionado = pedidoSelecionado;
            tela.FormClosed += Tela_FormClosed;
            tela.Show();
        }

        private void CarregarPedidos()
        {
            dgPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPedidos.MultiSelect = false;
            dgPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPedidos.AutoGenerateColumns = false;
            dgPedidos.DataSource = Program.Gerenciador.TodosOsPedidos();
        }

        private void TelaListaPedidos_Load(object sender, EventArgs e)
        {
            CarregarPedidos();
            this.WindowState = FormWindowState.Maximized;
        }

        private bool VerificarSelecao()
        {
            if (dgPedidos.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            AbreTelaInclusaoAlteracao(null);
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarPedidos();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                Pedido pedidoSelecionado = (Pedido)dgPedidos.SelectedRows[0].DataBoundItem;
                AbreTelaInclusaoAlteracao(pedidoSelecionado);
            }
        }

        private void btFinalizarPedido_Click(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                Pedido pedidoSelecionado = (Pedido)dgPedidos.SelectedRows[0].DataBoundItem;

                if (pedidoSelecionado.Encerrado.Equals(true))
                {
                    MessageBox.Show("Esse pedido já foi finalizado");
                    return;
                }

                pedidoSelecionado.Encerrado = true;
                Validacao validacao = Program.Gerenciador.AlterarPedido(pedidoSelecionado);

                if (!validacao.Valido)
                {
                    String mensagemValidacao = "";
                    foreach (var msg in validacao.Mensagens)
                    {
                        mensagemValidacao += msg + Environment.NewLine;
                    }
                    MessageBox.Show(mensagemValidacao, "Erro");
                }
                else
                {
                    MessageBox.Show("Pedido finalizado com sucesso");
                }
            }
            CarregarPedidos();
        }
    }
}
