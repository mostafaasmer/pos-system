using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace pos_system.BL
{
    class POS_Login
    {
        public DataTable Login(string id , string pwd)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@username", SqlDbType.VarChar, 50);
            param[0].Value = id;

            param[1] = new SqlParameter("@password", SqlDbType.VarChar, 50);
            param[1].Value = pwd;


            DAL.Open();
            DataTable dt = new DataTable() ;
            dt = DAL.SelectData("Log_IN", param);
            DAL.Close();
            return dt;

        }
    }
}
