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
    public partial class UserHomePage : Form
    {
        public UserHomePage()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-BURAK;Initial Catalog=CMSDb;Integrated Security=True;");

        private void getDataFromDatabase()
        {
            sqlConnection.Open();
            string query = "SELECT * FROM TableOrder WHERE OrderUser='"+labelUsername.Text+"'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var dataSet = new DataSet();  
            sqlDataAdapter.Fill(dataSet);
            dataGridViewLastOrder.DataSource = dataSet.Tables[0];
            sqlConnection.Close();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UserMenu userMenu = new UserMenu();
            userMenu.Show();
            this.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            UserOrder userOrder = new UserOrder();
            userOrder.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void UserHomePage_Load(object sender, EventArgs e)
        {
            labelUsername.Text = Form1._user;
            getDataFromDatabase();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UserDetails userDetails = new UserDetails();
            userDetails.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewLastOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
