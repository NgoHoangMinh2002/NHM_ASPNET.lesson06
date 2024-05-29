using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NhmLesson06.Models
{
    public class NhmSong
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nhm: Hãy nhâp ứng viên")]
        [DisplayName("Tieu De")]
        public string NhmTitle { get; set; }
        [Required(ErrorMessage = "Nhm: Hay Nhap nhan vien")]
        [DisplayName("NV chinh")]
        public string NhmAuthor { get; set; }
        [Required(ErrorMessage = "Nhm: Hay Nhap ten")]
        [StringLength (50,MinimumLength =2,ErrorMessage ="Ten co toi thieu 2 ky tu,toi da 50 ky tu")]
        public string NhmArtist { get; set; }
        [Required(ErrorMessage = "Nhm: Hay Nhap Nguoi Dung")]
        [RegularExpression(@"[0-9][4]",ErrorMessage ="Nhm:Nhap xuat phai co 2 ky tu so")]
        [Range(1900,2004,ErrorMessage ="Nhm:Nam sinh trong khoang tu 1900-2004")]
        [DisplayName("Nam Sinh")]
        public int NhmYearRelease { get; set; }

    }
}