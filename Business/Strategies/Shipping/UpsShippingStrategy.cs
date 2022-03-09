using Strategy_Pattern_Using_different_shipping_providers.Business.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Strategy_Pattern_Using_different_shipping_providers.Business.Strategies.Shipping
{
    internal class UpsShippingStrategy : IShippingStrategy
    {
        public void Ship(Order order)
        {
            using (var client = new HttpClient())
            {
                /// TODO: Implement Ups Shipping Integration
                /// 
                Console.WriteLine("Order is shipped with Ups");
            }
        }
    }
}
