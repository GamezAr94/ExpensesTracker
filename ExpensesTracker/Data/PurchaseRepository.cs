using ExpensesTracker.Common.Expenses;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracker.Data
{
    class PurchaseRepository
    {
        private static readonly string connString = @"server = localhost; 
                                                      user id = root; 
                                                      database = expensestracker;";
        public static ExpensesList GetExpenses()
        {
            ExpensesList expensesList;
            using(MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = @"SELECT id_purchase, date_purchase, amount_purchase, category_purchase, info_purchase, notes_purchase, type_purchase
                                FROM purchase
                                ORDER BY id_purchase DESC;";
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    conn.Open();
                    expensesList = new ExpensesList();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        int id;
                        DateTime date;
                        decimal amount;
                        string category;
                        string info;
                        string notes = null;
                        string type;
                        while (reader.Read())
                        {
                            id = (int)reader["id_purchase"];
                            date =(DateTime)reader["date_purchase"];
                            amount = (decimal)reader[2];
                            category = reader[3] as string;
                            info = reader[4] as string;
                            notes = reader.IsDBNull(5) ? null : reader[5] as string;
                            type = reader[6] as string;
                            expensesList.Add(new Expenses()
                                            {
                                                Id = id,
                                                Date = date,
                                                Amount = amount,
                                                Category = category,
                                                Information = info,
                                                Notes = notes,
                                                Type = type
                                            });
                        }
                    }
                }
            }
            return expensesList;
        }
        public static int AddExpenses(Expenses expenses)
        {
            int rowsAffected;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = @"IF NOT EXISTS (SELECT * FROM purchase WHERE notes_purchase LIKE @notes AND date_purchase = @date AND amount_purchase = @amount AND category_purchase = @category AND info_purchase = @info)
                                THEN
                                    INSERT INTO purchase
                                    (date_purchase, amount_purchase, category_purchase, info_purchase, notes_purchase, type_purchase)
                                    VALUES(@date, @amount, @category, @info, @notes, @type);
                                END IF;";
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("date", expenses.Date);
                    cmd.Parameters.AddWithValue("amount", expenses.Amount);
                    cmd.Parameters.AddWithValue("category", expenses.Category);
                    cmd.Parameters.AddWithValue("info", expenses.Information);
                    cmd.Parameters.AddWithValue("notes", (object)expenses.Notes??DBNull.Value);
                    cmd.Parameters.AddWithValue("type", expenses.Type);
                    conn.Open();

                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }

        internal static int EditRecord(Expenses purchase)
        {
            int rowsAffected;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = $@"UPDATE purchase
                                  SET date_purchase = @date, 
                                    amount_purchase = @amount, 
                                    category_purchase = @category, 
                                    info_purchase = @info, 
                                    notes_purchase = @notes,
                                    type_purchase = @type
                                  WHERE id_purchase = @productId";
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("type", purchase.Type);
                    cmd.Parameters.AddWithValue("productId", purchase.Id);
                    cmd.Parameters.AddWithValue("date", purchase.Date);
                    cmd.Parameters.AddWithValue("amount", purchase.Amount);
                    cmd.Parameters.AddWithValue("category", purchase.Category);
                    cmd.Parameters.AddWithValue("info", purchase.Information);
                    cmd.Parameters.AddWithValue("notes", (object)purchase.Notes ?? DBNull.Value);

                    conn.Open();


                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }

        internal static int DeleteExpenses(Expenses purchase)
        {
            int rowsAffected;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = $@"DELETE FROM purchase
                                    WHERE id_purchase = @purchaseId;";
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.Parameters.AddWithValue("purchaseId", purchase.Id);

                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }
    }
}
