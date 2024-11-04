namespace SysTINSApp
{
    partial class FrmProdutos
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
            label1 = new Label();
            txtID = new TextBox();
            txtCod = new TextBox();
            lblCod = new Label();
            dgvProdutos = new DataGridView();
            clnID = new DataGridViewTextBoxColumn();
            clnCod = new DataGridViewTextBoxColumn();
            clnValor = new DataGridViewTextBoxColumn();
            clnUnidade = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnCategoria = new DataGridViewTextBoxColumn();
            clnEstoque = new DataGridViewTextBoxColumn();
            clnData = new DataGridViewTextBoxColumn();
            btnInserir = new Button();
            btnConsultar = new Button();
            btnAtualizar = new Button();
            cmbCategoria = new ComboBox();
            txtdesc = new TextBox();
            lbldesc = new Label();
            lblValor = new Label();
            txtValor = new TextBox();
            txtVenda = new TextBox();
            lblVenda = new Label();
            lblCategoria = new Label();
            lblEstoque = new Label();
            textBox1 = new TextBox();
            txtDesconto = new TextBox();
            lblDesconto = new Label();
            lblData = new Label();
            txtData = new TextBox();
            chkAtivo = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(230, 47);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(230, 65);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(51, 23);
            txtID.TabIndex = 1;
            txtID.TextChanged += txtID_TextChanged_1;
            // 
            // txtCod
            // 
            txtCod.Location = new Point(305, 65);
            txtCod.Name = "txtCod";
            txtCod.ReadOnly = true;
            txtCod.Size = new Size(66, 23);
            txtCod.TabIndex = 2;
            // 
            // lblCod
            // 
            lblCod.AutoSize = true;
            lblCod.Location = new Point(305, 47);
            lblCod.Name = "lblCod";
            lblCod.Size = new Size(66, 15);
            lblCod.TabIndex = 4;
            lblCod.Text = "Cod_barras";
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.AllowUserToResizeColumns = false;
            dgvProdutos.AllowUserToResizeRows = false;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { clnID, clnCod, clnValor, clnUnidade, clnDescricao, clnCategoria, clnEstoque, clnData });
            dgvProdutos.Location = new Point(33, 314);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(804, 150);
            dgvProdutos.TabIndex = 5;
            // 
            // clnID
            // 
            clnID.HeaderText = "ID";
            clnID.Name = "clnID";
            // 
            // clnCod
            // 
            clnCod.HeaderText = "Cod_barras";
            clnCod.Name = "clnCod";
            // 
            // clnValor
            // 
            clnValor.HeaderText = "Valor_Unit";
            clnValor.Name = "clnValor";
            // 
            // clnUnidade
            // 
            clnUnidade.HeaderText = "Unidade Venda";
            clnUnidade.Name = "clnUnidade";
            // 
            // clnDescricao
            // 
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            // 
            // clnCategoria
            // 
            clnCategoria.HeaderText = "Categoria ID";
            clnCategoria.Name = "clnCategoria";
            // 
            // clnEstoque
            // 
            clnEstoque.HeaderText = "Estoque minimo";
            clnEstoque.Name = "clnEstoque";
            // 
            // clnData
            // 
            clnData.HeaderText = "Data cad";
            clnData.Name = "clnData";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(150, 276);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(97, 23);
            btnInserir.TabIndex = 6;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(390, 276);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(97, 23);
            btnConsultar.TabIndex = 7;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(624, 276);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(97, 23);
            btnAtualizar.TabIndex = 8;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(557, 97);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(84, 23);
            cmbCategoria.TabIndex = 9;
            // 
            // txtdesc
            // 
            txtdesc.Location = new Point(230, 129);
            txtdesc.Name = "txtdesc";
            txtdesc.Size = new Size(304, 23);
            txtdesc.TabIndex = 10;
            // 
            // lbldesc
            // 
            lbldesc.AutoSize = true;
            lbldesc.Location = new Point(230, 105);
            lbldesc.Name = "lbldesc";
            lbldesc.Size = new Size(58, 15);
            lbldesc.TabIndex = 11;
            lbldesc.Text = "Descrição";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(230, 159);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(60, 15);
            lblValor.TabIndex = 12;
            lblValor.Text = "Valor_Unit";
            lblValor.Click += lblValor_Click;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(230, 177);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(60, 23);
            txtValor.TabIndex = 13;
            // 
            // txtVenda
            // 
            txtVenda.Location = new Point(313, 177);
            txtVenda.Name = "txtVenda";
            txtVenda.Size = new Size(86, 23);
            txtVenda.TabIndex = 14;
            // 
            // lblVenda
            // 
            lblVenda.AutoSize = true;
            lblVenda.Location = new Point(313, 159);
            lblVenda.Name = "lblVenda";
            lblVenda.Size = new Size(86, 15);
            lblVenda.TabIndex = 15;
            lblVenda.Text = "Unidade Venda";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(557, 74);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(72, 15);
            lblCategoria.TabIndex = 16;
            lblCategoria.Text = "Categoria ID";
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Location = new Point(421, 155);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(94, 15);
            lblEstoque.TabIndex = 17;
            lblEstoque.Text = "Estoque minimo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(421, 177);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(94, 23);
            textBox1.TabIndex = 18;
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(392, 65);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.ReadOnly = true;
            txtDesconto.Size = new Size(74, 23);
            txtDesconto.TabIndex = 19;
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Location = new Point(392, 47);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(57, 15);
            lblDesconto.TabIndex = 20;
            lblDesconto.Text = "Desconto";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(531, 159);
            lblData.Name = "lblData";
            lblData.Size = new Size(53, 15);
            lblData.TabIndex = 21;
            lblData.Text = "Data cad";
            // 
            // txtData
            // 
            txtData.Location = new Point(531, 177);
            txtData.Name = "txtData";
            txtData.Size = new Size(100, 23);
            txtData.TabIndex = 22;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Checked = true;
            chkAtivo.CheckState = CheckState.Checked;
            chkAtivo.Location = new Point(577, 133);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 23;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // FrmProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 476);
            Controls.Add(chkAtivo);
            Controls.Add(txtData);
            Controls.Add(lblData);
            Controls.Add(lblDesconto);
            Controls.Add(txtDesconto);
            Controls.Add(textBox1);
            Controls.Add(lblEstoque);
            Controls.Add(lblCategoria);
            Controls.Add(lblVenda);
            Controls.Add(txtVenda);
            Controls.Add(txtValor);
            Controls.Add(lblValor);
            Controls.Add(lbldesc);
            Controls.Add(txtdesc);
            Controls.Add(cmbCategoria);
            Controls.Add(btnAtualizar);
            Controls.Add(btnConsultar);
            Controls.Add(btnInserir);
            Controls.Add(dgvProdutos);
            Controls.Add(lblCod);
            Controls.Add(txtCod);
            Controls.Add(txtID);
            Controls.Add(label1);
            Name = "FrmProdutos";
            Text = "FrmProdutos";
            Load += FrmProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtID;
        private TextBox txtCod;
        private Label lblCod;
        private DataGridView dgvProdutos;
        private Button btnInserir;
        private Button btnConsultar;
        private Button btnAtualizar;
        private ComboBox cmbCategoria;
        private TextBox txtdesc;
        private Label lbldesc;
        private Label lblValor;
        private TextBox txtValor;
        private TextBox txtVenda;
        private Label lblVenda;
        private Label lblCategoria;
        private Label lblEstoque;
        private TextBox textBox1;
        private TextBox txtDesconto;
        private Label lblDesconto;
        private Label lblData;
        private TextBox txtData;
        private DataGridViewTextBoxColumn clnID;
        private DataGridViewTextBoxColumn clnCod;
        private DataGridViewTextBoxColumn clnValor;
        private DataGridViewTextBoxColumn clnUnidade;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnCategoria;
        private DataGridViewTextBoxColumn clnEstoque;
        private DataGridViewTextBoxColumn clnData;
        private CheckBox chkAtivo;
    }
}