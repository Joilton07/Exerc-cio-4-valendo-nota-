using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio4
{
    public partial class Form_Usuario : Form
    {
        public Form_Usuario()
        {
            InitializeComponent();
        }

        private void button_Acessar_Click(object sender, EventArgs e)
        {
            if (textBox_Usuario.Text == "admin")
            {
                if (textBox_Senha.Text == "123456")
                {
                    MessageBox.Show("Parabéns! Acesso liberado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    textBox_Senha.Focus();
                    MessageBox.Show("Senha incorreta. Tente: 123456", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                textBox_Usuario.Focus();
                MessageBox.Show("Usuário inválido. Tente: admin", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_Sair_Click(object sender, EventArgs e) => Close();

        private void textBox_Usuario_Enter(object sender, EventArgs e)
        {
            if (textBox_Usuario.Text == "Informe seu nome de usuário")
            {
                textBox_Usuario.Text = "";
                textBox_Usuario.ForeColor = Color.Black;
            }
        }

        private void textBox_Usuario_Leave(object sender, EventArgs e)
        {
            if (textBox_Usuario.Text == "")
            {
                textBox_Usuario.Text = "Informe seu nome de usuário";
                textBox_Usuario.ForeColor = Color.Gray;
            }
        }

        private void textBox_Senha_Leave(object sender, EventArgs e)
        {
            if (textBox_Senha.Text == "")
            {
                textBox_Senha.Text = "Informe sua senha";
                textBox_Senha.ForeColor = Color.Gray;
                textBox_Senha.PasswordChar = (char)0;
            }
        }

        private void textBox_Senha_Enter(object sender, EventArgs e)
        {
            if (textBox_Senha.Text == "Informe sua senha")
            {
                textBox_Senha.Text = "";
                textBox_Senha.ForeColor = Color.Black;
                textBox_Senha.PasswordChar = '*';
            }
        }

        private void Form_Usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void Form_Usuario_Load(object sender, EventArgs e)
        {
        }
    }
}
