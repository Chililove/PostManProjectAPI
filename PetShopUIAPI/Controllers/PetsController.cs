﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerApp.Core.ApplicationService;
using CustomerApp.Core.Entity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetShopUIAPI.Controllers
   
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        
        public PetsController(ICustomerService customerService) 
        {
            _customerService = customerService;
        }
        // GET: api/<PetsController>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customerService.GetAllCustomers();
        }
      

        // GET api/<PetsController>/5
        [HttpGet("{id}")]
        public Customer Get (int id)  
        {
            return _customerService.FindCustomerById(id);
        }

        // POST api/<PetsController>
        [HttpPost]
        public void Post([FromBody] Customer customer)
        {
            _customerService.CreateCustomer(customer);
        }

        // PUT api/<PetsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PetsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
