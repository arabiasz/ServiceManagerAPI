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
    public class DevicesController : DbController<Device, DeviceRepository>
    {
        private readonly DeviceRepository repository;

        public DevicesController(DeviceRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
