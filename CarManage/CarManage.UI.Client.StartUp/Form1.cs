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

        CarManage.DataAccess.MySql.DataAccessBase data = new DataAccess.MySql.DataAccessBase();

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

        private void button2_Click(object sender, EventArgs e)
        {
            CarManage.Business.Customer.Car car = new Business.Customer.Car();
            CarManage.Model.Customer.CarInfo carInfo = new Model.Customer.CarInfo();

            carInfo.Id = Guid.NewGuid().ToString();
            carInfo.CustomerId = Guid.NewGuid().ToString();
            carInfo.Number = "Number";
            carInfo.Brand = "Brand";
            carInfo.Model = "Model";
            carInfo.Displacement = 1;
            carInfo.FrameNumber = "FrameNumber";
            carInfo.EngineNumber = "EngineNumber";
            carInfo.BodyColor = "BodyColor";
            carInfo.InteriorColor = "InteriorColor";
            carInfo.InvoiceDate = null;
            carInfo.BuyMileage = 2;
            carInfo.RegisterDate = DateTime.Now;
            carInfo.Mileage = 3;
            carInfo.MaintenancePeriod = 4;
            carInfo.MaintenanceMileage = 5;
            carInfo.NextMaintenanceDate =DateTime.Now;
            carInfo.NextMaintenanceMileage = 6;
            carInfo.GuaranteePeriod = 7;
            carInfo.GuaranteeMileage = 8;
            carInfo.ActualGuaranteeDate = DateTime.Now;
            carInfo.ActualGuaranteeMileage = CarManage.Model.Enum.CustomerCharacter.主导型;
            carInfo.CreateDate = DateTime.Now;
            carInfo.UpdateDate = DateTime.Now;
            carInfo.Creator = "Creator";
            carInfo.Operator = "Operator";
            carInfo.Valid = true;

            car.Add(carInfo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CarManage.Business.Customer.Car car = new Business.Customer.Car();
            CarManage.Model.Customer.CarInfo carInfo = car.Load("166ca143-1ebc-4cc2-a7a4-4013a6fa42ab");
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
