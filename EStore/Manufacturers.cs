namespace EStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Manufacturers
    {
        public int id { get; set; }

        [Required]
        [StringLength(128)]
        public string name { get; set; }

        public Manufacturers()
        {

        }

        public Manufacturers(string _name)
        {
            name = _name;
        }

    }
}
