namespace EStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CashboxState")]
    public partial class Cashbox
    {
        public long id { get; set; }

        public decimal amount_before { get; set; }

        public decimal amount_after { get; set; }

        public DateTime last_change_dttm { get; set; }

        public Cashbox()
        {

        }

        public Cashbox(decimal amt_before, decimal amt_after, DateTime dt)
        {
            amount_before = amt_before;
            amount_after = amt_after;
            last_change_dttm = dt;
        }
    }
}
