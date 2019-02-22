using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConfirmCode
    {
        public int ID { get; set; }
        public User user { get; set; }
        public int Code { get; set; }
    }
}
