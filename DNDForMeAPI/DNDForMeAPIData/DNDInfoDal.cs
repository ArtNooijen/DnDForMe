using DNDForMeAPIInterface.DTO;
using DNDForMeAPIInterface.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDForMeAPIData
{
    public class DNDInfoDal : IDNDInfocollection
    {
        public List<DNDInfoDTO> GetAllDNDInfos()
        {
            List<DNDInfoDTO> dNDInfoDTOs = new();

            string query = "SELECT b.Id, , b.Name, b.Description, b.Note";
            query += "FROM info as b ";
            

            using (MySqlCommand cmd = new(query))
            {
                var conn = DbConnectDal.DBConnect();
                cmd.Connection = conn;
                conn.Open();
                using MySqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    DNDInfoDTO dNDInfoDTO = new();
                    dNDInfoDTO.Id = sdr.GetInt32("Id");
                    foreach (var item in dNDInfoDTOs)
                    {
                        if (dNDInfoDTO.Id == item.Id)
                        {
                            dNDInfoDTO = item;
                        }
                    }
                    if (dNDInfoDTO.Name == null)
                    {
                        dNDInfoDTO.Name = sdr.GetString("Name");
                        dNDInfoDTO.Description = sdr.GetString("Description");
                        dNDInfoDTO.Note = sdr.GetString("Note");

                        dNDInfoDTOs.Add(dNDInfoDTO);
                    }
                 
                }
                conn.Close();
            };
            return dNDInfoDTOs;
        }

        public DNDInfoDTO GetDNDInfo(int Id)
        {
            DNDInfoDTO dNDInfoDTO = new();
            string query = $"SELECT * FROM `info` WHERE Id= @Id";
            using (MySqlCommand cmd = new(query))
            {
                var conn = DbConnectDal.DBConnect();
                cmd.Connection = conn;
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", Id);

                using MySqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    dNDInfoDTO.Id = Convert.ToInt32(sdr["Id"]);
                    dNDInfoDTO.Name = sdr["Name"].ToString();
                    dNDInfoDTO.Description = sdr["Description"].ToString();
                    dNDInfoDTO.Note = sdr["Note"].ToString();
                   

                }
                conn.Close();
            }
            return dNDInfoDTO;
        }

        public void UpdateDNDInfo(DNDInfoDTO dNDInfoDTO)
        {
            string query = $"UPDATE `info` SET Name=@Name,Description=@Description,Note=@Note WHERE Id=@Id";

            using (MySqlCommand cmd = new(query))
            {
                var conn = DbConnectDal.DBConnect();
                cmd.Connection = conn;
                conn.Open();
                cmd.Parameters.AddWithValue("@Name", dNDInfoDTO.Name);
                cmd.Parameters.AddWithValue("@Description", dNDInfoDTO.Description);
                cmd.Parameters.AddWithValue("@Note", dNDInfoDTO.Note);
              
                cmd.ExecuteNonQuery();

                conn.Close();
            };
        }

        public void CreateDNDInfo(DNDInfoDTO dNDInfoDTO, int UserId)
        {
            string query = "INSERT INTO `info`(`Name`, `Description`, `Note`, `UserId`) VALUES (@Name,@Description,@Note,@UserId)";
       

            using MySqlConnection conn = DbConnectDal.DBConnect();
            MySqlCommand cmd = new(query);
            cmd.Connection = conn;
            conn.Open();
            cmd.Parameters.AddWithValue("@Name", dNDInfoDTO.Name);
            cmd.Parameters.AddWithValue("@Description", dNDInfoDTO.Description);
            cmd.Parameters.AddWithValue("@Note", dNDInfoDTO.Note);
            cmd.Parameters.AddWithValue("@UserId", UserId);
            cmd.ExecuteNonQuery();
            int id = (int)cmd.LastInsertedId;          
         
         
            conn.Close();
        }

        public void DeleteDNDInfo(DNDInfoDTO dNDInfoDTO)
        {
            string query = "Delete FROM info WHERE Id= @Id ";
            using (MySqlCommand cmd = new(query))
            {
                var conn = DbConnectDal.DBConnect();
                cmd.Connection = conn;
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", dNDInfoDTO.Id);
                cmd.ExecuteNonQuery();
                conn.Close();
            };
        }

        public List<DNDInfoDTO> GetDNDIfnoData()
        {
            List<DNDInfoDTO> dNDInfoDTOs = new();

            string query = "SELECT b.Id, b.Title, b.ISBN, b.Genre, b.MaxPageNumber, b.CurrentPageNumber, b.Rating, a.AuteurId, a.FirstName, a.LastName " +
                "FROM book as b " +
                "LEFT JOIN bookauteur as ba ON ba.BookId = b.Id " +
                "LEFT JOIN auteur as a ON a.AuteurId = ba.AuteurId";

            using (MySqlCommand cmd = new(query))
            {
                var conn = DbConnectDal.DBConnect();
                cmd.Connection = conn;
                conn.Open();
                using MySqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    DNDInfoDTO dNDInfoDTO = new();
                    dNDInfoDTO.Id = sdr.GetInt32("Id");
                    foreach (var item in dNDInfoDTOs)
                    {
                        if (dNDInfoDTO.Id == item.Id)
                        {
                            dNDInfoDTO = item;
                        }
                    }
                    if (dNDInfoDTO.Name == null)
                    {
                        dNDInfoDTO.Name = sdr.GetString("Name");
                        dNDInfoDTO.Description = sdr.GetString("Description");
                        dNDInfoDTO.Note = sdr.GetString("Note");
                        dNDInfoDTOs.Add(dNDInfoDTO);
                    }
                  
                }
                conn.Close();
            };
            return dNDInfoDTOs;
        }
    }
}
