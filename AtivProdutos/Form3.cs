using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace AtivProdutos
{
    public partial class Form3 : Form
    {
        private clsConexao conexao = new clsConexao();
        private StringBuilder CmdSql = new StringBuilder();
        DataSet DS;
        DataTable DT;

        public Form3()
        {
            InitializeComponent();
            txtCod.TextChanged += TxtCod_TextChanged;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtCod.Enabled = true;
            dtpMovto.Checked = false;
            rdbEntrada.Checked = false;
            rdbSaida.Checked = false;
        }

        private void TxtCod_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCod.Text))
            {
                txtDesc.Text = "";
                return;
            }

            try
            {
                CmdSql.Clear();
                CmdSql.Append("SELECT Descricao FROM Produto WHERE CodProd = @CodProd");

                List<MySqlParameter> parameters = new List<MySqlParameter>
                {
                    new MySqlParameter("@CodProd", int.Parse(txtCod.Text))
                };

                conexao.StrSql = CmdSql.ToString();
                DS = conexao.RetornarDataSet(parameters);

                if (DS != null && DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    txtDesc.Text = DS.Tables[0].Rows[0]["Descricao"].ToString();
                    txtDesc.Visible = true;
                }
                else
                {
                    txtDesc.Text = "";
                    txtDesc.Visible = false;
                    MessageBox.Show("Produto não encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar a descrição: {ex.Message}");
            }
        }

        private void ChamarGrid()
        {
            conexao.StrSql = "select * from Movto";
            DS = conexao.RetornarDataSet();
            DT = DS.Tables[0];
            dgvMovto.DataSource = DT;
        }

        private void LimparCampos()
        {
            txtCodMovto.Clear();
            txtCod.Clear();
            txtDesc.Clear();
            txtObs.Clear();
            txtQuant.Clear();
            dtpMovto.Checked = false;
            rdbEntrada.Checked = false;
            rdbSaida.Checked = false;
          
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCod.Text) || string.IsNullOrWhiteSpace(txtObs.Text) || string.IsNullOrWhiteSpace(txtQuant.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos necessários.");
                    return;
                }

                int codmovto = int.Parse(txtCodMovto.Text);
                int codProd = int.Parse(txtCod.Text);
                string obs = txtObs.Text;
                DateTime dtMovto = dtpMovto.Value;
                decimal quant = decimal.Parse(txtQuant.Text);

                string tipo;
                if (rdbEntrada.Checked)
                {
                    tipo = "entrada";
                }
                else if (rdbSaida.Checked)
                {
                    tipo = "saída";
                }
                else
                {
                    MessageBox.Show("Selecione o tipo de movimento (Entrada ou Saída).");
                    return;
                }

                CmdSql.Clear();
                CmdSql.Append("INSERT INTO Movto (CodMovto, CodProd, Obs, DtMovto, Tipo, Quant) ");
                CmdSql.Append("VALUES (@CodMovto, @CodProd, @Obs, @DtMovto, @Tipo, @Quant);");

                conexao.StrSql = CmdSql.ToString();

                List<MySqlParameter> parametersMovto = new List<MySqlParameter>
                {
                    new MySqlParameter("@CodMovto", codmovto),
                    new MySqlParameter("@CodProd", codProd),
                    new MySqlParameter("@Obs", obs),
                    new MySqlParameter("@DtMovto", dtMovto),
                    new MySqlParameter("@Tipo", tipo),
                    new MySqlParameter("@Quant", quant)
                };

                conexao.ExecutarCmd(parametersMovto);
                MessageBox.Show("Movimento inserido com sucesso!");
           
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir o movimento: {ex.Message}");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvMovto.Visible = true;
                dgvMovto.DataSource = null;

                CmdSql.Clear();
                CmdSql.Append("SELECT CodMovto, CodProd, Obs, DtMovto, Tipo, Quant FROM Movto WHERE 1=1");

                List<MySqlParameter> parameters = new List<MySqlParameter>();

                bool vazio = false;

                if (!string.IsNullOrWhiteSpace(txtCodMovto.Text))
                {
                    CmdSql.Append(" AND CodMovto = @CodMovto");
                    parameters.Add(new MySqlParameter("@CodMovto", int.Parse(txtCodMovto.Text)));
                    vazio = true;
                }

                if (!string.IsNullOrWhiteSpace(txtCod.Text))
                {
                    CmdSql.Append(" AND CodProd = @CodProd");
                    parameters.Add(new MySqlParameter("@CodProd", int.Parse(txtCod.Text)));
                    vazio = true;
                }

                if (!vazio)
                {
                    CmdSql.Clear();
                    CmdSql.Append("SELECT CodMovto, CodProd, Obs, DtMovto, Tipo, Quant FROM Movto");
                }

                conexao.StrSql = CmdSql.ToString();
                DS = conexao.RetornarDataSet(parameters);

                if (DS != null && DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    dgvMovto.DataSource = DS.Tables[0];
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado com os parâmetros fornecidos.");
                }

                
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira um número válido para o Código do Movimento ou do Produto.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar os registros: {ex.Message}");
            }
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCodMovto.Text) && string.IsNullOrWhiteSpace(txtCod.Text))
                {
                    MessageBox.Show("Por favor, informe o Código do Movimento ou o Código do Produto para exclusão.");
                    return;
                }

                CmdSql.Clear();
                CmdSql.Append("DELETE FROM Movto WHERE 1=1");

                List<MySqlParameter> parametros = new List<MySqlParameter>();

                if (!string.IsNullOrWhiteSpace(txtCodMovto.Text))
                {
                    CmdSql.Append(" AND CodMovto = @CodMovto");
                    parametros.Add(new MySqlParameter("@CodMovto", int.Parse(txtCodMovto.Text)));
                }

                if (!string.IsNullOrWhiteSpace(txtCod.Text))
                {
                    CmdSql.Append(" AND CodProd = @CodProd");
                    parametros.Add(new MySqlParameter("@CodProd", int.Parse(txtCod.Text)));
                }

                DialogResult confirmarExclusao = MessageBox.Show("Tem certeza de que deseja excluir o registro?", "Confirmar Exclusão", MessageBoxButtons.YesNo);
                if (confirmarExclusao != DialogResult.Yes)
                {
                    return;
                }

                conexao.StrSql = CmdSql.ToString();
                int linhasAfetadas = conexao.ExecutarCmd(parametros);

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Registro excluído com sucesso!");
                    ChamarGrid();
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado com os parâmetros fornecidos.");
                }

                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir o registro: {ex.Message}");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCodMovto.Text))
                {
                    MessageBox.Show("Por favor, informe o Código do Movimento para atualizar.");
                    return;
                }

                int codMovto;
                if (!int.TryParse(txtCodMovto.Text, out codMovto))
                {
                    MessageBox.Show("Código do Movimento inválido.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCod.Text) && string.IsNullOrWhiteSpace(txtObs.Text) &&
                    string.IsNullOrWhiteSpace(txtQuant.Text) && !dtpMovto.Checked &&
                    !rdbEntrada.Checked && !rdbSaida.Checked)
                {
                    MessageBox.Show("Por favor, preencha ao menos um campo para atualizar.");
                    return;
                }

                CmdSql.Clear();
                CmdSql.Append("UPDATE Movto SET ");
                List<MySqlParameter> parametros = new List<MySqlParameter>();
                bool primeiroCampo = true;

                if (!string.IsNullOrWhiteSpace(txtCod.Text))
                {
                    CmdSql.Append(primeiroCampo ? "CodProd = @CodProd" : ", CodProd = @CodProd");
                    parametros.Add(new MySqlParameter("@CodProd", int.Parse(txtCod.Text)));
                    primeiroCampo = false;
                }

                if (!string.IsNullOrWhiteSpace(txtObs.Text))
                {
                    CmdSql.Append(primeiroCampo ? "Obs = @Obs" : ", Obs = @Obs");
                    parametros.Add(new MySqlParameter("@Obs", txtObs.Text));
                    primeiroCampo = false;
                }

                if (!string.IsNullOrWhiteSpace(txtQuant.Text))
                {
                    CmdSql.Append(primeiroCampo ? "Quant = @Quant" : ", Quant = @Quant");
                    parametros.Add(new MySqlParameter("@Quant", decimal.Parse(txtQuant.Text)));
                    primeiroCampo = false;
                }

                if (dtpMovto.Checked)
                {
                    CmdSql.Append(primeiroCampo ? "DtMovto = @DtMovto" : ", DtMovto = @DtMovto");
                    parametros.Add(new MySqlParameter("@DtMovto", dtpMovto.Value));
                    primeiroCampo = false;
                }

                if (rdbEntrada.Checked)
                {
                    CmdSql.Append(primeiroCampo ? "Tipo = @Tipo" : ", Tipo = @Tipo");
                    parametros.Add(new MySqlParameter("@Tipo", "entrada"));
                }
                else if (rdbSaida.Checked)
                {
                    CmdSql.Append(primeiroCampo ? "Tipo = @Tipo" : ", Tipo = @Tipo");
                    parametros.Add(new MySqlParameter("@Tipo", "saída"));
                }

                CmdSql.Append(" WHERE CodMovto = @CodMovto");
                parametros.Add(new MySqlParameter("@CodMovto", codMovto));

                // Define a string SQL na conexão
                conexao.StrSql = CmdSql.ToString();

                int linhasAfetadas = conexao.ExecutarCmd(parametros);

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Registro atualizado com sucesso!");
                   ChamarGrid();
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado com o Código do Movimento fornecido.");
                }

                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar o registro: {ex.Message}");
            }
        }


    }
    }
