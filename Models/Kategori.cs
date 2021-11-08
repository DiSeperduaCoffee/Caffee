using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DiSeperduaCoffee.Models
{
    public class Kategori
    {
        public int Id { get; set; }
        public string Jenis { get; set; }
        public List<Kategori> Kategoris { get; set; }

    }
}