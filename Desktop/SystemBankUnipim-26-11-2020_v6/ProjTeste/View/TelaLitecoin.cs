using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemBankUnipim;

namespace ProjTeste.View
{
    public partial class TelaLitecoin : Form
    {
        Thread gerenciar;
        Thread Editar;
        Thread Relatorios;
        Thread GerenciarCliente;
        Thread carteiras;
        Thread mercado;
        Thread CompraVenda;
        Thread GerarTransacoes;
        Thread Etherum;
        Thread Litecoin;
        Thread Bitcoin;

        public TelaLitecoin()
        {
            InitializeComponent();
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

        private void buttonBitcoin_Click(object sender, EventArgs e)
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

        private void buttonEtherum_Click(object sender, EventArgs e)
        {
            this.Close();
            Etherum = new Thread(OpenEtherum);
            Etherum.SetApartmentState(ApartmentState.STA);
            Etherum.Start();
        }
        private void OpenEtherum(object obj)
        {
            Application.Run(new TelaEtherum());
        }

        private void buttonLitecoin_Click(object sender, EventArgs e)
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

        private void buttonMercadoGeral_Click(object sender, EventArgs e)
        {
            this.Close();
            mercado = new Thread(OpenMercados);
            mercado.SetApartmentState(ApartmentState.STA);
            mercado.Start();
        }
        private void OpenMercados(object obj)
        {
            Application.Run(new TelaMercado());
        }
    }
}
