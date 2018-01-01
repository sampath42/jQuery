using System;
using System.Collections.Generic;
using jQuery_Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace jQuery_Demo.Controllers
{
    public class HomeController : Controller
    {
        // [Route("home/index")]
        // public IActionResult Index()
        // {
        //     return Ok("Hello World from a controller");
        // }

        [Route("home/greet/{username}")]
        public IActionResult Greet(string username)
        {
            var greeting = new Greeting { Username = username };
            return Ok(greeting);
        }   

        [Route("home/index")]
        public IActionResult Index(string username)
        {
            return View(new Greeting { Username = username });
        }   

        [Route("home/InsertCustomer")]
        public IActionResult InsertCustomer(Customer cust)
        {
            return Ok(cust);
        }

        [Route("home/GetCustomerById")]
        public IActionResult GetCustomerById(int id)
        {            
            var customer = new Customer(){ Id=id, FirstName="Sampath", LastName="Bingi" };
            return Ok(customer);
        }

        [Route("home/GetCustomers")]
        public IActionResult GetCustomers()
        {
            List<Customer> customersList = new List<Customer>();
            for(int i=0;i<10;i++)
            {
                customersList.Add(new Customer(){Id=1,FirstName=$"{i} First Name",LastName=$"{i} Last Name"});
            }
            
            return Ok(customersList);
        }
    }
}