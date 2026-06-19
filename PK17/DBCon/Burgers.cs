using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using PK17.BuilderBurger;
using PK17.DBCon;

namespace PK17.DBCon
{
    public partial class Burgers
    {
        public int ID { get; set; }

        public bool? Cheese { get; set; }

        public bool? Bacon { get; set; }

        public bool? Letuce { get; set; }

        public bool? Tomato { get; set; }

        public bool? Pickles { get; set; }

        public Burgers()
        {
            Cheese = false;
            Bacon = false;
            Letuce = false;           
            Tomato = false;
            Pickles = false;
        }
    }    
}
