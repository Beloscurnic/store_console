
//using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Data.Entity;

namespace FactoryMethod
{
    [Table("Orders")]
   public class Orders
    {
        [Key]
        public int order { get; set; }
        public int IdDevice { get; set; }
        public int IdClient { get; set; }

        public int Price { get; set; }

        public virtual Client Client { get; set; }
       
        public virtual Сharacteristic Сharacteristic { get; set; }

    }
}
