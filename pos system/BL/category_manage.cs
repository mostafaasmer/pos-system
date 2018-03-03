using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace pos_system.BL
{
    class category_manage
    {
        public DataTable get_warehousesnames()
        {

            DataTable dt = new DataTable();
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dt = dal.SelectData("get_warehousesnames", null);
            dal.Close();
            return dt;
        }

        public void add_category(string cate_name, string cate_description, string sell_price , string discount, string less_price
           , string classification, string barcode, string cate_code, string another_cate_code , string less_quantity , byte [] cate_image,
            string no_quantity,string fast_cate,string unused,string unit)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[15];

            param[0] = new SqlParameter("@cate_name", SqlDbType.VarChar, 50);
            param[0].Value = cate_name;

            param[1] = new SqlParameter("@cate_description", SqlDbType.Text);
            param[1].Value = cate_description;

            param[2] = new SqlParameter("@sell_price", SqlDbType.VarChar, 30);
            param[2].Value = sell_price;

            param[3] = new SqlParameter("@discount", SqlDbType.NChar,10);
            param[3].Value = discount;

            param[4] = new SqlParameter("@less_price", SqlDbType.VarChar, 30);
            param[4].Value = less_price;

            param[5] = new SqlParameter("@classification", SqlDbType.VarChar, 30);
            param[5].Value = classification;

            param[6] = new SqlParameter("@barcode", SqlDbType.Text);
            param[6].Value = barcode;

            param[7] = new SqlParameter("@cate_code", SqlDbType.Text);
            param[7].Value = cate_code;

            param[8] = new SqlParameter("@another_cate_code", SqlDbType.Text);
            param[8].Value = another_cate_code;

            param[9] = new SqlParameter("@less_quantity", SqlDbType.NChar,10);
            param[9].Value = less_quantity;

            param[10] = new SqlParameter("@cate_image", SqlDbType.Image);
            param[10].Value = cate_image;

            param[11] = new SqlParameter("@no_quantity", SqlDbType.NChar, 10);
            param[11].Value = no_quantity;

            param[12] = new SqlParameter("@fast_cate", SqlDbType.NChar, 10);
            param[12].Value = fast_cate;

            param[13] = new SqlParameter("@unused", SqlDbType.NChar, 10);
            param[13].Value = unused;

            param[14] = new SqlParameter("@unit", SqlDbType.NChar, 10);
            param[14].Value = unit;

            dal.ExecuteCommand("add_category", param);
            dal.Close();

        }

        public void update_category(string cate_name, string cate_description, string sell_price, string discount, string less_price
           , string classification, string barcode, string cate_code, string another_cate_code, string less_quantity, byte[] cate_image,
            string no_quantity, string fast_cate, string unused, string unit)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[15];

            param[0] = new SqlParameter("@cate_name", SqlDbType.VarChar, 50);
            param[0].Value = cate_name;

            param[1] = new SqlParameter("@cate_description", SqlDbType.Text);
            param[1].Value = cate_description;

            param[2] = new SqlParameter("@sell_price", SqlDbType.VarChar, 30);
            param[2].Value = sell_price;

            param[3] = new SqlParameter("@discount", SqlDbType.NChar, 10);
            param[3].Value = discount;

            param[4] = new SqlParameter("@less_price", SqlDbType.VarChar, 30);
            param[4].Value = less_price;

            param[5] = new SqlParameter("@classification", SqlDbType.VarChar, 30);
            param[5].Value = classification;

            param[6] = new SqlParameter("@barcode", SqlDbType.Text);
            param[6].Value = barcode;

            param[7] = new SqlParameter("@cate_code", SqlDbType.Text);
            param[7].Value = cate_code;

            param[8] = new SqlParameter("@another_cate_code", SqlDbType.Text);
            param[8].Value = another_cate_code;

            param[9] = new SqlParameter("@less_quantity", SqlDbType.NChar, 10);
            param[9].Value = less_quantity;

            param[10] = new SqlParameter("@cate_image", SqlDbType.Image, 5000);
            param[10].Value = cate_image;

            param[11] = new SqlParameter("@no_quantity", SqlDbType.NChar, 10);
            param[11].Value = no_quantity;

            param[12] = new SqlParameter("@fast_cate", SqlDbType.NChar, 10);
            param[12].Value = fast_cate;

            param[13] = new SqlParameter("@unused", SqlDbType.NChar, 10);
            param[13].Value = unused;

            param[14] = new SqlParameter("@unit", SqlDbType.NChar, 10);
            param[14].Value = unit;

            dal.ExecuteCommand("update_category", param);
            dal.Close();
        }

        public DataTable verifycate(string cate)
        {

            DataTable dt = new DataTable();
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter [] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = cate;
            dt = dal.SelectData("verifycate", param);
            dal.Close();
            return dt;
        }

        public DataTable verifyunit(string cate , string unit)
        {

            DataTable dt = new DataTable();
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@cate", SqlDbType.VarChar, 50);
            param[0].Value = cate;

            param[1] = new SqlParameter("@unite", SqlDbType.VarChar, 50);
            param[1].Value = unit;

            dt = dal.SelectData("verifyunit", param);
            dal.Close();
            return dt;
        }

        public void add_warehouse_cate(string warehouse , string cate_name, string quantity, string buy_price)
        {

            
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@warehouse", SqlDbType.VarChar, 50);
            param[0].Value = warehouse;

            param[1] = new SqlParameter("@cate_name", SqlDbType.VarChar, 50);
            param[1].Value = cate_name;

            param[2] = new SqlParameter("@quantity", SqlDbType.VarChar, 50);
            param[2].Value = quantity;

            param[3] = new SqlParameter("@buy_price", SqlDbType.VarChar, 50);
            param[3].Value = buy_price;
            dal.Open();
            dal.ExecuteCommand("add_warehouse_cate", param);
            dal.Close();
        }


        public void add_unit(string cate_name, string unit_name, string unit_percentage, string sellprice)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@cate_name", SqlDbType.VarChar, 50);
            param[0].Value = cate_name;

            param[1] = new SqlParameter("@unit_name", SqlDbType.VarChar, 50);
            param[1].Value = unit_name;

            param[2] = new SqlParameter("@unit_percentage", SqlDbType.NChar,10);
            param[2].Value = unit_percentage;

            param[3] = new SqlParameter("@sellprice", SqlDbType.VarChar,30);
            param[3].Value = sellprice;

            dal.ExecuteCommand("add_unit", param);
            dal.Close();
        }

        public void delete_cate(string cate_name)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@cate_name", SqlDbType.VarChar, 50);
            param[0].Value = cate_name;

            dal.ExecuteCommand("delete_cate", param);
            dal.Close();
        }

        public DataTable get_all_cate()
        {

            DataTable dt = new DataTable();
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dt = dal.SelectData("get_all_cate", null);
            dal.Close();
            return dt;
        }

        public DataTable get_intial_quantity( string cate_name)
        {

            DataTable dt = new DataTable();
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@cate_name", SqlDbType.VarChar, 50);
            param[0].Value = cate_name;
            dt = dal.SelectData("get_intial_quantity", param);
            dal.Close();
            return dt;
        }

        public DataTable search_cate(string cate_name)
        {

            DataTable dt = new DataTable();
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@cate_name", SqlDbType.VarChar, 50);
            param[0].Value = cate_name;
            dt = dal.SelectData("search_cate", param);
            dal.Close();
            return dt;
        }

        public DataTable get_full_cate(string cate_name)
        {

            DataTable dt = new DataTable();
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@cate_name", SqlDbType.VarChar, 50);
            param[0].Value = cate_name;
            dt = dal.SelectData("get_full_cate", param);
            dal.Close();
            return dt;
        }

        public DataTable get_cate_unit(string cate_name)
        {

            DataTable dt = new DataTable();
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@cate_name", SqlDbType.VarChar, 50);
            param[0].Value = cate_name;
            dt = dal.SelectData("get_cate_unit", param);
            dal.Close();
            return dt;
        }

        public DataTable get_ware_quant(string cate_name)
        {

            DataTable dt = new DataTable();
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@cate_name", SqlDbType.VarChar, 50);
            param[0].Value = cate_name;
            dt = dal.SelectData("get_ware_quant", param);
            dal.Close();
            return dt;
        }

        public DataTable get_cate_image(string cate_name)
        {

            DataTable dt = new DataTable();
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@cate_name", SqlDbType.VarChar, 50);
            param[0].Value = cate_name;
            dt = dal.SelectData("get_cate_image", param);
            dal.Close();
            return dt;
        }

    }

    
   
}
