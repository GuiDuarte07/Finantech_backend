﻿using Finantech.Enums;
using System.ComponentModel.DataAnnotations;

namespace Finantech.DTOs.Expense
{
    public class CreateExpenseRequest
    {
        [Range(0, double.MaxValue, ErrorMessage = "O 'Amount' deve ser um número positivo.")]
        [Required(ErrorMessage = "Campo 'Amount' não informado.")]
        public double Amount { get; set; }

        [Required(ErrorMessage = "Campo 'ExpenseType' não informado.")]
        public ExpenseTypeEnum ExpenseType { get; set; }

        [Required(ErrorMessage = "Campo 'PurchaseDate' não informado.")]
        public DateTime PurchaseDate { get; set; }

        [Required(ErrorMessage = "Campo 'Destination' não informado.")]
        [MaxLength(80, ErrorMessage = "Campo 'Destination' pode conter até 80 caracteres")]
        public string Destination { get; set; }

        [MaxLength(100, ErrorMessage = "Campo 'Description' pode conter até 100 caracteres")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Campo 'AccountId' não informado.")]
        public int AccountId { get; set; }

        [Required(ErrorMessage = "Campo 'CategoryId' não informado.")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Campo 'JustForRecord' não informado.")]
        public bool JustForRecord { get; set; }
    }
}
