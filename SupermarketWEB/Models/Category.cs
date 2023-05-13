﻿namespace SupermarketWEB.Models
{
    public class Category
    {
        public int Id { get; set; } //Seá la llave primaria 
        public string Name { get; set; }

        public string? Description { get; set; }
        public ICollection<Product> products { get; set; } //Propiedad de navegación
    }
}
