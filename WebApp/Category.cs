using System;
using System.Collections.Generic;
using System.Text;

namespace DELETED
{
    public class Category
    {
        public Category()
        {
            jobs = new List<Job>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Job> jobs { get; set; }
    }
}
