using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegAndLog
{
    public partial class Login : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-56JN8FK;Initial Catalog=LoginDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public Login()
        {
            InitializeComponent();
        }
        private static string DecryptionedPassword(string pass)
        {
            char[] password = pass.ToCharArray();
            char[] decrypted = new char[pass.Length/3];
            char letter;
            for (int i = 1, h=0; i <= password.Length ; i++)
            {
                if (i % 3 == 0)
                {
                    int d = password[i-1] + '0';
                    letter = (char)d;
                    decrypted[h] = letter;
                    h++;
                }

            }
            string result = new string(decrypted);
            return result;
        }
        private void SignInBtn_Click(object sender, EventArgs e)
        {
            int err = 0;
            if (u_login.Text == "" || password.Text == "")
            {
                err = 1;
                MessageBox.Show("Fill in the blanks!");         
            }
            if (err == 0) {
                
                string query = "select count(*) from RegistrationTbl where email='" + u_login.Text + "' OR u_name='" + u_login.Text + "'";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                int v = (int)cmd.ExecuteScalar();
                if (v == 0) {
                    MessageBox.Show("Error username", "Error!");
                }
                else
                {
                   
                    string queryPass = "select password from RegistrationTbl where email='" + u_login.Text + "'  OR u_name='" + u_login.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(queryPass, connection);
                    using (SqlDataReader reader = cmd2.ExecuteReader())
                    {
                        
                        if (reader.Read())
                        {
                            string password2=String.Format("{0}", reader["password"]);
                            string checkPass = DecryptionedPassword(password2);
                            
                            if (checkPass == password.Text)
                            {
                                MessageBox.Show("Logged Successfully");
                            }
                            else
                            {
                                MessageBox.Show("Wrong password");
                            }
                        }
                    }
                }
                connection.Close();
            }
        }

        private void Signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void show_pass_Click(object sender, EventArgs e)
        {
            if (password.PasswordChar == '*') password.PasswordChar = '\0';
            else password.PasswordChar = '*';
        }
    }
}
