using System;
using System.Collections.Generic;
using System.Data;

using ClassLibrary.Common;

namespace CarManage.DataAccess.MySql
{
    public class Test : DataAccessBase
    {
        /// <summary>
        /// 实体名称和数据库表名可以不一样，插入机制是通过实体属性名和数据库表名字段名实现的
        /// </summary>
        public void Insert()
        {
//            QuestionInfo questionInfo = new QuestionInfo();

//            questionInfo.Title = "Dapper单表实体插入";
//            questionInfo.Content = "简单测试";
//            questionInfo.Rank = 1;
//            questionInfo.Rate = 2.88888m;
//            questionInfo.Remark = "无";
//            questionInfo.Description = "desc";
//            questionInfo.CreateDate = DateTime.Now;
//            questionInfo.Valid = true;

//            string commandText = @"INSERT INTO Question(Title,Content,Rank,Rate,Remark,Description,CreateDate,Valid)
//                                        VALUES(@Title,@Content,@Rank,@Rate,@Remark,@Description,@CreateDate,@Valid)";

//            using (IDbConnection connection = new MySqlConnection(mysqlConnectionString))
//            {
//                connection.Open();
//                connection.Execute(commandText, questionInfo);
//            }
        }
    }
    

    public class QuestionInfo
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public int? Rank { get; set; }

        public decimal? Rate { get; set; }

        public string Remark { get; set; }

        public string Description { get; set; }

        public DateTime CreateDate { get; set; }

        public bool Valid { get; set; }


        public List<AnswerInfo> Answers { get; set; }
    }

    public class AnswerInfo
    {
        public int Id { get; set; }

        public int QuestionId { get; set; }

        public string Commet { get; set; }

        public decimal Score { get; set; }
    }
}
