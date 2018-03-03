using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace pos_system.BL
{
    class bank_manage
    {

        public void add_bank(string bank_name, string balance)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@bank_name", SqlDbType.VarChar, 50);
            param[0].Value = bank_name;

            param[1] = new SqlParameter("@balance", SqlDbType.VarChar, 30);
            param[1].Value = balance;

            dal.ExecuteCommand("add_bank", param);
            dal.Close();

        }

        public void update_bank(string bank_name, string balance)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@bank_name", SqlDbType.VarChar, 50);
            param[0].Value = bank_name;

            param[1] = new SqlParameter("@balance", SqlDbType.VarChar, 30);
            param[1].Value = balance;

            dal.ExecuteCommand("update_bank", param);
            dal.Close();

        }

        public void delete_bank(string bank_name)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@bank_name", SqlDbType.VarChar, 50);
            param[0].Value = bank_name;

            dal.ExecuteCommand("delete_bank", param);
            dal.Close();

        }
    }
}
