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
    public partial class UserMenu : Form
    {
        public UserMenu()
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            UserOrder userOrder = new UserOrder();
            userOrder.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UserHomePage userHomePage = new UserHomePage();
            userHomePage.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void UserMenu_Load(object sender, EventArgs e)
        {
            labelUsername.Text = Form1._user;
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
    }
}
