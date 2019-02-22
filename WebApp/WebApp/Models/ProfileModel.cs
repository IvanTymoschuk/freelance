using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp
{
    public class ProfileModel
    {
        public ProfileModel()
        {
            selectListItems = new List<SelectListItem>();
        }
        public User user { get; set; }
        public ICollection<SelectListItem> selectListItems { get; set; }
        public int city_id { get; set; }
    }
}