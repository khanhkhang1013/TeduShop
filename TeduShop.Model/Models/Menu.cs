﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{

    [Table("Menus")]
        public class Menu
    {
        [Key]
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string URL { set; get; }
        public int? DisplayOder { set; get; }
        [Required]
        public int GroupID { set; get; }
        [ForeignKey("GroupID")]
        public virtual MenuGruop MenuGroup { set; get; }
        public string Target { set; get; }
        [Required]
        public bool Status { set; get; }


    }
}
