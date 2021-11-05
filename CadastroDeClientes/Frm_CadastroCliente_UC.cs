using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadastroDeClientesLib;
using CadastroDeClientesLib.Classes;
using CadastroDeClientesLib.Fichario;
using CadastroDeClientesLib.Databases;
using Microsoft.VisualBasic;

namespace CadastroDeClientes
{
    public partial class Frm_CadastroCliente_UC : UserControl
    {
        public Frm_CadastroCliente_UC()
        {
            InitializeComponent();

            Tls_Principal.Items[0].ToolTipText = "Incluir na base de dados um novo cliente";
            Tls_Principal.Items[1].ToolTipText = "Pesquisa de um cliente já cadastrado na base";
            Tls_Principal.Items[2].ToolTipText = "Salva alteração de cliente já existente";
            Tls_Principal.Items[4].ToolTipText = "Apaga o cliente selecionado";
            Tls_Principal.Items[6].ToolTipText = "Limpar dados da tela de cadastro de clientes";

            Msk_CPF.Mask = "000,000,000-00";
            Msk_Data.Mask = "00/00/0000";

            Grp_DadosPessoais.Text = "Dados Pessoais";
            Lbl_CPF.Text = "CPF";
            Lbl_DataDeNascimento.Text = "Data de Nascimento";
            Lbl_Nome.Text = "Nome";
            Lbl_NomeMae.Text = "Nome da Mãe";
            Lbl_NomePai.Text = "Nome do Pai";
            Chk_NaoTemPai.Text = "Não Informado";
            Grp_Telefone.Text = "Telefone";
            Grp_Genero.Text = "Genero";
            Rdb_Masculino.Text = "Masculino";
            Rdb_Feminino.Text = "Feminino";
            Rdb_Indefinido.Text = "Indefinido";

            Grp_Endereco.Text = "Dados de Endereço";
            Lbl_CEP.Text = "CEP";
            Lbl_Cidade.Text = "Cidade";
            Lbl_Bairro.Text = "Bairro";
            Lbl_Complemento.Text = "Complemento";
            Lbl_Logradouro.Text = "Logradouro";
            Lbl_Estado.Text = "Estado";

            Btn_Busca.Text = "Buscar Clientes";
            Grp_DataGrid.Text = "Clientes";

            LimparFormulario();
            AtualizaGrid();
        }

        private void LimparFormulario()
        {
            Txt_Bairro.Text = " ";
            Txt_CEP.Text = " ";
            Txt_Complemento.Text = " ";
            Msk_CPF.Text = " ";
            Txt_UF.Text = "";
            Txt_Logradouro.Text = " ";
            Txt_Nome.Text = " ";
            Txt_NomeMae.Text = " ";
            Txt_NomePai.Text = " ";
            Msk_Celular.Text = " ";
            Txt_Cidade.Text = " ";
            Msk_Data.Text = " ";
            Chk_NaoTemPai.Checked = false;
            Rdb_Indefinido.Checked = true;
        }

        private void Chk_NaoTemPai_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_NaoTemPai.Checked)
            {
                Txt_NomePai.Enabled = false;
            }
            else
            {
                Txt_NomePai.Enabled = true;
            }
        }

        private void incluirtoolStripButton1_Click(object sender, EventArgs e)
        {

            try
            {

                Cliente.Unit C = new Cliente.Unit();
                C = LeituraFormulario();
                C.ValidaClasse();
                C.ValidaComplemento();
                //C.IncluirFichario("C:\\WindowsForms\\Curso\\CursoWindowsForms\\Fichario");
                C.IncluirFicharioSQLServer("CLIENTES");
                MessageBox.Show("OK: Cliente incluido com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizaGrid();
            }
            catch (ValidationException Ex)
            {
                MessageBox.Show(Ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pesquisartoolStripButton2_Click(object sender, EventArgs e)
        {
            if (Msk_CPF.Text == "")
            {
                MessageBox.Show("CPF do Cliente vazio.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Cliente.Unit C = new Cliente.Unit();
                    C = C.BuscarFicharioSQLServer(Msk_CPF.Text, "CLIENTES");
                    if (C == null)
                    {
                        MessageBox.Show("CPF não encontrado.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        EscreveFormulario(C);
                    }

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void salvartoolStripButton3_Click(object sender, EventArgs e)
        {
            if (Msk_CPF.Text == "")
            {
                MessageBox.Show("CPF do Cliente vazio.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Cliente.Unit C = new Cliente.Unit();
                    C = LeituraFormulario();
                    C.ValidaClasse();
                    C.ValidaComplemento();
                    //C.AlterarFichario("C:\\WindowsForms\\Curso\\CursoWindowsForms\\Fichario");
                    C.AlterarFicharioSQLServer("CLIENTES");
                    MessageBox.Show("OK: Cliente alterado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizaGrid();
                }
                catch (ValidationException Ex)
                {
                    MessageBox.Show(Ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void excluirtoolStripButton4_Click(object sender, EventArgs e)
        {
            if (Msk_CPF.Text == "")
            {
                MessageBox.Show("CPF do Cliente vazio.", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Cliente.Unit C = new Cliente.Unit();
                    C = C.BuscarFicharioSQLServer(Msk_CPF.Text, "CLIENTES");
                    if (C == null)
                    {
                        MessageBox.Show("CPF não encontrado.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        EscreveFormulario(C);
                        Frm_Questao Db = new Frm_Questao("question message", "Você quer excluir o cliente?");
                        Db.ShowDialog();
                        if (Db.DialogResult == DialogResult.Yes)
                        {
                            C.ApagarFicharioSQLServer("CLIENTES");
                            MessageBox.Show("OK: Cliente apagado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AtualizaGrid();
                            LimparFormulario();
                        }
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void limpartoolStripButton5_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        Cliente.Unit LeituraFormulario()
        {
            Cliente.Unit C = new Cliente.Unit();
            C.Nome = Txt_Nome.Text;
            C.NomeMae = Txt_NomeMae.Text;
            C.NomePai = Txt_NomePai.Text;

            if (Chk_NaoTemPai.Checked)
            {
                C.NaoTemPai = true;
            }
            else
            {
                C.NaoTemPai = false;
            }
            if (Rdb_Masculino.Checked)
            {
                C.Genero = 0;
            }
            if (Rdb_Feminino.Checked)
            {
                C.Genero = 1;
            }
            if (Rdb_Indefinido.Checked)
            {
                C.Genero = 2;
            }

            C.Data = Msk_Data.Text;
            C.Cpf = Msk_CPF.Text;
            C.Cep = Txt_CEP.Text;
            C.Logradouro = Txt_Logradouro.Text;
            C.Cidade = Txt_Cidade.Text;
            C.Complemento = Txt_Complemento.Text;
            C.Bairro = Txt_Bairro.Text;
            C.Estado = Txt_UF.Text;

            C.Telefone = Msk_Celular.Text;

            return C;
        }
        void EscreveFormulario(Cliente.Unit C)
        {
            Txt_Nome.Text = C.Nome;
            Txt_NomeMae.Text = C.NomeMae;

            if (C.NaoTemPai == true)
            {
                Chk_NaoTemPai.Checked = true;
                Txt_NomePai.Text = "";
            }
            else
            {
                Chk_NaoTemPai.Checked = false;
                Txt_NomePai.Text = C.NomePai;
            }

            if (C.Genero == 0)
            {
                Rdb_Masculino.Checked = true;
            }
            if (C.Genero == 1)
            {
                Rdb_Feminino.Checked = true;
            }
            if (C.Genero == 2)
            {
                Rdb_Indefinido.Checked = true;
            }

            Msk_Data.Text = C.Data;
            Msk_CPF.Text = C.Cpf;
            Txt_CEP.Text = C.Cep;
            Txt_Logradouro.Text = C.Logradouro;
            Txt_Cidade.Text = C.Cidade;
            Txt_Complemento.Text = C.Complemento;
            Txt_Bairro.Text = C.Bairro;
            Msk_Celular.Text = C.Telefone;
            Txt_UF.Text = C.Estado;

        }

        private void Btn_BuscaCEP_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + Txt_CEP.Text + "/json/");
            request.AllowAutoRedirect = false;
            HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

            if (ChecaServidor.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show("Erro na requisição: " + ChecaServidor.StatusCode.ToString());
                return; // Encerra o códigoz
            }

            using (Stream webStream = ChecaServidor.GetResponseStream())
            {
                if (webStream != null)
                {
                    using (StreamReader responseReader = new StreamReader(webStream))
                    {
                        String response = responseReader.ReadToEnd();
                        response = Regex.Replace(response, "[{},]", string.Empty);
                        response = response.Replace("\"", "");
                        MessageBox.Show(response);

                        String[] substrings = response.Split('\n');

                        int cont = 0;
                        foreach (var substring in substrings)
                        {
                            // CEP
                            if (cont == 1)
                            {
                                string[] valor = substring.Split(':');
                                Txt_CEP.Text = valor[1].ToString();
                            }
                            // Logradouro
                            if (cont == 2)
                            {
                                string[] valor = substring.Split(':');
                                Txt_Logradouro.Text = valor[1].ToString();
                            }
                            // Bairro
                            if (cont == 4)
                            {
                                string[] valor = substring.Split(':');
                                Txt_Bairro.Text = valor[1].ToString();
                            }
                            // Cidade
                            if (cont == 5)
                            {
                                string[] valor = substring.Split(':');
                                Txt_Cidade.Text = valor[1].ToString();
                            }
                            // UF
                            if (cont == 6)
                            {
                                string[] valor = substring.Split(':');
                                Txt_UF.Text = valor[1].ToString();
                            }
                            cont++;
                        }
                    }
                }
            }
        }

        private void Btn_Busca_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente.Unit C = new Cliente.Unit();
                //var ListaBusca = C.BuscarFicharioTodos("E:\\Cursos-Apostilas\\Alura\\.NET\\Windows Forms\\CursoWindowsForms");
                var ListaBusca = C.BuscarFicharioSQLServerTodosDB("CLIENTES");
                Frm_Busca FForm = new Frm_Busca(ListaBusca);
                FForm.ShowDialog();
                if (FForm.DialogResult == DialogResult.OK)
                {
                    var idSelect = FForm.idSelect;
                    //C = C.BuscarFichario(idSelect, "E:\\Cursos-Apostilas\\Alura\\.NET\\Windows Forms\\CursoWindowsForms");
                    C = C.BuscarFicharioSQLServer(idSelect, "CLIENTES");
                    if (C == null)
                    {
                        MessageBox.Show("Identificador não encontrado.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        EscreveFormulario(C);
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AtualizaGrid()
        {
            try
            {
                Cliente.Unit C = new Cliente.Unit();
                //var ListaBusca = C.BuscarFicharioTodos("C:\\WindowsForms\\Curso\\CursoWindowsForms\\Fichario");
                //var ListaBusca = C.BuscarFicharioDBTodosDB("Cliente");
                //var ListaBusca = C.BuscarFicharioDBTodosSQL("Cliente");
                var ListaBusca = C.BuscarFicharioSQLServerTodosDB("CLIENTES");
                Dg_Clientes.Rows.Clear();
                for (int i = 0; i <= ListaBusca.Count - 1; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(Dg_Clientes);
                    row.Cells[0].Value = ListaBusca[i][0].ToString();
                    row.Cells[1].Value = ListaBusca[i][1].ToString();
                    Dg_Clientes.Rows.Add(row);
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
