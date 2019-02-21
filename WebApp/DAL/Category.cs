using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Category
    {
        public Category()
        {
            JoobsID = new List<int>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public  ICollection<int> JoobsID { get; set; }
    }
}
