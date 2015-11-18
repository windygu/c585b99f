using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//using MySql.Data.MySqlClient;
using Dapper;
using CarManage.DataAccess.MySql;

namespace CarManage.UI.Test
{
    
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = GetQuestions();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var parms = base.CreateParams;
                parms.Style &= ~0x02000000; // Turn off WS_CLIPCHILDREN 
                return parms;
            }
        }    

        //public List<QuestionInfo> GetQuestions()
        //{
        //    using (IDbConnection connection = new MySqlConnection("server=55ae29342ce85.gz.cdb.myqcloud.com;port=13451;database=test;uid=root;pwd=Zh100083;charset='utf8'"))
        //    {
        //        return connection.Query<QuestionInfo>("select * from Question").ToList();
        //    }


        //}
    }
}
