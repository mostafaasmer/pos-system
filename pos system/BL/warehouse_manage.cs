using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace pos_system.BL
{
    class warehouse_manage
    {
        public void add_warehouse(string warehouse_name)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@warehouse_name", SqlDbType.VarChar, 50);
            param[0].Value = warehouse_name;

            dal.ExecuteCommand("add_warehouse", param);
            dal.Close();

        }

        public void update_warehouse(string warehouse_name)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@warehouse_name", SqlDbType.VarChar, 50);
            param[0].Value = warehouse_name;

            dal.ExecuteCommand("update_warehouse", param);
            dal.Close();

        }

        public void delete_warehouse(string warehouse_name)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@warehouse_name", SqlDbType.VarChar, 50);
            param[0].Value = warehouse_name;

            dal.ExecuteCommand("delete_warehouse", param);
            dal.Close();

        }

    }
}
