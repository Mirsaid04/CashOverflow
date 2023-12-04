﻿//=================================
// Copyright (c) Tarteeb LLC
// Developed by CashOverflow Team
//=================================

using CashOverflow.Models.Reviews;
using Microsoft.EntityFrameworkCore;

namespace CashOverflow.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Review> reviews { get; set; }
    }
}
