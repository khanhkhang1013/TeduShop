using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
   [Table("ProductCategories")]
   public class ProductCategory
    {
        [Key]
        public int ID { set; get;}
        [Required]
        public string Name { set; get; }
        [Required]
        public string Alias { set; get; }
        public int ParentID { set; get; }
        public  int DislayOder { set; get; }
        public string Discriptint { set; get; }
        public string Image { set; get; }
        public string Metakeyword { set; get; }
        public string matadiscription { set; get; }
        public DateTime CreatedDate { set; get; }
        public DateTime CreatedBy { set; get; }
        public DateTime UpdatedDate { set; get; }
        public string UpdatedBy { set; get; }
        public bool Status { set; get; }
        public bool HomeFlag { set; get; }
        public virtual IEnumerable<Product> Products { set; get; }
       
    }   
}
