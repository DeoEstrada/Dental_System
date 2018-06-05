namespace Dental_System
{
    partial class Update_Services
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
            this.update_service = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_sprice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_sdetails = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dsp_id = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.btn_saveService = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // update_service
            // 
            this.update_service.BackColor = System.Drawing.SystemColors.Window;
            this.update_service.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.update_service.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader13});
            this.update_service.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_service.FullRowSelect = true;
            this.update_service.GridLines = true;
            this.update_service.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.update_service.Location = new System.Drawing.Point(12, 101);
            this.update_service.MultiSelect = false;
            this.update_service.Name = "update_service";
            this.update_service.Size = new System.Drawing.Size(321, 486);
            this.update_service.TabIndex = 159;
            this.update_service.UseCompatibleStateImageBehavior = false;
            this.update_service.View = System.Windows.Forms.View.Tile;
            this.update_service.SelectedIndexChanged += new System.EventHandler(this.update_service_SelectedIndexChanged);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ID";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Service Name";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Service Detail";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Service Price";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_search.Location = new System.Drawing.Point(261, 55);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(44, 30);
            this.btn_search.TabIndex = 139;
            this.btn_search.Text = "🔍";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Helvetica Neue LT Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(33, 55);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(228, 30);
            this.txt_search.TabIndex = 138;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(474, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 34);
            this.label5.TabIndex = 136;
            this.label5.Text = "My Services";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(575, 473);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(144, 34);
            this.btn_update.TabIndex = 166;
            this.btn_update.Text = "Update Service";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.EnabledChanged += new System.EventHandler(this.btn_update_EnabledChanged);
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_sprice
            // 
            this.txt_sprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_sprice.Font = new System.Drawing.Font("Helvetica Neue LT Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sprice.Location = new System.Drawing.Point(385, 420);
            this.txt_sprice.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sprice.Name = "txt_sprice";
            this.txt_sprice.Size = new System.Drawing.Size(334, 23);
            this.txt_sprice.TabIndex = 165;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(381, 396);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 164;
            this.label3.Text = "Service Price";
            // 
            // txt_sdetails
            // 
            this.txt_sdetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_sdetails.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txt_sdetails.Location = new System.Drawing.Point(385, 222);
            this.txt_sdetails.Name = "txt_sdetails";
            this.txt_sdetails.Size = new System.Drawing.Size(334, 149);
            this.txt_sdetails.TabIndex = 163;
            this.txt_sdetails.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(381, 189);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 162;
            this.label2.Text = "Service Details";
            // 
            // txt_sname
            // 
            this.txt_sname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_sname.Font = new System.Drawing.Font("Helvetica Neue LT Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sname.Location = new System.Drawing.Point(385, 143);
            this.txt_sname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sname.Name = "txt_sname";
            this.txt_sname.Size = new System.Drawing.Size(334, 23);
            this.txt_sname.TabIndex = 161;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(381, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 160;
            this.label1.Text = "Service Name";
            // 
            // dsp_id
            // 
            this.dsp_id.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dsp_id.Location = new System.Drawing.Point(517, 101);
            this.dsp_id.Margin = new System.Windows.Forms.Padding(4);
            this.dsp_id.Name = "dsp_id";
            this.dsp_id.ReadOnly = true;
            this.dsp_id.Size = new System.Drawing.Size(107, 27);
            this.dsp_id.TabIndex = 167;
            this.dsp_id.Visible = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(575, 473);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(144, 34);
            this.btn_save.TabIndex = 168;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.IndianRed;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(385, 473);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(144, 34);
            this.btn_cancel.TabIndex = 169;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(385, 473);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(144, 34);
            this.btn_add.TabIndex = 170;
            this.btn_add.Text = "Add Service";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelAdd.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAdd.Location = new System.Drawing.Point(385, 473);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(144, 34);
            this.btnCancelAdd.TabIndex = 171;
            this.btnCancelAdd.Text = "CANCEL";
            this.btnCancelAdd.UseVisualStyleBackColor = false;
            this.btnCancelAdd.Click += new System.EventHandler(this.btnCancelAdd_Click);
            // 
            // btn_saveService
            // 
            this.btn_saveService.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_saveService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveService.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveService.Location = new System.Drawing.Point(575, 473);
            this.btn_saveService.Name = "btn_saveService";
            this.btn_saveService.Size = new System.Drawing.Size(144, 34);
            this.btn_saveService.TabIndex = 172;
            this.btn_saveService.Text = "Save";
            this.btn_saveService.UseVisualStyleBackColor = false;
            this.btn_saveService.Click += new System.EventHandler(this.btn_saveService_Click);
            // 
            // Update_Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(744, 599);
            this.Controls.Add(this.btn_saveService);
            this.Controls.Add(this.btnCancelAdd);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dsp_id);
            this.Controls.Add(this.txt_sprice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_sdetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_sname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update_service);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Update_Services";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Services";
            this.Load += new System.EventHandler(this.Update_Services_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView update_service;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_sprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txt_sdetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dsp_id;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btnCancelAdd;
        private System.Windows.Forms.Button btn_saveService;
    }
}