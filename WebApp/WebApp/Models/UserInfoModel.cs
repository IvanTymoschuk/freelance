using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
namespace WebApp
{
    public class UserInfoModel
    {
        public UserInfoModel()
        {
            jobs = new List<Job>();
        }
        public DAL.User user { get; set; }
        public ICollection<Job> jobs {get;set;}
    }
}