﻿using Finantech.Enums;

namespace Finantech.Models.Entities
{
    public class Expense
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public ExpenseTypeEnum ExpenseType { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string Destination { get; set; }
        public string? Description { get; set; }
        public bool JustForRecord { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public int AccountId { get; set; }
        public int CategoryId { get; set; }

        public Account? Account { get; set; }
        public Category? Category { get; set; }
    }
}
