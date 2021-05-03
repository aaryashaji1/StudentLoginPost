using StudentLoginPost.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentLoginPost.Controllers
{
    public class StudentController : ApiController
    {

        String connectionString = "Server=ARYASHAJI\\SQLEXPRESS;Database=PersonManagement;Trusted_Connection=True;";
        [HttpPost]
        public Student StudentLogin(Student student)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("StudentLogin", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("Username", student.Username);
            command.Parameters.AddWithValue("Password", student.Password);


            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            
            student.Id = Convert.ToInt32(reader["Id"]);
            student.Age = Convert.ToInt32(reader["Age"]);
            student.Name = reader["Name"].ToString();
            student.Place = reader["Place"].ToString();

            reader.Close();
            connection.Close();
            return student;
        }
    }
}

