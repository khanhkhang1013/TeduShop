using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("PostCategories")]
    public class PostCategorie
    {
        [Key]
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string Alias { set; get; }
        [Key]
        public int ParentID { set; get; }
        public int? DislayOder { set; get; }
        public string Discriptint { set; get; }
        public string Image { set; get; }
        public string Metakeyword { set; get; }
        public string matadiscription { set; get; }
        public bool? Status { set; get; }
        public bool? HomeFlag { set; get; }


    }


}
