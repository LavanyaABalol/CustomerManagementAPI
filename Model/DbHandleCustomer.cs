using Newtonsoft.Json;
using System.Linq;

namespace CustomerManagementAPI.Model
{
    public class DbHandleCustomer
    {
        public EFContext Context=new EFContext();

        public bool addCustomer(Customer c)
        {
            c.CreatedDate = DateTime.Now;
           Context.Customers.Add(c);
            Context.SaveChanges();
            return true;
        }

        public bool deleteCustomer(int id)
        {
            Customer customer = Context.Customers.Find(id);
            Context.Customers.Remove(customer);
            Context.SaveChanges();
            return true;
        }

        public void updateCustomer(Customer c)
        {
            Customer cr = new Customer();
            cr = Context.Customers.Find(c.CustomerId);

            cr.CustomerLName=c.CustomerLName;
            cr.CustomerFName=c.CustomerFName;
         //   cr.CreatedDate=c.CreatedDate;   
            cr.Country=c.Country;
            Context.SaveChanges();

            return;
        }

        public Customer getCustomerById(int id)
        {
            return Context.Customers.Find(id);
        }

        public string customerList()
        {
            return JsonConvert.SerializeObject(Context.Customers.ToList());
        }

    }
}
