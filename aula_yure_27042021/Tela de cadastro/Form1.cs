using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela_de_cadastro {
    public partial class Form1 : Form {
        List<PessoaFisica> pessoa_fisica;
        public Form1() {
            InitializeComponent();
            pessoa_fisica = new List<PessoaFisica>();
        }

        public void adicionar() {
            string nome, endereco, cpf, num;
            if(tb_endereco.Text == "" || tb_nome.Text == "" || masked_cpf.Text == "" || masked_numero.Text == "") {

                MessageBox.Show("Campo não preenchido detectado. Preencha os campos para prosseguir.");

            } else {

                nome = tb_nome.Text;
                endereco = tb_endereco.Text;
                cpf = masked_cpf.Text;
                num = masked_numero.Text;

                PessoaFisica pessoa = new PessoaFisica(nome, cpf, endereco, num);
                pessoa_fisica.Add(pessoa);

                lista.Items.Add(nome);
                lista.Items.Add(cpf);
                lista.Items.Add(num);
                lista.Items.Add(endereco);
                lista.Items.Add("--------------------------\n");
                MessageBox.Show(nome + " foi adicionado(a) ao banco de cadastros!");
                limpar();
            }
        }

        public void limpar() {
            tb_endereco.Clear();
            tb_nome.Clear();
            masked_cpf.Clear();
            masked_numero.Clear();
            tb_nome.Focus();
        }


        private void btn_adicionar_Click(object sender, EventArgs e) {
            adicionar();
        }

    }
}
