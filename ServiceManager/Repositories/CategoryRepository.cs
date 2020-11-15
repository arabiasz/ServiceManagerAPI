using ServiceManager.Data;
using ServiceManager.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ServiceManager.EFCore
{
    public class CategoryRepository : Repository<Category, ServiceManagerContext>
    {
        private readonly ServiceManagerContext context;

        public CategoryRepository(ServiceManagerContext context) : base(context)
        {
            this.context = context;
        }

        //public override async Task<Category> Add(Category entity)
        //{
        //    try
        //    {
        //        var result = context.Category.Any(x => x.Name.Equals(entity.Name));
        //        if (!result)
        //        {
        //            entity.Editor = Environment.UserName;

        //            return await base.Add(entity);
        //        }
        //        else
        //        {
        //            // hard code string or get model property name via reflection etc
        //            // Or if you want a general error you can use string.Empty as the key name and display via the validation summary
        //            //   ModelState.AddModelError("Name", "Name must be unique");

        //            // Fall through and return error 
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }

        //    return entity;
        //}

    }
}
