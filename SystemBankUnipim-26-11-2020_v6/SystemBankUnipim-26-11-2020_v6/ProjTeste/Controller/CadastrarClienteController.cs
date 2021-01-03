using ProjTeste.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjTeste.Controller
{
    public class CadastrarClienteController
    {
        public bool mensagem;
        public String msg = "";

        public String Cadastrar(String nome, String cpf, String cnpj, DateTime dtNasc, String telefone, String email, String senha)
        {
            CadastrarClienteDao cadastraDao = new CadastrarClienteDao();
            this.msg = cadastraDao.CadastrarCliente(nome, cpf, cnpj, dtNasc, telefone, email, senha);
            if (cadastraDao.cadastroOK)
            {
                this.mensagem = true;
            }
            return msg;
        }
    }
}
