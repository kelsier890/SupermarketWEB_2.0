﻿using System.ComponentModel.DataAnnotations.Schema;

namespace SupermarketWEB.Models
{
    public class Product
    {
        //[Key] -> Anotación si la propiedad no se llama Id, ejemplo Productid
        public int Id { get; set; }
        public string Name { get; set; }

        [Column(TypeName="decimal(6,2")]
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }//Será la llave foranea
        public Category Category { get; set; } //Propiedad de navegación
    }
}
