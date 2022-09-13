using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_Code_first_Assingnment_2.Entities
{
    [Table("Book")]
    internal class Book
    {
        [Key] //Identity applied with 1,1
        [ForeignKey("Order")]
        public int BookId { get; set; }
        [Required] //set not null
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string BookName { get; set; }
        public double? Price { get; set; } //null constraint applied
        [StringLength(35)]
        [Column(TypeName = "char")]
        public string Author { get; set; }


        public Order Order { get; set; } //Navigation property
    }
}
