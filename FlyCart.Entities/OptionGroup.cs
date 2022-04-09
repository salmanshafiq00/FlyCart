using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyCart.Entities
{
    public class OptionGroup
    {
        public int OptionGroupID { get; set; }
        public string OptionGroupName { get; set; }
        [ForeignKey("ProductOption")]
        public int ProductOptionID { get; set; }
        public virtual ProductOption ProductOption { get; set; }
        public virtual List<Option> Options { get; set; }
    }
}
