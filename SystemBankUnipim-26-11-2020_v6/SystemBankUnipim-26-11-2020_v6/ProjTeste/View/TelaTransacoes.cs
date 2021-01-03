using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using SystemBankUnipim;
using System.Data.SqlClient;

namespace ProjTeste.View
{
    public partial class TelaTransacoes : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-S1FSRDP\\SQLEXPRESS;Initial Catalog=SYSTEMBANKUNIPIM;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        Thread gerenciar;
        Thread Editar;
        Thread Relatorios;
        Thread GerenciarCliente;
        Thread carteiras;
        Thread mercado;
        Thread CompraVenda;
        Thread GerarTransacoes;

        public TelaTransacoes()
        {
            InitializeComponent();
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
                                                "ON TpTrans.Id_Tipo_Transacao = Trans.Id_Tipo_Transacao " +
                                                "WHERE CART.Id_Cliente = @nrcarteira", con);
            //command.Parameters.Add("@nrcarteira", SqlDbType.Int, 5, textBoxNrCarteira.Text);
            adapt.SelectCommand.Parameters.Add(new SqlParameter
            {
                ParameterName = "@nrcarteira",
                Value = textBoxNrCarteira.Text,
                SqlDbType = SqlDbType.Int,
                Size = 30  // Assuming a 2000 char size of the field annotation (-1 for MAX)
            });
            adapt.Fill(dt);
            dataGridViewTransacoes.DataSource = dt;
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

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            DisplayData();
            MessageBox.Show("Veja as ultimas Transações do Cliente", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
