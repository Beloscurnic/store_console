
//using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Data.Entity;

namespace FactoryMethod
{
    [Table("RAW")]
    public class RAW
    {
        [Key]
        public int IdDevice { get; set; }
        public string Name_fabrica { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public string Memory_type { get; set; }
        public string Сlock_frequency { get; set; }
        public int Price { get; set; }

    }
}
