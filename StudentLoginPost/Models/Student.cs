using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentLoginPost.Models
{
    public class Student
    {

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Place { get; set; }
    }
}