namespace Dental_System
{
    partial class Billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sLabel = new System.Windows.Forms.Label();
            this.add1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.price1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.qty1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.name1 = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.service_txt = new System.Windows.Forms.TextBox();
            this.mylist = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.dsp_total = new System.Windows.Forms.TextBox();
            this.patient_search = new System.Windows.Forms.Button();
            this.rb_nfname = new System.Windows.Forms.RadioButton();
            this.rb_nlname = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.patient_txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.discount = new System.Windows.Forms.CheckBox();
            this.dsp_time = new System.Windows.Forms.Label();
            this.bill_dspName = new System.Windows.Forms.Label();
            this.dsp_transNo = new System.Windows.Forms.Label();
            this.trans_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.changed = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cash = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dsp_id = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sLabel);
            this.groupBox2.Controls.Add(this.add1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.price1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.qty1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.name1);
            this.groupBox2.Controls.Add(this.search);
            this.groupBox2.Controls.Add(this.service_txt);
            this.groupBox2.Font = new System.Drawing.Font("Helvetica Neue LT Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 278);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Services";
            // 
            // sLabel
            // 
            this.sLabel.AutoSize = true;
            this.sLabel.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sLabel.Location = new System.Drawing.Point(23, 216);
            this.sLabel.Name = "sLabel";
            this.sLabel.Size = new System.Drawing.Size(12, 18);
            this.sLabel.TabIndex = 102;
            this.sLabel.Text = ".";
            this.sLabel.Visible = false;
            // 
            // add1
            // 
            this.add1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.add1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add1.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add1.Location = new System.Drawing.Point(106, 216);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(73, 29);
            this.add1.TabIndex = 97;
            this.add1.Text = "ADD ➕";
            this.add1.UseVisualStyleBackColor = false;
            this.add1.Click += new System.EventHandler(this.add1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(15, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 96;
            this.label4.Text = "Price";
            // 
            // price1
            // 
            this.price1.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F);
            this.price1.Location = new System.Drawing.Point(18, 169);
            this.price1.Name = "price1";
            this.price1.ReadOnly = true;
            this.price1.Size = new System.Drawing.Size(94, 27);
            this.price1.TabIndex = 95;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(159, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 94;
            this.label5.Text = "Quantity";
            // 
            // qty1
            // 
            this.qty1.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F);
            this.qty1.ForeColor = System.Drawing.Color.Green;
            this.qty1.Location = new System.Drawing.Point(162, 169);
            this.qty1.Name = "qty1";
            this.qty1.Size = new System.Drawing.Size(94, 27);
            this.qty1.TabIndex = 93;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 92;
            this.label6.Text = "Name";
            // 
            // name1
            // 
            this.name1.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F);
            this.name1.Location = new System.Drawing.Point(18, 106);
            this.name1.Name = "name1";
            this.name1.ReadOnly = true;
            this.name1.Size = new System.Drawing.Size(238, 27);
            this.name1.TabIndex = 91;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.White;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.Blue;
            this.search.Location = new System.Drawing.Point(244, 41);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(30, 27);
            this.search.TabIndex = 84;
            this.search.Text = "🔍";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // service_txt
            // 
            this.service_txt.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F);
            this.service_txt.Location = new System.Drawing.Point(18, 41);
            this.service_txt.Name = "service_txt";
            this.service_txt.Size = new System.Drawing.Size(226, 27);
            this.service_txt.TabIndex = 83;
            // 
            // mylist
            // 
            this.mylist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.mylist.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mylist.FullRowSelect = true;
            this.mylist.GridLines = true;
            this.mylist.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.mylist.Location = new System.Drawing.Point(325, 20);
            this.mylist.MultiSelect = false;
            this.mylist.Name = "mylist";
            this.mylist.Scrollable = false;
            this.mylist.Size = new System.Drawing.Size(574, 213);
            this.mylist.TabIndex = 21;
            this.mylist.UseCompatibleStateImageBehavior = false;
            this.mylist.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Service";
            this.columnHeader1.Width = 219;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            this.columnHeader2.Width = 101;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Unit Price";
            this.columnHeader3.Width = 137;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sub Total";
            this.columnHeader4.Width = 132;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(662, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 25);
            this.label10.TabIndex = 92;
            this.label10.Text = "Total Price";
            // 
            // dsp_total
            // 
            this.dsp_total.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsp_total.Location = new System.Drawing.Point(765, 239);
            this.dsp_total.Name = "dsp_total";
            this.dsp_total.ReadOnly = true;
            this.dsp_total.Size = new System.Drawing.Size(134, 33);
            this.dsp_total.TabIndex = 93;
            // 
            // patient_search
            // 
            this.patient_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.patient_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patient_search.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_search.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.patient_search.Image = ((System.Drawing.Image)(resources.GetObject("patient_search.Image")));
            this.patient_search.Location = new System.Drawing.Point(206, 36);
            this.patient_search.Name = "patient_search";
            this.patient_search.Size = new System.Drawing.Size(34, 27);
            this.patient_search.TabIndex = 98;
            this.patient_search.UseVisualStyleBackColor = false;
            this.patient_search.Click += new System.EventHandler(this.patient_search_Click);
            // 
            // rb_nfname
            // 
            this.rb_nfname.AutoSize = true;
            this.rb_nfname.Location = new System.Drawing.Point(32, 67);
            this.rb_nfname.Name = "rb_nfname";
            this.rb_nfname.Size = new System.Drawing.Size(75, 17);
            this.rb_nfname.TabIndex = 97;
            this.rb_nfname.TabStop = true;
            this.rb_nfname.Text = "First Name";
            this.rb_nfname.UseVisualStyleBackColor = true;
            this.rb_nfname.CheckedChanged += new System.EventHandler(this.rb_nfname_CheckedChanged);
            // 
            // rb_nlname
            // 
            this.rb_nlname.AutoSize = true;
            this.rb_nlname.Location = new System.Drawing.Point(122, 67);
            this.rb_nlname.Name = "rb_nlname";
            this.rb_nlname.Size = new System.Drawing.Size(76, 17);
            this.rb_nlname.TabIndex = 96;
            this.rb_nlname.TabStop = true;
            this.rb_nlname.Text = "Last Name";
            this.rb_nlname.UseVisualStyleBackColor = true;
            this.rb_nlname.CheckedChanged += new System.EventHandler(this.rb_nlname_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 18);
            this.label7.TabIndex = 95;
            this.label7.Text = "Search Patient";
            // 
            // patient_txt
            // 
            this.patient_txt.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F);
            this.patient_txt.Location = new System.Drawing.Point(12, 36);
            this.patient_txt.Name = "patient_txt";
            this.patient_txt.Size = new System.Drawing.Size(194, 27);
            this.patient_txt.TabIndex = 94;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_discount);
            this.groupBox1.Controls.Add(this.discount);
            this.groupBox1.Controls.Add(this.dsp_time);
            this.groupBox1.Controls.Add(this.bill_dspName);
            this.groupBox1.Controls.Add(this.dsp_transNo);
            this.groupBox1.Controls.Add(this.trans_save);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.changed);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cash);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(334, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 244);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            // 
            // txt_discount
            // 
            this.txt_discount.BackColor = System.Drawing.Color.DarkGray;
            this.txt_discount.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F);
            this.txt_discount.Location = new System.Drawing.Point(290, 36);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.ReadOnly = true;
            this.txt_discount.Size = new System.Drawing.Size(258, 27);
            this.txt_discount.TabIndex = 110;
            this.txt_discount.TextChanged += new System.EventHandler(this.txt_discount_TextChanged);
            // 
            // discount
            // 
            this.discount.AutoSize = true;
            this.discount.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount.Location = new System.Drawing.Point(269, 16);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(121, 22);
            this.discount.TabIndex = 111;
            this.discount.Text = "Add Discount";
            this.discount.UseVisualStyleBackColor = true;
            this.discount.CheckedChanged += new System.EventHandler(this.discount_CheckedChanged);
            // 
            // dsp_time
            // 
            this.dsp_time.AutoSize = true;
            this.dsp_time.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsp_time.Location = new System.Drawing.Point(44, 196);
            this.dsp_time.Name = "dsp_time";
            this.dsp_time.Size = new System.Drawing.Size(42, 18);
            this.dsp_time.TabIndex = 108;
            this.dsp_time.Text = "Time";
            this.dsp_time.Click += new System.EventHandler(this.dsp_time_Click);
            // 
            // bill_dspName
            // 
            this.bill_dspName.AutoSize = true;
            this.bill_dspName.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_dspName.Location = new System.Drawing.Point(44, 163);
            this.bill_dspName.Name = "bill_dspName";
            this.bill_dspName.Size = new System.Drawing.Size(50, 18);
            this.bill_dspName.TabIndex = 107;
            this.bill_dspName.Text = "Name";
            // 
            // dsp_transNo
            // 
            this.dsp_transNo.AutoSize = true;
            this.dsp_transNo.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsp_transNo.Location = new System.Drawing.Point(15, 38);
            this.dsp_transNo.Name = "dsp_transNo";
            this.dsp_transNo.Size = new System.Drawing.Size(25, 18);
            this.dsp_transNo.TabIndex = 103;
            this.dsp_transNo.Text = "no";
            // 
            // trans_save
            // 
            this.trans_save.BackColor = System.Drawing.Color.OliveDrab;
            this.trans_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trans_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trans_save.ForeColor = System.Drawing.Color.White;
            this.trans_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trans_save.Location = new System.Drawing.Point(351, 196);
            this.trans_save.Name = "trans_save";
            this.trans_save.Size = new System.Drawing.Size(160, 34);
            this.trans_save.TabIndex = 106;
            this.trans_save.Text = "SAVE";
            this.trans_save.UseVisualStyleBackColor = false;
            this.trans_save.Click += new System.EventHandler(this.trans_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 102;
            this.label1.Text = "Transaction no.";
            // 
            // changed
            // 
            this.changed.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F);
            this.changed.Location = new System.Drawing.Point(290, 154);
            this.changed.Name = "changed";
            this.changed.ReadOnly = true;
            this.changed.Size = new System.Drawing.Size(258, 27);
            this.changed.TabIndex = 105;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(270, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 18);
            this.label11.TabIndex = 104;
            this.label11.Text = "Changed";
            // 
            // cash
            // 
            this.cash.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F);
            this.cash.Location = new System.Drawing.Point(290, 92);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(258, 27);
            this.cash.TabIndex = 103;
            this.cash.TextChanged += new System.EventHandler(this.cash_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(270, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 18);
            this.label9.TabIndex = 102;
            this.label9.Text = "Amount Handed";
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.Location = new System.Drawing.Point(46, 131);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(12, 18);
            this.fname.TabIndex = 100;
            this.fname.Text = ".";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(197, 131);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(12, 18);
            this.lname.TabIndex = 101;
            this.lname.Text = ".";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 18);
            this.label8.TabIndex = 99;
            this.label8.Text = "Name";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dsp_id
            // 
            this.dsp_id.AutoSize = true;
            this.dsp_id.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsp_id.Location = new System.Drawing.Point(632, 254);
            this.dsp_id.Name = "dsp_id";
            this.dsp_id.Size = new System.Drawing.Size(12, 18);
            this.dsp_id.TabIndex = 101;
            this.dsp_id.Text = ".";
            this.dsp_id.Visible = false;
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(914, 529);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dsp_id);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dsp_total);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.mylist);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rb_nlname);
            this.Controls.Add(this.patient_txt);
            this.Controls.Add(this.rb_nfname);
            this.Controls.Add(this.patient_search);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Billing";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox service_txt;
        public System.Windows.Forms.ListView mylist;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button add1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox price1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox qty1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name1;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox dsp_total;
        private System.Windows.Forms.Button patient_search;
        private System.Windows.Forms.RadioButton rb_nfname;
        private System.Windows.Forms.RadioButton rb_nlname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox patient_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button trans_save;
        private System.Windows.Forms.TextBox changed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cash;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label dsp_time;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label bill_dspName;
        private System.Windows.Forms.Label dsp_id;
        private System.Windows.Forms.Label sLabel;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dsp_transNo;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.CheckBox discount;
    }
}