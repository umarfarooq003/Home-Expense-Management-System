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
using System.Xml.Linq;

namespace ExpenseManagment
{
    public partial class Income : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-5BG8Q2I;Initial Catalog=HomeExpense;Integrated Security=True;Encrypt=False";
        public Income()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void DashBoard_Click(object sender, EventArgs e)
        {
            DashBoard dashboard = new DashBoard();
            dashboard.Show();
            this.Hide();
    }

        private void SaveIncomebtn_Click(object sender, EventArgs e)
        {
            string IncomeName = IncomeTextBox.Text;
            string Category = comboBox1.SelectedItem.ToString();
            string amount = AmounttextBox.Text;
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string description = richTextBox1.Text;
            string amountinRupeesLabel=AmountINRupeesLabel.Text;

            if (string.IsNullOrEmpty(IncomeName) || string.IsNullOrEmpty(Category) || string.IsNullOrEmpty(amount) || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fill in the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();

                using (SqlCommand cmd = new SqlCommand("INSERT INTO Income ([income name], category, amount, date, description) VALUES (@incomeName, @category, @amount, @date, @description)", sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@incomeName", IncomeName);
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
            IncomeTextBox.Text = "";
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
            string Query = "Select  sum(amount) from Income";
            SqlDataAdapter adapter = new SqlDataAdapter(Query,sqlConnection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            AmountINRupeesLabel.Text = dataTable.Rows[0][0].ToString();
            sqlConnection.Close();
        }

        private void VeiwIncome_Click(object sender, EventArgs e)
        {
            Veiw_Income income = new Veiw_Income();
            income.ShowDialog();
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
            VeiwExpenses expenses=new VeiwExpenses();
            expenses.ShowDialog();
            this.Hide();
        }
    }
}
