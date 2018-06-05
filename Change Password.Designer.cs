namespace Dental_System
{
    partial class Change_Password
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.old_pass = new System.Windows.Forms.TextBox();
            this.new_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.re_pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.dsp_id = new System.Windows.Forms.Label();
            this.rpass_check = new System.Windows.Forms.PictureBox();
            this.pass_check = new System.Windows.Forms.PictureBox();
            this.label_pass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rpass_check)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pass_check)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica Neue LT Std", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Old Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // old_pass
            // 
            this.old_pass.Location = new System.Drawing.Point(43, 115);
            this.old_pass.Name = "old_pass";
            this.old_pass.PasswordChar = '⚫';
            this.old_pass.Size = new System.Drawing.Size(283, 27);
            this.old_pass.TabIndex = 2;
            this.old_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.old_pass.TextChanged += new System.EventHandler(this.old_pass_TextChanged);
            // 
            // new_pass
            // 
            this.new_pass.Enabled = false;
            this.new_pass.Location = new System.Drawing.Point(41, 225);
            this.new_pass.Name = "new_pass";
            this.new_pass.PasswordChar = '⚫';
            this.new_pass.Size = new System.Drawing.Size(283, 27);
            this.new_pass.TabIndex = 4;
            this.new_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.new_pass.TextChanged += new System.EventHandler(this.new_pass_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter New Password";
            // 
            // re_pass
            // 
            this.re_pass.Enabled = false;
            this.re_pass.Location = new System.Drawing.Point(43, 304);
            this.re_pass.Name = "re_pass";
            this.re_pass.PasswordChar = '⚫';
            this.re_pass.Size = new System.Drawing.Size(283, 27);
            this.re_pass.TabIndex = 6;
            this.re_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.re_pass.TextChanged += new System.EventHandler(this.re_pass_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Re -enter New Password";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(141, 355);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(82, 31);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dsp_id
            // 
            this.dsp_id.AutoSize = true;
            this.dsp_id.Location = new System.Drawing.Point(263, 66);
            this.dsp_id.Name = "dsp_id";
            this.dsp_id.Size = new System.Drawing.Size(50, 18);
            this.dsp_id.TabIndex = 8;
            this.dsp_id.Text = "label5";
            // 
            // rpass_check
            // 
            this.rpass_check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rpass_check.Location = new System.Drawing.Point(331, 307);
            this.rpass_check.Name = "rpass_check";
            this.rpass_check.Size = new System.Drawing.Size(21, 21);
            this.rpass_check.TabIndex = 90;
            this.rpass_check.TabStop = false;
            // 
            // pass_check
            // 
            this.pass_check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pass_check.Location = new System.Drawing.Point(329, 228);
            this.pass_check.Name = "pass_check";
            this.pass_check.Size = new System.Drawing.Size(21, 21);
            this.pass_check.TabIndex = 89;
            this.pass_check.TabStop = false;
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Font = new System.Drawing.Font("Helvetica Neue LT Std", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pass.ForeColor = System.Drawing.Color.Red;
            this.label_pass.Location = new System.Drawing.Point(206, 255);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(120, 14);
            this.label_pass.TabIndex = 91;
            this.label_pass.Text = "*Maximum length reach!";
            this.label_pass.Visible = false;
            // 
            // Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(363, 407);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.rpass_check);
            this.Controls.Add(this.pass_check);
            this.Controls.Add(this.dsp_id);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.re_pass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.new_pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.old_pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Helvetica Neue LT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Change_Password";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.Change_Password_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rpass_check)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pass_check)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox old_pass;
        private System.Windows.Forms.TextBox new_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox re_pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.Label dsp_id;
        private System.Windows.Forms.PictureBox rpass_check;
        private System.Windows.Forms.PictureBox pass_check;
        private System.Windows.Forms.Label label_pass;
    }
}