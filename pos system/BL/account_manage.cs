using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace pos_system.BL
{
    class account_manage
    {
        public void add_account(string acc_name, string acc_type, string debit, string creditor, string acc_date
           , string email, string mobile_no, string address, string acc_code, string acc_calss, string notes)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[11];
            
            param[0] = new SqlParameter("@acc_name", SqlDbType.VarChar, 50);
            param[0].Value = acc_name;

            param[1] = new SqlParameter("@acc_type", SqlDbType.VarChar,30);
            param[1].Value = acc_type;

            param[2] = new SqlParameter("@debit", SqlDbType.VarChar, 30);
            param[2].Value = debit;

            param[3] = new SqlParameter("@creditor", SqlDbType.VarChar, 30);
            param[3].Value = creditor;

            param[4] = new SqlParameter("@acc_date", SqlDbType.Date);
            param[4].Value = acc_date;

            param[5] = new SqlParameter("@email", SqlDbType.Text);
            param[5].Value = email;

            param[6] = new SqlParameter("@mobile_no", SqlDbType.VarChar,20);
            param[6].Value = mobile_no;

            param[7] = new SqlParameter("@address", SqlDbType.Text);
            param[7].Value = address;

            param[8] = new SqlParameter("@acc_code", SqlDbType.Text);
            param[8].Value = acc_code;

            param[9] = new SqlParameter("@acc_calss", SqlDbType.Text);
            param[9].Value = acc_calss;

            param[10] = new SqlParameter("@notes", SqlDbType.NChar, 10);
            param[10].Value = notes;

            dal.ExecuteCommand("add_account", param);
            dal.Close();

        }

        public void edit_account(string acc_name, string acc_type, string debit, string creditor, string acc_date
           , string email, string mobile_no, string address, string acc_code, string acc_calss, string notes)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[11];

            param[0] = new SqlParameter("@acc_name", SqlDbType.VarChar, 50);
            param[0].Value = acc_name;

            param[1] = new SqlParameter("@acc_type", SqlDbType.VarChar, 30);
            param[1].Value = acc_type;

            param[2] = new SqlParameter("@debit", SqlDbType.VarChar, 30);
            param[2].Value = debit;

            param[3] = new SqlParameter("@creditor", SqlDbType.VarChar, 30);
            param[3].Value = creditor;

            param[4] = new SqlParameter("@acc_date", SqlDbType.Date);
            param[4].Value = acc_date;

            param[5] = new SqlParameter("@email", SqlDbType.Text);
            param[5].Value = email;

            param[6] = new SqlParameter("@mobile_no", SqlDbType.VarChar, 20);
            param[6].Value = mobile_no;

            param[7] = new SqlParameter("@address", SqlDbType.Text);
            param[7].Value = address;

            param[8] = new SqlParameter("@acc_code", SqlDbType.Text);
            param[8].Value = acc_code;

            param[9] = new SqlParameter("@acc_calss", SqlDbType.Text);
            param[9].Value = acc_calss;

            param[10] = new SqlParameter("@notes", SqlDbType.NChar, 10);
            param[10].Value = notes;

            dal.ExecuteCommand("edit_account", param);
            dal.Close();
        }
        public void delete_account(string acc_name)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@acc_name", SqlDbType.VarChar, 50);
            param[0].Value = acc_name;

            dal.ExecuteCommand("delete_account", param);
            dal.Close();

        }



    }
}
