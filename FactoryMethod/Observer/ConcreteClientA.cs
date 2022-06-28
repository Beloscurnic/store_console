using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Observer
{

    // Конкретные Наблюдатели реагируют на обновления, выпущенные Издателем, к
    // которому они прикреплены.
    class ConcreteClientA : IClient
    {
        public string email;
        private MyDbContext context;
        public void Update(string model)
        {
            context = new MyDbContext();
            Product2 product2 = new Product2();

            Email email2 = new Email();
            var Device = context.Pre_orders.Where(p => p.Device_model == model);
            foreach (Pre_order p in Device)
            {
                email = p.Email;
                email2.send(email, model);
                product2.Detach(email, model);
            }
          
        }
    }
}
