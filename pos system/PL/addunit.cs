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
    public partial class addunit : Form
    {
        public string cate_name = "";

        public addunit()
        {
            InitializeComponent();
            label5.Hide();
            unitno.Hide();
            label4.Hide();
            mainunit_no.Hide();
            label8.Hide();
            main_unit_smaller.Hide();
        }
        
        BL.category_manage cm = new BL.category_manage(); 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void largerRB_CheckedChanged(object sender, EventArgs e)
        {
            label5.Hide();
            unitno.Hide();
            label4.Hide();
            mainunit_no.Hide();
            label8.Show();
            main_unit_smaller.Show();
        }

        private void smallerRB_CheckedChanged(object sender, EventArgs e)
        {
            label5.Show();
            unitno.Show();
            label4.Show();
            mainunit_no.Show();
            label8.Hide();
            main_unit_smaller.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double percentage = 0.0;
            if (largerRB.Checked)
            { percentage = double.Parse(main_unit_smaller.Text); }
            else if(smallerRB.Checked)
            { percentage = double.Parse(unitno.Text)/ double.Parse(mainunit_no.Text); }
            //cm.add_unit(cate_name, unit_name.Text, percentage.ToString(), sell_price_for_each.Text);
            
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
