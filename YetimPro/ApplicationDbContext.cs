using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using YetimPro.Models;

namespace YetimPro
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext() : base("name=DefaultConnection")
        {

        }
        public virtual DbSet<Contact> İletisims { get; set; }
        public virtual DbSet<BagisSinif> BagisSinif { get; set; }
        public virtual DbSet<Haber> Habers { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
    }
}