using CadastroFuncionarios.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionarios.dao
{
    internal class FuncionarioDAO
    {
        public void Insert(Funcionario funcionario)
        {
            if (string.IsNullOrWhiteSpace(funcionario.Nome))
            {
                throw new Exception("O nome do funcionário não pode ser vazio ou nulo.");
            }

            if (string.IsNullOrWhiteSpace(funcionario.Cpf))
            {
                throw new Exception("O CPF do funcionário não pode ser vazio ou nulo.");
            }

            try
            {

                string sql = "INSERT INTO Funcionario (Nome_Funcionario, CPF_Funcionario) " +
                    "VALUES(@nome, @cpf)";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@nome", funcionario.Nome);
                comando.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                comando.ExecuteNonQuery();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Funcionario cadastrado com Sucesso!");
                Console.ResetColor();
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao cadastrar o funcionario!{ex.Message}");

            }

            finally
            {
                Conexao.FecharConexao();
            }
        }
        public void Delete(Funcionario funcionario)
        {

            if (funcionario == null)
            {
                throw new Exception("Funcionário não existe na lista ou o valor inserido é nulo. Por gentileza, tente novamente!");
            }

            try
            {
                
                string sql = "DELETE FROM Funcionario WHERE Id_Funcionario = @IdFuncionario";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@IdFuncionario", funcionario.IdFuncionario);

                comando.ExecuteNonQuery();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Cliente excluido com sucesso!");
                Console.ReadKey();
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir o cliente {ex.Message}");
            }

            finally
            {
                Conexao.FecharConexao();
            }
        }

        public List<Funcionario> List()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            try
            {
                var sql = "SELECT * FROM Funcionario ORDER BY Nome_Funcionario";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                using (MySqlDataReader dr = comando.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Funcionario funcionario = new Funcionario();
                        funcionario.IdFuncionario = dr.GetInt32("Id_Funcionario");
                        funcionario.Nome = dr.GetString("Nome_Funcionario");
                        funcionario.Cpf = dr.GetString("CPF_Funcionario");
                        funcionarios.Add(funcionario);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao cadastrar na lista{ex.Message}");
            }
            finally
            {
                Conexao.FecharConexao();

            }
            return funcionarios;
        }

        public void Update(Funcionario funcionario)
        {
            if(funcionario == null)
            {
                throw new Exception("Funcionário não pode ser nulo. ");
            }
            try
            {
                string sql = "UPDATE Funcionario SET Nome_Funcionario = @nome, CPF_Funcionario = @cpf " +
                   "WHERE Id_Funcionario = @IdFuncionario";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@nome", funcionario.Nome);
                comando.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                comando.Parameters.AddWithValue("@IdFuncionario", funcionario.IdFuncionario);
                comando.ExecuteNonQuery();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Cliente atualizado com sucesso! ");
                Console.ReadKey();
                Console.ResetColor();
            }
            catch (Exception ex) 
            {
                throw new Exception($"Erro ao atualizar o cliente {ex.Message}");
            }
            finally
            {
                Conexao.FecharConexao();
            }
        } 
        

    }
}
