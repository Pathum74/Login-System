namespace UserAuthentication
{
    partial class Frm_Home
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
            this.btn_Attendance = new System.Windows.Forms.Button();
            this.btn_Studnet = new System.Windows.Forms.Button();
            this.btn_adduseradmin = new System.Windows.Forms.Button();
            this.btn_payment = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_loguser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Attendance
            // 
            this.btn_Attendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Attendance.ForeColor = System.Drawing.Color.Green;
            this.btn_Attendance.Location = new System.Drawing.Point(131, 162);
            this.btn_Attendance.Name = "btn_Attendance";
            this.btn_Attendance.Size = new System.Drawing.Size(191, 102);
            this.btn_Attendance.TabIndex = 0;
            this.btn_Attendance.Text = "Attendance";
            this.btn_Attendance.UseVisualStyleBackColor = true;
            // 
            // btn_Studnet
            // 
            this.btn_Studnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Studnet.ForeColor = System.Drawing.Color.Green;
            this.btn_Studnet.Location = new System.Drawing.Point(439, 162);
            this.btn_Studnet.Name = "btn_Studnet";
            this.btn_Studnet.Size = new System.Drawing.Size(191, 102);
            this.btn_Studnet.TabIndex = 2;
            this.btn_Studnet.Text = "Documents";
            this.btn_Studnet.UseVisualStyleBackColor = true;
            // 
            // btn_adduseradmin
            // 
            this.btn_adduseradmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adduseradmin.ForeColor = System.Drawing.Color.Green;
            this.btn_adduseradmin.Location = new System.Drawing.Point(439, 321);
            this.btn_adduseradmin.Name = "btn_adduseradmin";
            this.btn_adduseradmin.Size = new System.Drawing.Size(191, 102);
            this.btn_adduseradmin.TabIndex = 5;
            this.btn_adduseradmin.Text = "Add User/Admin";
            this.btn_adduseradmin.UseVisualStyleBackColor = true;
            this.btn_adduseradmin.Click += new System.EventHandler(this.btn_adduseradmin_Click);
            // 
            // btn_payment
            // 
            this.btn_payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payment.ForeColor = System.Drawing.Color.Green;
            this.btn_payment.Location = new System.Drawing.Point(131, 321);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(191, 102);
            this.btn_payment.TabIndex = 3;
            this.btn_payment.Text = "Settings";
            this.btn_payment.UseVisualStyleBackColor = true;
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.Green;
            this.btn_logout.Location = new System.Drawing.Point(680, 445);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(85, 28);
            this.btn_logout.TabIndex = 6;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lbl_loguser
            // 
            this.lbl_loguser.AutoSize = true;
            this.lbl_loguser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loguser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_loguser.Location = new System.Drawing.Point(216, 35);
            this.lbl_loguser.Name = "lbl_loguser";
            this.lbl_loguser.Size = new System.Drawing.Size(146, 36);
            this.lbl_loguser.TabIndex = 7;
            this.lbl_loguser.Text = "Welcome:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.lbl_loguser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 100);
            this.panel1.TabIndex = 8;
            // 
            // Frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(830, 527);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_adduseradmin);
            this.Controls.Add(this.btn_payment);
            this.Controls.Add(this.btn_Studnet);
            this.Controls.Add(this.btn_Attendance);
            this.MaximumSize = new System.Drawing.Size(848, 574);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(848, 574);
            this.Name = "Frm_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Frm_Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Attendance;
        private System.Windows.Forms.Button btn_Studnet;
        private System.Windows.Forms.Button btn_adduseradmin;
        private System.Windows.Forms.Button btn_payment;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lbl_loguser;
        private System.Windows.Forms.Panel panel1;
    }
}