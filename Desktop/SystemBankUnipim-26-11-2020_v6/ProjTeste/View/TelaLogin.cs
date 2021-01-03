using ProjTeste.Controller;
using ProjTeste.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SystemBankUnipim
{
    public partial class TelaLogin : Form
    {
        Thread mercado;
        Thread GerenciarCliente;
        Thread carteiras;
        Thread CompraVenda;
        Thread Relatorios;
        Thread Editar;
        Thread Etherum;
        Thread Litecoin;
        Thread Bitcoin;
        Thread GerarCadastros;
        Thread GerarTransacoes;

        public TelaLogin()
        {
            InitializeComponent();
        }

        private void ButtonGeCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            GerenciarCliente= new Thread(OpenGerenciarClientes);
            GerenciarCliente.SetApartmentState(ApartmentState.STA);
            GerenciarCliente.Start();

        }
        private void OpenGerenciarClientes(object obj)
        {
            Application.Run(new TelaGerenciarCliente());
        }

        private void ButtonMercado_Click(object sender, EventArgs e)
        {
            this.Close();
            mercado = new Thread(OpenMercado);
            mercado.SetApartmentState(ApartmentState.STA);
            mercado.Start();
        }
        private void OpenMercado(object obj)
        {
            Application.Run(new TelaMercado());
        }
        private void ButtonCarteiras_Click(object sender, EventArgs e)
        {
            this.Close();
            carteiras = new Thread(OpenCarteiras);
            carteiras.SetApartmentState(ApartmentState.STA);
            carteiras.Start();
        }
        private void OpenCarteiras(object obj)
        {
            Application.Run(new TelaCarteiras());
        }
        private void ButtonCompraVenda_Click(object sender, EventArgs e)
        {
            this.Close();
            CompraVenda = new Thread(OpenCompraVenda);
            CompraVenda.SetApartmentState(ApartmentState.STA);
            CompraVenda.Start();
        }
        private void OpenCompraVenda(object obj)
        {
            Application.Run(new TelaCompraVenda());
        }
        private void ButtonRelatorios_Click(object sender, EventArgs e)
        {
            this.Close();
            Relatorios = new Thread(OpenRelatorios);
            Relatorios.SetApartmentState(ApartmentState.STA);
            Relatorios.Start();
        }
        private void OpenRelatorios(object obj)
        {
            Application.Run(new TelaRelatorios());
        }
        private void ButtonEditar_Click(object sender, EventArgs e)
        {
            this.Close();
            Editar = new Thread(OpenEditar);
            Editar.SetApartmentState(ApartmentState.STA);
            Editar.Start();
        }
        private void OpenEditar(object obj)
        {
            Application.Run(new TelaEditar());
        }

        private void ButtonEhterum_Click(object sender, EventArgs e)
        {
            this.Close();
            Etherum = new Thread(OpenEtherum);
            Etherum.SetApartmentState(ApartmentState.STA);
            Etherum.Start();
        }
        private void OpenEtherum(object obj)
        {
            Application.Run(new TelaRelatorios());
        }

        private void ButtonLitecoin_Click(object sender, EventArgs e)
        {
            this.Close();
            Litecoin = new Thread(OpenLitecoin);
            Litecoin.SetApartmentState(ApartmentState.STA);
            Litecoin.Start();
        }
        private void OpenLitecoin(object obj)
        {
            Application.Run(new TelaLitecoin());
        }
        private void ButtonBitcoin_Click(object sender, EventArgs e)
        {
            this.Close();
            Bitcoin = new Thread(OpenBitcoin);
            Bitcoin.SetApartmentState(ApartmentState.STA);
            Bitcoin.Start();
        }
        private void OpenBitcoin(object obj)
        {
            Application.Run(new TelaBitcoin());
        }
        private void ButtonGerarCadastros_Click(object sender, EventArgs e)
        {
            this.Close();
            GerarCadastros = new Thread(OpenGerarCadastros);
            GerarCadastros.SetApartmentState(ApartmentState.STA);
            GerarCadastros.Start();
        }
        private void OpenGerarCadastros(object obj)
        {
            Application.Run(new TelaGerarCadastros());
        }
        private void ButtonGerarTransacoes_Click(object sender, EventArgs e)
        {
            this.Close();
            GerarTransacoes = new Thread(OpenGerarTransacoes);
            GerarTransacoes.SetApartmentState(ApartmentState.STA);
            GerarTransacoes.Start();
        }
        private void OpenGerarTransacoes(object obj)
        {
            Application.Run(new TelaGerarTransacoes());
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }
        
        private void ButtonEntrar_Click_1(object sender, EventArgs e)
        {
            LoginController loginController = new LoginController();
            loginController.Acessar(textBoxUsuario.Text, textBoxSenha.Text);

            if (loginController.msg.Equals(""))
            {
                if (loginController.LoginUp)
                {
                    this.Close();
                    MessageBox.Show("Logado com Sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mercado = new Thread(OpenMercado);
                    mercado.SetApartmentState(ApartmentState.STA);
                    mercado.Start();
                }
                else
                {
                    MessageBox.Show("Login/Senha Inválido!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(loginController.msg);
            }

        }
    }
}
