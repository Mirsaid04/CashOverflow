//=================================
// Copyright (c) Tarteeb LLC
// Developed by CashOverflow Team
//=================================

using System;
using System.Text.Json.Serialization;
using CashOverflow.Models.Companies;

namespace CashOverflow.Models.Reviews
{
    public class Review
    {
        public Guid id { get; set; }
        public int Stars { get; set; }
        public string Thoughts { get; set; }
        public Guid CompanyId { get; set; }
        [JsonIgnore]
        public Company Company { get; set; }
    }
}
