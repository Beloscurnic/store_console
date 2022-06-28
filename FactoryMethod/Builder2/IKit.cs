using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Builder2
{
 public interface IKit
    {
        void PK(int Id, int user);
        void Tablet(int Id, int user);
        void Laptop(int Id, int user);
       
    }
}
