﻿namespace EventProjectWeb.DTO.Customer
{
    public class UpdateCustomerRequestDTO
    {
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}