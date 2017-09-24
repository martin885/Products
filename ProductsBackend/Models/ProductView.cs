using ProductsDomain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProductsBackend.Models
{
    [NotMapped]
    public class ProductView:Product
    {
        [Display(Name="Imagenes")]
        public HttpPostedFileBase ImageFile { get; set; }
    }
}