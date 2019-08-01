using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YetimPro.Models
{
    public class Comment
    {
        public int Id { get; set; }
        //[Required(ErrorMessage ="Lütfen Ad Alanına Adınızı Giriniz.")]
        public string Ad { get; set; }
       // [Required(ErrorMessage = "Lütfen Mesaj Alanına Mesajınızı Giriniz.")]
        public string Mesaj { get; set; }
        public DateTime Tarih { get; set; }
        public int? HaberId { get; set; }
        [ForeignKey("HaberId")]
        public virtual Haber Haber { get; set; }

    }
}