using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace Dental_System
{
    class dbProvider
    {
        public MySqlConnection Con = null;
        public MySqlCommand Cmd = null;
        public MySqlDataReader Reader = null;
        public string ErrorMsg = "";



        public void ShowErrorMsg()
        {
            MessageBox.Show(ErrorMsg, "Manage User", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public string conString()
        {

            return "Server=localhost;user id = dbconnection; password = 09353276080; Database = clinic"; ;
        }

        public bool add(int idemp, string fname, string lname, string uname, string pass,string number, string gender, string acctype,string pos, string stat, string active)
        {
            //Account_Registration_Form ff = new Account_Registration_Form();
            //string aa = ff.dsp_path.Text;

            //byte[] imageBt = null;
            //FileStream fstream = new FileStream(aa, FileMode.Open, FileAccess.Read);
            //BinaryReader br = new BinaryReader(fstream);
            //imageBt = br.ReadBytes((int)fstream.Length);

            bool retValue = false;
            Con = new MySqlConnection(conString());
            Cmd = new MySqlCommand(@"INSERT INTO clinic.users VALUES(@user_id, @fname, @lname, @username, @password,@number, @gender, @acctype,@position,@status,@active);", Con);

            Cmd.Parameters.Add(new MySqlParameter("@user_id", idemp));
            Cmd.Parameters.Add(new MySqlParameter("@fname", fname));
            Cmd.Parameters.Add(new MySqlParameter("@lname", lname));
            Cmd.Parameters.Add(new MySqlParameter("@username", uname));
            Cmd.Parameters.Add(new MySqlParameter("@password", pass));
            Cmd.Parameters.Add(new MySqlParameter("@number", number));
            Cmd.Parameters.Add(new MySqlParameter("@gender", gender));
            Cmd.Parameters.Add(new MySqlParameter("@acctype", acctype));
            Cmd.Parameters.Add(new MySqlParameter("@position", pos));
            Cmd.Parameters.Add(new MySqlParameter("@status", stat));
            Cmd.Parameters.Add(new MySqlParameter("@active", active));


            try
            {
                Con.Open();
                Cmd.ExecuteNonQuery();
                Con.Close();
                Con.Dispose();
                retValue = true;
            }
            catch (Exception e)
            {
                this.ErrorMsg = e.Message;
                ShowErrorMsg();
                retValue = false;
            }
            return retValue;

        }

        public bool addPtnt(int idemp, string fname, string mi, string lname, string bday, string gender, string addCrnt, string addPer, string Wnum, string Hnum, string Mnum)
        {

            bool retValue = false;
            Con = new MySqlConnection(conString());
            Cmd = new MySqlCommand(@"INSERT INTO clinic.tbl_patient VALUES(@Ptnt_id, @Ptnt_Fname,@Ptnt_Minitial, @Ptnt_Lname,@Ptnt_bday,@Ptnt_gender,@Ptnt_CurntAdd,@Ptnt_pmntAdd,@Ptnt_HomeNum,@Ptnt_WorkNum,@Ptnt_MobileNum );", Con);

            Cmd.Parameters.Add(new MySqlParameter("@Ptnt_id", idemp));
            Cmd.Parameters.Add(new MySqlParameter("@Ptnt_Fname", fname));
            Cmd.Parameters.Add(new MySqlParameter("@Ptnt_Lname", lname));
            Cmd.Parameters.Add(new MySqlParameter("@Ptnt_Minitial", mi));
            Cmd.Parameters.Add(new MySqlParameter("@Ptnt_bday", bday));
            Cmd.Parameters.Add(new MySqlParameter("@Ptnt_gender", gender));
            Cmd.Parameters.Add(new MySqlParameter("@Ptnt_CurntAdd", addCrnt));
            Cmd.Parameters.Add(new MySqlParameter("@Ptnt_pmntAdd", addPer));
            Cmd.Parameters.Add(new MySqlParameter("@Ptnt_HomeNum", Wnum));
            Cmd.Parameters.Add(new MySqlParameter("@Ptnt_WorkNum", Wnum));
            Cmd.Parameters.Add(new MySqlParameter("@Ptnt_MobileNum", Hnum));

            try
            {
                Con.Open();
                Cmd.ExecuteNonQuery();
                Con.Close();
                Con.Dispose();
                retValue = true;
            }
            catch (Exception e)
            {
                this.ErrorMsg = e.Message;
                ShowErrorMsg();
                retValue = false;
            }
            return retValue;

        }

        public bool addMed(int idMed, int idemp, string tongue, string palate, string tonsil, string lips, string floor, string cheeks, string allergy, string heart, string blood, string diabetes, string kidney, string liver, string hygiene, string others)
        {

            bool retValue = false;
            Con = new MySqlConnection(conString());
            Cmd = new MySqlCommand(@"INSERT INTO `tbl_medicalhistory` VALUES (@idMed,@Ptnt_id,@txt_tongue,@txt_palate,@txt_tonsil,@txt_lips,@txt_floorOfMouth,@txt_cheeks,@txt_allergy,@txt_HeartDisease,@txt_BloodDyscracia,@txt_Diabetes,@txt_kidney,@txt_liver,@txt_hygiene,@txt_others) ON DUPLICATE KEY UPDATE txt_tongue='" + tongue + "', txt_palate='" + palate + "', txt_tonsil='" + tonsil + "', txt_lips='" + lips + "', txt_floorOfMouth='" + floor + "', txt_cheeks='" + cheeks + "', txt_allergy='" + allergy + "', txt_HeartDisease='" + heart + "', txt_BloodDyscracia='" + blood + "', txt_Diabetes='" + diabetes + "', txt_kidney='" + kidney + "', txt_liver='" + liver + "', txt_hygiene='" + hygiene + "', txt_others='" + others + "' ;", Con);

            Cmd.Parameters.Add(new MySqlParameter("@idMed", idMed));
            Cmd.Parameters.Add(new MySqlParameter("@Ptnt_id", idemp));
            Cmd.Parameters.Add(new MySqlParameter("@txt_tongue", tongue));
            Cmd.Parameters.Add(new MySqlParameter("@txt_palate", palate));
            Cmd.Parameters.Add(new MySqlParameter("@txt_tonsil", tonsil));
            Cmd.Parameters.Add(new MySqlParameter("@txt_lips", lips));
            Cmd.Parameters.Add(new MySqlParameter("@txt_floorOfMouth", floor));
            Cmd.Parameters.Add(new MySqlParameter("@txt_cheeks", cheeks));
            Cmd.Parameters.Add(new MySqlParameter("@txt_allergy", allergy));
            Cmd.Parameters.Add(new MySqlParameter("@txt_HeartDisease", heart));
            Cmd.Parameters.Add(new MySqlParameter("@txt_BloodDyscracia", blood));
            Cmd.Parameters.Add(new MySqlParameter("@txt_Diabetes", diabetes));
            Cmd.Parameters.Add(new MySqlParameter("@txt_kidney", kidney));
            Cmd.Parameters.Add(new MySqlParameter("@txt_liver", liver));
            Cmd.Parameters.Add(new MySqlParameter("@txt_hygiene", hygiene));
            Cmd.Parameters.Add(new MySqlParameter("@txt_others", others));
            
            

            try
            {
                Con.Open();
                Cmd.ExecuteNonQuery();
                Con.Close();
                Con.Dispose();
                retValue = true;
            }
            catch (Exception e)
            {
                this.ErrorMsg = e.Message;
                ShowErrorMsg();
                retValue = false;
            }
            return retValue;

        }


        public bool addService(int idemp, string sname, string sdtl, string sprice)
        {
            bool retValue = false;
            Con = new MySqlConnection(conString());
            Cmd = new MySqlCommand(@"INSERT INTO clinic.tbl_services VALUES(@service_id,@service_name,@service_details,@service_price);", Con);

            Cmd.Parameters.Add(new MySqlParameter("@service_id", idemp));
            Cmd.Parameters.Add(new MySqlParameter("@service_name", sname));
            Cmd.Parameters.Add(new MySqlParameter("@service_details", sdtl));
            Cmd.Parameters.Add(new MySqlParameter("@service_price", sprice));


            try
            {
                Con.Open();
                Cmd.ExecuteNonQuery();
                Con.Close();
                Con.Dispose();
                retValue = true;
            }
            catch (Exception e)
            {
                this.ErrorMsg = e.Message;
                ShowErrorMsg();
                retValue = false;
            }
            return retValue;
        }

        public bool addSched(int idSched, string id, string doctor, string remarks, string date, string time, string thistime, string stat)
        {

            bool retValue = false;
            Con = new MySqlConnection(conString());
            Cmd = new MySqlCommand(@"INSERT INTO `tbl_schedule` VALUES (@sched_id,@ptnt_id,@doc_id,@remarks,@sched_date,@sched_time,@this_dateTime,@status);", Con);

            Cmd.Parameters.Add(new MySqlParameter("@sched_id", idSched));
            Cmd.Parameters.Add(new MySqlParameter("@ptnt_id", id));
            Cmd.Parameters.Add(new MySqlParameter("@doc_id", doctor));
            Cmd.Parameters.Add(new MySqlParameter("@remarks", remarks));
            Cmd.Parameters.Add(new MySqlParameter("@sched_date", date));
            Cmd.Parameters.Add(new MySqlParameter("@sched_time", time));
            Cmd.Parameters.Add(new MySqlParameter("@this_dateTime", thistime));
            Cmd.Parameters.Add(new MySqlParameter("@status", stat));

            try
            {
                Con.Open();
                Cmd.ExecuteNonQuery();
                Con.Close();
                Con.Dispose();
                retValue = true;
            }
            catch (Exception e)
            {
                this.ErrorMsg = e.Message;
                ShowErrorMsg();
                retValue = false;
            }
            return retValue;

        }

        public bool Populate(ListView Lsv, string Qry)
        {
            bool RetValue = false;
            Lsv.Items.Clear();

            Con = new MySqlConnection(conString());
            Cmd = new MySqlCommand(Qry, Con);

            try
            {
                Con.Open();
                Reader = Cmd.ExecuteReader();
                while (Reader.Read())
                {
                    ListViewItem lst = new ListViewItem(Reader.GetValue(0).ToString());

                    for (int x = 1; x < Lsv.Columns.Count; x++)
                    {
                        lst.SubItems.Add(Reader.GetValue(x).ToString());

                    }
                    Lsv.Items.Add(lst);
                }
                Con.Close();
                Con.Dispose();
                RetValue = true;
            }
            catch (Exception e)
            {
                this.ErrorMsg = e.Message;
                RetValue = false;
                ShowErrorMsg();

            }
            return RetValue;
        }

        //public void ClearMedHistory()
        //{
        //    My_Patients mp = new My_Patients();
        //    mp.txt_tongue.Text = "";
        //    mp.txt_palate.Text = "";
        //    mp.txt_tonsil.Text = "";
        //    mp.txt_lips.Text = "";
        //    mp.txt_floorOfMouth.Text = "";
        //    mp.txt_cheeks.Text = "";
        //    mp.txt_allergy.Text = "";
        //    mp.txt_HeartDisease.Text = "";
        //    mp.txt_BloodDyscracia.Text = "";
        //    mp.txt_Diabetes.Text = "";
        //    mp.txt_kidney.Text = "";
        //    mp.txt_liver.Text = "";
        //    mp.txt_hygiene.Text = "";
        //    mp.txt_others.Text = "";
        //}

       //------------------------------------------------------------------------------

        public string getMD5(string text)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;
            StringBuilder str = new StringBuilder();

            for (int i = 1; i < result.Length; i++)
            {
                str.Append(result[i].ToString("x2"));
            }
            return str.ToString();
        }
    }
}
