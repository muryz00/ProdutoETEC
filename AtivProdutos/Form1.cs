using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtivProdutos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frmProduto = new Form2();
            frmProduto.Show();
        }

        private void movimentoDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frmMovto = new Form3();
            frmMovto.Show();
        }
    }
}
