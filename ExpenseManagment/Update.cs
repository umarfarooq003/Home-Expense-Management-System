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
    public partial class Update : Form
    {
        public event EventHandler UpdateSuccessful;
        private const string ConnectionString = "Data Source=DESKTOP-5BG8Q2I;Initial Catalog=HomeExpense;Integrated Security=True;Encrypt=False";
        public Update()
        {
            InitializeComponent();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string ExpenseName = ExpenseTextBox.Text;
            string Category = comboBox1.SelectedItem.ToString();
            string amount = AmounttextBox.Text;
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string description = richTextBox1.Text;

            SqlConnection sqlconnection = new SqlConnection(ConnectionString);
            sqlconnection.Open();
            SqlCommand cmd = new SqlCommand("Update Expense set [expense name]=@expenseName, category=@category,amount=@amount,date=@date,description=@description where id=@id", sqlconnection);
            cmd.Parameters.AddWithValue("@id", int.Parse(IDTextBox.Text));
            cmd.Parameters.AddWithValue("@expenseName", ExpenseName);
            cmd.Parameters.AddWithValue("@category", Category);
            cmd.Parameters.AddWithValue("@amount", int.Parse(amount));
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.ExecuteNonQuery();
            sqlconnection.Close();
            MessageBox.Show("Updated Successfully");
            OnUpdateSuccessful();
            ClearData();
            TotalIncome();
        }

        private void ClearData()
        {
            IDTextBox.Text = "";
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


        protected virtual void OnUpdateSuccessful()
        {
            UpdateSuccessful?.Invoke(this, EventArgs.Empty);
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }

       
    }
}
