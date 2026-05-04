using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LogiN
{
    public partial class TelaPedidos : Form
    {
        int idSelecionado = 0;
        bool modoEdicao = false;

        string conexao = "server=localhost;database=Projeto;uid=root;pwd=;";

        public TelaPedidos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += TelaPedidos_Load;
        }

        private void TelaPedidos_Load(object sender, EventArgs e)
        {
            CarregarPedidos();
            CarregarClientes();
            CarregarServicos();

            cmbStatusP.Items.Add("Pendente");
            cmbStatusP.Items.Add("Em andamento");
            cmbStatusP.Items.Add("Finalizado");
        }

        private void CarregarPedidos()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();

                    string sql = @"SELECT p.Id,
                                          c.Nome AS Cliente,
                                          s.Tipo AS Servico,
                                          p.Valor,
                                          p.Status
                                   FROM Pedidos p
                                   JOIN Clientes c ON p.ClienteId = c.Id
                                   JOIN Servicos s ON p.ServicoId = s.Id";

                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvPedidos.DataSource = dt;

                    EstiloGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar:\n" + ex.ToString());
            }
        }

        private void CarregarClientes()
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();

                string sql = "SELECT Id, Nome FROM Clientes";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbClienteP.DataSource = dt;
                cmbClienteP.DisplayMember = "Nome";
                cmbClienteP.ValueMember = "Id";
            }
        }

        private void CarregarServicos()
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();

                string sql = "SELECT Id, Tipo, Valor FROM Servicos";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbTipodeServicoP.DataSource = dt;
                cmbTipodeServicoP.DisplayMember = "Tipo";
                cmbTipodeServicoP.ValueMember = "Id";
            }
        }

        private void EstiloGrid()
        {
            dgvPedidos.EnableHeadersVisualStyles = false;

            dgvPedidos.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvPedidos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dgvPedidos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 165, 187);
            dgvPedidos.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvPedidos.RowHeadersVisible = false;
            dgvPedidos.BorderStyle = BorderStyle.None;
            dgvPedidos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvPedidos.GridColor = Color.White;

            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.MultiSelect = false;
            dgvPedidos.ReadOnly = true;
            dgvPedidos.AllowUserToAddRows = false;

            dgvPedidos.Columns["Id"].Visible = false;

            dgvPedidos.Columns["Cliente"].HeaderText = "Cliente";
            dgvPedidos.Columns["Servico"].HeaderText = "Serviço";
            dgvPedidos.Columns["Valor"].HeaderText = "Valor";
            dgvPedidos.Columns["Status"].HeaderText = "Status";

            dgvPedidos.Columns["Valor"].DefaultCellStyle.Format = "C2";

            dgvPedidos.ClearSelection();
        }

        private void cmbTipodeServicoP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipodeServicoP.SelectedItem is DataRowView row)
            {
                txtValorP.Text = row["Valor"].ToString();
            }
        }
        
        private void btnSalvarP_Click(object sender, EventArgs e)
        {
            int clienteId = Convert.ToInt32(cmbClienteP.SelectedValue);
            int servicoId = Convert.ToInt32(cmbTipodeServicoP.SelectedValue);
            string status = cmbStatusP.Text;

            decimal valor;
            if (!decimal.TryParse(txtValorP.Text.Replace(",", "."),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out valor))
            {
                MessageBox.Show("Valor inválido!");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();

                if (!modoEdicao)
                {
                    string sql = "INSERT INTO Pedidos (ClienteId, ServicoId, Valor, Status) VALUES (@c,@s,@v,@st)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@c", clienteId);
                    cmd.Parameters.AddWithValue("@s", servicoId);
                    cmd.Parameters.AddWithValue("@v", valor);
                    cmd.Parameters.AddWithValue("@st", status);

                    cmd.ExecuteNonQuery();
                }
                else
                {
                    string sql = "UPDATE Pedidos SET ClienteId=@c, ServicoId=@s, Valor=@v, Status=@st WHERE Id=@id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@c", clienteId);
                    cmd.Parameters.AddWithValue("@s", servicoId);
                    cmd.Parameters.AddWithValue("@v", valor);
                    cmd.Parameters.AddWithValue("@st", status);
                    cmd.Parameters.AddWithValue("@id", idSelecionado);

                    cmd.ExecuteNonQuery();
                }
            }

            CarregarPedidos();
        }

        private void btnExcluirP_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvPedidos.CurrentRow.Cells["Id"].Value);

                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();

                    string sql = "DELETE FROM Pedidos WHERE Id=@id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }

                CarregarPedidos();
            }
        }

        private void txtBuscaP_TextChanged(object sender, EventArgs e)
        {
            if (dgvPedidos.DataSource is DataTable dt)
            {
                dt.DefaultView.RowFilter =
                    $"Cliente LIKE '%{txtBuscaP.Text}%' OR Servico LIKE '%{txtBuscaP.Text}%'";
            }
        }

        private void btnClientesP_Click(object sender, EventArgs e)
        {
            new TelaClientes().Show();
            this.Hide();
        }

        private void btnEstoqueP_Click(object sender, EventArgs e)
        {
            new TelaEstoque().Show();
            this.Hide();
        }

        private void btnServicosP_Click(object sender, EventArgs e)
        {
            new TelaServicos().Show();
            this.Hide();
        }
    }
}