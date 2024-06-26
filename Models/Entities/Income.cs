﻿using Finantech.Enums;
using System.ComponentModel.DataAnnotations;

namespace Finantech.Models.Entities
{
    public class Income
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public double Amount { get; set; }
        public IncomeTypeEnum IncomeType { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string Origin { get; set; }
        public bool JustForRecord { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public int AccountId { get; set; }
        public int CategoryId { get; set; }

        public Account Account { get; set; }
        public Category Category { get; set; }
    }
}
