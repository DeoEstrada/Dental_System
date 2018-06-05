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
    public partial class Billing : Form
    {
        dbProvider db = new dbProvider();
        MySqlConnection con;
        MySqlDataReader reader;
        MySqlCommand cmd;


        public Billing(string hue)
        {
            InitializeComponent();
            timer1.Start();
            bill_dspName.Text = hue;
            serviceComplete();
        }

        public string conString()
        {

            return "Server=localhost;user id = dbconnection; password = 09353276080; Database = clinic"; ;
        }


        public Billing()
        {
            // TODO: Complete member initialization
        }

        // ------------------------ AutoComplete -------------------------------
        void serviceComplete()
        {
            service_txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            service_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string command = "SELECT * from clinic.tbl_services where 1";
            con = new MySqlConnection(conString());
            cmd = new MySqlCommand(command, con);

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string serviceName = reader.GetString("service_name");
                    coll.Add(serviceName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            service_txt.AutoCompleteCustomSource = coll;

        }

        void fnameComplete()
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
        void lnameComplete()
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
        // ------------------------ END OF AutoComplete -------------------------------


        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.dsp_time.Text = datetime.ToString();
        }

        private void rb_nfname_CheckedChanged(object sender, EventArgs e)
        {
            fnameComplete();
        }

        private void rb_nlname_CheckedChanged(object sender, EventArgs e)
        {
            lnameComplete();
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (service_txt.Text == "")
            {
                MessageBox.Show("Search field is empty!");
            }

            else
            {
                
                string qry = "SELECT * FROM clinic.tbl_services WHERE service_name LIKE '%%" + this.service_txt.Text + "%%' ";
                con = new MySqlConnection(conString());
                cmd = new MySqlCommand(qry, con);
                MySqlDataReader dr;


                try
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        string name = dr.GetString("service_name");
                        string price = dr.GetInt32("service_price").ToString();
                        string idd = dr.GetInt32("service_id").ToString();
                        name1.Text = name;
                        price1.Text = price;
                        sLabel.Text = idd;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                service_txt.Text = "";
            }
        }

        private void patient_search_Click(object sender, EventArgs e)
        {
            if (patient_txt.Text == "")
            {
                MessageBox.Show("Search field is empty!");
            }
            else if (rb_nfname.Checked == true)
            {
                string qry = "SELECT * FROM clinic.tbl_patient WHERE Ptnt_Fname LIKE '%%" + this.patient_txt.Text + "%%'";
                con = new MySqlConnection(conString());
                cmd = new MySqlCommand(qry, con);
                MySqlDataReader dr;

                try
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        string sfname = dr.GetString("Ptnt_Fname");
                        string slname = dr.GetString("Ptnt_Lname");
                        string idd = dr.GetString("Ptnt_id");
                        lname.Text = slname;
                        fname.Text = sfname;
                        dsp_id.Text = idd;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                patient_txt.Text = "";
            }
            else if (rb_nlname.Checked == true)
            {
                string qry = "SELECT * FROM clinic.tbl_patient WHERE Ptnt_Lname LIKE '%%" + this.patient_txt.Text + "%%' ";
                con = new MySqlConnection(conString());
                cmd = new MySqlCommand(qry, con);
                MySqlDataReader dr;

                try
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        string sfname = dr.GetString("Ptnt_Fname");
                        string slname = dr.GetString("Ptnt_Lname");
                        lname.Text = slname;
                        fname.Text = sfname;


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                patient_txt.Text = "";
            }
        }

        private void add1_Click(object sender, EventArgs e)
        {
            if (name1.Text == "")
            {
                MessageBox.Show("Select a Service!");

            }
            else if (qty1.Text == "" || qty1.Text == "0")
            {
                MessageBox.Show("Enter Quantity!");
            }

            else
            {

                double price = Convert.ToDouble(price1.Text);
                double qty = Convert.ToDouble(qty1.Text);
                double ans = price * qty;

                string service = Convert.ToString(name1.Text);
                string prce = Convert.ToString(price1.Text);
                string qtyy = Convert.ToString(qty1.Text);
                string answer = Convert.ToString(ans);
                string id = Convert.ToString(sLabel.Text);

                //textBox1.Text = "";
                //textBox2.Text = "";
                //comboBox1.Text = "";

                ListViewItem list = new ListViewItem();
                list.SubItems.Clear();
                list.Text = service;
                list.SubItems.Add(qtyy);
                list.SubItems.Add(prce);
                list.SubItems.Add(answer);
                list.SubItems.Add(id);
                mylist.Items.Add(list);

            }
            double gg = 0;
            foreach (ListViewItem item in mylist.Items)
            {
                gg += Double.Parse(item.SubItems[3].Text);

                name1.Text = "";
                price1.Text = "";
                qty1.Text = "";
            }
            dsp_total.Text = gg.ToString();
            serviceComplete();
        }

        

        private void cash_TextChanged(object sender, EventArgs e)
        {
            double amthanded;
            double totalDue;
            double change;

            try
            {
                if (cash.Text != "")
                {
                    amthanded = double.Parse(cash.Text);
                    totalDue = double.Parse(dsp_total.Text);
                    change = amthanded - totalDue;
                    changed.Text = change.ToString("0.00");
                }

            }
            catch (Exception ex)
            {
                amthanded = 0;
                totalDue = 0;
                change = 0;
                changed.Clear();
            }
        }

        private void dsp_time_Click(object sender, EventArgs e)
        {

        }

        private void trans_save_Click(object sender, EventArgs e)
        {
            if (mylist.Items.Count == 0)
            {
                MessageBox.Show("PLEASE ADD SERVICE(S) ON LIST");
            }
            else if (fname.Text == ".")
            {
                MessageBox.Show("Please enter customer's name!");
            }
            else
            {
                //to tbl_transactionlist
                con = new MySqlConnection(conString());
                string trans = dsp_transNo.Text;
                int limit = mylist.Items.Count - 1;

                for (int i = 0; i <= limit; i++)
                {
                    
                    string service = mylist.Items[i].SubItems[4].Text;
                    string qty = mylist.Items[i].SubItems[1].Text;
                    string price = mylist.Items[i].SubItems[2].Text;
                    string subTotal = mylist.Items[i].SubItems[3].Text;

                    string sql = "INSERT INTO tbl_transactionlist (trans_id,service_id,quantity,unit_price,total) VALUES ('" + trans + "','" + service + "','" + qty + "', '" + price + "','" + subTotal + "')";

                    con = new MySqlConnection(conString());
                    cmd = new MySqlCommand(sql, con);

                    try
                    {
                        con.Open();
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                        }



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

                //to tbl_transaction
                string pay ="";
                double handed = Convert.ToDouble(cash.Text);
                double grandTotal = Convert.ToDouble(dsp_total.Text);
                string name = bill_dspName.Text;
                string datenow = dsp_time.Text;

                if (cash.Text == "0")
                {
                    pay = "unpaid";
                }
                else
                {
                    double tAmountHanded = Convert.ToDouble(cash.Text);

                    if (changed.Text == "0.00")
                    {
                        pay = "paid";
                    }
                    else if (tAmountHanded >= 1)
                    {
                        pay = "unpaid";
                    }
                }
                string ptnt_id = dsp_id.Text;
                string sql2 = "INSERT INTO `tbl_transaction`(`trans_id`,`Ptnt_id`, `amount_handed`, `grand_total`, `balance`, `status`,`date`, `agent`) VALUES ('" + trans + "','" + ptnt_id + "','" + handed + "','" + grandTotal + "','" + changed.Text + "', '" + pay + "','" + datenow + "', '" + name + "')";
                con = new MySqlConnection(conString());
                cmd = new MySqlCommand(sql2, con);

                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            MessageBox.Show("transaction saved!");
            mylist.Items.Clear();
            transNo();
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            transNo();
            rb_nfname.Checked = true;
        }

        public void transNo()
        {

            string command = "SELECT COUNT(*) as result FROM `tbl_transaction`";


            MySqlConnection con = new MySqlConnection(conString());
            MySqlCommand cmd = new MySqlCommand(command, con);
            MySqlDataReader dr;




            int counter = 0;

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());

            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    counter += 1;

                    string no = dr["result"].ToString();

                    dsp_transNo.Text = no + result;





                }
                con.Close();
                con.Dispose();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void discount_CheckedChanged(object sender, EventArgs e)
        {
            if (discount.Checked == true)
            {
                txt_discount.ReadOnly = false;
                txt_discount.BackColor = System.Drawing.Color.White;
            }
            if (discount.Checked == false)
            {
                txt_discount.ReadOnly = true;
                txt_discount.BackColor = System.Drawing.Color.DarkGray;
                txt_discount.Text = "";
            }
        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            
            if (discount.Checked == true)
            {
                if (txt_discount.Text == "" || txt_discount.Text == "0")
                {
                }
                else
                {
                    txt_discount.ReadOnly = false;
                    txt_discount.BackColor = System.Drawing.Color.White;
                    double FullPrice = Convert.ToDouble(dsp_total.Text);
                    double DiscountPercent = Convert.ToDouble(txt_discount.Text);
                    //double DiscountPrice = FullPrice - (FullPrice * DiscountPercent);
                    double DiscountPrice = FullPrice * (1 - DiscountPercent);

                    dsp_total.Text = DiscountPrice.ToString();
                }

            }
            if (discount.Checked == false)
            {
                txt_discount.ReadOnly = true;
                txt_discount.BackColor = System.Drawing.Color.DarkGray;
                txt_discount.Text = "";
            }
        }
    }
}
