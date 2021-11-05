using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeClientesLib.Fichario
{
    public class Fichario
    {
        public string diretorio;
        public string mensagem;
        public bool status;

        public Fichario(string Diretorio)
        {
            status = true;
            try
            {
                if (!(Directory.Exists(Diretorio)))
                {
                    Directory.CreateDirectory(Diretorio);
                }
                diretorio = Diretorio;
                mensagem = "Conexão com o Fichario criada com sucesso.";
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão com o Fichario com erro: " + ex.Message;
            }
        }

        public void Incluir(string Cpf, string jsonUnit)
        {
            status = true;
            try
            {
                if (File.Exists(diretorio + "\\" + Cpf + ".json"))
                {
                    status = false;
                    mensagem = "Inclusão não permitida porque o indentificador já existe: " + Cpf;
                }
                else
                {
                    File.WriteAllText(diretorio + "\\" + Cpf + ".json", jsonUnit);
                    status = true;
                    mensagem = "Inclusão efetuada com sucesso. Identificador: " + Cpf;
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão com o Fichario com erro: " + ex.Message;
            }
        }

        public string Buscar(string Cpf)
        {
            status = true;
            try
            {
                if (!(File.Exists(diretorio + "\\" + Cpf + ".json")))
                {
                    status = false;
                    mensagem = "Inclusão não permitida porque o indentificador já existe: " + Cpf;
                }
                else
                {
                    string conteudo = File.ReadAllText(diretorio + "\\" + Cpf + ".json");
                    status = true;
                    mensagem = "Inclusão efetuada com sucesso. Identificador: " + Cpf;
                    return conteudo;
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar conteudo com o identificador: " + ex.Message;
            }
            return "";
        }

        public void Apagar(string Cpf)
        {
            status = true;
            try
            {
                if (!(File.Exists(diretorio + "\\" + Cpf + ".json")))
                {
                    status = false;
                    mensagem = "Indentificador não existe: " + Cpf;
                }
                else
                {
                    File.Delete(diretorio + "\\" + Cpf + ".json");
                    status = true;
                    mensagem = "Exclusão efetuada com sucesso. Identificador: " + Cpf;

                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar conteudo com o identificador: " + ex.Message;
            }
        }
        public void Alterar(string Cpf, string jsonUnit)
        {
            status = true;
            try
            {
                if (!(File.Exists(diretorio + "\\" + Cpf + ".json")))
                {
                    status = false;
                    mensagem = "Alteração não permitida porque o indentificador não existe: " + Cpf;
                }
                else
                {
                    File.Delete(diretorio + "\\" + Cpf + ".json");
                    File.WriteAllText(diretorio + "\\" + Cpf + ".json", jsonUnit);
                    status = true;
                    mensagem = "Alteração efetuada com sucesso. Identificador: " + Cpf;
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
