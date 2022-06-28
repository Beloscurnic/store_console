using FactoryMethod.Builder2;
using System;
using System.Linq;

namespace FactoryMethod.Builder2
{
    class Kit : IKit
    {
        public Product product = new Product();
        public Sum numbers = new Sum();

        // Новый набор KIT должен содержать пустой объект продукта,
        // который используется в дальнейшей сборке.
        public Kit()
        {
            this.Reset();

        }
        // доступ к текущему экземпляру класса. 
        public void Reset()
        {
            this.numbers = new Sum();
            this.product = new Product();

        }

        public void Delit(int Id)
        {
            int i = Id;
            using (var context = new MyDbContext())
            {
                var Сharacteristic = context.Сharacteristics.FirstOrDefault(a => a.IdDevice == i);
                if (Сharacteristic != null)
                {
                    context.Сharacteristics.Remove(Сharacteristic);
                    context.SaveChanges();
                }
            }

        }
        // Все этапы производства работают с одним и тем же экземпляром
        // продукта.
        public void PK(int Id, int user)
        {
            int i = Id;
            int client = user;

            using (var context = new MyDbContext())
            {
               
                Client Clients = context.Clients.FirstOrDefault(a => a.IdClient == client);
                if (Clients != null)
                {
                    var Сharacteristic = context.Сharacteristics.Where(a => a.IdDevice == i);
                    foreach (Сharacteristic apart in Сharacteristic)
                    {
                        Console.WriteLine($"Модель устройства: {apart.Name};    Цена: {apart.Price}");
                        this.product.Add(apart.Name);
                        this.numbers.Add2(apart.Price);
                    }
                }
                Delit(i);
            }
        }

        public void Tablet(int Id, int user)
        {
            int i = Id;
            int client = user;

            using (var context = new MyDbContext())
            {
                
                Client Clients = context.Clients.FirstOrDefault(a => a.IdClient == client);
                if (Clients != null)
                {
                    Console.WriteLine("");
                    var Сharacteristic = context.Сharacteristics.Where(a => a.IdDevice == i);
                    foreach (Сharacteristic apart in Сharacteristic)
                    {
                        Console.WriteLine($"Модель устройства: {apart.Name};    Цена: {apart.Price}");
                        this.product.Add(apart.Name);
                        this.numbers.Add2(apart.Price);
                    }
                }
                Delit(i);
            }
        }

        public void Laptop(int Id, int user)
        {
            int i = Id;
            int client = user;

            using (var context = new MyDbContext())
            {            
                var Сharacteristic = context.Сharacteristics.Where(a => a.IdDevice == i);

                foreach (Сharacteristic apart in Сharacteristic)
                {
                    Console.WriteLine($"Модель устройства: {apart.Name};    Цена: {apart.Price}");
                    this.product.Add(apart.Name);
                    this.numbers.Add2(apart.Price);
                }
                Delit(i);
            }
        }



        //Возращение канечного набора клиенту с последующей подготовки строителя к следующиму проекту.
        public Product GetProduct()
        {
            Product result = this.product;

            //    this.Reset();

            return result;
        }
        public Sum GetProduct2()
        {
            Sum result2 = this.numbers;

            this.Reset();

            return result2;
        }
    }
}
