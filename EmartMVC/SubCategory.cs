using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmartMvcCaseStudy.Models
{
    public class SubCategory
    {
        [Key]
        public int SID { get; set; }
        public string SNAME { get; set; }
        public int CID { get; set; }
        public string ABOUTSUBCATEGORY { get; set; }
        public int GST { get; set; }
    }
}
