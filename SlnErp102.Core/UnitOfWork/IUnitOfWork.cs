﻿using SlnErp102.Core.Repository.Stocks.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnErp102.Core.UnitOfWork
{
    public interface IUnitOfWork
    {
        IProductEntryRepository ProductEntryRepo { get; }
        Task CommitAsync();
        void Commit();
    }
}
