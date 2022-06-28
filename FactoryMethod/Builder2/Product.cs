using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Builder2
{
    public class Product
    {
       
        private List<object> parts = new List<object>();

        public void Add(string part)
        {
            this.parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this.parts.Count; i++)
            {
                str += this.parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2);
            return "Cписок покупок: " + str + "\n";
        }
      
    }
}