using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Text;

using System.Windows.Forms;
using WebSocket4Net;
using CCWin;
using MySql;
using System.Collections;
using MySql.ApplicationBlocks.Data;
using MySql.Data.MySqlClient;

namespace test
{


    public partial class Form1 : CCSkinMain
    {
        DataAccess objAccess = new DataAccess();
        DateTime _lastKeystroke = new DateTime(0);
        List<char> _barcode = new List<char>(10);
        WebSocket websocket;
        public string Conn = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlconnectionString"].ToString();
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
           // this.MinimizeBox = false;
           // this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);

            websocket = new WebSocket("ws://192.168.1.103:8050");
          //  websocket.Opened += new EventHandler(websocket_Opened);
            //websocket.Error += new EventHandler<ErrorEventArgs>(websocket_Error);
            //websocket.Closed += new EventHandler(websocket_Closed);
            //websocket.MessageReceived += new EventHandler(websocket_MessageReceived);
          
            websocket.Open();
            //this.KeyPreview = true;
           // Run_Clear_Pid();
           // int a = objAccess.ret(textBox1.Text);
          //  label1.Text = (a ).ToString();
        }

        private void websocket_Opened(object sender, EventArgs e)
        {
            websocket.Send("Hello World!");
        }

        private void websocket_DataReceived(object sender, EventArgs e)
        {
            
           
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // check timing (keystrokes within 100 ms)
            TimeSpan elapsed = (DateTime.Now - _lastKeystroke);
            if (elapsed.TotalMilliseconds > 100)
                _barcode.Clear();

            // record keystroke & timestamp
            _barcode.Add(e.KeyChar);
            _lastKeystroke = DateTime.Now;

            // process barcode
            if (e.KeyChar == 13 && _barcode.Count > 0)
            {
                string msg = new String(_barcode.ToArray());
                MessageBox.Show(msg);
                _barcode.Clear();
            }
            else
                label1.Text = e.KeyChar.ToString();
        }
        Queue<char> Q = new Queue<char>();
        //private void Form1_KeyDown(object sender, KeyEventArgs e)
        //{

        //    char c = (char)e.KeyCode;

        //    if (char.IsLetterOrDigit(c))
        //        Q.Enqueue(c);
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        foreach (char cc in Q)
        //            textBox1.Text += cc;
        //        Q = new Queue<char>();
        //    }
        //}

       public void tt(){
           string _data = ",12,";
           _data = _data.Substring(1, _data.Length -2);
           label1.Text = _data;


        }

       //private void Form1_FormClosing(object sender, FormClosingEventArgs e)
       //{
       //    MessageBox.Show("程序将最小化到系统托盘区");
       //    e.Cancel = true; // 取消关闭窗体 
       //    this.Hide();
       //    this.ShowInTaskbar = false;//取消窗体在任务栏的显示 
       //    this.notifyIcon.Visible = true;//显示托盘图标 

       //}
       public void pp()
       {



           ArrayList aList = new ArrayList();

           aList.Add("011134600140");

           aList.Add("019113900119");

           aList.Add("D033M241005Q11I1700033");

           aList.Add("101110091835718");

           aList.Add("10091110030587893");
           aList.Add("SSZL12J0700507");

           int aa = 0;
           for (int i = 0; i < aList.Count; i++)
           {
               aa = aList[i].ToString().IndexOf("011");
               if (aa == 0)
               {
                   aList.Remove(aList[i].ToString());
                   break;
               }
           }


          
       }


       #region  clear mysql job
       public void Run_Clear_Pid()
       {

           //System.Timers.Timer t = new System.Timers.Timer();
           System.Timers.Timer t = new System.Timers.Timer(3 * 1000);
           t.Elapsed += new System.Timers.ElapsedEventHandler(this.RunJobTime);
           t.Start();
           t.AutoReset = true;
           t.Enabled = true;
           GC.KeepAlive(t);
       }
       private void RunJobTime(object sender, System.Timers.ElapsedEventArgs e)
       {

           objAccess.Employee_LastAccess(2, 11, "A11", "A11");
       }


       #endregion


       private void button1_Click(object sender, EventArgs e)
       {
           string field = "", strfield = "", strfieldtemp = "";
           int cc = 0;
           int temp_cc = 1, intcheck = 0;
           strfield = textBox1.Text.Trim();
           try
           {
               objAccess.Employee_LastAccess(2,11,"A11","A11");
               int a = objAccess.ret(textBox1.Text);
               int b = objAccess.ret(textBox1.Text);
               label1.Text = (a + b).ToString();
               //strfieldtemp = strfield.Substring(strfield.Length - 1, 1);
               //temp_cc = int.Parse(strfieldtemp);
               //strfield = strfield.Substring(0, strfield.Length - 1);
               //temp_cc++;
               //strfield = strfield + temp_cc.ToString();

           }
           catch
           {
               temp_cc = 0;
           }

          // field += strfield + "='222222',";
       }

         private void ExitMainForm()         
         { 

            if (MessageBox.Show("您确定要退出SFIS ?", "确认退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)              { 
                this.notifyIcon.Visible = false;                
                this.Close();                 
                this.Dispose();                  
                Application.Exit();           
            }         
         } 
       private void ShowMainForm()
       {
           this.Show();
           this.notifyIcon.Visible = false;
           this.WindowState = FormWindowState.Normal; 
           this.Activate();
       }
       private void HideMainForm()
       {
           this.Hide();
           this.notifyIcon.Visible = true;
       } 





       private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
       {
           if (e.Button == MouseButtons.Left)
           {
               ShowMainForm();
                
                //this.ShowInTaskbar = true;
                //this.notifyIcon.Visible = false;
                //this.Visible = true;
                //this.Activate(); 
            }
           else if (e.Button == MouseButtons.Right)
           {
           }
       }

       private void Form1_Resize(object sender, EventArgs e)
       {
           if (this.WindowState == FormWindowState.Minimized)
           {
               HideMainForm();
               //this.Hide();
               //this.ShowInTaskbar = false;//取消窗体在任务栏的显示 
               //this.notifyIcon.Visible = true;//显示托盘图标 
              // MessageBox.Show("程序将最小化到系统托盘区");
           }
          
       }

       private void Form1_FormClosing(object sender, FormClosingEventArgs e)
       {
           e.Cancel = true;
           HideMainForm();
       }

       private void showToolStripMenuItem_Click(object sender, EventArgs e)
       {
           ShowMainForm();
       }

       private void exitToolStripMenuItem_Click(object sender, EventArgs e)
       {
           ExitMainForm();
       }

       private void button2_Click(object sender, EventArgs e)
       {
           websocket.Send("Hello World!");
       }


    }


}
