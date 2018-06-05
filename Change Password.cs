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
    public partial class Change_Password : Form
    {
        dbProvider db = new dbProvider();
        public Change_Password()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (new_pass.Text != re_pass.Text)
            {
                MessageBox.Show("Password did not match!");
                new_pass.Text = "";
                re_pass.Text = "";
                new_pass.Focus();
                pass_check.Visible = false;
                rpass_check.Visible = false;
            }
            else if (new_pass.Text == re_pass.Text)
            {
                string pass = re_pass.Text;

                //encrypt
                string layer1 = db.getMD5(pass);
                string layer2 = db.getMD5(layer1);
                string layer3 = db.getMD5(layer2);
                string layer4 = db.getMD5(layer3);
                string layer5 = db.getMD5(layer4);

                MySqlConnection con = new MySqlConnection("Server=localhost;user id = dbconnection; password = 09353276080; Database = clinic");
                string command = "UPDATE clinic.users SET password =@pass where user_id ='" + this.dsp_id.Text + "'";
                MySqlCommand cmd = new MySqlCommand(command, con);
                cmd.Parameters.AddWithValue("@pass", layer5.ToString());

                MySqlDataReader reader;
                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    MessageBox.Show("Succesfully Updated!");
                    while (reader.Read())
                    {

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }
               

        private void old_pass_TextChanged(object sender, EventArgs e)
        {
            string layer1 = db.getMD5(old_pass.Text);
            string layer2 = db.getMD5(layer1);
            string layer3 = db.getMD5(layer2);
            string layer4 = db.getMD5(layer3);
            string layer5 = db.getMD5(layer4);

            string connect = "Server=localhost;user id = dbconnection; password = 09353276080; Database = clinic";
            string command = "select * from clinic.users where user_id =@id and password = @pass and active ='Y'";
            

            MySqlConnection con = new MySqlConnection(connect);
            MySqlCommand cmd = new MySqlCommand(command, con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", this.dsp_id.Text);
            cmd.Parameters.AddWithValue("@pass", layer5.ToString());
            MySqlDataReader dr = cmd.ExecuteReader(); ;

            
            if (dr.HasRows)
            {
                new_pass.Enabled = true;
               


            }
            else
            {
                new_pass.Enabled = false;
               
            }

            con.Close();
            con.Dispose();

        }

        private void Change_Password_Load(object sender, EventArgs e)
        {

        }

        private void new_pass_TextChanged(object sender, EventArgs e)
        {
            new_pass.MaxLength = 25;


            label_pass.Visible = false;

            if (new_pass.TextLength == 0)
            {

            }
            else if (new_pass.TextLength < 4)
            {
                pass_check.Image = Properties.Resources.cancel;
                pass_check.Refresh();
                pass_check.Visible = true;
                rpass_check.Visible = false;
                re_pass.Enabled = false;
            }
            else
            {
                pass_check.Image = Properties.Resources.accept;
                pass_check.Refresh();
                pass_check.Visible = true;
                rpass_check.Visible = true;
                re_pass.Enabled = true;
            }
        }

        private void re_pass_TextChanged(object sender, EventArgs e)
        {
            if (!re_pass.Text.Equals(new_pass.Text))
            {

                rpass_check.Image = Properties.Resources.cancel;
                rpass_check.Refresh();
                rpass_check.Visible = true;
                btn_save.Enabled = true;
            }
            else
            {

                if (new_pass.TextLength < 4)
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
    }
}
