/**************************************************************************
 *                                                                        *
 *  File:        UserDaoService.cs                                        *
 *  Atuhors:     Baciu H. Alexandru, Corduneanu Vlad, Haralamb Marian     *
 *  Contributions: The authors' contribution depends on the               *
 *  implementation of tasks                                               *
 *                                                                        *
 *                                                                        *
 *  Description: Contains functions that works with sql lite              *
 *  -> get function, connection function, update function,                *
 *  delete function, insert function                                      *
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
    public class UserDAOService : IUserDAO
    {
        private string _path;

        /// <summary>
        /// Constructor with parameters
        /// Path for sqllite connection
        /// </summary>
        /// <param name="modelController"></param>
        /// <param name="path"></param>
        public UserDAOService(string path)
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
        /// Public method for getting an user object from database
        /// </summary>
        /// <param name="username"></param>
        /// <returns>null or user</returns>
        public UserModel GetUser(string username)
        {
            UserModel userModel = null;

            // creating connection
            SQLiteConnection con = CreateConnection();
            SQLiteCommand cmd;

            // creating command
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM USERS WHERE USERNAME='" + username + "';";

            // creating reader
            SQLiteDataReader dataReader;

            try
            {
                // executing transaction
                dataReader = cmd.ExecuteReader();
                dataReader.Read();
                userModel = new UserModel(dataReader.GetInt32(0),
                                                    dataReader.GetString(1),
                                                    dataReader.GetString(2),
                                                    dataReader.GetString(3));
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                Console.WriteLine("Utilizatorul nu exista. Se va returna null");
            }

            // closing database connection
            con.Close();

            return userModel;
        }

        /// <summary>
        /// Public method for inserting an user into database
        /// </summary>
        /// <param name="userModel"></param>
        /// <returns>true for successful operation</returns>
        public bool InsertUser(UserModel userModel)
        {
            bool result;

            // creating connection
            SQLiteConnection con = CreateConnection();
            SQLiteCommand cmd;

            // creating command
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO USERS(USERNAME, PASSWORD, EVOLUTION) VALUES('" + userModel.Username + "', '"
                                                                                             + userModel.Password + "', '"
                                                                                             + userModel.Evolution + "');";

            // executing transaction
            try
            {
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                result = false;
            }

            // closing database connection
            con.Close();

            return result;
        }

        /// <summary>
        /// Public method for updating user password
        /// </summary>
        /// <param name="userModel"></param>
        /// <param name="newPassword"></param>
        /// <returns>true for successful operation</returns>
        public bool UpdatePassword(UserModel userModel, string newPassword)
        {
            if (newPassword.Equals(""))
            {
                return false;
            }
            bool result;

            // creating connection
            SQLiteConnection con = CreateConnection();
            SQLiteCommand cmd;

            // creating command
            cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE USERS SET PASSWORD='" + newPassword + "' WHERE USERNAME='" + userModel.Username + "';";

            // executing transaction
            try
            {
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                result = false;
            }

            // closing database connection
            con.Close();

            return result;
        }

        /// <summary>
        /// Public method for updating user score
        /// </summary>
        /// <param name="username"></param>
        /// <param name="newEvolution"></param>
        /// <returns>true for successful operation</returns>
        public bool UpdateEvolution(string username, string newEvolution)
        {
            if (newEvolution.Equals(""))
            {
                return false;
            }
            bool result;

            // creating connection
            SQLiteConnection con = CreateConnection();
            SQLiteCommand cmd;

            // creating command
            cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE USERS SET EVOLUTION='" + newEvolution + "' WHERE USERNAME='" + username + "';";

            try
            {
                // executing transaction
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                result = false;
            }

            // closing database connection
            con.Close();

            return result;
        }

        /// <summary>
        /// Public method for getting the user score
        /// </summary>
        /// <param name="username"></param>
        /// <returns>score for succes or "" for fail</returns>
        public string GetEvolution(string username)
        {
            // creating connection
            SQLiteConnection con = CreateConnection();
            SQLiteCommand cmd;

            // creating command
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT EVOLUTION FROM USERS WHERE USERNAME='" + username + "';";

            // creating reader
            SQLiteDataReader dataReader;
            try
            {
                // executing transaction
                dataReader = cmd.ExecuteReader();
                dataReader.Read();

                string evolution = dataReader.GetString(0);
                dataReader.Close();

                // closing database connection
                con.Close();

                return evolution;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }

            // closing database connection
            con.Close();

            return "";
        }

        /// <summary>
        /// Public method that returns leaderboard
        /// </summary>
        /// <returns>a sorted list by score with users</returns>
        public List<UserModel> GetUserRankings()
        {
            List<UserModel> userModelsRanking = new List<UserModel>();

            // creating connection
            SQLiteConnection con = CreateConnection();
            SQLiteCommand cmd;

            // creating command
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT USERNAME, EVOLUTION FROM USERS;";

            // creating reader
            SQLiteDataReader dataReader;
            dataReader = cmd.ExecuteReader();

            // adding each use in List
            while (dataReader.Read())
            {
                userModelsRanking.Add(new UserModel(0,
                                                    dataReader.GetString(0),
                                                    null,
                                                    dataReader.GetString(1)));
            }

            // closing database connection
            con.Close();

            // using bubblesort for sorting by score the result
            for (int i = 0; i < userModelsRanking.Count; i++)
            {
                int swaps = 0;
                for (int j = 0; j < userModelsRanking.Count - i - 1; j++)
                {
                    if (Convert.ToInt32(userModelsRanking[j].Evolution) < Convert.ToInt32(userModelsRanking[j + 1].Evolution))
                    {
                        UserModel aux = new UserModel(0, userModelsRanking[j].Username, null, userModelsRanking[j].Evolution);
                        userModelsRanking[j] = userModelsRanking[j + 1];
                        userModelsRanking[j + 1] = aux;
                        swaps++;
                    }
                }
                if (swaps == 0)
                    break;
            }

            return userModelsRanking;
        }

        /// <summary>
        /// Public method for deleting user from database
        /// </summary>
        /// <param name="userModel"></param>
        /// <returns>return true for succesful operation</returns>
        public bool DeleteUser(UserModel userModel)
        {
            bool result;

            // creating connection
            SQLiteConnection con = CreateConnection();
            SQLiteCommand cmd;

            // creating command
            cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM USERS WHERE USERNAME='" + userModel.Username + "';";

            // executing transaction
            try
            {
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                result = false;
            }

            // closing database connection
            con.Close();

            return result;
        }
    }
}
