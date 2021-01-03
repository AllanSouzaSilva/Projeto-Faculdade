using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjTeste.DAL
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();
        public Conexao()
        {
            //con.ConnectionString = @"Data Source=DESKTOP-S1FSRDP\\SQLEXPRESS;Initial Catalog=SYSTEMBANKUNIPIM;Integrated Security=True";
            //Conexao Liz
            con.ConnectionString = @"Data Source=DESKTOP-S1FSRDP\SQLEXPRESS;Initial Catalog=SYSTEMBANKUNIPIM;Integrated Security=True";
        }

        public SqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
