﻿using System;
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
        private IModelController _modelController;

        public UserDAOService(IModelController modelController, string path)
        {
            _modelController = modelController;
            _path = path;
        }

        private SQLiteConnection CreateConnection()
        {
            SQLiteConnection con;
            con = new SQLiteConnection("Data Source=" + this._path + "; Version = 3; New = True; Compress = True; ");
            con.Open();
            return con;
        }

        /// <summary>
        /// Return null if user doesn`t exists
        /// </summary>
        /// <param name="username"></param>
        /// <returns>null or user</returns>
        public UserModel GetUser(string username)
        {
            SQLiteConnection con = CreateConnection();
            SQLiteCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM USERS WHERE USERNAME='" + username + "';";

            SQLiteDataReader dataReader;
            UserModel userModel = null;
            try
            {
                dataReader = cmd.ExecuteReader();
                dataReader.Read();
                userModel = new UserModel(dataReader.GetInt32(0),
                                                    dataReader.GetString(1),
                                                    dataReader.GetString(2),
                                                    dataReader.GetString(3));
            }
            catch (Exception e)
            {
                Console.WriteLine("Utilizatorul nu exista. Se va returna null");
            }
            con.Close();
            return userModel;
        }

        public bool InsertUser(UserModel userModel)
        {
            bool result;
            SQLiteConnection con = CreateConnection();
            SQLiteCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO USERS(USERNAME, PASSWORD, EVOLUTION) VALUES('" + userModel.Username + "', '"
                                                                                             + userModel.Password + "', '"
                                                                                             + userModel.Evolution + "');";
            try
            {
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception e)
            {
                result = false;
            }
            con.Close();
            return result;
        }

        public bool UpdatePassword(UserModel userModel, string newPassword)
        {
            if (newPassword.Equals(""))
            {
                return false;
            }
            bool result;
            SQLiteConnection con = CreateConnection();
            SQLiteCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE USERS SET PASSWORD='" + newPassword + "' WHERE USERNAME='" + userModel.Username + "';";
            try
            {
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception e)
            {
                result = false;
            }
            con.Close();
            return result;
        }

        public bool UpdateEvolution(string username, string newEvolution)
        {
            if (newEvolution.Equals(""))
            {
                return false;
            }
            bool result;
            SQLiteConnection con = CreateConnection();
            SQLiteCommand cmd;
            cmd = con.CreateCommand();
            try
            {
                cmd.CommandText = "UPDATE USERS SET EVOLUTION='" + newEvolution + "' WHERE USERNAME='" + username + "';";
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception e)
            {
                result = false;
            }
            con.Close();
            return result;
        }

        public string GetEvolution(string username)
        {
            SQLiteConnection con = CreateConnection();
            SQLiteCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT EVOLUTION FROM USERS WHERE USERNAME='" + username + "';";

            SQLiteDataReader dataReader;
            try
            {
                dataReader = cmd.ExecuteReader();
                dataReader.Read();
                string evolution = dataReader.GetString(0);
                dataReader.Close();
                con.Close();
                return evolution;
            }
            catch (Exception e)
            {
                Console.WriteLine("Utilizatorul nu exista. Se va returna null");
            }
            con.Close();
            return "";
        }

        public List<UserModel> GetUserRankings()
        {
            List<UserModel> userModelsRanking = new List<UserModel>();

            SQLiteConnection con = CreateConnection();
            SQLiteCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT USERNAME, EVOLUTION FROM USERS;";

            SQLiteDataReader dataReader;
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                userModelsRanking.Add(new UserModel(0,
                                                    dataReader.GetString(0),
                                                    null,
                                                    dataReader.GetString(1)));
            }
            con.Close();

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

        public bool DeleteUser(UserModel userModel)
        {
            bool result;
            SQLiteConnection con = CreateConnection();
            SQLiteCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM USERS WHERE USERNAME='" + userModel.Username + "';";
            try
            {
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception e)
            {
                result = false;
            }
            con.Close();
            return result;
        }
    }
}
