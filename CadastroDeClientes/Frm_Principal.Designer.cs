
namespace CadastroDeClientes
{
    partial class Frm_Principal
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroGeralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incluirClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tbc_Aplicacoes = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroGeralToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroGeralToolStripMenuItem
            // 
            this.cadastroGeralToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem});
            this.cadastroGeralToolStripMenuItem.Image = global::CadastroDeClientes.Properties.Resources.Cadastros;
            this.cadastroGeralToolStripMenuItem.Name = "cadastroGeralToolStripMenuItem";
            this.cadastroGeralToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.cadastroGeralToolStripMenuItem.Text = "Cadastro Geral";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incluirClienteToolStripMenuItem,
            this.fecharCadastroToolStripMenuItem});
            this.clientesToolStripMenuItem.Image = global::CadastroDeClientes.Properties.Resources.user;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // incluirClienteToolStripMenuItem
            // 
            this.incluirClienteToolStripMenuItem.Image = global::CadastroDeClientes.Properties.Resources.icons8_adicionar_usuário_masculino_96;
            this.incluirClienteToolStripMenuItem.Name = "incluirClienteToolStripMenuItem";
            this.incluirClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.incluirClienteToolStripMenuItem.Text = "Incluir Cliente";
            this.incluirClienteToolStripMenuItem.Click += new System.EventHandler(this.incluirClienteToolStripMenuItem_Click);
            // 
            // fecharCadastroToolStripMenuItem
            // 
            this.fecharCadastroToolStripMenuItem.Image = global::CadastroDeClientes.Properties.Resources.icons8_fechar_janela_96;
            this.fecharCadastroToolStripMenuItem.Name = "fecharCadastroToolStripMenuItem";
            this.fecharCadastroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fecharCadastroToolStripMenuItem.Text = "Fechar Cadastro";
            this.fecharCadastroToolStripMenuItem.Click += new System.EventHandler(this.fecharCadastroToolStripMenuItem_Click);
            // 
            // Tbc_Aplicacoes
            // 
            this.Tbc_Aplicacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbc_Aplicacoes.Location = new System.Drawing.Point(0, 24);
            this.Tbc_Aplicacoes.Name = "Tbc_Aplicacoes";
            this.Tbc_Aplicacoes.SelectedIndex = 0;
            this.Tbc_Aplicacoes.Size = new System.Drawing.Size(800, 426);
            this.Tbc_Aplicacoes.TabIndex = 1;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tbc_Aplicacoes);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroGeralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incluirClienteToolStripMenuItem;
        private System.Windows.Forms.TabControl Tbc_Aplicacoes;
        private System.Windows.Forms.ToolStripMenuItem fecharCadastroToolStripMenuItem;
    }
}

