using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Builder2
{
    public class Director
    {
        private IKit builder2;

        public IKit Builder2
        {
            set { builder2 = value; }
        }
        //устанавливает зна
        // чение поля. доступно только для записи - можно только установить значение
        //Параметр value представляет передаваемое значение
        // Директор может строить несколько вариаций продукта, используя
        // одинаковые шаги построения.

        public void KitMinimal(int Id, int user)
        {
            int i = Id;
            this.builder2.PK(i, user);
        }

        public void KitFull(int Id, int Id2, int Id3, int user)
        {
            int i = Id;
            int i2 = Id2;
            int i3 = Id3;
            this.builder2.PK(i, user);
            this.builder2.Tablet(i2, user);
            this.builder2.Laptop(i3, user);
        }

    }
}