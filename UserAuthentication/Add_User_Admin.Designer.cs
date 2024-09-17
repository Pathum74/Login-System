namespace UserAuthentication
{
    partial class frm_Add_User_Admin
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
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.tbllogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uaDBDataSet = new UserAuthentication.uaDBDataSet();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.tbllogBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cb_role = new System.Windows.Forms.ComboBox();
            this.tbllogBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_adminuser = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbllogTableAdapter = new UserAuthentication.uaDBDataSetTableAdapters.tbllogTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tbllogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllogBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllogBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_adminuser)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_new
            // 
            this.btn_new.ForeColor = System.Drawing.Color.Green;
            this.btn_new.Location = new System.Drawing.Point(46, 233);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(305, 38);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.ForeColor = System.Drawing.Color.Green;
            this.btn_edit.Location = new System.Drawing.Point(46, 292);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(305, 38);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.ForeColor = System.Drawing.Color.Green;
            this.btn_save.Location = new System.Drawing.Point(46, 350);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(305, 38);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.ForeColor = System.Drawing.Color.Green;
            this.btn_delete.Location = new System.Drawing.Point(46, 406);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(305, 38);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.ForeColor = System.Drawing.Color.Green;
            this.btn_cancel.Location = new System.Drawing.Point(46, 462);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(305, 38);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_username
            // 
            this.txt_username.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbllogBindingSource, "Username", true));
            this.txt_username.Location = new System.Drawing.Point(137, 111);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(214, 22);
            this.txt_username.TabIndex = 5;
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            // 
            // tbllogBindingSource
            // 
            this.tbllogBindingSource.DataMember = "tbllog";
            this.tbllogBindingSource.DataSource = this.uaDBDataSet;
            // 
            // uaDBDataSet
            // 
            this.uaDBDataSet.DataSetName = "uaDBDataSet";
            this.uaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_password
            // 
            this.txt_password.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbllogBindingSource, "Password", true));
            this.txt_password.Location = new System.Drawing.Point(137, 141);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(214, 22);
            this.txt_password.TabIndex = 6;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // tbllogBindingSource1
            // 
            this.tbllogBindingSource1.DataMember = "tbllog";
            this.tbllogBindingSource1.DataSource = this.uaDBDataSet;
            // 
            // cb_role
            // 
            this.cb_role.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.tbllogBindingSource, "ROLE", true));
            this.cb_role.FormattingEnabled = true;
            this.cb_role.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cb_role.Location = new System.Drawing.Point(137, 172);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(214, 24);
            this.cb_role.TabIndex = 7;
            this.cb_role.SelectedIndexChanged += new System.EventHandler(this.cb_role_SelectedIndexChanged);
            // 
            // tbllogBindingSource2
            // 
            this.tbllogBindingSource2.DataMember = "tbllog";
            this.tbllogBindingSource2.DataSource = this.uaDBDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(43, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(52, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(83, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Role:";
            // 
            // dgv_adminuser
            // 
            this.dgv_adminuser.AutoGenerateColumns = false;
            this.dgv_adminuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_adminuser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.rOLEDataGridViewTextBoxColumn});
            this.dgv_adminuser.DataSource = this.tbllogBindingSource;
            this.dgv_adminuser.Location = new System.Drawing.Point(401, 111);
            this.dgv_adminuser.Name = "dgv_adminuser";
            this.dgv_adminuser.ReadOnly = true;
            this.dgv_adminuser.RowHeadersWidth = 51;
            this.dgv_adminuser.RowTemplate.Height = 24;
            this.dgv_adminuser.Size = new System.Drawing.Size(394, 389);
            this.dgv_adminuser.TabIndex = 11;
            this.dgv_adminuser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_adminuser_CellContentClick);
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "User Name";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // rOLEDataGridViewTextBoxColumn
            // 
            this.rOLEDataGridViewTextBoxColumn.DataPropertyName = "ROLE";
            this.rOLEDataGridViewTextBoxColumn.HeaderText = "ROLE";
            this.rOLEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rOLEDataGridViewTextBoxColumn.Name = "rOLEDataGridViewTextBoxColumn";
            this.rOLEDataGridViewTextBoxColumn.ReadOnly = true;
            this.rOLEDataGridViewTextBoxColumn.Width = 125;
            // 
            // tbllogTableAdapter
            // 
            this.tbllogTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 91);
            this.panel1.TabIndex = 12;
            // 
            // frm_Add_User_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(830, 527);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_adminuser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_role);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_new);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(848, 574);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(848, 574);
            this.Name = "frm_Add_User_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add User Admin";
            this.Load += new System.EventHandler(this.frm_Add_User_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbllogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllogBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllogBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_adminuser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.ComboBox cb_role;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_adminuser;
        private uaDBDataSet uaDBDataSet;
        private System.Windows.Forms.BindingSource tbllogBindingSource;
        private uaDBDataSetTableAdapters.tbllogTableAdapter tbllogTableAdapter;
        private System.Windows.Forms.BindingSource tbllogBindingSource1;
        private System.Windows.Forms.BindingSource tbllogBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
    }
}