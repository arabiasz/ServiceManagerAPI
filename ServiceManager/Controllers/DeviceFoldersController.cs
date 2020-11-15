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
    public class DeviceFoldersController : DbController<DevicesFolder, DeviceFolderRepository>
    {
        private readonly DeviceFolderRepository repository;

        public DeviceFoldersController(DeviceFolderRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
