
//using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Data.Entity;


namespace FactoryMethod
{
    [Table("Сonnector")]
    public class Сonnector
    {
        [Key]
        public int IdСonnector { get; set; }
        public int Price { get; set; }
        public string NameSocket { get; set; }
        public string TypeСonnector { get; set; }
    }
}
