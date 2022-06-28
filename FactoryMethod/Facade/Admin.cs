using FactoryMethod.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Observer;

namespace FactoryMethod.Facade
{
  public  class Admin
    {
        
        private MyDbContext context;
        private bool loop=true;
        public string model_name;
        public void Storage()
        {
            context = new MyDbContext();
            Product2 product = new Product2();
            //заказ устройств на склад
            while (loop == true)
            {

                Console.WriteLine("");
                Console.Write("Список производителей товаров: ");
                var groups = from p in context.Fabricas
                             group p by p.Tipy_device;
                foreach (var g in groups)
                {
                    Console.Write("{0},  ", g.Key);
                }

                Console.WriteLine("");
                Console.Write("Выберите какое тип устройства заказать: ");
                string device = Console.ReadLine();

                var devise2 = context.Fabricas.Where(p => p.Tipy_device == device);
                foreach (Fabrica p in devise2)
                    Console.WriteLine("Id:{6} Производитель {0}, Модель {1}, Цена {2}, RAM {3}, Дисплей {4}, ОС {5}",
                            p.Name_fabrica,p.Name, p.Price, p.Memory, p.Display, p.Operating_system, p.IdDevice);
  
                Console.WriteLine("");
                Console.Write("Выберите ID устройства для заказа: ");
                string device2 = Console.ReadLine();
                int device3 = Convert.ToInt32(device2);

                Console.Write("Введите количество устройств: ");
                string Count1 = Console.ReadLine();
                int Count = Convert.ToInt32(Count1);

                if (device == "leptop")
                {
                    Console.WriteLine("");
                    var machines = new laptop(device3);
                    var delivery = new List<technology>();
                    // Вызываем фабричный метод для создания доставки.
                    //   machines.Create(Count);
                    // Добавляем созданные устройства в общую коллекцию.
                    delivery.AddRange(machines.Create(Count));
                    // Выводим данные о устройствах на экран.
                    foreach (var note in delivery)
                    {
                        Console.WriteLine(note);
                    }
                }
                if (device == "tablet")
                {
                    Console.WriteLine("");
                    var machines = new tablet(device3);
                    var delivery = new List<technology>();
                    // Вызываем фабричный метод для создания доставки.

                    // Добавляем созданные устройства в общую коллекцию.
                    delivery.AddRange(machines.Create(Count));
                    // Выводим данные о устройствах на экран.
                    foreach (var note in delivery)
                    {
                        Console.WriteLine(note);
                    }
                }
                if (device == "pk")
                {
                    Console.WriteLine("");
                    var machines = new pk(device3);
                    var delivery = new List<technology>();
                    // Вызываем фабричный метод для создания доставки.

                    // Добавляем созданные устройства в общую коллекцию.
                    delivery.AddRange(machines.Create(Count));
                    // Выводим данные о устройствах на экран.
                    foreach (var note in delivery)
                    {
                        Console.WriteLine(note);
                    }
                }

                Console.WriteLine("");
                SumFactoryMethod sum = new SumFactoryMethod(Count, device3);
                sum.GetSum();

                var devise7 = context.Fabricas.Where(p => p.IdDevice == device3);
                foreach (Fabrica p in devise7)
                {
                    model_name = p.Name;
                }  

                product.Notify(model_name);
                Console.WriteLine("");
                Console.Write("Заказать что-то ещё (y/n): ");
                string number4 = Console.ReadLine();
                if (number4 == "y")
                    loop = true;
                else loop = false;
               
            }

            context.Dispose();

          
        }
    }
}
