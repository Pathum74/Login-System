using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UserAuthentication
{
    public partial class Frm_login : Form
    {
        SqlConnection con=new SqlConnection(Properties.Settings.Default.uaDBConnectionString);
        SqlDataAdapter da;
        SqlCommand cmd;
        public Frm_login()
        {
            InitializeComponent();
        }

        private void Frm_login_Load(object sender, EventArgs e)
        {

        }

        string log;
        private void btn_login_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd=new SqlCommand("SELECT * FROM tbllog WHERE Username='"+txt_UserName.Text+"' and Password='"+txt_Password.Text+"'",con);
            da=new SqlDataAdapter(cmd);
            DataSet ds=new DataSet();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i == 1)
            {
                SqlDataReader dr=cmd.ExecuteReader();
                dr.Read();
                if (dr[3].ToString()=="Admin")
                {
                    ulog.type = "A";
                }
                else if (dr[3].ToString()=="User")
                {
                    ulog.type = "U";
                }
                log = "Welcome:" + txt_UserName.Text;
                this.Hide();
                Frm_Home fh=new Frm_Home(log);
                fh.Show();
                
            }
            else
            {
                MessageBox.Show("Please check your User name or Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
