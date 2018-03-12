using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{

    [Table("Posts")]
    public class Post
    {
        [Key]
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string Alias { set; get; }
        public int? CategoryID { set; get; }
        [Required]
        public string Image { set; get; }
        public string Content { set; get; }
        public string Description { set; get; }
        public bool? HomeFlag { set; get; }
        public bool? hotFlag { set; get; }
        public int? ViewCount { set; get; }
    }
}
