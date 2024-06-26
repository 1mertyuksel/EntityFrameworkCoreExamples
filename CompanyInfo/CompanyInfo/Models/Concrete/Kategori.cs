﻿using CompanyInfo.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyInfo.Models.Concrete
{
    public class Kategori :BaseEntity
    {
       
        public string KategoriAdi { get; set; }
        public string? Aciklama { get; set; }
        public ICollection<Urun>  Urunler { get; set; } = new List<Urun>(); 
    }
}
