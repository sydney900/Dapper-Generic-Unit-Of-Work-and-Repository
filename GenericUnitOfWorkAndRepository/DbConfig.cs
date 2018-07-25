﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericUnitOfWorkAndRepository
{
    public class DbConfig : IDbConfig
    {
        public string ProviderName { get; set; }
        public string ConnectionString { get; set; }
    }
}
