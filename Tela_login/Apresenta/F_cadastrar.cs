using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tela_login.modelo;

namespace Tela_login.Apresenta {
    public partial class F_cadastrar : Form {
        public F_cadastrar() {
            InitializeComponent();
        }

        private void btn_cadast_cadst_Click(object sender, EventArgs e) {
            Controle ctr = new Controle();
            string msg = ctr.Cadastrar(tb_log_cadstrar.Text, tb_senha_cadst.Text, tb_conf_senha_cadstr.Text);
            if(ctr.validar) {
                MessageBox.Show(msg, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_log_cadstrar.Clear();
                tb_conf_senha_cadstr.Clear();
                tb_senha_cadst.Clear();
            } else {
                MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
