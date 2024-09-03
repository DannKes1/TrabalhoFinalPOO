using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TrabalhoFinalFORMS
{
    public static class Conexao
    {
        static MySqlConnection conexao;

        public static MySqlConnection Conectar()
        {
            try
            {
                string strconexao = "server=localhost;port=3306;uid=root;pwd=root;database=SistemaFinanceiro";
                conexao = new MySqlConnection(strconexao);
                conexao.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar" + ex.Message);
            }
            return conexao;
        }
        public static void FecharConexao()
        {
            conexao.Close();
        }
    }
}
