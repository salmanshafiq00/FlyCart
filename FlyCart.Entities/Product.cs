using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyCart.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        [ForeignKey("Catagory")]
        public int CatagoryID { get; set; }
        public virtual Catagory Catagory { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public virtual List<ProductOption> ProductOptions { get; set; }
        public decimal Price { get; set; }
        public decimal Weight { get; set; }
        public string Images { get; set; }
        public bool Stock { get; set; }
    }
}
