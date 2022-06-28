using System;

// Класс Создатель объявляет фабричный метод, который должен возвращать
// объект класса Продукт. Подклассы Создателя обычно предоставляют
// реализацию этого метода.

namespace FactoryMethod
{
    /// <summary>
    /// Базовый класс для устройств техналогии.
    /// </summary>
    public abstract class check
    {
        /// <summary>
        /// Название устройства.
        /// </summary>
        public string Name { get; protected set; }
        public int Sum { get; protected set; }

        /// <summary>
        /// Создать новый экземпляр техники.
        /// </summary>
        /// <param name="name"> Название. </param>
        public check(string name)
        {
            // Проверяем входные данные на корректность.
            if(string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            // Устанавливаем значение.
            Name = name;
        }

        /// <summary>
        /// Дотсавка новой партии устройтсв.
        /// </summary>
        /// <param name="Count"> Количество устройств надо доставить. </param>
        /// <param name="Id_divaces"> Id устройства. </param>
        /// <returns> Доставлено. </returns>
        public abstract technology[] Create(int Count);

        /// <summary>
        /// Приведение объекта к строке.
        /// </summary>
        /// <returns> Название. </returns>
      
    }
}
