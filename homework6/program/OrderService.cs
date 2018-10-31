using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace program
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
            List<Order> orders = orderDict.Values.ToList();
            var query = from s in orders
                        where s.Customer.Name == customerName
                        select s;
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

        public static void XmlSerialize(XmlSerializer ser, string fileName, object obj)

        {

            FileStream fs = new FileStream(fileName, FileMode.Create);

            ser.Serialize(fs, obj);

            fs.Close();

        }

        public static List<Order> orders = new List<Order>();

        public void Export(string fileName)

        {

            XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));

            XmlSerialize(xmlser, fileName, orders);

            string xml = File.ReadAllText(fileName);

        }

        public void Import(string fileName)

        {

            XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));

            FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);

            orders = xmlser.Deserialize(fileStream)

                as List<Order>;

        }
    }
}
