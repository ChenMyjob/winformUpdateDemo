using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace testlogin
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            /*  ProcessStartInfo info =new ProcessStartInfo();
              info.FileName = "update";
              info.Arguments = Process.GetCurrentProcess().Id.ToString();
              Process proc;
              try
              {
                  //启动外部程序
                  proc=Process.Start(info);
              }
              catch(Exception ex)
              {
                  MessageBox.Show("系统找不到指定的程序文件。");
              }*/



        }
    }
}
