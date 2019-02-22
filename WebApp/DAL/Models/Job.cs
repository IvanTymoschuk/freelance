using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Job
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public City City { get; set; }

        public Category Category { get; set; }
        public User  UserOwner { get; set; }
    }
}
