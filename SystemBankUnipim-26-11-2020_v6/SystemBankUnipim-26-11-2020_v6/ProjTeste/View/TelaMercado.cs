using ProjTeste.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SystemBankUnipim

{
    public partial class TelaMercado : Form
    {
        Thread gerenciar;
        Thread Editar;
        Thread GerenciarCliente;
        Thread mercado;
        Thread carteiras;
        Thread CompraVenda;
        Thread GerarTransacoes;
        Thread Relatorios;
        Thread Etherum;
        Thread Litecoin;
        Thread Bitcoin;

        public TelaMercado()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            gerenciar = new Thread(openGerenciarClientes);
            gerenciar.SetApartmentState(ApartmentState.STA);
            gerenciar.Start();
           
        }

        private void openGerenciarClientes(object obj)
        {
            Application.Run(new TelaGerenciarCliente());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TelaMercado_Load(object sender, EventArgs e)
        {

        }

        private void buttonEOS_Click(object sender, EventArgs e)
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
        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            double n1;
            double n2;
            double resultado;

            n2 = double.Parse(textBoxMoeda.Text);
            n1 = double.Parse(textBoxValor.Text);

            resultado = n1 / n2;

            MessageBox.Show(Convert.ToString(resultado));
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
