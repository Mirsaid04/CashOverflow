//=================================
// Copyright (c) Tarteeb LLC
// Developed by CashOverflow Team
//=================================

using CashOverflow.Models.Locations;
using Microsoft.EntityFrameworkCore;

namespace CashOverflow.Brokers.Storages
{
    public partial class StrorageBroker
    {
        DbSet<Location> locations { get; set; }
    }
}
