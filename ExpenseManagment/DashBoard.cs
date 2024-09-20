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
    public partial class DashBoard : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-5BG8Q2I;Initial Catalog=HomeExpense;Integrated Security=True;Encrypt=False";
        public DashBoard()
        {
            try
            {
                InitializeComponent();
                GetTotalIncome();
                GetTotalTransactionIncome();
                GetTotalExpense();
                GetTotalTransactionExpense();
                GetMaximumExpense();
                GetMinimumExpense();
                GetMaximumIncome();
                GetMinimumIncome();
                GetLastExpenseTransaction();
                GetLastIncomeTransaction();
                GetBalance();
                GetBestIncomeCategory();
                GetLastIncomeTransactionDate();
                GetLastExpenseTransactionDate();
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Dashboardpicturebox_Click(object sender, EventArgs e)
        {
           
        }
        public void GetTotalIncome()
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string Query = "Select  sum(amount) from Income";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, sqlConnection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            AmountINRupeesLabel.Text = "Rs " + dataTable.Rows[0][0].ToString();
            sqlConnection.Close();
        }

        private void GetTotalTransactionIncome()
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string Query = "Select  Count(*) from Income";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, sqlConnection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            IncomeNumberLabel.Text = dataTable.Rows[0][0].ToString();
            sqlConnection.Close();
        }

        public void GetTotalExpense()
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string Query = "Select  sum(amount) from Expense";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, sqlConnection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            AmountInRupeesExepenseLabel.Text = "Rs " + dataTable.Rows[0][0].ToString();
            sqlConnection.Close();
        }


        private void GetTotalTransactionExpense()
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string Query = "Select  Count(*) from Expense";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, sqlConnection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            ExpenseNumberLabel.Text = dataTable.Rows[0][0].ToString();
            sqlConnection.Close();
        }

        private void GetMaximumExpense()
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string Query = "SELECT MAX(amount) FROM Expense";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, sqlConnection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            MaximumExpenseLabel.Text = "Rs " + dataTable.Rows[0][0].ToString();
            sqlConnection.Close();
        }

        private void GetMinimumExpense()
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string Query = "SELECT MIN(amount) FROM Expense";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, sqlConnection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            MinimumExpenseLabel.Text = "Rs " + dataTable.Rows[0][0].ToString();
            sqlConnection.Close();
        }



        private void GetMaximumIncome()
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string Query = "SELECT MAX(amount) FROM Income";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, sqlConnection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            MaxIncomeLabel.Text = "Rs " + dataTable.Rows[0][0].ToString();
            sqlConnection.Close();
        }

        private void GetMinimumIncome()
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string Query = "SELECT MIN(amount) FROM Income";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, sqlConnection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            MinimumIncomeLabel.Text ="Rs "+ dataTable.Rows[0][0].ToString();
            sqlConnection.Close();
        }

        private void GetLastIncomeTransaction()
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string Query = "SELECT Max(date) from Income";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, sqlConnection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            LastIncomeLabel.Text = dataTable.Rows[0][0].ToString();
            sqlConnection.Close();
        }


        private void GetLastExpenseTransaction()
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string Query = "SELECT Max(date) from Expense";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, sqlConnection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            LastExpenseLabel.Text = dataTable.Rows[0][0].ToString();
            sqlConnection.Close();
        }

        private void GetBalance()
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();

            // Get total expense
            string ExpenseQuery = "Select sum(amount) from Expense";
            SqlDataAdapter adapter = new SqlDataAdapter(ExpenseQuery, sqlConnection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            string Expense = dataTable.Rows[0][0].ToString();

            sqlConnection.Close();

            sqlConnection.Open();

            // Get total income
            string IncomeQuery = "Select sum(amount) from Income";
            SqlDataAdapter adapter1 = new SqlDataAdapter(IncomeQuery, sqlConnection);
            DataTable dataTable1 = new DataTable();
            adapter1.Fill(dataTable1);
            string Income = dataTable1.Rows[0][0].ToString(); 

            sqlConnection.Close();

            // Convert strings to double
            double doubleIncome = double.Parse(Income);
            double doubleExpense = double.Parse(Expense);

            // Calculate and display the balance
            double Balance = doubleIncome - doubleExpense;
            BalanceLabel.Text = "Rs " + Balance.ToString(); 
        }


        private void GetBestIncomeCategory()
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string InnerQuery = "SELECT MAX(amount) from Income";
            SqlDataAdapter adapter = new SqlDataAdapter(InnerQuery, sqlConnection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            string Query = "Select category from Income where amount= " + dataTable.Rows[0][0].ToString();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Query,sqlConnection);
            DataTable dataTable2 = new DataTable();
            sqlDataAdapter.Fill(dataTable2);
            BestIncomecategory.Text = dataTable2.Rows[0][0].ToString();
            sqlConnection.Close();
        }


        private void GetLastIncomeTransactionDate()
        {
            GetLastTransactionIncomeDate.Text = "";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string Query = "SELECT Max(date) from Income";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, sqlConnection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            GetLastTransactionIncomeDate.Text = dataTable.Rows[0][0].ToString();
            sqlConnection.Close();
        }


        private void GetLastExpenseTransactionDate()
        {
            LastExpenseDate.Text = "";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string Query = "SELECT Max(date) from Expense";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, sqlConnection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            LastExpenseDate.Text = dataTable.Rows[0][0].ToString();
            sqlConnection.Close();
        }




        private void IncomeLabel_Click(object sender, EventArgs e)
        {
            Income income = new Income();
            income.ShowDialog();
        }

        private void VeiwIncomeLabel_Click(object sender, EventArgs e)
        {
            Veiw_Income veiw_Income = new Veiw_Income();
            veiw_Income.ShowDialog();
        }

        private void ExpensesLabel_Click(object sender, EventArgs e)
        {
            Expenses expenses=new Expenses();
            expenses.ShowDialog();
            
        }

        private void VeiwExpensesLabel_Click(object sender, EventArgs e)
        {
            VeiwExpenses veiwExpenses = new VeiwExpenses();
            veiwExpenses.ShowDialog();
            
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
    }
}
