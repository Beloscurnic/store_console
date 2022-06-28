using System;
using System.Linq;

namespace FactoryMethod
{
    public class Registration
    {
        private MyDbContext context;
        private bool loop;
        public bool Registrations1()
        {
            context = new MyDbContext();
            loop = true;
            while (loop == true)
            {
                Console.WriteLine("Для регистрации введите имя, пароль и email.");
                Console.Write("Имя: ");
                string Name = Console.ReadLine();
                Console.Write("Пароль: ");
                string password = Console.ReadLine();
                Console.Write("email: ");
                string email = Console.ReadLine();
                Console.WriteLine("");

                Client user = context.Clients.FirstOrDefault(u => u.Name == Name && u.password == password && u.email == email);
                if (user == null)
                {
                    // добавляем пользователя в бд
                    context.Clients.Add(new Client { Name = Name, password = password, email=email });
                    context.SaveChanges();
                    Console.WriteLine("Пользователь зарегестрирован");                   
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Данный пользователь существует. Повторите попытку");
                    context.Dispose();
                    loop = true;
                }
            }
            return true;
        }
    }
}
