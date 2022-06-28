
//using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Data.Entity;

namespace FactoryMethod
{
    [Table("Motherboard")]
    public class Motherboard
    {
        [Key]
        public int IdDevice { get; set; }
        public string Name_fabrica { get; set; }
        public string Name { get; set; }
        public int slot_CPU { get; set; }
        public int slot_RAW { get; set; }
        public int max_RAW { get; set; }
        public int slot_video_card { get; set; }
        public int Price { get; set; }
     
    }
}
