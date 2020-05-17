/**************************************************************************
 *                                                                        *
 *  File:        QuestionDaoService.cs                                    *
 *  Atuhors:     Baciu H. Alexandru, Corduneanu Vlad, Haralamb Marian     *
 *  Contributions: The authors' contribution depends on the               *
 *  implementation of tasks                                               *
 *                                                                        *
 *                                                                        *
 *  Description: Contains functions that works with sql lite              *
 *  -> get function, connection function                                  *
 *                                                                        *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/
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

        /// <summary>
        /// Constructor with parameters
        /// Path for sqllite connection
        /// </summary>
        /// <param name="path"></param>
        public QuestionDAOService(string path)
        {
            _path = path;
        }

        /// <summary>
        /// Private method for creatting a database connection
        /// </summary>
        /// <returns>an open connection to database</returns>
        private SQLiteConnection CreateConnection()
        {
            SQLiteConnection con;
            con = new SQLiteConnection("Data Source=" + this._path + "; Version = 3; New = True; Compress = True; ");
            con.Open();
            return con;
        }

        /// <summary>
        /// Public method for getting questions by level from database
        /// </summary>
        /// <param name="level"></param>
        /// <returns>A list with 25 Question or null</returns>
        public List<QuestionModel> GetQuestions(int level)
        {
            List<QuestionModel> questionModels = new List<QuestionModel>();

            // creating connection
            SQLiteConnection con = CreateConnection();
            SQLiteCommand cmd;

            // creating command
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM QUESTIONS WHERE LEVEL=" + level + ";";

            // creating reader
            SQLiteDataReader dataReader;
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                // executing transaction
                questionModels.Add(new QuestionModel(dataReader.GetInt32(0),
                                                     dataReader.GetString(1),
                                                     dataReader.GetString(2),
                                                     dataReader.GetString(3),
                                                     dataReader.GetString(4),
                                                     dataReader.GetString(5),
                                                     dataReader.GetString(6),
                                                     dataReader.GetInt32(7)));
            }

            // closing database connection
            con.Close();

            return questionModels;
        }
    }
}
