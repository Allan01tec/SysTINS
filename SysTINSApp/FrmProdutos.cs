using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysTINSClass;

namespace SysTINSApp
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            cmbCategoria.DataSource = Categoria.ObterLista();
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.DisplayMember= "Descricao";
            cmbCategoria.ValueMember = "Desconto";
            CarregaGridProdutos();

        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            Categoria categoria = new(
                txtCod.Text,
                Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue))
                );
            categoria.Inserir();
            if (categoria.Id > 0)
            {
                // carrega grid
                CarregaGridProdutos();
                MessageBox.Show($"Produto {categoria.Nome} inserido com sucesso");
                btnInserir.Enabled = false;
            }
        }
        private void CarregaGridProdutos()
        {
            dgvProdutos.Rows.Clear();
            var listaDeProdutos = Categoria.ObterLista();
            int linha = 0;
            foreach (var categoria in listaDeProdutos)
            {
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[linha].Cells[0].Value = categoria.Id;
                dgvProdutos.Rows[linha].Cells[1].Value = categoria.Nome;
                dgvProdutos.Rows[linha].Cells[2].Value = categoria.Descricao;
                linha++;
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaAtual = dgvProdutos.CurrentRow.Index;
            int idUser = Convert.ToInt32(dgvProdutos.Rows[linhaAtual].Cells[0].Value);
            var categoria = Categoria.ObterPorId(idUser);
            txtID.Text = categoria.Id.ToString();
            txtCod.Text = categoria.Nome;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new();
            categoria.Id = int.Parse(txtID.Text);
            categoria.Nome = txtCod.Text;

            if (categoria.Atualizar())
            {
                CarregaGridProdutos();
                MessageBox.Show("Produto atualizado com sucesso");
            }
        }

        private void txtID_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblValor_Click(object sender, EventArgs e)
        {

        }
    }
}