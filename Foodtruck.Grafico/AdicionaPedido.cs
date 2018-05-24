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
    public partial class AdicionaPedido : Form
    {
        Pedido pedido = new Pedido();
        public Pedido PedidoSelecionado { get; set; }

        public AdicionaPedido()
        {
            InitializeComponent();
        }

        private void AdicionarPedido_Load(object sender, EventArgs e)
        {
            CarregaComboBoxes();
            CarregaDataGrids();
            CarregaTotal();
            this.WindowState = FormWindowState.Maximized;
        }

        private void CarregaComboBoxes()
        {
            cbClientes.DisplayMember = "Descricao";
            cbClientes.ValueMember = "Id";
            cbClientes.DataSource = Program.Gerenciador.TodosOsClientes();

            cbLanches.DisplayMember = "Nome";
            cbLanches.ValueMember = "Id";
            cbLanches.DataSource = Program.Gerenciador.TodosOsLanches();

            cbBebidas.DisplayMember = "Nome";
            cbBebidas.ValueMember = "Id";
            cbBebidas.DataSource = Program.Gerenciador.TodasAsBebidas();
        }

        private void CarregaTotal()
        {
            lbTotal.Text = pedido.ValorTotal.ToString();
        }

        private void btAddBebida_Click(object sender, EventArgs e)
        {
            Bebida bebidaSelecionada = (Bebida)cbBebidas.SelectedItem;
            pedido.Bebidas.Add(bebidaSelecionada);
            CarregaDataGrids();
        }

        private void btAddLanche_Click(object sender, EventArgs e)
        {
            Lanche lancheSelecionado = cbLanches.SelectedItem as Lanche;
            pedido.Lanches.Add(lancheSelecionado);
            CarregaDataGrids();
        }

        private void CarregaDataGrids()
        {
            dgBebidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgBebidas.AutoGenerateColumns = false;
            dgBebidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgBebidas.MultiSelect = false;
            dgBebidas.DataSource = pedido.Bebidas.ToList();

            dgLanches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgLanches.AutoGenerateColumns = false;
            dgLanches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgLanches.MultiSelect = false;
            dgLanches.DataSource = pedido.Lanches.ToList();

            CarregaTotal();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            /*try
            {*/
                pedido.Cliente = cbClientes.SelectedItem as Cliente;
                pedido.DataCompra = DateTime.Now;
                Validacao validacao = Program.Gerenciador.CadastrarPedido(pedido);

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
                    MessageBox.Show("Pedido cadastrado com sucesso");
                }
                this.Close();
            /*}
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro grave, fale com o administrador");
            }*/
        }
    }
}
