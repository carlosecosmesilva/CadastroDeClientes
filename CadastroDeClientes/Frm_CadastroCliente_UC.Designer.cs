
namespace CadastroDeClientes
{
    partial class Frm_CadastroCliente_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastroCliente_UC));
            this.Tls_Principal = new System.Windows.Forms.ToolStrip();
            this.incluirtoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.pesquisartoolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.salvartoolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.excluirtoolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.limpartoolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Lbl_CPF = new System.Windows.Forms.Label();
            this.Lbl_DataDeNascimento = new System.Windows.Forms.Label();
            this.Lbl_NomeMae = new System.Windows.Forms.Label();
            this.Lbl_NomePai = new System.Windows.Forms.Label();
            this.Msk_CPF = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.Txt_NomeMae = new System.Windows.Forms.TextBox();
            this.Txt_NomePai = new System.Windows.Forms.TextBox();
            this.Dt_Nascimento = new System.Windows.Forms.DateTimePicker();
            this.Grp_DadosPessoais = new System.Windows.Forms.GroupBox();
            this.Chk_NaoTemPai = new System.Windows.Forms.CheckBox();
            this.Grp_Telefone = new System.Windows.Forms.GroupBox();
            this.Msk_Celular = new System.Windows.Forms.MaskedTextBox();
            this.Grp_Genero = new System.Windows.Forms.GroupBox();
            this.Rdb_Feminino = new System.Windows.Forms.RadioButton();
            this.Rdb_Indefinido = new System.Windows.Forms.RadioButton();
            this.Rdb_Masculino = new System.Windows.Forms.RadioButton();
            this.Grp_Endereco = new System.Windows.Forms.GroupBox();
            this.Txt_CEP = new System.Windows.Forms.TextBox();
            this.Btn_BuscaCEP = new System.Windows.Forms.Button();
            this.Txt_UF = new System.Windows.Forms.TextBox();
            this.Txt_Bairro = new System.Windows.Forms.TextBox();
            this.Txt_Cidade = new System.Windows.Forms.TextBox();
            this.Txt_Complemento = new System.Windows.Forms.TextBox();
            this.Txt_Logradouro = new System.Windows.Forms.TextBox();
            this.Lbl_Bairro = new System.Windows.Forms.Label();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Lbl_Cidade = new System.Windows.Forms.Label();
            this.Lbl_Complemento = new System.Windows.Forms.Label();
            this.Lbl_Logradouro = new System.Windows.Forms.Label();
            this.Lbl_CEP = new System.Windows.Forms.Label();
            this.Grp_DataGrid = new System.Windows.Forms.GroupBox();
            this.Dg_Clientes = new System.Windows.Forms.DataGridView();
            this.Btn_Busca = new System.Windows.Forms.Button();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tls_Principal.SuspendLayout();
            this.Grp_DadosPessoais.SuspendLayout();
            this.Grp_Telefone.SuspendLayout();
            this.Grp_Genero.SuspendLayout();
            this.Grp_Endereco.SuspendLayout();
            this.Grp_DataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // Tls_Principal
            // 
            this.Tls_Principal.AutoSize = false;
            this.Tls_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incluirtoolStripButton1,
            this.pesquisartoolStripButton2,
            this.salvartoolStripButton3,
            this.toolStripSeparator1,
            this.excluirtoolStripButton4,
            this.toolStripSeparator2,
            this.limpartoolStripButton5});
            this.Tls_Principal.Location = new System.Drawing.Point(0, 0);
            this.Tls_Principal.Name = "Tls_Principal";
            this.Tls_Principal.Size = new System.Drawing.Size(708, 40);
            this.Tls_Principal.TabIndex = 0;
            this.Tls_Principal.Text = "toolStrip1";
            // 
            // incluirtoolStripButton1
            // 
            this.incluirtoolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.incluirtoolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("incluirtoolStripButton1.Image")));
            this.incluirtoolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.incluirtoolStripButton1.Name = "incluirtoolStripButton1";
            this.incluirtoolStripButton1.Size = new System.Drawing.Size(23, 37);
            this.incluirtoolStripButton1.Text = "toolStripButton1";
            this.incluirtoolStripButton1.Click += new System.EventHandler(this.incluirtoolStripButton1_Click);
            // 
            // pesquisartoolStripButton2
            // 
            this.pesquisartoolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pesquisartoolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("pesquisartoolStripButton2.Image")));
            this.pesquisartoolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pesquisartoolStripButton2.Name = "pesquisartoolStripButton2";
            this.pesquisartoolStripButton2.Size = new System.Drawing.Size(23, 37);
            this.pesquisartoolStripButton2.Text = "toolStripButton2";
            this.pesquisartoolStripButton2.Click += new System.EventHandler(this.pesquisartoolStripButton2_Click);
            // 
            // salvartoolStripButton3
            // 
            this.salvartoolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvartoolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("salvartoolStripButton3.Image")));
            this.salvartoolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvartoolStripButton3.Name = "salvartoolStripButton3";
            this.salvartoolStripButton3.Size = new System.Drawing.Size(23, 37);
            this.salvartoolStripButton3.Text = "toolStripButton3";
            this.salvartoolStripButton3.Click += new System.EventHandler(this.salvartoolStripButton3_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // excluirtoolStripButton4
            // 
            this.excluirtoolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.excluirtoolStripButton4.Image = global::CadastroDeClientes.Properties.Resources.icons8_remover_usuário_masculino_96;
            this.excluirtoolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.excluirtoolStripButton4.Name = "excluirtoolStripButton4";
            this.excluirtoolStripButton4.Size = new System.Drawing.Size(23, 37);
            this.excluirtoolStripButton4.Text = "toolStripButton4";
            this.excluirtoolStripButton4.Click += new System.EventHandler(this.excluirtoolStripButton4_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // limpartoolStripButton5
            // 
            this.limpartoolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.limpartoolStripButton5.Image = global::CadastroDeClientes.Properties.Resources.icons8_limpar_pesquisa_96;
            this.limpartoolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.limpartoolStripButton5.Name = "limpartoolStripButton5";
            this.limpartoolStripButton5.Size = new System.Drawing.Size(23, 37);
            this.limpartoolStripButton5.Text = "toolStripButton5";
            this.limpartoolStripButton5.Click += new System.EventHandler(this.limpartoolStripButton5_Click);
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.Location = new System.Drawing.Point(6, 68);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Nome.TabIndex = 1;
            this.Lbl_Nome.Text = "Nome";
            // 
            // Lbl_CPF
            // 
            this.Lbl_CPF.AutoSize = true;
            this.Lbl_CPF.Location = new System.Drawing.Point(6, 39);
            this.Lbl_CPF.Name = "Lbl_CPF";
            this.Lbl_CPF.Size = new System.Drawing.Size(27, 13);
            this.Lbl_CPF.TabIndex = 2;
            this.Lbl_CPF.Text = "CPF";
            // 
            // Lbl_DataDeNascimento
            // 
            this.Lbl_DataDeNascimento.AutoSize = true;
            this.Lbl_DataDeNascimento.Location = new System.Drawing.Point(153, 39);
            this.Lbl_DataDeNascimento.Name = "Lbl_DataDeNascimento";
            this.Lbl_DataDeNascimento.Size = new System.Drawing.Size(104, 13);
            this.Lbl_DataDeNascimento.TabIndex = 3;
            this.Lbl_DataDeNascimento.Text = "Data de Nascimento";
            // 
            // Lbl_NomeMae
            // 
            this.Lbl_NomeMae.AutoSize = true;
            this.Lbl_NomeMae.Location = new System.Drawing.Point(6, 97);
            this.Lbl_NomeMae.Name = "Lbl_NomeMae";
            this.Lbl_NomeMae.Size = new System.Drawing.Size(74, 13);
            this.Lbl_NomeMae.TabIndex = 4;
            this.Lbl_NomeMae.Text = "Nome da Mãe";
            // 
            // Lbl_NomePai
            // 
            this.Lbl_NomePai.AutoSize = true;
            this.Lbl_NomePai.Location = new System.Drawing.Point(6, 127);
            this.Lbl_NomePai.Name = "Lbl_NomePai";
            this.Lbl_NomePai.Size = new System.Drawing.Size(68, 13);
            this.Lbl_NomePai.TabIndex = 5;
            this.Lbl_NomePai.Text = "Nome do Pai";
            // 
            // Msk_CPF
            // 
            this.Msk_CPF.Location = new System.Drawing.Point(47, 36);
            this.Msk_CPF.Mask = "000.000.000-00";
            this.Msk_CPF.Name = "Msk_CPF";
            this.Msk_CPF.Size = new System.Drawing.Size(89, 20);
            this.Msk_CPF.TabIndex = 6;
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Location = new System.Drawing.Point(47, 65);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(397, 20);
            this.Txt_Nome.TabIndex = 7;
            // 
            // Txt_NomeMae
            // 
            this.Txt_NomeMae.Location = new System.Drawing.Point(82, 94);
            this.Txt_NomeMae.Name = "Txt_NomeMae";
            this.Txt_NomeMae.Size = new System.Drawing.Size(362, 20);
            this.Txt_NomeMae.TabIndex = 8;
            // 
            // Txt_NomePai
            // 
            this.Txt_NomePai.Location = new System.Drawing.Point(82, 124);
            this.Txt_NomePai.Name = "Txt_NomePai";
            this.Txt_NomePai.Size = new System.Drawing.Size(362, 20);
            this.Txt_NomePai.TabIndex = 9;
            // 
            // Dt_Nascimento
            // 
            this.Dt_Nascimento.Location = new System.Drawing.Point(263, 36);
            this.Dt_Nascimento.Name = "Dt_Nascimento";
            this.Dt_Nascimento.Size = new System.Drawing.Size(181, 20);
            this.Dt_Nascimento.TabIndex = 10;
            // 
            // Grp_DadosPessoais
            // 
            this.Grp_DadosPessoais.Controls.Add(this.Chk_NaoTemPai);
            this.Grp_DadosPessoais.Controls.Add(this.Grp_Telefone);
            this.Grp_DadosPessoais.Controls.Add(this.Txt_NomePai);
            this.Grp_DadosPessoais.Controls.Add(this.Grp_Genero);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_Nome);
            this.Grp_DadosPessoais.Controls.Add(this.Txt_NomeMae);
            this.Grp_DadosPessoais.Controls.Add(this.Dt_Nascimento);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_NomePai);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_CPF);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_NomeMae);
            this.Grp_DadosPessoais.Controls.Add(this.Msk_CPF);
            this.Grp_DadosPessoais.Controls.Add(this.Txt_Nome);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_DataDeNascimento);
            this.Grp_DadosPessoais.Location = new System.Drawing.Point(6, 44);
            this.Grp_DadosPessoais.Name = "Grp_DadosPessoais";
            this.Grp_DadosPessoais.Size = new System.Drawing.Size(681, 184);
            this.Grp_DadosPessoais.TabIndex = 11;
            this.Grp_DadosPessoais.TabStop = false;
            this.Grp_DadosPessoais.Text = "Dados Pessoais";
            // 
            // Chk_NaoTemPai
            // 
            this.Chk_NaoTemPai.AutoSize = true;
            this.Chk_NaoTemPai.Location = new System.Drawing.Point(9, 157);
            this.Chk_NaoTemPai.Name = "Chk_NaoTemPai";
            this.Chk_NaoTemPai.Size = new System.Drawing.Size(84, 17);
            this.Chk_NaoTemPai.TabIndex = 14;
            this.Chk_NaoTemPai.Text = "Não tem Pai";
            this.Chk_NaoTemPai.UseVisualStyleBackColor = true;
            this.Chk_NaoTemPai.CheckedChanged += new System.EventHandler(this.Chk_NaoTemPai_CheckedChanged);
            // 
            // Grp_Telefone
            // 
            this.Grp_Telefone.Controls.Add(this.Msk_Celular);
            this.Grp_Telefone.Location = new System.Drawing.Point(463, 26);
            this.Grp_Telefone.Name = "Grp_Telefone";
            this.Grp_Telefone.Size = new System.Drawing.Size(181, 55);
            this.Grp_Telefone.TabIndex = 13;
            this.Grp_Telefone.TabStop = false;
            this.Grp_Telefone.Text = "Celular";
            // 
            // Msk_Celular
            // 
            this.Msk_Celular.Location = new System.Drawing.Point(7, 19);
            this.Msk_Celular.Mask = "(99) 00000-0000";
            this.Msk_Celular.Name = "Msk_Celular";
            this.Msk_Celular.Size = new System.Drawing.Size(133, 20);
            this.Msk_Celular.TabIndex = 0;
            // 
            // Grp_Genero
            // 
            this.Grp_Genero.Controls.Add(this.Rdb_Feminino);
            this.Grp_Genero.Controls.Add(this.Rdb_Indefinido);
            this.Grp_Genero.Controls.Add(this.Rdb_Masculino);
            this.Grp_Genero.Location = new System.Drawing.Point(463, 87);
            this.Grp_Genero.Name = "Grp_Genero";
            this.Grp_Genero.Size = new System.Drawing.Size(181, 87);
            this.Grp_Genero.TabIndex = 11;
            this.Grp_Genero.TabStop = false;
            this.Grp_Genero.Text = "Gênero";
            // 
            // Rdb_Feminino
            // 
            this.Rdb_Feminino.AutoSize = true;
            this.Rdb_Feminino.Location = new System.Drawing.Point(90, 20);
            this.Rdb_Feminino.Name = "Rdb_Feminino";
            this.Rdb_Feminino.Size = new System.Drawing.Size(85, 17);
            this.Rdb_Feminino.TabIndex = 2;
            this.Rdb_Feminino.TabStop = true;
            this.Rdb_Feminino.Text = "radioButton1";
            this.Rdb_Feminino.UseVisualStyleBackColor = true;
            // 
            // Rdb_Indefinido
            // 
            this.Rdb_Indefinido.AutoSize = true;
            this.Rdb_Indefinido.Location = new System.Drawing.Point(7, 50);
            this.Rdb_Indefinido.Name = "Rdb_Indefinido";
            this.Rdb_Indefinido.Size = new System.Drawing.Size(85, 17);
            this.Rdb_Indefinido.TabIndex = 1;
            this.Rdb_Indefinido.TabStop = true;
            this.Rdb_Indefinido.Text = "radioButton1";
            this.Rdb_Indefinido.UseVisualStyleBackColor = true;
            // 
            // Rdb_Masculino
            // 
            this.Rdb_Masculino.AutoSize = true;
            this.Rdb_Masculino.Location = new System.Drawing.Point(7, 20);
            this.Rdb_Masculino.Name = "Rdb_Masculino";
            this.Rdb_Masculino.Size = new System.Drawing.Size(85, 17);
            this.Rdb_Masculino.TabIndex = 0;
            this.Rdb_Masculino.TabStop = true;
            this.Rdb_Masculino.Text = "radioButton1";
            this.Rdb_Masculino.UseVisualStyleBackColor = true;
            // 
            // Grp_Endereco
            // 
            this.Grp_Endereco.Controls.Add(this.Txt_CEP);
            this.Grp_Endereco.Controls.Add(this.Btn_BuscaCEP);
            this.Grp_Endereco.Controls.Add(this.Txt_UF);
            this.Grp_Endereco.Controls.Add(this.Txt_Bairro);
            this.Grp_Endereco.Controls.Add(this.Txt_Cidade);
            this.Grp_Endereco.Controls.Add(this.Txt_Complemento);
            this.Grp_Endereco.Controls.Add(this.Txt_Logradouro);
            this.Grp_Endereco.Controls.Add(this.Lbl_Bairro);
            this.Grp_Endereco.Controls.Add(this.Lbl_Estado);
            this.Grp_Endereco.Controls.Add(this.Lbl_Cidade);
            this.Grp_Endereco.Controls.Add(this.Lbl_Complemento);
            this.Grp_Endereco.Controls.Add(this.Lbl_Logradouro);
            this.Grp_Endereco.Controls.Add(this.Lbl_CEP);
            this.Grp_Endereco.Location = new System.Drawing.Point(6, 244);
            this.Grp_Endereco.Name = "Grp_Endereco";
            this.Grp_Endereco.Size = new System.Drawing.Size(681, 121);
            this.Grp_Endereco.TabIndex = 12;
            this.Grp_Endereco.TabStop = false;
            this.Grp_Endereco.Text = "Dados de Endereço";
            // 
            // Txt_CEP
            // 
            this.Txt_CEP.Location = new System.Drawing.Point(40, 22);
            this.Txt_CEP.Name = "Txt_CEP";
            this.Txt_CEP.Size = new System.Drawing.Size(96, 20);
            this.Txt_CEP.TabIndex = 17;
            // 
            // Btn_BuscaCEP
            // 
            this.Btn_BuscaCEP.Location = new System.Drawing.Point(156, 20);
            this.Btn_BuscaCEP.Name = "Btn_BuscaCEP";
            this.Btn_BuscaCEP.Size = new System.Drawing.Size(75, 23);
            this.Btn_BuscaCEP.TabIndex = 16;
            this.Btn_BuscaCEP.Text = "Localizar";
            this.Btn_BuscaCEP.UseVisualStyleBackColor = true;
            this.Btn_BuscaCEP.Click += new System.EventHandler(this.Btn_BuscaCEP_Click);
            // 
            // Txt_UF
            // 
            this.Txt_UF.Location = new System.Drawing.Point(403, 20);
            this.Txt_UF.Name = "Txt_UF";
            this.Txt_UF.Size = new System.Drawing.Size(41, 20);
            this.Txt_UF.TabIndex = 15;
            // 
            // Txt_Bairro
            // 
            this.Txt_Bairro.Location = new System.Drawing.Point(403, 52);
            this.Txt_Bairro.Name = "Txt_Bairro";
            this.Txt_Bairro.Size = new System.Drawing.Size(242, 20);
            this.Txt_Bairro.TabIndex = 14;
            // 
            // Txt_Cidade
            // 
            this.Txt_Cidade.Location = new System.Drawing.Point(403, 83);
            this.Txt_Cidade.Name = "Txt_Cidade";
            this.Txt_Cidade.Size = new System.Drawing.Size(242, 20);
            this.Txt_Cidade.TabIndex = 13;
            // 
            // Txt_Complemento
            // 
            this.Txt_Complemento.Location = new System.Drawing.Point(75, 83);
            this.Txt_Complemento.Name = "Txt_Complemento";
            this.Txt_Complemento.Size = new System.Drawing.Size(267, 20);
            this.Txt_Complemento.TabIndex = 12;
            // 
            // Txt_Logradouro
            // 
            this.Txt_Logradouro.Location = new System.Drawing.Point(68, 52);
            this.Txt_Logradouro.Name = "Txt_Logradouro";
            this.Txt_Logradouro.Size = new System.Drawing.Size(274, 20);
            this.Txt_Logradouro.TabIndex = 11;
            // 
            // Lbl_Bairro
            // 
            this.Lbl_Bairro.AutoSize = true;
            this.Lbl_Bairro.Location = new System.Drawing.Point(362, 55);
            this.Lbl_Bairro.Name = "Lbl_Bairro";
            this.Lbl_Bairro.Size = new System.Drawing.Size(34, 13);
            this.Lbl_Bairro.TabIndex = 6;
            this.Lbl_Bairro.Text = "Bairro";
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Location = new System.Drawing.Point(362, 23);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(40, 13);
            this.Lbl_Estado.TabIndex = 5;
            this.Lbl_Estado.Text = "Estado";
            // 
            // Lbl_Cidade
            // 
            this.Lbl_Cidade.AutoSize = true;
            this.Lbl_Cidade.Location = new System.Drawing.Point(362, 86);
            this.Lbl_Cidade.Name = "Lbl_Cidade";
            this.Lbl_Cidade.Size = new System.Drawing.Size(40, 13);
            this.Lbl_Cidade.TabIndex = 4;
            this.Lbl_Cidade.Text = "Cidade";
            // 
            // Lbl_Complemento
            // 
            this.Lbl_Complemento.AutoSize = true;
            this.Lbl_Complemento.Location = new System.Drawing.Point(6, 86);
            this.Lbl_Complemento.Name = "Lbl_Complemento";
            this.Lbl_Complemento.Size = new System.Drawing.Size(71, 13);
            this.Lbl_Complemento.TabIndex = 3;
            this.Lbl_Complemento.Text = "Complemento";
            // 
            // Lbl_Logradouro
            // 
            this.Lbl_Logradouro.AutoSize = true;
            this.Lbl_Logradouro.Location = new System.Drawing.Point(6, 55);
            this.Lbl_Logradouro.Name = "Lbl_Logradouro";
            this.Lbl_Logradouro.Size = new System.Drawing.Size(61, 13);
            this.Lbl_Logradouro.TabIndex = 2;
            this.Lbl_Logradouro.Text = "Logradouro";
            // 
            // Lbl_CEP
            // 
            this.Lbl_CEP.AutoSize = true;
            this.Lbl_CEP.Location = new System.Drawing.Point(6, 26);
            this.Lbl_CEP.Name = "Lbl_CEP";
            this.Lbl_CEP.Size = new System.Drawing.Size(28, 13);
            this.Lbl_CEP.TabIndex = 0;
            this.Lbl_CEP.Text = "CEP";
            // 
            // Grp_DataGrid
            // 
            this.Grp_DataGrid.Controls.Add(this.Dg_Clientes);
            this.Grp_DataGrid.Location = new System.Drawing.Point(6, 372);
            this.Grp_DataGrid.Name = "Grp_DataGrid";
            this.Grp_DataGrid.Size = new System.Drawing.Size(681, 231);
            this.Grp_DataGrid.TabIndex = 13;
            this.Grp_DataGrid.TabStop = false;
            this.Grp_DataGrid.Text = "Grid";
            // 
            // Dg_Clientes
            // 
            this.Dg_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CPF,
            this.Nome});
            this.Dg_Clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dg_Clientes.Location = new System.Drawing.Point(3, 16);
            this.Dg_Clientes.Name = "Dg_Clientes";
            this.Dg_Clientes.Size = new System.Drawing.Size(675, 212);
            this.Dg_Clientes.TabIndex = 0;
            // 
            // Btn_Busca
            // 
            this.Btn_Busca.Location = new System.Drawing.Point(147, 10);
            this.Btn_Busca.Name = "Btn_Busca";
            this.Btn_Busca.Size = new System.Drawing.Size(75, 23);
            this.Btn_Busca.TabIndex = 15;
            this.Btn_Busca.Text = "button1";
            this.Btn_Busca.UseVisualStyleBackColor = true;
            this.Btn_Busca.Click += new System.EventHandler(this.Btn_Busca_Click);
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF do Cliente";
            this.CPF.Name = "CPF";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome do Cliente";
            this.Nome.Name = "Nome";
            this.Nome.Width = 300;
            // 
            // Frm_CadastroCliente_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.Btn_Busca);
            this.Controls.Add(this.Grp_DataGrid);
            this.Controls.Add(this.Grp_Endereco);
            this.Controls.Add(this.Grp_DadosPessoais);
            this.Controls.Add(this.Tls_Principal);
            this.Name = "Frm_CadastroCliente_UC";
            this.Size = new System.Drawing.Size(708, 653);
            this.Tls_Principal.ResumeLayout(false);
            this.Tls_Principal.PerformLayout();
            this.Grp_DadosPessoais.ResumeLayout(false);
            this.Grp_DadosPessoais.PerformLayout();
            this.Grp_Telefone.ResumeLayout(false);
            this.Grp_Telefone.PerformLayout();
            this.Grp_Genero.ResumeLayout(false);
            this.Grp_Genero.PerformLayout();
            this.Grp_Endereco.ResumeLayout(false);
            this.Grp_Endereco.PerformLayout();
            this.Grp_DataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Clientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip Tls_Principal;
        private System.Windows.Forms.ToolStripButton incluirtoolStripButton1;
        private System.Windows.Forms.ToolStripButton pesquisartoolStripButton2;
        private System.Windows.Forms.ToolStripButton salvartoolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton excluirtoolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton limpartoolStripButton5;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.Label Lbl_CPF;
        private System.Windows.Forms.Label Lbl_DataDeNascimento;
        private System.Windows.Forms.Label Lbl_NomeMae;
        private System.Windows.Forms.Label Lbl_NomePai;
        private System.Windows.Forms.MaskedTextBox Msk_CPF;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.TextBox Txt_NomeMae;
        private System.Windows.Forms.TextBox Txt_NomePai;
        private System.Windows.Forms.DateTimePicker Dt_Nascimento;
        private System.Windows.Forms.GroupBox Grp_DadosPessoais;
        private System.Windows.Forms.GroupBox Grp_Genero;
        private System.Windows.Forms.RadioButton Rdb_Feminino;
        private System.Windows.Forms.RadioButton Rdb_Indefinido;
        private System.Windows.Forms.RadioButton Rdb_Masculino;
        private System.Windows.Forms.GroupBox Grp_Endereco;
        private System.Windows.Forms.Label Lbl_Bairro;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.Label Lbl_Cidade;
        private System.Windows.Forms.Label Lbl_Complemento;
        private System.Windows.Forms.Label Lbl_Logradouro;
        private System.Windows.Forms.Label Lbl_CEP;
        private System.Windows.Forms.CheckBox Chk_NaoTemPai;
        private System.Windows.Forms.GroupBox Grp_Telefone;
        private System.Windows.Forms.MaskedTextBox Msk_Celular;
        private System.Windows.Forms.TextBox Txt_Bairro;
        private System.Windows.Forms.TextBox Txt_Cidade;
        private System.Windows.Forms.TextBox Txt_Complemento;
        private System.Windows.Forms.TextBox Txt_Logradouro;
        private System.Windows.Forms.TextBox Txt_UF;
        private System.Windows.Forms.Button Btn_BuscaCEP;
        private System.Windows.Forms.TextBox Txt_CEP;
        private System.Windows.Forms.GroupBox Grp_DataGrid;
        private System.Windows.Forms.DataGridView Dg_Clientes;
        private System.Windows.Forms.Button Btn_Busca;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    }
}
