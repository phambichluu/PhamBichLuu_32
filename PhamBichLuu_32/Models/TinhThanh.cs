using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhamBichLuu_32.Models
{
    [Table("TinhThanhs")]
    public class TinhThanh
    {
        [Key]
        public int MaTinhThanh { get; set; }
        [AllowHtml]
        public string TenTinhThanh { get; set; }
    }
}