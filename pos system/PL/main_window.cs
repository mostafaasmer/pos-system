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
    public partial class main_window : Form
    {
        static private main_window mfrm ;
        static void mfrm_close(object sender, FormClosedEventArgs e)
        {
            mfrm = null;
        }
        public static main_window get_mfrm
        {
            get
            {
                if(mfrm==null)
                {
                    mfrm = new main_window();
                    mfrm.FormClosed += new FormClosedEventHandler(mfrm_close);
                }
                return mfrm;

            }
        } 
        public main_window()
        {
            InitializeComponent();
            if (mfrm == null)
                mfrm = this;
        }

        private void الفروعToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void التحويلاتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void add_cat_btn_Click(object sender, EventArgs e)
        {
            Add_cat adc = new Add_cat();
            adc.ShowDialog();
        }

        private void main_window_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PL.edite_category w = new PL.edite_category();
            w.ShowDialog();
        }
    }
}
