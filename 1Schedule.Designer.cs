namespace Dental_System
{
    partial class _1Schedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_1Schedule));
            this.ptnt_list = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.rb_nfname = new System.Windows.Forms.RadioButton();
            this.rb_nlname = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.patient_txt = new System.Windows.Forms.TextBox();
            this.btn_set = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dsp_lname = new System.Windows.Forms.TextBox();
            this.dsp_id = new System.Windows.Forms.TextBox();
            this.dsp_fname = new System.Windows.Forms.TextBox();
            this.dsp_pno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ptnt_list
            // 
            this.ptnt_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ptnt_list.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F);
            this.ptnt_list.FullRowSelect = true;
            this.ptnt_list.GridLines = true;
            this.ptnt_list.Location = new System.Drawing.Point(14, 99);
            this.ptnt_list.MultiSelect = false;
            this.ptnt_list.Name = "ptnt_list";
            this.ptnt_list.Size = new System.Drawing.Size(525, 97);
            this.ptnt_list.TabIndex = 83;
            this.ptnt_list.UseCompatibleStateImageBehavior = false;
            this.ptnt_list.View = System.Windows.Forms.View.Details;
            this.ptnt_list.SelectedIndexChanged += new System.EventHandler(this.ptnt_list_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Firstname";
            this.columnHeader2.Width = 172;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Lastname";
            this.columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Phone no.";
            this.columnHeader4.Width = 124;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(413, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 27);
            this.button1.TabIndex = 82;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rb_nfname
            // 
            this.rb_nfname.AutoSize = true;
            this.rb_nfname.Location = new System.Drawing.Point(190, 69);
            this.rb_nfname.Name = "rb_nfname";
            this.rb_nfname.Size = new System.Drawing.Size(75, 17);
            this.rb_nfname.TabIndex = 81;
            this.rb_nfname.TabStop = true;
            this.rb_nfname.Text = "First Name";
            this.rb_nfname.UseVisualStyleBackColor = true;
            this.rb_nfname.CheckedChanged += new System.EventHandler(this.rb_nfname_CheckedChanged);
            // 
            // rb_nlname
            // 
            this.rb_nlname.AutoSize = true;
            this.rb_nlname.Location = new System.Drawing.Point(291, 69);
            this.rb_nlname.Name = "rb_nlname";
            this.rb_nlname.Size = new System.Drawing.Size(76, 17);
            this.rb_nlname.TabIndex = 80;
            this.rb_nlname.TabStop = true;
            this.rb_nlname.Text = "Last Name";
            this.rb_nlname.UseVisualStyleBackColor = true;
            this.rb_nlname.CheckedChanged += new System.EventHandler(this.rb_nlname_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 79;
            this.label2.Text = "Search Patient";
            // 
            // patient_txt
            // 
            this.patient_txt.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F);
            this.patient_txt.Location = new System.Drawing.Point(187, 36);
            this.patient_txt.Name = "patient_txt";
            this.patient_txt.Size = new System.Drawing.Size(226, 27);
            this.patient_txt.TabIndex = 78;
            // 
            // btn_set
            // 
            this.btn_set.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btn_set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_set.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_set.Location = new System.Drawing.Point(232, 372);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(104, 34);
            this.btn_set.TabIndex = 84;
            this.btn_set.Text = "Continue";
            this.btn_set.UseVisualStyleBackColor = false;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 18);
            this.label1.TabIndex = 85;
            this.label1.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 86;
            this.label3.Text = "Firstname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 87;
            this.label4.Text = "Lastname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(96, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 88;
            this.label5.Text = "Phone no.";
            // 
            // dsp_lname
            // 
            this.dsp_lname.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F);
            this.dsp_lname.Location = new System.Drawing.Point(190, 291);
            this.dsp_lname.Name = "dsp_lname";
            this.dsp_lname.ReadOnly = true;
            this.dsp_lname.Size = new System.Drawing.Size(226, 27);
            this.dsp_lname.TabIndex = 89;
            // 
            // dsp_id
            // 
            this.dsp_id.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F);
            this.dsp_id.Location = new System.Drawing.Point(190, 225);
            this.dsp_id.Name = "dsp_id";
            this.dsp_id.ReadOnly = true;
            this.dsp_id.Size = new System.Drawing.Size(226, 27);
            this.dsp_id.TabIndex = 90;
            // 
            // dsp_fname
            // 
            this.dsp_fname.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F);
            this.dsp_fname.Location = new System.Drawing.Point(190, 258);
            this.dsp_fname.Name = "dsp_fname";
            this.dsp_fname.ReadOnly = true;
            this.dsp_fname.Size = new System.Drawing.Size(226, 27);
            this.dsp_fname.TabIndex = 91;
            // 
            // dsp_pno
            // 
            this.dsp_pno.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F);
            this.dsp_pno.Location = new System.Drawing.Point(190, 324);
            this.dsp_pno.Name = "dsp_pno";
            this.dsp_pno.ReadOnly = true;
            this.dsp_pno.Size = new System.Drawing.Size(226, 27);
            this.dsp_pno.TabIndex = 92;
            // 
            // _1Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(548, 432);
            this.Controls.Add(this.dsp_pno);
            this.Controls.Add(this.dsp_fname);
            this.Controls.Add(this.dsp_id);
            this.Controls.Add(this.dsp_lname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_set);
            this.Controls.Add(this.ptnt_list);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rb_nfname);
            this.Controls.Add(this.rb_nlname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.patient_txt);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "_1Schedule";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Patient";
            this.Load += new System.EventHandler(this._1Schedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ptnt_list;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rb_nfname;
        private System.Windows.Forms.RadioButton rb_nlname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox patient_txt;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dsp_lname;
        private System.Windows.Forms.TextBox dsp_id;
        private System.Windows.Forms.TextBox dsp_fname;
        private System.Windows.Forms.TextBox dsp_pno;
    }
}