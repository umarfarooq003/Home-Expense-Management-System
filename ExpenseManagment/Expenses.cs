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
    public partial class Expenses : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-5BG8Q2I;Initial Catalog=HomeExpense;Integrated Security=True;Encrypt=False";
        public Expenses()
        {
            InitializeComponent();
        }

        private void Expenses_Load(object sender, EventArgs e)
        {

        }


        private void SaveExpbtn_Click(object sender, EventArgs e)
        {
            string ExpenseName = ExpenseTextBox.Text;
            string Category = comboBox1.SelectedItem.ToString();
            string amount = AmounttextBox.Text;
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string description = richTextBox1.Text;

            if (string.IsNullOrEmpty(ExpenseName) || string.IsNullOrEmpty(Category) || string.IsNullOrEmpty(amount) || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fill in the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();

                using (SqlCommand cmd = new SqlCommand("INSERT INTO Expense ([expense name], category, amount, date, description) VALUES (@expenseName, @category, @amount, @date, @description)", sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@expenseName", ExpenseName);
                    cmd.Parameters.AddWithValue("@category", Category);
                    cmd.Parameters.AddWithValue("@amount", int.Parse(amount));
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@description", description);

                    cmd.ExecuteNonQuery();

                }

                MessageBox.Show("Data Inserted Successfully");
            }

            ClearData();
            TotalIncome();


        }
        private void ClearData()
        {
            ExpenseTextBox.Text = "";
            AmounttextBox.Text = "";
            richTextBox1.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            AmountINRupeesLabel.Text = "";
            comboBox1.SelectedItem = null;
        }
        private void TotalIncome()
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string Query = "Select  sum(amount) from Expense";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, sqlConnection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            AmountINRupeesLabel.Text = dataTable.Rows[0][0].ToString();
            sqlConnection.Close();
        }

        private void DashBoard_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard=new DashBoard();
            dashBoard.Show();
            this.Hide();
        }

        private void IncomeLabel_Click(object sender, EventArgs e)
        {
            Income income=new Income();
            income.Show();
            this.Hide();
        }

        private void VeiwIncome_Click(object sender, EventArgs e)
        {
            Veiw_Income income = new Veiw_Income();
            income.Show();
            this.Hide();
        }

        private void VeiwExpensesLabel_Click(object sender, EventArgs e)
        {
            VeiwExpenses veiwExpenses = new VeiwExpenses();
            veiwExpenses.Show();
            this.Hide();
        }
    }
}
