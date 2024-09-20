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

namespace ExpenseManagment
{
    public partial class Veiw_Income : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-5BG8Q2I;Initial Catalog=HomeExpense;Integrated Security=True;Encrypt=False";
        public Veiw_Income()
        {
            InitializeComponent();
        }

        private void Veiw_Income_Load(object sender, EventArgs e)
        {

        }

        private void DashBoard_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            this.Hide();
        }

        private void IncomeLabel_Click(object sender, EventArgs e)
        {
            Income income = new Income();
            income.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Expenses expenses = new Expenses();
            expenses.ShowDialog();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            VeiwExpenses expenses = new VeiwExpenses();
            expenses.ShowDialog();
            this.Hide();
        }


        private void QueryRunner(SqlCommand cmd, SqlConnection connection)
        {
            using (cmd)
            {
                var reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                dataGridView1.DataSource = table;
            }
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection(ConnectionString);
            sqlconnection.Open();
            string Query1 = "Select * from Income";
            SqlCommand sqlCommand = new SqlCommand(Query1, sqlconnection);
            QueryRunner(sqlCommand, sqlconnection);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Income ic = new Income();
            ic.Show();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Delete_Income delete_Income = new Delete_Income();
            delete_Income.Show();
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateIncome updateIncome = new UpdateIncome(); 
            updateIncome.Show();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string IncomeName = ExpenseNametextbox.Text;
            string Category = comboBox1.SelectedItem?.ToString(); // Ensure comboBox1.SelectedItem is not null

            if (!string.IsNullOrEmpty(IncomeName) && !string.IsNullOrEmpty(Category))
            {
                SqlConnection sqlconnection = new SqlConnection(ConnectionString);
                sqlconnection.Open();
                string Query = "SELECT * FROM Income WHERE [income name] = @IncomeName AND category = @Category";
                SqlCommand sqlCommand = new SqlCommand(Query, sqlconnection);
                sqlCommand.Parameters.AddWithValue("@IncomeName", IncomeName);
                sqlCommand.Parameters.AddWithValue("@Category", Category);

                QueryRunner(sqlCommand, sqlconnection);
                ClearData();
            }
            else
            {
                MessageBox.Show("Expense name and category must be specified for the search.");
            }
        }

        private void ClearData()
        {
            ExpenseNametextbox.Text = "";
            comboBox1.SelectedItem = null;
        }
    }
}
