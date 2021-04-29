using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tela_login.Apresenta;
using Tela_login.modelo;

namespace Tela_login {
    public partial class F_autentication : Form {
        public F_autentication() {
            InitializeComponent();
        }

        private void btn_logar_Click(object sender, EventArgs e) {
            Controle cs = new Controle();
            if(tb_login.Text == "" || tb_senha.Text == "") {
                MessageBox.Show("Login ou senha em branco, favor preencher os campos.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                cs.Logar(tb_login.Text, tb_senha.Text);
                if(cs.msg == "") { 
                    if(cs.validar) {
                        F_bem_vindo bv = new F_bem_vindo();
                        MessageBox.Show("Logado com sucesso!", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        bv.Show();
                        //F_autentication.ActiveForm.ActiveControl.Visible = false;
                    } else {
                        MessageBox.Show("Usuário ou senha inválido!", "ATENÇÃO", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                } else {
                    MessageBox.Show(cs.msg, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tb_sair_Click(object sender, EventArgs e) {
            F_autentication.ActiveForm.Close();
        }

        private void link_cadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            F_cadastrar cad = new F_cadastrar();
            cad.ShowDialog(); 
        }
    }
}
