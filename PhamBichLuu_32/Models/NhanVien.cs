using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhamBichLuu_32.Models
{
    [Table("NhanViens")]
    public class NhanVien
    {
        [Key]
        public string MaNhanVien { get; set; }
        [AllowHtml]
        public string TenNhanVien { get; set; }
    }
}