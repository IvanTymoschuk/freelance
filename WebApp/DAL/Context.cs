namespace DAL
{
    using System;
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
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<User> Users { get; set; }
         public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
    }
    class MyContextInitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context db)
        {

            db.Users.Add(new User { AvaPath = null, ID=1, City = "RIVNE", Email = "Freak@team.com", FullName = "Freak Admin Lox", IsEmployee = false, Password = "Admin", Raiting = 1 });
            db.Users.Add(new User { AvaPath = null, City = "RIVNE", Email = "Vadim@team.com", FullName = "Vadim Designer GG", IsEmployee = true, Password = "Pass", Raiting = 1 });
            db.Categories.Add(new Category { Name = "IT",ID=1 });
            db.Jobs.Add(new Job { Name = "C# DEV", CategoryID = 1, Date = DateTime.Now, Description = "Create course work", Salary = 9999, UserOwnerID = 1 });
            db.SaveChanges();
        }
    }
    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}