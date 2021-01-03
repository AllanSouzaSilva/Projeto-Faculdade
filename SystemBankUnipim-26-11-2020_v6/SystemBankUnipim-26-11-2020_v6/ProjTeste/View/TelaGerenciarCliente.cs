using ProjTeste.Controller;
using ProjTeste.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SystemBankUnipim
{
    public partial class TelaGerenciarCliente : Form
    {
        Thread gerenciar;
        Thread Editar;
        Thread Relatorios;
        Thread GerenciarCliente;
        Thread carteiras;
        Thread mercado;
        Thread CompraVenda;
        Thread GerarTransacoes;


        public TelaGerenciarCliente()
        {
            InitializeComponent();
        }

        private void ButtonMercado_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaMercado mercadotela = new TelaMercado();
            mercadotela.Show();
        }

        private void ButtonFinalizarCadastro_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNomeCliente.Text) && !string.IsNullOrEmpty(textBoxEmail.Text) && !string.IsNullOrEmpty(textBoxCPFCNPJ.Text) && !string.IsNullOrEmpty(textBoxDataNascimento.Text))// != null || textBoxEmailCliente != null || textBoxCPFCNPJ != null || textBoxDataNascimento != null)
            {
                CadastrarClienteController cliente = new CadastrarClienteController();
                String mensagem = cliente.Cadastrar(textBoxNomeCliente.Text, textBoxCPFCNPJ.Text, textBoxCPFCNPJ.Text, Convert.ToDateTime(textBoxDataNascimento.Text),
                                  textBoxTel.Text, textBoxEmail.Text, textBoxSenha.Text);

                if (cliente.mensagem)
                {
                    MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(cliente.msg, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Dados incorretos. Favor Tentar Novamente.");
            }
        }

        private void ButtonCadastrarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            gerenciar = new Thread(OpenGerenciarClientes);
            gerenciar.SetApartmentState(ApartmentState.STA);
            gerenciar.Start();
            ClearData();
        }

        private void OpenGerenciarClientes(object obj)
        {
            Application.Run(new TelaGerenciarCliente());
        }

        //Clear Data  
        private void ClearData()
        {
            textBoxNomeCliente.Text = "";
            textBoxCPFCNPJ.Text = "";
            textBoxDataNascimento.Text = "";
            textBoxTel.Text = "";
            textBoxEmail.Text = "";
            textBoxSenha.Text = "";
            //ID = 0;
        }

        private void TelaGerenciarCliente_Load(object sender, EventArgs e)
        {

        }

        private void buttonEditarCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
            Editar = new Thread(OpenEditar);
            Editar.SetApartmentState(ApartmentState.MTA);
            Editar.Start();
        }
        private void OpenEditar(object obj)
        {
            Application.Run(new TelaEditar());
        }

        private void buttonRelatorios_Click(object sender, EventArgs e)
        {
            this.Close();
            Relatorios = new Thread(OpenRelatorios);
            Relatorios.SetApartmentState(ApartmentState.STA);
            Relatorios.Start();
            ClearData();
        }

        private void OpenRelatorios(object obj)
        {
            Application.Run(new TelaRelatorios());
        }

        private void buttonGerenciarMercado_Click(object sender, EventArgs e)
        {
            this.Close();
            GerenciarCliente = new Thread(OpenGerenciaClientes);
            GerenciarCliente.SetApartmentState(ApartmentState.STA);
            GerenciarCliente.Start();
        }

        private void OpenGerenciaClientes(object obj)
        {
            Application.Run(new TelaGerenciarCliente());
        }

        private void buttonCarteiras_Click(object sender, EventArgs e)
        {
            this.Close();
            carteiras = new Thread(OpenCarteira);
            carteiras.SetApartmentState(ApartmentState.STA);
            carteiras.Start();
        }
        private void OpenCarteira(object obj)
        {
            Application.Run(new TelaCarteiras());
        }

        private void buttonMercado_Click_1(object sender, EventArgs e)
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

        private void buttonCadastrarCliente_Click_1(object sender, EventArgs e)
        {
            this.Close();
            GerenciarCliente = new Thread(OpenGerenciaCadastros);
            GerenciarCliente.SetApartmentState(ApartmentState.STA);
            GerenciarCliente.Start();
        }

        private void OpenGerenciaCadastros(object obj)
        {
            Application.Run(new TelaGerenciarCliente());
        }

        private void buttonCompraVenda_Click(object sender, EventArgs e)
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

        private void buttonTransacoes_Click(object sender, EventArgs e)
        {
            this.Close();
            GerarTransacoes = new Thread(OpenGerarTransacoes);
            GerarTransacoes.SetApartmentState(ApartmentState.STA);
            GerarTransacoes.Start();
        }
        private void OpenGerarTransacoes(object obj)
        {
            Application.Run(new TelaTransacoes());
        }

    }
}
