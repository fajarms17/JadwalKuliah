namespace DataModel
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DataContext : DbContext
    {
        // Your context has been configured to use a 'DataContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DataModel.DataContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DataContext' 
        // connection string in the application configuration file.
        public DataContext()
            : base("name=DataContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Kelas> Kelas { get; set; }
        public virtual DbSet<Dosen> Dosen { get; set; }
        public virtual DbSet<MataKuliah> MataKuliah { get; set; }
        public virtual DbSet<Hari> Hari { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}