using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjTeste.DAL
{
    public class LoginDao
    {
        public bool loginUp = false;
        public String msg = ""; //esta ok 
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public bool verificarLogin(String login, String senha)
        {
            cmd.CommandText = "SELECT * FROM TB_Usuario where usuario = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    loginUp = true;
                }
                con.Desconectar();
                dr.Close();
            }
            catch(SqlException)
            {
                this.msg = "Erro com o Banco de Dados!";
                throw;
            }
            return loginUp;
        }
    }
}
