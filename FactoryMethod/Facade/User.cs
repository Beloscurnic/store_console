using FactoryMethod.Builder2;
using System;
using System.Linq;
using FactoryMethod.Decorator;
using FactoryMethod.Observer;
using static FactoryMethod.Decorator.Decorator;

namespace FactoryMethod.Facade
{
  public  class User
    {
        private MyDbContext context;
        private int Name1;
        private bool loop;

        private string name_accessories;
        private int price_accessories;
        private int slotCPU;
        private int slotRAW;
        private int slotRAW2;
        private int slotvideo_card;
        private int slotvideo_card2;
        private int slotCPU2;
        private string email;

        public void buy(int Name)
        {
            loop = true;
            Name1 = Name;
            context = new MyDbContext();
            var director = new Director();
            var kit = new Kit();
            director.Builder2 = kit;
            while (loop == true)
            {
                Console.WriteLine("");
                Console.Write("Выберите тип устройства для просмотра: ");
                //группировка по типу устройтсва
                var groups3 = from p in context.Сharacteristics
                              group p by p.device_type;
                foreach (var g in groups3)
                {
                    Console.Write("{0},  ", g.Key);
                }
                Console.WriteLine("");
                Console.Write("Введите тип устройства: ");
                string type_device = Console.ReadLine();
                string modeli;


                switch (type_device)
                {
                    case "leptop":
                        var groups5 = from p in context.Сharacteristics
                                      where p.device_type == "leptop"
                                      group p by p.Name;
                        foreach (var g in groups5)
                        {
                            modeli = g.Key;
                            Console.WriteLine("");
                            Console.Write("Модель: ");
                            Console.WriteLine(g.Key);
                            Console.WriteLine("Характеристики модели:");
                            foreach (var p in g)
                            {
                                Console.WriteLine("Id {5} Цена {0} RAW {1} Экран {2} OC {3} Производитель {4}",
                                                p.Price, p.Memory, p.Display, p.Operating_system, p.Fabrica, p.IdDevice);
                                break;
                            }

                        }
                        Console.WriteLine("");
                        Console.Write("Выберите ID устройства для заказа:");
                        string device5 = Console.ReadLine();
                        int device4 = Convert.ToInt32(device5);

                        kit.Laptop(device4, Name1);

                        break;

                    case "tablet":

                        var groups6 = from p in context.Сharacteristics
                                      where p.device_type == "tablet"
                                      group p by p.Name;
                        foreach (var g in groups6)
                        {
                            modeli = g.Key;
                            Console.WriteLine("");
                            Console.Write("Модель: ");
                            Console.WriteLine(g.Key);
                            Console.WriteLine("Характеристики модели:");
                            foreach (var p in g)
                            {
                                Console.WriteLine("Id {5} Цена {0} RAW {1} Экран {2} OC {3} Производитель {4}",
                                                p.Price, p.Memory, p.Display, p.Operating_system, p.Fabrica, p.IdDevice);
                                break;
                            }

                        }
                        Console.WriteLine("");
                        Console.Write("Выберите ID устройства для заказа: ");
                        string device6 = Console.ReadLine();
                        int device7 = Convert.ToInt32(device6);

                        kit.Laptop(device7, Name1);

                        break;

                    case "pk":

                        var groups7 = from p in context.Сharacteristics
                                      where p.device_type == "pk"
                                      group p by p.Name;
                        foreach (var g in groups7)
                        {
                            modeli = g.Key;
                            Console.WriteLine("");
                            Console.Write("Модель: ");
                            Console.WriteLine(g.Key);
                            Console.WriteLine("Характеристики модели:");
                            foreach (var p in g)
                            {
                                Console.WriteLine("Id {5} Цена {0} RAW {1} Экран {2} OC {3} Производитель {4}",
                                                p.Price, p.Memory, p.Display, p.Operating_system, p.Fabrica, p.IdDevice);
                                break;
                            }

                        }
                        Console.WriteLine("");
                        Console.Write("Выберите ID устройства для заказа: ");
                        string device9 = Console.ReadLine();
                        int device8 = Convert.ToInt32(device9);

                        kit.Laptop(device8, Name1);

                        break;

                }
                Console.WriteLine("");
                Console.Write("Продолжит покупки (y/n): ");
                string number5 = Console.ReadLine();
                if (number5 == "y")
                    loop = true;
                else loop = false;
            }
            Console.WriteLine("");
            Console.WriteLine("Ваш чек:");
            Console.WriteLine(kit.GetProduct().ListParts());
            Console.WriteLine(kit.GetProduct2().ListParts2());
            Console.ReadLine();
            context.Dispose();
        }

        public void collect(int Name)
        {
            loop = true;
            context = new MyDbContext();
            while (loop == true)
            {
                Console.WriteLine("");
                Console.Write("Доступые производители материской платы: ");
                var groups = from p in context.Motherboards
                             group p by p.Name_fabrica;
                foreach (var g in groups)
                {
                    Console.Write("{0},  ", g.Key);
                }
                Console.WriteLine("\n");
                Console.Write("Выберите производителя материской платы: ");

                string device = Console.ReadLine();
                Console.WriteLine("");
                var devise2 = context.Motherboards.Where(p => p.Name_fabrica == device);
                foreach (Motherboard p in devise2)
                {
                    Console.WriteLine("Id:{6} Производитель {0}, Модель {1}, Цена {2}, слоты под CPU {3}, слоты под RAW {4}, слоты под видео карту {5}",
                            p.Name_fabrica, p.Name, p.Price, p.slot_CPU, p.slot_RAW, p.slot_video_card, p.IdDevice);
                    Console.WriteLine("");
                }
                Console.WriteLine("");
                Console.Write("Выберите ID материской платы: ");
                string device2 = Console.ReadLine();
                int device3 = Convert.ToInt32(device2);

                var Motherboard = context.Motherboards.Where(a => a.IdDevice == device3);

                foreach (Motherboard p in Motherboard)
                {
                    name_accessories = p.Name;
                    price_accessories = p.Price;
                    slotCPU = p.slot_CPU;
                    slotRAW = p.slot_RAW;
                    slotvideo_card = p.slot_video_card;
                }
                Console.WriteLine("");
                Manufacturer product = new Assembly(device3);
                product = new Motherboard_D(product, name_accessories, price_accessories);


                Console.WriteLine("");
                Console.WriteLine("Под данную материскую плату доступно {0} слотов под поцессор", slotCPU);
                if (slotCPU > 1)
                {
                    Console.Write("Введите сколько процессоров вам надо исходя из доступных {0} : ", slotCPU);
                    string slotCPU1 = Console.ReadLine();
                    slotCPU2 = Convert.ToInt32(slotCPU1);
                    slotCPU = slotCPU2;
                }

                Console.WriteLine("");
                Console.Write("Доступые производители процессоров: ");
                var groups_CPU = from p in context.CPUs
                                 group p by p.Name_fabrica;
                foreach (var g in groups_CPU)
                {
                    Console.Write("{0},  ", g.Key);
                }
                Console.WriteLine("\n");
                Console.Write("Выберите производителя процессора: ");

                string device_CPU_fabrica = Console.ReadLine();
                Console.WriteLine("");
                var device_CPU = context.CPUs.Where(p => p.Name_fabrica == device_CPU_fabrica);


                foreach (CPU p in device_CPU)
                {
                    Console.WriteLine("Id:{5} Производитель {0}, Модель {1}, Цена {2}, ядра {3}, частота {4}, слоты под видео карту {5}",
                            p.Name_fabrica, p.Name, p.Price, p.Kernels, p.Clock_frequency, p.IdDevice);
                    Console.WriteLine("");
                }


                int bufer = 0;
                for (int i = 0; i < slotCPU; i++)
                {
                    Console.WriteLine("");
                    Console.Write("Выберите ID процессора: ");
                    string device5 = Console.ReadLine();
                    int device6 = Convert.ToInt32(device5);

                    var CPU = context.CPUs.Where(a => a.IdDevice == device6);

                    foreach (CPU p in CPU)
                    {
                        name_accessories = p.Name;
                        price_accessories = p.Price;

                    }
                    bufer = price_accessories + bufer;
                }
                product = new CPU_D(product, name_accessories, bufer);
                Console.WriteLine("");


                Console.WriteLine("");
                Console.WriteLine("Под данную материскую плату доступно {0} слотов под ОЗУ", slotRAW);
                if (slotRAW > 1)
                {
                    Console.Write("Введите сколько слотов ОЗУ вам надо исходя из доступных {0} : ", slotRAW);
                    string slotRAW1 = Console.ReadLine();
                    slotRAW2 = Convert.ToInt32(slotRAW1);
                    slotRAW = slotRAW2;
                }

                Console.WriteLine("");
                Console.Write("Доступые производители ОЗУ: ");
                var groups_RAW = from p in context.RAWs
                                 group p by p.Name_fabrica;
                foreach (var g in groups_RAW)
                {
                    Console.Write("{0},  ", g.Key);
                }
                Console.WriteLine("\n");
                Console.Write("Выберите производителя ОЗУ: ");

                string device_RAW_fabrica = Console.ReadLine();
                Console.WriteLine("");
                var device_RAW = context.RAWs.Where(p => p.Name_fabrica == device_RAW_fabrica);


                foreach (RAW p in device_RAW)
                {
                    Console.WriteLine("Id:{6} Производитель {0}, Модель {1}, Цена {2}, Объем {3}, Тип памяти {4}, частота {5}",
                            p.Name_fabrica, p.Name, p.Price, p.Size, p.Memory_type, p.Сlock_frequency, p.IdDevice);
                    Console.WriteLine("");
                }


                // int bufer2 = 0;
                for (int i = 0; i < slotRAW; i++)
                {
                    Console.WriteLine("");
                    Console.Write("Выберите ID ОЗУ под {0} слот : ", i + 1);
                    string device7 = Console.ReadLine();
                    int device8 = Convert.ToInt32(device7);

                    var RAW = context.RAWs.Where(a => a.IdDevice == device8);

                    foreach (RAW p in RAW)
                    {
                        name_accessories = p.Name;
                        price_accessories = p.Price;

                    }

                    //   bufer2 = price_accessories + bufer2;
                    product = new RAW_D(product, name_accessories, price_accessories);
                }
                Console.WriteLine("");



                Console.WriteLine("Под данную материскую плату доступно {0} слотов под видое карту", slotvideo_card);
                if (slotvideo_card > 1)
                {
                    Console.Write("Введите сколько слотов под видое карту вам надо исходя из доступных {0} : ", slotvideo_card);
                    string slotvideo_card1 = Console.ReadLine();
                    slotvideo_card2 = Convert.ToInt32(slotvideo_card1);
                    slotvideo_card = slotvideo_card2;
                }
                Console.WriteLine("");
                Console.Write("Доступые производители видео карт: ");
                var groups_Video_cart = from p in context.Video_carts
                                        group p by p.Name_fabrica;
                foreach (var g in groups_Video_cart)
                {
                    Console.Write("{0},  ", g.Key);
                }
                Console.WriteLine("\n");
                Console.Write("Выберите производителя Видео карты: ");

                string device_Video_cart_fabrica = Console.ReadLine();
                Console.WriteLine("");
                var device_Video_cart = context.Video_carts.Where(p => p.Name_fabrica == device_Video_cart_fabrica);


                foreach (Video_cart p in device_Video_cart)
                {
                    Console.WriteLine("Id:{6} Производитель {0}, Модель {1}, Цена {2}, Объем {3}, Тип памяти {4}, частота {5}",
                            p.Name_fabrica, p.Name, p.Price, p.Size, p.Memory_type, p.Сlock_frequency, p.IdDevice);
                    Console.WriteLine("");
                }


                // int bufer2 = 0;
                for (int i = 0; i < slotvideo_card; i++)
                {
                    Console.WriteLine("");
                    Console.Write("Выберите ID видео карты под {0} слот : ", i + 1);
                    string device7 = Console.ReadLine();
                    int device8 = Convert.ToInt32(device7);

                    var Video_cart = context.Video_carts.Where(a => a.IdDevice == device8);

                    foreach (Video_cart p in Video_cart)
                    {
                        name_accessories = p.Name;
                        price_accessories = p.Price;

                    }
                    product = new Video_cart_D(product, name_accessories, price_accessories);
                }
                Console.WriteLine("");


                Console.WriteLine("{0}", product.Name);
                Console.WriteLine("Цена сборки: {0}", product.GetCost());

                Console.WriteLine("");
                Console.Write("Собрать ещё один ПК (y/n): ");
                string number5 = Console.ReadLine();
                if (number5 == "y")
                    loop = true;
                else loop = false;
            }
        }

        public void watcher(int Idclient)
        {
            loop = true;
            context = new MyDbContext();
            while (loop == true)
            {
                var subject = new Product2();
                var observerA = new ConcreteClientA();

                var clients = context.Clients.Where(a => a.IdClient == Idclient);
                foreach (Client p in clients)
                {
                    email = p.email;
                }
                Console.WriteLine("");
                Console.Write("Введите модель устройства отслеживания : ");
                string model5 = Console.ReadLine();
                subject.Attach(observerA, email, model5);

                Console.WriteLine("");
                Console.Write("Отслеживать ещё какой-то товар (y/n): ");
                string number5 = Console.ReadLine();
                if (number5 == "y")
                    loop = true;
                else loop = false;
            }
        }
    }
}
