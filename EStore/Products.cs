namespace EStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products
    {
        public int id { get; set; }

        [Required]
        [StringLength(120)]
        public string product_name { get; set; }

        public long manufacturer_id { get; set; }

        [Required]
        [StringLength(100)]
        public string measuring_unit { get; set; }

        public int category_id { get; set; }

        public decimal price_charge { get; set; }

        public decimal price_sell { get; set; }
    }
}
