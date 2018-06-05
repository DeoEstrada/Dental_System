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
    public partial class Enter_Password : Form
    {
        dbProvider db = new dbProvider();
        Update_Account ua = new Update_Account();
        MySqlConnection con;
        MySqlDataReader reader;

        public string conString()
        {

            return "Server=localhost;user id = dbconnection; password = 09353276080; Database = clinic"; ;
        }

        public Enter_Password()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
           
            string layer1 = db.getMD5(txt_pass.Text);
            string layer2 = db.getMD5(layer1);
            string layer3 = db.getMD5(layer2);
            string layer4 = db.getMD5(layer3);
            string layer5 = db.getMD5(layer4);
            string command = "select * from clinic.users where user_id =@id and password = @pass and active ='Y'";


            MySqlConnection con = new MySqlConnection(conString());
            MySqlCommand cmd = new MySqlCommand(command, con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", this.dsp_myid.Text); //Admin ID
            cmd.Parameters.AddWithValue("@pass", layer5.ToString());
            MySqlDataReader dr = cmd.ExecuteReader(); ;


            if (dr.HasRows)
            {
                //con.Open();
                update();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong Password!");   
            }
            con.Close();
            con.Dispose();
        }

        private void update()
        {
           
            string id = this.dsp_thisId.Text; //emp ID
            string fname = this.dsp_fname.Text;
            string lname = this.dsp_lname.Text;
            string uname = this.dsp_uname.Text;
            string pass = this.dsp_pass.Text;
            string acc = this.dsp_acc.Text;
            string pos = this.dsp_pos.Text;

            string layer1 = db.getMD5(pass);
            string layer2 = db.getMD5(layer1);
            string layer3 = db.getMD5(layer2);
            string layer4 = db.getMD5(layer3);
            string layer5 = db.getMD5(layer4);

            con = new MySqlConnection(conString());
            string command = "UPDATE clinic.users SET fname=@fname ,lname=@lname ,username =@uname ,password =@mypass, acctype = @acc ,position = @pos  where user_id =@myid";
            MySqlCommand cmd = new MySqlCommand(command, con);
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@uname", uname);
            cmd.Parameters.AddWithValue("@mypass", layer5.ToString());
            cmd.Parameters.AddWithValue("@acc", acc);
            cmd.Parameters.AddWithValue("@pos", pos);
            cmd.Parameters.AddWithValue("@myid", id);

            con.Open();
          
            try
            {
                
                reader = cmd.ExecuteReader();
                MessageBox.Show("Succesfully Updated!");
                while (reader.Read())
                {
                }

                ua.update_user.Items.Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            con.Dispose();
        }
    }
}
