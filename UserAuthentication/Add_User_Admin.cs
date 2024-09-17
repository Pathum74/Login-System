using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserAuthentication
{
    public partial class frm_Add_User_Admin : Form
    {
        public frm_Add_User_Admin()
        {
            InitializeComponent();
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_Add_User_Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uaDBDataSet.tbllog' table. You can move, or remove it, as needed.
            this.tbllogTableAdapter.Fill(this.uaDBDataSet.tbllog);
            Edit(false);
        }

        private void Edit(bool value)
        {
            txt_username.Enabled= value;
            txt_password.Enabled= value;
            cb_role.Enabled= value;
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                uaDBDataSet.tbllog.AddtbllogRow(uaDBDataSet.tbllog.NewtbllogRow());
                tbllogBindingSource.MoveLast();
                txt_username.Focus();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message,"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                uaDBDataSet.tbllog.RejectChanges();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Edit(true);
            txt_username.Focus();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                tbllogBindingSource.EndEdit();
                tbllogTableAdapter.Update(uaDBDataSet.tbllog);
                dgv_adminuser.Refresh();
                txt_username.Focus();
                MessageBox.Show("Your data has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                uaDBDataSet.tbllog.RejectChanges();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                tbllogBindingSource.RemoveCurrent();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Edit(false);
            tbllogBindingSource.ResetBindings(false);
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_adminuser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
