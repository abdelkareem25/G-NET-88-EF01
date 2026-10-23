using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace G_NET_88_EF01
{
    public class Inventory
    {
        public string Title { get; set; }
        [Key]
        public int ISBN { get; set; }
        public decimal Price { get; set; }
        public int NumberOfPages { get; set; }
        public DateTime YearPublished { get; set; }
        public bool InStock { get; set; }
    }
}
