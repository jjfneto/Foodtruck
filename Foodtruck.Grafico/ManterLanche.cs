﻿using Foodtruck.Negocio;
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
    public partial class ManterLanche : Form
    {
        public Lanche LancheSelecionado { get; set; }

        public ManterLanche()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Lanche lanche = new Lanche();
            lanche.Id = Convert.ToInt64(tbId.Text);
            lanche.Nome = tbNome.Text;
            lanche.Valor = Convert.ToDecimal(tbValor.Text);

            Validacao validacao;
            if (LancheSelecionado == null)
            {
                validacao = Program.Gerenciador.CadastraLanche(lanche);
            }
            else
            {
                validacao = Program.Gerenciador.AlterarLanche(lanche);
            }

            if (!validacao.Valido)
            {
                String mensagemValidacao = "";
                foreach (var chave in validacao.Mensagens.Keys)
                {
                    String msg = validacao.Mensagens[chave];
                    mensagemValidacao += msg;
                    mensagemValidacao += Environment.NewLine;
                }
                MessageBox.Show(mensagemValidacao);
            }
            else
            {
                MessageBox.Show("Lanche salvo com sucesso");
            }

            this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManterLanche_Shown(object sender, EventArgs e)
        {
            if (LancheSelecionado != null)
            {
                this.tbId.Text = LancheSelecionado.Id.ToString();
                this.tbNome.Text = LancheSelecionado.Nome;
                this.tbValor.Text = LancheSelecionado.Valor.ToString();
            }
        }
    }
}
