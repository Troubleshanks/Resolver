using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace Resolver.Models
{
    public class CreateThreadViewModel
    {

        [ScaffoldColumn(false)]
        [BsonId]
        public virtual ObjectId caseRecordNumber { get; set; }
        

        [DataType(DataType.Text)]
        [Required]
        public virtual String threadTitle { get; set; }

        [DataType(DataType.MultilineText)]
        [UIHint("WYSIWYG")]
        [AllowHtml]
        [Required]
        public virtual String postObject { get; set; }
       
    }
}