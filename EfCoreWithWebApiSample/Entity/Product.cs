using System;
using System.ComponentModel.DataAnnotations;

namespace WebApiWithRepositorySample.Entity
{
    public class Product: IEntity
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
        
    }
}
