using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class OrderService
    {
        private Dictionary<uint, Order> orderDict;
        
        public OrderService()
        {
            orderDict = new Dictionary<uint, Order>();
        }
        
        public void AddOrder(Order order)
        {
            if (orderDict.ContainsKey(order.Id))
                throw new Exception($"order-{order.Id} is already existed!");
            orderDict[order.Id] = order;
        }
        
        public void RemoveOrder(uint orderId)
        {
            orderDict.Remove(orderId);
        }
        
        public List<Order> QueryAllOrders()
        {
            return orderDict.Values.ToList();
        }
        
        public Order GetById(uint orderId)
        {
            return orderDict[orderId];
        }
        
        public List<Order> QueryByGoodsName(string goodsName)
        {
            List<Order> result = new List<Order>();
            foreach (Order order in orderDict.Values)
            {
                foreach (OrderDetail detail in order.Details)
                {
                    if (detail.Goods.Name == goodsName)
                    {
                        result.Add(order);
                        break;
                    }
                }
            }
            return result;
        }
        
        public List<Order> QueryByCustomerName(string customerName)
        {
            var query = orderDict.Values
                .Where(order => order.Customer.Name == customerName);
            return query.ToList();
        }
        
        public void UpdateCustomer(uint orderId, Customer newCustomer)
        {
            if (orderDict.ContainsKey(orderId))
            {
                orderDict[orderId].Customer = newCustomer;
            }
            else
            {
                throw new Exception($"order-{orderId} is not existed!");
            }
        }
    }
}
