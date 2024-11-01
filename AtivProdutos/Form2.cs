using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace AtivProdutos
{
    public partial class Form2 : Form
    {
        private clsConexao conexao = new clsConexao();
        private StringBuilder CmdSql = new StringBuilder();
        DataSet DS;
        DataTable DT;

        public Form2()
        {
            InitializeComponent();
            
            txtCod.TextChanged += TxtCod_TextChanged;
            txtDesc.TextChanged += TxtDesc_TextChanged;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtCod.Enabled = true;
            txtDesc.Enabled = false;
            txtValor.Enabled = false;
        }

        private void TxtCod_TextChanged(object sender, EventArgs e)
        {
            txtDesc.Enabled = !string.IsNullOrWhiteSpace(txtCod.Text);
        }

        private void TxtDesc_TextChanged(object sender, EventArgs e)
        {
            txtValor.Enabled = !string.IsNullOrWhiteSpace(txtDesc.Text);
        }

        private void LimparCampos()
        {
            txtCod.Clear();
            txtDesc.Clear();
            txtValor.Clear();
           

        }


        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCod.Text) ||
                    string.IsNullOrWhiteSpace(txtDesc.Text) ||
                    string.IsNullOrWhiteSpace(txtValor.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.");
                    return;
                }

                CmdSql.Clear();
                CmdSql.Append("INSERT INTO Produto (CodProd, Descricao, Valor, Vencto) ");
                CmdSql.Append("VALUES (@CodProd, @Descricao, @Valor, @Vencto)");

                List<MySqlParameter> parameters = new List<MySqlParameter>
                {
                    new MySqlParameter("@CodProd", int.Parse(txtCod.Text)),
                    new MySqlParameter("@Descricao", txtDesc.Text),
                    new MySqlParameter("@Valor", decimal.Parse(txtValor.Text)),
                    new MySqlParameter("@Vencto", dtpVencimento.Value)
                };

                conexao.StrSql = CmdSql.ToString(); 
                int resultado = conexao.ExecutarCmd(parameters); 

                if (resultado > 0)
                {
                    MessageBox.Show("Inclusão executada com sucesso!");
                    LimparCampos();
                   
                }
                else
                {
                    MessageBox.Show("Erro ao tentar incluir o registro!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, verifique os formatos dos dados de entrada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void ChamarGrid()
        {
            conexao.StrSql = "select * from Produto";
            DS = conexao.RetornarDataSet();

            DT = DS.Tables[0];
            GridProduto.DataSource = DT;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                GridProduto.Visible = true;
                CmdSql.Clear();
                CmdSql.Append("SELECT CodProd, Descricao, Valor, Vencto FROM Produto WHERE 1=1");

                List<MySqlParameter> parameters = new List<MySqlParameter>();

                if (!string.IsNullOrEmpty(txtCod.Text))
                {
                    if (int.TryParse(txtCod.Text, out int codigo))
                    {
                        CmdSql.Append(" AND CodProd = @CodProd");
                        parameters.Add(new MySqlParameter("@CodProd", codigo));
                        LimparCampos();
                    }
                    else
                    {
                        MessageBox.Show("O código deve ser numérico.");
                        return;
                    }
                }

                if (!string.IsNullOrEmpty(txtDesc.Text))
                {
                    CmdSql.Append(" AND Descricao LIKE @Descricao");
                    parameters.Add(new MySqlParameter("@Descricao", "%" + txtDesc.Text + "%"));
                }

                if (!string.IsNullOrEmpty(txtValor.Text))
                {
                    if (decimal.TryParse(txtValor.Text, out decimal valor))
                    {
                        CmdSql.Append(" AND Valor = @Valor");
                        parameters.Add(new MySqlParameter("@Valor", valor));
                    }
                    else
                    {
                        MessageBox.Show("O valor deve ser um número decimal.");
                        return;
                    }
                }

                Console.WriteLine("SQL Query: " + CmdSql.ToString());
                foreach (var param in parameters)
                {
                    Console.WriteLine($"Parameter: {param.ParameterName}, Value: {param.Value}");
                }

                conexao.StrSql = CmdSql.ToString();
                DS = conexao.RetornarDataSet(parameters);

                if (DS != null && DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    DT = DS.Tables[0];
                    GridProduto.DataSource = DT;
                }
                else
                {
                    MessageBox.Show("Nenhum produto encontrado com os critérios informados.");
                    GridProduto.DataSource = null; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao executar a pesquisa: {ex.Message}");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtCod.Text))
            {
                MessageBox.Show("Por favor, insira o Código do Pet para excluir.");
                return;
            }

            var confirmResult = MessageBox.Show("Tem certeza que deseja excluir este registro?",
                                                "Confirmar Exclusão",
                                                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                CmdSql.Clear();
                CmdSql.Append("DELETE FROM Produto WHERE CodProd = @CodProd");

                List<MySqlParameter> parameters = new List<MySqlParameter>
                {
                    new MySqlParameter("@CodProd", txtCod.Text)
                };

                conexao.StrSql = CmdSql.ToString();

                if (conexao.ExecutarCmd(parameters) > 0)
                {
                    MessageBox.Show("Registro excluído com sucesso!");
                    ChamarGrid();
                }
                else
                {
                    MessageBox.Show("Erro ao tentar excluir o registro.");
                }
            }
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
