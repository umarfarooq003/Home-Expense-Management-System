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
    public partial class UpdateIncome : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-5BG8Q2I;Initial Catalog=HomeExpense;Integrated Security=True;Encrypt=False";
        public UpdateIncome()
        {
            InitializeComponent();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string IncomeName = IncomeTextBox.Text;
            string Category = comboBox1.SelectedItem.ToString();
            string amount = AmounttextBox.Text;
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string description = richTextBox1.Text;

            SqlConnection sqlconnection = new SqlConnection(ConnectionString);
            sqlconnection.Open();
            SqlCommand cmd = new SqlCommand("Update Income set [income name]=@incomeName, category=@category,amount=@amount,date=@date,description=@description where id=@id", sqlconnection);
            cmd.Parameters.AddWithValue("@id", int.Parse(IDTextBox.Text));
            cmd.Parameters.AddWithValue("@incomeName", IncomeName);
            cmd.Parameters.AddWithValue("@category", Category);
            cmd.Parameters.AddWithValue("@amount", int.Parse(amount));
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.ExecuteNonQuery();
            sqlconnection.Close();
            MessageBox.Show("Updated Successfully");
            ClearData();
            TotalIncome();

        }


        private void ClearData()
        {
            IDTextBox.Text = "";
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
            SqlDataAdapter adapter = new SqlDataAdapter(Query, sqlConnection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            AmountINRupeesLabel.Text = dataTable.Rows[0][0].ToString();
            sqlConnection.Close();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
