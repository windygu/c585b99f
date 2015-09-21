using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace CarManage.UI.Client.StartUp
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

            ClassLibrary.Configuration.ConfigurationManager.Instance.Init();
            log4net.Config.XmlConfigurator.Configure(new System.IO.FileInfo("log4net.config"));
            Application.Run(new Form1());
        }
    }
}
