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

        public int CategoryID { get; set; }
        public int  UserOwnerID { get; set; }
    }
}
