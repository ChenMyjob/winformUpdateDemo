using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Xml;

namespace testlogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("请输入用户名", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtPwd.Text == "")
                {
                    MessageBox.Show("请输入密码", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    SqlConnection conn = BaseClass.DBConn.Login();
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select count(*) from userpwd where username='" + txtName.Text + "' and pwd='" + txtPwd.Text + "'", conn);
                    int i = Convert.ToInt32(cmd.ExecuteScalar());
                    if (i > 0)
                    {
                        cmd = new SqlCommand("select * from userpwd where username='" + txtName.Text + "'", conn);
                        SqlDataReader sdr = cmd.ExecuteReader();
                        sdr.Read();
                        conn.Close();
                        helloworld hello = new helloworld();
                        hello.Show();
                       
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定退出系统吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmUpdate updateFrm = new FrmUpdate();
            updateFrm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //bool bHasError = false;

        ///// <summary>
        ///// 获取客户端应用程序及服务器端升级程序的最近一次更新日期
        ///// </summary>
        ///// <param name="Dir"></param>
        ///// <returns></returns>
        //private string GetTheLastUpdateTime(string Dir)
        //{
        //    string LastUpdateTime = "";
        //    string AutoUpdaterFileName = Dir + @"\AutoUpdater.xml";
        //    if(!File.Exists(AutoUpdaterFileName))
        //        return LastUpdateTime;
        //    //打开xml文件
        //    FileStream myFile=new FileStream(AutoUpdaterFileName,FileMode.Open);
        //    //xml文件阅读器
        //    XmlTextReader xml = new XmlTextReader(myFile);
        //    while(xml.Read())
        //    {
        //        if(xml.Name=="UpdateTime")
        //        {
        //            LastUpdateTime = xml.GetAttribute("Date");
        //            break;
        //        }
        //    }
        //    xml.Close();
        //    myFile.Close();
        //    return LastUpdateTime;
        //}
        // string thePreUpdateDate =testlogin.Form1.GetTheLastUpdateTime(Application.StartupPath);
    }
}
