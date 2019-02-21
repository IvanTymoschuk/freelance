using System;
using System.Collections.Generic;
using System.Text;

namespace DELETED
{
    public class Job
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public virtual Category category { get; set; }
        public virtual User UserOwner { get; set; }
    }
}
