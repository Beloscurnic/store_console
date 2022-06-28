using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Decorator
{
    class Decorator
    {
        
        public abstract class Manufacturer
        {
            //объект наследования 
            public Manufacturer(string n)
            {
                Name = n;
            }
            //переменая которая возращает значение поля но изменят могут только наследованые классы
            public string Name { get; protected set; }
            //вывод суммы заказа
            public abstract int GetCost();
        }
     public   class Assembly : Manufacturer
        {
            public Assembly(int kgkgh) : base("Компоненты ПК: ")
            { }
            public override int GetCost()
            {
                return 0;
            }
        }
        /*    Декоратором является абстрактный класс  который унаследован от класса Manufacturer и 
          *    содержит ссылку на декорируемый объект ASUS и Nvidia*/
        public abstract class MotherboardDecorator : Manufacturer
        {
            protected Manufacturer factory;
            public MotherboardDecorator(string n, Manufacturer factory) : base(n)
            {
                this.factory = factory;
            }
        }

        public class RAW_D : MotherboardDecorator
        {
            int Price;
            public RAW_D(Manufacturer p, string Name2, int price)
                : base(p.Name + "\n ОЗУ: " + Name2, p)
            {
                Price = price;
            }

            public override int GetCost()
            {
                return (factory.GetCost() + Price);
            }
        }
        public class Video_cart_D : MotherboardDecorator
        {
            int Price;
            public Video_cart_D(Manufacturer p, string Name2, int price)
                : base(p.Name + "\n Видео карта: " + Name2, p)
            {
                Price = price;
            }

            public override int GetCost()
            {
                return (factory.GetCost() + Price);
            }
        }
        public class CPU_D : MotherboardDecorator
        {
            int Price;
            public CPU_D(Manufacturer p, string Name2, int price)
                : base(p.Name + "\n Процессор: " + Name2, p)
            {
                Price = price;
            }

            public override int GetCost()
            {
                return (factory.GetCost() + Price);
            }
        }
        public class Motherboard_D : MotherboardDecorator
        {
            int Price;
            public Motherboard_D(Manufacturer p, string Name2, int price)
                : base(p.Name + "\n Материская плата: " + Name2, p)
            {
                Price = price;
            }

            public override int GetCost()
            {
                return (factory.GetCost() + Price);
            }
        }
    }
}
