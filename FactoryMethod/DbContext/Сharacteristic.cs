
//using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Data.Entity;

namespace FactoryMethod
{
    [Table("Сharacteristic")]
    public  class Сharacteristic
    {
        [Key]
        public int IdDevice { get; set; }
        public string unique_number { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Memory { get; set; }
        public string Display { get; set; }
        public string Operating_system { get; set; }
        public string device_type { get; set; }
        public string Fabrica { get; set; }
       
    }
}
