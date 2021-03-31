using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class F_principal : Form
    {
        string txt;
        public F_principal()
        {
            InitializeComponent();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            F_lista listanome = new F_lista();
            txt += tb_add_nome.Text + ", ";
            MessageBox.Show("O nome " + txt + " foi adicionado a lista");
            tb_add_nome.Clear();
            tb_add_nome.Focus();
        }

        private void btn_lista_Click(object sender, EventArgs e)
        {
            F_lista listanome = new F_lista(txt);
            listanome.ShowDialog();
        }
    }
}
