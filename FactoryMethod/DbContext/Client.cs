
//using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Data.Entity;


namespace FactoryMethod
{
    [Table("Client")]
    public  class Client
    {
        [Key]
        public int IdClient { get; set; }
        public string Name { get; set; }
        public string password { get; set; }
        public string email { get; set; }
    }
}
