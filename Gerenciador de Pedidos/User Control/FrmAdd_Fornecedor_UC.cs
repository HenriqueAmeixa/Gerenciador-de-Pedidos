using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibliotecas.Classes;
using Bibliotecas.Estruturas;

namespace Gerenciador_de_Pedidos.User_Control
{
    public partial class FrmAdd_Fornecedor_UC : UserControl
    {
        public FrmAdd_Fornecedor_UC()
        {
            InitializeComponent();
        }

        private void btn_BuscarCEP_Click(object sender, EventArgs e)
        {
            var vJson = BuscaCEP.GeraJSONCEP(txt_CEP.Text);
            CEP.Unit Cep = new CEP.Unit();
            Cep = CEP.DesSerializedClassUnit(vJson);

            txt_Bairro.Text = Formatador.Formatar(Cep.Bairro);
            txt_Rua.Text = Formatador.Formatar(Cep.Logradouro);
            txt_Cidade.Text = Formatador.Formatar(Cep.Localidade);
            txt_UF.Text = Formatador.Formatar(Cep.UF);
            

        }
    }
}
