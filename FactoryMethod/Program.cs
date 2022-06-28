//using FactoryMethod.Builder2;
//using FactoryMethod.FactoryMethod;
using FactoryMethod.Builder2;
using FactoryMethod.Facade;
using FactoryMethod.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FactoryMethod
{
    class Program
    {

        static void Main(string[] args)
        {


            using (var context = MyDbContext.getInstance())
            {
                Facade2 facade = new Facade2(new Authorization(), new Registration(), new User(), new Admin());
                Console.WriteLine("Выберите пункт меню:");
                Console.WriteLine("1. Вход");
                Console.WriteLine("2. Регистрация");
                Console.Write("Пункт: ");
                string number = Console.ReadLine();
                int result = Int32.Parse(number);
                switch (result)
                {
                    case 1:
                        facade.Operation1();
                        break;

                    case 2:
                        facade.Operation2();
                        break;
                }
               
                Console.ReadLine();
            }

        }
    }
}
