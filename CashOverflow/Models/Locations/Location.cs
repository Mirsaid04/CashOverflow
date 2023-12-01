//=================================
// Copyright (c) Tarteeb LLC
// Developed by CashOverflow Team
//=================================

using System;

namespace CashOverflow.Models.Locations
{
    public class Location
    {
        public Guid Id { get; set;}
        public string Name { get; set; }  
        public Country Country { get; set;}
        public DateTimeOffset CreateDate { get; set;}
        public DateTimeOffset UpdateDate { get; set;}
    }
}
