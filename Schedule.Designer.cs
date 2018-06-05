namespace Dental_System
{
    partial class Schedule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.time_txt = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_doctor = new System.Windows.Forms.ComboBox();
            this.btnSched = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.sdate_txt = new System.Windows.Forms.TextBox();
            this.btn_set = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.thistime = new System.Windows.Forms.Label();
            this.timer12 = new System.Windows.Forms.Timer(this.components);
            this.dsp_pno = new System.Windows.Forms.TextBox();
            this.dsp_fname = new System.Windows.Forms.TextBox();
            this.dsp_id2 = new System.Windows.Forms.TextBox();
            this.dsp_lname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_remarks = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.doc_ID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time";
            // 
            // time_txt
            // 
            this.time_txt.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_txt.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time_txt.Location = new System.Drawing.Point(36, 314);
            this.time_txt.Name = "time_txt";
            this.time_txt.ShowUpDown = true;
            this.time_txt.Size = new System.Drawing.Size(227, 27);
            this.time_txt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(328, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Doctor";
            // 
            // txt_doctor
            // 
            this.txt_doctor.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F);
            this.txt_doctor.FormattingEnabled = true;
            this.txt_doctor.Location = new System.Drawing.Point(422, 216);
            this.txt_doctor.Name = "txt_doctor";
            this.txt_doctor.Size = new System.Drawing.Size(227, 27);
            this.txt_doctor.TabIndex = 9;
            this.txt_doctor.SelectedIndexChanged += new System.EventHandler(this.txt_doctor_SelectedIndexChanged);
            // 
            // btnSched
            // 
            this.btnSched.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnSched.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSched.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSched.Location = new System.Drawing.Point(451, 368);
            this.btnSched.Name = "btnSched";
            this.btnSched.Size = new System.Drawing.Size(115, 34);
            this.btnSched.TabIndex = 69;
            this.btnSched.Text = "Schedule";
            this.btnSched.UseVisualStyleBackColor = false;
            this.btnSched.Click += new System.EventHandler(this.btnSched_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Helvetica Neue LT Std", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(241, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 32);
            this.label6.TabIndex = 70;
            this.label6.Text = "Schedule Patient";
            // 
            // sdate_txt
            // 
            this.sdate_txt.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F);
            this.sdate_txt.Location = new System.Drawing.Point(36, 239);
            this.sdate_txt.Name = "sdate_txt";
            this.sdate_txt.ReadOnly = true;
            this.sdate_txt.Size = new System.Drawing.Size(186, 27);
            this.sdate_txt.TabIndex = 71;
            this.sdate_txt.TextChanged += new System.EventHandler(this.sdate_txt_TextChanged);
            // 
            // btn_set
            // 
            this.btn_set.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btn_set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_set.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_set.Location = new System.Drawing.Point(222, 238);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(41, 28);
            this.btn_set.TabIndex = 72;
            this.btn_set.Text = "OK";
            this.btn_set.UseVisualStyleBackColor = false;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(36, 78);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 73;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // thistime
            // 
            this.thistime.AutoSize = true;
            this.thistime.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thistime.Location = new System.Drawing.Point(23, 376);
            this.thistime.Name = "thistime";
            this.thistime.Size = new System.Drawing.Size(42, 18);
            this.thistime.TabIndex = 82;
            this.thistime.Text = "Time";
            this.thistime.Click += new System.EventHandler(this.label8_Click);
            // 
            // timer12
            // 
            this.timer12.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dsp_pno
            // 
            this.dsp_pno.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F);
            this.dsp_pno.Location = new System.Drawing.Point(422, 178);
            this.dsp_pno.Name = "dsp_pno";
            this.dsp_pno.ReadOnly = true;
            this.dsp_pno.Size = new System.Drawing.Size(226, 27);
            this.dsp_pno.TabIndex = 100;
            // 
            // dsp_fname
            // 
            this.dsp_fname.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F);
            this.dsp_fname.Location = new System.Drawing.Point(422, 112);
            this.dsp_fname.Name = "dsp_fname";
            this.dsp_fname.ReadOnly = true;
            this.dsp_fname.Size = new System.Drawing.Size(226, 27);
            this.dsp_fname.TabIndex = 99;
            // 
            // dsp_id2
            // 
            this.dsp_id2.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F);
            this.dsp_id2.Location = new System.Drawing.Point(422, 79);
            this.dsp_id2.Name = "dsp_id2";
            this.dsp_id2.ReadOnly = true;
            this.dsp_id2.Size = new System.Drawing.Size(226, 27);
            this.dsp_id2.TabIndex = 98;
            // 
            // dsp_lname
            // 
            this.dsp_lname.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F);
            this.dsp_lname.Location = new System.Drawing.Point(422, 145);
            this.dsp_lname.Name = "dsp_lname";
            this.dsp_lname.ReadOnly = true;
            this.dsp_lname.Size = new System.Drawing.Size(226, 27);
            this.dsp_lname.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 96;
            this.label2.Text = "Phone no.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(328, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 18);
            this.label8.TabIndex = 95;
            this.label8.Text = "Lastname";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(328, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 18);
            this.label9.TabIndex = 94;
            this.label9.Text = "Firstname";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(332, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 18);
            this.label10.TabIndex = 93;
            this.label10.Text = "ID";
            // 
            // txt_remarks
            // 
            this.txt_remarks.Location = new System.Drawing.Point(335, 276);
            this.txt_remarks.Name = "txt_remarks";
            this.txt_remarks.Size = new System.Drawing.Size(314, 84);
            this.txt_remarks.TabIndex = 101;
            this.txt_remarks.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(329, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 102;
            this.label4.Text = "Remarks";
            // 
            // doc_ID
            // 
            this.doc_ID.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F);
            this.doc_ID.Location = new System.Drawing.Point(422, 216);
            this.doc_ID.Name = "doc_ID";
            this.doc_ID.ReadOnly = true;
            this.doc_ID.Size = new System.Drawing.Size(58, 27);
            this.doc_ID.TabIndex = 103;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(680, 407);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_remarks);
            this.Controls.Add(this.thistime);
            this.Controls.Add(this.dsp_pno);
            this.Controls.Add(this.dsp_fname);
            this.Controls.Add(this.dsp_id2);
            this.Controls.Add(this.dsp_lname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btn_set);
            this.Controls.Add(this.sdate_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSched);
            this.Controls.Add(this.txt_doctor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.time_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doc_ID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Schedule";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.Schedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker time_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txt_doctor;
        private System.Windows.Forms.Button btnSched;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sdate_txt;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label thistime;
        private System.Windows.Forms.Timer timer12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox dsp_id2;
        public System.Windows.Forms.TextBox dsp_pno;
        public System.Windows.Forms.TextBox dsp_fname;
        public System.Windows.Forms.TextBox dsp_lname;
        private System.Windows.Forms.RichTextBox txt_remarks;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox doc_ID;
    }
}