namespace EStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("History")]
    public partial class History
    {      
        public int ID { get; set; }

        public DateTime Date { get; set; }
        
        [Required]
        [StringLength(128)]
        public string product_name { get; set; }

        public decimal quantity { get; set; }
    }
}
