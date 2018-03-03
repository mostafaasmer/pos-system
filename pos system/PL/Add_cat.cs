using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pos_system.PL
{
    public partial class Add_cat : Form
    {
      

        double percentage = 0.0;
        string check_box1 = "";
        string check_box2 = "";
        string check_box3 = "";
       public string check = "add";
        BL.category_manage cm = new BL.category_manage();
       
        public void passing_data ()
        {
            MemoryStream ms = new MemoryStream();
            byte[] bytimage = ms.ToArray();

            cm.add_category(cate_name.Text, description.Text, sell_price.Text, discount.Text, less_price.Text, classification.Text, barcode.Text, cate_code.Text,
                another_code.Text,less_quantity.Text, bytimage ,check_box1,check_box2,check_box3,unit.Text);
        }
        public void reset_warehouse_dgv()
        {

        }


        public Add_cat ()
        {
            InitializeComponent();

            label17.Hide();
            unitno.Hide();
            label21.Hide();
            mainunit_no.Hide();
            label16.Hide();
            main_unit_smaller.Hide();
            

            this.cate_warehouses.DataSource = cm.get_warehousesnames();
            cate_warehouses.Columns[0].HeaderText = "المخزن";
            if (check == "add")
            {
                cate_warehouses.Columns.Add("Column", "الكميه");
                cate_warehouses.Columns.Add("Column", "اقل سعر شراء");
            }
            cate_warehouses.Columns[0].ReadOnly = true;
            cate_unite.Columns.Add("Column", "الوحده");
            cate_unite.Columns.Add("Column", "نسبه الوحده");
            cate_unite.Columns.Add("Column", "سعر البيع");
            cate_unite.ReadOnly = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            check_box2 = "1";
        }

        private void Add_cat_Load(object sender, EventArgs e)
        {

        }

        private void add_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور| *.jpg; *.png; *.gif; *.BMP";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                cat_image.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cate_warehouses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (check == "add")
            {
                DataTable dtt = new DataTable();
                dtt = cm.verifycate(cate_name.Text);
                if (dtt.Rows.Count > 0)
                {
                    MessageBox.Show("هذا الاسم موجود مسبقا");
                    cate_name.Text = "";
                }
                else
                {
                    DataTable dt = new DataTable();

                    passing_data();

                    for (int i = 0; i < cate_unite.Rows.Count - 1; i++)
                    {
                        dt = cm.verifyunit(cate_name.Text, cate_unite.Rows[i].Cells[0].Value.ToString());
                        if (dt.Rows.Count == 0)
                        {
                            cm.add_unit(cate_name.Text, cate_unite.Rows[i].Cells[0].Value.ToString(), cate_unite.Rows[i].Cells[1].Value.ToString(), cate_unite.Rows[i].Cells[2].Value.ToString());
                        }
                    }
                    for (int i = 0; i < cate_warehouses.Rows.Count; i++)
                    {
                        if (cate_warehouses.Rows[i].Cells[1].Value == null)
                        { cate_warehouses.Rows[i].Cells[1].Value = ""; }
                        if (cate_warehouses.Rows[i].Cells[0].Value == null)
                        { cate_warehouses.Rows[i].Cells[0].Value = ""; }
                        cm.add_warehouse_cate(cate_warehouses.Rows[i].Cells[2].Value.ToString(), cate_name.Text, cate_warehouses.Rows[i].Cells[1].Value.ToString(), cate_warehouses.Rows[i].Cells[0].Value.ToString());
                    }

                }
            }
            else {
                MemoryStream ms = new MemoryStream();
                byte[] bytimage = ms.ToArray();
               cm.update_category(cate_name.Text, description.Text, sell_price.Text, discount.Text, less_price.Text, classification.Text, barcode.Text, cate_code.Text,
                another_code.Text, less_quantity.Text, bytimage, check_box1, check_box2, check_box3, unit.Text);

            }
            
        }

        private void save_new_Click(object sender, EventArgs e)
        {             Add_cat ad = new Add_cat();

            button6_Click(sender, e);
            /* Close();
             ad.ShowDialog();*/
            cate_code.Text = "";
            cate_name.Text="";
            classification.Text = "";
            less_price.Text = "";
            less_quantity.Text = "";
            sell_price.Text = "";
            discount.Text = "";
            barcode.Text = "";
            another_code.Text = "";
            mainunit_no.Text = "";
            main_unit_smaller.Text = "";
            unit.Text = "";
            unitno.Text = "";
            unit_name.Text = "";
            main_unit_smaller.Text = "";
            mainunit_no.Text = "";
            description.Text = "";
            sell_price_for_each.Text = "";
            if (cat_image.Image != null)
            {
                cat_image.Image.Dispose();
                cat_image.Image = null;
            }

            for (int i = 0; i < cate_warehouses.Rows.Count; i++)
            {
                cate_warehouses.Rows[i].Cells[1].Value = "";
                cate_warehouses.Rows[i].Cells[0].Value="";
            }
            cate_unite.Rows.Clear();
            cate_unite.Refresh();
        }

        private void cate_name_Validated(object sender, EventArgs e)
        {
            if (check == "add")
            {
                DataTable dt = new DataTable();
                dt = cm.verifycate(cate_name.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("هذا الاسم موجود مسبقا");
                    cate_name.Text = "";
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (largerRB.Checked)
            { percentage = double.Parse(main_unit_smaller.Text); }
            else if (smallerRB.Checked)
            { percentage = double.Parse(unitno.Text) / double.Parse(mainunit_no.Text); }
            cate_unite.Rows.Add(unit_name.Text, percentage.ToString(), sell_price_for_each.Text);
        }

        private void largerRB_CheckedChanged(object sender, EventArgs e)
        {
            label17.Hide();
            unitno.Hide();
            label21.Hide();
            mainunit_no.Hide();
            label16.Show();
            main_unit_smaller.Show();
        }

        private void smallerRB_CheckedChanged(object sender, EventArgs e)
        {
            label17.Show();
            unitno.Show();
            label21.Show();
            mainunit_no.Show();
            label16.Hide();
            main_unit_smaller.Hide();
        }

        private void cate_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            cate_unite.Rows.RemoveAt(cate_unite.CurrentCell.RowIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            check_box1 = "1";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            check_box3 = "1";
        }

        private void sell_price_for_each_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void sell_price_for_each_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void mainunit_no_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainunit_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void main_unit_smaller_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void unitno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void less_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void sell_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void less_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
