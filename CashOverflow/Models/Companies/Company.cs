//=================================
// Copyright (c) Tarteeb LLC
// Developed by CashOverflow Team
//=================================

using System;

namespace CashOverflow.Models.Companies
{
    public class Company
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
    }
}
