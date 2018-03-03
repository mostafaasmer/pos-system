using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pos_system.PL
{
    public partial class login_form : Form
    {
        BL.POS_Login log = new BL.POS_Login();
        public login_form()
        {
            InitializeComponent();
            //intializ listbox
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DAL.intializ_userslist(users_list);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cancel_login_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = log.Login(users_list.GetItemText(users_list.SelectedItem), pwd_txt.Text);
            if (dt.Rows.Count > 0)
            {
                main_window.get_mfrm.Show();
                this.Hide();
               // this.Close();
                MessageBox.Show("login done");                
            }
            else
            { MessageBox.Show("login faild"); }
        }

        private void users_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void login_form_Load(object sender, EventArgs e)
        {

        }
    }
}
