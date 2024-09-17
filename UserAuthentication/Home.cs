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
    public partial class Frm_Home : Form
    {
        public Frm_Home(string log)
        {
            InitializeComponent();
            lbl_loguser.Text = log;
        }

        private void btn_adduseradmin_Click(object sender, EventArgs e)
        {
            frm_Add_User_Admin fau=new frm_Add_User_Admin();
            fau.ShowDialog();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Frm_login fl=new Frm_login();
            fl.Show();
            this.Hide();
        }

        private void Frm_Home_Load(object sender, EventArgs e)
        {
            if (ulog.type == "A")
            {
                btn_adduseradmin.Visible = true;
                btn_Attendance.Visible = true;
                btn_payment.Visible = true;
                btn_Studnet.Visible = true;
            }
            else if (ulog.type == "U")
            {
                btn_adduseradmin.Visible = false;
                btn_Attendance.Visible = true;
                btn_payment.Visible = false;            
                btn_Studnet.Visible = true;
            }
        }
    }
}
