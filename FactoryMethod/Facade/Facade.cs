using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Facade
{
    public class Facade2
    {
        Authorization authorization;
        Registration registration;
        User user;
        Admin admin;
        public int Idclient = 0;
        public Facade2(Authorization sa, Registration sb, User sc, Admin min)
        {
            authorization = sa;
            registration = sb;
            user = sc;
            admin = min;
        }
        public void Operation1()
        {
            bool b=false;
            Idclient = authorization.Authorizations();
            if (Idclient == 1)
            {
                string boofer = "3";
                switch (boofer)
                {
                    case "3":
                        Console.WriteLine(" ");
                        Console.WriteLine("Выбирите действие:");
                        Console.WriteLine("1 - Заказать товар");
                        Console.WriteLine("2 - Перейти к возможностям пользователя");
                        Console.Write("Ведите номер: ");
                        string input = Console.ReadLine();
                        switch (input)
                        {
                            case "1":
                                admin.Storage();
                                break;
                            case "2":
                                b = true;
                                break;
                        }
                        if (b == true) break;
                        else goto case "3";
                }
              
            }
            else if (Idclient == 0)
            {
                registration.Registrations1();
                Idclient = authorization.Authorizations();
            }
                string type_device = "5";
            bool l = false;
            switch (type_device)
                {
                    case "5":
                        Console.WriteLine(" ");
                        Console.WriteLine("Выбирите действие:");
                        Console.WriteLine("1 - Купить товар");
                        Console.WriteLine("2 - Собрать ПК");
                        Console.WriteLine("3 - Сделать заказ");
                        Console.WriteLine("4 - Выйти с программы");
                        Console.WriteLine(" ");
                        Console.Write("Ведите номер: ");
                       string type_device2 = Console.ReadLine();
                            switch (type_device2)
                            {
                                case "1":
                                    user.buy(Idclient);
                                    break;

                                case "2":
                                    user.collect(Idclient);
                                    break;

                                case "3":
                                    user.watcher(Idclient);
                                    break;
                                case "4":
                                 l = true;
                                    break;
                             }
                    if (l == true) break;
                    else goto case "5";
                }
            
        }

        public void Operation2()
        {
            registration.Registrations1();
            Idclient = authorization.Authorizations();
            string type_device = "5";
            bool l = false;
            switch (type_device)
            {
                case "5":
                    Console.WriteLine(" ");
                    Console.WriteLine("Выбирите действие:");
                    Console.WriteLine("1 - Купить товар");
                    Console.WriteLine("2 - Собрать ПК");
                    Console.WriteLine("3 - Сделать заказ");
                    Console.WriteLine("4 - Выйти с программы");
                    Console.WriteLine(" ");
                    Console.Write("Ведите номер: ");
                    string type_device2 = Console.ReadLine();
                    switch (type_device2)
                    {
                        case "1":
                            user.buy(Idclient);
                            break;

                        case "2":
                            user.collect(Idclient);
                            break;

                        case "3":
                            user.watcher(Idclient);
                            break;
                        case "4":
                            l = true;
                            break;
                    }
                    if (l == true) break;
                    else goto case "5";
            }
        }
    }
}
