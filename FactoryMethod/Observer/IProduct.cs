using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Observer
{
    public interface IProduct
    {
        // Присоединяет наблюдателя к издателю.
        void Attach(IClient observer, string email, string device_model);

        // Отсоединяет наблюдателя от издателя.
        void Detach(string email, string device_model);

        // Уведомляет всех наблюдателей о событии.
        void Notify(string device_model);
    }
}
