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

namespace Dental_System
{
    public partial class Update_Account : Form
    {
        dbProvider db = new dbProvider();
        MySqlConnection con;
        MySqlDataReader reader;
        MySqlCommand cmd;

        public Update_Account()
        {
            InitializeComponent();
        }

        public string conString()
        {

            return "Server=localhost;user id = dbconnection; password = 09353276080; Database = clinic"; ;
        }

        void ActiveCompleteFirstname()
        {
            txt_search.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string command = "SELECT * from clinic.users where acctype = 'Staff' && active = 'Y'";
            con = new MySqlConnection(conString());
            cmd = new MySqlCommand(command, con);

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    string serviceName = reader.GetString("fname");
                    coll.Add(serviceName);



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txt_search.AutoCompleteCustomSource = coll;

        }
        void ActiveCompleteLastname()
        {
            txt_search.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string command = "SELECT * from clinic.users where acctype = 'Staff' && active = 'Y'";
            con = new MySqlConnection(conString());
            cmd = new MySqlCommand(command, con);


            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    string serviceName = reader.GetString("lname");
                    coll.Add(serviceName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txt_search.AutoCompleteCustomSource = coll;

        }

        private void Update_Account_Load(object sender, EventArgs e)
        {
            db.Populate(update_user, @"SELECT fname,lname,acctype,username,position,user_id FROM clinic.users WHERE active = 'Y'  AND acctype = 'Employee'");
            rb_fname.Checked = true;

            txt_fname.Enabled = false;
            txt_lname.Enabled = false;
            txt_uname.Enabled = false;
            txt_repass.Enabled = false;
            txt_AccountType.Enabled = false;
            txt_position.Enabled = false;
            btn_update.Enabled = false;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
            if (txt_search.Text == "")
            {
                MessageBox.Show("Enter a word to search");
            }
            else if (rb_fname.Checked == true)
            {
                int count = 0;
                string qry = "SELECT fname,lname,acctype,username,position,user_id FROM clinic.users WHERE fname LIKE '%%" + this.txt_search.Text + "%%' && active = 'Y'  AND acctype = 'Staff'";
                con = new MySqlConnection(conString());
                cmd = new MySqlCommand(qry, con);
                update_user.Items.Clear();

                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader.GetValue(0).ToString());
                        for (int i = 1; i < reader.FieldCount; i++)
                            item.SubItems.Add(reader.GetValue(i).ToString());

                        update_user.Items.Add(item);

                        count++;
                    }

                    MessageBox.Show(this, "There are " + count + " item(s) found!");

                    con.Close();
                    con.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message);
                }
                txt_search.Text = "";
            }
            else if (rb_lname.Checked == true)
            {
                int count = 0;
                string qry = "SELECT fname,lname,acctype,username,position,user_id FROM clinic.users WHERE fname LIKE '%%" + this.txt_search.Text + "%%' && active = 'Y'  AND acctype = 'Staff'";
                con = new MySqlConnection(conString());
                cmd = new MySqlCommand(qry, con);
                update_user.Items.Clear();

                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader.GetValue(0).ToString());
                        for (int i = 1; i < reader.FieldCount; i++)
                            item.SubItems.Add(reader.GetValue(i).ToString());

                        update_user.Items.Add(item);

                        count++;
                    }

                    MessageBox.Show(this, "There are " + count + " item(s) found!");

                    con.Close();
                    con.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message);
                }
                txt_search.Text = "";
            }
        }

        private void update_user_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in update_user.SelectedItems)
            {
                if (update_user.SelectedItems.Count == 1)
                {
                    txt_fname.Enabled = true;
                    txt_lname.Enabled = true;
                    txt_uname.Enabled = true;
                    txt_repass.Enabled = true;
                    txt_AccountType.Enabled = true;
                    txt_position.Enabled = true;
                    btn_update.Enabled = true;

                    txt_fname.Text = item.SubItems[0].Text;
                    txt_lname.Text = item.SubItems[1].Text;
                    txt_AccountType.Text = item.SubItems[2].Text;
                    txt_uname.Text = item.SubItems[3].Text;
                    txt_position.Text = item.SubItems[4].Text;
                    dsp_id.Text = item.SubItems[5].Text;
                }
                else 
                {
                    
                }

            }
        }

        private void rb_fname_CheckedChanged(object sender, EventArgs e)
        {
            ActiveCompleteFirstname();
        }

        private void rb_lname_CheckedChanged(object sender, EventArgs e)
        {
            ActiveCompleteLastname();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (update_user.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select employee to update!");

            }
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
                if (txt_pass.Text != txt_repass.Text)
                {
                    MessageBox.Show("Password did not match!");
                    txt_pass.Text = "";
                    txt_repass.Text = "";
                }

                else
                {
                    DialogResult dialog = MessageBox.Show("Are you sure to update user?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.No)
                    {

                    }
                    else if (dialog == DialogResult.Yes)
                    {

                        string id = dsp_id2.Text;
                        string ThisID = dsp_id.Text;
                        string fname = txt_fname.Text;
                        string lname = txt_lname.Text;
                        string uname = txt_uname.Text;
                        string pass = txt_repass.Text;
                        string acc = txt_AccountType.Text.ToString();
                        string pos = txt_position.Text.ToString();

                        if (fname == "" || lname == "" || uname == "" || pass == "" || acc == "" || pos == "")
                        {
                            MessageBox.Show("Please complete the form!");
                        }
                        else if (fname != "" || lname != "" || uname != "" || pass != "" || acc != "" || pos == "")
                        {

                            Enter_Password ep = new Enter_Password();

                            ep.dsp_myid.Text = id;
                            ep.dsp_thisId.Text = ThisID;
                            ep.dsp_fname.Text = fname;
                            ep.dsp_lname.Text = lname;
                            ep.dsp_uname.Text = uname;
                            ep.dsp_pass.Text = pass;
                            ep.dsp_acc.Text = acc;
                            ep.dsp_pos.Text = pos;
                            ep.ShowDialog();
                            txt_pass.Text = "";
                            txt_repass.Text = "";

                        }
                        //string input = Microsoft.VisualBasic.Interaction.InputBox("Please input password!", "Prompt", "", 0, 0);
                        //dbProvider db = new dbProvider();

                        //string fname = txt_fname.Text;
                        //string lname = txt_lname.Text;
                        //string uname = txt_uname.Text;
                        //string pass = txt_repass.Text;
                        //string acc = txt_AccountType.Text.ToString();
                        //string pos = txt_position.Text.ToString();

                        //if (fname == "" || lname == "" || uname == "" || acc == "" || pos == "")
                        //{
                        //    MessageBox.Show("Please complete the form!");
                        //}
                        //else if (fname != "" || lname != "" || uname != "" || pass != "" || acc != "" || pos == "")
                        //{
                        //    string command = "UPDATE clinic.users SET fname='" + fname + "' ,lname='" + lname + "' ,username ='" + uname + "',gender ='" + acc + "' ,status ='" + pos + "'  where user_id ='" + this.dsp_id.Text + "'";
                        //    con = new MySqlConnection(conString());
                        //    cmd = new MySqlCommand(command, con);
                        //    try
                        //    {
                        //        con.Open();
                        //        reader = cmd.ExecuteReader();
                        //        MessageBox.Show("Succesfully Updated!");
                        //        while (reader.Read())
                        //        {
                        //        }

                        //        update_user.Items.Clear();
                        //        this.Dispose();

                        //    }
                        //    catch (Exception ex)
                        //    {
                        //        MessageBox.Show(ex.Message);
                        //    }
                        //}
                    }
                }
            }
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
                    counter++;

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




    }
}
