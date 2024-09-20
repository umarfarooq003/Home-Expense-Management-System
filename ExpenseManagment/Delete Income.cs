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
    public partial class Delete_Income : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-5BG8Q2I;Initial Catalog=HomeExpense;Integrated Security=True;Encrypt=False";
        public Delete_Income()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection(ConnectionString);
            sqlconnection.Open();
            string Query = "Select * from Income";
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

        private void Delete_Income_Load(object sender, EventArgs e)
        {
           
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string ID = IDTextBox.Text;
            System.Windows.Forms.DialogResult result = MessageBox.Show("Are you sure you want to Delete it ?", "Delete ?", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("Delete From Income where id=@id", sqlConnection);
                cmd.Parameters.AddWithValue("@id", int.Parse(ID));
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Deleted Successfully");
            }
            IDTextBox.Text = "";
        }
    }
}
