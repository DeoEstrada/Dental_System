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
    public partial class _1Schedule : Form
    {
        dbProvider db = new dbProvider();
        MySqlConnection con;
        MySqlDataReader reader;
        MySqlCommand cmd;

        public _1Schedule()
        {
            InitializeComponent();
        }

        public string conString()
        {

            return "Server=localhost;user id = dbconnection; password = 09353276080; Database = clinic"; ;
        }

        //-------------------------------------------------
        void CompleteFirstname()
        {
            patient_txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            patient_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string command = "SELECT * from clinic.tbl_patient where 1";
            con = new MySqlConnection(conString());
            cmd = new MySqlCommand(command, con);

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    string serviceName = reader.GetString("Ptnt_Fname");
                    coll.Add(serviceName);



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            patient_txt.AutoCompleteCustomSource = coll;

        }
        void CompleteLastname()
        {
            patient_txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            patient_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string command = "SELECT * from clinic.tbl_patient where 1";
            con = new MySqlConnection(conString());
            cmd = new MySqlCommand(command, con);


            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    string serviceName = reader.GetString("Ptnt_Lname");
                    coll.Add(serviceName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            patient_txt.AutoCompleteCustomSource = coll;

        }
        //-----------------------------------------------------

        private void button1_Click(object sender, EventArgs e)
        {
            if (patient_txt.Text == "")
            {
                MessageBox.Show("Enter name!");
            }
            else if (rb_nfname.Checked == true)
            {
                int count = 0;
                string qry = "SELECT Ptnt_id,Ptnt_Fname,Ptnt_Lname,Ptnt_MobileNum FROM clinic.tbl_patient WHERE Ptnt_Fname LIKE '%%" + this.patient_txt.Text + "%%'";
                con = new MySqlConnection(conString());
                cmd = new MySqlCommand(qry, con);
                ptnt_list.Items.Clear();


                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader.GetValue(0).ToString());
                        for (int i = 1; i < reader.FieldCount; i++)
                            item.SubItems.Add(reader.GetValue(i).ToString());

                        ptnt_list.Items.Add(item);

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
                patient_txt.Text = "";

            }
            else if (rb_nlname.Checked == true)
            {
                int count = 0;
                string qry = "SELECT Ptnt_id,Ptnt_Fname,Ptnt_Lname,Ptnt_MobileNum FROM clinic.tbl_patient WHERE Ptnt_Lname LIKE '%%" + this.patient_txt.Text + "%%'";
                con = new MySqlConnection(conString());
                cmd = new MySqlCommand(qry, con);


                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader.GetValue(0).ToString());
                        for (int i = 1; i < reader.FieldCount; i++)
                            item.SubItems.Add(reader.GetValue(i).ToString());

                        ptnt_list.Items.Add(item);

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
                patient_txt.Text = "";

            }
        }

        private void _1Schedule_Load(object sender, EventArgs e)
        {
            rb_nfname.Checked = true;
            CompleteFirstname();
        }

        private void rb_nfname_CheckedChanged(object sender, EventArgs e)
        {
            CompleteFirstname();
        }

        private void rb_nlname_CheckedChanged(object sender, EventArgs e)
        {
            CompleteLastname();
        }

        private void ptnt_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ptnt_list.SelectedItems)
            {
                if (ptnt_list.SelectedItems.Count == 1)
                {
                    dsp_id.Text = item.SubItems[0].Text;
                    dsp_fname.Text = item.SubItems[1].Text;
                    dsp_lname.Text = item.SubItems[2].Text;
                    dsp_pno.Text = item.SubItems[3].Text;

                }
                else
                {

                }
            }
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            if (dsp_id.Text == "")
            {
                MessageBox.Show("Select Patient!"); 
            }
            else
            {
                Schedule sce = new Schedule();
                sce.dsp_id2.Text = dsp_id.Text;
                sce.dsp_fname.Text = dsp_fname.Text;
                sce.dsp_lname.Text = dsp_lname.Text;
                sce.dsp_pno.Text = dsp_pno.Text;
                this.Hide();
                this.Close();
                sce.ShowDialog();
                
            }
        }
    }
}
