using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class MyTicketsModel
    {
        public MyTicketsModel()
        {
            tickets = new List<Ticket>();
        }
        public ICollection<Ticket> tickets { get; set; }
        public int myId { get; set; }
    }
}