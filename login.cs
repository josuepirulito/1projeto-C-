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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        public static string usuario;
        public static string CodUsuario;

        //Estabelecendo conexao com banco de dados sql server
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-BVL8D62;integrated security=SSPI;initial Catalog=db_livraria");

        SqlCommand cm = new SqlCommand();

       // SqlDataReader dt;

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = false;
        }

        private void btnSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text==""|| txtSenha.Text=="")
            {
                MessageBox.Show("Preencher os campos login e senha:", "Atenção !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tbl_atendente where ds_login = ('"+txtLogin.Text+"' ) and ds_Senha = ('"+txtSenha.Text+"') and ds_status = 1";
                    cm.Connection = cn;
                    SqlDataAdapter da = new SqlDataAdapter(cm);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                   // dt = cm.ExecuteReader();

                    if(dt.Rows.Count > 0) //a contagem de linhas do datatable e maior que zero ?
                    {
                        usuario = dt.Rows[0]["ds_Login"].ToString();
                        CodUsuario = dt.Rows[0]["cd_atendente"].ToString();
                        frmMenu menu = new frmMenu();
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos:", "Ocorreu um erro !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtLogin.Clear();
                        txtSenha.Clear();
                        txtLogin.Focus();

                    }
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
