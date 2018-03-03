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
    public partial class edite_category : Form
    {
        BL.category_manage cm = new BL.category_manage();
        public void intial_quantity()
        {
           
            for(int i=0;i<category_dgv.Rows.Count-1;i++)
            {
                double all = 0;
                DataTable dd = cm.get_intial_quantity(category_dgv.Rows[i].Cells[1].Value.ToString());
                foreach (DataColumn col in dd.Columns)
                {
                    foreach (DataRow row in dd.Rows)
                    {
                       if(row[col.ColumnName] != "")
                       all += double.Parse(row[col.ColumnName].ToString());
                    }
                }
                this.category_dgv.Rows[i].Cells[7].Value = all;
            }
        }
        public edite_category()
        {
            InitializeComponent();
            this.category_dgv.DataSource = cm.get_all_cate();
           
            category_dgv.Columns[0].HeaderText = "رقم الصنف";
            category_dgv.Columns[1].HeaderText = "اسم الصنف";
            category_dgv.Columns[2].HeaderText = "سعر البيع";
            category_dgv.Columns[3].HeaderText = "التصنيف";
            category_dgv.Columns[4].HeaderText = "باركود";
            category_dgv.Columns[5].HeaderText = "الكود";
            category_dgv.Columns[6].HeaderText = "الوحده";
            category_dgv.Columns[7].HeaderText = "الكميه المتاحه";
            intial_quantity();
            category_dgv.ReadOnly = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PL.Add_cat w = new PL.Add_cat();
            w.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void search_tx_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cm.search_cate(search_tx.Text);
            this.category_dgv.DataSource = dt;
            intial_quantity();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cm.search_cate("");
            this.category_dgv.DataSource = dt;
            intial_quantity();
        }

        private void delete_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("هل انت متأكد","حذف",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Exclamation)==DialogResult.Yes)
            {
                cm.delete_cate(this.category_dgv.CurrentRow.Cells[1].Value.ToString());
                this.category_dgv.DataSource = cm.get_all_cate();
                intial_quantity();
            }

        }

        private void update_Click(object sender, EventArgs e)
        {
            Add_cat w = new Add_cat();
            DataTable dd= cm.get_full_cate(this.category_dgv.CurrentRow.Cells[1].Value.ToString());
            w.check = "edite";
            w.cate_name.Text = dd.Rows[0].ItemArray[1].ToString();
            w.cate_name.ReadOnly=true;
            w.description.Text= dd.Rows[0].ItemArray[2].ToString();
            w.sell_price.Text = dd.Rows[0].ItemArray[3].ToString();
            w.discount.Text= dd.Rows[0].ItemArray[4].ToString();
            w.less_price.Text= dd.Rows[0].ItemArray[5].ToString();
            w.classification.Text= dd.Rows[0].ItemArray[6].ToString();
            w.barcode.Text = dd.Rows[0].ItemArray[7].ToString();
            w.cate_code.Text= dd.Rows[0].ItemArray[8].ToString();
            w.another_code.Text= dd.Rows[0].ItemArray[9].ToString();
            w.less_quantity.Text = dd.Rows[0].ItemArray[10].ToString();
            w.unit.Text = dd.Rows[0].ItemArray[15].ToString();
            if (dd.Rows[0].ItemArray[12].ToString().Contains("1"))
                w.checkBox3.Checked = true;
            if (dd.Rows[0].ItemArray[13].ToString().Contains("1"))
                w.checkBox1.Checked = true;
            if (dd.Rows[0].ItemArray[14].ToString().Contains("1"))
                w.checkBox2.Checked = true;
            w.cate_unite.DataSource = cm.get_cate_unit(this.category_dgv.CurrentRow.Cells[1].Value.ToString());
            
            w.cate_warehouses.DataSource = cm.get_ware_quant(this.category_dgv.CurrentRow.Cells[1].Value.ToString());
            if (w.cate_warehouses.Rows.Count < 0)
            {
                w.cate_warehouses.Columns.RemoveAt(1);
                w.cate_warehouses.Columns.RemoveAt(2);
            }
            /* byte[] image = (byte[])cm.get_cate_image(this.category_dgv.CurrentRow.Cells[1].Value.ToString()).Rows[0][0];
             MemoryStream ms = new MemoryStream(image);
             w.cat_image.Image = Image.FromStream(ms);*/
            w.save.Text = "تعديل";
            w.save_new.Visible = false;
            w.ShowDialog();
           

             



        }
    }
}
