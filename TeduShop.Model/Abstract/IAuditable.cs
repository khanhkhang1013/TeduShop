using System;

namespace TeduShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { set; get; }
        string CreatedBy { set; get; }
        DateTime? UpdatedDate { set; get; }
        string UpdateBy { set; get; }
        string Metakeyword { set; get; }
        string MetaDescription { set; get; }
        bool Status { set; get;}
     
    }
}