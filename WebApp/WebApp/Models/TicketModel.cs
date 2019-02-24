using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class TicketModel
    {
        public TicketModel()
        {
            ticketMSGs = new List<TicketMSG>();
        }
        public Ticket ticket { get; set; }
        public ICollection<TicketMSG> ticketMSGs { get; set; }
        public TicketMSG mSG { get; set; }
        public int uid { get; set; }
    }
}