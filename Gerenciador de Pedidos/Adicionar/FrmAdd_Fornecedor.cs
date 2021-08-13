using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gerenciador_de_Pedidos.User_Control;

namespace Gerenciador_de_Pedidos.Adicionar
{
    public partial class FrmAdd_Fornecedor : Form
    {
        public FrmAdd_Fornecedor()
        {
            InitializeComponent();
        }

        private void FrmAddFornecedor_Load(object sender, EventArgs e)
        {
            FrmAdd_Fornecedor_UC fornBasic = new FrmAdd_Fornecedor_UC();
            fornBasic.Dock = DockStyle.Fill;
            TabPage tbBasic = new TabPage();
            tbBasic.Name = "Cadastro de Fornecedor";
            tbBasic.Text = "Cadastro de Fornecedor";
            tbBasic.Controls.Add(fornBasic);
            tbc_Fornecedor.TabPages.Add(tbBasic);

            FrmAdd_Descontos_UC fornDesc = new FrmAdd_Descontos_UC();
            fornBasic.Dock = DockStyle.Fill;
            TabPage tbDesc = new TabPage();
            tbDesc.Name = "Descontos";
            tbDesc.Text = "Descontos";
            tbDesc.Controls.Add(fornDesc);
            tbc_Fornecedor.TabPages.Add(tbDesc);

            FrmAdd_Icone_UC fornIcone = new FrmAdd_Icone_UC();
            fornBasic.Dock = DockStyle.Fill;
            TabPage tbIcone = new TabPage();
            tbIcone.Name = "Logo";
            tbIcone.Text = "Logo";
            tbIcone.Controls.Add(fornIcone);
            tbc_Fornecedor.TabPages.Add(tbIcone);
        }
    }
}
