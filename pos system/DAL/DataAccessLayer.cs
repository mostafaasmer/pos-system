using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace pos_system.DAL
{
    class DataAccessLayer
    {
        SqlConnection sqlconnection;

        public DataAccessLayer()
        {
            sqlconnection = new SqlConnection("server=localhost;" +
                                       "Trusted_Connection=yes;" +
                                       "database=POS_DB; " +
                                       "connection timeout=30");
        }

        public void Open()
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();
            }
        }

        public void Close()
        {
            if (sqlconnection.State != ConnectionState.Closed)
            {
                sqlconnection.Close();
            }
        }

        public DataTable SelectData(string stored_procedure, SqlParameter[] param )//read data from db
        {
            //creat cmd
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.CommandType = CommandType.StoredProcedure;
            sqlcommand.CommandText = stored_procedure;// "Log_IN";
            sqlcommand.Connection = sqlconnection;

            //fill cmd paramters
            if (param!=null)
            {
               sqlcommand.Parameters.AddRange(param);               
            }

            //data adapter
            SqlDataAdapter da = new SqlDataAdapter(sqlcommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //excute query //insert delete update .. 
        public void ExecuteCommand (string stored_procedure, SqlParameter[] param)//read data from db
        {
            //creat cmd
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.CommandType = CommandType.StoredProcedure;
            sqlcommand.CommandText = stored_procedure;
            sqlcommand.Connection = sqlconnection;


            //fill cmd paramters
            if (param != null)
            {
                sqlcommand.Parameters.AddRange(param);
            }

            sqlcommand.ExecuteNonQuery();//excute query
        }

        public void intializ_userslist(ListBox users_list )
        {
            
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(
            "SELECT userid FROM users;", sqlconnection);
            adapter.Fill(ds);
            users_list.DataSource = ds.Tables[0];
            users_list.DisplayMember = "userid";
        }

        



    }
}
