﻿using Microsoft.EntityFrameworkCore;
using Microting.eFormApi.BasePn.Abstractions;
using Microting.eFormApi.BasePn.Infrastructure.Database.Entities;
using Microting.eFormBaseCustomerBase.Infrastructure.Data.Entities;

namespace Microting.eFormBaseCustomerBase.Infrastructure.Data
{
    public class CustomersPnDbAnySql : DbContext, IPluginDbContext
    {
        public CustomersPnDbAnySql() { }

        public CustomersPnDbAnySql(DbContextOptions<CustomersPnDbAnySql> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerVersion> CustomerVersions { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<CustomerField> CustomerFields { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceVersion> InvoiceVersions { get; set; }
        public DbSet<PluginConfigurationValue> PluginConfigurationValues { get; set; }
        public DbSet<PluginConfigurationValueVersion> PluginConfigurationValueVersions { get; set; }
        public DbSet<PluginPermission> PluginPermissions { get; set; }
        public DbSet<PluginGroupPermission> PluginGroupPermissions { get; set; }
        public DbSet<PluginGroupPermissionVersion> PluginGroupPermissionVersions { get; set; }
    }
}
