namespace EStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StockCharge")]
    public partial class StockCharge
    {
        public int ID { get; set; }

        public DateTime Date { get; set; }

        public long product_id { get; set; }

        public decimal quantity { get; set; }

        public StockCharge()
        {

        }

        public StockCharge(DateTime dt, long _product_id, decimal _quantity)
        {
            Date = dt;
            product_id = _product_id;
            quantity = _quantity;
        }
    }
}
