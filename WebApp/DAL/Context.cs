namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class Context : DbContext
    {
        // Your context has been configured to use a 'Context' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DAL.Context' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Context' 
        // connection string in the application configuration file.
        public Context()
            : base("name=Context")
        {
            Database.SetInitializer(new MyContextInitializer());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<User> Users { get; set; }
         public virtual DbSet<Job> Jobs { get; set; }
         public virtual DbSet<Category> Categories { get; set; }
         public virtual DbSet<ConfirmCode> ConfirmCodes { get; set; }
        public virtual DbSet<City> Cities { get; set; }

    }
    class MyContextInitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context db)
        {
            IList<User> users = new List<User>();
            IList<Job> jobs = new List<Job>();

            var city = new City() { Name = "Rivne" };


            users.Add(new User() { AvaPath = null, City = city, Email = "Freak@team.com", FullName = "Freak Admin Lox", IsEmployee = false, Password = "Admin", Raiting = 1 });
            users.Add(new User() { AvaPath = null, City = city, Email = "Vadim@team.com", FullName = "Vadim Designer GG", IsEmployee = true, Password = "Pass", Raiting = 1 });
          

            var cat= new Category() { Name = "IT" };
           
           jobs.Add(new Job() { Name = "C# DEV",Category = cat,City = city, Date = DateTime.Now, Description = "Create course work", Salary = 9999 });

            db.Users.AddRange(users);
            db.Jobs.AddRange(jobs);
            db.SaveChanges();
        }
    }
    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}