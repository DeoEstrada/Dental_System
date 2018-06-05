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
    public partial class Update_Services : Form
    {
        dbProvider db = new dbProvider();
        MySqlConnection con;
        MySqlDataReader reader;
        MySqlCommand cmd;
        public Update_Services()
        {
            InitializeComponent();
        }

        public string conString()
        {

            return "Server=localhost;user id = dbconnection; password = 09353276080; Database = clinic"; ;
        }


        private void Update_Services_Load(object sender, EventArgs e)
        {
            CompleteServices();
            db.Populate(update_service, @"SELECT * FROM clinic.tbl_services");
            txt_sname.ReadOnly = true;
            txt_sdetails.ReadOnly = true;
            txt_sprice.ReadOnly = true;
            btn_save.Visible = false;
            btn_cancel.Visible = false;
            btnCancelAdd.Visible = false;
            btn_saveService.Visible = false;
            btn_update.Enabled = false;
        }

        void CompleteServices()
        {
            txt_search.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
            txt_search.AutoCompleteCustomSource = coll;

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                MessageBox.Show("Search field is empty!");
            }

            else
            {
                int count = 0;
                string qry = "SELECT * FROM clinic.tbl_services WHERE service_name LIKE '%%" + this.txt_search.Text + "%%' ";
                con = new MySqlConnection(conString());
                cmd = new MySqlCommand(qry, con);
                update_service.Items.Clear();

                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader.GetValue(0).ToString());
                        for (int i = 1; i < reader.FieldCount; i++)
                            item.SubItems.Add(reader.GetValue(i).ToString());

                        update_service.Items.Add(item);

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

        private void update_service_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in update_service.SelectedItems)
            {
                if (update_service.SelectedItems.Count == 1)
                {
                    dsp_id.Text = item.SubItems[0].Text;
                    txt_sname.Text = item.SubItems[1].Text;
                    txt_sdetails.Text = item.SubItems[2].Text;
                    txt_sprice.Text = item.SubItems[3].Text;
                    btn_update.Enabled = true;

                }
                else
                {
                    //btn_update.Enabled = true;
                }

            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (update_service.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select service to update!");
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Are you sure to update service?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.No)
                {

                }
                else if (dialog == DialogResult.Yes)
                {
                    txt_sname.ReadOnly = false;
                    txt_sdetails.ReadOnly = false;
                    txt_sprice.ReadOnly = false;
                    btn_save.Visible = true;
                    btn_cancel.Visible = true;
                    btn_update.Visible = false;
                    btnCancelAdd.Visible = false;
                    btn_add.Visible = false;

                }
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           
            string sname = txt_sname.Text;
            string sdtl = txt_sdetails.Text;
            string sprice = txt_sprice.Text;

            if (sname == "" || sdtl == "" || sprice == "")
            {
                MessageBox.Show("Please complete the form!");
            }
            else if (sname != "" || sdtl != "" || sprice != "")
            {
                
                    string command = "UPDATE clinic.tbl_services SET service_name='" + sname + "',service_details='" + sdtl + "',service_price='" + sprice + "'where service_id ='" + this.dsp_id.Text + "'";
                    con = new MySqlConnection(conString());
                    cmd = new MySqlCommand(command, con);
                    try
                    {
                        con.Open();
                        reader = cmd.ExecuteReader();
                        MessageBox.Show("Succesfully Updated!");
                        while (reader.Read())
                        {
                        }

                        update_service.Items.Clear();
                        

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    txt_sname.Text = "";
                    txt_sdetails.Text = "";
                    txt_sprice.Text = "";
                    txt_sname.ReadOnly = true;
                    txt_sdetails.ReadOnly = true;
                    txt_sprice.ReadOnly = true;
                    btn_save.Visible = false;
                    btn_cancel.Visible = false;
                    btn_update.Visible = true;
                    btn_add.Visible = true;
                    db.Populate(update_service, @"SELECT * FROM clinic.tbl_services");
                }

            }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
         DialogResult dialog = MessageBox.Show("Cancel this update?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.No)
                {

                }
                else if (dialog == DialogResult.Yes)
                {
                    txt_sname.ReadOnly = true;
                    txt_sdetails.ReadOnly = true;
                    txt_sprice.ReadOnly = true;
                    btn_save.Visible = false;
                    btn_cancel.Visible = false;
                    btn_update.Visible = true;
                    btn_add.Visible = true;
                    txt_search.Enabled = true;
                    btn_search.Enabled = true;
                    update_service.Enabled = true;
                }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Add new service?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.No)
                {

                }
                else if (dialog == DialogResult.Yes)
                {
                    txt_sname.Text = "";
                    txt_sdetails.Text = "";
                    txt_sprice.Text = "";
                    txt_sname.ReadOnly = false;
                    txt_sdetails.ReadOnly = false;
                    txt_sprice.ReadOnly = false;
                    btn_cancel.Visible = false;
                    btn_save.Visible = false;
                    btn_update.Visible = false;
                    btn_add.Visible = false;
                    btnCancelAdd.Visible = true;
                    btn_saveService.Visible = true;
                    txt_search.Enabled = false;
                    btn_search.Enabled = false;
                    update_service.Enabled = false;
                }
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Cancel?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.No)
                {

                }
                else if (dialog == DialogResult.Yes)
                {
                    txt_sname.Text = "";
                    txt_sdetails.Text = "";
                    txt_sprice.Text = "";
                    btn_update.Visible = true;
                    btn_add.Visible = true;
                    btn_save.Visible = false;
                    btn_cancel.Visible = false;
                    btnCancelAdd.Visible = false;
                    btn_saveService.Visible = false;
                    txt_search.Enabled = true;
                    btn_search.Enabled = true;
                    update_service.Enabled = true;
                }
        }

        private void btn_saveService_Click(object sender, EventArgs e)
        {
            int a = 0;
            int idemp = a;
            string sname = txt_sname.Text;
            string sdtl = txt_sdetails.Text;
            string sprice = txt_sprice.Text;

            if (sname == "" || sdtl == "" || sprice == "")
            {
                MessageBox.Show("Please complete the form!");
            }
            else if (sname != "" || sdtl != "" || sprice != "")
            {
                db.addService(idemp, sname, sdtl, sprice);
                MessageBox.Show("Service sucessfuly added!");
               txt_sname.Text="";
               txt_sdetails.Text="";
                txt_sprice.Text="";
                
            }
        
            txt_sname.Text = "";
            txt_sdetails.Text = "";
            txt_sprice.Text = "";
            btn_update.Visible = true;
            btn_add.Visible = true;
            btn_save.Visible = false;
            btn_cancel.Visible = false;
            btnCancelAdd.Visible = false;
            btn_saveService.Visible = false;
            txt_search.Enabled = true;
            btn_search.Enabled = true;
            update_service.Enabled = true;
            db.Populate(update_service, @"SELECT * FROM clinic.tbl_services");
        }

        private void btn_update_EnabledChanged(object sender, EventArgs e)
        {
 
        }
        }
    }

    
