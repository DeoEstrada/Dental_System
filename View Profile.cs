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
    public partial class View_Profile : Form
    {
        dbProvider db = new dbProvider();
        MySqlConnection con;
        MySqlDataReader reader;
        MySqlCommand cmd;

        public View_Profile()
        {
            InitializeComponent();
        }

        private void btn_edit_Click(object sender, MouseEventArgs e)
        {
            btn_cancel.Enabled = true;
            btn_cancel.Visible = true;
            btn_save.Enabled = true;
            btn_save.Visible = true;
            btn_edit.Enabled = false;
            btn_edit.Visible = false;
            txt_gender.Visible = true;
            txt_stat.Visible = true;

            dsp_fname2.ReadOnly = false;
            dsp_lname2.ReadOnly = false;
            dsp_user2.ReadOnly = true;
            dsp_gender2.Visible = false;
            dsp_acct2.ReadOnly = true;
            dsp_stat2.Visible = false;
            dsp_number.ReadOnly = false;
            
        }

        string fname;
        string lname;
        string user;
        string gender;
        string acct;
        string stat;
        string contact;

        private void View_Profile_Load(object sender, EventArgs e)
        {
            btn_cancel.Enabled = false;
            btn_cancel.Visible = false;
            btn_save.Enabled = false;
            btn_save.Visible = false;
            txt_gender.Visible = false;
            txt_stat.Visible = false;
            dsp_fname2.ReadOnly = true;
            dsp_lname2.ReadOnly = true;
            dsp_user2.ReadOnly = true;
            dsp_gender2.ReadOnly = true;
            dsp_acct2.ReadOnly = true;
            dsp_stat2.ReadOnly = true;
            dsp_number.ReadOnly = true;

            string connect = "Server=localhost;user id = dbconnection; password = 09353276080; Database = clinic";
            string command = "select * from clinic.users where user_id='"+this.dsp_id2.Text+"'";


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
                    fname = dr.GetValue(1).ToString();
                    lname = dr.GetValue(2).ToString();
                    user = dr.GetValue(3).ToString();
                    gender = dr.GetValue(6).ToString();
                    acct = dr.GetValue(7).ToString();
                    stat = dr.GetValue(9).ToString();
                    contact = dr.GetValue(5).ToString();

                }
                con.Close();
                con.Dispose();
               
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            dsp_fname2.Text = fname;
            dsp_lname2.Text = lname;
            dsp_user2.Text = user;
            dsp_gender2.Text = gender;
            dsp_acct2.Text = acct;
            dsp_stat2.Text = stat;
            dsp_number.Text = contact;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            goBack();
        }

        public void goBack()
        {
            btn_edit.Enabled = true;
            btn_edit.Visible = true;
            btn_cancel.Enabled = false;
            btn_cancel.Visible = false;
            btn_save.Enabled = false;
            btn_save.Visible = false;
            txt_gender.Visible = false;
            txt_stat.Visible = false;
            dsp_gender2.Visible = true;
            dsp_stat2.Visible = true;
            dsp_number.ReadOnly = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string connect = "Server=localhost;user id = dbconnection; password = 09353276080; Database = clinic";


            DialogResult dialog = MessageBox.Show("Save update?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
            {

            }
            else if (dialog == DialogResult.Yes)
            {
                
                string fname = dsp_fname2.Text;
                string lname = dsp_lname2.Text;
                string gender = txt_gender.Text.ToString();
                string stat = txt_stat.Text.ToString();
                string num = dsp_number.Text;

                if (fname == "" || lname == "" ||gender == "" || stat == "")
                {
                    MessageBox.Show("Please complete the form!");
                }
                else if (fname != "" || lname != "" || gender != "" || stat == "")
                {
                    string command = "UPDATE clinic.users SET fname='" + fname + "' ,lname='" + lname + "' ,gender ='" + gender + "' ,status ='" + stat + "',number ='"+num +"'  where user_id ='" + this.dsp_id2.Text + "'";
                    con = new MySqlConnection(connect);
                    cmd = new MySqlCommand(command, con);
                    try
                    {
                        con.Open();
                        reader = cmd.ExecuteReader();
                        MessageBox.Show("Succesfully Updated!");
                        while (reader.Read())
                        {
                        }
                        goBack();
                        

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
