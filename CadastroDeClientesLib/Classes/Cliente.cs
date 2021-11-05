using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using CadastroDeClientesLib;
using CadastroDeClientesLib.Databases;

namespace CadastroDeClientesLib.Classes

{
    public class Cliente
    {
        public class Unit
        {
            [Required(ErrorMessage = "O Nome do Cliente é obrigatório")]
            [StringLength(50, ErrorMessage = "Nome do cliente deve possuir no máximo 50 caracteres")]
            public string Nome { get; set; }
            public string NomePai { get; set; }

            [Required(ErrorMessage = "O Nome da Mãe é obrigatório")]
            [StringLength(50, ErrorMessage = "Nome da mãe deve ter no máximo 50 caracteres")]
            public string NomeMae { get; set; }

            public bool NaoTemPai { get; set; }

            [Required(ErrorMessage = "CPF é obrigatório")]
            public string Cpf { get; set; }

            [Required(ErrorMessage = "O genêro é obrigatório")]
            public int Genero { get; set; }

            [Required(ErrorMessage = "O CEP é obrigatório")]
            public string Cep { get; set; }

            [Required(ErrorMessage = "O Logradouro é obrigatório")]
            [StringLength(100, ErrorMessage = "O logradouro deve ter no máximo 100 caracteres")]
            public string Logradouro { get; set; }

            [Required(ErrorMessage = "O Complemento é obrigatório")]
            [StringLength(100, ErrorMessage = "O Complemento deve ter no máximo 100 caracteres")]
            public string Complemento { get; set; }

            [Required(ErrorMessage = "O Bairro é obrigatório")]
            [StringLength(50, ErrorMessage = "O Bairro deve ter no máximo 50 caracteres")]
            public string Bairro { get; set; }

            [Required(ErrorMessage = "A Cidade é obrigatório")]
            [StringLength(50, ErrorMessage = "A Cidade deve ter no máximo 50 caracteres")]
            public string Cidade { get; set; }

            [Required(ErrorMessage = "O Estado é obrigatório")]
            public string Estado { get; set; }

            [Required(ErrorMessage = "Telefone é obrigatório")]
            public string Telefone { get; set; }

            public void ValidaClasse()
            {
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if (isValid == false)
                {
                    StringBuilder sbrErrors = new StringBuilder();
                    foreach (var validationResult in results)
                    {
                        sbrErrors.AppendLine(validationResult.ErrorMessage);
                    }
                    throw new ValidationException(sbrErrors.ToString());
                }
            }

            public void ValidaComplemento()
            {
                if (this.NomePai == this.NomeMae)
                {
                    throw new Exception("Nome do pai e da mãe não podem ser iguais");
                }
                if (this.NaoTemPai == false)
                {
                    if (this.NomePai == "")
                    {
                        throw new Exception("Nome do pai não pode estar vazio quando a propriedade Pai desconhecido não estiver marcada");
                    }
                }

                bool validaCPF = Cls_Uteis.Valida(this.Cpf);
                if (validaCPF == false)
                {
                    throw new Exception("CPF Inválido!");
                }
            }

            #region "CRUD do FicharioSQLServer Local DB"

            public void IncluirFicharioSQLServer(string conexao)
            {
                string clienteJson = Cliente.SerializedClassUnit(this);
                FicharioSQLServer F = new FicharioSQLServer(conexao);
                if (F.status)
                {
                    F.Incluir(this.Cpf, clienteJson);
                    if (!(F.status))
                    {
                        throw new Exception(F.mensagem);
                    }
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }

            public Unit BuscarFicharioSQLServer(string id, string conexao)
            {
                FicharioSQLServer F = new FicharioSQLServer(conexao);
                if (F.status)
                {
                    string clienteJson = F.Buscar(id);
                    return Cliente.DesSerializedClassUnit(clienteJson);
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }

            public void AlterarFicharioSQLServer(string conexao)
            {
                string clienteJson = Cliente.SerializedClassUnit(this);
                FicharioSQLServer F = new FicharioSQLServer(conexao);
                if (F.status)
                {
                    F.Alterar(this.Cpf, clienteJson);
                    if (!(F.status))
                    {
                        throw new Exception(F.mensagem);
                    }
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }

            public void ApagarFicharioSQLServer(string conexao)
            {

                FicharioSQLServer F = new FicharioSQLServer(conexao);
                if (F.status)
                {
                    F.Apagar(this.Cpf);
                    if (!(F.status))
                    {
                        throw new Exception(F.mensagem);
                    }
                }
                else
                {
                    throw new Exception(F.mensagem);
                }

            }

            public List<List<string>> BuscarFicharioSQLServerTodosDB(string conexao)
            {
                FicharioSQLServer F = new FicharioSQLServer(conexao);
                if (F.status)
                {
                    List<string> List = new List<string>();
                    List = F.BuscarTodos();
                    if (F.status)
                    {
                        List<List<string>> ListaBusca = new List<List<string>>();
                        for (int i = 0; i <= List.Count - 1; i++)
                        {
                            Cliente.Unit C = Cliente.DesSerializedClassUnit(List[i]);
                            ListaBusca.Add(new List<string> { C.Cpf, C.Nome });
                        }
                        return ListaBusca;
                    }
                    else
                    {
                        throw new Exception(F.mensagem);
                    }
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }

            #endregion
        }
            public class List
            {
                public List<Unit> ListUnit { get; set; }
            }
            public static Unit DesSerializedClassUnit(string vJson)
            {
                return JsonConvert.DeserializeObject<Unit>(vJson);
            }
            public static string SerializedClassUnit(Unit unit)
            {
                return JsonConvert.SerializeObject(unit);
            }

    }

}


