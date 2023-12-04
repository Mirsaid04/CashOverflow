//=================================
// Copyright (c) Tarteeb LLC
// Developed by CashOverflow Team
//=================================

using CashOverflow.Models.Salaries;
using Microsoft.EntityFrameworkCore;

namespace CashOverflow.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Salary> Salaries { get; set; }
    }
}
