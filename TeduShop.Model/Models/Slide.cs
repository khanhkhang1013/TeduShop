﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("Slides")]
  public  class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        public string Name { set;get;}
        [Required]
        public string Discription { set; get; }
        public string Image  { set; get; }
        public string URL { set; get; }
        public int? DisplayOrder { set; get; }
        public bool? Status { set; get; }


    }
}
