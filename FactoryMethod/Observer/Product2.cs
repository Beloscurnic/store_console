using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Observer
{
    public class Product2 : IProduct
    {
        private MyDbContext context;

        // Для удобства в этой переменной хранится состояние Издателя,
        // необходимое всем подписчикам.
        public int State { get; set; } = 0;

        // Список подписчиков. В реальной жизни список подписчиков может
        // храниться в более подробном виде (классифицируется по типу события и
        // т.д.)
        private List<IClient> _observers = new List<IClient>();

        // Методы управления подпиской.
        public void Attach(IClient observer, string email, string device_model)
        {
            context = new MyDbContext();
            var Pre_order = new List<Pre_order>
                        {
                         new Pre_order() {Email=email,Device_model=device_model }
                        };
            context.Pre_orders.AddRange(Pre_order);
            context.SaveChanges();
            context.Dispose();
            Console.WriteLine("Выбраная модель поставлена на счётчик ");

        }

        public void Detach( string email, string device_model)
        {
            using (var context = new MyDbContext())
            {
                var Pre_order = context.Pre_orders.FirstOrDefault(a => a.Email == email && a.Device_model == device_model);
                if (Pre_order != null)
                {
                    context.Pre_orders.Remove(Pre_order);
                    context.SaveChanges();
                }
            }

          
        }

        // Запуск обновления в каждом подписчике.
        public void Notify(string device_model)
        {
            ConcreteClientA client = new ConcreteClientA();
            client.Update(device_model);
        }
    }
}
