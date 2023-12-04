//=================================
// Copyright (c) Tarteeb LLC
// Developed by CashOverflow Team
//=================================

using CashOverflow.Models.Companies;
using Microsoft.EntityFrameworkCore;

namespace CashOverflow.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Company> Companys { get; set; }
    }
}
