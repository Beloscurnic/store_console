
//using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Data.Entity;

namespace FactoryMethod
{
    [Table("Pre_order")]
    public class Pre_order
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Device_model { get; set; }

    }
}
