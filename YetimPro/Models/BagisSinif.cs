using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YetimPro.Models
{
    public class BagisSinif
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Lütfen Bağış Türünü Seçiniz.")]
        [Display(Name ="Bağış Türü")]
        public BTur? Tur { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage = "Ad alanı gereklidir")]
        [Display(Name ="Adınız")]
        public string Ad { get; set; }

        [MaxLength(50)]
        [Display(Name ="Soyadınız")]
        [Required(ErrorMessage = "Soyad alanı gereklidir")]
        public string Soyad { get; set; }

        [MaxLength(50)]
        [Display(Name ="Mail Adresiniz")]
        [Required(ErrorMessage = "Mail alanı gereklidir")]
        [EmailAddress]
        public string Mail { get; set; }

        [Phone]
        [Display(Name = "Telefonunuz")]
        public string Tel { get; set; }

        [Display(Name = "Mesajınız")]
        public string Mesaj { get; set; }

    }


    public enum BTur
    {
        Kurban,
        Nakit
    }
}