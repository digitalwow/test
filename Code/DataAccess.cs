using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
//using Microsoft.ApplicationBlocks.Data;
using MySql.ApplicationBlocks.Data;
using MySql.Data.MySqlClient;
using System.Collections;


namespace test
{

    class DataAccess
    {

        public string Conn = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlconnectionString"].ToString();
        
        public string strSql = "";
        public string ErrorMsg = "";
        public const string sfis_rawbarcode = "sfis_rawbarcode";
        //public const string sfis_rawbarcode_caddytrek = "caddytrek";
        public string Productname = System.Configuration.ConfigurationManager.ConnectionStrings["Productname"].ToString();
        //public  

        public int ret(string barcode)
        {
            string strSql = "select barcode from sfis_rawbarcode_outside where active=1";
            MySqlDataReader sdr = MySqlHelper.ExecuteReader(Conn, strSql);
            IList<Models_BarCodeNoOnly> list = new List<Models_BarCodeNoOnly>();
            while (sdr.Read())
            {
                Models_BarCodeNoOnly group = new Models_BarCodeNoOnly();

                group.BarCodeNo = sdr["barcode"].ToString().Trim();
                group.Closeit = 1;
                list.Add(group);

            }

            sdr.Close();
            sdr.Dispose();
            return list.Count;
        }

        public void Employee_LastAccess(int productid, int stationid, string gunno, string masterid)
        {
            if (productid == 0)
                strSql = "SELECT id, username,fullname, picture, company as work_id, lastlogintime FROM sfis_member where id = " + masterid;
            else
                strSql = "SELECT id, username,fullname, picture, company as work_id, lastlogintime FROM sfis_member where id  = ( " +
                    "SELECT operator_now FROM sfis_base_workstation where productid=" + productid + " and stationid=" + stationid + " and scanner_gun='" + gunno + "') ";
            MySqlDataReader sdr = MySqlHelper.ExecuteReader(Conn, strSql);

            IList<Models_Employee> list = new List<Models_Employee>();
            while (sdr.Read())
            {
                Models_Employee group = new Models_Employee();

                //group.CurrentStepID = sdr["Factory_Region"].ToString().Trim() + sdr["LineID_StepID"].ToString().Trim();
                group.CurrentStepID = "";
                group.EmployeeID = sdr["username"].ToString().Trim();
                group.stationName = 11;
                group.AccessTime = sdr["lastlogintime"].ToString();
                group.m_id = int.Parse(sdr["id"].ToString());
                group.workid = sdr["work_id"].ToString();
                list.Add(group);
            }
            sdr.Close();
            //sdr.Dispose();
        }

        public string ReturnSingleField(string _strsql)
        {
            try
            {
                return SQLHelper.ExecuteScalar(Conn, CommandType.Text, _strsql).ToString();
            }
            catch (Exception ex)
            {
                return ""; //ex..Message;
            }
        }
    }
}
