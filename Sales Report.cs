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
    public partial class Sales_Report : Form
    {
        public Sales_Report()
        {
            InitializeComponent();
        }

        private void Sales_Report_Load(object sender, EventArgs e)
        {
            to_date.MaxDate = DateTime.Today.AddDays(+0);
            time.Start();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            int count = 0;
            string from = from_date.Text;
            string to = to_date.Text;

            string constring = "Server=localhost;user id = dbconnection; password = 09353276080; Database = clinic";
            string qry = "Select trans_id,date,grand_total From clinic.tbl_transaction where date >= '" + from + "'  AND date <= '" + to + "' AND status = 'paid'";
            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand(qry, con);
            MySqlDataReader reader;
            report_list.Items.Clear();

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader.GetValue(0).ToString());
                    for (int i = 1; i < reader.FieldCount; i++)
                        item.SubItems.Add(reader.GetValue(i).ToString());

                    report_list.Items.Add(item);

                    count++;
                }

                con.Close();
                con.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }

            double gg = 0;
            foreach (ListViewItem item in report_list.Items)
            {
                gg += Double.Parse(item.SubItems[2].Text);
            }
            dsp_total.Text = gg.ToString();
        }

        private void time_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.dsp_time.Text = dateTime.ToString();
        }
    }
}
