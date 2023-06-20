using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _1projeto_C_
{
    public partial class fromAtendente : UserControl
    {
        public fromAtendente()
        {
            InitializeComponent();
        }

        //Estabelecendo conexao com banco de dados sql server
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-BVL8D62;integrated security=SSPI;initial Catalog=db_livraria");

        SqlCommand cm = new SqlCommand();

        SqlDataReader dt;

        private void desabilitaCampos()
        {
            lblCodigo.Visible = false;
            lbl_Cod.Visible = false;

            btnNovo.Enabled = true;
            txtNome.Enabled = false;
            txtLogin.Enabled = false;
            txtSenha.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;

        }
        private void habilitaCampos()
        {
            txtNome.Enabled = true;
            txtLogin.Enabled = true;
            txtSenha.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

            txtNome.Focus();
            txtBuscar.Text = "";
            dgvFunc.DataSource = null;


        }
        private void limparCampos()
        {
            txtNome.Text = "";
            txtLogin.Clear();
            txtSenha.Clear();
            txtNome.Focus();
            txtBuscar.Clear();
            dgvFunc.DataSource = null;
            rdbAti.Checked = true;
            lbl_Cod.Visible = false;

        }
        private void manipularDados()
        {
            lblCodigo.Visible = true;
            lbl_Cod.Visible = true;

            btnAlterar.Enabled = true;
            btnCancelar.Enabled = true;
            btnExclui.Enabled = true;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = false;

            txtNome.Enabled = true;
            txtLogin.Enabled = true;
            txtSenha.Enabled = true;
        }

        private void lbl_Login_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Altera_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório informa o campo nome.", "Atenção 🚨", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
            }
            else if (txtLogin.Text == "")
            {
                MessageBox.Show("Obrigatório informa o campo Login.", "Atenção 🚨", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Focus();
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Obrigatório informa o campo Senha.", "Atenção 🚨", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
            }
            else if (txtSenha.Text.Length < 8)
            {
                MessageBox.Show("O campo Senha deve conter no minimo 8 digitos.", "Atenção 🚨", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
            }
            else
            {
                try
                {
                    string nome = txtNome.Text;
                    string login = txtLogin.Text;
                    string senha = txtSenha.Text;

                    int cd = Convert.ToInt32( lbl_Cod.Text);

                    string strsql = "update tbl_atendente set ds_Login=@Login,ds_Senha=@Senha,nm_atendente=@atendente where cd_atendente=@cd";
          

                    cm.CommandText = strsql;
                    cm.Connection = cn;


                    cm.Parameters.Add("@Login", SqlDbType.VarChar).Value = login;
                    cm.Parameters.Add("@Senha", SqlDbType.Char).Value = senha;
                    cm.Parameters.Add("@atendente", SqlDbType.VarChar).Value = nome;
                    cm.Parameters.Add("@cd", SqlDbType.Int).Value = cd;

                    cn.Open();
                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();
                    MessageBox.Show("Dados alterados com sucesso.", "Alterações de daods concluida 👍", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNome.Focus();
                    limparCampos();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();

                }
                finally
                {
                    cn.Close();
                }

            }
        }
        private void fromAtendente_Load(object sender, EventArgs e)
        {
            desabilitaCampos();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaCampos();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desabilitaCampos();
            limparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório informa o campo nome.", "Atenção 🚨",MessageBoxButtons.OK,MessageBoxIcon.Error);
                       txtNome.Focus();
            }
            else if(txtLogin.Text == "") {
                MessageBox.Show("Obrigatório informa o campo Login.", "Atenção 🚨", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Focus();
            }
            else if(txtSenha.Text == "")
            {
                MessageBox.Show("Obrigatório informa o campo Senha.", "Atenção 🚨", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
            }
            else if (txtSenha.Text.Length < 8)
            {
                MessageBox.Show("O campo Senha deve conter no minimo 8 digitos.", "Atenção 🚨", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
            }
            else
            {
                try
                {
                    string nome = txtNome.Text;
                    string login = txtLogin.Text;
                    string senha = txtSenha.Text;

                    string strsql = "insert into tbl_atendente (ds_Login,ds_Senha,nm_atendente)values(@Login,@Senha,@atendente)";

                    cm.CommandText = strsql;
                    cm.Connection = cn;
                    

                    cm.Parameters.Add("@Login", SqlDbType.VarChar).Value = login;
                    cm.Parameters.Add("@Senha", SqlDbType.Char).Value = senha;
                    cm.Parameters.Add("@atendente", SqlDbType.VarChar).Value = nome;

                    cn.Open();
                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();
                    MessageBox.Show("Dados inseridos.", "Dados no Sql 👍", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNome.Focus();
                    limparCampos();
                }
                catch(Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();

                }
                finally
                {
                    cn.Close();
                }

            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if(txtBuscar.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tbl_atendente where nm_atendente like ('"+ txtBuscar.Text +"%')";
                    cm.Connection = cn;

                    //receber os dados de uma tabela após a execução de uma Select
                    SqlDataAdapter da = new SqlDataAdapter();

                    //representar uma ou mais tabela de dados
                    DataTable dt = new DataTable();

                    //recebendo os dados da instrução Select
                    da.SelectCommand = cm;

                    da.Fill(dt);//preenchendo o datatable
                    dgvFunc.DataSource = dt;
                    cn.Close();

                }
                catch(Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                
            }
            else
            {
                dgvFunc.DataSource = null;
            }
        }
        private void carregaAtendente()
        {
            lbl_Cod.Text = dgvFunc.SelectedRows[0].Cells[0].Value.ToString();
            txtLogin.Text = dgvFunc.SelectedRows[0].Cells[1].Value.ToString();
            txtSenha.Text = dgvFunc.SelectedRows[0].Cells[2].Value.ToString();
            txtNome.Text = dgvFunc.SelectedRows[0].Cells[3].Value.ToString();

            string valor = dgvFunc.SelectedRows[0].Cells[4].Value.ToString();
            //MessageBox.Show(valor);

            if(valor == "True")
            {
                rdbAti.Checked = true;
            }
            else
            {
                rdbIna.Checked = true;
            }

            manipularDados();
        }

        private void dgvFunc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            carregaAtendente();
            if(rdbAti.Checked)
            {
                btnExclui.Enabled = true;
            }
            else
            {
                btnExclui.Enabled = false;
            }
        }

        private void btnExclui_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório informa o campo nome.", "Atenção 🚨", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
            }
            else if (txtLogin.Text == "")
            {
                MessageBox.Show("Obrigatório informa o campo Login.", "Atenção 🚨", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Focus();
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Obrigatório informa o campo Senha.", "Atenção 🚨", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
            }
            else if (txtSenha.Text.Length < 8)
            {
                MessageBox.Show("O campo Senha deve conter no minimo 8 digitos.", "Atenção 🚨", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
            }
            else if(rdbAti.Checked)
            {
                MessageBox.Show("Para remover o registro você precisa alterar os status para INATIVO.", "Erro ao tentar EXCLUIR!!! 🚨", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult exclusao = MessageBox.Show("Você tem certeza que deseja remover esse registro?","Exclusão de registo",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
           
                if(exclusao == DialogResult.No)
                {
                    return;
                }
                else
                {
                    try
                    {
                        int cd = Convert.ToInt32( lbl_Cod.Text);

                        cn.Open();
                        string strSql = "update tbl_atendente set ds_status = 0 where cd_atendente =@cd";
                        cm.CommandText = strSql;
                        cm.Connection = cn;
                        cm.Parameters.Add("@cd", SqlDbType.Int).Value = cd ;

                        cm.ExecuteNonQuery();
                        cm.Parameters.Clear();
                        MessageBox.Show("A exclusão foi executada com sucesso.", "EXCLUIDO 👍", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNome.Focus();
                        limparCampos();
                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show(erro.Message);
                        cn.Close();
                    }
                    finally
                    {
                        cn.Close();
                    }
                }
            }

        }
    }
}
