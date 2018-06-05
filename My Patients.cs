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
    public partial class My_Patients : Form
    {
        dbProvider db = new dbProvider();
        MySqlConnection con;
        MySqlDataReader reader;
        MySqlCommand cmd;

        public My_Patients()
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
            txt_search.AutoCompleteCustomSource = coll;

        }
        void ActiveCompleteLastname()
        {
            txt_search.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
            txt_search.AutoCompleteCustomSource = coll;

        }
         // ------------------------ END OF AutoComplete -------------------------------

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                MessageBox.Show("Search field is empty!");
            }

            else if (rb_pfname.Checked == true)
                {
                    int count = 0;
                    string qry = "SELECT * FROM clinic.tbl_patient WHERE Ptnt_Fname LIKE '%%" + this.txt_search.Text + "%%' ";
                    con = new MySqlConnection(conString());
                    cmd = new MySqlCommand(qry, con);
                    ptnt_view.Items.Clear();

                    try
                    {
                        con.Open();
                        reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader.GetValue(0).ToString());
                            for (int i = 1; i < reader.FieldCount; i++)
                                item.SubItems.Add(reader.GetValue(i).ToString());

                            ptnt_view.Items.Add(item);

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
                else if (rb_plname.Checked == true)
                {
                    int count = 0;
                    string qry = "SELECT * FROM clinic.tbl_patient WHERE Ptnt_Lname LIKE '%%" + this.txt_search.Text + "%%' ";
                    con = new MySqlConnection(conString());
                    cmd = new MySqlCommand(qry, con);
                    ptnt_view.Items.Clear();

                    try
                    {
                        con.Open();
                        reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader.GetValue(0).ToString());
                            for (int i = 1; i < reader.FieldCount; i++)
                                item.SubItems.Add(reader.GetValue(i).ToString());

                            ptnt_view.Items.Add(item);

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

        private void My_Patients_Load(object sender, EventArgs e)
        {
            select_bday.MaxDate = DateTime.Today.AddDays(+0);
            rb_pfname.Checked = true;
            db.Populate(ptnt_view, @"SELECT * FROM clinic.tbl_patient WHERE 1");
            btn_cancel.Visible = false;
            btn_add.Visible = false;
            select_bday.Visible = false;
            select_gender.Visible = false;


        }

        public void goBack()
        {
            tabPage1.BackColor = System.Drawing.Color.LightBlue;
            tabPage2.BackColor = System.Drawing.Color.LightBlue;
            tabPage3.BackColor = System.Drawing.Color.LightBlue;
            tabPage4.BackColor = System.Drawing.Color.LightBlue;
            btn_cancel.Visible = false;
            btn_BasicUpdate.Visible = false;
            btn_MedAdd.Visible = false;
            btn_update.Visible = true;
            dsp_fname.ReadOnly = true;
            dsp_mi.ReadOnly = true;
            dsp_lname.ReadOnly = true;
            dsp_bday.ReadOnly = true;
            dsp_gender.ReadOnly = true;
            dsp_currAdd.ReadOnly = true;
            dsp_perAdd.ReadOnly = true;
            dsp_hnum.ReadOnly = true;
            dsp_wnum.ReadOnly = true;
            dsp_mnum.ReadOnly = true;

            txt_tongue.ReadOnly = true;
            txt_palate.ReadOnly = true;
            txt_tonsil.ReadOnly = true;
            txt_lips.ReadOnly = true;
            txt_floorOfMouth.ReadOnly = true;
            txt_cheeks.ReadOnly = true;
            txt_allergy.ReadOnly = true;
            txt_HeartDisease.ReadOnly = true;
            txt_BloodDyscracia.ReadOnly = true;
            txt_Diabetes.ReadOnly = true;
            txt_kidney.ReadOnly = true;
            txt_liver.ReadOnly = true;
            txt_hygiene.ReadOnly = true;
            txt_others.ReadOnly = true;
            btn_add.Visible = false;

            select_bday.Visible = false;
            select_gender.Visible = false;
            dsp_bday.Visible = true;
            dsp_gender.Visible = true;
            add_patient.Visible = true;

            txt_search.ReadOnly = false;
            btn_search.Enabled = true;
            rb_pfname.Enabled = true;
            rb_plname.Enabled = true;
            ptnt_view.Enabled = true;
            add_patient.Visible = true;
        }

        private void rb_pfname_CheckedChanged(object sender, EventArgs e)
        {
            ActiveCompleteFirstname();
        }

        private void rb_plname_CheckedChanged(object sender, EventArgs e)
        {
            ActiveCompleteLastname();
        }

        private void ptnt_view_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            
             

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dsp_id.Text == "")
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("Please select patient to update!");
            }
            else if (dsp_id.Text !="" )
            {
                string fname = dsp_fname.Text;
                string lname = dsp_lname.Text;

                SystemSounds.Exclamation.Play();
                DialogResult dialog = MessageBox.Show("Update "+fname+" "+lname+"'s information?", "Confirm", MessageBoxButtons.OKCancel , MessageBoxIcon.Question);
                if (dialog == DialogResult.Cancel )
                {

                }
                else if (dialog == DialogResult.OK )
                {
                    tabPage1.BackColor = System.Drawing.Color.SteelBlue;
                    tabPage2.BackColor = System.Drawing.Color.SteelBlue;
                    tabPage3.BackColor = System.Drawing.Color.SteelBlue;
                    tabPage4.BackColor = System.Drawing.Color.SteelBlue;
                    btn_cancel.Visible = true;
                    btn_BasicUpdate.Visible = true;
                    btn_MedAdd.Visible = true;
                    btn_update.Visible = false;
                    dsp_fname.ReadOnly = false;
                    dsp_mi.ReadOnly = false;
                    dsp_lname.ReadOnly = false;
                    dsp_bday.ReadOnly = false;
                    dsp_gender.ReadOnly = false;
                    dsp_currAdd.ReadOnly = false;
                    dsp_perAdd.ReadOnly = false;
                    dsp_hnum.ReadOnly = false;
                    dsp_wnum.ReadOnly = false;
                    dsp_mnum.ReadOnly = false;

                    txt_tongue.ReadOnly = false;
                    txt_palate.ReadOnly = false;
                    txt_tonsil.ReadOnly = false;
                    txt_lips.ReadOnly = false;
                    txt_floorOfMouth.ReadOnly = false;
                    txt_cheeks.ReadOnly = false;
                    txt_allergy.ReadOnly = false;
                    txt_HeartDisease.ReadOnly = false;
                    txt_BloodDyscracia.ReadOnly = false;
                    txt_Diabetes.ReadOnly = false;
                    txt_kidney.ReadOnly = false;
                    txt_liver.ReadOnly = false;
                    txt_hygiene.ReadOnly = false;
                    txt_others.ReadOnly = false;

                    btn_add.Visible = false;
                    select_bday.Visible = true;
                    select_gender.Visible = true;
                    dsp_bday.Visible = false;
                    dsp_gender.Visible = false;
                    add_patient.Visible = false;

                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
             DialogResult dialog = MessageBox.Show("Cancel activity?", "Confirm", MessageBoxButtons.OKCancel , MessageBoxIcon.Question);
                if (dialog == DialogResult.Cancel )
                {

                }
                else if (dialog == DialogResult.OK)
                {
                    goBack();
                }
        }

        private void btn_MedAdd_Click(object sender, EventArgs e)
        {
            dbProvider db = new dbProvider();
            int b = 0;
            int idMed = b;
            int idemp =  Convert.ToInt32(dsp_id.Text);
            string tongue = txt_tongue.Text;
            string palate = txt_palate.Text;
            string tonsil = txt_tonsil.Text;
            string lips = txt_lips.Text;
            string floor = txt_floorOfMouth.Text;
            string cheeks = txt_cheeks.Text;
            string allergy = txt_allergy.Text;
            string heart = txt_HeartDisease.Text;
            string blood = txt_BloodDyscracia.Text;
            string diabetes = txt_Diabetes.Text;
            string kidney = txt_kidney.Text;
            string liver = txt_liver.Text;
            string hygiene = txt_hygiene.Text;
            string others = txt_others.Text;

           
                db.addMed(idMed, idemp, tongue, palate, tonsil, lips, floor, cheeks, allergy, heart, blood, diabetes, kidney, liver, hygiene, others);
                MessageBox.Show("Sucessfuly Updated!");
                db.Populate(ptnt_view, @"SELECT * FROM clinic.tbl_patient WHERE 1");
                goBack();
                
            
        }

        private void btn_BasicUpdate_Click(object sender, EventArgs e)
        {
             dbProvider db = new dbProvider();
            SystemSounds.Exclamation.Play();
             DialogResult dialog = MessageBox.Show("You are sure to update patients information?", "Confirm", MessageBoxButtons.OKCancel , MessageBoxIcon.Question);
                if (dialog == DialogResult.Cancel )
                {

                }
                else if (dialog == DialogResult.OK)
                {
                    string fname = dsp_fname.Text;
                    string lname = dsp_lname.Text;
                    string mi = dsp_mi.Text;
                    string bday = select_bday.Text.ToString();
                    string gender = select_gender.Text.ToString();
                    string addCrnt = dsp_currAdd.Text;
                    string addPer = dsp_perAdd.Text;
                    string Wnum = dsp_wnum.Text;
                    string Hnum = dsp_hnum.Text;
                    string Mnum = dsp_mnum.Text;


                    if (fname == "" || lname == "" || mi == "" || bday == "" || gender == "" || addCrnt == "" || Mnum == "")
                    {
                        MessageBox.Show("Please complete the form!");
                    }
                    else if (fname != "" || lname != "" || mi != "" || bday != "" || gender != "" || addCrnt != "" || Mnum != "")
                    {

                        string command = "UPDATE clinic.tbl_patient SET Ptnt_Fname='" + fname + "', Ptnt_Minitial='" + mi + "', Ptnt_Lname='" + lname + "', Ptnt_bday='" + bday + "', Ptnt_CurntAdd='" + addCrnt + "', Ptnt_pmntAdd='" + addPer + "', Ptnt_HomeNum='" + Hnum + "', Ptnt_WorkNum='" + Wnum + "', Ptnt_MobileNum='" + Mnum + "' where Ptnt_id ='" + this.dsp_id.Text + "'";
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
                            db.Populate(ptnt_view, @"SELECT * FROM clinic.tbl_patient WHERE 1");
                            goBack();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {

        }

        private void add_patient_Click(object sender, EventArgs e)
        {
        
                SystemSounds.Exclamation.Play();
                DialogResult dialog = MessageBox.Show("Add new patient?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.Cancel)
                {

                }
                else if (dialog == DialogResult.OK)
                {
                    label9.Visible = false;
                    dsp_id.Visible = false;
                    dsp_id.Text = "";
                    dsp_fname.Text = "";
                    dsp_mi.Text = "";
                    dsp_lname.Text = "";
                    dsp_bday.Text = "";
                    dsp_gender.Text = "";
                    dsp_currAdd.Text = "";
                    dsp_perAdd.Text = "";
                    dsp_hnum.Text = "";
                    dsp_wnum.Text = "";
                    dsp_mnum.Text = "";

                    txt_tongue.Text = "";
                    txt_palate.Text = "";
                    txt_tonsil.Text = "";
                    txt_lips.Text = "";
                    txt_floorOfMouth.Text = "";
                    txt_cheeks.Text = "";
                    txt_allergy.Text = "";
                    txt_HeartDisease.Text = "";
                    txt_BloodDyscracia.Text = "";
                    txt_Diabetes.Text = "";
                    txt_kidney.Text = "";
                    txt_liver.Text = "";
                    txt_hygiene.Text = "";
                    txt_others.Text = "";

                    tabPage1.BackColor = System.Drawing.Color.SteelBlue;
                    tabPage2.BackColor = System.Drawing.Color.SteelBlue;
                    tabPage3.BackColor = System.Drawing.Color.SteelBlue;
                    tabPage4.BackColor = System.Drawing.Color.SteelBlue;
                    btn_cancel.Visible = true;
                    btn_BasicUpdate.Visible = true;
                    btn_MedAdd.Visible = true;
                    btn_update.Visible = false;
                    dsp_fname.ReadOnly = false;
                    dsp_mi.ReadOnly = false;
                    dsp_lname.ReadOnly = false;
                    dsp_bday.ReadOnly = false;
                    dsp_gender.ReadOnly = false;
                    dsp_currAdd.ReadOnly = false;
                    dsp_perAdd.ReadOnly = false;
                    dsp_hnum.ReadOnly = false;
                    dsp_wnum.ReadOnly = false;
                    dsp_mnum.ReadOnly = false;
                    txt_tongue.ReadOnly = false;
                    txt_palate.ReadOnly = false;
                    txt_tonsil.ReadOnly = false;
                    txt_lips.ReadOnly = false;
                    txt_floorOfMouth.ReadOnly = false;
                    txt_cheeks.ReadOnly = false;
                    txt_allergy.ReadOnly = false;
                    txt_HeartDisease.ReadOnly = false;
                    txt_BloodDyscracia.ReadOnly = false;
                    txt_Diabetes.ReadOnly = false;
                    txt_kidney.ReadOnly = false;
                    txt_liver.ReadOnly = false;
                    txt_hygiene.ReadOnly = false;
                    txt_others.ReadOnly = false;

                    btn_cancel.Visible = false;
                    txt_search.ReadOnly = true;
                    btn_search.Enabled = false;
                    rb_pfname.Enabled = false;
                    rb_plname.Enabled = false;
                    ptnt_view.Enabled = false;
                    
                    btn_add.Visible = true;
                    btn_BasicUpdate.Visible = false;
                    select_bday.Visible = true;
                    select_gender.Visible = true;
                    dsp_bday.Visible = false;
                    dsp_gender.Visible = false;

                    add_patient.Visible = false;
                    btn_cancel.Visible = true;
                    btn_MedAdd.Visible = false;
                }
            
        }

        private void this_cancel_Click(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
            DialogResult dialog = MessageBox.Show("Are you sure you want to cancel?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.Cancel)
            {

            }
            else if (dialog == DialogResult.OK)
            {
                
                btn_BasicUpdate.Visible = false;
                btn_MedAdd.Visible = false;
                btn_update.Visible = true;
                dsp_fname.ReadOnly = true;
                dsp_mi.ReadOnly = true;
                dsp_lname.ReadOnly = true;
                dsp_bday.ReadOnly = true;
                dsp_gender.ReadOnly = true;
                dsp_currAdd.ReadOnly = true;
                dsp_perAdd.ReadOnly = true;
                dsp_hnum.ReadOnly = true;
                dsp_wnum.ReadOnly = true;
                dsp_mnum.ReadOnly = true;

                txt_tongue.ReadOnly = true;
                txt_palate.ReadOnly = true;
                txt_tonsil.ReadOnly = true;
                txt_lips.ReadOnly = true;
                txt_floorOfMouth.ReadOnly = true;
                txt_cheeks.ReadOnly = true;
                txt_allergy.ReadOnly = true;
                txt_HeartDisease.ReadOnly = true;
                txt_BloodDyscracia.ReadOnly = true;
                txt_Diabetes.ReadOnly = true;
                txt_kidney.ReadOnly = true;
                txt_liver.ReadOnly = true;
                txt_hygiene.ReadOnly = true;
                txt_others.ReadOnly = true;

                btn_cancel.Visible = false;
                txt_search.ReadOnly = false;
                btn_search.Enabled = true;
                rb_pfname.Enabled = true;
                rb_plname.Enabled = true;
                ptnt_view.Enabled = true;
                btn_add.Visible = false;

                label9.Visible = true;
                dsp_id.Visible = true;
            }
        }

        private void t18_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void ptnt_view_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void ptnt_view_MouseClick(object sender, MouseEventArgs e)
        {
            txt_tongue.Text = "";
            txt_palate.Text = "";
            txt_tonsil.Text = "";
            txt_lips.Text = "";
            txt_floorOfMouth.Text = "";
            txt_cheeks.Text = "";
            txt_allergy.Text = "";
            txt_HeartDisease.Text = "";
            txt_BloodDyscracia.Text = "";
            txt_Diabetes.Text = "";
            txt_kidney.Text = "";
            txt_liver.Text = "";
            txt_hygiene.Text = "";
            txt_others.Text = "";

            foreach (ListViewItem item in ptnt_view.SelectedItems)
            {
                dsp_id.Text = item.SubItems[0].Text;
                dsp_fname.Text = item.SubItems[1].Text;
                dsp_mi.Text = item.SubItems[2].Text;
                dsp_lname.Text = item.SubItems[3].Text;
                dsp_bday.Text = item.SubItems[4].Text;
                dsp_gender.Text = item.SubItems[5].Text;
                dsp_currAdd.Text = item.SubItems[6].Text;
                dsp_perAdd.Text = item.SubItems[7].Text;
                dsp_hnum.Text = item.SubItems[8].Text;
                dsp_wnum.Text = item.SubItems[9].Text;
                dsp_mnum.Text = item.SubItems[10].Text;
            }
            int idemp = Convert.ToInt32(dsp_id.Text);

            string command = "select * from clinic.tbl_medicalhistory where Ptnt_id = '" + idemp + "' ";


            MySqlConnection con = new MySqlConnection(conString());
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


                    txt_tongue.Text = dr.GetValue(2).ToString();
                    txt_palate.Text = dr.GetValue(3).ToString();
                    txt_tonsil.Text = dr.GetValue(4).ToString();
                    txt_lips.Text = dr.GetValue(5).ToString();
                    txt_floorOfMouth.Text = dr.GetValue(6).ToString();
                    txt_cheeks.Text = dr.GetValue(7).ToString();
                    txt_allergy.Text = dr.GetValue(8).ToString();
                    txt_HeartDisease.Text = dr.GetValue(9).ToString();
                    txt_BloodDyscracia.Text = dr.GetValue(10).ToString();
                    txt_Diabetes.Text = dr.GetValue(11).ToString();
                    txt_kidney.Text = dr.GetValue(12).ToString();
                    txt_liver.Text = dr.GetValue(13).ToString();
                    txt_hygiene.Text = dr.GetValue(14).ToString();
                    txt_others.Text = dr.GetValue(15).ToString();

                }
                con.Close();
                con.Dispose();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            string dspCom = "SELECT s.service_name, tl.unit_price, tl.quantity, tl.total, t.date, t.agent FROM `tbl_services` as s inner join `tbl_transactionlist` as tl on s.service_id = tl.service_id inner join `tbl_transaction` as t on tl.trans_id = t.trans_id where t.Ptnt_id = '" + idemp + "'";


            MySqlConnection connection = new MySqlConnection(conString());
            MySqlCommand cmd22 = new MySqlCommand(dspCom, connection);
            MySqlDataReader go;



            transList.Items.Clear();
            int counter2 = 0;


            try
            {
                connection.Open();
                go = cmd22.ExecuteReader();
                while (go.Read())
                {
                    ListViewItem item = new ListViewItem(go.GetValue(0).ToString());
                    for (int i = 1; i < go.FieldCount; i++)
                        item.SubItems.Add(go.GetValue(i).ToString());

                    transList.Items.Add(item);

                    counter2 += 1;
                }
                con.Close();
                con.Dispose();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_search_Enter(object sender, EventArgs e)
        {
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int a = 0;
            int idemp = a;
            string fname = dsp_fname.Text;
            string lname = dsp_lname.Text;
            string mi = dsp_mi.Text;
            string bday = select_bday.Text.ToString();
            string gender = select_gender.Text.ToString();
            string addCrnt = dsp_currAdd.Text;
            string addPer = dsp_perAdd.Text;
            string Wnum = dsp_wnum.Text;
            string Hnum = dsp_hnum.Text;
            string Mnum = dsp_mnum.Text;

            if (fname == "" || lname == "" || mi == "" || bday == "" || gender == "" || addCrnt == "" || Mnum == "")
            {
                MessageBox.Show("Please complete the form!");
            }
            else if (fname != "" || lname != "" || mi != "" || bday != "" || gender != "" || addCrnt != "" || Mnum != "")
            {
                db.addPtnt(idemp, fname, mi, lname, bday, gender, addCrnt, addPer, Hnum, Wnum, Mnum);
                MessageBox.Show("Patient Succesfully added!");
                db.Populate(ptnt_view, @"SELECT * FROM clinic.tbl_patient WHERE 1");
                goBack();
            }
        }

        private void t18_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void pasta_Click(object sender, EventArgs e)
        {
            //System.Windows.Forms.Picturebox.BackColor = System.Drawing.Color.SteelBlue;
            //this.Picturebox.BackColor = System.Drawing.Color.SteelBlue;
        }

        private void Filled_Click(object sender, EventArgs e)
        {

        }

        private void extracted_Click(object sender, EventArgs e)
        {

        }

        private void transList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void select_bday_ValueChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
