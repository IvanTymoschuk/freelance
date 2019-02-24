using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Ticket
    {
        public Ticket()
        {
            ticketMSGs = new List<TicketMSG>();
        }
        public int ID { get; set; }
        public string Status { get; set; }
        public virtual User Owner { get; set; }
        public virtual ICollection<TicketMSG> ticketMSGs { get; set; }
        public DateTime LastUpdate { get; set; }
        public string Theme { get; set; }
    }

    public class TicketMSG
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public virtual Ticket ticket { get; set; }
        public int UserID { get; set; }
        public DateTime Date { get; set; }
    }

}
