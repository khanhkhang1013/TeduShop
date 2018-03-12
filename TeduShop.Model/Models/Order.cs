using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("Orders")]
   public  class Order
    {
        [Key]
        public int ID { set;get;}
        [Required]
        public string CustomerName { set; get; }
        [Required]
        public string CustomerAddress { set; get; }
        [Required]
        public string CustomerEmail { set; get; }
        [Required]
        public string CustomerMobile { set; get; }
        public string CustomerMessge { set; get; }
        public DateTime CrearedDate { set; get; }
        public string CreatedBy { set; get; }
        public string PaymentMethod { set;get;}
        public string PaymentStatus { set; get; }
        [Required]
        public bool Status { set; get; }
        
    }
}
