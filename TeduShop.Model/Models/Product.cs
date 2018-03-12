using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TeduShop.Model.Models
{
    [Table("Products")]
   public class Product
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string Alias { set; get; }
        public string CategoryID { set; get; }
        public string Image { set; get; }
        public XElement MoreImages { set; get; }
        public decimal Price { set; get; }
        public decimal? PromotionPrice { set; get; }
        public int? Warranty { set; get; }
        public string Description { set; get; }
        public string Conten { set; get; }
        public bool HomeFlag { set; get; }
        public bool HotFlag { set; get; }
        public int ViewCoun { set; get; }
        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { set; get; }

    }
}
