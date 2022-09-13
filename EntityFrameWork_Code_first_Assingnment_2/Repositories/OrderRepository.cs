using EntityFrameWork_Code_first_Assingnment_2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_Code_first_Assingnment_2.Repositories
{
    internal class OrderRepository
    {
        public MyContextDB db = new MyContextDB();
        public void AddOrder(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
        }
    }
}
