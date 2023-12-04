//=================================
// Copyright (c) Tarteeb LLC
// Developed by CashOverflow Team
//=================================

using CashOverflow.Models.Jobs;
using Microsoft.EntityFrameworkCore;

namespace CashOverflow.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Job> jobs { get; set; }
    }
}
