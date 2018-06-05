using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Dental_System
{
    public partial class Account_Registration_Form : Form
    {
        public Account_Registration_Form()
        {
            InitializeComponent();
        }

        //public string conString()
        //{

        //    return ""; ;
        //}

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;user id = dbconnection; password = 09353276080; Database = clinic");
            con.Open();

            MySqlCommand cmd = new MySqlCommand("select * from users where username=@Name", con);
            cmd.Parameters.AddWithValue("@Name", txt_uname.Text);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                MessageBox.Show("Username already taken!");
                txt_uname.Text = "";
            }
            else
            {
                dbProvider db = new dbProvider();
                int a = 0;
                int idemp = a;
                string fname = txt_fname.Text;
                string lname = txt_lname.Text;
                string uname = txt_uname.Text;
                string pass = txt_repass.Text;
                string gender = txt_gender.Text.ToString();
                string acctype = txt_AccountType.Text.ToString();
                string pos = txt_position.Text.ToString();
                string stat = txt_stat.Text.ToString();
                string active = "Y";
                string number = contact_number.Text;


                //encrypt
                string layer1 = db.getMD5(pass);
                string layer2 = db.getMD5(layer1);
                string layer3 = db.getMD5(layer2);
                string layer4 = db.getMD5(layer3);
                string layer5 = db.getMD5(layer4);


                if (fname == "" || lname == "" || uname == "" || pass == "" || gender == "" || stat == "" || number == "" || acctype == "" || pos == "")
                {
                    MessageBox.Show("Please complete the form!");
                }
                else if (fname != "" || lname != "" || uname != "" || pass != "" || gender != "" || stat != "" || number != "" || acctype != "" || pos != "")
                {
                    if (txt_pass.Text != txt_repass.Text)
                    {
                        MessageBox.Show("Password did not match!");
                        txt_pass.Text = "";
                        txt_repass.Text = "";
                    }
                    else
                    {
                        db.add(idemp, fname, lname, uname, layer5, number, gender, acctype, pos, stat, active);
                        MessageBox.Show("Account sucessfuly registered!");
                        this.Close();
                    }

                }
            }
        }

       
        private void Account_Registration_Form_Load(object sender, EventArgs e)
        {
          
        }

        private void txt_fname_TextChanged(object sender, EventArgs e)
        {
            label_fname.Visible = false;
            txt_fname.MaxLength = 25;

            if (txt_fname.TextLength == 0)
            {
                //fnamepic.Visible = false;
            }
            if (txt_fname.TextLength == 25)
            {
                label_fname.Visible = true;
            }
            else if (txt_fname.TextLength < 2)
            {
                fname_red.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                fname_red.BackColor = System.Drawing.Color.AliceBlue;
             
            }
        }

        private void txt_lname_TextChanged(object sender, EventArgs e)
        {
            txt_lname.MaxLength = 25;

            label_lname.Visible = false;
            txt_lname.MaxLength = 25;

            if (txt_lname.TextLength == 25)
            {
                label_lname.Visible = true;
            }
            else if (txt_lname.TextLength < 2)
            {
                lname_red.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                lname_red.BackColor = System.Drawing.Color.AliceBlue;

            }
        }

        private void txt_uname_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;user id = dbconnection; password = 09353276080; Database = clinic");
            con.Open();

            MySqlCommand cmd = new MySqlCommand("select * from users where username=@Name", con);
            cmd.Parameters.AddWithValue("@Name", txt_uname.Text);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                uname_av.Visible = true;
                uname_check.Visible = false;
                
            }
            else
            {
                txt_uname.MaxLength = 15;
                //min = 6

                label_uname.Visible = false;

                if (txt_uname.TextLength == 0)
                {
                    uname_check.Visible = false;
                }
                if (txt_uname.TextLength == 15)
                {

                    label_uname.Visible = true;
                }
                else if (txt_uname.TextLength < 6)
                {
                    //txt_uname.BackColor = System.Drawing.Color.Red;
                    uname_check.Image = Properties.Resources.cancel;
                    uname_check.Refresh();
                    uname_check.Visible = true;
                }
                else
                {

                    //txt_uname.BackColor = System.Drawing.Color.White;
                    uname_check.Image = Properties.Resources.accept;
                    uname_check.Refresh();
                    uname_check.Visible = true;

                }
            }
            con.Close();
            con.Dispose();
           
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            txt_pass.MaxLength = 25;


            label_pass.Visible = false;

            if (txt_pass.TextLength == 0)
            {

            }
            else if (txt_pass.TextLength < 4)
            {
                pass_check.Image = Properties.Resources.cancel;
                pass_check.Refresh();
                pass_check.Visible = true;
                rpass_check.Visible = false;
                //txt_repass.ReadOnly = true;
            }
            else
            {
                pass_check.Image = Properties.Resources.accept;
                pass_check.Refresh();
                pass_check.Visible = true;
                rpass_check.Visible = true;
                //txt_repass.ReadOnly = false;
            }

        }

        private void txt_fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsPunctuation(e.KeyChar) ||
          Char.IsSymbol(e.KeyChar) || Char.IsDigit(e.KeyChar);
            TextBox tb = (TextBox)sender;
            if ((e.KeyChar == ' ') && (tb.Text.Length > 0))
            {
                if (tb.Text[tb.Text.Length - 1] == ' ')
                    e.Handled = true;
            }
        }

        private void txt_lname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsPunctuation(e.KeyChar) ||
         Char.IsSymbol(e.KeyChar) || Char.IsDigit(e.KeyChar);
            TextBox tb = (TextBox)sender;
            if ((e.KeyChar == ' ') && (tb.Text.Length > 0))
            {
                if (tb.Text[tb.Text.Length - 1] == ' ')
                    e.Handled = true;
            }
        }

        private void txt_uname_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = Char.IsPunctuation(e.KeyChar) ||
            //        Char.IsSeparator(e.KeyChar) ||
            //        Char.IsSymbol(e.KeyChar);

            e.Handled = Char.IsPunctuation(e.KeyChar) ||
        Char.IsSymbol(e.KeyChar) || Char.IsDigit(e.KeyChar) || Char.IsSeparator(e.KeyChar);
            TextBox tb = (TextBox)sender;
            if ((e.KeyChar == ' ') && (tb.Text.Length > 0))
            {
                if (tb.Text[tb.Text.Length - 1] == ' ')
                    e.Handled = true;
            }

        }

        private void show_txt_CheckedChanged(object sender, EventArgs e)
        {
            if (show_txt.Checked == true)
            {
                txt_pass.PasswordChar = '\0';
            }
            else if (show_txt.Checked == false)
            {
                txt_pass.PasswordChar = '⚫';
            }
        }

        private void txt_repass_TextChanged(object sender, EventArgs e)
        {
            if (!txt_repass.Text.Equals(txt_pass.Text))
            {

                rpass_check.Image = Properties.Resources.cancel;
                rpass_check.Refresh();
                rpass_check.Visible = true;
            }
            else
            {

                if (txt_pass.TextLength < 4)
            {
                rpass_check.Image = Properties.Resources.cancel;
                rpass_check.Refresh();
                rpass_check.Visible = true;
            }
            else
            {
                rpass_check.Image = Properties.Resources.accept;
                rpass_check.Refresh();
                rpass_check.Visible = true;
            }

               
            }
        }

        private void contact_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsNumber(e.KeyChar))
            {
                TextBox tb = sender as TextBox;
                int cursorPosLeft = tb.SelectionStart;
                int cursorPosRight = tb.SelectionStart + tb.SelectionLength;
                string result = tb.Text.Substring(0, cursorPosLeft) + e.KeyChar + tb.Text.Substring(cursorPosRight);
                string[] parts = result.Split('.');
                if (parts.Length > 1)
                {
                    if (parts[1].Length > 2 || parts.Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void contact_number_TextChanged(object sender, EventArgs e)
        {
            contact_number.MaxLength = 11;
        }

        private void txt_AccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int counter = 0;
            MySqlConnection con = new MySqlConnection("Server=localhost;user id = dbconnection; password = 09353276080; Database = clinic");
            MySqlCommand cmd = new MySqlCommand("select * from users where acctype='Admin'", con);
            MySqlDataReader dr;

             try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    counter ++;

                    if (counter == 2)
                    {
                       
                        if (txt_AccountType.Text == "Admin")
                        {
                            MessageBox.Show("You already have 2 admins! access denied!");
                            txt_AccountType.Items.Remove("Admin");
                        }
                    }
                }
                con.Close();
                con.Dispose();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_position_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
