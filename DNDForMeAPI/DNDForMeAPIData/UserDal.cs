using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DNDForMeAPIInterface.Interfaces;
using DNDForMeAPIInterface.DTO;


using MySql.Data.MySqlClient;

namespace DNDForMeAPIData
{
    public class UserDal : IUser , IUserCollection
    {
        
        public List<UserDto> GetAllUsers()
        {
            List<UserDto> userDtos = new List<UserDto>();


            string query = "SELECT * FROM `user`";
            using (MySqlCommand cmd = new MySqlCommand(query))
            {
                var conn = DbConnectDal.DBConnect();
                cmd.Connection = conn;
                conn.Open();
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        userDtos.Add(new UserDto
                        {
                            Id = Convert.ToInt32(sdr["Id"]),
                            Username = sdr["Username"].ToString(),
                            Password = sdr["password"].ToString(),
                            Email = sdr["Email"].ToString(),
                        });
                    }
                    conn.Close();
                }
            };
            return userDtos;
        }
    }
}
