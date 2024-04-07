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

namespace CafeManagementSystem
{
    public partial class UserOrder : Form
    {
        public UserOrder()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-BURAK;Initial Catalog=CMSDb;Integrated Security=True;");

        private void getAllDataFromDatabase()
        {
            sqlConnection.Open();
            string query = "SELECT * FROM TableMenu";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridViewMenu.DataSource = dataSet.Tables[0];
            sqlConnection.Close();
        }
        private void getSelectedCategoryDataFromDatabase()
        {
            sqlConnection.Open();
            string query = "SELECT * FROM TableMenu WHERE MenuItemCategory='" + comboboxCategory.Text + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridViewMenu.DataSource = dataSet.Tables[0];
            sqlConnection.Close();
        }

        private void setData()
        {
            sqlConnection.Open();
            string query = "INSERT INTO TableOrder VALUES('"+labelUsername.Text+"', '"+textboxItemName.Text+"', '"+labelDate.Text+"', '"+textboxAmount.Text+"')";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Order successfully created");
            sqlConnection.Close();
        }

        private void UserOrder_Load(object sender, EventArgs e)
        {
            labelUsername.Text = Form1._user;
            labelDate.Text = DateTime.Today.Date.Day.ToString() + "/" + DateTime.Today.Date.Month.ToString() + "/" + DateTime.Today.Date.Year.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UserHomePage userHomePage = new UserHomePage();
            userHomePage.Show();
            this.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            UserMenu userMenu = new UserMenu();
            userMenu.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UserDetails userDetails = new UserDetails();
            userDetails.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void comboboxCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboboxCategory.Text == "All")
            {
                getAllDataFromDatabase();
            }
            else
            {
                getSelectedCategoryDataFromDatabase();
            }
        }

        private void dataGridViewMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            setData();
        }
    }
}
