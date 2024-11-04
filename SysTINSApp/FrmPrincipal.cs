using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysTINSClass;
using static Mysqlx.Notice.Warning.Types;

namespace SysTINSApp
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new();//cria uma instância (objeto) do FormUsuarios
            frmUsuarios.MdiParent = this;//associa esta instancia ao Container (MDI) FrmPrincipal 
            frmUsuarios.Show();//exibe/chama o form Usuários na janela do sistema
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //Hide();
            //FrmLogin frmLogin = new();
            //if (frmLogin.ShowDialog() == DialogResult.OK)
            //{
            //    tsslUsuario.Text = Program.UsuarioLogado.Nome + "-" + Program.UsuarioLogado.Nivel.Nome;
            //    Show();
            //}
            //else
            //    Application.Exit();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}