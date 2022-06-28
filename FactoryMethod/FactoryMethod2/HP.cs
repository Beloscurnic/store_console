using System;
using FactoryMethod.FactoryMethod2;
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
    public class HP : technology
    {

        /// <summary>
        /// Уникальный код.
        /// </summary>
        public Guid unique_number { get; private set; }
     
        /// <summary>
        /// Название устройства.
        /// </summary>
       
        private MyDbContext context;

        /// <summary>
        /// Создать новый экземпляр HP.
        /// </summary>
        /// <param name="Id_divaces"> Id устойства. </param>
        ///  <param name="NameManufacturer"> название производителя. </param>
        public HP(int Id_divaces) 
            : base("HP:")
        {
            Guid unique_number = Guid.NewGuid();
            string id = unique_number.ToString();

            context = new MyDbContext();

            var fabrica = context.Fabricas.First(p => p.IdDevice == Id_divaces);
                if (fabrica != null)
                {
                    name_fabrica = fabrica.Name_fabrica;
                    tipy_device = fabrica.Tipy_device;
                    name_divaces = fabrica.Name;
                    price = fabrica.Price;
                    memory = fabrica.Memory;
                    display = fabrica.Display;
                    operating_system = fabrica.Operating_system;
                };


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
            return $"{Name_fabrica} Уникальный код {unique_number} Тип устройства {tipy_device} Модель {name_divaces} ";
        }      
    }
}
