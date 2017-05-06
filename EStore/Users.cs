namespace EStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        public long id { get; set; }

        [StringLength(100)]
        public string username { get; set; }

        [StringLength(20)]
        public string password { get; set; }

        public int? privileges { get; set; }
    }
}
