using System;
using FactoryMethod.FactoryMethod2;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.FactoryMethod
{

  public class SumFactoryMethod
    {
        public int Sum1;
        public int Count;
        public int ID;
        public int price;
        private MyDbContext context;
        public SumFactoryMethod(int count,int Id)
        {
            Count = count; ID = Id;
        }
        public void GetSum()
        {

            context = new MyDbContext();
                Fabrica fabrica = context.Fabricas.FirstOrDefault(p => p.IdDevice == ID);
                if (fabrica != null)
                {  
                    price = fabrica.Price;
                }
                Console.WriteLine($"Общая сумма заказа: {Sum1=price*Count}");

        }
    }
}
