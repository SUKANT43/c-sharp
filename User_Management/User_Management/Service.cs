using System;
using MySql.Data.MySqlClient;

namespace User_Management
{
    class Service
    {
        //add user
        public static void AddUser(string name, string email, int age)
        {
            using (MySqlConnection conn = new MySqlConnection(Config.connString))
            {
                conn.Open();

                string query = "INSERT INTO users(name, email, age) VALUES (@name, @email, @age)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@age", age);

                    cmd.ExecuteNonQuery();
                    Console.WriteLine("✅ User added successfully!");
                }
            }
        }

        //get user
        public static void GetUserData()
        {
            using(MySqlConnection conn=new MySqlConnection(Config.connString))
            {
                conn.Open();
                string query = "SELECT * FROM users";
                using(MySqlCommand cmd=new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"ID: {reader["id"]}, Name: {reader["name"]}, Email: {reader["email"]}, Age: {reader["age"]}");
                        }
                    }
                }
            }
        }

        //update user
        public static void UpdateUser(int id, string newName,string email, int newAge)
        {
            using (MySqlConnection conn = new MySqlConnection(Config.connString))
            {
                conn.Open();
                string query = "UPDATE users SET name=@name, age=@age, email=@email WHERE id=@id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", newName);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@age", newAge);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Your data updated successfully");
                }
            }
        }

        //delete User
        public static void DeleteUser(int id)
        {
            using(MySqlConnection conn=new MySqlConnection(Config.connString))
            {
                conn.Open();
                string query = "DELETE FROM users WHERE id=@id";
                using(MySqlCommand cmd=new MySqlCommand(query,conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("User data deleted successfully!");
                }
            }
        }
    }
}
