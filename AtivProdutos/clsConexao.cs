using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivProdutos
{
    internal class clsConexao
    {
        private string _StrSql;

        public string StrSql
        {
            get { return _StrSql; }
            set { _StrSql = value; }
        }

        private string strConexao = "datasource=localhost;username=root;password=;database=produtos";
        /*Instanciando Conexão banco de dados*/
        private MySqlConnection AbriBanco()
        {
            MySqlConnection Conn = new MySqlConnection();
            Conn.ConnectionString = strConexao;
            Conn.Open();
            return Conn;
        }
        private void FecharBanco(MySqlConnection Conn)
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
        }
        public DataSet RetornarDataSet(List<MySqlParameter> parameters = null)
        {
            MySqlConnection conn = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter DA = new MySqlDataAdapter();
            DataSet DS = new DataSet();

            try
            {
                conn = AbriBanco();
                cmd.CommandText = _StrSql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                // Adiciona parâmetros ao comando, se existirem
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                }

                DA.SelectCommand = cmd;
                DA.Fill(DS);

                return DS;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao retornar dataset: " + ex.Message);
            }
            finally
            {
                FecharBanco(conn);
            }
        }

        public MySqlDataReader RetornarDataReader(List<MySqlParameter> parameters = null)
        {
            MySqlConnection conn = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                conn = AbriBanco();
                cmd.CommandText = _StrSql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                return cmd.ExecuteReader(CommandBehavior.CloseConnection);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int ExecutarCmd(List<MySqlParameter> parameters = null)
        {
            using (MySqlConnection conn = AbriBanco())
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandText = _StrSql;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;

                    // Adiciona parâmetros se houver
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());
                    }

                    return cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro: " + ex.Message);
                }
            }
        }

    }
}

