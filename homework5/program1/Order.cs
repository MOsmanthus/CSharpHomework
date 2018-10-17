using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Order
    {
        private List<OrderDetail> details = new List<OrderDetail>();

        public Order(uint orderId, Customer customer)
        {
            Id = orderId;
            Customer = customer;
        }

        public uint Id { get; set; }

        public Customer Customer { get; set; }


        public List<OrderDetail> Details
        {
            get => this.details;
        }

        public void AddDetails(OrderDetail orderDetail)
        {
            if (this.Details.Contains(orderDetail))
            {
                throw new Exception($"orderDetails-{orderDetail.Id} is already existed!");
            }
            details.Add(orderDetail);
        }

        public void RemoveDetails(uint orderDetailId)
        {
            details.RemoveAll(d => d.Id == orderDetailId);
        }

        public override string ToString()
        {
            string result = "================================================================================\n";
            result += $"orderId:{Id}, customer:({Customer})";
            details.ForEach(od => result += "\n\t" + od);
            result += "\n================================================================================";
            return result;
        }
    }
}
