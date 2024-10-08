﻿using ControleCerto.DTOs.Account;

namespace ControleCerto.DTOs.User
{
    public class InfoUserResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
    }
}
