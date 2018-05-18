namespace Foodtruck.Grafico
{
    partial class AdicionaPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBebidas = new System.Windows.Forms.ComboBox();
            this.cbLanches = new System.Windows.Forms.ComboBox();
            this.btAddBebida = new System.Windows.Forms.Button();
            this.btAddLanche = new System.Windows.Forms.Button();
            this.dgBebidas = new System.Windows.Forms.DataGridView();
            this.IdBebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeBebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorBebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgLanches = new System.Windows.Forms.DataGridView();
            this.IdLanche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeLanche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorLanche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgBebidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLanches)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes:";
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(56, 12);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(285, 21);
            this.cbClientes.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bebidas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lanches:";
            // 
            // cbBebidas
            // 
            this.cbBebidas.FormattingEnabled = true;
            this.cbBebidas.Location = new System.Drawing.Point(55, 57);
            this.cbBebidas.Name = "cbBebidas";
            this.cbBebidas.Size = new System.Drawing.Size(223, 21);
            this.cbBebidas.TabIndex = 4;
            // 
            // cbLanches
            // 
            this.cbLanches.FormattingEnabled = true;
            this.cbLanches.Location = new System.Drawing.Point(413, 57);
            this.cbLanches.Name = "cbLanches";
            this.cbLanches.Size = new System.Drawing.Size(223, 21);
            this.cbLanches.TabIndex = 5;
            // 
            // btAddBebida
            // 
            this.btAddBebida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddBebida.Location = new System.Drawing.Point(285, 55);
            this.btAddBebida.Name = "btAddBebida";
            this.btAddBebida.Size = new System.Drawing.Size(30, 23);
            this.btAddBebida.TabIndex = 6;
            this.btAddBebida.Text = "+";
            this.btAddBebida.UseVisualStyleBackColor = true;
            this.btAddBebida.Click += new System.EventHandler(this.btAddBebida_Click);
            // 
            // btAddLanche
            // 
            this.btAddLanche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddLanche.Location = new System.Drawing.Point(643, 57);
            this.btAddLanche.Name = "btAddLanche";
            this.btAddLanche.Size = new System.Drawing.Size(30, 23);
            this.btAddLanche.TabIndex = 7;
            this.btAddLanche.Text = "+";
            this.btAddLanche.UseVisualStyleBackColor = true;
            this.btAddLanche.Click += new System.EventHandler(this.btAddLanche_Click);
            // 
            // dgBebidas
            // 
            this.dgBebidas.AllowUserToResizeColumns = false;
            this.dgBebidas.AllowUserToResizeRows = false;
            this.dgBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBebidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdBebida,
            this.NomeBebida,
            this.ValorBebida});
            this.dgBebidas.Location = new System.Drawing.Point(8, 93);
            this.dgBebidas.Name = "dgBebidas";
            this.dgBebidas.ReadOnly = true;
            this.dgBebidas.Size = new System.Drawing.Size(307, 268);
            this.dgBebidas.TabIndex = 8;
            // 
            // IdBebida
            // 
            this.IdBebida.DataPropertyName = "Id";
            this.IdBebida.HeaderText = "Código";
            this.IdBebida.Name = "IdBebida";
            this.IdBebida.ReadOnly = true;
            // 
            // NomeBebida
            // 
            this.NomeBebida.DataPropertyName = "Nome";
            this.NomeBebida.HeaderText = "Nome";
            this.NomeBebida.Name = "NomeBebida";
            this.NomeBebida.ReadOnly = true;
            // 
            // ValorBebida
            // 
            this.ValorBebida.DataPropertyName = "Valor";
            this.ValorBebida.HeaderText = "Valor";
            this.ValorBebida.Name = "ValorBebida";
            this.ValorBebida.ReadOnly = true;
            // 
            // dgLanches
            // 
            this.dgLanches.AllowUserToResizeColumns = false;
            this.dgLanches.AllowUserToResizeRows = false;
            this.dgLanches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLanches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLanche,
            this.NomeLanche,
            this.ValorLanche});
            this.dgLanches.Location = new System.Drawing.Point(365, 93);
            this.dgLanches.Name = "dgLanches";
            this.dgLanches.Size = new System.Drawing.Size(307, 268);
            this.dgLanches.TabIndex = 9;
            // 
            // IdLanche
            // 
            this.IdLanche.DataPropertyName = "Id";
            this.IdLanche.HeaderText = "Código";
            this.IdLanche.Name = "IdLanche";
            // 
            // NomeLanche
            // 
            this.NomeLanche.DataPropertyName = "Nome";
            this.NomeLanche.HeaderText = "Nome";
            this.NomeLanche.Name = "NomeLanche";
            // 
            // ValorLanche
            // 
            this.ValorLanche.DataPropertyName = "Valor";
            this.ValorLanche.HeaderText = "Valor";
            this.ValorLanche.Name = "ValorLanche";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "TOTAL:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(57, 382);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(0, 13);
            this.lbTotal.TabIndex = 11;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(597, 372);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 12;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // AdicionaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 405);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgLanches);
            this.Controls.Add(this.dgBebidas);
            this.Controls.Add(this.btAddLanche);
            this.Controls.Add(this.btAddBebida);
            this.Controls.Add(this.cbLanches);
            this.Controls.Add(this.cbBebidas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.label1);
            this.Name = "AdicionaPedido";
            this.Text = "AdicionarPedido";
            this.Load += new System.EventHandler(this.AdicionarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBebidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLanches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBebidas;
        private System.Windows.Forms.ComboBox cbLanches;
        private System.Windows.Forms.Button btAddBebida;
        private System.Windows.Forms.Button btAddLanche;
        private System.Windows.Forms.DataGridView dgBebidas;
        private System.Windows.Forms.DataGridView dgLanches;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBebida;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeBebida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorBebida;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLanche;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeLanche;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorLanche;
    }
}