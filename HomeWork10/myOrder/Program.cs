﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myOrder
{
    public class Program
    {
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();
            orderService.ShowForUser();
        }
    }
}
