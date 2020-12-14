using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContentManagement.Models;
using ContentManagement.Models.ContentManagement;

namespace ContentManagement.Data
{
    public class MysqlStoreContext
    {
        private string ConnectionString { get; set; }
        
        public MysqlStoreContext(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<UserModel> GetListOfUsers()
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                const string CmdString = "select * from user";
                List<UserModel> list = new List<UserModel>();
                MySqlCommand cmd = new MySqlCommand(CmdString, conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new UserModel()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            UserName = reader["UserName"].ToString(),
                            UserPassword = reader["UserPassword"].ToString(),
                        });
                    }
                }

                return list;
            }
        }

        public List<TextContentModel> GetListOfTextContent()
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                const string CmdString = "select * from textcontent";
                List<TextContentModel> list = new List<TextContentModel>();
                MySqlCommand cmd = new MySqlCommand(CmdString, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new TextContentModel()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Content = reader["Content"].ToString(),
                            ContentName = reader["Name"].ToString(),
                        });
                    }
                }

                return list;
            }

        }


        public TextContentModel FindTextContent(string cmdString, int? id)
        {
            TextContentModel textContent = new TextContentModel();
            if (id != null)
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(cmdString + id, conn);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            textContent = new TextContentModel()
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Content = reader["Content"].ToString(),
                                ContentName = reader["Name"].ToString(),
                            };
                        }
                        return textContent;
                    }
             
                }
           
            }
            
            return textContent;

        }



        public UserModel FindUser(string cmdString, int? id)
        {
            UserModel user = new UserModel();
            if (id != null)
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(cmdString + id, conn);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user = new UserModel()
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                UserName = reader["UserName"].ToString(),
                                UserPassword = reader["UserPassword"].ToString()
                            };
                        }
                        return user;
                    }

                }

            }

            return user;

        }


        public int? Edit(string cmdString, int? id)
        {
            if (id != null)
            {
                if (ConnectToDatabase())
                {
                    using (MySqlConnection conn = GetConnection())
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(cmdString, conn);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            return id;
        }

        public int? Delete(int? id)
        {

            if (id != null)
            {
                using (MySqlConnection conn = GetConnection())
                {
                    if (ConnectToDatabase())
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand($"DELETE FROM textcontent WHERE Id = {id}", conn);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            return id;
        }



        public void Add(TextContentModel text)
        {

            using (MySqlConnection conn = GetConnection())
            {
                if (ConnectToDatabase())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand($"INSERT INTO textcontent (Content,Name) VALUES ('{text.Content}', '{text.ContentName}')", conn);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        //checks if the string is correct or if connection can be done to database
        private bool ConnectToDatabase()
        {
            using (MySqlConnection l_oConnection = GetConnection())
            {
                try
                {
                    l_oConnection.Open();
                    return true;
                }
                catch (MySqlException)
                {
                    return false;
                }
            }
        }

    }
}
