﻿using AutoMapper;
using Ecosystem.Services.Base.Implementations;
using Ecosystem.Services.Base.Interfaces;
using StorageManagerService.DomainServices.Interfaces;
using StorageManagerService.Entities;

namespace StorageManagerService.DomainServices.Implementations
{
    public class ProductDomainService : CrudDomainService<Product>, IProductDomainService
    {
        public ProductDomainService(ILogger<IProductDomainService> logger,
            IMapper mapper,
            IRepository<Product> repository) : base(logger, mapper, repository)
        {
        }
    }
}
