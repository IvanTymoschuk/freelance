using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class NewTicketModel
    {
        public Ticket ticket { get; set; }
        public TicketMSG mSG { get; set; }
        public int OwnerID { get; set; }
    }
}