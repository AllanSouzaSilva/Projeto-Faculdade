﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using SystemBankUnipim;

namespace ProjTeste.View
{
    public partial class TelaGerarTransacoes : Form
    {
        Thread gerenciar;
        Thread Editar;
        Thread Relatorios;
        Thread GerenciarCliente;
        Thread carteiras;
        Thread mercado;
        Thread CompraVenda;
        Thread GerarTransacoes;
        Thread GerarCadastros;
        Thread GerarLucros;


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-S1FSRDP\\SQLEXPRESS;Initial Catalog=SYSTEMBANKUNIPIM;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public TelaGerarTransacoes()
        {
            InitializeComponent();
            DisplayData();
        }

        //Display Data in DataGridView
        //A validar
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT Cli.Nome,Cart.Id_Carteira,TpTrans.Descricao_Investimento,Trans.Valor_Transacao, Trans.Carteira_Destino, Trans.Agencia_Destino, Trans.Conta_Destino " +
                                                "FROM TB_Transacao as Trans " +
                                                "INNER JOIN TB_Carteira as Cart " +
                                                "ON Cart.Id_Carteira = Trans.Id_Carteira " +
                                                "INNER JOIN TB_Cliente as Cli " +
                                                "ON Cli.Id_Cliente = Cart.Id_Cliente " +
                                                "INNER JOIN TB_Tipo_Transacao as TpTrans " +
                                                "ON TpTrans.Id_Tipo_Transacao = Trans.Id_Tipo_Transacao", con);
            adapt.Fill(dt);
            dataGridRelatorioTransacoes.DataSource = dt;
            con.Close();
        }

        private void buttonMercado_Click(object sender, EventArgs e)
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

        private void buttonRelatorios_Click(object sender, EventArgs e)
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

        private void buttonGerarCadastros_Click(object sender, EventArgs e)
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

        private void buttonGerarTransacoes_Click(object sender, EventArgs e)
        {
            this.Close();
            GerarTransacoes = new Thread(OpenGerarTransacoess);
            GerarTransacoes.SetApartmentState(ApartmentState.STA);
            GerarTransacoes.Start();
        }
        private void OpenGerarTransacoess(object obj)
        {
            Application.Run(new TelaGerarTransacoes());
        }

        private void buttonGerarLucros_Click(object sender, EventArgs e)
        {
            this.Close();
            GerarLucros = new Thread(OpenGerarLucros);
            GerarLucros.SetApartmentState(ApartmentState.STA);
            GerarLucros.Start();
        }
        private void OpenGerarLucros(object obj)
        {
            Application.Run(new TelaGerarLucros());
        }
    }
}
