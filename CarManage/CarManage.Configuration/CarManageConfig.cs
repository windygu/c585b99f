using System;
using System.Collections.Generic;
//using System.Windows.Forms;
using System.Drawing;
using System.Configuration;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

using ClassLibrary.Configuration;

namespace CarManage.Configuration
{
    public sealed class CarManageConfig : IConfigurationSection
    {
        private static readonly CarManageConfig instance = 
            new CarManageConfig();

        public event EventHandler<EventArgs> OnSave;


        #region 系统常量

        /// <summary>
        /// 属性契约
        /// </summary>
        public readonly string AttributeContract =
            "Esoft.Framework.DataService.IAttributeFileTransfer";

        /// <summary>
        /// 属性服务地址
        /// </summary>
        public readonly string AttributeAddress = "{0}://{1}:{2}/Design_Time_Addresses/"
            + "Esoft.Framework.DataService/IAttributeFileTransfer/IAttributeFileTransfer";

        /// <summary>
        /// 品牌契约
        /// </summary>
        public readonly string BrandContract =
            "Esoft.Framework.DataService.IBrandFileTransfer";

        /// <summary>
        /// 订单契约
        /// </summary>
        public readonly string OrderContract =
            "Esoft.Framework.DataService.Order.IOrderFileTransfer";

        /// <summary>
        /// 库存契约
        /// </summary>
        public readonly string StorageContract =
            "Esoft.Framework.DataService.Storage.IStorageFileTransfer";

        /// <summary>
        /// 采购订单契约
        /// </summary>
        public readonly string PurchaseContract =
            "Esoft.Framework.DataService.Purchase.IPurchaseFileTransfer";

        /// <summary>
        /// 品牌服务地址
        /// </summary>
        public readonly string BrandAddress = "{0}://{1}:{2}/Design_Time_Addresses/"
            + "Esoft.Framework.DataService/IBrandFileTransfer/IBrandFileTransfer";

        /// <summary>
        /// 产品数据契约
        /// </summary>
        public readonly string ProductContract =
            "Esoft.Framework.DataService.IProductFileTransfer";

        /// <summary>
        /// 产品服务地址
        /// </summary>
        public readonly string ProductAddress = "{0}://{1}:{2}/Design_Time_Addresses/"
            + "Esoft.Framework.DataService/IProductFileTransfer/IProductFileTransfer";

        /// <summary>
        /// 订单服务地址
        /// </summary>
        public readonly string OrderAddress = "{0}://{1}:{2}/Design_Time_Addresses/"
            + "Esoft.Framework.DataService/IOrderFileTransfer/IOrderFileTransfer";

        /// <summary>
        /// 库存服务地址
        /// </summary>
        public readonly string StorageAddress = "{0}://{1}:{2}/Design_Time_Addresses/"
            + "Esoft.Framework.DataService/IStorageFileTransfer/IStorageFileTransfer";

        /// <summary>
        /// 采购订单服务地址
        /// </summary>
        public readonly string PurchaseAddress = "{0}://{1}:{2}/Design_Time_Addresses/"
            + "Esoft.Framework.DataService/IPurchaseFileTransfer/IPurchaseFileTransfer";

        /// <summary>
        /// 供应商系统服务地址
        /// </summary>
        ///public readonly string SupplierServiceAddress = "{0}://{1}/Esoft.Framework.Web.Supplier/SupplierServiceTransfer.svc";
        public readonly string SupplierServiceAddress = "{0}://{1}/SupplierServiceTransfer.svc";

        /// <summary>
        /// 供应商系统Web服务地址
        /// </summary>
        public string SupplierWebServiceUrl { get; set; }

        #endregion

        static CarManageConfig()
        {
            
        }

        public static CarManageConfig Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// 应用程序是否已退出
        /// </summary>
        public bool AppExited { get; set; }

        private string dataAccessProvider;

        /// <summary>
        /// 数据访问提供程序
        /// </summary>
        public string DataAccessProvider
        {
            get
            {
                return instance.dataAccessProvider;
            }

            set { instance.dataAccessProvider = value; }
        }

        /// <summary>
        /// 异常处理策略
        /// </summary>
        public string ExceptionPolicy { get; set; }

        /// <summary>
        /// 日志处理提供程序
        /// </summary>
        public string LoggingProvider { get; set; }

        /// <summary>
        /// 日志策略
        /// </summary>
        public string LoggingPolicy { get; set; }

        /// <summary>
        /// 应用程序根目录
        /// </summary>
        public readonly string AppPath = Path.GetDirectoryName(
            Assembly.GetExecutingAssembly().ManifestModule.FullyQualifiedName)+"\\";

        /// <summary>
        /// 是否启用缓存
        /// </summary>
        public bool EnableCache { get; set; }

        /// <summary>
        /// 是否启用权限
        /// </summary>
        public bool EnablePermission { get; set; }

        /// <summary>
        /// 应用程序版本号
        /// </summary>
        public string AppVersion
        {
            get
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// 数据库连接字符串名称
        /// </summary>
        public string ConnectionStringName { get; set; }

        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public string ConnectionString
        {
            get { return System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString; }
        }

        /// <summary>
        /// 系统语言
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// 页面大小
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 产品图片扩展名
        /// </summary>
        public string ImageExtension
        {
            get { return ".jpg"; }
        }

        /// <summary>
        /// Html编辑器
        /// </summary>
        public string HtmlEditorUrl
        {
            get
            {
                return Path.Combine(CarManageConfig.Instance.AppPath,
                    "PlugIn\\Fckeditor\\ProductEditor.htm");
            }
        }

        public void ProcessSection(XmlNode node)
        {
            foreach (XmlNode childNode in node.ChildNodes)
            {
                if (childNode.NodeType.Equals(XmlNodeType.Comment))
                    continue;

                if (childNode.Attributes["key"].Value.Equals("ExceptionPolicy"))
                    instance.ExceptionPolicy = childNode.Attributes["value"].Value;

                if (childNode.Attributes["key"].Value.Equals("DataAccessProvider"))
                    instance.dataAccessProvider = childNode.Attributes["value"].Value;

                if (childNode.Attributes["key"].Value.Equals("LoggingProvider"))
                    instance.LoggingProvider = childNode.Attributes["value"].Value;

                if (childNode.Attributes["key"].Value.Equals("LoggingPolicy"))
                    instance.LoggingPolicy = childNode.Attributes["value"].Value;

                if (childNode.Attributes["key"].Value.Equals("PageSize"))
                {
                    int pageSize = 0;

                    if (int.TryParse(childNode.Attributes["value"].Value, out pageSize))
                        instance.PageSize = pageSize;
                    else
                        instance.PageSize = 20;
                }

                if (childNode.Attributes["key"].Value.Equals("Language"))
                    instance.Language = childNode.Attributes["value"].Value;

                if (childNode.Attributes["key"].Value.Equals("EnableCache"))
                    instance.EnableCache = bool.Parse(childNode.Attributes["value"].Value);

                if (childNode.Attributes["key"].Value.Equals("EnablePermission"))
                    instance.EnablePermission = bool.Parse(childNode.Attributes["value"].Value);
            }
        }

        //public void Save()
        //{
        //    if (OnSave != null)
        //        OnSave(null, null);
        //}

        public void Save()
        {
            string configPath =
                System.Configuration.ConfigurationManager.AppSettings["ConfigFile"];

            XmlDocument document = new XmlDocument();
            document.Load(configPath);

            XmlNode node = document.SelectSingleNode(
                "descendant::carConfiguration");

            if (node == null)
                return;

            foreach (XmlNode childNode in node.ChildNodes)
            {
                if (!childNode.NodeType.Equals(XmlNodeType.Element))
                    continue;
            }

            document.Save(configPath);
        }

        public string Type
        {
            get { return "carConfiguration"; }
        }
    }
}
