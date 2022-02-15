using Microsoft.EntityFrameworkCore;



namespace CustomerManagementAPI.Model
{
    public class EFContext: DbContext
    {

        private string conn = "Server=APBALOL;Database=API_CustomerDManagement;Trusted_Connection=True;";

   
        protected override void OnConfiguring(DbContextOptionsBuilder ob)
        {
            ob.UseSqlServer(conn);
        }
           

        public DbSet<Customer> Customers { get; set;}
        public DbSet<Address> AddressT { get; set;}


    }
}
