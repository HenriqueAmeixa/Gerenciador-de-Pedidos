
namespace Gerenciador_de_Pedidos.Adicionar
{
    partial class FrmAdd_Fornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbc_Fornecedor = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // tbc_Fornecedor
            // 
            this.tbc_Fornecedor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbc_Fornecedor.Location = new System.Drawing.Point(23, 78);
            this.tbc_Fornecedor.Name = "tbc_Fornecedor";
            this.tbc_Fornecedor.SelectedIndex = 0;
            this.tbc_Fornecedor.Size = new System.Drawing.Size(887, 686);
            this.tbc_Fornecedor.TabIndex = 0;
            // 
            // FrmAddFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 790);
            this.Controls.Add(this.tbc_Fornecedor);
            this.Name = "FrmAddFornecedor";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmAddFornecedor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_Fornecedor;
    }
}