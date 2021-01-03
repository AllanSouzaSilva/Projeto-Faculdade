using ProjTeste.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemBankUnipim;

namespace ProjTeste.View
{
    public partial class TelaEditar : Form
    {
        Thread Editar;
        Thread GerenciarCliente;
        Thread mercado;
        Thread carteiras;
        Thread CompraVenda;
        Thread GerarTransacoes;
        Thread Relatorios;

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-S1FSRDP\\SQLEXPRESS;Initial Catalog=SYSTEMBANKUNIPIM;Integrated Security=True");
        //Conexao con = new Conexao();
        SqlCommand cmd;
        SqlDataAdapter adapt;

        //ID variable used in Updating and Deleting Record  
        int ID = 0;

        public TelaEditar()
        {
            InitializeComponent();
            DisplayData();
        }

        //Display Data in DataGridView  
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM TB_Cliente", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
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
            ID = 0;
        }

        private void TelaEditar_Load(object sender, EventArgs e)
        {

        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (textBoxNomeCliente.Text != "" && textBoxCPFCNPJ.Text != "")
            {
                if (textBoxCPFCNPJ.Text.Length == 11)
                {
                    string cnpj = "";
                    cmd = new SqlCommand("UPDATE TB_Cliente SET Nome=@nome,CPF=@cpf,CNPJ=@cnpj,DtNasc=@dtNasc,Telefone=@telefone,Email=@email,Senha=@senha where Id_Cliente='"+ ID +"'", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@nome", textBoxNomeCliente.Text);
                    cmd.Parameters.AddWithValue("@cpf", textBoxCPFCNPJ.Text);
                    cmd.Parameters.AddWithValue("@cnpj", cnpj);
                    cmd.Parameters.AddWithValue("@dtNasc", textBoxDataNascimento.Text);
                    cmd.Parameters.AddWithValue("@telefone", textBoxTel.Text);
                    cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
                    cmd.Parameters.AddWithValue("@senha", textBoxSenha.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados Pessoa Fisica atualizados com sucesso.","Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    DisplayData();
                    ClearData();
                }
                else if (textBoxCPFCNPJ.Text.Length == 14)
                {
                    string cpf = "";
                    cmd = new SqlCommand("UPDATE TB_Cliente SET Nome=@nome,CPF=@cpf,CNPJ=@cnpj,DtNasc=@dtNasc,Telefone=@telefone,Email=@email,Senha=@senha where Id_Cliente=@id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@nome", textBoxNomeCliente.Text);
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    cmd.Parameters.AddWithValue("@cnpj", textBoxCPFCNPJ);
                    cmd.Parameters.AddWithValue("@dtNasc", textBoxDataNascimento.Text);
                    cmd.Parameters.AddWithValue("@telefone", textBoxTel.Text);
                    cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
                    cmd.Parameters.AddWithValue("@senha", textBoxSenha.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados Pessoa Juridica atualizados com sucesso.","Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    DisplayData();
                    ClearData();
                }
            }
            else
            {
                MessageBox.Show("Selecione um Cliente para atualizar.");
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("DELETE TB_Cliente where Id_Cliente=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Cliente Deletado com Suceso o/!","Deletado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Por favor selecione uma linha para Deletar.","ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cpf = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string cnpj = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (cpf.Length == 11)
            {
                ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                textBoxNomeCliente.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxCPFCNPJ.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                //cnpj = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBoxDataNascimento.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBoxTel.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBoxEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                textBoxSenha.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            else if (cnpj.Length == 14)
            {
                ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                textBoxNomeCliente.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                //textBoxCPFCNPJ.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxCPFCNPJ.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBoxDataNascimento.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBoxTel.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBoxEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                textBoxSenha.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
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

        private void buttonCadastrarCliente_Click(object sender, EventArgs e)
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
            GerenciarCliente = new Thread(OpenGerenciaCliente);
            GerenciarCliente.SetApartmentState(ApartmentState.STA);
            GerenciarCliente.Start();
        }

        private void OpenGerenciaCliente(object obj)
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
    }
}
