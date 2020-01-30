using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmartMvcCaseStudy.Models
{
    public class Category
    {
        [Key]
        public int CID { get; set; }
        public string CNAME { get; set; }
        public string ABOUTCATEGORY { get; set; }
    }
}
