﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceManager.Data
{
    public interface IEntity
    {
        public Guid Id { get; set; }
        //public string Editor { get; set; }
    }
}
