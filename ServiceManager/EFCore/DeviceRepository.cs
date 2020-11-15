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
    public class DeviceRepository : Repository<Device, ServiceManagerContext>
    {
        private readonly ServiceManagerContext context;

        public DeviceRepository(ServiceManagerContext context) : base(context)
        {
            this.context = context;
        }

        public override async Task<Device> Get(Guid id)
        {
            return await context.Devices
                                .Include(x => x.DevicesFolder)
                                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
