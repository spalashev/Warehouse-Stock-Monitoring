namespace EStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class StockQuantities
    {
        public long id { get; set; }

        public DateTime reference_date { get; set; }

        public long product_id { get; set; }

        public decimal quantity { get; set; }

        public StockQuantities()
        {

        }

        public StockQuantities(DateTime dt, long _product_id, decimal _quantity)
        {
            reference_date = dt;
            product_id = _product_id;
            quantity = _quantity;
        }
    }
}
