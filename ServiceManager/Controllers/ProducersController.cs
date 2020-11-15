using Microsoft.AspNetCore.Mvc;
using ServiceManager.Controllers;
using ServiceManagerAPI.EFCore;
using ServiceManagerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProducersController : DbController<Producer, ProducerRepository>
    {
        private readonly ProducerRepository repository;

        public ProducersController(ProducerRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
