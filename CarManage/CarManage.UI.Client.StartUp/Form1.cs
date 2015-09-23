using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;

using Dapper;

namespace CarManage.UI.Client.StartUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlServerDapper();
            //LoggingTest();
            new CarManage.DataAccess.MySql.Test().Insert();
        }

        private void SqlServerDapper()
        {
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection();
            connection.ConnectionString = "server=127.0.0.1;database=TestDB;uid=sa;password=Zh100083;";
            connection.Open();

            DapperInfo info = new DapperInfo();

            info.Id = Guid.NewGuid();
            info.Name = "wangxu";
            info.Age = null;
            info.BirthDate = null;
            //info.Valid = true;

            string commandText = "INSERT INTO Dapper(Id,Name,Age,BirthDate,Valid)VALUES(@Id,@Name,@Age,@BirthDate,@Valid)";

            connection.Execute(commandText, info);

            connection.Close();
        }

        private void MySqlDapper()
        {
            //DbProviderFactory factory=DbProviderFactories.GetFactory(
            ////System.Data.Common.DbConnection connection =new 
            ////connection.ConnectionString = "server=127.0.0.1;database=TestDB;uid=sa;password=Zh100083;";
            //connection.Open();

            //DapperInfo info = new DapperInfo();

            //info.Id = Guid.NewGuid();
            //info.Name = "wangxu";
            //info.Age = null;
            //info.BirthDate = null;
            ////info.Valid = true;

            //string commandText = "INSERT INTO Dapper(Id,Name,Age,BirthDate,Valid)VALUES(@Id,@Name,@Age,@BirthDate,@Valid)";

            //connection.Execute(commandText, info);

            //connection.Close();
        }

        private void LoggingTest()
        {
            try
            {
                throw new Exception("123");
            }
            catch (Exception ex)
            {
                ClassLibrary.ExceptionHandling.UserInterfaceExceptionHandler.HandlerException("456", ref ex);
            }
        }
    }

    public class DapperInfo
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int? Age { get; set; }

        public DateTime? BirthDate { get; set; }

        public bool Valid { get; set; }
    }
}
