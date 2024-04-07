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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-BURAK;Initial Catalog=CMSDb;Integrated Security=True;");

        public static string _user;
        private void login()
        {
            _user = textboxUsername.Text;
            if (textboxUsername.Text == "" || textboxPassword.Text == "")
            {
                MessageBox.Show("Enter username or password");
            }
            else
            {
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT count(*) FROM TableUser WHERE Username='"+textboxUsername.Text+"' AND UserPassword='"+textboxPassword.Text+"'", sqlConnection);   
                DataTable dataTable = new DataTable();  
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows[0][0].ToString() == "1")
                {
                    UserHomePage userHomePage = new UserHomePage();
                    userHomePage.Show();
                    this.Hide();
                    _user = textboxUsername.Text;
                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                }
                sqlConnection.Close();
            }


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            login();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
