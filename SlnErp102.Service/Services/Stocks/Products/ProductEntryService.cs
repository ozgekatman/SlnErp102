﻿using SlnErp102.Core.Models.Stocks.Products;
using SlnErp102.Core.Service.Stocks.Products;
using SlnErp102.Core.Repository;
using SlnErp102.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnErp102.Service.Services.Stocks.Products
{
    public class ProductEntryService : Service<ProductEntry>, IProductEntryService
    {
        public ProductEntryService(IUnitOfWork unitOfWork, IRepository<ProductEntry> repository) : base(unitOfWork, repository)
        {

        }

        public async Task<IEnumerable<ProductEntry>> DistinctListByCompany()
        {
            return await _unitOfWork.ProductEntryRepo.DistinctListByCompany();
        }

        public async Task<IEnumerable<ProductEntry>> ProductEntryListByInvoice(string? invoice)
        {
            return  await _unitOfWork.ProductEntryRepo.ProductEntryListByInvoice(invoice);
        }
    }
}
