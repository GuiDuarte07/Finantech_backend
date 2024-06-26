﻿using System.ComponentModel.DataAnnotations;

namespace Finantech.DTOs.CreditCard
{
    public class InfoCreditCardResponse
    {
        public int Id { get; set; }
        public double TotalLimit { get; set; }
        public double UsedLimit { get; set; }
        public string Description { get; set; }
        public string CardBrand { get; set; }
        public DateTime DueDay { get; set; }
        public DateTime CloseDay { get; set; }
    }
}
