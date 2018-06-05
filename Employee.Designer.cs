namespace Dental_System
{
    partial class Employee
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
            this.rb_fname = new System.Windows.Forms.RadioButton();
            this.rb_lname = new System.Windows.Forms.RadioButton();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_active = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_blocked = new System.Windows.Forms.RadioButton();
            this.rb_active = new System.Windows.Forms.RadioButton();
            this.btn_block = new System.Windows.Forms.Button();
            this.dsp_id = new System.Windows.Forms.TextBox();
            this.emp_view = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rb_nfname = new System.Windows.Forms.RadioButton();
            this.rb_nlname = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_fname
            // 
            this.rb_fname.AutoSize = true;
            this.rb_fname.Location = new System.Drawing.Point(602, 74);
            this.rb_fname.Name = "rb_fname";
            this.rb_fname.Size = new System.Drawing.Size(75, 17);
            this.rb_fname.TabIndex = 30;
            this.rb_fname.TabStop = true;
            this.rb_fname.Text = "First Name";
            this.rb_fname.UseVisualStyleBackColor = true;
            this.rb_fname.CheckedChanged += new System.EventHandler(this.rb_fname_CheckedChanged);
            // 
            // rb_lname
            // 
            this.rb_lname.AutoSize = true;
            this.rb_lname.Location = new System.Drawing.Point(694, 74);
            this.rb_lname.Name = "rb_lname";
            this.rb_lname.Size = new System.Drawing.Size(76, 17);
            this.rb_lname.TabIndex = 29;
            this.rb_lname.TabStop = true;
            this.rb_lname.Text = "Last Name";
            this.rb_lname.UseVisualStyleBackColor = true;
            this.rb_lname.CheckedChanged += new System.EventHandler(this.rb_lname_CheckedChanged);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(805, 36);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(86, 32);
            this.btn_search.TabIndex = 27;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(562, 37);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(239, 29);
            this.txt_search.TabIndex = 26;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            this.txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_search_KeyPress);
            // 
            // btn_active
            // 
            this.btn_active.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_active.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_active.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_active.Location = new System.Drawing.Point(452, 56);
            this.btn_active.Name = "btn_active";
            this.btn_active.Size = new System.Drawing.Size(86, 35);
            this.btn_active.TabIndex = 22;
            this.btn_active.Text = "Activate ";
            this.btn_active.UseVisualStyleBackColor = false;
            this.btn_active.Click += new System.EventHandler(this.btn_active_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_blocked);
            this.groupBox1.Controls.Add(this.rb_active);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 60);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select to view employee";
            // 
            // rb_blocked
            // 
            this.rb_blocked.AutoSize = true;
            this.rb_blocked.Location = new System.Drawing.Point(219, 23);
            this.rb_blocked.Name = "rb_blocked";
            this.rb_blocked.Size = new System.Drawing.Size(154, 25);
            this.rb_blocked.TabIndex = 2;
            this.rb_blocked.TabStop = true;
            this.rb_blocked.Text = "Blocked Employee";
            this.rb_blocked.UseVisualStyleBackColor = true;
            this.rb_blocked.CheckedChanged += new System.EventHandler(this.rb_blocked_CheckedChanged);
            // 
            // rb_active
            // 
            this.rb_active.AutoSize = true;
            this.rb_active.Location = new System.Drawing.Point(42, 22);
            this.rb_active.Name = "rb_active";
            this.rb_active.Size = new System.Drawing.Size(142, 25);
            this.rb_active.TabIndex = 1;
            this.rb_active.TabStop = true;
            this.rb_active.Text = "Active Employee";
            this.rb_active.UseVisualStyleBackColor = true;
            this.rb_active.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btn_block
            // 
            this.btn_block.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_block.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_block.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_block.Location = new System.Drawing.Point(452, 56);
            this.btn_block.Name = "btn_block";
            this.btn_block.Size = new System.Drawing.Size(86, 35);
            this.btn_block.TabIndex = 23;
            this.btn_block.Text = "Block";
            this.btn_block.UseVisualStyleBackColor = false;
            this.btn_block.Click += new System.EventHandler(this.btn_block_Click);
            // 
            // dsp_id
            // 
            this.dsp_id.Location = new System.Drawing.Point(438, 18);
            this.dsp_id.Name = "dsp_id";
            this.dsp_id.Size = new System.Drawing.Size(100, 20);
            this.dsp_id.TabIndex = 24;
            this.dsp_id.Visible = false;
            // 
            // emp_view
            // 
            this.emp_view.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader1,
            this.columnHeader17});
            this.emp_view.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_view.FullRowSelect = true;
            this.emp_view.GridLines = true;
            this.emp_view.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.emp_view.Location = new System.Drawing.Point(12, 102);
            this.emp_view.MultiSelect = false;
            this.emp_view.Name = "emp_view";
            this.emp_view.Size = new System.Drawing.Size(922, 359);
            this.emp_view.TabIndex = 20;
            this.emp_view.UseCompatibleStateImageBehavior = false;
            this.emp_view.View = System.Windows.Forms.View.Details;
            this.emp_view.SelectedIndexChanged += new System.EventHandler(this.emp_view_SelectedIndexChanged);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ID";
            this.columnHeader8.Width = 35;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Firstname";
            this.columnHeader9.Width = 137;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Lastname";
            this.columnHeader10.Width = 164;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Username";
            this.columnHeader13.Width = 108;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Gender";
            this.columnHeader14.Width = 79;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Position";
            this.columnHeader15.Width = 129;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Status";
            this.columnHeader16.Width = 90;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Phone #";
            this.columnHeader1.Width = 116;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Active";
            // 
            // rb_nfname
            // 
            this.rb_nfname.AutoSize = true;
            this.rb_nfname.Location = new System.Drawing.Point(602, 74);
            this.rb_nfname.Name = "rb_nfname";
            this.rb_nfname.Size = new System.Drawing.Size(75, 17);
            this.rb_nfname.TabIndex = 32;
            this.rb_nfname.TabStop = true;
            this.rb_nfname.Text = "First Name";
            this.rb_nfname.UseVisualStyleBackColor = true;
            this.rb_nfname.CheckedChanged += new System.EventHandler(this.rb_nfname_CheckedChanged);
            // 
            // rb_nlname
            // 
            this.rb_nlname.AutoSize = true;
            this.rb_nlname.Location = new System.Drawing.Point(694, 74);
            this.rb_nlname.Name = "rb_nlname";
            this.rb_nlname.Size = new System.Drawing.Size(76, 17);
            this.rb_nlname.TabIndex = 31;
            this.rb_nlname.TabStop = true;
            this.rb_nlname.Text = "Last Name";
            this.rb_nlname.UseVisualStyleBackColor = true;
            this.rb_nlname.CheckedChanged += new System.EventHandler(this.rb_nlname_CheckedChanged);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(943, 471);
            this.Controls.Add(this.rb_nfname);
            this.Controls.Add(this.rb_nlname);
            this.Controls.Add(this.rb_fname);
            this.Controls.Add(this.rb_lname);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_active);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_block);
            this.Controls.Add(this.dsp_id);
            this.Controls.Add(this.emp_view);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Employee";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_fname;
        private System.Windows.Forms.RadioButton rb_lname;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_active;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_blocked;
        private System.Windows.Forms.RadioButton rb_active;
        private System.Windows.Forms.Button btn_block;
        private System.Windows.Forms.TextBox dsp_id;
        private System.Windows.Forms.ListView emp_view;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.RadioButton rb_nfname;
        private System.Windows.Forms.RadioButton rb_nlname;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}