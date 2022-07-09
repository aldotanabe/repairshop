﻿using RepairShop.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(
            ICustomerRepository customerRepository,
            ISalesOrderRepository salesOrderRepository,
            ISalesOrderLineRepository salesOrderLineRepository,
            IVendorRepository vendorRepository)
        {
            Customers = customerRepository;
            SalesOrders = salesOrderRepository;
            SalesOrderLines = salesOrderLineRepository;
            Vendors = vendorRepository;
        }
        public ICustomerRepository Customers { get; }
        public ISalesOrderRepository SalesOrders { get; }
        public ISalesOrderLineRepository SalesOrderLines { get; }
        public IVendorRepository Vendors { get; }
    }
}
