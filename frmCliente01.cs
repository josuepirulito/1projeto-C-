using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1projeto_C_
{
    public partial class frmCliente01 : UserControl
    {
        public frmCliente01()
        {
            InitializeComponent();
        }


        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-BVL8D62;integrated security=SSPI;initial Catalog=db_livraria");

        SqlCommand cm = new SqlCommand();



        private void desabilitaCampos()
        {
            
            lbl_Codclic.Visible = false;

            comboBox1.Enabled = false;
            label9.Enabled = false;
            btnNovo.Enabled = true;
            txtNome.Enabled = false;
            txtLogin.Enabled = false;
            maskedTextBox1.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            textBox1.Enabled = false;
            textBox7.Enabled = false;
            textBox2.Enabled = false;
            textBox8.Enabled = false;
            textBox3.Enabled = false;
            maskedTextBox3.Enabled = false;
            comboBox2.Enabled = false;
            lblCNPJ.Visible = false;
            maskedTextBox4.Visible = false;
            maskedTextBox2.Enabled = false;
            
            
            


        }
        private void habilitaCampos()
        {
            lbl_Codclic.Visible = false;

            comboBox1.Enabled = true;
            label9.Enabled = true;
            maskedTextBox1.Enabled =  true;
            btnNovo.Enabled = false;
            txtNome.Enabled = true;
            txtLogin.Enabled = true;
            maskedTextBox1.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            textBox1.Enabled = true;
            textBox7.Enabled = true;
            textBox2.Enabled = true;
            textBox8.Enabled = true;
            textBox3.Enabled = true;
            maskedTextBox3.Enabled = false;
            comboBox2.Enabled = true;
            maskedTextBox2.Enabled = true;
            lblCNPJ.Visible = false;
            maskedTextBox4.Visible = false;
            maskedTextBox3.Enabled = true;




           


        }
        private void limparCampos()
        {
            txtNome.Clear();
            txtLogin.Clear();
            maskedTextBox1.Clear();

            
            textBox1.Clear();
            textBox7.Clear();
            textBox2.Clear();
            textBox8.Clear();
            textBox3.Clear();
            maskedTextBox3.Clear();
            comboBox2.SelectedIndex = -1;
            maskedTextBox2.Clear();
            txtBuscar.Clear();
            comboBox1.SelectedIndex = -1; 


            lblCodigo.Visible = false;
            rdbAti.Checked = true;
            dgvFunc.DataSource = null;
            lbl_Codclic.Visible = true;


          

        }
        private void manipularDados()
        {
           

        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1)// se nao houver nada selecionado
            {
                lblCNPJ.Visible = false;
                maskedTextBox4.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 0)// se estiver selecionado fisica

            {
                lblCNPJ.Visible = false;
                maskedTextBox4.Visible = false;
            }
            else
            {
                lblCNPJ.Visible = true;
                maskedTextBox4.Visible = true;

            }


        }

        private void lblCNPJ_Click(object sender, EventArgs e)
        {

        }

        private void frmCliente01_Load(object sender, EventArgs e)
        {
            desabilitaCampos();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaCampos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvFunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabilitaCampos();




        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           if(rdbIna.Checked)
            {
                MessageBox.Show("voce precisa marca como ativo:", "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rdbAti.Checked = true;
            }
            else if (txtNome.Text == "")
            {
                MessageBox.Show("obrigatório preenche o campo Nome:", "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
            }

            else if (txtLogin.Text == "")
            {
                MessageBox.Show("obrigatório preenche o campo email:", "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLogin.Focus();
            }
            else if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("obrigatório preenche o campo telefone:", "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maskedTextBox1.Focus();
            }
            else if (maskedTextBox1.Text.Length < 11)
            {
                MessageBox.Show("obrigatório preenche o campo telefone válido:", "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maskedTextBox1.Focus();
            }
           else if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("obrigatório infoma o tipo de pessoa:", "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }


            if (comboBox1.SelectedIndex == 0 &&  maskedTextBox2.Text.Length < 11)
            {
              
               MessageBox.Show("informa cpf valido:", "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Information);
               maskedTextBox4.Focus();
                
            }

            if (comboBox1.SelectedIndex == 1 && maskedTextBox4.Text.Length < 14)
            {
               
               MessageBox.Show("informa cnpj valido:", "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Information);
               maskedTextBox4.Focus();
                
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("obrigatório preenche o campo logradouro:", "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Focus();
            }
            else if (textBox7.Text == "")
            {
                MessageBox.Show("obrigatório preenche o campo numero:", "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox7.Focus();
            }
            else if (textBox8.Text == "")
            {
                MessageBox.Show("obrigatório preenche o campo Bairro:", "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox8.Focus();
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("obrigatório preenche o campo Cidade:", "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox3.Focus();
            }
            else if (maskedTextBox3.Text.Length < 8)
            {
                MessageBox.Show("obrigatório preenche o campo CEP:", "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maskedTextBox3.Focus();
            }
            else if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("obrigatório preenche o campo UF:", "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
           else
            {
                string nome = txtNome.Text;
                string email = txtLogin.Text;
                string telefone = maskedTextBox1.Text;
                string cpf;
                string cnpj;
                string pessoa;


                if (comboBox1.SelectedIndex == 0)
                {

                    pessoa = "F";
                    cpf = maskedTextBox2.Text;
                    cnpj = "";
                }
                else
                {
                    pessoa = "J";
                    cnpj = maskedTextBox4.Text;
                    cpf = "";
                }
                
                
                try {
                    string logradouro = textBox1.Text;
                    string numero = textBox7.Text;
                    string complemento = textBox2.Text;
                    string bairro = textBox8.Text;
                    string cidade = textBox3.Text;
                    string cep = maskedTextBox3.Text;
                    string UF = comboBox2.SelectedItem.ToString();


                    string strSql = "insert into tbl_Cliente(nm_Cliente,ds_Email,no_CNPJ,nm_Logradouro,no_numero,ds_Complemento,nm_Bairro,nm_Cidade,sg_UF,no_CEP,ds_pessoa)Values(@nm_Cliente,@ds_Email,@no_CPF,@no_CNPJ,@nm_Logradouro,@no_numero,@ds_Complemento,@nm_Bairro,@nm_Cidade,@sg_UF,@no_CEP,1,@ds_pessoa)";
                    cm.CommandText = strSql;
                    cm.Connection = cn;

                 

                cm.Parameters.Add("@nm_Cliente", SqlDbType.VarChar).Value = txtNome;
                cm.Parameters.Add("@ds_Email", SqlDbType.VarChar).Value = txtLogin;
                cm.Parameters.Add("@no_CPF", SqlDbType.VarChar).Value = maskedTextBox2;
                cm.Parameters.Add("@no_CNPJ", SqlDbType.VarChar).Value = maskedTextBox4;
                cm.Parameters.Add("@nm_Logradouro", SqlDbType.VarChar).Value = textBox1;
                cm.Parameters.Add("@no_numero", SqlDbType.VarChar).Value = textBox7;
                cm.Parameters.Add("@ds_Complemento", SqlDbType.VarChar).Value = textBox2;
               
                cm.Parameters.Add("@nm_Bairro", SqlDbType.VarChar).Value = textBox8;
                cm.Parameters.Add("@nm_Cidade", SqlDbType.VarChar).Value = textBox3;
                cm.Parameters.Add("@sg_UF", SqlDbType.VarChar).Value = comboBox2;
                cm.Parameters.Add("@no_CEP", SqlDbType.VarChar).Value = maskedTextBox3;
               //cm.Parameters.Add("@ds_status", SqlDbType.VarChar).Value = status;
                cm.Parameters.Add("@ds_pessoa", SqlDbType.VarChar).Value = pessoa;
               // cm.Parameters.AddWithValue("@cd", 0).Direction = ParameterDirection.Output;
                cn.Open();
                cm.ExecuteNonQuery();
                    
               // int cd = Convert.ToInt32(cm.Parameters["@cd"].Value);
                // string celular = maskedTextBox1.Text;

                 // cm.CommandText = "insert into tbl_telefone(cd_Cliente,no_Telefone)values('" + cd + "')'" + celular + "')";
                    
                cm.Connection = cn;
                cm.ExecuteNonQuery();

                MessageBox.Show("Os dados do cliente foram inseridos com sucesso!!","Dados inseridos");
                    limparCampos();
                    cn.Close();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
