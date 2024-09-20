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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExpenseManagment
{
    public partial class Delete : Form
    {
        public event EventHandler UpdateSuccessful;
        private const string ConnectionString = "Data Source=DESKTOP-5BG8Q2I;Initial Catalog=HomeExpense;Integrated Security=True;Encrypt=False";
        public Delete()
        {
            InitializeComponent();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string ID=IDTextBox.Text;
            System.Windows.Forms.DialogResult result = MessageBox.Show("Are you sure you want to Delete it ?", "Delete ?", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("Delete From Expense  where id=@id", sqlConnection);
                cmd.Parameters.AddWithValue("@id", int.Parse(ID));
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Deleted Successfully");
                OnUpdateSuccessful();
            }
             IDTextBox.Text = "";

        }

        protected virtual void OnUpdateSuccessful()
        {
            UpdateSuccessful?.Invoke(this, EventArgs.Empty);
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection(ConnectionString);
            sqlconnection.Open();
            string Query = "Select * from Expense";
            SqlCommand sqlCommand = new SqlCommand(Query, sqlconnection);
            QueryRunner(Query, sqlconnection);
        }


        private void QueryRunner(string Query, SqlConnection connection)
        {
            using (SqlCommand cmd = new SqlCommand(Query, connection))
            {
                var reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                dataGridView1.DataSource = table;
            }
        }

        private void DashBoardLabel_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard= new DashBoard();
            dashBoard.ShowDialog();
            this.Hide();
        }

        private void IncomeLabel_Click_1(object sender, EventArgs e)
        {
            Income income = new Income();
            income.ShowDialog();
            this.Hide();
        }

        private void VeiwIncomeLabel_Click_1(object sender, EventArgs e)
        {

            Veiw_Income veiw_Income = new Veiw_Income();
            veiw_Income.ShowDialog();
            this.Hide();
        }

        private void ExpensesLabel_Click_1(object sender, EventArgs e)
        {
            Expenses expenses = new Expenses();
            expenses.ShowDialog();
            this.Hide();
        }

        private void VeiwExpensesLabel_Click_1(object sender, EventArgs e)
        {
            VeiwExpenses veiwExpenses = new VeiwExpenses();
            veiwExpenses.ShowDialog();
            this.Hide();
        }

        private void CLosebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
