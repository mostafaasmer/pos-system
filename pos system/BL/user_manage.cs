using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace pos_system.BL
{
    class user_manage
    {
        public DataTable add_user(string user_id, string password)
        {

            DataTable dt = new DataTable();
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@user_id", SqlDbType.VarChar, 50);
            param[0].Value = user_id;

            param[1] = new SqlParameter("@password", SqlDbType.VarChar, 50);
            param[1].Value = password;

            dt = dal.SelectData("add_user", param);
            dal.Close();
            return dt;
        }

        public DataTable update_user(string user_id, string password)
        {

            DataTable dt = new DataTable();
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@user_id", SqlDbType.VarChar, 50);
            param[0].Value = user_id;

            param[1] = new SqlParameter("@password", SqlDbType.VarChar, 50);
            param[1].Value = password;

            dt = dal.SelectData("update_user", param);
            dal.Close();
            return dt;
        }

        public DataTable add_permissions(string userid , string manag_prog, string back_up, string general_reports, string date_time, string pills_number, string show_sales_pills, string add_sales_pills, string del_sales_pills, string edite_sales_pills, string show_buy_pills, string add_buy_pills, string del_buy_pills, string edite_buy_pills, string show_inventory, string add_inventory, string del_inventory, string edite_inventory, string show_exchange, string add_exchange, string del_exchange, string edite_exchange, string show_Settlement, string add_Settlement, string del_Settlement, string edite_Settlement, string show_Expenses, string add_Expenses, string del_Expenses, string edite_Expenses, string show_Receipts, string add_Receipts, string del_Receipts, string edite_Receipts, string edite_sell_price, string add_discount, string follow_sell_pills, string Repayment_of_purchases, string sell_by_less_than_less_price, string show_benefits, string sell_less_buy, string rebayments_of_sales, string show_cate, string add_cate, string del_cate, string edite_cate, string cate_movement_report, string warehouse_goods_report, string warehouse_movement_report, string cate_cost, string sell_nonavailable_quantity, string print_barcode, string shohna_report, string show_accounts, string add_accounts, string del_accounts, string edite_accounts, string account_balance, string account_statement, string show_bank_movement, string expenses_analysis, string recipts_analysis, string show_installment_contract, string add_installment, string edite_installment, string del_installment, string pay_installment, string late_payed_installment)
        {

            DataTable dt = new DataTable();
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[68];

            param[0] = new SqlParameter("@userid", SqlDbType.NChar, 10);
            param[0].Value = userid;
            param[1] = new SqlParameter("@manag_prog", SqlDbType.NChar, 10);
            param[1].Value = manag_prog;
            param[2] = new SqlParameter("@back_up", SqlDbType.NChar, 10);
            param[2].Value = back_up;
            param[3] = new SqlParameter("@general_reports", SqlDbType.NChar, 10);
            param[3].Value = general_reports;
            param[4] = new SqlParameter("@date_time", SqlDbType.NChar, 10);
            param[4].Value = date_time;
            param[5] = new SqlParameter("@pills_number", SqlDbType.NChar, 10);
            param[5].Value = pills_number;
            param[6] = new SqlParameter("@show_sales_pills", SqlDbType.NChar, 10);
            param[6].Value = show_sales_pills;
            param[7] = new SqlParameter("@add_sales_pills", SqlDbType.NChar, 10);
            param[7].Value = add_sales_pills;
            param[8] = new SqlParameter("@del_sales_pills", SqlDbType.NChar, 10);
            param[8].Value = del_sales_pills;
            param[9] = new SqlParameter("@edite_sales_pills", SqlDbType.NChar, 10);
            param[9].Value = edite_sales_pills;
            param[10] = new SqlParameter("@show_buy_pills", SqlDbType.NChar, 10);
            param[10].Value = show_buy_pills;
            param[11] = new SqlParameter("@add_buy_pills", SqlDbType.NChar, 10);
            param[11].Value = add_buy_pills;
            param[12] = new SqlParameter("@del_buy_pills", SqlDbType.NChar, 10);
            param[12].Value = del_buy_pills;
            param[13] = new SqlParameter("@edite_buy_pills", SqlDbType.NChar, 10);
            param[13].Value = edite_buy_pills;
            param[14] = new SqlParameter("@show_inventory", SqlDbType.NChar, 10);
            param[14].Value = show_inventory;
            param[15] = new SqlParameter("@add_inventory", SqlDbType.NChar, 10);
            param[15].Value = add_inventory;
            param[16] = new SqlParameter("@del_inventory", SqlDbType.NChar, 10);
            param[16].Value = del_inventory;
            param[17] = new SqlParameter("@edite_inventory", SqlDbType.NChar, 10);
            param[17].Value = edite_inventory;
            param[18] = new SqlParameter("@show_exchange", SqlDbType.NChar, 10);
            param[18].Value = show_exchange;
            param[19] = new SqlParameter("@add_exchange", SqlDbType.NChar, 10);
            param[19].Value = add_exchange;
            param[20] = new SqlParameter("@del_exchange", SqlDbType.NChar, 10);
            param[20].Value = del_exchange;
            param[21] = new SqlParameter("@edite_exchange", SqlDbType.NChar, 10);
            param[21].Value = edite_exchange;
            param[22] = new SqlParameter("@show_Settlement", SqlDbType.NChar, 10);
            param[22].Value = show_Settlement;
            param[23] = new SqlParameter("@add_Settlement", SqlDbType.NChar, 10);
            param[23].Value = add_Settlement;
            param[24] = new SqlParameter("@del_Settlement", SqlDbType.NChar, 10);
            param[24].Value = del_Settlement;
            param[25] = new SqlParameter("@edite_Settlement", SqlDbType.NChar, 10);
            param[25].Value = edite_Settlement;
            param[26] = new SqlParameter("@show_Expenses", SqlDbType.NChar, 10);
            param[26].Value = show_Expenses;
            param[27] = new SqlParameter("@add_Expenses", SqlDbType.NChar, 10);
            param[27].Value = add_Expenses;
            param[28] = new SqlParameter("@del_Expenses", SqlDbType.NChar, 10);
            param[28].Value = del_Expenses;
            param[29] = new SqlParameter("@edite_Expenses", SqlDbType.NChar, 10);
            param[29].Value = edite_Expenses;
            param[30] = new SqlParameter("@show_Receipts", SqlDbType.NChar, 10);
            param[30].Value = show_Receipts;
            param[31] = new SqlParameter("@add_Receipts", SqlDbType.NChar, 10);
            param[31].Value = add_Receipts;
            param[32] = new SqlParameter("@del_Receipts", SqlDbType.NChar, 10);
            param[32].Value = del_Receipts;
            param[33] = new SqlParameter("@edite_Receipts", SqlDbType.NChar, 10);
            param[33].Value = edite_Receipts;
            param[34] = new SqlParameter("@edite_sell_price", SqlDbType.NChar, 10);
            param[34].Value = edite_sell_price;
            param[35] = new SqlParameter("@add_discount", SqlDbType.NChar, 10);
            param[35].Value = add_discount;
            param[36] = new SqlParameter("@follow_sell_pills", SqlDbType.NChar, 10);
            param[36].Value = follow_sell_pills;
            param[37] = new SqlParameter("@Repayment_of_purchases", SqlDbType.NChar, 10);
            param[37].Value = Repayment_of_purchases;
            param[38] = new SqlParameter("@sell_by_less_than_less_price", SqlDbType.NChar, 10);
            param[38].Value = sell_by_less_than_less_price;
            param[39] = new SqlParameter("@show_benefits", SqlDbType.NChar, 10);
            param[39].Value = show_benefits;
            param[40] = new SqlParameter("@sell_less_buy", SqlDbType.NChar, 10);
            param[40].Value = sell_less_buy;
            param[41] = new SqlParameter("@rebayments_of_sales", SqlDbType.NChar, 10);
            param[41].Value = rebayments_of_sales;
            param[42] = new SqlParameter("@show_cate", SqlDbType.NChar, 10);
            param[42].Value = show_cate;
            param[43] = new SqlParameter("@add_cate", SqlDbType.NChar, 10);
            param[43].Value = add_cate;
            param[44] = new SqlParameter("@del_cate", SqlDbType.NChar, 10);
            param[44].Value = del_cate;
            param[45] = new SqlParameter("@edite_cate", SqlDbType.NChar, 10);
            param[45].Value = edite_cate;
            param[46] = new SqlParameter("@cate_movement_report", SqlDbType.NChar, 10);
            param[46].Value = cate_movement_report;
            param[47] = new SqlParameter("@warehouse_goods_report", SqlDbType.NChar, 10);
            param[47].Value = warehouse_goods_report;
            param[48] = new SqlParameter("@warehouse_movement_report", SqlDbType.NChar, 10);
            param[48].Value = warehouse_movement_report;
            param[49] = new SqlParameter("@cate_cost", SqlDbType.NChar, 10);
            param[49].Value = cate_cost;
            param[50] = new SqlParameter("@sell_nonavailable_quantity", SqlDbType.NChar, 10);
            param[50].Value = sell_nonavailable_quantity;
            param[51] = new SqlParameter("@print_barcode", SqlDbType.NChar, 10);
            param[51].Value = print_barcode;
            param[52] = new SqlParameter("@shohna_report", SqlDbType.NChar, 10);
            param[52].Value = shohna_report;
            param[53] = new SqlParameter("@show_accounts", SqlDbType.NChar, 10);
            param[53].Value = show_accounts;
            param[54] = new SqlParameter("@add_accounts", SqlDbType.NChar, 10);
            param[54].Value = add_accounts;
            param[55] = new SqlParameter("@del_accounts", SqlDbType.NChar, 10);
            param[55].Value = del_accounts;
            param[56] = new SqlParameter("@edite_accounts", SqlDbType.NChar, 10);
            param[56].Value = edite_accounts;
            param[57] = new SqlParameter("@account_balance", SqlDbType.NChar, 10);
            param[57].Value = account_balance;
            param[58] = new SqlParameter("@account_statement", SqlDbType.NChar, 10);
            param[58].Value = account_statement;
            param[59] = new SqlParameter("@show_bank_movement", SqlDbType.NChar, 10);
            param[59].Value = show_bank_movement;
            param[60] = new SqlParameter("@expenses_analysis", SqlDbType.NChar, 10);
            param[60].Value = expenses_analysis;
            param[61] = new SqlParameter("@recipts_analysis", SqlDbType.NChar, 10);
            param[61].Value = recipts_analysis;
            param[62] = new SqlParameter("@show_installment_contract", SqlDbType.NChar, 10);
            param[62].Value = show_installment_contract;
            param[63] = new SqlParameter("@add_installment", SqlDbType.NChar, 10);
            param[63].Value = add_installment;
            param[64] = new SqlParameter("@edite_installment", SqlDbType.NChar, 10);
            param[64].Value = edite_installment;
            param[65] = new SqlParameter("@del_installment", SqlDbType.NChar, 10);
            param[65].Value = del_installment;
            param[66] = new SqlParameter("@pay_installment", SqlDbType.NChar, 10);
            param[66].Value = pay_installment;
            param[67] = new SqlParameter("@late_payed_installment", SqlDbType.NChar, 10);
            param[67].Value = late_payed_installment;

            dt = dal.SelectData("add_user", param);
            dal.Close();
            return dt;
        }

        public DataTable update_permissions(string userid, string manag_prog, string back_up, string general_reports, string date_time, string pills_number, string show_sales_pills, string add_sales_pills, string del_sales_pills, string edite_sales_pills, string show_buy_pills, string add_buy_pills, string del_buy_pills, string edite_buy_pills, string show_inventory, string add_inventory, string del_inventory, string edite_inventory, string show_exchange, string add_exchange, string del_exchange, string edite_exchange, string show_Settlement, string add_Settlement, string del_Settlement, string edite_Settlement, string show_Expenses, string add_Expenses, string del_Expenses, string edite_Expenses, string show_Receipts, string add_Receipts, string del_Receipts, string edite_Receipts, string edite_sell_price, string add_discount, string follow_sell_pills, string Repayment_of_purchases, string sell_by_less_than_less_price, string show_benefits, string sell_less_buy, string rebayments_of_sales, string show_cate, string add_cate, string del_cate, string edite_cate, string cate_movement_report, string warehouse_goods_report, string warehouse_movement_report, string cate_cost, string sell_nonavailable_quantity, string print_barcode, string shohna_report, string show_accounts, string add_accounts, string del_accounts, string edite_accounts, string account_balance, string account_statement, string show_bank_movement, string expenses_analysis, string recipts_analysis, string show_installment_contract, string add_installment, string edite_installment, string del_installment, string pay_installment, string late_payed_installment)
        {

            DataTable dt = new DataTable();
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[68];

            param[0] = new SqlParameter("@userid", SqlDbType.NChar, 10);
            param[0].Value = userid;
            param[1] = new SqlParameter("@manag_prog", SqlDbType.NChar, 10);
            param[1].Value = manag_prog;
            param[2] = new SqlParameter("@back_up", SqlDbType.NChar, 10);
            param[2].Value = back_up;
            param[3] = new SqlParameter("@general_reports", SqlDbType.NChar, 10);
            param[3].Value = general_reports;
            param[4] = new SqlParameter("@date_time", SqlDbType.NChar, 10);
            param[4].Value = date_time;
            param[5] = new SqlParameter("@pills_number", SqlDbType.NChar, 10);
            param[5].Value = pills_number;
            param[6] = new SqlParameter("@show_sales_pills", SqlDbType.NChar, 10);
            param[6].Value = show_sales_pills;
            param[7] = new SqlParameter("@add_sales_pills", SqlDbType.NChar, 10);
            param[7].Value = add_sales_pills;
            param[8] = new SqlParameter("@del_sales_pills", SqlDbType.NChar, 10);
            param[8].Value = del_sales_pills;
            param[9] = new SqlParameter("@edite_sales_pills", SqlDbType.NChar, 10);
            param[9].Value = edite_sales_pills;
            param[10] = new SqlParameter("@show_buy_pills", SqlDbType.NChar, 10);
            param[10].Value = show_buy_pills;
            param[11] = new SqlParameter("@add_buy_pills", SqlDbType.NChar, 10);
            param[11].Value = add_buy_pills;
            param[12] = new SqlParameter("@del_buy_pills", SqlDbType.NChar, 10);
            param[12].Value = del_buy_pills;
            param[13] = new SqlParameter("@edite_buy_pills", SqlDbType.NChar, 10);
            param[13].Value = edite_buy_pills;
            param[14] = new SqlParameter("@show_inventory", SqlDbType.NChar, 10);
            param[14].Value = show_inventory;
            param[15] = new SqlParameter("@add_inventory", SqlDbType.NChar, 10);
            param[15].Value = add_inventory;
            param[16] = new SqlParameter("@del_inventory", SqlDbType.NChar, 10);
            param[16].Value = del_inventory;
            param[17] = new SqlParameter("@edite_inventory", SqlDbType.NChar, 10);
            param[17].Value = edite_inventory;
            param[18] = new SqlParameter("@show_exchange", SqlDbType.NChar, 10);
            param[18].Value = show_exchange;
            param[19] = new SqlParameter("@add_exchange", SqlDbType.NChar, 10);
            param[19].Value = add_exchange;
            param[20] = new SqlParameter("@del_exchange", SqlDbType.NChar, 10);
            param[20].Value = del_exchange;
            param[21] = new SqlParameter("@edite_exchange", SqlDbType.NChar, 10);
            param[21].Value = edite_exchange;
            param[22] = new SqlParameter("@show_Settlement", SqlDbType.NChar, 10);
            param[22].Value = show_Settlement;
            param[23] = new SqlParameter("@add_Settlement", SqlDbType.NChar, 10);
            param[23].Value = add_Settlement;
            param[24] = new SqlParameter("@del_Settlement", SqlDbType.NChar, 10);
            param[24].Value = del_Settlement;
            param[25] = new SqlParameter("@edite_Settlement", SqlDbType.NChar, 10);
            param[25].Value = edite_Settlement;
            param[26] = new SqlParameter("@show_Expenses", SqlDbType.NChar, 10);
            param[26].Value = show_Expenses;
            param[27] = new SqlParameter("@add_Expenses", SqlDbType.NChar, 10);
            param[27].Value = add_Expenses;
            param[28] = new SqlParameter("@del_Expenses", SqlDbType.NChar, 10);
            param[28].Value = del_Expenses;
            param[29] = new SqlParameter("@edite_Expenses", SqlDbType.NChar, 10);
            param[29].Value = edite_Expenses;
            param[30] = new SqlParameter("@show_Receipts", SqlDbType.NChar, 10);
            param[30].Value = show_Receipts;
            param[31] = new SqlParameter("@add_Receipts", SqlDbType.NChar, 10);
            param[31].Value = add_Receipts;
            param[32] = new SqlParameter("@del_Receipts", SqlDbType.NChar, 10);
            param[32].Value = del_Receipts;
            param[33] = new SqlParameter("@edite_Receipts", SqlDbType.NChar, 10);
            param[33].Value = edite_Receipts;
            param[34] = new SqlParameter("@edite_sell_price", SqlDbType.NChar, 10);
            param[34].Value = edite_sell_price;
            param[35] = new SqlParameter("@add_discount", SqlDbType.NChar, 10);
            param[35].Value = add_discount;
            param[36] = new SqlParameter("@follow_sell_pills", SqlDbType.NChar, 10);
            param[36].Value = follow_sell_pills;
            param[37] = new SqlParameter("@Repayment_of_purchases", SqlDbType.NChar, 10);
            param[37].Value = Repayment_of_purchases;
            param[38] = new SqlParameter("@sell_by_less_than_less_price", SqlDbType.NChar, 10);
            param[38].Value = sell_by_less_than_less_price;
            param[39] = new SqlParameter("@show_benefits", SqlDbType.NChar, 10);
            param[39].Value = show_benefits;
            param[40] = new SqlParameter("@sell_less_buy", SqlDbType.NChar, 10);
            param[40].Value = sell_less_buy;
            param[41] = new SqlParameter("@rebayments_of_sales", SqlDbType.NChar, 10);
            param[41].Value = rebayments_of_sales;
            param[42] = new SqlParameter("@show_cate", SqlDbType.NChar, 10);
            param[42].Value = show_cate;
            param[43] = new SqlParameter("@add_cate", SqlDbType.NChar, 10);
            param[43].Value = add_cate;
            param[44] = new SqlParameter("@del_cate", SqlDbType.NChar, 10);
            param[44].Value = del_cate;
            param[45] = new SqlParameter("@edite_cate", SqlDbType.NChar, 10);
            param[45].Value = edite_cate;
            param[46] = new SqlParameter("@cate_movement_report", SqlDbType.NChar, 10);
            param[46].Value = cate_movement_report;
            param[47] = new SqlParameter("@warehouse_goods_report", SqlDbType.NChar, 10);
            param[47].Value = warehouse_goods_report;
            param[48] = new SqlParameter("@warehouse_movement_report", SqlDbType.NChar, 10);
            param[48].Value = warehouse_movement_report;
            param[49] = new SqlParameter("@cate_cost", SqlDbType.NChar, 10);
            param[49].Value = cate_cost;
            param[50] = new SqlParameter("@sell_nonavailable_quantity", SqlDbType.NChar, 10);
            param[50].Value = sell_nonavailable_quantity;
            param[51] = new SqlParameter("@print_barcode", SqlDbType.NChar, 10);
            param[51].Value = print_barcode;
            param[52] = new SqlParameter("@shohna_report", SqlDbType.NChar, 10);
            param[52].Value = shohna_report;
            param[53] = new SqlParameter("@show_accounts", SqlDbType.NChar, 10);
            param[53].Value = show_accounts;
            param[54] = new SqlParameter("@add_accounts", SqlDbType.NChar, 10);
            param[54].Value = add_accounts;
            param[55] = new SqlParameter("@del_accounts", SqlDbType.NChar, 10);
            param[55].Value = del_accounts;
            param[56] = new SqlParameter("@edite_accounts", SqlDbType.NChar, 10);
            param[56].Value = edite_accounts;
            param[57] = new SqlParameter("@account_balance", SqlDbType.NChar, 10);
            param[57].Value = account_balance;
            param[58] = new SqlParameter("@account_statement", SqlDbType.NChar, 10);
            param[58].Value = account_statement;
            param[59] = new SqlParameter("@show_bank_movement", SqlDbType.NChar, 10);
            param[59].Value = show_bank_movement;
            param[60] = new SqlParameter("@expenses_analysis", SqlDbType.NChar, 10);
            param[60].Value = expenses_analysis;
            param[61] = new SqlParameter("@recipts_analysis", SqlDbType.NChar, 10);
            param[61].Value = recipts_analysis;
            param[62] = new SqlParameter("@show_installment_contract", SqlDbType.NChar, 10);
            param[62].Value = show_installment_contract;
            param[63] = new SqlParameter("@add_installment", SqlDbType.NChar, 10);
            param[63].Value = add_installment;
            param[64] = new SqlParameter("@edite_installment", SqlDbType.NChar, 10);
            param[64].Value = edite_installment;
            param[65] = new SqlParameter("@del_installment", SqlDbType.NChar, 10);
            param[65].Value = del_installment;
            param[66] = new SqlParameter("@pay_installment", SqlDbType.NChar, 10);
            param[66].Value = pay_installment;
            param[67] = new SqlParameter("@late_payed_installment", SqlDbType.NChar, 10);
            param[67].Value = late_payed_installment;

            dt = dal.SelectData("update_permissions", param);
            dal.Close();
            return dt;
        }

    }
}
