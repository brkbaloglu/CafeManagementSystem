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
    public partial class UserDetails : Form
    {
        public UserDetails()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-BURAK;Initial Catalog=CMSDb;Integrated Security=True;");

        private void updateData()
        {
            sqlConnection.Open();
            string query = "UPDATE TableUser SET Username='"+textboxUsername.Text+"', UserPhone='"+textboxPhone.Text+"', UserPassword='"+textboxPassword.Text+"';";
            string query2 = "UPDATE TableOrder SET OrderUser='"+textboxUsername.Text+"';";
            SqlCommand sqlCommand  = new SqlCommand(query, sqlConnection);
            SqlCommand sqlCommand2  = new SqlCommand(query2, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlCommand2.ExecuteNonQuery();
            MessageBox.Show("User successfully updated");
            sqlConnection.Close();
        }
        
        private void UserDetails_Load(object sender, EventArgs e)
        {
            labelUsername.Text = Form1._user;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UserDetails userDetails = new UserDetails();
            userDetails.Show();
            this.Hide();    
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            updateData();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
