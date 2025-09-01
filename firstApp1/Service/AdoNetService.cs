using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstApp1.Service
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string PersonalInformation { get; set; } = null;
    }

    public class AdoNetService
    {

        public void Execute()
        {
            var connectionString = @"Data Source=RAJAN\LOCALHOST;Initial Catalog=farmer_mangment;Integrated Security=True;";
            using (var connection = new SqlConnection(connectionString))
            {
                var users = new List<User>();

                var userCommand = new SqlCommand("SELECT * FROM Seller", connection);

                connection.Open();

                using (var userReader = userCommand.ExecuteReader())
                {
                    while (userReader.Read())
                    {
                        users.Add(new User
                        {
                            Id = userReader.GetInt32(0),
                            Name = userReader.GetString(1),
                            Address = userReader.GetString(2),
                            Gender = userReader.GetString(3),
                            PersonalInformation = userReader.IsDBNull(4) ? null : userReader.GetString(4)
                        });
                    }
                }
            }
        }
    }
}
