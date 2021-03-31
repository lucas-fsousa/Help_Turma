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
    public partial class F_lista : Form
    {
        public F_lista(string lista)
        {
            InitializeComponent();
            tb_lista.Text = lista;
        }
        public F_lista()
        {
            InitializeComponent();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_lista.Clear();
            MessageBox.Show("Limpeza concluida.");
        }
    }
}
