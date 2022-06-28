using System;

// Интерфейс Продукта объявляет операции, которые должны выполнять все
// конкретные продукты.
namespace FactoryMethod
{
    /// <summary>
    /// Базовый класс для любого производителя.
    /// </summary>
    public abstract class technology
    {
       
        /// <summary>
        /// Название производителя.
        /// </summary>
        public string Name_fabrica { get; protected set; }


        public string name_fabrica { get; protected set; }
        public string name_divaces { get; protected set; }
        public string tipy_device { get; protected set; }
        public int price { get; protected set; }
        public int memory { get; protected set; }
        public string display { get; protected set; }
        public string operating_system { get; protected set; }
        public int idManufacturer { get; protected set; }
        /// <summary>
        /// Создать новый устройства.
        /// </summary>
        /// <param name="name"> Название компании. </param>

        public technology(string name)
        {
            // Проверяем входные данные на корректность.
            if(string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            // Устанавливаем значения.
            Name_fabrica = name;
        }

        /// <summary>
        /// Приведение объекта к строке. 
        /// </summary>
        /// <returns> Название компании. </returns>
        public override string ToString()
        {
            return Name_fabrica;
        }
    }
}
