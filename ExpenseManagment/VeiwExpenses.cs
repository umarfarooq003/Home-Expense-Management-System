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
    public partial class VeiwExpenses : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-5BG8Q2I;Initial Catalog=HomeExpense;Integrated Security=True;Encrypt=False";
        public VeiwExpenses()
        {
            InitializeComponent();
            Update form2 = new Update();
            Delete delete = new Delete();
            form2.UpdateSuccessful += Update_UpdateSuccessful;
            delete.UpdateSuccessful += Delete_UpdateSuccessful;
        }
        private void Delete_UpdateSuccessful(object sender, EventArgs e)
        {
            ShowBtn_Click(sender, e);
        }

        private void Update_UpdateSuccessful(object sender, EventArgs e)
        {

            ShowBtn_Click(sender, e);
        }

        private void DashBoard_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.ShowDialog();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IncomeLabel_Click(object sender, EventArgs e)
        {
            Income income=new Income();
            income.ShowDialog();
            this.Hide();
        }

        private void VeiwIncome_Click(object sender, EventArgs e)
        {
            Veiw_Income veiw_Income=new Veiw_Income();
            veiw_Income.ShowDialog();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Expenses expenses=new Expenses();
            expenses.ShowDialog();
            this.Hide();
        }

      

        private void VeiwExpenses_Load(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Expenses expenses = new Expenses();
            expenses.ShowDialog();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            update.ShowDialog();
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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.ShowDialog();
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {

            SqlConnection sqlconnection = new SqlConnection(ConnectionString);
            sqlconnection.Open();
            string Query = "Select * from Expense";
            SqlCommand sqlCommand= new SqlCommand(Query, sqlconnection);
            QueryRunner(Query,sqlconnection);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string ExpenseName = ExpenseNametextbox.Text;
            string Category = comboBox1.SelectedItem?.ToString(); // Ensure comboBox1.SelectedItem is not null

            if (!string.IsNullOrEmpty(ExpenseName) && !string.IsNullOrEmpty(Category))
            {
                SqlConnection sqlconnection = new SqlConnection(ConnectionString);
                sqlconnection.Open();
                string Query = "SELECT * FROM Expense WHERE [expense name] = @ExpenseName AND category = @Category";
                SqlCommand sqlCommand = new SqlCommand(Query, sqlconnection);
                sqlCommand.Parameters.AddWithValue("@ExpenseName", ExpenseName);
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

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
