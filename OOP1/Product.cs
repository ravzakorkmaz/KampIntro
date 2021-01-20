using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //Bu tip classlarda SADECE ÖZELLIK olur
    class Product //Entity
    {
        public int Id { get; set; }
        //Referans anahtar
        public int CategoryId { get; set; } 
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        //CRUD 
    }
}
