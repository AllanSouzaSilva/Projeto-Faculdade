using ProjTeste.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjTeste.Controller
{
    public class LoginController
    {
        public bool LoginUp;
        public String msg = "";

        public bool Acessar(String login, String senha)
        {
            LoginDao loginDao = new LoginDao();
            LoginUp = loginDao.verificarLogin(login, senha);

            if (!loginDao.msg.Equals(""))
            {
                this.msg = loginDao.msg;
            }
            return LoginUp;
        }
    }
}
