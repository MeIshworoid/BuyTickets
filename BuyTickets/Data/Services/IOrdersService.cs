﻿using BuyTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuyTickets.Data.Services
{
    public interface IOrdersService
    {
        Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress);
        Task<List<Order>> GetOrderByUserIdAndRoleAsync(string userId, string userRole);
    }
}
