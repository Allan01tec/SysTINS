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
    public partial class FrmLogin : Form
    {
        private int tentativa = 0;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //colocar validação do login
            var usuario = Usuario.EfetuarLogin(txtEmail.Text,txtSenha.Text);
            if (usuario.Id>0)
            {//caso o login tenha funcionado
                Program.UsuarioLogado = usuario ;
                this.DialogResult = DialogResult.OK;
            Close();
               
            }
            else
            {
                tentativa++;
                if (tentativa < 3)
                { 
                    lblMensagem.Text = $"Usuário e/ou senha inválidos \n restam {tentativa + 1}/3"; 
                }
                else
                {
                    lblMensagem.Text = "Número de login excedido!";
                    this.DialogResult = DialogResult.OK;
                }
              
            }
       
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
