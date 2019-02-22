using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class JobsListModel
    {
        public List<DAL.Job> jobs { get; set; }
        public List<DAL.Category> Categories { get; set; }
        public List<DAL.City> Cities { get; set; }


    }
}