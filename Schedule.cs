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
    public partial class Schedule : Form
    {
        dbProvider db = new dbProvider();
       

        public Schedule()
        {
            InitializeComponent();
            timer12.Start();
            docFill();
        }

        public string conString()
        {

            return "Server=localhost;user id = dbconnection; password = 09353276080; Database = clinic"; ;
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
       
            monthCalendar1.MinDate = DateTime.Today.AddDays(-0);
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            sdate_txt.Text = monthCalendar1.SelectionStart.Month.ToString() + "/" + monthCalendar1.SelectionStart.Day.ToString() + "/" + monthCalendar1.SelectionStart.Year.ToString();
        }

       
      

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.thistime.Text = datetime.ToString();
        }

        

      

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           
        }

        private void ptnt_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (service_list.SelectedItems.Count == 0)
            //{
            //    MessageBox.Show("Please select service to add!");
            //}
            //else if(service_list.SelectedItems.Count == 1)
            //{
            //    ListBox list = new ListBox();
            //    //ListViewItem list = new ListViewItem();
            //    list.Items.Add;
            // }
            }

        private void sdate_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_doctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string command = "SELECT * from clinic.users where fname = '" + txt_doctor.Text + "'";
            MySqlConnection con = new MySqlConnection(conString());
            MySqlCommand cmd = new MySqlCommand(command, con);
            MySqlDataReader dr;

            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string id = dr.GetString("user_id");
                    doc_ID.Text = id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void docFill()
        {
            string command = "SELECT * from clinic.users where position='Doctor'";
            MySqlConnection con = new MySqlConnection(conString());
            MySqlCommand cmd = new MySqlCommand(command, con);
            MySqlDataReader dr;

            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string doc = dr.GetString("fname");
                    txt_doctor.Items.Add(doc);     
               }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSched_Click(object sender, EventArgs e)
        {

            dbProvider db = new dbProvider();
            int a = 0;
            int idSched = a;
            string id = dsp_id2.Text;
            string doctor = doc_ID.Text;
            string remarks = txt_remarks.Text;
            string date = sdate_txt.Text;
            string time = time_txt.Text;
            string thisTime = thistime.Text;
            string stat = "Pending";



            if (id == ""||doctor == "" || remarks == "" || date == "" || time == "")
            {
                MessageBox.Show("Please complete the schedule form!");
            }
            else if (id != "" || doctor != "" || remarks != "" || date != "" || time != "")
            {
                db.addSched(idSched, id, doctor, remarks, date, time, thisTime, stat);
                MessageBox.Show("Patient succesfully scheduled!");
                this.Close();
            }
        }
        
    }
}
