using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Media;

namespace Dental_System
{
    public partial class Login : Form
    {
        dbProvider db = new dbProvider();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void Login_MouseLeave(object sender, EventArgs e)
        {
           
        }

        string name;
        string acct;
        string aID;
        private void btnLogin_Click(object sender, EventArgs e)
        {

            string layer1 = db.getMD5(txtPass.Text);
            string layer2 = db.getMD5(layer1);
            string layer3 = db.getMD5(layer2);
            string layer4 = db.getMD5(layer3);
            string layer5 = db.getMD5(layer4);

            string connect = "Server=localhost;user id = dbconnection; password = 09353276080; Database = clinic";
            string command = "select * from clinic.users where username = '" + this.txtUser.Text + "' and password = '" + layer5.ToString() + "' and active ='Y'";


            MySqlConnection con = new MySqlConnection(connect);
            MySqlCommand cmd = new MySqlCommand(command, con);
            MySqlDataReader dr;




            int counter = 0;


            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    counter += 1;
                    name = dr.GetValue(1).ToString();
                    acct = dr.GetValue(7).ToString();
                    aID = dr.GetValue(0).ToString();
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Welcome " + name+ "!");
                    

                }
                con.Close();
                con.Dispose();
                {
                    if (counter == 1)
                    {
                        con.Open();
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            acct = dr.GetValue(7).ToString();
                            if (acct == "Admin")
                            {
                                Home home = new Home();

                                home.dsp_name.Text = name;
                                home.dsp_id.Text = aID;
                                this.Hide();
                                home.ShowDialog();
                                this.Show();
                            }
                            else if (acct == "Employee")
                            {
                                My_Patients mp = new My_Patients();
                                this.Hide();
                                mp.ShowDialog();
                                this.Show();
                            }
                        }
                        con.Close();
                        con.Dispose();
                    }
                    else
                    {
                        SystemSounds.Exclamation.Play();
                        MessageBox.Show("Wrong username/password");


                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtPass.Text = String.Empty;
            txtUser.SelectAll();
            txtUser.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsPunctuation(e.KeyChar) ||
                   Char.IsSeparator(e.KeyChar) ||
                   Char.IsSymbol(e.KeyChar);
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsPunctuation(e.KeyChar) ||
                    Char.IsSeparator(e.KeyChar) ||
                    Char.IsSymbol(e.KeyChar);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtPass.PasswordChar = '\0';
            }
            else if (checkBox1.Checked == false)
            {
                txtPass.PasswordChar = '⚫';
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string connect = "Server=localhost;user id = dbconnection; password = 09353276080; Database = clinic";
            string command = "select * from clinic.users";



            MySqlConnection con = new MySqlConnection(connect);
            MySqlCommand cmd = new MySqlCommand(command, con);
            MySqlDataReader dr;




            int counter = 0;


            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    counter += 1;
                }
                con.Close();
                con.Dispose();
                {
                    if (counter == 0)
                    {
                        Account_Registration_Form reg = new Account_Registration_Form();
                        reg.ShowDialog();
                        Login log = new Login();
                        this.Hide();
                        log.ShowDialog();
                        this.Close();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
