﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ExpensesTracker.Common.Members;

namespace ExpensesTracker.Data
{
    class MemberRepository
    {
        private static readonly string connString = @"server = localhost; 
                                                      user id = root; 
                                                      database = expensestracker;";
        public static Member LoginMember(string user, string pass)
        {
            Member activeMember = null;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = @"SELECT id_member, name_member, lastName_member, phone_member, type_member, profile_member, email_member, passwor_member
                                FROM members
                                WHERE (email_member LIKE @user OR profile_member LIKE @user) AND passwor_member LIKE @pass;";
                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("user", user);
                    cmd.Parameters.AddWithValue("pass", pass);

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
                            phone = reader.IsDBNull(3) ? null : reader["phone_member"] as string;
                            activeMember = new Member(){                                
                                Name = name,
                                LastName = lName,
                                Email = email,
                                Profile = profile,
                                Password = password,
                                Phone = phone,
                                Type = type,
                                ID = id,
                            };
                        }
                    }
                }
            }
            return activeMember;
        }
        
        public static MembersList GetMembers()
        {
            MembersList membersList;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = @"SELECT id_member, name_member, lastName_member, phone_member, type_member, profile_member, email_member, passwor_member
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
                            phone = reader.IsDBNull(3) ? null : reader["phone_member"] as string;
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
