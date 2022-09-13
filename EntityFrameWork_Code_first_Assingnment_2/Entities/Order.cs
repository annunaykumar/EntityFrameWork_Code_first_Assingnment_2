using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameWork_Code_first_Assingnment_2.Entities
{
    [Table("Order")]
    internal class Order
    {
        [Key] //set primary key
        
        public int OrderId { get; set; }
        
        public DateTime OrderDate { get; set; }
        public int BookId { get; set; }
    }
}
