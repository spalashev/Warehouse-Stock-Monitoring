namespace EStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Categories
    {
        public int id { get; set; }

        [Required]
        [StringLength(128)]
        public string category_name { get; set; }

        public Categories()
        {

        }

        public Categories(int _id, string _category_name)
        {
            id = _id;
            category_name = _category_name;
        }

        public Categories(string cat_name)
        {
            category_name = cat_name;
        }
    }
}
