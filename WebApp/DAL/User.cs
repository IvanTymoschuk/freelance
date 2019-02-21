using System;

namespace DAL
{
    public class User
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public bool IsEmployee { get; set; }
        public string AvaPath { get; set; }
        public double Raiting { get; set; }
    }
}
