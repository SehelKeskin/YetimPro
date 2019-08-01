using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YetimPro.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage = "Lütfen Adınızı Giriniz.")]
        public string Ad { get; set; }


        [MaxLength(50)]
        [Required(ErrorMessage ="Lütfen Soyadınızı Giriniz.")]
        public string Soyad { get; set; }


        [MaxLength(50)]
        [Required(ErrorMessage ="Lütfen Telefon Numaranızı Giriniz.")]
        [Phone]
        public string Tel { get; set; }


        [MaxLength(50)]
        [Required(ErrorMessage ="Lütfen Email Adresinizi yazınız.")]
        [EmailAddress]
        public string Email { get; set; }


        [MaxLength(4050)]
        [Required(ErrorMessage ="Lütfen mesaj alanını doldurunuz.")]
        public string Mesaj { get; set; }
    }
}