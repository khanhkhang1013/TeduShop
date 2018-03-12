using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abstract
{
    public class Auditable : IAuditable
    {
        [MaxLength(256)]
        public string CreatedBy { set; get; }
      
        [MaxLength(256)]
        public DateTime? CreatedDate { set; get; }        
        [MaxLength(256)]
        public string MetaDescription { set; get; }
        [MaxLength(256)]
        public string Metakeyword { set; get; }
        public bool Status { set; get; }
        [MaxLength(256)]
        public string UpdateBy { set; get; }
        public DateTime? UpdatedDate { set; get; }
        DateTime? IAuditable.CreatedDate { set; get; }

    }
}
