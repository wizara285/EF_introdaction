using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_introdaction
{
    public class Order
    {
        [Key]
        public int Order_Id { get; set; }
        public string Item { get; set; }
        public int Amount { get; set; }
        public int Customer_Id { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
