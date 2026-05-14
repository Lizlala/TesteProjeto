using MySql.Data.MySqlClient;
using System.Drawing.Text;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Web;

namespace LogiN
{
    public partial class Login : System.Windows.Forms.Form
    {
        string conexao = "server=localhost; uid=root; PWd =; Database=fiodeouro;";
        public Login()
        {
            InitializeComponent();
            this.AcceptButton = btnEntrar;
            EsqueceuSenhaPainel.Visible = false;
        }

        private string GerarNovaSenha()
        {
            return Guid.NewGuid().ToString("N").Substring(0, 8);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }



        //Esqueceu Senha.
        private void EnviarEmail(string emailDestino, string novaSenha)
        {

        }




        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            MySqlConnection con = new MySqlConnection(conexao);

            try


            {
                con.Open();

                string sql = "SELECT * FROM Login_usuario WHERE nome=@nome and senha=@senha";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@nome", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    TelaEstoque principal = new TelaEstoque();
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }






        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
        }


        private void btnSalvarS_Click(object sender, EventArgs e)
        {

            // Validação de campos vazios
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtCpf.Text) ||
                string.IsNullOrWhiteSpace(txtcadastroSenha.Text))
            {
                MessageBox.Show("Preencha todos os campos.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validação de tamanho
            if (txtCpf.Text.Length != 11 || txtcadastroSenha.Text.Length != 8)
            {
                MessageBox.Show(" CPF ou Senha inválidos.",
                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MySqlConnection con = new MySqlConnection(conexao);
            try
            {
                con.Open();
                string sql = "INSERT INTO Login_usuario(nome, cpf,senha) VALUES (@nome,@cpf,@senha);";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
                cmd.Parameters.AddWithValue("@senha", txtcadastroSenha.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro feito com sucesso, parabéns!");
                con.Close();
                if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                   string.IsNullOrWhiteSpace(txtCpf.Text) ||
                   string.IsNullOrWhiteSpace(txtcadastroSenha.Text))

                {
                    MessageBox.Show("Preencha todos os campos.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception)
            {

            }
        }

        private void btncadastraL_Click_1(object sender, EventArgs e)
        {
            PainelUsuario.Visible = true;
        }

        private void EqueceuSenha_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EsqueceuSenhaPainel.Visible = true;


        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {




            if (string.IsNullOrWhiteSpace(txtTelefone.Text))
            {
                MessageBox.Show("Informe o CPF.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            MessageBox.Show(
                "Nova senha cadastrda com sucesso.",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            EsqueceuSenhaPainel.Visible = false;

            MySqlConnection con = new MySqlConnection(conexao);
            try
            {
                con.Open();
                string sql = "INSERT INTO Login_usuário(CPF,Senha) VALUES (@CPF,@Senha);";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@CPF", txtTelefone.Text);
                cmd.Parameters.AddWithValue("@Senha", txtSenhaE.Text);

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {

            }




            if (string.IsNullOrWhiteSpace(txtTelefone.Text))
            {
                MessageBox.Show("Informe o CPF.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string novaSenha = GerarNovaSenha();

            EnviarEmail(txtTelefone.Text, novaSenha);



            // Voltar para tela principal
            EsqueceuSenhaPainel.Visible = false;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            EsqueceuSenhaPainel.Visible = false;

        }

        private void EqueceuSenha_Click(object sender, EventArgs e)
        {
            EsqueceuSenhaPainel.Visible = true;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            EsqueceuSenhaPainel.Visible = false;
        }

        private void btnVoltarS_Click_1(object sender, EventArgs e)
        {
            PainelUsuario.Visible = false;
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
