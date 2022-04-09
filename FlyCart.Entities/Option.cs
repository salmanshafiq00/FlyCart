using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyCart.Entities
{
    public class Option
    {
        public int OptionID { get; set; }
        [ForeignKey("OptionGroup")]
        public int GroupID { get; set; }
        public virtual OptionGroup OptionGroup { get; set; }
        public string OptionName { get; set; }
    }
}
