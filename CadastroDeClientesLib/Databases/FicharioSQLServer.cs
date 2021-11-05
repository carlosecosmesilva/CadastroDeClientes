using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeClientesLib.Databases
{
   public class FicharioSQLServer
    {
        public string mensagem;
        public bool status;
        public string tabela;
        public SQLServerClass db;

        public FicharioSQLServer(string Tabela)
        {
            status = true;
            try
            {
                db = new SQLServerClass();
                tabela = Tabela;
                mensagem = "Conexão com a Tabela criada com sucesso";
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão com a Tabela com erro: " + ex.Message;
            }
        }

        public void Incluir(string CPF, string jsonUnit)
        {
            status = true;
            try
            {
                // INSERT INTO CLIENTE (CPF, JSON) VALUES ('000.000.000-00','{...}')

                var SQL = "INSERT INTO " + tabela + " (CPF, JSON) VALUES ('" + CPF + "', '" + jsonUnit + "')";
                db.SQLCommand(SQL);
                status = true;
                mensagem = "Inclusão efetuada com sucesso. Identificador: " + CPF;

            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão com o Fichario com erro: " + ex.Message;
            }
        }

        public string Buscar(string CPF)
        {
            status = true;
            try
            {
                // SELECT CPF, JSON FROM CLIENTE WHERE CPF = '000010'

                var SQL = "SELECT CPF, JSON FROM " + tabela + " WHERE CPF = '" + CPF + "'";
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {
                    string conteudo = dt.Rows[0]["JSON"].ToString();
                    status = true;
                    mensagem = "Inclusão efetuada com sucesso. Identificador: " + CPF;
                    return conteudo;
                }
                else
                {
                    status = false;
                    mensagem = "Identificador não existente: " + CPF;
                }

            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar o conteúdo do Identificador: " + ex.Message;
            }
            return "";
        }

        public List<string> BuscarTodos()
        {
            status = true;
            List<string> List = new List<string>();
            try
            {
                // SELECT CPF, JSON FROM CLIENTE'

                var SQL = "SELECT CPF, JSON FROM " + tabela;
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        string conteudo = dt.Rows[i]["JSON"].ToString();
                        List.Add(conteudo);
                    }
                    return List;
                }
                else
                {
                    status = false;
                    mensagem = "Não existem clientes na base de dados";
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar o conteúdo do Identificador: " + ex.Message;
            }
            return List;
        }

        public void Apagar(string CPF)
        {
            status = true;
            try
            {
                var SQL = "SELECT CPF, JSON FROM " + tabela + " WHERE CPF = '" + CPF + "'";
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {

                    // DELETE FROM CLIENTE WHERE CPF = '00010'

                    SQL = "DELETE FROM " + tabela + " WHERE CPF = '" + CPF + "'";
                    db.SQLCommand(SQL);
                    status = true;
                    mensagem = "Inclusão efetuada com sucesso. Identificador: " + CPF;
                }
                else
                {
                    status = false;
                    mensagem = "Identificador não existente: " + CPF;
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar o conteúdo do Identificador: " + ex.Message;
            }
        }

        public void Alterar(string CPF, string jsonUnit)
        {
            status = true;
            try
            {

                var SQL = "SELECT CPF, JSON FROM " + tabela + " WHERE CPF = '" + CPF + "'";
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {

                    // UPDATE CLIENTE SET JSON = '{...}' WHERE CPF = '00010'

                    SQL = "UPDATE " + tabela + " SET JSON = '" + jsonUnit + "' WHERE CPF = '" + CPF + "'";
                    db.SQLCommand(SQL);
                    status = true;
                    mensagem = "Alteração efetuada com sucesso. Identificador: " + CPF;
                }
                else
                {
                    status = false;
                    mensagem = "Alteração não permitida porque o Identificador não existe: " + CPF;
                }

            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão com o Fichario com erro: " + ex.Message;
            }

        }

    }
}
