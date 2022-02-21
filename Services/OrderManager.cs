﻿using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class OrderManager
    {
        private readonly ShoppingDB _context;

        public OrderManager(ShoppingDB context)
        {
            _context = context;
        }
        public List<Order> GetOrders()
        {
            return _context.Orders.ToList();
        }
        public void Add(Order order)
        {
            _context.Add(order);
            _context.SaveChanges();
        }
    }
}
