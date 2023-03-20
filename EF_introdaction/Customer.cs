using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_introdaction
{
    public class Customer
    {
        [Key]
        public int Customer_Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public int? Age { get; set; }
        public string Country { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

    }
}
