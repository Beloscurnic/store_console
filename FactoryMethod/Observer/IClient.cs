using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Observer
{
    public interface IClient
    {
        
        // Получает обновление от издателя
        void Update(string model);
    }
}
