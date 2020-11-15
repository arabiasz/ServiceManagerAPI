using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServiceManager.Data;
using ServiceManager.EFCore;
using ServiceManager.Models;

namespace ServiceManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : DbController<Category, CategoryRepository>
    {
        private readonly CategoryRepository repository;

        public CategoriesController(CategoryRepository repository) :  base(repository)
        {
            this.repository = repository;
        }
    }
}
