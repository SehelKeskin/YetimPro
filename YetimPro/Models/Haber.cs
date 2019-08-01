using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YetimPro.Models
{
    public class Haber
    {
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public string Foto { get; set; }
        public string Ad { get; set; }
        public string Baslik { get; set; }
        public string Gövde { get; set; }
        public string Sayfa { get; set; }
        public virtual ICollection<Comment> comments { get; set; }

    }
}