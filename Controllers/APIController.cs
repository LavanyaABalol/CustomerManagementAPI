using CustomerManagementAPI.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowOrigin")]
    [ApiController]
    public class APIController : ControllerBase
    {
        // GET: api/<APIController>
        [HttpGet]
        public string Get()
        {

            DbHandleCustomer db = new DbHandleCustomer();
            return db.customerList();

        }

        // GET api/<APIController>/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {

            DbHandleCustomer db = new DbHandleCustomer();
            return db.getCustomerById(id);
        }

        // POST api/<APIController>
        [HttpPost]
        public void Post(Customer c)
        {
            DbHandleCustomer db = new DbHandleCustomer();
            db.addCustomer(c);

        }

        // PUT api/<APIController>/5
        [HttpPut]
        public void Put(Customer c)
        {
            DbHandleCustomer db = new DbHandleCustomer();
            db.updateCustomer(c);
        }

        // DELETE api/<APIController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
                DbHandleCustomer db=new DbHandleCustomer();
            return db.deleteCustomer(id);

        }
    }
}
