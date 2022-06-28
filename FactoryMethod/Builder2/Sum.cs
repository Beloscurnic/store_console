using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Builder2
{
    public class Sum
    {
     
        private ArrayList numbers = new ArrayList();

        public void Add2(int part)
        {
            this.numbers.Add(part);
        }

        public string ListParts2()
        {
            
            int sum = 0;
            foreach (int id in numbers)
            {
                sum = sum + id;
            }
            return "Сумма заказа: " + sum.ToString() + "\n";
        }
       
    }
}