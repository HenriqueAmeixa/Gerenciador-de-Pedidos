using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gerenciador_de_Pedidos.Adicionar;

namespace Gerenciador_de_Pedidos
{
    public partial class Frm_TelaPrincipal : Form
    {
        public Frm_TelaPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adicionar.FrmAdd_Fornecedor f = new Adicionar.FrmAdd_Fornecedor();
            f.ShowDialog();
        }
    }
}
