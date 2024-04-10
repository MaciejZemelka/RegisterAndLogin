using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace RegAndLog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static bool IsValid(string email)
        {
            string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov|pl)$";

            return Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
        }

       private static string EncryptionedPassword(string pass)
        {
            Random rnd = new Random();
            char[] password = pass.ToCharArray();
            char[] encrypted=new char[pass.Length*3];
            char letter;
            for(int i = 1,h=0; i <= pass.Length*3; i++)
            {
                if (i % 3 == 0)
                {
                    int d = password[h] - '0';
                    letter = (char)d;
                    encrypted[i - 1] = letter;
                    h++;
                }
                else
                {
                    int start = 40;
                    int end = 122;
                    int Rolled = rnd.Next(start, end);
                    encrypted[i-1]=(char)Rolled;
                    
                }

            }
            string result=new string (encrypted);
            return result;
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-56JN8FK;Initial Catalog=LoginDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            int err = 0;
            try
            {
                if (u_name.Text == "" || e_mail.Text == "" || b_date.Text == "" || gender.Text == "" || password.Text == "" || con_password.Text == "")
                {
                    err = 1;
                    MessageBox.Show("Fill in the blank");
                }
                int v = check(e_mail.Text, u_name.Text);
                if (v == 1 && err == 0)
                {
                    err = 1;
                    MessageBox.Show("You are already registered with this e-mail or this username is already used!");
                }
                if (!IsValid(e_mail.Text) && err == 0)
                {
                    err = 1;
                    MessageBox.Show("email is ivalid");
                }
                if (password.Text != con_password.Text && err==0)
                {
                    err = 1;
                    MessageBox.Show("passwords doesn't match");
                }
                if (err == 0)
                {

                    string newPass=EncryptionedPassword(password.Text);

                    connection.Open();
                    SqlCommand command = new SqlCommand("insert into RegistrationTbl values(@u_name, @email, @b_date, @gender, @password)", connection);
                    command.Parameters.AddWithValue("@u_name", u_name.Text);
                    command.Parameters.AddWithValue("@email", e_mail.Text);
                    command.Parameters.AddWithValue("@b_date", Convert.ToDateTime(b_date.Text));
                    command.Parameters.AddWithValue("@gender", gender.Text);
                    command.Parameters.AddWithValue("@password", newPass);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Register Successfuly!");
                    u_name.Text = "";
                    e_mail.Text = "";
                    b_date.Text = "";
                    gender.Text = "";
                    password.Text = "";
                    con_password.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        
        int check(string email, string name)
        {
            connection.Open();
            string query = "select count(*) from RegistrationTbl where email='" + email + "' OR u_name='" + name + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int v = (int)command.ExecuteScalar();
            connection.Close();
            return v;
        }

        private void show_pass_Click(object sender, EventArgs e)
        {
            if (password.PasswordChar == '*') password.PasswordChar = '\0';
            else password.PasswordChar = '*';

        }

        private void show_con_pass_Click(object sender, EventArgs e)
        {
            if (con_password.PasswordChar == '*') con_password.PasswordChar = '\0';
            else con_password.PasswordChar = '*';
        }

        private void SignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
