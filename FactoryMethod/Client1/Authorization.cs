using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FactoryMethod
{
  
  public  class Authorization
    {
        private MyDbContext context;
        private string Name1;
        private bool loop;
        private int IDclient=0;
        public int Authorizations()
        {
            loop = true;    
            while (loop == true)
            {
                context = new MyDbContext();
                Console.WriteLine("");
                Console.WriteLine("Для входа введите имя и пароль.");
                Console.Write("Имя: ");
                Name1 = Console.ReadLine();
                Console.Write("Пароль: ");
                string password1 = Console.ReadLine();
                Client admin = context.Clients.FirstOrDefault(u => u.IdClient == 1);
                Client user1 = context.Clients.FirstOrDefault(u => u.Name == Name1 && u.password == password1);
                if (user1 == admin)
                {
                    return 1;
                }
                if (user1 == null)
                {
                    Console.WriteLine("Вы не зарегестрированы.");
                    loop = false;
                    break;
                }

                IDclient = user1.IdClient;
                context.Dispose();
                loop = false;
            }
            return IDclient;
        }
    }
}
