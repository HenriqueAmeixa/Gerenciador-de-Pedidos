
namespace Gerenciador_de_Pedidos.User_Control
{
    partial class FrmAdd_Fornecedor_UC
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_Endereco = new System.Windows.Forms.GroupBox();
            this.btn_BuscarCEP = new System.Windows.Forms.Button();
            this.txt_Bairro = new System.Windows.Forms.TextBox();
            this.lb_Bairro = new System.Windows.Forms.Label();
            this.txt_CEP = new System.Windows.Forms.TextBox();
            this.lb_CEP = new System.Windows.Forms.Label();
            this.txt_UF = new System.Windows.Forms.TextBox();
            this.lb_UF = new System.Windows.Forms.Label();
            this.lb_Cidade = new System.Windows.Forms.Label();
            this.txt_Cidade = new System.Windows.Forms.TextBox();
            this.txt_Rua = new System.Windows.Forms.TextBox();
            this.lb_Rua = new System.Windows.Forms.Label();
            this.gb_DadosFornecedor = new System.Windows.Forms.GroupBox();
            this.lb_Codigo = new System.Windows.Forms.Label();
            this.gb_Contato = new System.Windows.Forms.GroupBox();
            this.txt_Celular = new System.Windows.Forms.TextBox();
            this.lb_Celular = new System.Windows.Forms.Label();
            this.txt_Contato = new System.Windows.Forms.TextBox();
            this.lb_Contato = new System.Windows.Forms.Label();
            this.txt_Telefone = new System.Windows.Forms.TextBox();
            this.lb_Telefone = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Comissao = new System.Windows.Forms.TextBox();
            this.txt_NomeReduzido = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_IE = new System.Windows.Forms.TextBox();
            this.txt_CNPJ = new System.Windows.Forms.TextBox();
            this.lb_Comissao = new System.Windows.Forms.Label();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.lb_NomeReduzido = new System.Windows.Forms.Label();
            this.lb_IE = new System.Windows.Forms.Label();
            this.lb_CNPJ = new System.Windows.Forms.Label();
            this.lb_NomeFornecedor = new System.Windows.Forms.Label();
            this.gb_Endereco.SuspendLayout();
            this.gb_DadosFornecedor.SuspendLayout();
            this.gb_Contato.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Endereco
            // 
            this.gb_Endereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Endereco.Controls.Add(this.btn_BuscarCEP);
            this.gb_Endereco.Controls.Add(this.txt_Bairro);
            this.gb_Endereco.Controls.Add(this.lb_Bairro);
            this.gb_Endereco.Controls.Add(this.txt_CEP);
            this.gb_Endereco.Controls.Add(this.lb_CEP);
            this.gb_Endereco.Controls.Add(this.txt_UF);
            this.gb_Endereco.Controls.Add(this.lb_UF);
            this.gb_Endereco.Controls.Add(this.lb_Cidade);
            this.gb_Endereco.Controls.Add(this.txt_Cidade);
            this.gb_Endereco.Controls.Add(this.txt_Rua);
            this.gb_Endereco.Controls.Add(this.lb_Rua);
            this.gb_Endereco.Location = new System.Drawing.Point(13, 362);
            this.gb_Endereco.Name = "gb_Endereco";
            this.gb_Endereco.Size = new System.Drawing.Size(727, 137);
            this.gb_Endereco.TabIndex = 11;
            this.gb_Endereco.TabStop = false;
            this.gb_Endereco.Text = "Endereço";
            // 
            // btn_BuscarCEP
            // 
            this.btn_BuscarCEP.ImageIndex = 0;
            this.btn_BuscarCEP.Location = new System.Drawing.Point(155, 51);
            this.btn_BuscarCEP.Name = "btn_BuscarCEP";
            this.btn_BuscarCEP.Size = new System.Drawing.Size(31, 21);
            this.btn_BuscarCEP.TabIndex = 28;
            this.btn_BuscarCEP.UseVisualStyleBackColor = true;
            this.btn_BuscarCEP.Click += new System.EventHandler(this.btn_BuscarCEP_Click);
            // 
            // txt_Bairro
            // 
            this.txt_Bairro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Bairro.Location = new System.Drawing.Point(502, 51);
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.Size = new System.Drawing.Size(219, 20);
            this.txt_Bairro.TabIndex = 27;
            // 
            // lb_Bairro
            // 
            this.lb_Bairro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Bairro.AutoSize = true;
            this.lb_Bairro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Bairro.Location = new System.Drawing.Point(499, 31);
            this.lb_Bairro.Name = "lb_Bairro";
            this.lb_Bairro.Size = new System.Drawing.Size(46, 17);
            this.lb_Bairro.TabIndex = 26;
            this.lb_Bairro.Text = "Bairro:";
            // 
            // txt_CEP
            // 
            this.txt_CEP.Location = new System.Drawing.Point(21, 51);
            this.txt_CEP.Name = "txt_CEP";
            this.txt_CEP.Size = new System.Drawing.Size(128, 20);
            this.txt_CEP.TabIndex = 25;
            // 
            // lb_CEP
            // 
            this.lb_CEP.AutoSize = true;
            this.lb_CEP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CEP.Location = new System.Drawing.Point(18, 31);
            this.lb_CEP.Name = "lb_CEP";
            this.lb_CEP.Size = new System.Drawing.Size(33, 17);
            this.lb_CEP.TabIndex = 24;
            this.lb_CEP.Text = "CEP:";
            // 
            // txt_UF
            // 
            this.txt_UF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_UF.Location = new System.Drawing.Point(502, 94);
            this.txt_UF.Name = "txt_UF";
            this.txt_UF.Size = new System.Drawing.Size(34, 20);
            this.txt_UF.TabIndex = 23;
            // 
            // lb_UF
            // 
            this.lb_UF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_UF.AutoSize = true;
            this.lb_UF.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UF.Location = new System.Drawing.Point(499, 74);
            this.lb_UF.Name = "lb_UF";
            this.lb_UF.Size = new System.Drawing.Size(26, 17);
            this.lb_UF.TabIndex = 22;
            this.lb_UF.Text = "UF:";
            // 
            // lb_Cidade
            // 
            this.lb_Cidade.AutoSize = true;
            this.lb_Cidade.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Cidade.Location = new System.Drawing.Point(243, 31);
            this.lb_Cidade.Name = "lb_Cidade";
            this.lb_Cidade.Size = new System.Drawing.Size(52, 17);
            this.lb_Cidade.TabIndex = 21;
            this.lb_Cidade.Text = "Cidade:";
            // 
            // txt_Cidade
            // 
            this.txt_Cidade.Location = new System.Drawing.Point(246, 51);
            this.txt_Cidade.Name = "txt_Cidade";
            this.txt_Cidade.Size = new System.Drawing.Size(201, 20);
            this.txt_Cidade.TabIndex = 20;
            // 
            // txt_Rua
            // 
            this.txt_Rua.Location = new System.Drawing.Point(21, 94);
            this.txt_Rua.Name = "txt_Rua";
            this.txt_Rua.Size = new System.Drawing.Size(429, 20);
            this.txt_Rua.TabIndex = 19;
            // 
            // lb_Rua
            // 
            this.lb_Rua.AutoSize = true;
            this.lb_Rua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Rua.Location = new System.Drawing.Point(18, 74);
            this.lb_Rua.Name = "lb_Rua";
            this.lb_Rua.Size = new System.Drawing.Size(33, 17);
            this.lb_Rua.TabIndex = 3;
            this.lb_Rua.Text = "Rua:";
            // 
            // gb_DadosFornecedor
            // 
            this.gb_DadosFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_DadosFornecedor.Controls.Add(this.lb_Codigo);
            this.gb_DadosFornecedor.Controls.Add(this.gb_Contato);
            this.gb_DadosFornecedor.Controls.Add(this.txt_Comissao);
            this.gb_DadosFornecedor.Controls.Add(this.txt_NomeReduzido);
            this.gb_DadosFornecedor.Controls.Add(this.txt_Nome);
            this.gb_DadosFornecedor.Controls.Add(this.txt_IE);
            this.gb_DadosFornecedor.Controls.Add(this.txt_CNPJ);
            this.gb_DadosFornecedor.Controls.Add(this.lb_Comissao);
            this.gb_DadosFornecedor.Controls.Add(this.lbl_Codigo);
            this.gb_DadosFornecedor.Controls.Add(this.lb_NomeReduzido);
            this.gb_DadosFornecedor.Controls.Add(this.lb_IE);
            this.gb_DadosFornecedor.Controls.Add(this.lb_CNPJ);
            this.gb_DadosFornecedor.Controls.Add(this.lb_NomeFornecedor);
            this.gb_DadosFornecedor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_DadosFornecedor.Location = new System.Drawing.Point(13, 12);
            this.gb_DadosFornecedor.Name = "gb_DadosFornecedor";
            this.gb_DadosFornecedor.Size = new System.Drawing.Size(727, 333);
            this.gb_DadosFornecedor.TabIndex = 10;
            this.gb_DadosFornecedor.TabStop = false;
            this.gb_DadosFornecedor.Text = "Dados do Fornecedor";
            // 
            // lb_Codigo
            // 
            this.lb_Codigo.AutoSize = true;
            this.lb_Codigo.ForeColor = System.Drawing.Color.Red;
            this.lb_Codigo.Location = new System.Drawing.Point(23, 56);
            this.lb_Codigo.Name = "lb_Codigo";
            this.lb_Codigo.Size = new System.Drawing.Size(0, 17);
            this.lb_Codigo.TabIndex = 15;
            // 
            // gb_Contato
            // 
            this.gb_Contato.Controls.Add(this.txt_Celular);
            this.gb_Contato.Controls.Add(this.lb_Celular);
            this.gb_Contato.Controls.Add(this.txt_Contato);
            this.gb_Contato.Controls.Add(this.lb_Contato);
            this.gb_Contato.Controls.Add(this.txt_Telefone);
            this.gb_Contato.Controls.Add(this.lb_Telefone);
            this.gb_Contato.Controls.Add(this.lb_Email);
            this.gb_Contato.Controls.Add(this.txt_Email);
            this.gb_Contato.Location = new System.Drawing.Point(6, 158);
            this.gb_Contato.Name = "gb_Contato";
            this.gb_Contato.Size = new System.Drawing.Size(493, 158);
            this.gb_Contato.TabIndex = 14;
            this.gb_Contato.TabStop = false;
            this.gb_Contato.Text = "Contato";
            // 
            // txt_Celular
            // 
            this.txt_Celular.Location = new System.Drawing.Point(329, 53);
            this.txt_Celular.Name = "txt_Celular";
            this.txt_Celular.Size = new System.Drawing.Size(143, 25);
            this.txt_Celular.TabIndex = 18;
            // 
            // lb_Celular
            // 
            this.lb_Celular.AutoSize = true;
            this.lb_Celular.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Celular.Location = new System.Drawing.Point(326, 32);
            this.lb_Celular.Name = "lb_Celular";
            this.lb_Celular.Size = new System.Drawing.Size(51, 17);
            this.lb_Celular.TabIndex = 17;
            this.lb_Celular.Text = "Celular:";
            // 
            // txt_Contato
            // 
            this.txt_Contato.Location = new System.Drawing.Point(15, 53);
            this.txt_Contato.Name = "txt_Contato";
            this.txt_Contato.Size = new System.Drawing.Size(139, 25);
            this.txt_Contato.TabIndex = 16;
            // 
            // lb_Contato
            // 
            this.lb_Contato.AutoSize = true;
            this.lb_Contato.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Contato.Location = new System.Drawing.Point(12, 32);
            this.lb_Contato.Name = "lb_Contato";
            this.lb_Contato.Size = new System.Drawing.Size(57, 17);
            this.lb_Contato.TabIndex = 15;
            this.lb_Contato.Text = "Contato:";
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Location = new System.Drawing.Point(329, 113);
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(143, 25);
            this.txt_Telefone.TabIndex = 14;
            // 
            // lb_Telefone
            // 
            this.lb_Telefone.AutoSize = true;
            this.lb_Telefone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Telefone.Location = new System.Drawing.Point(326, 93);
            this.lb_Telefone.Name = "lb_Telefone";
            this.lb_Telefone.Size = new System.Drawing.Size(60, 17);
            this.lb_Telefone.TabIndex = 13;
            this.lb_Telefone.Text = "Telefone:";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.Location = new System.Drawing.Point(12, 93);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(48, 17);
            this.lb_Email.TabIndex = 2;
            this.lb_Email.Text = "E-Mail:";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(15, 113);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(287, 25);
            this.txt_Email.TabIndex = 12;
            // 
            // txt_Comissao
            // 
            this.txt_Comissao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Comissao.Location = new System.Drawing.Point(532, 53);
            this.txt_Comissao.Name = "txt_Comissao";
            this.txt_Comissao.Size = new System.Drawing.Size(78, 25);
            this.txt_Comissao.TabIndex = 13;
            // 
            // txt_NomeReduzido
            // 
            this.txt_NomeReduzido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_NomeReduzido.Location = new System.Drawing.Point(532, 111);
            this.txt_NomeReduzido.Name = "txt_NomeReduzido";
            this.txt_NomeReduzido.Size = new System.Drawing.Size(181, 25);
            this.txt_NomeReduzido.TabIndex = 11;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(21, 111);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(457, 25);
            this.txt_Nome.TabIndex = 10;
            // 
            // txt_IE
            // 
            this.txt_IE.Location = new System.Drawing.Point(445, 53);
            this.txt_IE.MaxLength = 2;
            this.txt_IE.Name = "txt_IE";
            this.txt_IE.Size = new System.Drawing.Size(33, 25);
            this.txt_IE.TabIndex = 9;
            // 
            // txt_CNPJ
            // 
            this.txt_CNPJ.Location = new System.Drawing.Point(198, 53);
            this.txt_CNPJ.Name = "txt_CNPJ";
            this.txt_CNPJ.Size = new System.Drawing.Size(155, 25);
            this.txt_CNPJ.TabIndex = 8;
            // 
            // lb_Comissao
            // 
            this.lb_Comissao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Comissao.AutoSize = true;
            this.lb_Comissao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Comissao.Location = new System.Drawing.Point(529, 33);
            this.lb_Comissao.Name = "lb_Comissao";
            this.lb_Comissao.Size = new System.Drawing.Size(68, 17);
            this.lb_Comissao.TabIndex = 6;
            this.lb_Comissao.Text = "Comissão:";
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Codigo.Location = new System.Drawing.Point(18, 33);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(54, 17);
            this.lbl_Codigo.TabIndex = 0;
            this.lbl_Codigo.Text = "Código:";
            // 
            // lb_NomeReduzido
            // 
            this.lb_NomeReduzido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_NomeReduzido.AutoSize = true;
            this.lb_NomeReduzido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NomeReduzido.Location = new System.Drawing.Point(529, 91);
            this.lb_NomeReduzido.Name = "lb_NomeReduzido";
            this.lb_NomeReduzido.Size = new System.Drawing.Size(106, 17);
            this.lb_NomeReduzido.TabIndex = 1;
            this.lb_NomeReduzido.Text = "Nome Reduzido:";
            // 
            // lb_IE
            // 
            this.lb_IE.AutoSize = true;
            this.lb_IE.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IE.Location = new System.Drawing.Point(442, 33);
            this.lb_IE.Name = "lb_IE";
            this.lb_IE.Size = new System.Drawing.Size(24, 17);
            this.lb_IE.TabIndex = 3;
            this.lb_IE.Text = "I.E:";
            // 
            // lb_CNPJ
            // 
            this.lb_CNPJ.AutoSize = true;
            this.lb_CNPJ.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CNPJ.Location = new System.Drawing.Point(195, 33);
            this.lb_CNPJ.Name = "lb_CNPJ";
            this.lb_CNPJ.Size = new System.Drawing.Size(40, 17);
            this.lb_CNPJ.TabIndex = 4;
            this.lb_CNPJ.Text = "CNPJ:";
            // 
            // lb_NomeFornecedor
            // 
            this.lb_NomeFornecedor.AutoSize = true;
            this.lb_NomeFornecedor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NomeFornecedor.Location = new System.Drawing.Point(18, 91);
            this.lb_NomeFornecedor.Name = "lb_NomeFornecedor";
            this.lb_NomeFornecedor.Size = new System.Drawing.Size(47, 17);
            this.lb_NomeFornecedor.TabIndex = 5;
            this.lb_NomeFornecedor.Text = "Nome:";
            // 
            // FrmAdd_Fornecedor_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_Endereco);
            this.Controls.Add(this.gb_DadosFornecedor);
            this.Name = "FrmAdd_Fornecedor_UC";
            this.Size = new System.Drawing.Size(792, 518);
            this.gb_Endereco.ResumeLayout(false);
            this.gb_Endereco.PerformLayout();
            this.gb_DadosFornecedor.ResumeLayout(false);
            this.gb_DadosFornecedor.PerformLayout();
            this.gb_Contato.ResumeLayout(false);
            this.gb_Contato.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Endereco;
        private System.Windows.Forms.Button btn_BuscarCEP;
        private System.Windows.Forms.TextBox txt_Bairro;
        private System.Windows.Forms.Label lb_Bairro;
        private System.Windows.Forms.TextBox txt_CEP;
        private System.Windows.Forms.Label lb_CEP;
        private System.Windows.Forms.TextBox txt_UF;
        private System.Windows.Forms.Label lb_UF;
        private System.Windows.Forms.Label lb_Cidade;
        private System.Windows.Forms.TextBox txt_Cidade;
        private System.Windows.Forms.TextBox txt_Rua;
        private System.Windows.Forms.Label lb_Rua;
        private System.Windows.Forms.GroupBox gb_DadosFornecedor;
        private System.Windows.Forms.Label lb_Codigo;
        private System.Windows.Forms.GroupBox gb_Contato;
        private System.Windows.Forms.TextBox txt_Celular;
        private System.Windows.Forms.Label lb_Celular;
        private System.Windows.Forms.TextBox txt_Contato;
        private System.Windows.Forms.Label lb_Contato;
        private System.Windows.Forms.TextBox txt_Telefone;
        private System.Windows.Forms.Label lb_Telefone;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Comissao;
        private System.Windows.Forms.TextBox txt_NomeReduzido;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_IE;
        private System.Windows.Forms.TextBox txt_CNPJ;
        private System.Windows.Forms.Label lb_Comissao;
        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.Label lb_NomeReduzido;
        private System.Windows.Forms.Label lb_IE;
        private System.Windows.Forms.Label lb_CNPJ;
        private System.Windows.Forms.Label lb_NomeFornecedor;
    }
}
