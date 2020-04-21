using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System.Data.SQLite;
namespace DatabaseAcces
{
    public class QuestionDAOService: IQuestionDAO
    {
        private string _path;

        public QuestionDAOService(string path)
        {
            this._path = path;
        }

        private SQLiteConnection CreateConnection()
        {
            SQLiteConnection con;
            con = new SQLiteConnection("Data Source=" + this._path + "; Version = 3; New = True; Compress = True; ");
            con.Open();
            return con;
        }

        public List<QuestionModel> GetQuestions(int level)
        {
            List<QuestionModel> questionModels = new List<QuestionModel>();

            SQLiteConnection con = CreateConnection();
            SQLiteCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM QUESTIONS WHERE LEVEL=" + level + ";";

            SQLiteDataReader dataReader;
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                questionModels.Add(new QuestionModel(dataReader.GetInt32(0),
                                                     dataReader.GetString(1),
                                                     dataReader.GetString(2),
                                                     dataReader.GetString(3),
                                                     dataReader.GetString(4),
                                                     dataReader.GetString(5),
                                                     dataReader.GetString(6),
                                                     dataReader.GetInt32(7)));
            }
            con.Close();
            return questionModels;
        }
    }
}
