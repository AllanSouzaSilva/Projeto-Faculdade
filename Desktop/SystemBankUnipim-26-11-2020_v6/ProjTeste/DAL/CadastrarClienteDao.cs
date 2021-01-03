using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjTeste.DAL
{
    public class CadastrarClienteDao
    {
        public bool cadastroOK = false;
        public String msg = ""; //esta ok
        Conexao con = new Conexao();

        public String CadastrarCliente(String nome, String cpf, String cnpj, DateTime dtNasc, String telefone, String email, String senha)
        {
            SqlCommand cmd = new SqlCommand();

            if (cpf.Length == 11)
            {
                cnpj = "";

                cmd.CommandText = "INSERT INTO TB_Cliente VALUES (@nome,@cpf,@cnpj,@dtNasc,@telefone,@email,@senha)";
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@cnpj", cnpj);
                cmd.Parameters.AddWithValue("@dtNasc", dtNasc);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);

                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();
                    con.Desconectar();
                    this.msg = "Dados Cadastrados com Sucesso!";
                    cadastroOK = true;
                }
                catch (SqlException)
                {
                    this.msg = "Erro com o Banco de Dados!";
                }
            }
            else if (cnpj.Length == 14)
            {
                cpf = "";

                cmd.CommandText = "INSERT INTO TB_Cliente (@nome,@cpf,@cnpj,@dtNasc,@telefone,@email,@senha)";
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@cnpj", cnpj);
                cmd.Parameters.AddWithValue("@dtNasc", dtNasc);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);

                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();
                    con.Desconectar();
                    this.msg = "Dados Cadastrados com Sucesso!";
                    cadastroOK = true;
                }
                catch (SqlException)
                {
                    this.msg = "Erro com o Banco de Dados!";
                }
            }
            else
            {
                this.msg = "Dados Invalidos";
            }
            return msg;
        }
    }
}
