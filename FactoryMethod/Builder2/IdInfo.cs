using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Builder2
{
  public  class IdInfo
    {
        public int Idinfo()
        {
            Random rnd = new Random();
             int IdNumber = rnd.Next();
            return IdNumber;
        }
    }
}