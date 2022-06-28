using FactoryMethod.FactoryMethod2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Конкретные Продукты предоставляют различные реализации интерфейса
// Продукта.
namespace FactoryMethod
{
    /// <summary>
    /// Компания РЗ.
    /// </summary>
    public class LENOVA : technology
    {

        /// <summary>
        /// Уникальный код.
        /// </summary>
        public Guid unique_number { get; private set; }
        string id;
        /// <summary>
        /// Название устройства.
        /// </summary>

        private MyDbContext context;
        /// <summary>
        /// Создать новый экземпляр LENOVA.
        /// </summary>
        /// <param name="Id_divaces"> Id устойства. </param>
        ///  <param name="NameManufacturer"> название производителя. </param>
        public LENOVA(int Id_divaces)
            : base("Производитель LENOVA:")
        {
            Guid unique_number = Guid.NewGuid();
            var Uniq = new Uniq_Password();
            id = Uniq.Vozrat();

            context = new MyDbContext();

            Fabrica fabrica = context.Fabricas.FirstOrDefault(p => p.IdDevice == Id_divaces);
                if (fabrica != null)
                {
                    name_fabrica = fabrica.Name_fabrica;
                    tipy_device = fabrica.Tipy_device;
                    name_divaces = fabrica.Name;
                    price = fabrica.Price;
                    memory = fabrica.Memory;
                    display = fabrica.Display;
                    operating_system = fabrica.Operating_system;
                }

           // Создаем устройства и добавляем в коллекцию.
            var Сharacteristic = new List<Сharacteristic>
                        {
                         new Сharacteristic() { unique_number = id, Name=name_divaces,Price=price,Memory=memory,Display=display,Operating_system=operating_system, device_type= tipy_device,Fabrica=name_fabrica}
                        };
            context.Сharacteristics.AddRange(Сharacteristic);
            context.SaveChanges();
            context.Dispose();
        }

        /// <summary>
        /// Приведение объекта к строке.
        /// </summary>
        /// <returns> Информация о устройствах. </returns>
        public override string ToString()
        {
            return $"{Name_fabrica} Уникальный код {id} Тип устройства {tipy_device} Модель {name_divaces}";
        }
    }
}
