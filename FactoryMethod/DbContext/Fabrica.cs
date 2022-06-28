
//using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Data.Entity;

namespace FactoryMethod
{
    [Table("Fabrica")]
   public class Fabrica
    {
        [Key]
        public int IdDevice { get; set; }
        public string Name_fabrica { get; set; }
        public string Tipy_device { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Memory { get; set; }
        public string Display { get; set; }
        public string Operating_system { get; set; }
    }
}
