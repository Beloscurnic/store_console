using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Конкретные Создатели переопределяют фабричный метод для того, чтобы
// изменить тип результирующего продукта.

namespace FactoryMethod
{
    /// <summary>
    /// Устройство для доставки Ноутов.
    /// </summary>
    public class pk : check
    {
        /// <summary>
        /// ID УСТРОЙСТВА
        /// </summary>
        private int _denomination;
        /// <summary>
        /// Название производителя
        /// </summary>
        private string Tipy;
        public int price;
        // public int Sum;
        private MyDbContext context;
        /// <summary>
        /// Создать новый экземпляр устройства для доставки.
        /// </summary>
        /// <param name="Name"> ID устройства. </param>
        public pk(int Name)
            : base("Доставка Ноутов")
        {

            // Устанавливаем значение.
            _denomination = Name;
        }

        /// <summary>
        /// количество заказаных устройств.
        /// </summary>
        /// <param name="Count"> количество устройств. </param>

        public override technology[] Create(int Count)
        {


            context = new MyDbContext();

            //Количество устройст для доствки
            //  int Sum;
            Fabrica fabrica = context.Fabricas.FirstOrDefault(p => p.IdDevice == _denomination);
            if (fabrica != null)
            {
                Tipy = fabrica.Name_fabrica;
                price = fabrica.Price;
            }

            var count = Count;


            // Создаем коллекцию для сохранения устройст.
            var delivery = new List<technology>();
            if (Tipy == "HP")
            {
                // Создаем устройства и добавляем в коллекцию.
                for (var i = 0; i < count; i++)
                {
                    var HP = new HP(_denomination);
                    delivery.Add(HP);
                }

            }
            if (Tipy == "Lenova")
            {
                // Создаем устройства и добавляем в коллекцию.
                for (var i = 0; i < count; i++)
                {
                    var HP = new LENOVA(_denomination);
                    delivery.Add(HP);
                }
            }
            // Возвращаем готовые устройства.
            context.Dispose();
            return delivery.ToArray();

        }
    }
}
