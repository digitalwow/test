using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    class Models_Station
    {
        public int init_station { get; set; }
        public int stationid { get; set; }
        public int productid { get; set; }
        public string productname { get; set; }
        public int mode { get; set; }
        public int mode_line { get; set; }
        public string stationname { get; set; }
        public string master_db_barcode { get; set; }
        public string master_db_field { get; set; }
        public string parent_barcode { get; set; }
        public string prepant_db_field { get; set; }
        public int need_iqc { get; set; }
        public int barcode_bysort { get; set; }
        public int worktime_s { get; set; }
        public int worktime_e { get; set; }
        public int worktime_alert { get; set; }
        public int prev_stationid { get; set; }
        //public string prev_parentcode { get; set; }
        public int color_match_station { get; set; }
        public string color_match_station_prevfix { get; set; }
        public string scanner_gun { get; set; }
        public string operator_id { get; set; }
        public string coverbarcode2iqc { get; set; }
        public int timeout_sec { get; set; }
        public int is_rewrite { get; set; }
        public int is_rework { get; set; }
        public int is_rework_par { get; set; }
        public int is_insert2db { get; set; }
        public string close_barcode { get; set; }
        public string reset_barcode { get; set; }
        public string error_barocde_prevfix { get; set; }
        public string substep_name { get; set; }
        public string substep_prefix { get; set; }
        public string substep_db_field { get; set; }
        public int substep_color_match_station { get; set; }
        public string substep_color_match_station_prevfix { get; set; }
        public int subneed_filter { get; set; }
        public int subneed_only { get; set; } 
        public int subneed_iqc { get; set; }  
        public int subneed_prev { get; set; }
        public int subneed_from { get; set; }
        public int subneed_option { get; set; }  
    }
    class Models_Employee
    {
        public string CurrentStepID {get ;set;}
        public string EmployeeID { get; set; }
        public int stationName { get; set; }
        public string AccessTime { get; set; }
        public int m_id { get; set; }
        public string workid { get; set; }
        
    }



    class Models_Option
    {
        public string Option_Name { get; set; }
        public string Option_Value { get; set; }
        public string Option_Value1 { get; set; }
    }

    class Models_Rework_Workstation
    {
        public int stationid { get; set; }
        public string rework_field { get; set; }
        public int is_rework { get; set; }
        public int is_rework_par { get; set; }
    }


    class ControlName
    {
        public string controlname { get; set; }
    }

    class Models_MessageTable
    {
        public string msg_code { get; set; }
        public string msg_class { get; set; }
        public string msg_voice { get; set; }
        public string msg_content { get; set; }
    }

    /*
    class Models_CaddyTrek1
    {
        
        public string id { get; set; }
        public string barcodeno { get; set; }
        public DateTime ScanBarCodeDate { get; set; }
        public string bldc { get; set; }
        public string gcb { get; set; }
        public string tq2400 { get; set; }
        public string cc2530 { get; set; }
        public string sensor { get; set; }
        public string burn_ver { get; set; }
        public string frame { get; set; }
        public string wheel1 { get; set; }
        public string wheel2 { get; set; }
        public string cover { get; set; }
        public string cartype { get; set; }
        public string hs { get; set; }
        public string hs_bt { get; set; }
        public string car_bt1 { get; set; }
        public string car_bt_c { get; set; }
        public string usb_a { get; set; }
        public string car_bt2 { get; set; }
        public int createdit { get; set; }
    }
    */

    //class Models_SFISView
    //{

    //    public int StepID { get; set; }
    //    public string ParentBarCode { get; set; } // get scan barcode and get parentid after fill this field.
    //    public string BarCodeNo { get; set; } // scan Barcode
    //    public int ErrorCodeID { get; set; }
    //    public string ScanBarCodeDate { get; set; } //get scan barcode date and time from MSMQ
    //    public string ProcessTime { get; set; } //how must time (sec) for this step no and pre step no
    //}
    class Models_SFIS
    {
        public int Productid { get; set; }
        public string Productname { get; set; }
        public string FactoryCode { get; set; }
        public string MasterID { get; set; }
        public string ProductShortID { get; set; }
        public string RegionID { get; set; }
        public int LineID { get; set; }
        public int StepID { get; set; }
        public int Mode { get; set; }
        public int Rework { get; set; }
        public string ParentBarCode { get; set; } // get scan barcode and get parentid after fill this field.
        //public string PrevParentBarcode { get; set; }
        public string BarCodeNo { get; set; } // scan Barcode
        public int ErrorCodeID { get; set; }
        public int OperatorID { get; set; } // who operation
        public int ValidID { get; set; } // -1  : not assign, 0 : not found parent id, 1 : current
        public int ClosedIt { get; set; } // 1 : closed, 0 : not close.
        public int FinalSortByBarCode { get; set; }
        public DateTime ScanBarCodeDate { get; set; } //get scan barcode date and time from MSMQ
        public DateTime Created { get; set; } //get scan barcode date and time from MSMQ
        //public int ProcessTime { get; set; } //how must time (sec) for this step no and pre step no
        public string Note { get; set; }
        public int StationNameID { get; set; } // station ID, from         
        public string WorkID { get; set; }
        public string Db_field { get; set; }
        public string Db_field_Master { get; set; }
        public string Messages { get; set; }
        public int ErrorID { get; set; } //assign errorid

        public string result { get; set; }
        public bool write_rawdata { get; set; } //write db
        public string OptionValue { get; set; } //return client option string
        public int OptionValue_ismode { get; set; } //return client option string1
        public int OptionValue_isrework { get; set; } //return client option string2
        public int OptionValue_isrewrite { get; set; } //return client option string3
    }

    class Models_SFIS_Temp
    {
        public string MasterID { get; set; }
        public string ProductShortID { get; set; }
        public string RegionID { get; set; }
        public int LineID { get; set; }
        public int StepID { get; set; }
        public string ParentBarCode { get; set; } // get scan barcode and get parentid after fill this field.
        public string BarCodeNo { get; set; }                
        public int ValidID { get; set; } // -1  : not assign, 0 : not found parent id, 1 : current
        public int ClosedIt { get; set; }
        public int FinalSortByBarCode { get; set; }
       
    }


    class Models_ProductID_Relation
    {
        public string ParentID { get; set; }
        public string ParentID_Pre { get; set; }
        public string ChildID { get; set; }
        public string GUNID { get; set; }
        public string Note { get; set; }
        public int OperatorID { get; set; }
        public bool bolActive { get; set; }
        public int stepid { get; set; }
    }

    class Models_BarCodeNoOnly
    {
        public string BarCodeNo { get; set; }
        public int Closeit { get; set; }

    }

    class Models_Product
    {
        public string productname { get; set; }
        public int id { get; set; }
    }

    class Models_Gun
    {
        public string gunno { get; set; }
    }

    class Models_val
    {
        public string val { get; set; }
    }

    class Models_Rework_Pooling
    {
        public string parentbarocode { get; set; }
        public int stationid { get; set; }
        public int productid { get; set; }
    }


    //Id,Email,Sex,Name
    //Id, Parameter_Id, Param_Encryption, Title, Content, Sender, sendtime, End_Time, EN_Web_Country
    //, Condition_ddlisEpaper, Condition_ddlGoup, Additionall_CBepaperMember, Additionall_CBcardMember
    // ,Use_P, Success_Send, Loss_Send, CDE, APM, ACM, AppDateTime, UCoin, UCoin_Date, Start_Time, Appointment_Date,(CDE+APM+ACM) AS QUT
    //public class ePaperMain
    //{
    //    public int Id { get; set; }
    //    public int Parameter_Id { get; set; }
    //    public string Param_Encryption { get; set; }
    //    public string Title { get; set; }
    //    public string Content { get; set; }
    //    public string Sender { get; set; }
    //    public string sendtime { get; set; }
    //    public DateTime End_Time { get; set; }
    //    public int EN_Web_Country { get; set; }
    //    public string Condition_ddlisEpaper { get; set; }
    //    public string Condition_ddlGoup { get; set; }
    //    public char Additionall_CBepaperMember { get; set; }
    //    public char Additionall_CBcardMember { get; set; }
    //    public char Use_P { get; set; }
    //    public int Success_Send { get; set; }
    //    public int Loss_Send { get; set; }
    //    public string CDE { get; set; }
    //    public int APM { get; set; }
    //    public int ACM { get; set; }
    //    public string AppDateTime { get; set; }
    //    public double UCoin { get; set; }
    //    public DateTime UCoin_Date { get; set; }
    //    public DateTime Start_Time { get; set; }
    //    public DateTime Appointment_Date { get; set; }
    //    public int QUT { get; set; }
    //    public bool Break_Flay { get; set; }        //標記中斷1
    //    public string Processstatus { get; set; }   //紀錄傳送狀態說明

    //}
    //public class V_Member_Group_All
    //{
    //    public int Id { get; set; }
    //    public string Email { get; set; }
    //    public int Sex { get; set; }
    //    public string Name { get; set; }
    //}
    //public class Smtp_Ip_Address
    //{
    //    public int Id { get; set; }
    //    public string Smtp_Ip { get; set; }
    //    public string Smtp_Name { get; set; }
    //}
    //public class epaper_log
    //{
    //    public int ePaper_id { get; set; }
    //    public int Member_Id { get; set; }
    //}

}

/// <summary>
/// 靠边隐藏的类型。
/// </summary>
public enum DockHideType
{
    /// <summary>
    /// 不隐藏
    /// </summary>
    None = 0,
    /// <summary>
    /// 靠上边沿隐藏
    /// </summary>
    Top,
    /// <summary>
    /// 靠左边沿隐藏
    /// </summary>
    Left,
    /// <summary>
    /// 靠右边沿隐藏
    /// </summary>
    Right
}

/// <summary>
/// 窗体的显示或隐藏状态
/// </summary>
public enum FormDockHideStatus
{
    /// <summary>
    /// 已隐藏
    /// </summary>
    Hide = 0,

    /// <summary>
    /// 准备隐藏
    /// </summary>
    ReadyToHide,

    /// <summary>
    /// 正常显示
    /// </summary>
    ShowNormally

}
class Enum_Utility
{
    enum DB_Table
    {
        //sfis_rawbarcode = "sfis_rawbarcode1",
        //sfis_rawbarcode_repair = "sfis_rawbarcode_repair",

        //sfis_productstepid2option = "sfis_productstepid2option"
    }

    

    public enum LogMsgType { Incoming, Outgoing, Normal, Warning, Error };

    public enum AlertVoiceType
    {
        Normal = 1,
        ReSet = 2,
        NotMatchCount = 5,
        NotClosed = 10,
        Error = 20
    }
    //public enum AlertVoice
    //{
    //    voice_1s = "01",
    //    voice_2s = "02",
    //    voice_3s = "03",
    //    voice_4s = "04",
    //    voice_5s = "05",
    //    voice_1l = "10",
    //    voice_3l = "11",
    //    voice_1l1s = "1E",
    //    voice_1l2s = "1F",
    //    voice_1l1s1l1s = "20"
    //}
}