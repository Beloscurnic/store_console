
//using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Data.Entity;

namespace FactoryMethod
{
    [Table("CPU")]
    public class CPU
    {
        [Key]
        public int IdDevice { get; set; }
        public string Name_fabrica { get; set; }
        public string Name { get; set; }
        public string Clock_frequency { get; set; }
        public int Kernels { get; set; }
        public int Price { get; set; }

    }
}
