using Microsoft.EntityFrameworkCore;
using ServiceManager.Data;
using ServiceManager.EFCore;
using ServiceManagerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceManagerAPI.EFCore
{
    public class DeviceFolderRepository : Repository<DevicesFolder, ServiceManagerContext>
    {
        private readonly ServiceManagerContext context;

        public DeviceFolderRepository(ServiceManagerContext context) : base(context)
        {
            this.context = context;
        }

        public override async Task<DevicesFolder> Get(Guid id)
        {
            return await context.DevicesFolder
                                .Include(x => x.Category)
                                .Include(p => p.Producer)
                                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
