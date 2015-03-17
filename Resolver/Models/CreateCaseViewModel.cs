using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using MongoDB.Bson;

namespace Resolver.Models
{
    public class CreateCaseViewModel
    {
        [ScaffoldColumn(false)]
        public virtual String caseManager { get; set; }

        [DataType(DataType.Text)]
        [Required]
        public virtual String caseTitle { get; set; }

        [DataType(DataType.MultilineText)]
        [UIHint("WYSIWYG")]
        [AllowHtml]
        [Required]
        public virtual String caseDescription { get; set; }
       
    }
}