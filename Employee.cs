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
    public partial class Employee : Form
    {
        dbProvider db = new dbProvider();
        MySqlConnection con;
        MySqlDataReader reader;
        MySqlCommand cmd;

        public Employee()
        {
            InitializeComponent();
        }
        public string conString()
        {

            return "Server=localhost;user id = dbconnection; password = 09353276080; Database = clinic"; ;
        }

        // ------------------------ AutoComplete -------------------------------
        void ActiveCompleteFirstname()
        {
            txt_search.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string command = "SELECT * from clinic.users where position = 'Staff' && active = 'Y'";
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

            string command = "SELECT * from clinic.users where position = 'Staff' && active = 'Y'";
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

        void CompleteFirstname()
        {
            txt_search.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string command = "SELECT * from clinic.users where position = 'Staff' && active ='N'";
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
        void CompleteLastname()
        {
            txt_search.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string command = "SELECT * from clinic.users where position = 'Staff' && active = 'N'";
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
        //------------------- END OF AUTOCOMPLETE --------------------------

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
             rb_fname.Checked = true;
            if (rb_active.Checked == true)
            {
                rb_fname.Visible = true;
                rb_lname.Visible = true;
                rb_nfname.Visible = false;
                rb_nlname.Visible = false;
                rb_blocked.Checked = false;

                int count = 0;
                string qry = "SELECT user_id,fname,lname,username,gender,position,status,number,active FROM clinic.users WHERE active = 'Y'  AND acctype = 'Employee'";
                con = new MySqlConnection(conString());
                cmd = new MySqlCommand(qry, con);


                emp_view.Items.Clear();

                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader.GetValue(0).ToString());


                        for (int i = 1; i < reader.FieldCount; i++)
                            item.SubItems.Add(reader.GetValue(i).ToString());

                        emp_view.Items.Add(item);

                        count++;
                    }

                    con.Close();
                    con.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message);
                }
                btn_block.Visible = true;
                btn_active.Visible = false;
            }
        }

        private void emp_view_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in emp_view.SelectedItems)
            {
                if (emp_view.SelectedItems.Count == 1)
                {
                    dsp_id.Text = item.SubItems[0].Text;
                }
                else
                {

                }
            }
        }

        private void rb_blocked_CheckedChanged(object sender, EventArgs e)
        {
            rb_nfname.Checked = true;
            if (rb_blocked.Checked == true)
            {
                rb_nfname.Visible = true;
                rb_nlname.Visible = true;
                rb_fname.Visible = false;
                rb_lname.Visible = false;
                rb_active.Checked = false;

                int count = 0;
                string qry = "SELECT user_id,fname,lname,username,gender,position,status,number,active FROM clinic.users WHERE active = 'N'  AND acctype = 'Employee'";
                con = new MySqlConnection(conString());
                cmd = new MySqlCommand(qry, con);


                emp_view.Items.Clear();

                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader.GetValue(0).ToString());


                        for (int i = 1; i < reader.FieldCount; i++)
                            item.SubItems.Add(reader.GetValue(i).ToString());

                        emp_view.Items.Add(item);

                        count++;
                    }

                    con.Close();
                    con.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message);
                }
                btn_active.Visible = true;
                btn_block.Visible = false;
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            rb_active.Checked = true;
            rb_fname.Checked = true;
        }

        private void btn_block_Click(object sender, EventArgs e)
        {
            if (emp_view.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select employee to block!");
            }
            else if (emp_view.SelectedItems.Count == 1)
            {
                SystemSounds.Exclamation.Play();
                DialogResult dialog = MessageBox.Show("Are you sure to block user?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.No)
                {

                }
                else if (dialog == DialogResult.Yes)
                {
                    if (emp_view.SelectedItems.Count == 1)
                    {
                        string command = "UPDATE clinic.users SET active ='N' where user_id = '" + this.dsp_id.Text + "' AND acctype = 'Employee' ";
                        con = new MySqlConnection(conString());
                        cmd = new MySqlCommand(command, con);
                        try
                        {
                            con.Open();
                            reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                            }
                            MessageBox.Show("User has been blocked!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select from list to update");

                    }
                    emp_view.Items.Clear();
                    db.Populate(emp_view, @"SELECT user_id,fname,lname,username,gender,position,status,number,active FROM clinic.users WHERE active = 'Y'  AND acctype = 'Employee'");

                }
            }
        }

        private void btn_active_Click(object sender, EventArgs e)
        {
            if (emp_view.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select employee to activate!");
            }
            else if (emp_view.SelectedItems.Count == 1)
            {
                SystemSounds.Exclamation.Play();
                DialogResult dialog = MessageBox.Show("Are you sure to Activate user?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.No)
                {

                }
                else if (dialog == DialogResult.Yes)
                {
                    if (emp_view.SelectedItems.Count == 1)
                    {
                        string command = "UPDATE clinic.users SET active ='Y' where user_id = '" + this.dsp_id.Text + "' AND acctype = 'Employee' ";
                        con = new MySqlConnection(conString());
                        cmd = new MySqlCommand(command, con);
                        try
                        {
                            con.Open();
                            reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                            }
                            MessageBox.Show("User has been activated!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select from list to update");

                    }
                    emp_view.Items.Clear();
                    db.Populate(emp_view, @"SELECT user_id,fname,lname,username,gender,position,status,number,active FROM clinic.users WHERE active = 'N'  AND acctype = 'Employee'");

                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                MessageBox.Show("Enter a word to search");
            }

            else if (rb_active.Checked == true)
            {
                //------------------ A C T I V E ------------------------------------------
                if (rb_fname.Checked == true)
                {
                    int count = 0;
                    string qry = "SELECT user_id,fname,lname,username,gender,position,status,number,active FROM clinic.users WHERE fname LIKE '%%" + this.txt_search.Text + "%%' && active = 'Y'  AND acctype = 'Employee'";
                    con = new MySqlConnection(conString());
                    cmd = new MySqlCommand(qry, con);
                    emp_view.Items.Clear();

                    try
                    {
                        con.Open();
                        reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader.GetValue(0).ToString());
                            for (int i = 1; i < reader.FieldCount; i++)
                                item.SubItems.Add(reader.GetValue(i).ToString());

                            emp_view.Items.Add(item);

                            count++;
                        }

                        MessageBox.Show(this, count + " item(s) found!");

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
                    string qry = "SELECT user_id,fname,lname,username,gender,position,status,number,active FROM clinic.users WHERE lname LIKE '%%" + this.txt_search.Text + "%%' && active = 'Y'  AND acctype = 'Employee'";
                    con = new MySqlConnection(conString());
                    cmd = new MySqlCommand(qry, con);
                    emp_view.Items.Clear();

                    try
                    {
                        con.Open();
                        reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader.GetValue(0).ToString());
                            for (int i = 1; i < reader.FieldCount; i++)
                                item.SubItems.Add(reader.GetValue(i).ToString());

                            emp_view.Items.Add(item);

                            count++;
                        }

                        MessageBox.Show(this, count + " item(s) found!");

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
            else if (rb_blocked.Checked == true)
            {
                //------------------I N A C T I V E --------------------------------------------------
                if (rb_fname.Checked == true)
                {
                    int count = 0;
                    string qry1 = "SELECT user_id,fname,lname,username,gender,position,status,number,active FROM clinic.users  WHERE fname LIKE '%%" + this.txt_search.Text + "%%' && active = 'N'  AND acctype = 'Employee'";
                    con = new MySqlConnection(conString());
                    cmd = new MySqlCommand(qry1, con);
                    emp_view.Items.Clear();

                    try
                    {
                        con.Open();
                        reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader.GetValue(0).ToString());
                            for (int i = 1; i < reader.FieldCount; i++)
                                item.SubItems.Add(reader.GetValue(i).ToString());

                            emp_view.Items.Add(item);

                            count++;
                        }

                        MessageBox.Show(this, count + " item(s) found!");

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
                    string qry1 = "SELECT user_id,fname,lname,username,gender,position,status,number,active FROM clinic.users  WHERE lname LIKE '%%" + this.txt_search.Text + "%%' && active = 'N'  AND acctype = 'Employee'";
                    con = new MySqlConnection(conString());
                    cmd = new MySqlCommand(qry1, con);
                    emp_view.Items.Clear();

                    try
                    {
                        con.Open();
                        reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader.GetValue(0).ToString());
                            for (int i = 1; i < reader.FieldCount; i++)
                                item.SubItems.Add(reader.GetValue(i).ToString());

                            emp_view.Items.Add(item);

                            count++;
                        }

                        MessageBox.Show(this, count + " item(s) found!");

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
        }

        private void rb_fname_CheckedChanged(object sender, EventArgs e)
        {
            ActiveCompleteFirstname();
        }

        private void rb_lname_CheckedChanged(object sender, EventArgs e)
        {
            ActiveCompleteLastname();
        }

        private void rb_nfname_CheckedChanged(object sender, EventArgs e)
        {
            CompleteFirstname();
        }

        private void rb_nlname_CheckedChanged(object sender, EventArgs e)
        {
            CompleteLastname();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
