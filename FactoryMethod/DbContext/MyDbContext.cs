
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace FactoryMethod
{
    public class MyDbContext : DbContext
    {
        private static MyDbContext instance;
        public MyDbContext(): base("DbConnectionString")
        {
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Fabrica> Fabricas { get; set; }
        public DbSet<Сharacteristic> Сharacteristics { get; set; }
        public DbSet<Orders> Orderss { get; set; }
        public DbSet<Сonnector> Сonnectors { get; set; }
        public DbSet<Motherboard> Motherboards { get; set; }
        public DbSet<CPU> CPUs { get; set; }
        public DbSet<RAW> RAWs { get; set; }
        public DbSet<Video_cart> Video_carts { get; set; }
        public DbSet<Pre_order> Pre_orders { get; set; }
        public static MyDbContext getInstance()
        {
            if (instance == null)
                instance = new MyDbContext();
            return instance;
        }
    }
}
