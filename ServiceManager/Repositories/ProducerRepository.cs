using ServiceManager.Data;
using ServiceManager.EFCore;
using ServiceManagerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceManagerAPI.EFCore
{
    public class ProducerRepository : Repository<Producer, ServiceManagerContext>
    {
        private readonly ServiceManagerContext context;

        public ProducerRepository(ServiceManagerContext context) : base(context)
        {
            this.context = context;
        }
    }
}
