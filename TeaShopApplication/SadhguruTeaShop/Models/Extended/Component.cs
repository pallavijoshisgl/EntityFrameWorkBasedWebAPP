using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SadhguruTeaShop.Models
{
    [MetadataType(typeof(ComponentMetadata))]
    public partial class Component
    {


    }

    public class ComponentMetadata
    {

            [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide Name")]
            public string Name { get; set; }

            [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide Description")]
            public string Description { get; set; }

            [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide Price")]
            [RegularExpression("([0-9]+.)", ErrorMessage = "Please enter valid Number")]
            public double Price { get; set; }
    }
    
}