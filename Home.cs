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
using System.Media;
using System.Threading;

namespace Dental_System
{
    public partial class Home : Form
    {
        dbProvider db = new dbProvider();
        MySqlDataReader reader;
 

        public Home()
        {
            InitializeComponent();
            timer1.Start();
        }

        public string conString()
        {

            return "Server=localhost;user id = dbconnection; password = 09353276080; Database = clinic"; ;
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            SystemSounds.Exclamation.Play();
            if (MessageBox.Show("Are you sure you want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.dsp_time.Text = datetime.ToString();
        }

        private void Home_Load(object sender, EventArgs e)
        {

            monthCalendar1.MinDate = DateTime.Today.AddDays(-0);
            monthCalendar1.MaxDate = DateTime.Today.AddDays(+7);
            db.Populate(list, @"SELECT a.Ptnt_Fname, a.Ptnt_MobileNum, c.remarks, c.Sched_time,w.fname FROM tbl_patient a, users w, tbl_schedule c WHERE a.Ptnt_id = c.ptnt_id AND w.user_id = c.doc_id and c.sched_date = '" +  DateTime.Now.ToString("M/d/yyyy") + "'");
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Account_Registration_Form ac = new Account_Registration_Form();
            ac.ShowDialog();
        }

        private void dsp_pic_Click(object sender, EventArgs e)
        {

        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            _1Schedule s = new _1Schedule();
            s.ShowDialog();
        }

        private void goto_profile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string id = dsp_id.Text;

            View_Profile vp = new View_Profile();
            vp.dsp_id2.Text = id;
            vp.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Update_Account ac = new Update_Account();
            ac.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            My_Patients mp = new My_Patients();
            mp.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Update_Services us = new Update_Services();
            us.ShowDialog();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account_Registration_Form ac = new Account_Registration_Form();
            ac.ShowDialog();
        }

        private void monthCalendar1_Click(object sender, EventArgs e)
        {
            monthCalendar1.Text = monthCalendar1.SelectionStart.Month.ToString() + "/" + monthCalendar1.SelectionStart.Day.ToString() + "/" + monthCalendar1.SelectionStart.Year.ToString();

            int count = 0;
            string command = "SELECT a.Ptnt_Fname, a.Ptnt_MobileNum, c.remarks, c.Sched_time,w.fname FROM tbl_patient a, users w, tbl_schedule c WHERE a.Ptnt_id = c.ptnt_id AND w.user_id = c.doc_id and c.sched_date = '" + monthCalendar1.Text + "'";
            MySqlConnection con = new MySqlConnection(conString());
            MySqlCommand cmd = new MySqlCommand(command, con);
 

            list.Items.Clear();

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader.GetValue(0).ToString());
                    for (int i = 1; i < reader.FieldCount; i++)
                        item.SubItems.Add(reader.GetValue(i).ToString());

                    list.Items.Add(item);

                    count++;
                }

                con.Close();
                con.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Billing bill = new Billing(dsp_name.Text);
            bill.ShowDialog();

            
        }

        private void viewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = dsp_id.Text;
            View_Profile vp = new View_Profile();
            vp.dsp_id2.Text = id;
            vp.ShowDialog();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account_Registration_Form ac = new Account_Registration_Form();
            ac.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            //SystemSounds.Exclamation.Play();
            //DialogResult dialog = MessageBox.Show("Are you sure you want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // if (dialog == DialogResult.Cancel)
            //    {

            //    }
            // else if (dialog == DialogResult.OK)
            // {
            //     Home h = new Home();
            //     h.Close();
            // }
                
        }

        private void viewServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_Services us = new Update_Services();
            us.ShowDialog();
        }

        private void Date_Click(object sender, EventArgs e)
        {
            
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Password ps = new Change_Password();
            string id = dsp_id.Text;
            ps.dsp_id.Text = id;
            ps.ShowDialog();
        }

        private void viewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_Account ac = new Update_Account();
            string id = dsp_id.Text;
            ac.dsp_id2.Text = id;
            ac.ShowDialog();
        }

        private void controlPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My_Patients mp = new My_Patients();
            mp.ShowDialog();
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _1Schedule s = new _1Schedule();
            s.ShowDialog();

        }

        private void billingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Billing bill = new Billing(dsp_name.Text);
            bill.ShowDialog();
        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales_Report sr = new Sales_Report();
            sr.ShowDialog();
        }

       
  
    }
}
