using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace FakeDataAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartsController : ControllerBase 
    {
        ICustomerList customers;

        public PartsController(ICustomerList cList) {
            customers = cList;
        }

        public PartsController() {
            Console.WriteLine("initializing customers.");
            customers = new ArrayList();
        }

        [HttpGet]
        public List<Customer> GetCustomersList() 
        {
            //Customer c1 = new Customer();
            //c1.CustID = 1;
            Console.WriteLine("customers list:");
            foreach (var customer in customers) {
                Console.WriteLine(customer.CustID + ", " + customer.Name);
            }
            return customers;
        }

        [HttpGet("{id}")]
        public Customer GetCustomer(int id) {
            Customer? c = null;
            foreach(var customer in customers) {
                if (customer.CustID == id) {
                    c = customer; 
                    break;
                }
            }
            return c;
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Customer value) {
            Console.WriteLine($"Customer {value.CustID}");
            customers.Add(value);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer value) {
            for (int i = 0; i < customers.Count; i++) {

                if (customers[i].CustID == value.CustID) {
                    customers[i] = value;
                }
            }
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
            for(int i = 0;i < customers.Count;i++) {
                if (customers[i].CustID == id) {
                    customers.RemoveAt(i);
                }
            }
        }
    }
}
