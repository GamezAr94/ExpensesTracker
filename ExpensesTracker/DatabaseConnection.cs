using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ExpensesTracker.Members;

namespace ExpensesTracker
{
    class DatabaseConnection
    {
        private static readonly string connString = "server = localhost; user id = root; database = expensestracker;";
        public static MembersList InitializingMembers()
        {
            MembersList membersList;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = @"SELECT *
                                FROM members;";
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    membersList = new MembersList();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        string name;
                        string lName;
                        string email;
                        string profile;
                        string password;
                        string phone;
                        string type;
                        int id;
                        while (reader.Read())
                        {
                            name = reader["name_member"] as string;
                            lName = reader["lastName_member"] as string;
                            email = reader["email_member"] as string;
                            profile = reader["profile_member"] as string;
                            password = reader["passwor_member"] as string;
                            type = reader["type_member"] as string;
                            id = (int)reader["id_member"];
                            // phone = reader.IsDBNull(7) ? null : reader["phone_members"] as string;
                            phone = "58";
                            membersList.Add(new Member()
                            {
                                Name = name,
                                LastName = lName,
                                Email = email,
                                Profile = profile,
                                Password = password,
                                Phone = phone,
                                Type = type,
                                ID= id,
                            });
                        }
                    }
                }
            }
            return membersList;
        }
    }
}
