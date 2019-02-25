using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class SupportController : Controller
    {
        // GET: Support
      
        public ActionResult Ticket(int id, int ticket)
        {
            using (Context ctx = new Context())
            {
                TicketModel model = new TicketModel();
                model.ticket = ctx.Tickets.FirstOrDefault(x => x.ID == ticket);
                model.uid = id;
                model.ticketMSGs = ctx.TicketMSGs.Where(x => x.ticket == ctx.Tickets.FirstOrDefault(y => y.ID == ticket)).ToList();
                model.mSG = new DAL.Models.TicketMSG();
                return View(model);
            }
        }
        public ActionResult CloseTicket(int id)
        {
            using (Context ctx = new Context())
            {
                ctx.Tickets.FirstOrDefault(x => x.ID == id).Status = "Close";
                ctx.SaveChanges();
            }
            return Redirect("/");
        }
        public ActionResult MyTickets(int id)
        {
            using (Context ctx = new Context())
            {
                MyTicketsModel model = new MyTicketsModel();
                model.tickets = ctx.Tickets.Where(x => x.Owner.ID == id).ToList();
                model.myId = id;
                return View(model);
            }

        }
        public ActionResult NewTicket(int id)
        {
            NewTicketModel model = new NewTicketModel();
            model.mSG = new DAL.Models.TicketMSG();
            model.ticket = new DAL.Models.Ticket();
            model.OwnerID = id;
            return View(model);

        }
        [HttpPost]
        public ActionResult NewTicket(NewTicketModel model)
        {
            using (Context ctx = new Context())
            {
                var ticket = new DAL.Models.Ticket()
                {
                    LastUpdate = DateTime.Now,
                    Status = "Open",
                    Owner = ctx.Users.FirstOrDefault(x => x.ID == model.OwnerID),
                    Theme = model.ticket.Theme,
                };
                ctx.TicketMSGs.Add(new DAL.Models.TicketMSG() { ticket = ticket, Text = model.mSG.Text, Date = DateTime.Now, UserID = model.OwnerID });
                ctx.SaveChanges();
            }
            return Redirect("/support/mytickets/" + model.OwnerID);
        }
    }
}